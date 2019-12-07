using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace final_assign
{
    public partial class Update_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //We only want to show the data when
            //the user visits the page for the first time
            //make sure to 
            if (!Page.IsPostBack)
            {
                //this connection instance is for showing data
                PageController controller = new PageController();
                ShowPageInfo(controller);
            }
        }

        protected void Update_page(object sender, EventArgs e)
        {

            //this connection instance is for editing data
            PageController controller = new PageController();

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                Pages new_page = new Pages();
                //set that student data
                new_page.SetPtitle(title.Text);
                new_page.SetPbody(body.Text);

                //add the student to the database
                try
                {
                    controller.UpdatePage(Int32.Parse(pageid), new_page);
                    Response.Redirect("Show_Page.aspx?pageid=" + pageid);
                }
                catch
                {
                    valid = false;
                }

            }

            if (!valid)
            {
                showerror.InnerHtml = "There was an error updating that student.";
            }

        }

        protected void ShowPageInfo(PageController controller)
        {

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            //We will attempt to get the record we need
            if (valid)
            {

                Pages page_record = controller.FindPage(Int32.Parse(pageid));
                title.Text = page_record.GetPtitle() + " " + page_record.GetPbody();
                body.Text = page_record.GetPbody();
            }

            if (!valid)
            {
                showerror.InnerHtml = "There was an error finding that page.";
            }
        }
    }
}
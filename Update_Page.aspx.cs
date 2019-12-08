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
            string Pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(Pageid)) valid = false;
            if (valid)
            {
                Pages new_page = new Pages();
                //set that page data
                new_page.SetPtitle(title.Text);
                new_page.SetPbody(body.Text);

                //add the page to the database
                try
                {
                    controller.UpdatePage(Int32.Parse(Pageid), new_page);
                    Response.Redirect("Show_Page.aspx?pageid=" + Pageid);
                }
                catch
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                showerror.InnerHtml = "There was an error updating that page.";
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
                title.Text = page_record.GetPtitle();
                body.Text = page_record.GetPbody();
            }

            if (!valid)
            {
                showerror.InnerHtml = "There was an error finding that page.";
            }
        }
        /* 
        Author: Christine ;
        Site: https://github.com/christinebittle/crud_essentials ;
        Date accessed: Dec 07 2019 ;
        Using purpose: to update table page information by user modification ;
        */
    }
}
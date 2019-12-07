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
    public partial class Delete_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // We only want to show the data when
            //the user visits the page for the first time
            //make sure to 
            if (!Page.IsPostBack)
            {
                //this connection instance is for showing data
                PageController controller = new PageController();
                //ShowPageInfo(controller);
            }
        }
        protected void Delete_page(object sender, EventArgs e)
        {
            //this connection instance is for editing data
            PageController controller = new PageController();

            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                //Pages new_page = new Pages();
                //set that student data
                //new_page.SetPtitle(title.Text);
                //new_page.SetPbody(body.Text);

                //add the student to the database
                try
                {
                    controller.DeletePage(Int32.Parse(pageid));
                    Response.Redirect("ShowPage.aspx?pageid=" + pageid);
                }
                catch
                {
                    valid = false;
                }
            }
        }
    }
}

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
    public partial class Show_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PageController controller = new PageController();
            //showing the base record student information
            ShowPageInfo(controller);
        }

            protected void Delete_page(object sender, EventArgs e)
            {
                bool valid = true;
                string pageid = Request.QueryString["pageid"];
                if (String.IsNullOrEmpty(pageid)) valid = false;

                PageController controller = new PageController();

                //deleting the student from the system
                if (valid)
                {
                    controller.DeletePage(Int32.Parse(pageid));
                    Response.Redirect("Show_Page.aspx");
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

                    ptitle.InnerHtml = page_record.GetPtitle();
                    pbody.InnerHtml = page_record.GetPbody();
            }
            else
            {
                valid = false;
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
        Using purpose: to show page record;
        */
    }
}
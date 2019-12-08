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
            PageController controller = new PageController();
            string pageid = Request.QueryString["pageid"];
            string pagetitle = Request.QueryString["pagetitle"];

            if (!Page.IsPostBack)
            {
                ShowConfirmation(pageid, pagetitle, controller);
            }
        }
        public void ShowConfirmation(string pageid, string pagetitle, PageController controller)
        {
            string query = "SELECT * FROM page WHERE pageid = {0}";
            query = String.Format(query, pageid, pagetitle);
            List<Dictionary<String, String>> rs = controller.List_Query(query);
            //first item (should only be one) is the record of enrolment between a page and a class
            Dictionary<String, String> pagerecord = rs.First();
            ptitle.InnerHtml = pagerecord["pagetitle"];
            
        }

        protected void Delete_page(object sender, EventArgs e)
        {
            //todo: validation on these ids
            string pageid = Request.QueryString["pageid"];
            string pagetitle = Request.QueryString["pagetitle"];

            PageController controller = new PageController();

            controller.DeletePage(Int32.Parse(pageid));
            Response.Redirect("Customer_Home.aspx");
        }
        /* 
        Author: Christine ;
        Site: https://github.com/christinebittle/crud_essentials ;
        Date accessed: Dec 07 2019 ;
        Using purpose: to delete table page information by user modification ;
        */
    }
}

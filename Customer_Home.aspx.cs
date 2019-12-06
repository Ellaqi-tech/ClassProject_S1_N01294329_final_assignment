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
    public partial class Customer_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   //reset the result set window:
            page_name.InnerHtml = "";
            //string searchkey = "";
            //if (Page.IsPostBack)
            //{
                //nothing, because no search function
            //}
            string query = "SELECT pagetitle FROM page";

            sql_debugger.InnerHtml = query;

            var db = new HTTP_Page();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String,String> row in rs)
            {
                //string Pageid = row["pageid"];
                string Pageid = row["pageid"];
                string Pagetitle = row["pagetitle"];
                page_name.InnerHtml += "<a href=\"Show_Page.aspx?pageid="+ Pageid + "\">" + Pagetitle + "</a>";
                //page_name.InnerHtml += "hello";
            }
        }
    }
}
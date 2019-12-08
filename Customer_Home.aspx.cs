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
            page_result.InnerHtml = "";

            string query = "SELECT pageid, pagetitle FROM page";

            sql_debugger.InnerHtml = query;

            var db = new HTTP_Page();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String,String> row in rs)
            {
                page_result.InnerHtml += "<div class=\"flex_container\">";

                string Pageid = row["pageid"];

                string Pagetitle = row["pagetitle"];

                page_result.InnerHtml += "<div class=\"left\"><a href=\"Show_Page.aspx?pageid=" + Pageid + "\">" + Pagetitle + "</a></div>";

                page_result.InnerHtml += "<div class=\"right\">" + "<a href =\"Update_Page.aspx?pageid=" + Pageid + "\">" + "Edit" + "</a>" + " " + " " + " " + "<a href =\"Delete_Page.aspx?pageid=" + Pageid + "\">" + "Delete" + "</a></div>";

                page_result.InnerHtml += "</div>";
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_assign
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //reset the result set window:
            //nav_li.InnerHtml = "";

            string query = "SELECT pageid, pagetitle FROM page LIMIT 5";

            //sql_debugger.InnerHtml = query;

            var db = new HTTP_Page();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                page_nav.InnerHtml += "<div class=\"navlist\">";

                string Pageid = row["pageid"];

                //string Pagetitle = row["pagetitle"];

                page_nav.InnerHtml += "<div class=\"navlist\"><a href=\"Show_Page.aspx?pageid=" + Pageid + "\">" + "Page " + Pageid + "</a></div>";

                page_nav.InnerHtml += "</div>";
            }
        }
    }
}
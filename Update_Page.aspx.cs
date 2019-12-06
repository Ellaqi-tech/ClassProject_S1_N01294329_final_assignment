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
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            //attempt to get the record we need
            if (valid)
            {
                var db = new HTTP_Page();
                Dictionary<String, String> page_record = db.FindPage(Int32.Parse(pageid));
                if (page_record.Count > 0)
                {
                    if (Page.IsPostBack)
                    {
                        string pagetitle = title.Text.ToString();
                        string pagebody = body.Text.ToString();
                        string query = "UPDATE page SET pagetitle ='" + pagetitle + "', pagebody ='" + pagebody + "'WHERE pageid =" + pageid;
                        var edit = new HTTP_Page();
                        int add = edit.Modify_Query(query);
                        Response.Redirect("~/Show_Page.aspx?pageid=" + pageid);
                    }
                    else
                    {
                        valid = false;
                    }
                    
                }
                     
            }
        }
    }
}
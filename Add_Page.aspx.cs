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
    public partial class Add_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_page(object sender, EventArgs e)
        {
            //create connection
            PageController db = new PageController();

            //create a new particular student
            Pages new_page = new Pages();
            //set that student data
            new_page.SetPtitle(title.Text);
            new_page.SetPbody(body.Text);

            //add the student to the database
            db.AddPage(new_page);

            Response.Redirect("Customer_Home.aspx");
        }
    }
}
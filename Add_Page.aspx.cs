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

            //create a new particular page
            Pages new_page = new Pages();
            //set that page data
            new_page.SetPtitle(title.Text);
            new_page.SetPbody(body.Text);

            //add the page to the database
            db.AddPage(new_page);

            Response.Redirect("Customer_Home.aspx");
        }
        /* 
        Author: Christine ;
        Site: https://github.com/christinebittle/crud_essentials ;
        Date accessed: Dec 06 2019 ;
        Using purpose: to add page information by user modification ;
        */
    }
}
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
            //ShowPageInfo(controller);
            //showing the classes the student is currently enrolled in
            //ListStudentEnrollment(controller);
            //populate the dropdownlist for classes for the student to pick
            /*if (!Page.IsPostBack)
            {
                FillClassOptions(controller);
            }*/

/*            protected void Delete_page(object sender, EventArgs e)
            {
                bool valid = true;
                string pageid = Request.QueryString["pageid"];
                if (String.IsNullOrEmpty(pageid)) valid = false;

                PageController controller = new PageController();

                //deleting the student from the system
                if (valid)
                {
                    controller.DeleteStudent(Int32.Parse(pageid));
                    Response.Redirect("ListStudents.aspx");
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
                    title.Text = page_record.GetPtitle() + " " + page_record.GetPbody();
                    body.Text = page_record.GetPbody();
                }

                if (!valid)
                {
                    showerror.InnerHtml = "There was an error finding that page.";
                }
            }*/


           
            
            
            //first try:
            /*//reset content
            title.InnerHtml = "";
            body.InnerHtml = "";
            // modification
            bool valid = true;
            string pageid = Request.QueryString["pageid"];

            if (String.IsNullOrEmpty(pageid)) valid = false;

            //attempt to get the page record
            if (valid)
            {
                var db = new HTTP_Page();
                Dictionary<String, String> page_record = db.FindPage(Int32.Parse(pageid));

                if (page_record.Count > 0)
                {
                    title.InnerHtml = page_record["pagetitle"];
                    body.InnerHtml = page_record["pagebody"];

                    //render loop for postback if user submit and user input valid
                    if (Page.IsPostBack)
                    {
                        string query = "SELECT * FROM page";

                        var pagedb = new HTTP_Page();
                        List<Dictionary<String, String>> rs = pagedb.List_Query(query);
                        foreach(Dictionary<String,String> row in rs)
                        {
                            string Pagetitle = row["pagetitle"];
                            string Pagebody = row["pagebody"];
                            title.InnerHtml += Pagetitle;
                            body.InnerHtml += Pagebody;
                        } 
                    }
                }
                else
                {
                    valid = false;
                }
            }*/
        }
    }
}
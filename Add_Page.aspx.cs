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
    public partial class add_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Student(object sender, EventArgs e)
        {
            

            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string SiteName = sitename.Text.ToString();
                    string H2 = h2.Text.ToString();
                    string query = "INSERT INTO page (pagetitle, pagebody) VALUES ('" + SiteName + "'," + H2 + ",')";
                    var db = new HTTP_Page();
                    int add = db.Modify_Query(query);
                    Response.Redirect("~/Customer_Home.aspx");
                }
            }
            //create connection
            //StudentController db = new StudentController();
            

            //create a new particular student
            /*    Student new_student = new Student();
                //set that student data
                new_student.SetFname(student_fname.Text);
                new_student.SetLname(student_lname.Text);
                new_student.SetNumber(student_number.Text);
                new_student.SetEnrolDate(DateTime.Now);

                //add the student to the database
                db.AddStudent(new_student);


                Response.Redirect("ListStudents.aspx");*/
        }
    }
}
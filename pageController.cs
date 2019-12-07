using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace final_assign
{
    public class pageController : HTTP_Page
    {
        public void AddPage(pages new_page)
        {
            //slightly better way of injecting data into strings

            string query = "insert into page (pagetitle, pagebody) values ('{a-z}','{a-z}')";
            query = String.Format(query, new_page.GetPtitle(), new_page.GetPbody());

            //This technique is still sensitive to SQL injection
            //

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }


        public void UpdatePage(int pageid, pages new_page)
        {
            //slightly better way of injecting data into strings
            //the below technique is known as string formatting. It allows us to make strings without "" + ""
            string query = "update page set pagetitle='{0}', pagebody='{1}'";
            query = String.Format(query, new_page.GetPtitle(), new_page.GetPbody(), pageid);
            //The above technique is still sensitive to SQL injection
            //we will learn about parameterized queries in the 2nd semester

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                //Try to update a student with the information provided to us.
                Connect.Open();
                cmd.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + query);
            }
            catch (Exception ex)
            {
                //If that doesn't seem to work, check Debug>Windows>Output for the below message
                Debug.WriteLine("Something went wrong in the UpdatePage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }

        public void DeletePage(int pageid)
        {
            //deleting a student will require us to modify two tables
            //one table is the studentsxclasses table (deleting where the studentid is specified)
            //one table is the students table (to delete the student)
            //Note: A MySQL trigger can be set up so that the appropriate studentsxclasses records are deleted
            //when the student is deleted. Currently this database isn't set up with a trigger

            //DELETING ON THE PRIMARY KEY OF STUDENTS
            string removepage = "delete from page where pageid = {0}";
            removepage = String.Format(removepage, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //This command removes all the target student's classes from the studentsxclasses table
            MySqlCommand cmd_removepage = new MySqlCommand(removepage, Connect);
            //This command removes the particular student from the table
            MySqlCommand cmd_removespage = new MySqlCommand(removepage, Connect);
            try
            {
                //try to execute both commands!
                Connect.Open();
                //remember to remove the relational element first
                cmd_removepage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepage);
                //then delete the main record
                cmd_removepage.ExecuteNonQuery();
                Debug.WriteLine("Executed query " + cmd_removepage);
            }
            catch (Exception ex)
            {
                //if this isn't working as intended, you can check debug>windows>output for the error message.
                Debug.WriteLine("Something went wrong in the delete Page Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
    }
}
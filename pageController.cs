using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace final_assign
{
    public class PageController : HTTP_Page
    {
        //The objective of this method in the schooldb class is to find a particular student given an integer ID
        //instead of returning a dictionary we will return type "STUDENT" in our Student.cs class
        public Pages FindPage(int id)
        {
            //Utilize the connection string
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //create a "blank" student so that our method can return something if we're not successful catching student data
            Pages result_page = new Pages();

            //we will try to grab student data from the database, if we fail, a message will appear in Debug>Windows>Output dialogue
            try
            {
                //Build a custom query with the id information provided
                string query = "SELECT * FROM page where pageid = " + id;
                Debug.WriteLine("Connection Initialized...");
                //open the db connection
                Connect.Open();
                //Run out query against the database
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                //Create a list of students (although we're only trying to get 1)
                List<Pages> pages = new List<Pages>();

                //read through the result set
                while (resultset.Read())
                {
                    //information that will store a single student
                    Pages currentpage = new Pages();

                    //Look at each column in the result set row, add both the column name and the column value to our Student dictionary
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        string key = resultset.GetName(i);
                        if (resultset.IsDBNull(i)) continue;
                        string value = resultset.GetString(i);
                        Debug.WriteLine("Attempting to transfer " + key + " data of " + value);
                        //can't just generically put data into a dictionary anymore
                        //must go through each column one by one to insert data into the right property
                        switch (key)
                        {
                            case "pagetitle":
                                currentpage.SetPtitle(value);
                                break;
                            case "pagebody":
                                currentpage.SetPbody(value);
                                break;
                        }

                    }
                    //Add the student to the list of students
                    pages.Add(currentpage);//????????????????????/what's pages for?
                }

                result_page = pages[0]; //get the first student

            }
            catch (Exception ex)
            {
                //If something (anything) goes wrong with the try{} block, this block will execute
                Debug.WriteLine("Something went wrong in the find Student method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return result_page;
        }




        public void AddPage(Pages new_page)
        {
            //slightly better way of injecting data into strings

            string query = "insert into page (pagetitle, pagebody) values ('{a-z}','{a-z}')";
            query = String.Format(query, new_page.GetPtitle(), new_page.GetPbody());

            //This technique is still sensitive to SQL injection

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


        public void UpdatePage(int pageid, Pages new_page)
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
            //slightly better way of injecting data into strings

            string query = "delete from page where pageid = {0}";
            query = String.Format(query, pageid);

            //This technique is still sensitive to SQL injection

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the DeletePage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
        /*public void DeletePage(int pageid)
        {
            //deleting a student will require us to modify two tables
            //one table is the studentsxclasses table (deleting where the studentid is specified)
            //one table is the students table (to delete the student)
            //Note: A MySQL trigger can be set up so that the appropriate studentsxclasses records are deleted
            //when the student is deleted. Currently this database isn't set up with a trigger

            //DELETING ON THE PRIMARY KEY OF STUDENTS
            string removepage = "delete from page where pageid = {0}";
            //removepage = String.Format(removepage, pageid);

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            //This command removes all the target student's classes from the studentsxclasses table
            //MySqlCommand cmd_removepage = new MySqlCommand(removepage, Connect);
            //This command removes the particular student from the table
            //MySqlCommand cmd_removespage = new MySqlCommand(removepage, Connect);
            try
            {
                //try to execute both commands!
                Connect.Open();
                //remember to remove the relational element first
                //cmd_removepage.ExecuteNonQuery();
                //Debug.WriteLine("Executed query " + cmd_removepage);
                //then delete the main record
                //cmd_removepage.ExecuteNonQuery();
                //Debug.WriteLine("Executed query " + cmd_removepage);
            }
            catch (Exception ex)
            {
                //if this isn't working as intended, you can check debug>windows>output for the error message.
                Debug.WriteLine("Something went wrong in the delete Page Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }*/
    }
}
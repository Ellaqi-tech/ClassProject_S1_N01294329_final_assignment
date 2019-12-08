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
    public class HTTP_Page
    {
        //access public database "ella" which created by ella
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "ella"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

        //connection string for connecting to database
        protected static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password =" + Password;
            }
        }
        // list a dictionary
        public List<Dictionary<String,String>> List_Query(string query)
        {
            MySqlConnection Connect = new  MySqlConnection(ConnectionString);

            List<Dictionary<String, String>> ResultSet = new List<Dictionary<string, string>>();

            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to excute query " + query);
                // open the database connecion:
                Connect.Open();
                // give the connection a query:
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                // grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();

                //for every row in the result set:
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<string, string>();
                    // for every column in the row
                    for(int i = 0; i<resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));
                    }
                    ResultSet.Add(Row);
                }//end row
                resultset.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());
            }
            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");
            return ResultSet;
        }
        /* 
        Author: Christine ;
        Site: https://github.com/christinebittle/crud_essentials ;
        Date accessed: Dec 07 2019 ;
        Using purpose: set page class;
        */
    }
}
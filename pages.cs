using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace final_assign
{
    public class Pages
    {
        /*
         These fields are private cannot be accessed normally
         will NOT be able to 
            set like Student.Fname = "Christine"
            get like Student.Fname ==> returns "Christine"
         */
        private string Pid;
        private string Ptitle;
        private string Pbody;

        /*
         we can build special methods which get and set values for our class
         the methods are public, but the fields themselves are private.
         this technique is known as "encapsulation"
        */

        //methods which return the private content requested
        //if we want the firstname we use
        //student.GetFname(); ==> returns "Christine"
        public string GetPid()
        {
            return Pid;
        }
        public string GetPtitle()
        {
            return Ptitle;
        }
        public string GetPbody()
        {
            return Pbody;
        }
        //These methods are used to set values in an object
        //i.e. if I want to change the last name to Bittle
        //student.SetLname("Bittle")
        public void SetPid(string value)
        {
            Pid = value;
        }
        public void SetPtitle(string value)
        {
            Ptitle = value;
        }
        public void SetPbody(string value)
        {
            Pbody = value;
        }
        /* 
        Author: Christine ;
        Site: https://github.com/christinebittle/crud_essentials ;
        Date accessed: Dec 05 2019 ;
        Using purpose: to set and get page table values;
        */
    }
}
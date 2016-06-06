using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// using statements that are required to connect to EF DB
using COMP2007_S2016_Lesson4.Models;
using System.Web.ModelBinding;


namespace COMP2007_S2016_Lesson4
{
    public partial class About1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading the page for the first time, populate the student grid
            if(!IsPostBack)
            {
                //get the student data
                this.GetStudents();
            }
        }
        
        /**
         *<summary>
         * This method gets the students data from the DB
         *</summary>
         * 
         * @method GetStudents
         * @returns {void}
         */
        protected void GetStudents()
        {
            // connect to EF
            using (DefaultConnectionYd db = new DefaultConnectionYd())
            {
                // query the Students Table using EF and LINQ
                var Students = (from allStudents in db.Students
                                select allStudents);
                //bind the result to the GridView
                StudentsGridView.DataSource = Students.ToList();
                StudentsGridView.DataBind();

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Use statements required for EF DB access
using COMP2007_S2016_Lesson4.Models;
using System.Web.ModelBinding;

namespace COMP2007_S2016_Lesson4
{
    public partial class GameDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            // Redirect back to Students page
            Response.Redirect("~/Game.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to connect to the server
            using (DefaultConnectionYd db = new DefaultConnectionYd())
            {
                //use the Student model to create a new student object and
                //save a new record
                Game newStudent = new Game();

                //add form data to the new student record
                

                //use LINQ to ADO.NET to add / insert new student into the database
                //db.Students.Add(newGame);

                //save our changes
                db.SaveChanges();

                //redirect back to the updated Student page
                Response.Redirect("~/Game.aspx");
            }
        }
    }
}
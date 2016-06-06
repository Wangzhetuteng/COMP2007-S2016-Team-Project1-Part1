/*
 *@author: Yandong Wang
 *@date: June 5, 2016
 *@version: 0.0.2 - updated SetActivePage Method to include new links
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/** This methods adds the active class to each li in the
  * main navbar according to the page title.
  * 
  * @method AddActiveClass
  * @return {string}
  */

namespace COMP2007_S2016_Lesson4
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
        }

        /**
        * This methods adds the active class to each li in the
        * main navbar according to the page title.
        * 
        * @method AddActiveClass
        * @return {string}
        */

        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Students":
                    students.Attributes.Add("class", "active");
                    break;
                case "Courses":
                    courses.Attributes.Add("class", "active");
                    break;
                case "Departments":
                    departments.Attributes.Add("class", "active");
                    break;
                case "Contact":
                    contact.Attributes.Add("class", "active");
                    break;
            }
            /*return Page.Title;*/
        }
    }
}
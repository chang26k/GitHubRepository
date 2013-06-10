using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWebSite.App_Code;

namespace MyWebSite.Weekly.Week1
{
    public partial class Romannumeral : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int input;

            if (int.TryParse(txtNumber.Text, out input) && input < 5000)
            {
                App_Code.RomanNumeral oLogic = new App_Code.RomanNumeral();
                lblAnswer.Text = oLogic.ProcessNumber(input);
            }
            else
            {
                lblAnswer.Text = "Invalid input.  Please input a number between 1 - 5000";
            }                 
        }


    }
}
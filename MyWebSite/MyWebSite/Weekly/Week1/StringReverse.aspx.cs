using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyWebSite.App_Code;

namespace MyWebSite.Weekly.Week1
{
    public partial class StringReverse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblForAnswer.Visible = false;
            lblAnswer.Visible = false;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {            
            App_Code.StringReverse oReverse = new App_Code.StringReverse();
            lblAnswer.Text = oReverse.Process(txtInput.Text);
            lblAnswer.Visible = true;
            lblForAnswer.Visible = true;
        }
    }
}
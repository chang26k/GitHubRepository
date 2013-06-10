using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace MyWebSite.Weekly.Week1
{
    public partial class ThreeWay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadBool();
            LightLogic();
        }

        private void LoadBool()
        {
            if (Cache["bool1"] != null)
            {
                bool1 = (Boolean)Cache["bool1"];
            }
            if (Cache["bool2"] != null)
            {
                bool2 = (Boolean)Cache["bool2"];
            }
        }        

        Boolean bool2;
        Boolean bool1;

        protected void btn2_Click(object sender, EventArgs e)
        {
            ReverseBool(ref bool2);
            LightLogic();
            StoreBool();
        }

        private void StoreBool()
        {
            Cache["bool1"] = bool1;
            Cache["bool2"] = bool2;
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            ReverseBool(ref bool1);
            LightLogic();
            StoreBool();
        }

        protected void ReverseBool(ref Boolean tbool)
        {
            if (tbool == true)
            {
                tbool = false;
            }
            else
            {
                tbool = true;
            }
           
        }

        protected void LightLogic()
        {
            if (bool1 == bool2)
            {
                lblLight.Text = "ON";
                lblLight.BackColor = Color.Yellow; 
            }
            else
            {
                lblLight.Text = "OFF";
                lblLight.BackColor = Color.Gray;
            }
        }
    }
}
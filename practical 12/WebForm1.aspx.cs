using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical_12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void EnableDisable(object sender, EventArgs e)
        {
            if (TextBox1.Enabled == true)
            {
                TextBox1.Enabled = false;
            }
            else
            {
                TextBox1.Enabled = true;
            }

        }
        protected void changeWidth(object sender, EventArgs e)
        {
            TextBox2.Width = Convert.ToInt32(TextBox2.Text);
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical_10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        protected void logIn(object sender, EventArgs e) {

            string username = TextBox1.Text;
            string password = TextBox2.Text;
            string queryString = "username="+username+"&password="+password;

            if (username != "" && password != "")
            {
                Response.Redirect("WebForm2.aspx?" + queryString);

            }
            else {
                Response.Redirect("WebForm2.aspx") ;
            
            }
        }
    }
}
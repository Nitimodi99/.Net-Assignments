﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical_13
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void submit(object sender, EventArgs e)
        {
            Session["Name"] = name.Text;
            Session["Mobile"] = mobileNo.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo_RedisCacheSessionStateProvider
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPut_Click(object sender, EventArgs e)
        {
            Session["ModuleName"] = txtinput.Text;
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            if (Session["ModuleName"] != null)
                txtoutput.Text = Session["ModuleName"].ToString();
        }
    }
}
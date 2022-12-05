using eVent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eVent
{
    public partial class ONama : Localization
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] == null || (bool)Session["loggedIn"] != true)
            {
                Response.Redirect("Login.aspx");
            }

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["loggedIn"] = null;
            Response.Redirect("PocetnaStrana.aspx");
        }
    }
}
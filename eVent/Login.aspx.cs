using eVent.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using eVent.Models;

namespace eVent
{
    public partial class Login : Localization
    {
        private readonly IRepository repo = RepositoryFactory.GetRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (Session["loggedIn"] != null && (bool)Session["loggedIn"] == true)
            {
                Response.Redirect("PocetnaStrana.aspx");
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = repo.checkUser(txtEmail.Text, txtPassword.Text);
                if (userId != -1)
                {
                    FormsAuthentication.RedirectFromLoginPage(txtEmail.Text, false);
                    Session["loggedIn"] = true;
                    Session["loggedInUserID"] = userId;
                    Response.Redirect("PocetnaStrana.aspx"); 
                }
                else
                {
                    lblError.Text = "Prijava nije uspjela. Pokušajte ponovno.";
                    lblError.Visible = true;
                }
            }
            catch (Exception)
            {
                lblError.Text = "Pristup bazi nije moguć. Molimo pokušajte ponovno.";
                lblError.Visible = true;
            }
        }
    }
}
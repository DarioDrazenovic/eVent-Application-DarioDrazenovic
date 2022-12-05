using eVent.Dal;
using eVent.Models;
using eVent_Web_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eVent
{
    public partial class Register : Localization
    {
        private readonly IRepository repo = RepositoryFactory.GetRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null && (bool)Session["loggedIn"] == true)
            {
                Response.Redirect("PocetnaStrana.aspx");
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    Email = txtEmail.Text,
                    Ime = txtFirstName.Text,
                    Prezime = txtLastName.Text,
                    Lozinka = txtPassword.Text,
                };

                user.IDUser = repo.InsertKorisnik(user);

                if (user.IDUser == -1)
                {
                    valEmailExists.IsValid = false;
                }
                else
                {
                    Response.Redirect("Login.aspx");
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
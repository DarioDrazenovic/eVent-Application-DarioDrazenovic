using eVent.Dal;
using eVent.Models;
using eVent_Web_Service.Models;
using System;
using System.Data.SqlClient;

namespace eVent
{
    public partial class KorisnickePostavke : Localization
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("server=oicarserver.database.windows.net; database=eVent;Uid=oicartim15@oicarserver;Pwd=eVent123");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] == null || (bool)Session["loggedIn"] != true)
            {
                Response.Redirect("Login.aspx");
            }

            var korisnici = RepositoryFactory.GetRepository().GetKorisici();
            foreach (var k in korisnici)
            {
                if (k.IDUser.ToString() == Session["loggedInUserID"].ToString())
                {
                    txtEmail.Text = k.Email;
                }
            }

        }


        protected void btnPwd_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != txtConPass.Text)
            {
                Label1.Text = "'Nova zaporka' i 'ponovljena zaporka' moraju biti iste!";
                return;
            }

            if (RepositoryFactory.GetRepository().checkUser(txtEmail.Text, txtOldPass.Text) == -1)
            {
                Label1.Text = "Stara lozinka je pogrešna!";
                return;
            }

            User korisnik = null;

            foreach (var user in RepositoryFactory.GetRepository().GetKorisici())
            {
                if (user.IDUser == int.Parse(Session["loggedInUserID"].ToString()))
                {
                    korisnik = user;
                }
            };

            korisnik.Lozinka = txtNewPass.Text;

            try
            {
                RepositoryFactory.GetRepository().UpdateKorisnik(korisnik);
                Label1.Text = "Uspješno promjenjeno!";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                lblError.Text = "Pristup bazi nije moguć. Molimo pokušajte ponovno.";
                lblError.Visible = true;
            }
        }
        protected void btnGup_Click(object sender, EventArgs e)
        {
            Response.Redirect("PocetnaStrana.aspx");
        }
    }
     
    }

       
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
    public partial class MojiDogadaji : Localization
    {
        private bool nemaDogadaja = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] == null || (bool)Session["loggedIn"] != true)
            {
                Response.Redirect("Login.aspx");
            }

            IEnumerable<Dogadaj> svi_dogadaji = RepositoryFactory.GetRepository().GetDogadaji();
            foreach (var item in svi_dogadaji)
            {
                if (item.OrganizatorID == int.Parse(Session["loggedInUserID"].ToString()))
                {
                    nemaDogadaja = false;
                    //<hr> ne radi zbog nekog razloga
                    gv_dogadaji.Controls.Add(new Label() { Text = "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> NAZIV: " + item.Naziv + "</div>"});
                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>OPIS: " + item.Opis + "</div>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'><a class='btn btn-primary btn-sm' style='margin:15px 5px 0 0' href='UredivanjeDogadaja.aspx?id=" + item.IDDogadaj + "'>UREDI</a>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<a class='btn btn-danger btn-sm' style='margin:15px 0 0 5px' href='BrisanjeDogadaja.aspx?id=" + item.IDDogadaj + "'>OBRIŠI</a></div>" });

                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    gv_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                }
            }

            if (nemaDogadaja)
            {
                lbl_nemaDogadaja.Visible = true;
            }

        }

        protected void Kreiraj_click(object sender, EventArgs e)
        {
            Response.Redirect("KreirajDogadaj.aspx");
        }
    }
}
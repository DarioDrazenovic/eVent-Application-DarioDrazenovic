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
    public partial class PocetnaStrana : Localization
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null && (bool)Session["loggedIn"] == true)
            {
                navKorPos.Visible = true;
                btnLogout.Visible = true;

                navLogin.Visible = false;
                navRegister.Visible = false;
            }


            String tekstPretrage = Request.QueryString["tekst"] == null ? "" : Request.QueryString["tekst"];

            IEnumerable<Dogadaj> svi_dogadaji = RepositoryFactory.GetRepository().GetDogadaji();
            IEnumerable<Slika> sve_slike = RepositoryFactory.GetRepository().GetSlike();
            foreach (var item in svi_dogadaji)
            {
                String slika = "";
                foreach (var s in sve_slike)
                {
                    if (s.DogadajID == item.IDDogadaj)
                    {
                        slika = "<img width='300' height='300' src='data: image/jpeg; base64," + s.SlikaPodaci + "'/>";
                        break;
                    }
                }

                if (item.Naziv.Contains(tekstPretrage)
                    || item.Opis.Contains(tekstPretrage))
                {
                    panel_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div class='card bg-light' style='box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2); transition: 0.3s; border-radius: 5px; margin-right: 600px; margin-left: 600px;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div class='card-body'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div class='container' style='padding: 40px 50px;'>" });

                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding-top:2px; padding-left:1px; padding-right:1px; padding-bottom:10px; Font-size: medium;'>NAZIV: " + item.Naziv + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>OPIS: " + item.Opis + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>BROJ DOLAZAKA: " + item.BrojDolazaka + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>CIJENA: " + item.Cijena + " kn" + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>LOKACIJA: " + item.Lokacija + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>DATUM POCETKA: " + DateTime.FromBinary(item.Pocetak).ToShortDateString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>DATUM ZAVRSETKA: " + DateTime.FromBinary(item.Zavrsetak).ToShortDateString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>VRIJEME POCETKA: " + DateTime.FromBinary(item.Pocetak).ToShortTimeString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>VRIJEME ZAVRSETKA: " + DateTime.FromBinary(item.Zavrsetak).ToShortTimeString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>PRVA SLIKA: <br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'>" + slika + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding-top:2px; padding-left:1px; padding-right:1px; padding-bottom:10px; Font-size: medium;'>DETALJI: <a href='PrikazDogadaja.aspx?id=" + item.IDDogadaj + "'>Prikaz</a>" + "<br></div>" });
                    
                    panel_dogadaji.Controls.Add(new Label() { Text = "</div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</div>" });

                    panel_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<br>" });
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["loggedIn"] = null;
            Response.Redirect("PocetnaStrana.aspx");
        }

        private long getLongFromDateTime(string datum, string vrijeme)
        {
            String[] datumPodaci = datum.Split('.');
            DateTime dt = new DateTime(int.Parse(datumPodaci[2]), int.Parse(datumPodaci[1]), int.Parse(datumPodaci[0]));

            String[] vrijemePodaci = vrijeme.Split(':');
            dt.AddHours(int.Parse(vrijemePodaci[0]));
            dt.AddMinutes(int.Parse(vrijemePodaci[1]));

            return dt.Ticks;
        }

        protected void btn_trazi_Click(object sender, EventArgs e)
        {
            String tekstPretrage = tb_trazilica.Text;
            Response.Redirect("PocetnaStrana.aspx?tekst=" + tekstPretrage);

        }
    }
}
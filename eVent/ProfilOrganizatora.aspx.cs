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
    public partial class ProfilOrganizatora : Localization
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int korisnikId = int.Parse(Request.QueryString["id"]);
            int prijavljeniKorisnikID = int.Parse(Session["loggedInUserID"].ToString());

            IEnumerable<User> svi_korisnici = RepositoryFactory.GetRepository().GetKorisici();
            IEnumerable<Dogadaj> svi_dogadaji = RepositoryFactory.GetRepository().GetDogadaji();
            IEnumerable<Slika> sve_slike = RepositoryFactory.GetRepository().GetSlike();

            foreach (var k in svi_korisnici)
            {
                if (k.IDUser == prijavljeniKorisnikID && k.Admin)
                {
                    panel.Controls.Add(
                        new Label()
                        {
                            Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'><a href = 'obrisiKorisnika.aspx?id=" + korisnikId + "'>Obriši</a><br></div>"
                        });
                }
            }


            foreach (var korisnik in svi_korisnici)
            {
                if (korisnik.IDUser == korisnikId)
                {
                    panel.Controls.Add(new Label() { Text = "<br>" });
                    panel.Controls.Add(new Label() { Text = "<div class='card' style='box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2); transition: 0.3s; border-radius: 5px; margin-right: 700px; margin-left: 700px;'>" });
                    panel.Controls.Add(new Label() { Text = "<div class='card-body'>" });
                    panel.Controls.Add(new Label() { Text = "<div class='container' style='padding: 40px 50px;'>" });

                    panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> EMAIL: " + korisnik.Email + "<br></div>" });
                    panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> IME: " + korisnik.Ime + "<br></div>" });
                    panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> PREZIME: " + korisnik.Prezime + "<br><br><br></div>" });

                    panel.Controls.Add(new Label() { Text = "</div>" });
                    panel.Controls.Add(new Label() { Text = "</div>" });
                    panel.Controls.Add(new Label() { Text = "</div>" });
                    panel.Controls.Add(new Label() { Text = "<br>" });
                    panel.Controls.Add(new Label() { Text = "<br>" });
                    panel.Controls.Add(new Label() { Text = "<br>" });
                    break;
                }
            }


            foreach (var item in svi_dogadaji)
            {
                if (item.OrganizatorID == korisnikId)
                {

                String slika = "";
                foreach (var s in sve_slike)
                {
                    if (s.DogadajID == item.IDDogadaj)
                    {
                        slika = s.SlikaPodaci;
                        break;
                    }
                }
                panel.Controls.Add(new Label() { Text = "<br>" });
                panel.Controls.Add(new Label() { Text = "<div class='card bg-light' style='box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2); transition: 0.3s; border-radius: 5px; margin-right: 600px; margin-left: 600px;'>" });
                panel.Controls.Add(new Label() { Text = "<div class='card-body'>" });
                panel.Controls.Add(new Label() { Text = "<div class='container' style='padding: 40px 50px;'>" });

                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> NAZIV: " + item.Naziv + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> OPIS: " + item.Opis + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> BROJ DOLAZAKA: " + item.BrojDolazaka + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> CIJENA: " + item.Cijena + " kn" + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> LOKACIJA: " + item.Lokacija + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> DATUM POCETKA: " + DateTime.FromBinary(item.Pocetak).ToShortDateString() + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> DATUM ZAVRSETKA: " + DateTime.FromBinary(item.Zavrsetak).ToShortDateString() + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> VRIJEME POCETKA: " + DateTime.FromBinary(item.Pocetak).ToShortTimeString() + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> VRIJEME ZAVRSETKA: " + DateTime.FromBinary(item.Zavrsetak).ToShortTimeString() + "<br></div>" });
                panel.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:1px; Font-size: medium;'> DETALJI: <a href='PrikazDogadaja.aspx?id=" + item.IDDogadaj + "'>Prikaz</a>" + "<br></div>" });

                panel.Controls.Add(new Label() { Text = "</div>" });
                panel.Controls.Add(new Label() { Text = "</div>" });
                panel.Controls.Add(new Label() { Text = "</div>" });

                panel.Controls.Add(new Label() { Text = "<br>" });
                panel.Controls.Add(new Label() { Text = "<br>" });
                panel.Controls.Add(new Label() { Text = "<br>" });
                }
            }
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("PocetnaStrana.aspx");
        }
    }
}
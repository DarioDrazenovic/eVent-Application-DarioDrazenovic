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
    public partial class PrikazDogadaja : Localization
    {
        bool vecDolazim = false;
        bool adminIsLoggedIn = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            int dogadajId = int.Parse(Request.QueryString["id"]);
            int korisnikId = Session["loggedInUserID"] == null ? -1 : int.Parse(Session["loggedInUserID"].ToString());

            IEnumerable<Dogadaj> svi_dogadaji = RepositoryFactory.GetRepository().GetDogadaji();
            IEnumerable<Slika> sve_slike = RepositoryFactory.GetRepository().GetSlike();
            IEnumerable<Komentar> svi_komentari = RepositoryFactory.GetRepository().GetKomentari();
            IEnumerable<DolazakNaDogadaj> svi_dolasci = RepositoryFactory.GetRepository().GetDolasci();
            IEnumerable<User> svi_korisnici = RepositoryFactory.GetRepository().GetKorisici();

            foreach (var dolazak in svi_dolasci)
            {
                if (dolazak.DogadajID == dogadajId && dolazak.KorisnikID == korisnikId)
                {
                    vecDolazim = true;
                    break;
                }
            }
            foreach (var k in svi_korisnici)
            {
                if (k.IDUser == korisnikId && k.Admin)
                {
                    adminIsLoggedIn = true;
                }
            }

            if (adminIsLoggedIn)
            {
                panel_dogadaji.Controls.Add(
                        new Label()
                        {
                            Text = "<a href = 'BrisanjeDogadaja.aspx?id=" + dogadajId + "'>Obriši</a><br>"
                        });
            }

            foreach (var item in svi_dogadaji)
            {
                if (item.IDDogadaj == dogadajId)
                {

                    panel_dogadaji.Controls.Add(new Label() { Text = "<div class='container' style='padding: 40px 50px;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<table style='border: 1px solid black;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<tr style='border: 1px solid black;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<td style='border: 1px solid black;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:2px; Font-size: medium;'>BROJ DOLAZAKA: " + item.BrojDolazaka + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</td>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<td style='border: 1px solid black;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:2px; Font-size: medium;'>NAZIV: " + item.Naziv + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</td>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</tr>" });

                    panel_dogadaji.Controls.Add(new Label() { Text = "<tr style='border: 1px solid black;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<td style='border: 1px solid black;'>" });

                    int slikaCounter = 1;
                    foreach (var s in sve_slike)
                    {
                        if (s.DogadajID == item.IDDogadaj)
                        {
                            panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:2px; Font-size: medium;'>SLIKA " + slikaCounter + ": </div>" + "<img width='300' height='300' src='data: image/jpeg; base64," + s.SlikaPodaci + "'/>" + "<br>" });
                        }
                    }

                    panel_dogadaji.Controls.Add(new Label() { Text = "</td>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<td style='border: 1px solid black;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>OPIS: " + item.Opis + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>CIJENA: " + item.Cijena + " kn" + "<br></div>" });

                    foreach (var k in svi_korisnici)
                    {
                        if (k.IDUser == item.OrganizatorID)
                        {
                            panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>ORGANIZATOR: <a style='text-decoration:none; font-weight:bold;' href='ProfilOrganizatora?id=" + item.OrganizatorID + "'>" + " " + k.Ime + " " + k.Prezime + "</a><br></div>" });
                        }
                    }

                    panel_dogadaji.Controls.Add(new Label() { Text = "</td>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<td style='border: 1px solid black;'>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>LOKACIJA: " + item.Lokacija + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>DATUM POCETKA: " + DateTime.FromBinary(item.Pocetak).ToShortDateString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>DATUM ZAVRSETKA: " + DateTime.FromBinary(item.Zavrsetak).ToShortDateString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>VRIJEME POCETKA: " + DateTime.FromBinary(item.Pocetak).ToShortTimeString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='display:flex; align-items:center; justify-content:center; padding:8px; Font-size: medium;'>VRIJEME ZAVRSETKA: " + DateTime.FromBinary(item.Zavrsetak).ToShortTimeString() + "<br></div>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</td>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</tr>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</table>" });


                    panel_dogadaji.Controls.Add(new Label() { Text = "<table>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<tr>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "<td>" });


                    panel_dogadaji.Controls.Add(new Label() { Text = "<div style='padding:8px; Font-size: medium;'><br><br>" + "KOMENTARI" + "<br><br></div>" });
                    foreach (var k in svi_komentari)
                    {
                        if (k.DogadajID == item.IDDogadaj)
                        {
                            String obrisiKomentar = "";
                            if (k.AutorID == korisnikId || adminIsLoggedIn)
                            {
                                obrisiKomentar = "<a style='padding:8px; Font-size: medium;' href='obrisiKomentar.aspx?id=" + k.IDKomentar + "'>Obriši</a><br>";
                            }

                            panel_dogadaji.Controls.Add(new Label()
                            {
                                Text = "<div style='padding:8px; Font-size: medium;'><br><br>" + RepositoryFactory.GetRepository().getKorisnik(k.AutorID)
                                + "<br>" + DateTime.FromBinary(k.Vrijeme).ToShortDateString() + " - " + DateTime.FromBinary(k.Vrijeme).ToShortTimeString()
                                + "<br><br>" + k.KomentarPodaci + " <br></div>" + obrisiKomentar
                            });
                        }
                    }
                    panel_dogadaji.Controls.Add(new Label() { Text = "</td>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</tr>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</table>" });
                    panel_dogadaji.Controls.Add(new Label() { Text = "</div>" });
                }
            }
        }

        protected void btn_komentiraj_Click(object sender, EventArgs e)
        {
            RepositoryFactory.GetRepository().InsertKomentar(
                new Komentar()
                {
                    AutorID = int.Parse(Session["loggedInUserID"].ToString()),
                    DogadajID = int.Parse(Request.QueryString["id"]),
                    KomentarPodaci = tb_komentar.Text,
                    Vrijeme = DateTime.Now.Millisecond
                }
                );
            Response.Redirect("PrikazDogadaja.aspx?id=" + int.Parse(Request.QueryString["id"]));

        }

        protected void btn_dolazim_Click(object sender, EventArgs e)
        {
            if (vecDolazim)
            {
                RepositoryFactory.GetRepository().DeleteDolazak(
                  new DolazakNaDogadaj()
                  {
                      DogadajID = int.Parse(Request.QueryString["id"]),
                      KorisnikID = int.Parse(Session["loggedInUserID"].ToString())
                  }
                  );
                btn_dolazim.Text = "Dolazim!";

            }else
            {
                RepositoryFactory.GetRepository().InsertDolazak(
                    new DolazakNaDogadaj()
                    {
                        DogadajID = int.Parse(Request.QueryString["id"]),
                        KorisnikID = int.Parse(Session["loggedInUserID"].ToString())
                    }
                    );
                btn_dolazim.Text = "Ne dolazim :(";
            }
        }
    }
}
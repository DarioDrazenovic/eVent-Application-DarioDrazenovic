using eVent.Dal;
using eVent.Models;
using eVent_Web_Service.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eVent
{
    public partial class UredivanjeDogadaja : Localization
    {
        private int dogadajId = -1;
        private int brojDolazaka = -1;
        protected void Page_Load(object sender, EventArgs e)
        {
            var dogadaji = RepositoryFactory.GetRepository().GetDogadaji();
            var slike = RepositoryFactory.GetRepository().GetSlike();
            try
            {
                dogadajId = int.Parse(Request.QueryString["id"].ToString());
            }
            catch
            {
                Response.Redirect("MojiDogadaji.aspx");
            }

            foreach (var dogadaj in dogadaji)
            {
                if (dogadaj.IDDogadaj == dogadajId)
                {
                    txtUrediNaziv.Text = dogadaj.Naziv;
                    txtOpis.Text = dogadaj.Opis;
                    txtTip.Text = dogadaj.TipDogadaja;
                    txtCijena.Text = dogadaj.Cijena.ToString();
                    txtLokacija.Text = dogadaj.Lokacija;
                    txtDatumPocetak.Text = DateTime.FromBinary(dogadaj.Pocetak).ToShortDateString();
                    txtDatumZavrsetak.Text = DateTime.FromBinary(dogadaj.Zavrsetak).ToShortDateString();
                    txtVrijemePocetak.Text = DateTime.FromBinary(dogadaj.Pocetak).ToShortTimeString();
                    txtVrijemeZavrsetak.Text = DateTime.FromBinary(dogadaj.Zavrsetak).ToShortTimeString();
                    brojDolazaka = dogadaj.BrojDolazaka;

                    foreach (var s in slike)
                    {
                        if (s.DogadajID == dogadaj.IDDogadaj)
                        {
                            panel_slike.Controls.Add(new Label() { Text = "<img width='300' height='300' src='data: image/jpeg; base64," + s.SlikaPodaci + "'/>" + "<br>" });
                        }
                    }
                }
            }
                       
        }

        protected void btnUredi_Click(object sender, EventArgs e)
        {
            Dogadaj dogadaj = new Dogadaj()
            {
                IDDogadaj = dogadajId,
                Naziv = txtUrediNaziv.Text,
                Opis = txtOpis.Text,
                TipDogadaja = txtTip.Text,
                Cijena = double.Parse(txtCijena.Text),
                Lokacija = txtLokacija.Text,
                Pocetak = getLongFromDateTime(txtDatumPocetak.Text, txtVrijemePocetak.Text),
                Zavrsetak = getLongFromDateTime(txtDatumZavrsetak.Text, txtVrijemeZavrsetak.Text),
                BrojDolazaka = brojDolazaka
            };
            RepositoryFactory.GetRepository().UpdateDogadaj(dogadaj);

            if (inputFile.HasFile)
            {
                Slika slika = new Slika()
                {
                    DogadajID = dogadajId,
                    SlikaPodaci = Convert.ToBase64String(inputFile.FileBytes)
                };
                RepositoryFactory.GetRepository().InsertSlika(slika);
            }
            Response.Redirect("MojiDogadaji.aspx");
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


        protected void btnOdustani_Click(object sender, EventArgs e)
        {
            Response.Redirect("MojiDogadaji.aspx");

        }
    }
}
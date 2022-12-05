using eVent.Dal;
using eVent.Models;
using eVent_Web_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace eVent
{
    public partial class KreirajDogadaj : Localization
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Kreiraj_click(object sender, EventArgs e)
        {
            Dogadaj dogadaj = new Dogadaj()
            {
                Naziv = txtNaziv.Text,
                Opis = txtOpis.Text,
                TipDogadaja = txtTip.Text,
                Cijena = double.Parse(txtCijena.Text),
                Lokacija = txtLokacija.Text,
                Pocetak = getLongFromDateTime(txtDatumPocetak.Text, txtVrijemePocetak.Text),
                Zavrsetak = getLongFromDateTime(txtDatumZavrsetak.Text, txtVrijemeZavrsetak.Text),
                OrganizatorID = int.Parse(Session["loggedInUserID"].ToString())
            };
            int dogadajId = RepositoryFactory.GetRepository().InsertDogadaj(dogadaj);

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
            String[] datumPodaci = datum.Split('-');
            DateTime dt = new DateTime(int.Parse(datumPodaci[0]), int.Parse(datumPodaci[1]), int.Parse(datumPodaci[2]));

            String[] vrijemePodaci = vrijeme.Split(':');
            dt.AddHours(int.Parse(vrijemePodaci[0]));
            dt.AddMinutes(int.Parse(vrijemePodaci[1]));

            return dt.Ticks;
        }

        protected void Odustani_click(object sender, EventArgs e)
        {
            Response.Redirect("MojiDogadaji.aspx");
        }
    }
}
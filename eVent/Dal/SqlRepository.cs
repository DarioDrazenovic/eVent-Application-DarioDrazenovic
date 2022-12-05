using eVent.Models;
using eVent_Web_Service.Models;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace eVent.Dal
{
    public class SqlRepository : IRepository
    {
        private string eve = "Data Source=SQL8002.site4now.net;Initial Catalog = db_a88711_event; User Id = db_a88711_event_admin; Password=eVent123";

        public IEnumerable<User> GetKorisici()
        {
            DataTable table = SqlHelper.ExecuteDataset(eve, "GetKorisnici").Tables[0];
            foreach (DataRow row in table.Rows)
            {
                yield return new User()
                {
                    IDUser = int.Parse(row["IDKorisnik"].ToString()),
                    Ime = row["Ime"].ToString(),
                    Prezime = row["Prezime"].ToString(),
                    Admin = bool.Parse(row["Admin"].ToString()),
                    Email = row["Email"].ToString(),
                    Lozinka = row["Lozinka"].ToString()
                };
            }
        }

        public  IEnumerable<Dogadaj> GetDogadaji()
        {

            DataTable table = SqlHelper.ExecuteDataset(eve, "GetDogadaji").Tables[0];
            foreach (DataRow row in table.Rows)
            {
                yield return new Dogadaj()
                {
                    IDDogadaj = int.Parse(row["IDDogadaj"].ToString()),
                    Naziv = row["Naziv"].ToString(),
                    Opis = row["Opis"].ToString(),
                    TipDogadaja = row["TipDogadaja"].ToString(),
                    Lokacija = row["Lokacija"].ToString(),
                    Cijena = double.Parse(row["Cijena"].ToString()),
                    Pocetak = long.Parse(row["Pocetak"].ToString()),
                    Zavrsetak = long.Parse(row["Zavrsetak"].ToString()),
                    BrojDolazaka = int.Parse(row["BrojDolazaka"].ToString()),
                    OrganizatorID = int.Parse(row["OrganizatorID"].ToString())
                };
            }
        }

        public IEnumerable<Slika> GetSlike()
        {

            DataTable table = SqlHelper.ExecuteDataset(eve, "GetSlike").Tables[0];
            foreach (DataRow row in table.Rows)
            {
                yield return new Slika()
                {
                    IDSlika = int.Parse(row["IDSlika"].ToString()),
                    DogadajID = int.Parse(row["DogadajID"].ToString()),
                    SlikaPodaci = row["Slika"].ToString()
                };
            }
        }

        public  IEnumerable<Komentar> GetKomentari()
        {

            DataTable table = SqlHelper.ExecuteDataset(eve, "GetKomentari").Tables[0];
            foreach (DataRow row in table.Rows)
            {
                yield return new Komentar()
                {
                    IDKomentar = int.Parse(row["IDKomentar"].ToString()),
                    DogadajID = int.Parse(row["DogadajID"].ToString()),
                    AutorID = int.Parse(row["AutorID"].ToString()),
                    KomentarPodaci = row["Komentar"].ToString(),
                    Vrijeme = long.Parse(row["Vrijeme"].ToString()),
                };
            }
        }
        public  IEnumerable<DolazakNaDogadaj> GetDolasci()
        {

            DataTable table = SqlHelper.ExecuteDataset(eve, "GetDolasci").Tables[0];
            foreach (DataRow row in table.Rows)
            {
                yield return new DolazakNaDogadaj()
                {
                    DogadajID = int.Parse(row["DogadajID"].ToString()),
                    KorisnikID = int.Parse(row["KorisnikID"].ToString())
                };
            }
        }


        // ------------  INSERT --------------------

        public  int InsertKorisnik(User User)
        {

            DataTable table = SqlHelper.ExecuteDataset(
                eve,
                "InsertKorisnik",
                User.Email,
                User.Lozinka,
                User.Ime,
                User.Prezime
                ).Tables[0];

            return int.Parse(table.Rows[0]["IDKorisnik"].ToString());

        }

        public  int InsertDogadaj(Dogadaj dogadaj)
        {
            DataTable table = SqlHelper.ExecuteDataset(
               eve,
               "InsertDogadaj",
               dogadaj.Naziv,
               dogadaj.Opis,
               dogadaj.TipDogadaja,
               dogadaj.Cijena,
               dogadaj.Lokacija,
               dogadaj.Pocetak,
               dogadaj.Zavrsetak,
               dogadaj.OrganizatorID
               ).Tables[0];

            return int.Parse(table.Rows[0]["IDDogadaj"].ToString());
        }

        public  int InsertSlika(Slika slika)
        {
            DataTable table = SqlHelper.ExecuteDataset(
              eve,
              "InsertSlika",
              slika.DogadajID,
              slika.SlikaPodaci
              ).Tables[0];

            return int.Parse(table.Rows[0]["IDSlika"].ToString());
        }

        public  void InsertKomentar(Komentar komentar)
        {
            SqlHelper.ExecuteNonQuery(
             eve,
             "InsertKomentar",
             komentar.DogadajID,
             komentar.KomentarPodaci,
             komentar.AutorID,
             komentar.Vrijeme
             );
        }
        public  void InsertDolazak(DolazakNaDogadaj dolazak)
        {
            SqlHelper.ExecuteNonQuery(
            eve,
            "InsertDolazakNaDogadaj",
            dolazak.DogadajID,
            dolazak.KorisnikID
            );
        }

        // ------------  UPDATE --------------------
        public  void UpdateKorisnik(User User)
        {
            SqlHelper.ExecuteDataset(eve, "UpdateKorisnik",
                User.IDUser,
                User.Lozinka,
                User.Ime,
                User.Prezime
                );
        }

        public  void UpdateDogadaj(Dogadaj dogadaj)
        {
            SqlHelper.ExecuteDataset(eve, "UpdateDogadaj",
                dogadaj.IDDogadaj,
                dogadaj.Naziv,
                dogadaj.Opis,
                dogadaj.TipDogadaja,
                dogadaj.Cijena,
                dogadaj.Lokacija,
                dogadaj.Pocetak,
                dogadaj.Zavrsetak,
                dogadaj.BrojDolazaka
                );
        }

        // ------------  DELETE --------------------
        public  void DeleteKorisnik(int idUser)
        {
            SqlHelper.ExecuteDataset(eve, "DeleteKorisnik", idUser);
        }

        public  void DeleteDogadaj(int idDogadaj)
        {
            SqlHelper.ExecuteDataset(eve, "DeleteDogadaj", idDogadaj);
        }

        public  void DeleteSlika(int idSlika)
        {
            SqlHelper.ExecuteDataset(eve, "DeleteSlika", idSlika);
        }
        public  void DeleteDolazak(DolazakNaDogadaj dolazak)
        {
            SqlHelper.ExecuteDataset(eve, "DeleteDolazak",
                dolazak.DogadajID,
                dolazak.KorisnikID
                );
        }
        public  void DeleteKomentar(int id)
        {
            SqlHelper.ExecuteDataset(eve, "DeleteKomentar", id);
        }

        public int checkUser(string email, string password)
        {
            var korisnici = GetKorisici();
            foreach (var k in korisnici)
            {
                if (k.Email == email && k.Lozinka == password)
                {
                    return k.IDUser;
                }
            }
            return -1;
        }

        public String getKorisnik(int id) {
            foreach (var k in GetKorisici())
            {
                if (k.IDUser == id)
                {
                    return k.Ime + " " + k.Prezime;
                }
            }
            return "";
        }

    }
}
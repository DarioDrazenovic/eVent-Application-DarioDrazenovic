using eVent_Web_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eVent.Dal
{
    public interface IRepository
    {

        IEnumerable<User> GetKorisici();
        IEnumerable<Dogadaj> GetDogadaji();
        IEnumerable<Slika> GetSlike();
        IEnumerable<Komentar> GetKomentari();
        IEnumerable<DolazakNaDogadaj> GetDolasci();
        int InsertKorisnik(User User);
        int InsertDogadaj(Dogadaj dogadaj);
        int InsertSlika(Slika slika);
        int checkUser(string email, string password);
        void InsertKomentar(Komentar komentar);
        void InsertDolazak(DolazakNaDogadaj dolazak);
        void UpdateKorisnik(User User);
        void UpdateDogadaj(Dogadaj dogadaj);
        void DeleteKorisnik(int idUser);
        void DeleteDogadaj(int idDogadaj);
        void DeleteSlika(int idSlika);
        void DeleteDolazak(DolazakNaDogadaj dolazak);
        void DeleteKomentar(int id);
        String getKorisnik(int id);
    }
}

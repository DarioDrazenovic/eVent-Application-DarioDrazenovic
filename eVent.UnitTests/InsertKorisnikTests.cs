using eVent.Dal;
using eVent_Web_Service.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eVent.UnitTests
{
    [TestClass]
    public class InsertKorisnikTests
    {
        private readonly string ime = "test";
        private readonly string prezime = "test";
        private readonly string email = "test@gmail.com";
        private readonly string password= "testtest";

        [TestMethod]
        public void InsertKorisnik_ShouldInsertKorisnik_WhenKorisnikExists()
        {
            //Arrange
            var repo = new SqlRepository();

            //Act
            var result = repo.InsertKorisnik(new User { Email = email, Lozinka = password, Ime = ime, Prezime = prezime});

            //Assert
            Assert.IsTrue(result < 0);
        }
        private readonly string ime1 = "Marac";
        private readonly string prezime1 = "Komarac";
        private readonly string email1 = "marac132@gmail.com";
        private readonly string password1 = "12345Marko";

        [TestMethod]
        public void InsertKorisnik_ShouldInsertKorisnik_WhenKorisnikDoesNotExist()
        {
            //Arrange
            var repo = new SqlRepository();

            //Act
            var result = repo.InsertKorisnik(new User { Email = email1, Lozinka = password1, Ime = ime1, Prezime = prezime1 });

            //Assert
            Assert.IsTrue(result > 0);
        }
    }
}

using eVent.Dal;
using eVent_Web_Service.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace eVent.UnitTests
{
    /// <summary>
    /// Summary description for InsertDogadajTests
    /// </summary>
    [TestClass]
    public class InsertDogadajTests
    {
        private string naziv = "Iron Maiden";
        private string opis = "Popularni bend vraca se još jednom, Lorem ipsum blablalalasdsda";
        private string tipDogadaja = "Koncert";
        private double cijena = 750;
        private string lokacija = "Zagreb";
        private long pocetak = 1653249600633;
        private long zavrsetak = 1653336000633;
        private int brojDolazaka = 0;
        private int organizatorID = 1;

        [TestMethod]
        public void InsertDogadaj_ShouldInsertDogadaj_WhenDogadajExists()
        {
            //Arrange
            var repo = new SqlRepository();

            //Act
            var result = repo.InsertDogadaj(new Dogadaj { BrojDolazaka = brojDolazaka, Cijena = cijena, Lokacija = lokacija, Naziv = naziv,
             Opis = opis, OrganizatorID = organizatorID, Pocetak = pocetak, TipDogadaja = tipDogadaja, Zavrsetak = zavrsetak});

            //Assert
            Assert.IsTrue(result > 0);
        }
        private string naziv1 = "Dariov koncert";
        private string opis1 = "Jel netko cuo za ovo opce?";
        private string tipDogadaja1 = "Predavanje";
        private double cijena1 = 2;
        private string lokacija1 = "Metropola";
        private long pocetak1 = 1653249600633;
        private long zavrsetak1 = 1653336000633;
        private int brojDolazaka1 = 0;
        private int organizatorID1 = 1;

        [TestMethod]
        public void InsertDogadaj_ShouldInsertDogadaj_WhenDogadajDoesNotExist()
        {
            //Arrange
            var repo = new SqlRepository();

            //Act
            var result = repo.InsertDogadaj(new Dogadaj
            {
                BrojDolazaka = brojDolazaka1,
                Cijena = cijena1,
                Lokacija = lokacija1,
                Naziv = naziv1,
                Opis = opis1,
                OrganizatorID = organizatorID1,
                Pocetak = pocetak1,
                TipDogadaja = tipDogadaja1,
                Zavrsetak = zavrsetak1
            });

            //Assert
            Assert.IsTrue(result > 0);
        }
    }
}

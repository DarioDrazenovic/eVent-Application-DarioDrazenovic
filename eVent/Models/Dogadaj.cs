namespace eVent_Web_Service.Models
{
    public class Dogadaj
    {
        public int IDDogadaj { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public string TipDogadaja { get; set; }
        public double Cijena { get; set; }
        public string Lokacija { get; set; }
        public long Pocetak { get; set; }
        public long Zavrsetak { get; set; }
        public int BrojDolazaka { get; set; }
        public int OrganizatorID { get; set; }
    }
}

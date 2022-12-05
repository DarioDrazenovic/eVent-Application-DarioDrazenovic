namespace eVent_Web_Service.Models
{
    public class Komentar
    {
        public int IDKomentar { get; set; }
        public int DogadajID { get; set; }
        public int AutorID { get; set; }
        public string KomentarPodaci { get; set; }
        public long Vrijeme { get; set; }
    }
}

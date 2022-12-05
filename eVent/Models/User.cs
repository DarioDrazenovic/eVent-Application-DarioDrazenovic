namespace eVent_Web_Service.Models
{

    public class User
    {
        public int IDUser { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public bool Admin { get; set; }
    }
}

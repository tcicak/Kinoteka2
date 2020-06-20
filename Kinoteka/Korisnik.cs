using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteka
{
    // Klasa koja definira korisnika koji korsiti aplikaciju
    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string BrojKartice { get; set; }
        public string BrojMobitela { get; set; }
        public string Uloga { get; set; }

        public Korisnik(int id, string ime, string prezime, string email, string lozinka, DateTime datumRodjenja, string brojKartice, string brojMobitela, string uloga)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            Lozinka = lozinka;
            DatumRodjenja = datumRodjenja;
            BrojKartice = brojKartice;
            BrojMobitela = brojMobitela;
            Uloga = uloga;
        }
        public Korisnik()
        {

        }
    }
}

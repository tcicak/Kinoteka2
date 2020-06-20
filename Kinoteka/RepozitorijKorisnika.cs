using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;

namespace Kinoteka
{
    public class RepozitorijKorisnika
    {

        // Metoda koja dodaje korisnika u repozitorij
        public int DodajKorisnika (Korisnik noviKorisnik)
        {
            Database.Instance.Connect();
            string sql = "INSERT INTO Korisnik (Ime, Prezime, Email, Lozinka, DatumRodjenja, BrojKartice, BrojMobitela, Uloga) " +
                $"VALUES ('{noviKorisnik.Ime}', '{noviKorisnik.Prezime}', '{noviKorisnik.Email}', '{noviKorisnik.Lozinka}', '{noviKorisnik.DatumRodjenja.ToString("yyyyMMdd")}', '{noviKorisnik.BrojKartice}', '{noviKorisnik.BrojMobitela}', '{noviKorisnik.Uloga}')";
            int affectedRows = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return affectedRows;
        }

        // Metoda koja dohvaća sve korisnike iz repozitorija
        public List<Korisnik> DohvatiKorisnike()
        {
            List<Korisnik> sviKorisnici = new List<Korisnik>();
            string sql = "SELECT * FROM Korisnik";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            while (dataReader.Read())
            {
                Korisnik korisnik = DohvacanjePodataka(dataReader);
                sviKorisnici.Add(korisnik);
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return sviKorisnici;
        }

        public int PrebrojKorisnike()
        {
            int broj = 0;
            string sql = "SELECT COUNT(KorisnikId) FROM Korisnik";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            while (dataReader.Read())
            {
                broj += 1;
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return broj;
        }

        // Metoda koja dohvaća odabranog korisnika iz repozitorija
        public Korisnik DohvatiOdabranogKorisnika(int idOdabranogKorisnika)
        {
            string sql = $"SELECT * FROM Korisnik WHERE KorisnikId='{idOdabranogKorisnika}'";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            Korisnik odabraniKorisnik = DohvacanjePodataka(dataReader);
            return odabraniKorisnik;
        }


        private Korisnik DohvacanjePodataka(IDataReader dataReader)
        {
            int id = (int)dataReader["KorisnikID"];
            string ime = dataReader["Ime"].ToString();
            string prezime = dataReader["Prezime"].ToString();
            string email = dataReader["Email"].ToString();
            string lozinka = dataReader["Lozinka"].ToString();
            DateTime datumRodjenja = DateTime.Parse(dataReader["DatumRodjenja"].ToString());
            string brojKartice = dataReader["BrojKartice"].ToString();
            string brojMobitela = dataReader["BrojMobitela"].ToString();
            string uloga = dataReader["Uloga"].ToString();

            Korisnik korisnik = new Korisnik()
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                Email = email,
                Lozinka = lozinka,
                DatumRodjenja = datumRodjenja,
                BrojKartice = brojKartice,
                Uloga = uloga
            };
            return korisnik;
        }

        // Metoda koja briše korisnika iz repozitorija
        public int ObrisiKorisnika (Korisnik korisnik)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM Korisnik WHERE KorisnikId = {korisnik.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
    }
}

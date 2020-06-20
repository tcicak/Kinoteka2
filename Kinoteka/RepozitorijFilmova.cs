using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;

namespace Kinoteka
{
    public class RepozitorijFilmova
    {
        public List<Film> Filmovi { get; set; } = new List<Film>();

        // Metoda koja dodaje novi film u repozitorij
        public int DodajFilm(Film NoviFilm)
        {
            Database.Instance.Connect();
            string sql = "INSERT INTO Film (Naziv, Zanr, VrijemeTrajanja, DatumPremijere, Godina, Direktor)" +
                $"VALUES ('{NoviFilm.Naziv}', '{NoviFilm.Zanr}', '{NoviFilm.VrijemeTrajanja}', '{NoviFilm.DatumPremijere.ToString("yyyyMMdd")}', '{NoviFilm.Godina}', '{NoviFilm.Direktor}')";
            int affectedRows = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return affectedRows;
        }

        // Metoda koja dohvaća sve filmove iz repozitorija
        public List<Film> DohvatiFilmove()
        {
            List<Film> sviFilmovi = new List<Film>();
            string sql = "SELECT * FROM Film";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            while (dataReader.Read())
            {
                Film film = DohvacanjePodataka(dataReader);

                sviFilmovi.Add(film);
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return sviFilmovi;
        }

        // Metoda koja dohvaća odabrani film iz repozitorija
        public Film DohvatiOdabraniFilm(int idOdabranogFilma)
        {
            string sql = $"SELECT * FROM Film WHERE FilmId='{idOdabranogFilma}'";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            Film odabraniFilm = DohvacanjePodataka(dataReader);
            return odabraniFilm;
        }

        // Metoda koja pomocu DataReader-a dohvaća podatke o filmovima iz repozitorija (koristi se u prethodne dvije metode)
        private static Film DohvacanjePodataka(IDataReader dataReader)
        {
            int id = (int)dataReader["FilmID"];
            string naziv = dataReader["Naziv"].ToString();
            string zanr = dataReader["Zanr"].ToString();
            int vrijemeTrajanja = (int)dataReader["VrijemeTrajanja"];
            DateTime datumPremijere = DateTime.Parse(dataReader["DatumPremijere"].ToString());
            int godina = (int)dataReader["Godina"];
            string direktor = dataReader["Direktor"].ToString();

            Film film = new Film()
            {
                Id = id,
                Naziv = naziv,
                Zanr = zanr,
                VrijemeTrajanja = vrijemeTrajanja,
                DatumPremijere = datumPremijere,
                Godina = godina,
                Direktor = direktor
            };
            return film;
        }

        // Metoda koja briše filmove iz repozitorija
        public int ObrisiFilm(Film film)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM Film WHERE FilmId = {film.Id}";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }
    }
}

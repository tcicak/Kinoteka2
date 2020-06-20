using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccess;

namespace Kinoteka
{
    public class RepozitorijKina
    {   
        // Metoda koja dodaje novo kino u repozitorij
        public int DodajKino(Kino novoKino)
        {
            Database.Instance.Connect();
            string sql = $"INSERT INTO Kino (Grad, Adresa) VALUES ('{novoKino.Grad}', '{novoKino.Adresa}')";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return i;
        }

        // Metoda koja dohvaća sva kina iz repozitorija
        public List<Kino> DohvatiKina()
        {
            List<Kino> svaKina = new List<Kino>();
            string sql = "SELECT * FROM Kino";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            while (dataReader.Read())
            {
                Kino kino = DohvacanjePodataka(dataReader);
                svaKina.Add(kino);
            }
            dataReader.Close();
            Database.Instance.Disconnect();
            return svaKina;
        }

        // Metoda koja dohvaća odabrano kino iz repozitorija
        public Kino DohvatiOdabranoKino(int idOdabranogKina)
        {
            string sql = $"SELECT * FROM Kino WHERE KinoId = '{idOdabranogKina}'";
            Database.Instance.Connect();
            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            Kino odabranoKino = DohvacanjePodataka(dataReader);
            return odabranoKino;
        }

        // Metoda koja pomocu DataReader-a dohvaća podatke o kinima iz repozitorija (koristi se u prethodne dvije metode)
        private Kino DohvacanjePodataka(IDataReader dataReader)
        {
            int id = (int)dataReader["KinoID"];
            string grad = dataReader["Grad"].ToString();
            string adresa = dataReader["Adresa"].ToString();

            Kino kino = new Kino()
            {
                Id = id,
                Grad = grad,
                Adresa = adresa
            };
            return kino;
        }

        //Metoda koja briše kino iz repozitorija
        public void ObrisiKino(Kino kino)
        {
            Database.Instance.Connect();
            string sql = $"DELETE FROM Kino WHERE KinoId = '{kino.Id}'";
            int i = Database.Instance.ExecuteCommand(sql);
            Database.Instance.Disconnect();
            return;
        }
    }
}

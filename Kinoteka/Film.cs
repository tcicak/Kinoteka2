using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteka
{
    // Klasa koja sadrži sve informacije o filmu
    public class Film
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Zanr { get; set; }
        public int VrijemeTrajanja { get; set; }
        public DateTime DatumPremijere { get; set; }
        public int Godina { get; set; }
        public string Direktor { get; set; }

        public Film(int id, string naziv, string zanr, int vrijemeTrajanja, DateTime datumPremijere, int godina, string direktor)
        {
            Id = id;
            Naziv = naziv;
            Zanr = zanr;
            VrijemeTrajanja = vrijemeTrajanja;
            DatumPremijere = datumPremijere;
            Godina = godina;
            Direktor = direktor;
        }
        public Film()
        {

        }
    }
}

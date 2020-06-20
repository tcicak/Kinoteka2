using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteka
{
    public class Racun
    {
        public int BrRacuna { get; set; }
        public string ImeKina { get; set; }
        public string ImeKupca { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public float Cijena { get; set; }
        public float PDV { get; set; }
        public float UkupnaCijena { get; set; }

        public Racun(int brRacuna, string imeKina, string imeKupca, DateTime datumVrijeme, float cijena, float pdv, float ukupnaCijena)
        {
            BrRacuna = brRacuna;
            ImeKina = imeKina;
            ImeKupca = imeKupca;
            DatumVrijeme = datumVrijeme;
            Cijena = cijena;
            PDV = pdv;
            UkupnaCijena = ukupnaCijena;
        }
    }
}

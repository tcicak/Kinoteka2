using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteka
{
    public class Sjedalo
    {
        public string NazivSjedala { get; set; }
        public bool Zauzeto { get; set; }

        public Sjedalo(string nazivSjedala, bool zauzeto)
        {
            NazivSjedala = nazivSjedala;
            Zauzeto = zauzeto;
        }
    }
}

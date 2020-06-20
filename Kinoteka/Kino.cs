using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoteka
{
    public class Kino
    {
        public int Id { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }

        public Kino(int id, string grad, string adresa)
        {
            Id = id;
            Grad = grad;
            Adresa = adresa;
        }

        public Kino()
        {

        }
    }
}

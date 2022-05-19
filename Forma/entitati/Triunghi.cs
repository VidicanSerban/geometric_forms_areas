using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Triunghi: Forme
    {
        public Triunghi(string culoare, float baza, float inaltime, double aria)
            :base(culoare, aria)
        {
            this.Baza = baza;
            this.Inaltime = inaltime;
            base.Aria = this.CalculAria();
        }

        public float Baza { get; set;}
        public float Inaltime { get; set;}
        public double CalculAria()
        {
            return (Convert.ToDouble(Baza) * Convert.ToDouble(Inaltime))/2;
        }

        public override string Descriere()
        {
            return $"Triunghiului de culoare {Culoare}, baza {Baza} si inaltimea {Inaltime}. Aria acestui triunghi este {Aria}.";
        }

    }
}

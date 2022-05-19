using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public class Dreptunghi: Forme
    {
        public Dreptunghi(string culoare, float lungime, float latime, double aria)
            :base(culoare, aria)
        {
            this.Lungime = lungime;
            this.Latime = latime;
            base.Aria = this.CalculAria();
        }

        public float Lungime { get; set; }
        public float Latime { get; set; }

        public double CalculAria()
        {
            return (Convert.ToDouble(Latime) * Convert.ToDouble(Lungime));
        }
        public override string Descriere()
        {
            return $"Dreptunghiului de culoare {Culoare}, latime {Latime} si lungime {Lungime}. Aria acestui dreptunghi este {Aria}. ";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitati
{
    public abstract class Forme
    {
        public Forme(string culoare, double aria)
        {
            Culoare = culoare;
            Aria = aria;
        }

        public string Culoare { get; set;}

        public double Aria { get; set;}

        public abstract string Descriere();
    }
}

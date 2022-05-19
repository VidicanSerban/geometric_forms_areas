using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;

namespace Forma
{
    public class TriunghiMgr
    {
        public Triunghi AddTriunghi()
        {
            Console.WriteLine("Culoare: ");
            string culoare = Console.ReadLine();
            Console.WriteLine("Inaltime: ");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Baza: ");
            float baza = float.Parse(Console.ReadLine());
            return new Triunghi(culoare, h, baza, 0);
        }
    }
}

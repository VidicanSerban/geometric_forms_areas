using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    public class DrepunghiMgr
    {
        public Dreptunghi AddDreptunghi()
        {
            Console.WriteLine("Culoare: ");
            string culoare = Console.ReadLine();
            Console.WriteLine("Latime: ");
            float lat = float.Parse(Console.ReadLine());
            Console.WriteLine("Lungime: ");
            float lung = float.Parse(Console.ReadLine());
            return new Dreptunghi(culoare, lat, lung, 0);
        }
    }
}

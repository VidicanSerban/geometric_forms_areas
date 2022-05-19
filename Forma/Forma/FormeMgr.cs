using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitati;
namespace Forma
{
    class FormeMgr
    {
        private static List<Forme> arii = new List<Forme>();

        public void AddElement(Forme elem)
        {
            arii.Add(elem);
        }
        public static void PrintLista()
        {
            foreach (var elem in arii)
            {
                Console.WriteLine(elem.Descriere());
            }
        }

        public static void Interogare_Arie()
        {
            var interogare = from elem in arii
                             orderby elem.Aria
                             select elem;

            foreach (var p in interogare)
            {
                    Console.WriteLine(p.Descriere());
            }
        }
    }
}

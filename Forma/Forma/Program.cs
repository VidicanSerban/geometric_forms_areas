using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    class Program
    {
        static void Main(string[] args)
        {
            var forme_arii = new FormeMgr();
            Console.Write("Cate dreptunghiuri doriti sa introduceti? - ");
            int nr_drt = int.Parse(Console.ReadLine());
            for (int i = 0; i < nr_drt; i++)
            {
                forme_arii.AddElement(new DrepunghiMgr().AddDreptunghi());
            }
            Console.Write("Cate triunghiuri doriti sa introduceti? - ");
            int nr_trg = int.Parse(Console.ReadLine());
            for (int i = 0; i < nr_trg; i++)
            {
                forme_arii.AddElement(new TriunghiMgr().AddTriunghi());
            }

            FormeMgr.PrintLista();
            
            Console.WriteLine("\nFormele geometrice ordonate dupa arii sunt: ");
            FormeMgr.Interogare_Arie();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_Klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov zrakoplov = new Zrakoplov();
            zrakoplov.SetNaziv("Airbus");
            zrakoplov.SetDosegLeta(6000);
            zrakoplov.SetSnagaMotoraU_kW(2000);

            Console.WriteLine("Zrakoplov x380:");
            Console.WriteLine(zrakoplov.Ispis());
            Console.WriteLine("\n");
            Zrakoplov zrakoplov2 = new Zrakoplov("Cessna Skycatcher", 870, 75);

            Console.WriteLine("Zrakoplov C162:");
            Console.WriteLine(zrakoplov2.Ispis());

            Zrakoplov zrakoplov3 = new Zrakoplov("Pilatus", 1333, 1200);
            Console.WriteLine("\n");
            Console.WriteLine("Zrakoplov PC-21:");
            Console.WriteLine(zrakoplov3.Ispis());

            Console.ReadKey();
        }


    }

       
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaBrojeva = new List<int>();

            while (true)
            {
                Console.Write("Unesite broj: ");
                string unos = Console.ReadLine();
                if (int.TryParse(unos, out int broj))
                {
                    if (broj == 0) break;
                    if (broj < 0) continue;
                    listaBrojeva.Add(broj);
                }
            }

            Console.WriteLine("Unijeli ste {0} brojeva.", listaBrojeva.Count);

            for (int i = 0; i < listaBrojeva.Count; i++) {
                Console.Write(listaBrojeva[i]);
                if(i < listaBrojeva.Count-1)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey();
        }
    }
}

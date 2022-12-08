using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
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
                    listaBrojeva.Add(broj);
                }
            }

            for(int i = 0; i < listaBrojeva.Count; i++)
            {
                int tmpBroj = Math.Abs(listaBrojeva[i]);
                if (tmpBroj > 99)
                {
                    listaBrojeva[i] = 0;
                }
            }

            for (int i = 0; i < listaBrojeva.Count; i++)
            {
                Console.Write(listaBrojeva[i]);
                if (i < listaBrojeva.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey();
        }
    }
}

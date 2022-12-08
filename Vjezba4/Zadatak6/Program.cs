using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak6
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
                    if (Math.Abs(broj) < 10) break;
                    listaBrojeva.Add(broj);
                }
            }

            int djeljivihSPet = 0;
            for (int i = 0; i < listaBrojeva.Count; i++)
            {
                Console.Write(listaBrojeva[i]);
                if (i < listaBrojeva.Count - 1)
                {
                    Console.Write(", ");
                }
                if(listaBrojeva[i] % 5 == 0)
                {
                    djeljivihSPet += 1;
                }
            }

            Console.WriteLine("\nDijeljivih s pet je {0}", djeljivihSPet);

            Console.ReadKey();
        }
    }
}

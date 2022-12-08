using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Koliko brojeva zelite unijeti? ");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                return;
            }

            HashSet<int> brojevi = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Unesite broj: ");
                if (int.TryParse(Console.ReadLine(), out int broj) && broj >= 1)
                {
                    brojevi.Add(broj);
                }
            }

            for (int i = 0; i < brojevi.Count; i++)
            {
                Console.Write(brojevi.ElementAt(i));
                if (i < brojevi.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\nNajveći broj je {0}", brojevi.Max());

            Console.ReadKey();
        }
    }
}

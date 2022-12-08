using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaBrojeva = new List<int>();

            while (true)
            {
                Console.Write("Unesite element strukture: ");
                string unos = Console.ReadLine();
                if (int.TryParse(unos, out int broj))
                {
                    if (broj == 0) break;
                    listaBrojeva.Add(broj);
                }
            }

            int minBroj = listaBrojeva.Min();
            Console.WriteLine("Najmanji clan je {0}", minBroj);
            listaBrojeva.Remove(minBroj);

            listaBrojeva.ForEach(i => Console.Write(i));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Koliko brojeva zelite unijeti? ");
            int n;
            if(!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                return;
            }

            List<int> cjelobrojniDijelovi = new List<int>();
            List<double> decimalniDijelovi = new List<double>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Unesite broj: ");
                if(double.TryParse(Console.ReadLine(), out double decimalniBroj) && decimalniBroj >= 1)
                {
                    decimalniBroj = Math.Round((double) decimalniBroj, 2);
                    double cjelobrojniDio = Math.Truncate(decimalniBroj);
                    cjelobrojniDijelovi.Add((int) cjelobrojniDio);
                    double decimalniDio = decimalniBroj - cjelobrojniDio;
                    decimalniDijelovi.Add(decimalniDio);
                }
            }

            for (int i = 0; i < cjelobrojniDijelovi.Count; i++)
            {
                Console.Write(cjelobrojniDijelovi[i]);
                    Console.Write(", ");
            }

            for (int i = 0; i < decimalniDijelovi.Count; i++)
            {
                Console.Write(decimalniDijelovi[i]);
                if (i < decimalniDijelovi.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.ReadKey();
        }
    }
}

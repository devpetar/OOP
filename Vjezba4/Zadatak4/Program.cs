using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaImena = new List<string>();

            while (true)
            {
                Console.Write("Unesite ime gosta: ");
                string imeGosta = Console.ReadLine();
                if ("kraj".Equals(imeGosta)) break; 
                listaImena.Add(imeGosta);
            }

            listaImena.Sort();
            Console.WriteLine("Prisutni gosti su:");
            listaImena.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}

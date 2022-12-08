using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaBrojeva = new List<int>();

            while(true)
            {
                Console.Write("Unesite element strukture: ");
                string unos = Console.ReadLine();
                if(int.TryParse(unos, out int broj))
                {
                    if (broj == 0) break;
                    listaBrojeva.Add(broj);
                }
            }

            listaBrojeva.Reverse();
            listaBrojeva.ForEach(i => Console.WriteLine(i));

            Console.ReadKey();
        }
    }
}

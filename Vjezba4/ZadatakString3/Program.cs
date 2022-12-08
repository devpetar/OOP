using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakString3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite rečenicu: ");
            string unos = Console.ReadLine();
            string[] rijeci = unos.Split();
            Console.WriteLine("U rečenici se nalazi {0} riječi.", rijeci.Length);
            foreach (var rijec in rijeci)
            {
                Console.WriteLine(rijec);
            }

            Console.ReadKey();
        }
    }
}

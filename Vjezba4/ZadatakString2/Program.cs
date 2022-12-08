using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakString2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite niz znakova: ");
            string unos = Console.ReadLine();
            unos = unos.ToUpper();
            Console.WriteLine(unos);

            Console.ReadKey();
        }
    }
}

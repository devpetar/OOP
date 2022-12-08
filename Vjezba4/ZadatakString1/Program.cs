using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakString1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite riječ: ");
            string prvaRijec = Console.ReadLine();
            Console.Write("Unesite riječ: ");
            string drugaRijec = Console.ReadLine();

            if (prvaRijec.Equals(drugaRijec))
            {
                Console.WriteLine("Učitane su dvije iste riječi.");
            }
            else
            {
                Console.WriteLine("Nisu učitane dvije iste riječi.");
            }

            Console.ReadKey();
        }
    }
}

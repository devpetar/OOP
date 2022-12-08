using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> mjeseci = new Dictionary<int, string>();
            mjeseci.Add(1, "Siječanj");
            mjeseci.Add(2, "Veljača");
            mjeseci.Add(3, "Ožujak");
            mjeseci.Add(4, "Travanj");
            mjeseci.Add(5, "Svibanj");
            mjeseci.Add(6, "Lipanj");
            mjeseci.Add(7, "Srpanj");
            mjeseci.Add(8, "Kolovoz");
            mjeseci.Add(9, "Rujan");
            mjeseci.Add(10, "Listopad");
            mjeseci.Add(11, "Studeni");
            mjeseci.Add(12, "Prosinac");

            Console.Write("Unesite redni broj mjeseca: ");
            if(int.TryParse(Console.ReadLine(), out int i) && i >= 1 && i <= 12)
            {
                Console.WriteLine("Odabrali ste: " + mjeseci[i]);
            }

            Console.ReadKey();
        }
    }
}

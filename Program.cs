using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraznanja5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesite koliko brojeva zelite upisati.");
            int x = Convert.ToInt32(Console.ReadLine());
            double[] polje;
            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Unesite " + x + " broj");
                polje[x] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toets_210114
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto1 = new Auto();
            var auto2 = new Auto();
                auto2.Merk = "Citroën";
                auto2.Model = "Cactus C4";
                auto2.Prijs = 27999;
                auto2.Verbruik = 4.3;
            var auto3 = new Auto("Peugeot", "5008");
                auto3.Prijs = 32599;
                auto3.Verbruik = 5.2;
            var auto4 = new Auto("Seat", "Ibiza", "14223", "3.8");

            Console.WriteLine(auto1.AsText);
            Console.WriteLine("");
            Console.WriteLine(auto2.AsText);
            Console.WriteLine("");
            Console.WriteLine(auto3.AsText);
            Console.WriteLine("");
            Console.WriteLine(auto4.AsText);
            Console.ReadKey();
        }
    }
}

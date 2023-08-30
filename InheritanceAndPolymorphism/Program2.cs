using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Program2
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- Thong tin ve dong vat -----");
            Console.ForegroundColor = ConsoleColor.White;

            Lion lion = new Lion(200, "lion");
            Tiger tiger = new Tiger(100, "tiger");
            lion.Show();
            Console.WriteLine();
            tiger.Show();

        }
    }
}

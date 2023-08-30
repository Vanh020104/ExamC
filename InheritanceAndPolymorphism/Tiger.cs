using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Tiger : AnimalClass
    {
        public Tiger(double weight, string name)
        {
            SetMe(weight, name);
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-- Thong tin ve Tiger:");
            Console.ForegroundColor = ConsoleColor.White;
            base.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class Lion : AnimalClass
    {
        public Lion(double weight, string name)
        {
            SetMe(weight, name);
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-- Thong tin ve Lion:");
            Console.ForegroundColor = ConsoleColor.White;

            base.Show();
        }
    }
}

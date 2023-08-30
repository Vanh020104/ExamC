using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public class AnimalClass
    {
        protected double Weight { get; set; }
        protected string Name { get; set; }

        public void SetMe(double weight, string name)
        {
            Weight = weight;
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Weight: {Weight} kg");
        }
    }
    
  
    
}

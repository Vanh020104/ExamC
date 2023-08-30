using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Program1
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-- Hay nhap thong tin can tinh! --");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Nhap ban kinh:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap chieu cao:");
            double height = double.Parse(Console.ReadLine());

            Cylinder cylinder = new Cylinder();
            cylinder.Process(radius, height);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-- Ket qua vua tinh la: --");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(cylinder.Result());
        }
    }
}

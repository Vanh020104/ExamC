using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Cylinder
    {
        private double Radius { get; set; }
        private double Height { get; set; }
        private double BaseArea { get; set; }
        private double LateralArea { get; set; }
        private double TotalArea { get; set; }
        private double Volume { get; set; }

        public void Process(double radius, double height)
        {
            Radius = radius;
            Height = height;

            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        } 


        public string Result()
        {
            return $"Base: {BaseArea}\n " +
                   $"Lateral: {LateralArea}\n" +
                   $"Total: {TotalArea}\n" +
                   $"Volume: {Volume}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Cirkel : Geometri
    {
        public double radius { get; set; }
        public double Pi;
        public Cirkel()
        {
            radius = 4;
            Pi = 3.14;
        }

        public override double Area()
        {
           double area = radius * Pi;
           Console.WriteLine($"Area cirkel: {area}");
            return area;
        }
    }
}

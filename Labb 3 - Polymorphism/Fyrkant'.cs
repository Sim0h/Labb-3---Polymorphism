using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Fyrkant : Geometri
    {
        public double Lenght;
        public double Width;

        public Fyrkant()
        {
            Lenght = 5.3;
            Width = 5.3;
        }

        public override double Area()
        {
            double area = Lenght * Width;
            Console.WriteLine($"Area fyrkant: {area}");
            return area;
        }
    }
}

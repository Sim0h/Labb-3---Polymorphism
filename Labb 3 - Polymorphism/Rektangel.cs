using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_3___Polymorphism
{
    internal class Rektangel : Geometri
    {
        public double Lenght;
        public double Width;

        public Rektangel()
        {
            Lenght = 10.5;
            Width = 5.2;
        }

        public override double Area()
        {
            double area = Lenght * Width;
            Console.WriteLine($"Area Rektangel: {area}");
            return area;
        }
    }
}

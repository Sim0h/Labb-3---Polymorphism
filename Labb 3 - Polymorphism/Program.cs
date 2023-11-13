namespace Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri geometri = new Cirkel();
            geometri.Area();

            Geometri geometri2 = new Rektangel();
            geometri2.Area();

            Geometri geometri3 = new Fyrkant();
            geometri3.Area();
        }
    }
}
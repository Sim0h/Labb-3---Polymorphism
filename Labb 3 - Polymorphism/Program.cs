namespace Labb_3___Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cirkel cirkel = new Cirkel();
            cirkel.Area();

            Rektangel rektangel = new Rektangel();
            rektangel.Area();

            Fyrkant fyrkant = new Fyrkant();
            fyrkant.Area();
        }
    }
}
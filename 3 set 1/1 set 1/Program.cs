using System.Runtime.InteropServices;

namespace _1_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti prima valoare");
            double a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare ");
            double b=int.Parse(Console.ReadLine());
            double x = 0;
            if (a == 0) Console.WriteLine("Ecuatia nu are solutii");
            if (b == 0) x = 0;
            else x = b / a;
            Console.WriteLine($"Rezultatul este {x}");
        }
    }
}

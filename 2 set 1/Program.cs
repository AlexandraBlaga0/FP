namespace _2_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti prima valoare ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a treia valoare ");
            double c = double.Parse(Console.ReadLine());
            double x = 0, delta = 0, x1 = 0, x2 = 0;
            if (a == 0)
            {
                if (b != 0)
                {
                    x = -c / b;
                    Console.WriteLine($"Ecuatia devine de gradul 1, rezultatul este {x}");
                }
                else Console.WriteLine("Ecutaia nu are solutii");
            }
            else
            {
                delta = b * b - 4 * a * c;
                if (delta < 0) Console.WriteLine("Ecuatia nu are solutii reale ");
                else if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Solutiile sunt {x1} si {x2}");
                }
                else
                {
                    x = -b / (2 * a);
                    Console.WriteLine($"Solutia unica este {x}");
                }
            }
        }

    }
}



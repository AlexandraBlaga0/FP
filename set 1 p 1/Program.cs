

namespace set_1_p_1
{
    internal class Program
    {
        static void ecuatie1()
        {
            Console.WriteLine("Introduceti prima valoare ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare ");
            int b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia are solutii infinite");
                }
                else Console.WriteLine("Nu are solutii");
            }
            else
            {
                int x = -b / a;
                Console.WriteLine($"Solutia este {x}");
            }
        }
            static void Main(string[] args)
            {
                ecuatie1 ();
            }
        }
    }


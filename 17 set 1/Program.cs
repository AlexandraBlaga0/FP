namespace _17_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar ");
            int b = int.Parse(Console.ReadLine());
                int originalA = a, originalB = b;

                while (b != 0)
                {
                    int rest = a % b;
                    a = b;
                    b = rest;
                }

                int cmmmdc = a;
                int cmmmc = (originalA * originalB) / cmmmdc;

                Console.WriteLine($"Cel mai mare divizor comun al numerelor {originalA} si {originalB} este: {cmmmdc}");
                Console.WriteLine($"Cel mai mic multiplu comun al numerelor {originalA} si {originalB} este: {cmmmc}");
            }
        }
    }

namespace _8_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti prima valoare ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare ");
            int b= int.Parse(Console.ReadLine());
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"Valorile interschimbate sunt a= {a} si b= {b}");
        }
    }
}

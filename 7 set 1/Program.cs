namespace _7_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti prima valoare ");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare ");
            int b=int.Parse(Console.ReadLine());
            int aux = 0;
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Rezultatul valorilor interschimbate este a= {a} si b={b}");
        }
    }
}

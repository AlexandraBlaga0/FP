namespace _10_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul ");
            int n=int.Parse(Console.ReadLine());
            int divizori = 0;
            for (int i = 1; i <=n; i++)
                if (n % i == 0)
                    divizori++;
            if (divizori == 2) Console.WriteLine("Este numar prim");
            else Console.WriteLine("Nu este prim");
        }
    }
}

namespace _18_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul ");
            int n = int.Parse(Console.ReadLine());
            for (int f = 2; n > 1; f++)
                if (n % f == 0)
                {
                    int p = 0;
                    while (n % f == 0)
                    {
                        p++;
                        n /= f;
                        Console.WriteLine($"Factor: {f}, Putere: {p}");
                    }
                }
           
        }
    }
}

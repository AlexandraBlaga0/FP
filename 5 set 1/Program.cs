namespace _5_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti cifra k ");
            int k=int.Parse(Console.ReadLine());
            int cif=-1;
            if (k < 0) Console.WriteLine("K trebuie sa fie un numar pozitiv");
            for(int i=1; i<=k; i++) 
            {
                cif = n % 10;
                n /= 10;
            }
            if (cif == -1) Console.WriteLine("k este mai mare decat numarul");
            else Console.WriteLine($"Cifra {k} este {cif}");


        }
    }
}

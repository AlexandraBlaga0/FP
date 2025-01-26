namespace _20_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numaratorul:");
            int numarator = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti numitorul:");
            int numitor = int.Parse(Console.ReadLine());
            int numitor1 = numitor;
            while (numitor % 2 == 0)
                numitor /= 2;
            while (numitor % 5 == 0)
                numitor /= 5;
            if (numitor == 1)
            {
                int parteIntreaga = numarator / numitor1;
                int rest = numarator % numitor1;
                Console.Write(parteIntreaga + ".");
                if (rest == 0)
                {
                    Console.WriteLine();
                    return;
                }
                while (rest != 0)
                {
                    rest *= 10;
                    Console.Write(rest / numitor1);
                    rest = rest % numitor1;
                }

                Console.WriteLine();
                return; 
            }
            int parteIntreagaPeriodica = numarator / numitor1; 
            int restPeriodica = numarator % numitor1; 
            Console.Write(parteIntreagaPeriodica + ".");
            if (restPeriodica == 0)
            {
                Console.WriteLine();
                return;
            }
            int poz = 0;  
            int startPerioada = -1; 
            int restc = restPeriodica;
            while (restc != 0)
            {
                restc *= 10;
                int cifra = restc / numitor1;
                restc%= numitor1;
                Console.Write(cifra);
                poz++;
            }
            if (startPerioada != -1)
            {
                Console.WriteLine();
                Console.WriteLine($"Perioada incepe de la pozitia {startPerioada}");
            }
        }
    }
}

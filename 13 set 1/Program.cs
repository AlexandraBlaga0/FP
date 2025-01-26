namespace _13_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti anul ");
            int y1=int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea an ");
            int y2=int.Parse(Console.ReadLine());
            int bisecti = 0;
            for(int i=y1;i<=y2;i++)
            {
                if (i % 4 == 0) bisecti++;
            }
            Console.WriteLine($"Sunt {bisecti} ani bisecti");
        }
    }
}

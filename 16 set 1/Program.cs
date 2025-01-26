namespace _16_set_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti primul numar: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al doilea numar: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al treilea numar: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al patrulea numar: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti al cincilea numar: ");
            int e = int.Parse(Console.ReadLine());
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            int aldoilea = a, altreilea = a, alpatrulea = a;
            if (a > min && a < max) aldoilea = a;
            if (b > min && b < max && (aldoilea == min || b < aldoilea)) aldoilea = b;
            if (c > min && c < max && (aldoilea == min || c < aldoilea)) aldoilea = c;
            if (d > min && d < max && (aldoilea == min || d < aldoilea)) aldoilea = d;
            if (e > min && e < max && (aldoilea == min || e < aldoilea)) aldoilea = e;
            if (a > aldoilea && a < max) altreilea = a;
            if (b > aldoilea && b < max && (altreilea == min || b < altreilea)) altreilea = b;
            if (c > aldoilea && c < max && (altreilea == min || c < altreilea)) altreilea = c;
            if (d > aldoilea && d < max && (altreilea == min || d < altreilea)) altreilea = d;
            if (e > aldoilea && e < max && (altreilea == min || e < altreilea)) altreilea = e;
            if (a > altreilea && a < max) alpatrulea = a;
            if (b > altreilea && b < max && (alpatrulea == min || b < alpatrulea)) alpatrulea = b;
            if (c > altreilea && c < max && (alpatrulea == min || c < alpatrulea)) alpatrulea = c;
            if (d > altreilea && d < max && (alpatrulea == min || d < alpatrulea)) alpatrulea = d;
            if (e > altreilea && e < max && (alpatrulea == min || e < alpatrulea)) alpatrulea = e;
            Console.WriteLine($"Numerele în ordine crescătoare: {min}, {aldoilea}, {altreilea}, {alpatrulea}, {max}");
        }
    }
    }


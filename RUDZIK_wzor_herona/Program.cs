using System;

namespace RUDZIK_wzor_herona
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Witaj w aplikacji obliczającej pole trójkąta według wzoru herona");
            Console.WriteLine("Podaj bok 1");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok 2");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj bok 3");
            c = double.Parse(Console.ReadLine());
            if (a + b > c && a + c > b && b + c > a)
            {
                double p =(a + b + c)/2;
                double dopierwiastka = p * (p - a) * (p - b) * (p - c);
                double Pole = Math.Sqrt(dopierwiastka);
                Console.WriteLine("Pole tego trójkąta wynosi {0}",Pole);
            }
            else
            {
                Console.WriteLine("Trójkąt nie może powstać");
            }
            Console.ReadKey();
        }
    }
}

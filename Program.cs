using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Tere! See on toa pindala kalkulaator.");
        Console.WriteLine("Kas tuba on kolmnurk, ristkülik või ring?");
        Console.Write("Sisesta kujund: ");
        string kujund = Console.ReadLine().ToLower();

        double pindala = 0;

        if (kujund == "kolmnurk")
        {
            Console.Write("Sisesta alus: ");
            double alus = double.Parse(Console.ReadLine());
            Console.Write("Sisesta kõrgus: ");
            double korgus = double.Parse(Console.ReadLine());
            pindala = (alus * korgus) / 2;
        }
        else if (kujund == "ristkülik")
        {
            Console.Write("Sisesta pikkus: ");
            double pikkus = double.Parse(Console.ReadLine());
            Console.Write("Sisesta laius: ");
            double laius = double.Parse(Console.ReadLine());
            pindala = pikkus * laius;
        }
        else if (kujund == "ring")
        {
            Console.Write("Sisesta raadius: ");
            double r = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            pindala = pi * r * r;
        }
        else if (kujund == "ruut")
        {
            Console.WriteLine("Sisesta laius: ");
            double a = double.Parse(Console.ReadLine());
            pindala = a * a;
        }
        else if (kujund == "trap")
        {
            Console.WriteLine("Sisesta korgus: ");
            double korgus = double.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta alumine alus: ");
            double alumine = double.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta ülemine alus: ");
            double ülemine = double.Parse(Console.ReadLine());
            pindala = (alumine + ülemine) / 2 * korgus;
        }



        else
        {
            Console.WriteLine("Tundmatu kujund!");
            return;
        }

        Console.WriteLine("Pindala on: " + pindala);
    }
}





using System;

class Program
{
    static void Main(string[] args)
    {
        double n1, n2, media;

        Console.WriteLine("Qual sua nota no 1º semestre?");
        n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Qual sua nota no 2º semestre?");
        n2 = double.Parse(Console.ReadLine());

        media = (n1 + n2) / 2;
        Console.WriteLine($"A média é {media}");

    }
}

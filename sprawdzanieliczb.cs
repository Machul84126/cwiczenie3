using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę x:");
        int x = int.Parse(Console.ReadLine());

        int i = 1;
        int silnia = 1;

        while (true)
        {
            silnia *= i;
            if (silnia == x)
            {
                Console.WriteLine($"Liczba {x} jest silnią liczby {i}.");
                break;
            }
            else if (silnia > x)
            {
                Console.WriteLine($"Liczba {x} nie jest silnią żadnej liczby naturalnej.");
                break;
            }
            i++;
        }
    }
}
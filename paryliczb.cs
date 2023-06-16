using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                if (i + j == n)
                {
                    Console.WriteLine($"{i} + {j} = {n}");
                }
            }
        }
    }
}
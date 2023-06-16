using System;

class Program
{
    static void Main(string[] args)
    {
        int min = 1;
        int max = 20;
        Console.WriteLine("Pomyśl o liczbie z przedziału 1-20. Będę próbować ją odgadnąć.");
        while (true)
        {
            int guess = (min + max) / 2;
            Console.WriteLine($"Czy Twoja liczba to {guess}?");
            Console.WriteLine("Odpowiedz: -1 jeśli moja propozycja jest za mała, 1 jeśli za duża, 0 jeśli odgadłem.");
            int answer = int.Parse(Console.ReadLine());

            if (answer == 0)
            {
                Console.WriteLine($"Odgadłem! Twoja liczba to {guess}.");
                break;
            }
            else if (answer == -1)
            {
                min = guess + 1;
            }
            else if (answer == 1)
            {
                max = guess - 1;
            }
            else
            {
                Console.WriteLine("Nie rozpoznałem odpowiedzi. Spróbujmy jeszcze raz.");
            }
        }
    }
}
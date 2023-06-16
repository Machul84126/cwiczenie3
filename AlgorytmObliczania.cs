using System;

public class MyProgram
{
    public static void Main()
    {
        int n, k;
        Console.WriteLine("Wpisz liczbę n większą lub równą 5:");
        n = inputValue();
        Console.WriteLine("Wpisz liczbę k większą lub równą 5:");
        k = inputValue();

        int nSilnia = CalculateFactorial(n);
        int kSilnia = CalculateFactorial(k);

        int m = (nSilnia - kSilnia) / kSilnia;
        Console.WriteLine("Wynik m to: " + m);
    }

    private static int inputValue()
    {
        int Result = 0;
        bool isValid = false;

        while (!isValid)
        {
            string input = Console.ReadLine();
            isValid = int.TryParse(input, out Result) && Result >= 5;

            if (!isValid)
            {
                Console.WriteLine("Nieprawidłowe dane. Wprowadź liczbę naturalną większą lub równą 5.");
            }
        }

        return Result;
    }

    private static int CalculateFactorial(int number)
    {
        int factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
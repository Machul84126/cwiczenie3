using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj liczbę wyrazów ciągu Fibonacciego do wypisania:");
        int n = int.Parse(Console.ReadLine());
        PrintFibonacciSequence(n);
    }

    public static void PrintFibonacciSequence(int n)
    {
        if (n <= 0)
        {
            return;
        }
        
        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        
        if (n == 2)
        {
            Console.WriteLine(0);
            Console.WriteLine(1);
            return;
        }
        
        int[] fib = new int[n];
        fib[0] = 0;
        fib[1] = 1;
        
        Console.WriteLine(0);
        Console.WriteLine(1);
        
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i-1] + fib[i-2];
            Console.WriteLine(fib[i]);
        }
    }
}
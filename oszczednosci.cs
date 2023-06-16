using System;

public class MyProgram
{
    public static void Main()
    {
        decimal kwotaPoczatkowa, oprocentowanie;
        int liczbaMiesiecy;

        Console.WriteLine("Podaj kwotę początkową wpłacaną na konto oszczędnościowe:");
        kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Podaj oprocentowanie konta w skali roku:");
        oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Podaj liczbę miesięcy oszczędzania:");
        liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal podatekBelki = 0.19m; // Stawka podatku Belki wynosi 19%
       
        decimal kwotaZarobiona = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + (oprocentowanie / 12) / 100), liczbaMiesiecy);
        //decimal kwotaZarobiona = kwotaPoczatkowa * (decimal)Math.Pow((double)(1 + ((double)oprocentowanie / 12) / 100), liczbaMiesiecy);
        decimal zysk = kwotaZarobiona - kwotaPoczatkowa;
        decimal podatek = zysk * podatekBelki;
        decimal kwotaZarobionaPoOpodatkowaniu = zysk - podatek;

        Console.WriteLine("Kwota zarobiona na koncie oszczędnościowym po uwzględnieniu podatku Belki: " + kwotaZarobionaPoOpodatkowaniu);
    }
}
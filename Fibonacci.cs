public class MyProgram
{
    public static void Main()
    {
        double Liczba, Potega, Wynik;
        Console.WriteLine("Wpisz liczbę, którą chcesz potęgować");
        Liczba = inputValue();
        Console.WriteLine("Do której potęgi?");
        Potega = inputValue();
        Wynik = Math.Pow(Liczba, Potega);
        Console.WriteLine("Wynik potęgowania: " + Wynik);
    }

    private static int inputValue()
    {
        var Result = 0; // Initialize with a default value
        var isValid = false;

        while (!isValid)
        {
            var input = Console.ReadLine();
            isValid = int.TryParse(input, out Result) && Result >= 0;

            if (!isValid) Console.WriteLine("Nieprawidłowe dane. Wprowadź liczbę naturalną.");
        }

        return Result;
    }
}

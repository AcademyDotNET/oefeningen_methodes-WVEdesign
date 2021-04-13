using System;

//namespace Opwarmer_Berekenstraal
class Program
{
    public static void Main()
    {
        double result;
        double inputValue;

        Console.Write("Voer een diameter in om de straal te berekenen [mm]: ");
        inputValue = Convert.ToDouble(Console.ReadLine());
        
        result = straal(inputValue);
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"de straal is: {result} mm");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static double straal(double i)
    {
        i = i / 2;
        return i;
    }
}

using System;

//namespace Opwamer_omtrek_oppervlakte
class Program
{
    public static void Main()
    {
        double inputValue;
        double resultOmtrek;
        double resultOpp;

        Console.Write("Voer een diameter in om de omtrek en oppervlakte te berekenen [mm]: ");
        inputValue = Convert.ToDouble(Console.ReadLine());
        
        resultOmtrek = Omtrek(inputValue);
        resultOpp = Opp(inputValue);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Omtrek is: {resultOmtrek} mm, en Oppervlakte is: {resultOpp} mm.");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static double Omtrek(double i)
    {
        i = i * Math.PI;
        return i;
    }
    static double Opp(double i)
    {
        i = (Math.PI * Math.Pow(i,2))/4;
        return i;
    }
}
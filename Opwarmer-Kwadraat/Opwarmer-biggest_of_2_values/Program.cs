using System;

//Opwarmer_biggest_of_2_values
class Program
{
    public static void Main()
    {
        double inputValue1;
        double inputValue2;
        double grootste;
        
        Console.Write("Voer een eerste getal in: ");
        inputValue1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Voer een 2de getal in: ");
        inputValue2 = Convert.ToDouble(Console.ReadLine());

        grootste = checkGrootste(inputValue1,inputValue2);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Het grootste getal is {grootste}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static double checkGrootste(double i, double j)
    {
        if(i > j)
        {
            return i;
        }
        else
        {
            return j;
        }
    }
}
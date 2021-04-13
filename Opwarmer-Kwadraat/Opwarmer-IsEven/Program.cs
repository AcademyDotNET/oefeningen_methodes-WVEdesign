using System;

//namespace Opwarmer-IsEven
class Program
{
    public static void Main()
    {
        int inputValue;
        bool result;

        Console.Write("Voer een natuurlijk getal om te kijken of het even(true) of oneven(false) is: ");
        inputValue = Convert.ToInt32(Console.ReadLine());

        result = OddNumber(inputValue);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"result is: {result}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static Boolean OddNumber(int i)
    {
        if (i % 2 == 0)
        {
            return true;
        }
        else
        {
           return false;
        }
    }
}
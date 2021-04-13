using System;

//namespace Kwadraat
class Program
{
    public static void Main()
    {
        int result;
        int inputValue;

        Console.Write("Voer een natuurlijk getal in: ");
        inputValue = Convert.ToInt32(Console.ReadLine());
       
        result = kwadraat(inputValue);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"result is: {result}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static int kwadraat(int i)
    {
        i = i * i;
        return i;
    }
}


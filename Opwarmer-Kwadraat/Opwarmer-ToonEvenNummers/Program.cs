using System;

//Opwarmer-ToonEvenNummers
class Program
{
    public static void Main()
    {
        int inputValue;

        Console.Write("Voer een natuurlijk getal in om alle oneven nummers af te drukken: ");
        inputValue = Convert.ToInt32(Console.ReadLine());

        PrintAlleven(inputValue);
    }

    static void PrintAlleven(int i)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"alle oneven getallen van {i} tot 1; \n");
       
        do
        {
            i--;
            if (i % 2 == 1) // check oneven
            {
                Console.Write($"{i}, "); //print alle oneven nummers
            }
            else
            {
                
            }

        } while (i > 1);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"\n");
    }
}
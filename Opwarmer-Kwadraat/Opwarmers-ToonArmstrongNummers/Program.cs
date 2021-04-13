using System;

//Opwarmers-ToonArmstrongNummers
class Program
{
    public static void Main()
    {
        int inputValue;

        Console.Write("Voer een natuurlijk getal in om alle bijhorende Armstrong nummers af te drukken: ");
        inputValue = Convert.ToInt32(Console.ReadLine());

        PrintAllArmstrong(inputValue);
    }

    static void PrintAllArmstrong(int k)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"alle Armstrong getallen van {k} tot 1; \n");

        do
        {
            k--;
            if (IsArmstrong(k)) // check armstrong
            {
                Console.Write($"{k}, "); //print alle armstrong nummers
            }
            else
            {

            }

        } while (k > 1);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine($"\n");
    }
    static Boolean IsArmstrong(int i)
    {
        int lengthValue = Convert.ToString(i).Length;   //werkte eerst niet op deze plek, reden was dat .Lenght enkel op strings werkt
        int subInputValue = i;
        int subLengthValue = lengthValue;
        int ArmstrongValue = 0;

        do
        {
            lengthValue--;
            int cypher = (int)(subInputValue / Math.Pow(10, lengthValue));
            int difference = cypher * (int)Math.Pow(10, lengthValue);
            subInputValue -= difference;

            ArmstrongValue += (int)Math.Pow(cypher, subLengthValue);

            // debug
            //     Console.WriteLine($"Cypher {cypher}, another {lengthValue} digits..., ( subtractor = {difference} ), subvalue = {i}, armstrongValue = {ArmstrongValue} ");

        } while (lengthValue > 0);

        if (i == ArmstrongValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
using System;

//namespace Opwarmer-IsArmstrong
class Program
{
    public static void Main()
    {
        int inputValue;
        bool result;

        Console.Write("Voer een natuurlijk getal om te kijken of het al dan niet een Armstrong getal is: ");
        inputValue = Convert.ToInt32(Console.ReadLine());
        
        result = IsArmstrong(inputValue);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"result is: {result}");
        Console.ForegroundColor = ConsoleColor.Gray;
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

            Console.WriteLine($"Cypher {cypher}, another {lengthValue} digits..., ( subtractor = {difference} ), subvalue = {i}, armstrongValue = {ArmstrongValue} ");

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
/*
 * Maak een paswoord generator die paswoorden van bepaalde lengte genereert en bestaat uit willekeurige 
 * letters, hoofdletters en cijfers. Plaats deze code in een methode die 1 parameter aanvaardt namelijk 
 * de lengte van het paswoord dat gemaakt moet worden. De methode geeft het gegenereerde paswoord terug 
 * als resultaat. (tip gebruik een random number generator(s) om getallen te genereren die je ook kan 
 * casten naar chars dankzij de unicode waarde van chars).
*/

using System;

//namespace PaswoordGenerator
class Program
{
    public static void Main()
    {
        string result;
        int inputValue;

        Console.Write("Voer de lengte in voor uw gewenste random paswoord: ");
        inputValue = Convert.ToInt32(Console.ReadLine());

        result = PSWD_generator(inputValue);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"uw genereerd paswoord van {inputValue} lang is: {result}");
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    static string PSWD_generator(int i)
    {
        string paswoord = "";
        Random rnd_lowCase = new Random();
        Random rnd_HighCase = new Random();
        Random rnd_Num = new Random();

        do
        {
            
            if (i > 0)
            {
                char randomCharL = (char)rnd_lowCase.Next('a', 'z');
                paswoord += randomCharL;
                i--;
            }
            if (i > 0)
            {
                char randomCharH = (char)rnd_HighCase.Next('A', 'Z');
                paswoord += randomCharH;
                i--;
            }
            if (i > 0)
            {
                char randomCharN = (char)rnd_Num.Next('0', '9');
                paswoord += randomCharN;
                i--;
            }
            
        } while (i > 0);

        return paswoord;
    }
}


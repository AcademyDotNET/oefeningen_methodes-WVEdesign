using System;

//Film_default

class Program
{
    public enum Genre
    {
        Horror,
        Scifi,
        Fantasy,
        Onbekend
    }

    public static void Main()
    {

        FilmRunTime("Matrix", Genre.Scifi, 90);
        FilmRunTime("Matrix", Genre.Scifi);
        FilmRunTime("Matrix");

    }

    static void FilmRunTime(string filmNaam, Genre genre = Genre.Onbekend, int lengteMinuten = 90)
    {

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{filmNaam}, {lengteMinuten}, {genre}");
        Console.ForegroundColor = ConsoleColor.Gray;
            
    }
}
using System;

public class Welcome
{
    public string WelcomeMessage(int habitacion, int totalhabitaciones)
    {
        Console.WriteLine();
        Console.WriteLine("Has entrado en la habitación número {0} de {1}.", habitacion, totalhabitaciones);
        Console.WriteLine();
        Console.WriteLine("Examina la habitación.");
        Console.WriteLine();
        Console.Write("> ");
        string examinar = Console.ReadLine();
        return examinar;
    }

    public void GameOver()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Has llegado al final de mi primer juego.");
        Console.WriteLine("Dime por favor qué te parece en general");
        Console.WriteLine();
        Console.WriteLine("by MDT");
    }
}
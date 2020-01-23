using System;

public class Mesa
{
    protected int alto, ancho;
    protected bool mesaVista = false;
    
    public bool ExaminarMesa()
    {
        Console.WriteLine();
        Console.WriteLine("Es una mesa de comedor con cuatro patas.");
        mesaVista = true;
        return mesaVista;
    }

}
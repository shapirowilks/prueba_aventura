using System;

public class Puerta
{
    protected int alto, ancho;
    protected bool abierta = false;
    protected bool puertaVista = false;

    public bool ExaminarPuerta()
    {
        Console.WriteLine();
        Console.WriteLine("Es una puerta maciza, no parece que vaya a ceder. Tiene una cerradura de color azul.");
        return puertaVista = true;
    }

    public bool AbrirPuerta(bool tienellave)
    {
        if (tienellave == true)
        {
            Console.WriteLine("Puerta abierta.");
            abierta = true;
            return abierta;
        }
        else Console.WriteLine("Hace falta una llave.");
        return abierta;
    }
    
}
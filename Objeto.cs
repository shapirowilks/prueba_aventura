using System;

public class Objeto
{
    protected int size;
    protected bool llaveVista = false;
    protected bool llaveCogida = false;

    public bool ExaminarObjeto()
    {
        Console.WriteLine();
        Console.WriteLine("Es una llave azul.");
        return llaveVista = true;
    }

    public bool CogerObjeto()
    {
        Console.WriteLine();
        Console.WriteLine("Has cogido la llave y te la has guardado en el bolsillo.");
        return llaveCogida = true;

    }


}
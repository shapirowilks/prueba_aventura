using System;

public class Acciones
{
    public string AccionBasica()
    {
        Console.WriteLine();
        Console.WriteLine("¿Qué deseas hacer a continuación?");
        Console.WriteLine();
        Console.Write("> ");
        string accionBasica = Console.ReadLine();
        return accionBasica;
    }

    
    public int AccionMultiple(string decision)
    {
        //examinar puerta = 1; examinar mesa = 2; examinar objeto = 3; coger objeto = 4;  abrir puerta = 5;
        int respuesta = 0;
        if ((decision.IndexOf("puerta",0) >= 0) && ((decision.IndexOf("examinar",0) >= 0) || (decision.IndexOf("mirar",0) >= 0)))
            respuesta = 1;
        else if ((decision.IndexOf("mesa",0) >= 0) && ((decision.IndexOf("examinar",0) >= 0) || (decision.IndexOf("mirar",0) >= 0)))
            respuesta = 2;
        else if ((decision.IndexOf("llave",0) >= 0) && ((decision.IndexOf("examinar",0) >= 0) || (decision.IndexOf("mirar",0) >= 0)))
            respuesta = 3;
        else if ((decision.IndexOf("llave",0) >= 0) && (decision.IndexOf("coger",0) >= 0))
            respuesta = 4;
        else if ((decision.IndexOf("puerta",0) >= 0) && (decision.IndexOf("abrir",0) >= 0))
            respuesta = 5;
        return respuesta;

    }

    public void ObjetoVisto(string objetovisto)
    {
        Console.WriteLine("Ya has examinado {0} antes. Prueba otra cosa.", objetovisto);
        Console.WriteLine();
    }

    public void ObjetoCogido(string objetocogido)
    {
        Console.WriteLine("Ya has cogido {0} antes. Prueba otra cosa.", objetocogido);
        Console.WriteLine();
    }
}
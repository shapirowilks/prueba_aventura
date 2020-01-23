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
        //usamos un método creado específicamente para buscar en el array de la cadena
        
        int respuesta = 0;

        if ((EncontrarTexto(decision, "puerta") == true) && ((EncontrarTexto(decision, "examinar") == true)||(EncontrarTexto(decision, "mirar")==true)))
            respuesta = 1;
        else if ((EncontrarTexto(decision, "mesa") == true)&& ((EncontrarTexto(decision, "examinar") == true) || (EncontrarTexto(decision, "mirar") == true)))
            respuesta = 2;
        else if ((EncontrarTexto(decision, "llave") == true)&& ((EncontrarTexto(decision, "examinar") == true) || (EncontrarTexto(decision, "mirar") == true)))
            respuesta = 3;
        else if ((EncontrarTexto(decision, "llave") == true)&& ((EncontrarTexto(decision, "coger") == true)))
            respuesta = 4;
        else if ((EncontrarTexto(decision, "puerta") == true)&& ((EncontrarTexto(decision, "abrir") == true)))
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

    public bool EncontrarTexto(string cadena, string texto)
    {
        bool encontrado = false;
        string[] cadenaPartida = cadena.Split(' ');
        for (int i=0;i<cadenaPartida.Length;i++)
        {
            if (cadenaPartida[i] == texto)
            {
                encontrado = true;
            }
            
        }
        return encontrado;
    }
}
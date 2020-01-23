using System;

public class Inicial
{
        
    public static void Main()
    {
        //declaramos todas las clases
        Habitacion habitacion = new Habitacion();
        Mesa mesa = new Mesa();
        Objeto objeto = new Objeto();
        Puerta puerta = new Puerta();
        Welcome welcome = new Welcome();
        Acciones acciones = new Acciones();
        //usamos esto para el menú
        string accionPedida;
        int accionDevuelta;
        //declaramos las variables bool para saber si se han visto o cogido
        bool  puertavista = false, objetovisto = false,
            mesavista = false, objetocogido = false, estadopuerta = false;
        int numhabitaciones = 5;
        int habitacionactual = 1;
        do
        {

            Console.Clear();
            string welcomeString = welcome.WelcomeMessage(habitacionactual, numhabitaciones);
            while (welcomeString != "examinar")
            {
                Console.Clear();
                welcomeString = welcome.WelcomeMessage(habitacionactual, numhabitaciones);
            }

            habitacion.ExaminarHabitacion(habitacionactual);
            do
            {

                accionPedida = acciones.AccionBasica();
                accionDevuelta = acciones.AccionMultiple(accionPedida);
                Console.WriteLine();

                switch (accionDevuelta)
                {
                    case 1:
                        if (puertavista == true)
                            acciones.ObjetoVisto("la puerta");
                        else puertavista = puerta.ExaminarPuerta();
                        break;
                    case 2:
                        if (mesavista == true)
                            acciones.ObjetoVisto("la mesa");
                        else mesavista = mesa.ExaminarMesa();
                        break;
                    case 3:
                        if (objetovisto == true)
                            acciones.ObjetoVisto("la llave");
                        else objetovisto = objeto.ExaminarObjeto();
                        break;
                    case 4:
                        if (objetocogido == true)
                            acciones.ObjetoCogido(" la llave");
                        else objetocogido = objeto.CogerObjeto();
                        break;
                    case 5:
                        estadopuerta = puerta.AbrirPuerta(objetocogido);
                        break;
                    default: break;
                }

            }
            while (estadopuerta != true);

            Console.WriteLine();
            Console.WriteLine("Entrando en la habitación siguiente.");
            Console.WriteLine();
            Console.ReadLine();

            //incremento de habitacion
            habitacionactual++;

            //reiniciando valores
            puertavista = false;
            objetovisto = false;
            mesavista = false;
            objetocogido = false;
            estadopuerta = false;
        }
        while (habitacionactual <= numhabitaciones);

        welcome.GameOver();
        Console.ReadLine();

    }

}
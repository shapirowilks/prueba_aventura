using System;

public class Habitacion
{
    protected bool norte, sur, este, oeste;

    public void ExaminarHabitacion(int tipohabitacion)
    {
        switch (tipohabitacion)
        {
            case 1: Console.WriteLine();
                Console.WriteLine("Es una habitación amplia y oscura. En las paredes las grietas dibujan el camino hacia");
                Console.WriteLine("el corazón del edificio. El techo parece haber cedido en algunos puntos por los que");
                Console.WriteLine("se cuela una brisa desagradable. Delante de ti hay una mesa con una llave encima.");
                Console.WriteLine("En la pared de enfrente, junto a unos escombros, hay una puerta.");
                Console.WriteLine();
                break;
            case 2: Console.WriteLine();
                Console.WriteLine("Al pasar de la oscuridad a la luz te escuecen los ojos y tardas un poco en acostumbrarte.");
                Console.WriteLine("Un amplio ventanal ilumina la estancia aunque la suciedad y el moho le dan un ambiente");
                Console.WriteLine("siniestro. Se intuye un ruido que parece provenir del otro lado de la estancia, detrás de una");
                Console.WriteLine("puerta tan imponente como la anterior. En la habitación tambien hay una mesa y unas sillas,");
                Console.WriteLine("y una llave encima de la mesa.");
                break;
            case 3: Console.WriteLine();
                Console.WriteLine("Habitación 3, pendiente de escribir");
                break;
            case 4:
                Console.WriteLine();
                Console.WriteLine("Habitación 4, pendiente de escribir");
                break;
            case 5:
                Console.WriteLine();
                Console.WriteLine("Habitación 5, pendiente de escribir");
                break;
            default: break;
        }
        
        
    }

    public void CambiarHabitacion()
    {
        Console.WriteLine();
        Console.WriteLine("Entrando en la habitación siguiente.");
        Console.WriteLine();
        Console.ReadLine();
    }
    
        
}

    



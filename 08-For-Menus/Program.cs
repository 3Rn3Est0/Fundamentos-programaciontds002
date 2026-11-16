using System.Diagnostics.CodeAnalysis;

namespace _08_For_Menus;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al menu de opciones");
        while (true)
        {
            Console.WriteLine("Seleccione una opcion:");
        Console.WriteLine("1. Tabla de multiplicar");
        Console.WriteLine("2. Triangulo de asteriscos");
        Console.WriteLine("3. Salir");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                {  
            int a;
            int b;
            int resultado;
            
            
            for (a=1; a<13; a++)
            {
                if(a==13)
                break;
                for (b=1;b<13;b++)
                {
                    if(b==13)
                    break;
                    resultado= a*b;
                    Console.WriteLine($"{a} x {b} = {resultado}",4);
                }
            }
        }
                break;
            case "2":
                {
            int filas;

            Console.Write("Ingrese la cantidad de filas: ");

            while (!int.TryParse(Console.ReadLine(), out filas) || filas <= 0)
            {
                Console.Write("Entrada invalida. Ingrese un numero positivo: ");
            }

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            }


        }
                break;
            case "3":
                Console.WriteLine("Saliendo del programa...");
                return;
            default:
                Console.WriteLine("Opcion invalida. Intente nuevamente.");
                break;
        }
    }
    
    
    {
        
        
        

    }
    
}
}

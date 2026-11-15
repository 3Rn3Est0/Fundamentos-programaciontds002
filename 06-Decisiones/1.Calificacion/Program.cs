namespace _06_Decisiones;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese calificacion del estudiante (0-100):");
        int calificacion;
        do{
        if (int.TryParse(Console.ReadLine(), out calificacion))
        {
            if (calificacion >= 90)
            {
                Console.WriteLine("A");
            }
            else if (calificacion >= 80)
            {
                Console.WriteLine("B");
            }
            else if (calificacion >= 70)
            {
                Console.WriteLine("C");
            }
            else if (calificacion >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
        else //para entradas invalidas, como letras o símbolos, se muestra un mensaje de error
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
        }
    }
    while (calificacion < 0 || calificacion > 100); //se repite el bucle hasta que se ingrese una calificación válida
    }
}

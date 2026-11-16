namespace E05_Promedio_Validado;

class Program
{
    static void Main(string[] args)
    {
        int calificaciones;
        int notas=0;
        int cantidadDeNotas=0;
        int notaMasAlta= int.MinValue;
        int notaMasBaja= int.MaxValue;
        double promedio;

        Console.WriteLine("Introducir calificaciones del 0-100 (use -1 para terminar)");
        do
        {
            if(int.TryParse(Console.ReadLine(), out calificaciones))
            

            if(calificaciones != -1)
            {
                if(calificaciones < 0 || calificaciones > 100)
                {
                    Console.WriteLine("Entrada invalida, intente denuevo");
                }

                else
                    cantidadDeNotas++;
                    notas += calificaciones;

                    if(calificaciones> notaMasAlta)
                    {notaMasAlta=calificaciones;}

                    if (calificaciones < notaMasBaja)
                    {notaMasBaja = calificaciones;}

                    
            }


        } while (calificaciones != -1);
           
            promedio = notas / cantidadDeNotas;

        Console.WriteLine($"El promedio es {promedio}");
        Console.WriteLine($"La nota mas alta fue {notaMasAlta}");
        Console.WriteLine($"La nota mas alta fue {notaMasBaja}");
    }
}

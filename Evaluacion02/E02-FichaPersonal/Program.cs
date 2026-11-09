namespace E02_FichaPersonal;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "Ernesto Imbert  ";
        int edad = 19;
        double estatura = 1.78;
        bool trabaja = true;
        int anioActual = 2026;
        int trentaAnios = anioActual + 11;
    
        Console.WriteLine("**************************");
        Console.WriteLine("*     Ficha Personal     *");
        Console.WriteLine($"*Nombre: {nombre}*");
        Console.WriteLine($"*Edad: {edad,-18}*");
        Console.WriteLine($"*Estatura: {estatura,-14}*");
        Console.WriteLine($"*Trabaja: {trabaja,-15}*");
        Console.WriteLine($"*Año Actual: {anioActual,-12}*");
        Console.WriteLine($"*Año en 30: {trentaAnios,-13}*");
        Console.WriteLine("**************************");
    }
}

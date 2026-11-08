namespace _02_Variables;

class Program
{
    static void Main(string[] args)
    {
        string nombre = "Ernesto Imbert";
        int edad = 19;
        double estatura = 1.78;
        int ANIO_ACTUAL = 2026;
        int anioNacimiento = ANIO_ACTUAL - edad;

        Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad} años. Por lo tanto nací en el año {anioNacimiento} y mido {estatura} metros de estatura.");
    }
}

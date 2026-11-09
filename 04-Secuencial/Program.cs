namespace _04_Secuencial;

class Program
{
    static void Main(string[] args)
    {
        // Conversión de libras a kilogramos
        Console.WriteLine("Ingrese el peso en libras: ");
        Double libra = Convert.ToDouble(Console.ReadLine());
        Double peso = Math.Round(0.45359237 * libra, 2);
        Console.WriteLine($"Peso en kilogramos: {peso}");
    
        //conversion de farenheit a celsius
        Console.WriteLine("Ingrese la temperatura en grados Fahrenheit: ");
        Double farenheit = Convert.ToDouble(Console.ReadLine());
        Double celsius = Math.Round((farenheit - 32) * 5 / 9, 2);
        Console.WriteLine($"Temperatura en grados Celsius: {celsius}");
    }
}

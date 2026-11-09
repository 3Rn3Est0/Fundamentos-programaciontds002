namespace E02_ConversorMonedas;

class Program
{
    static void Main(string[] args)
    {
    Double TASA_USD = 0.016;
    Double PesosDominicanos;
    
Console.WriteLine("Ingrese la cantidad de pesos dominicanos a convertir: ");
PesosDominicanos = Convert.ToDouble(Console.ReadLine());

Double Dolares = PesosDominicanos * TASA_USD;
Console.WriteLine($"Dolares: {Dolares}");
    }
}

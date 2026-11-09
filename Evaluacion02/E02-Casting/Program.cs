namespace E02_Casting;

class Program
{
    static void Main(string[] args)
    {
        // Casting implicito
       Console.WriteLine("Ingrese un número decimal: ");
         Double numeroDecimal = Convert.ToDouble(Console.ReadLine());
         int parteEntera = (int)numeroDecimal;
         Console.WriteLine($"parte entera: {parteEntera}");

            // Casting explicito
         Console.WriteLine("Ingrese un número entero: ");
         int numeroEntero = Convert.ToInt32(Console.ReadLine());
         Double numeroDecimal2 = (double)numeroEntero;
         Console.WriteLine($"Número decimal convertido: {numeroDecimal}");
    }
}

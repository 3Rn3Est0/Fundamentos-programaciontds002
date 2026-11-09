namespace _03_Operadores;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número: ");
        Double numero1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número: ");
        Double numero2 = Convert.ToDouble(Console.ReadLine());

        Double suma = numero1 + numero2;
        Double resta = numero1 - numero2;
        Double multiplicacion = numero1 * numero2;
        Double divisionReal = (double)(numero1 / numero2);
        Double divisionEntera = (int)(numero1 / numero2);
        bool esPar = numero1 % 2 == 0;

        Console.WriteLine($" Resultados de las operaciones entre {numero1} y {numero2}:");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Resta: {resta}");
        Console.WriteLine($"Multiplicación: {multiplicacion}");
        Console.WriteLine($"División real: {divisionReal}");
        Console.WriteLine($"División entera: {divisionEntera}");
        Console.WriteLine($"Residuo: {numero1 % numero2}");
        Console.WriteLine($"¿El primero es par?: {esPar}");
    }
    
}
class Prueba_de_Escritorio 
{/*
PRUEBA DE ESCRITORIO
Valores:
x = 10
y = 3

Operación             Resultado
Suma:                 10 + 3 = 13
Resta:                10 - 3 = 7
Producto:             10 * 3 = 30
División real:        10 / 3 = 3.333333
División entera:      10 / 3 = 3
Residuo:              10 % 3 = 1
¿El primero es par?:  10 % 2 == 0 = true

*/}
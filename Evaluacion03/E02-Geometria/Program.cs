namespace E02_Geometria;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double perimetroCirculo = 2 * Math.PI * radio;

        Console.WriteLine($"Área del círculo: {areaCirculo}");
        Console.WriteLine($"Perímetro del círculo: {perimetroCirculo}");

        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del triángulo:");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

        double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;

        Console.WriteLine($"Área del triángulo: {areaTriangulo}");
        Console.WriteLine($"Hipotenusa del triángulo: {Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(alturaTriangulo, 2))}");
    }
}

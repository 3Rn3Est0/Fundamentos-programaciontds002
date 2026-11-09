using System.Diagnostics.CodeAnalysis;

namespace E03_Nomina;

class Program
{
    static void Main(string[] args)
    {
        string nombre;
        do
        {
            Console.WriteLine("Introduce el nombre del empleado:");
            nombre = Console.ReadLine() ?? "";
        } 
        while (string.IsNullOrWhiteSpace(nombre));
        
        Console.WriteLine("Introduce el salario base del empleado:");
        decimal salarioBase = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Introduce el número de horas trabajadas:");
        int horasTrabajadas = Convert.ToInt32(Console.ReadLine());
        Double AFP = 0.0287;
        Double SFS = 0.0304;
        Double SalarioBruto = (double)salarioBase * horasTrabajadas;
        Double DescuentoAFP = SalarioBruto * AFP;
        Double DescuentoSFS = SalarioBruto * SFS;
        Double SalarioNeto = SalarioBruto - DescuentoAFP - DescuentoSFS;

        Console.WriteLine($"Empleado: {nombre.ToUpper()}");
        Console.WriteLine($"Salario Bruto: {SalarioBruto,2}");
        Console.WriteLine($"Descuento AFP: {DescuentoAFP,2}");
        Console.WriteLine($"Descuento SFS: {DescuentoSFS,2}");
        Console.WriteLine($"Salario Neto: {SalarioNeto,2}");
    }
}

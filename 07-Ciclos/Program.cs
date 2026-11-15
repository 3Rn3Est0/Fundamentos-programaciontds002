namespace _07_Ciclos;

class Program
{
    static void Main(string[] args) 
    {
     
        {
           int numero;
              int suma = 0;
            do
             {
                Console.WriteLine("Ingrese un numero del 1 al 12 para ver la tabla de multiplicar:");
                numero = Convert.ToInt32(Console.ReadLine());

             if (numero < 1 || numero > 12)
            {
                Console.WriteLine("Numero no valido. Intente nuevamente.");
            }

            } while (numero < 1 || numero > 12);


            Console.WriteLine($"Tabla de multiplicar del {numero}:");

            for (int i = 1; i <= 10; i++)
        
            {
                suma += numero * i;
                Console.WriteLine($"{numero} x {i} = {numero * i}");
                
            }
            Console.WriteLine($"Sumatoria: {suma}");

        }
    }
}
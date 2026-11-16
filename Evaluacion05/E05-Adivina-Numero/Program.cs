using System.Diagnostics.CodeAnalysis;
using System.Security.AccessControl;

namespace _05_Adivina_Numero;

class Program
{
    static void Main(string[] args)
    {
        
        
        bool jugar = true;
        while (jugar)
        {int numeroSecreto = Random.Shared.Next(1, 101);
        int intentos = 0;
        int numeroIngresado;
        do
        {
            Console.WriteLine("Adivina el numero del 1 al 100");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());

            intentos++;

            if(numeroIngresado > numeroSecreto)
            Console.WriteLine("Menor");

            else if (numeroIngresado < numeroSecreto)
            Console.WriteLine("Mayor");

            else
            Console.WriteLine("Ganaste!");
            

        
        } while (numeroIngresado != numeroSecreto);
//Para que se genere un nuevo numero y no ocurra error se debe confirmar si volver a jugar otra vez
        Console.WriteLine($"Tus intentos fueron {intentos} ");
        Console.WriteLine("Seguir jugando?(s/n)");
        string respuesta = Console.ReadLine() ?? "";
        jugar=respuesta=="s";
    }

}
}

namespace E05_Caja_Registradora;

class Program
{
    static void Main(string[] args)
    {
        int cantidadDeProductos = 0;
        double subtotal = 0;
        double total = 0;
        double ITBIS = 0.18;

        do 
        {
            Console.WriteLine("Ingrese el precio del producto (o ingrese 0 para finalizar):");
            double precio = Convert.ToDouble(Console.ReadLine());

            if (precio < 0)
            {
                Console.WriteLine("Precio no válido. Intente nuevamente.");
                continue;
            }

            if (precio == 0)
            {
                break;
            }

            cantidadDeProductos++;
            subtotal += precio;

        } while (true);

        ITBIS = subtotal * 0.18;
        total = subtotal + ITBIS;

        Console.WriteLine($"Cantidad de productos: {cantidadDeProductos}");
        Console.WriteLine($"Subtotal: {subtotal}");
        Console.WriteLine($"ITBIS: {ITBIS}");
        Console.WriteLine($"Total: {total, 2}");

    }
}

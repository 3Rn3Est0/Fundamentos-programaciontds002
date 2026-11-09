namespace E03_Factura;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce el nombre del producto:");
        string nombreProducto = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Introduce el precio del producto:");
        decimal precioProducto = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Introduce la cantidad de productos:");
        int cantidadProductos = Convert.ToInt32(Console.ReadLine());
        Double ITBIS = 0.18;
        Double Subtotal = (double)precioProducto * cantidadProductos;
        Double Descuento = Subtotal * 0.10; // Descuento del 10%
        Double ITBISCalculado = (Subtotal - Descuento) * ITBIS;
        Double TotalFactura = Subtotal - Descuento + ITBISCalculado;

        Console.WriteLine($"{"Producto:",-10} {nombreProducto.PadLeft(20)}");
        Console.WriteLine($"{"Subtotal:",-10} {Subtotal,20:F2}");
        Console.WriteLine($"{"Descuento:",-10} {Descuento,20:F2}");
        Console.WriteLine($"{"ITBIS:",-10} {ITBISCalculado,20:F2}");
        Console.WriteLine($"{"Total Factura:",-5} {TotalFactura,16:F2}");
    }
}

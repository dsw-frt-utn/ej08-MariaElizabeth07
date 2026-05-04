namespace Dsw2026Ej8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ProductHelper helper = new ProductHelper();

            long code = 1001;
            string description = "Mouse";
            decimal price = 6999.99m;

            string etiqueta = helper.ObtenerEtiquetaProducto(code, description, price);

            Console.WriteLine("    Etiqueta:");
            Console.WriteLine(etiqueta);

            Problema2 p2 = new Problema2();

            int quantity = 2;

            string resultado = p2.CrearResumenVenta(code, description, quantity, price);

            Console.WriteLine("\n    Resumen de Venta:");
            Console.WriteLine(resultado);


        }
    }
}

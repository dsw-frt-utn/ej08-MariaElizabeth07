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

            Console.WriteLine("     Etiqueta:");
            Console.WriteLine(etiqueta);

        }
    }
}

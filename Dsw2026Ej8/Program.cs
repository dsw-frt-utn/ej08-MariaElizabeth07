namespace Dsw2026Ej8
{

    //Alumna:MORALES, María Elizabeth - 56030
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("           Trabajo Practico Nro 8");

            Console.WriteLine("\n   ********** PROBLEMA 1: **********");

            ProductHelper helper = new ProductHelper();

            long code = 1001;
            string description = "Mouse";
            decimal price = 6999.99m;

            string etiqueta = helper.ObtenerEtiquetaProducto(code, description, price);

            Console.WriteLine("    Etiqueta:");
            Console.WriteLine(etiqueta);

            //----

            Console.WriteLine("\n   ********** PROBLEMA 2: **********");

            Problema2 p2 = new Problema2();

            int quantity = 2;

            string resumen = p2.CrearResumenVenta(code, description, quantity, price);

            Console.WriteLine("\n    Resumen de Venta:");
            Console.WriteLine(resumen);

            //---

            Console.WriteLine("\n   ********** PROBLEMA 3: **********");

            Product product = new Product { Description = "Mouse Original" };
            int num = 10;

            Problema3 p3 = new Problema3();
            string cambio = p3.CompararCopias(num, product);

            Console.WriteLine("\n    Modificar Descripción:");
            Console.WriteLine(cambio);

            //----

            Console.WriteLine("\n   ********** PROBLEMA 4: **********");

            Problema4 prom = new Problema4();

            double promedio = prom.CalcularPromedio(5, null, 7);

            Console.WriteLine($"\n    Promedio de Notas: {promedio:N2}");

            //----

            Console.WriteLine("\n   ********** PROBLEMA 5: **********");

            Sale ventaMinorista = new RetailSale { Amount = 1000m };

            Sale ventaMayorista = new WholesaleSale { Amount = 1000m };

            Problema5 venta = new Problema5();

            Console.WriteLine("\n    Importe de Venta:");
            Console.WriteLine($"    Minorista (1000): {venta.ObtenerImporteFinal(ventaMinorista):C}");
            Console.WriteLine($"    Mayorista (1000 - 10%): {venta.ObtenerImporteFinal(ventaMayorista):C}");

            //---

            Console.WriteLine("\n   ********** PROBLEMA 6: **********");

            Problema6 p6 = new Problema6();

            string codigoSucio = " ab 123 x ";
            string codigoLimpio = p6.NormalizarCodigoProducto(codigoSucio);

            Console.WriteLine("\n    Normalizar Codigo de Producto");
            Console.WriteLine($"    Original: '{codigoSucio}'");
            Console.WriteLine($"    Normalizado: {codigoLimpio}");

        }
    }
}

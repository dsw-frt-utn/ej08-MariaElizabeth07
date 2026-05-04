using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        public const string Separador = "-";

        public bool ValidarPrecio(decimal price) => price > 0;

    }
}

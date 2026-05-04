using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        public string? Description { get; set; }

        public void CambiarDescripcion(string nuevaDesc)
        {
            Description = nuevaDesc;
        }

    }
}

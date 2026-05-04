using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4{
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double suma = 0;
            int contador = 0;

            int?[] notas = { nota1, nota2, nota3 };

            foreach (var nota in notas) {
                
                if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
                {
                    suma += nota.Value;
                    contador++;
                }

            }

            if (contador == 0)
            {
                return 0;
            }

            return suma / contador;
        }
    }
}

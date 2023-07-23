using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class Calculo
    {

        public void Calcular(int valor1, int valor2)
        {
            var soma = valor1 + valor2;
            Console.WriteLine($"Os valores {valor1} + {valor2} = {soma}");
        }
    }
}

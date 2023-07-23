using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
    public class ListaArray
    {
        public void Array()
        {
            int[] array = new int[3];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;

            int contador = 0;
            foreach (var item in array)
            {
                contador++;
                Console.WriteLine($"foreach: Array posição {contador} tem o valor {item} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"for: Array posição {i} tem o valor {array[i]} ");
            }
        }

        public void Lista()
        {
            List<string> lista = new List<string>();
            lista.Add("A");
            lista.Add("B");
            lista.Add("C");

            int contador = 0;
            foreach (var item in lista)
            {
                contador++;
                Console.WriteLine($"foreach: Lista posição {contador} tem o valor {item} ");
            }
        }
    }
}

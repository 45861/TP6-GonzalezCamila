using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
            //Crea un procedimiento “convertirEspaciado”, que reciba como argumento un texto y muestra una
            //cadena con un espacio adicional tras cada letra.Por ejemplo, “Hola, epet5” devolverá “H o l a, e p e t 5
            //“. Crea un programa principal donde se use dicho procedimiento.
        {
            Console.WriteLine("Ingrese un texto:");
            string texto = Console.ReadLine();

            convertirEspaciado(texto);

            Console.ReadKey();
        }

        // Procedimiento para convertir el texto con espacios adicionales
        static void convertirEspaciado(string texto)
        {
            string textoConEspacios = "";
            foreach (char c in texto)
            {
                textoConEspacios += c + " ";
            }
            Console.WriteLine(textoConEspacios.Trim());
        }
    }
}

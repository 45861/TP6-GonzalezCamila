using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
            //Diseñar un procedimiento que reciba una frase, y el programa remueva todas las vocales . Al final el
            //procedimiento mostrará la frase final.
            //Por ejemplo:
            //Entrada: “Habia una vez un barco”
            //Salida: “Hb n vz n brc"
        {
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();

            RemoverVocales(frase);

            Console.ReadKey();
        }

        // Procedimiento para remover las vocales de una frase
        static void RemoverVocales(string frase)
        {
            string fraseSinVocales = "";

            foreach (char c in frase)
            {
                if (!"aeiouAEIOU".Contains(c))
                {
                    fraseSinVocales += c;
                }
            }

            Console.WriteLine("Frase sin vocales: " + fraseSinVocales);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
            //Realizar un programa que pida al usuario una frase y una letra a buscar en esa frase. La función debe
            //devolver la cantidad de veces que encontró la letra.Nota: recordar el uso de la función Subcadena(). 
        {
            // Pedir al usuario que ingrese una frase
            Console.WriteLine("Ingrese una frase:");
            string frase = Console.ReadLine();

            // Pedir al usuario que ingrese una letra
            Console.WriteLine("Ingrese una letra a buscar en la frase:");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Para mover el cursor a la siguiente línea

            // Llamar a la función para contar las ocurrencias de la letra
            int cantidad = ContarOcurrencias(frase, letra);

            // Mostrar el resultado
            Console.WriteLine($"La letra '{letra}' se encuentra {cantidad} veces en la frase.");

            Console.ReadKey();
        }

        // Función para contar las ocurrencias de una letra en una frase
        static int ContarOcurrencias(string frase, char letra)
        {
            int contador = 0;

            // Recorrer la frase para contar las ocurrencias de la letra
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == letra)
                {
                    contador++;
                }
            }

             return contador;
        }
    }
}

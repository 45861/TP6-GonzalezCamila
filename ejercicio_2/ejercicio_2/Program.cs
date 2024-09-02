using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
            /* Realizara una funcion que valide si un numero es impar o no. Si es impar la funcion debe devolver un verdaddero, si no
             * es impar debe devolver falso. Nota: la funcion no debe tener mensajes que digan si es par o no.*/
        {
           
            Console.WriteLine("Ingrese un número:");
            int numero = int.Parse(Console.ReadLine());

            bool esImpar = EsImpar(numero);

            Console.WriteLine($"{esImpar}");

            Console.ReadKey();
        }

        // Función para verificar si un número es impar
        static bool EsImpar(int numero)
        {
            return numero % 2 != 0;
        }
    }
}


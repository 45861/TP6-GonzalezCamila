using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
            //Crear un programa que dibuje una escalera de números, donde cada línea de números comience en uno
            //y termine en el número de la línea.Solicitar la altura de la escalera al usuario al comenzar.Ejemplo: si se      
            //ingresa el número 3:
            //1
            //12
            //123
        {
            Console.WriteLine("Ingrese la altura de la escalera:");
            int altura = int.Parse(Console.ReadLine());

            DibujarEscalera(altura);
        }

        // Procedimiento para dibujar la escalera de números
        static void DibujarEscalera(int altura)
        {
            for (int i = 1; i <= altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine(); // Mover a la siguiente línea después de cada fila
            }
        }
    }
}

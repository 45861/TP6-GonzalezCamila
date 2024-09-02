using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        /* Crear una funcion que calcule la suma de dos numeros. En el programa principal, solicitaremos al usuario que ingrese
         * los dos numeros para luego pasarlos como argumentos a la funcion. La funcion realizara el calculo de la sma y devolvera el resultado, 
         que sera mostrado para su visualizacion.*/

        {

            // Función para calcular la suma de dos números
            int CalcularSuma(int num1, int num2)
            {
                return num1 + num2;
            }
                Console.WriteLine("Ingrese el primer número:");
                int numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número:");
                int numero2 = Convert.ToInt32(Console.ReadLine());

                int resultado = CalcularSuma(numero1, numero2);
                Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, resultado);

                Console.ReadKey();


            
        }
    }
}

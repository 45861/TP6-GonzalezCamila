using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
            //Crear una función llamada “Login”, que recibe un nombre de usuario y una contraseña y que devuelve
            //Verdadero si el nombre de usuario es “usuario1” y si la contraseña es “epet5”. Además, la función
            //calculara el número de intentos que se ha usado para loguearse, tenemos solo 3 intentos, si nos
            //quedamos sin intentos la función devolverá Falso.
        {
            int intentos = 0;
            bool loggedIn = false;

            while (intentos < 3 && !loggedIn)
                
            {
                Console.WriteLine("Ingrese el nombre de usuario:");
                string usuario = Console.ReadLine();

                Console.WriteLine("Ingrese la contraseña:");
                string contraseña = Console.ReadLine();

                // Llamar a la función Login
                loggedIn = Login(usuario, contraseña, ref intentos);

                if (loggedIn)
                {
                    Console.WriteLine("Inicio de sesión exitoso.");
                }
                else
                {
                    Console.WriteLine($"Inicio de sesión fallido. Intentos restantes: {3 - intentos}");
                }
            }

            if (!loggedIn)
            {
                Console.WriteLine("Se han agotado los intentos. Acceso denegado.");
            }

            Console.ReadKey();
        }

        // Función para verificar el login
        static bool Login(string usuario, string contraseña, ref int intentos)
        {       
            intentos++;
            if (usuario == "usuario1" && contraseña == "epet5")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

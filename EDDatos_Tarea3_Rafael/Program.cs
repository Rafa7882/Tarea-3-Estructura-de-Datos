using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDatos_Tarea3_Rafael
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tarea 1;
            Console.WriteLine("Escriba su Usuario Numérico:");
            String usuario = Console.ReadLine();
            Console.WriteLine("Escriba su Contraseña:");
            String contraseña = Console.ReadLine();

            String UsuarioCorrecto = "1234";
            String ContraseñaCorrecta = "1111";

            if (usuario != UsuarioCorrecto || contraseña != ContraseñaCorrecta)
            {
                Console.WriteLine("Contraseña Incorrecta, Intente de nuevo");
                Console.ReadLine();
            }
            else
            { 
                Console.WriteLine("Bienvenido");
             Console.ReadLine();
            }
           */
            /*Tarea 2;
            int numero;
            int resto;
            int contador = 0;
            Console.WriteLine("Escriba un número para calcular la cantidad de cifras:");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero > 0)
            {
                resto = numero % 10;
                contador++;
                numero = numero / 10;
            }
            Console.WriteLine("Su número tiene {0} cifras", contador);
            Console.ReadKey();
            */
            /*Tarea 3;
            int numero = 9;
            int multiplicador;
            int resultado = 0;
            Console.WriteLine("TABLA DE MULTIPLICACION \n\nTabla del 9\n");

            for (multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                resultado = numero * multiplicador;
                Console.WriteLine(numero + " x " + multiplicador + " = " + resultado);
            }
            Console.ReadLine();
            */
            /*Tarea 4;
            int x = 1;
            do
            {
                x++;
                Console.WriteLine(x);
            }
            while (x > 0);
            Console.ReadLine();
            */
            /*Tarea 5;
            int saludo = 0;
            do
            {
                Console.WriteLine("Hola");
            }
            while (saludo == 0);
            Console.ReadLine();
            */
            /*Tarea 9: Crear un programa que pida al usuario un nombre y una contraseña. La contraseña se debe introducir dos veces.Si las dos contraseñas no son iguales, se avisará al usuario y se le volverán a pedir las dos contraseñas.
              Tarea 10: Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Martín", o bien le diga "No te conozco" si teclea otro nombre.
            */
            /*Tarea 6;
            int a = 5;
            int b = ++a;
            int c = a;
            b = b*5;
            a = a * 2;
            Console.WriteLine("A = {0}\nB = {1}\nC = {2}", a, b, c);
            Console.ReadKey();
            */
            /*Tarea 7;
            int a = 5;
            int b = a+2;
            int c = -3;
            b -= 3;
            c *= 2;
            a *= b;
            Console.WriteLine("A = {0}\nB = {1}\nC = {2}", a, b, c);
            Console.ReadKey();
            */
            /*Tarea 8;
            char letra;
            bool EsUnaVocal;
            Console.WriteLine("Escriba una letra en minúscula:");
            letra = Convert.ToChar(Console.ReadLine());
            EsUnaVocal = (letra == 'a') || (letra == 'e') || (letra == 'i') || (letra == 'o') || (letra == 'u');
            if (EsUnaVocal)
                Console.WriteLine("La letra que escribió es una vocal");
            else
                Console.WriteLine("La letra que escribió o es una consonante o está en mayúscula");
            Console.ReadLine();
            */
            /*Tarea 9;
            Console.WriteLine("Escriba su Usuario:");
            String usuario = Console.ReadLine();
            Console.WriteLine("Escriba su Contraseña:");
            String contraseña1 = Console.ReadLine();
            Console.WriteLine("Escriba de nuevo su Contraseña:");
            String contraseña2 = Console.ReadLine();

            String UsuarioCorrecto = "rafa";
            String ContraseñaCorrecta = "7882";

            if (usuario != UsuarioCorrecto || contraseña1 != ContraseñaCorrecta || contraseña1 != contraseña2)
            {
                Console.WriteLine("Usuario o contraseña Incorrectos, Intente de nuevo");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Bienvenido");
                Console.ReadLine();
            }
            */
            /*Tarea 10;
            Console.WriteLine("Bienvenido, por favor ingrese su nombre:");
            string usuario = Console.ReadLine();

            string usuario_valido = "Martin";

            if (usuario == usuario_valido)
            {
                Console.WriteLine("Hola, Martín");
            }
            else
            {
                Console.WriteLine("No te conozco");
            }
            Console.ReadLine();
            */
        }
    }
}


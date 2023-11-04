using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; //Variable numerica de tipo entero. Toma numeros enteros
            decimal x = 0.0m; //Variable numerica de tipo decimal. Toma numeros decimales con pocos digitos despues de la coma.
            float f = 0.0f; //Variable numerica de tipo decimal. Toma mas numeros decimales con mas prescicion que el decimal.
            double d = 0.0d; //Variable numerica de tipo decimal. Toma mas numeros decimales con mas prescicion que el float.
            string cadena = ("Hola mundo"); //Cadena de caracteres.
            bool bandera = false; //Variable booleana. Toma verdadero o falso como valor.
            DateTime fecha = DateTime.MinValue; //Variable de una clase que puede guardar tanto la fecha como la hora.

            Console.WriteLine("El valor de i es: {0}", i); //Para poner la variable i se pone entre las comillas donde se desea insertar un {0} y luego de las comillas se inserta una coma y la variable. Si se desea insertar mas de una variable, se agregan mas {0} y luego de las comillas se ponen en orden separandolas por comas
            Console.WriteLine("El valor de x es: {0:C}", x); //{0:C} sirve para indicar un formato de moneda. La variable x va a salir representada con un formato de tipo moneda. Mas formatos https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/formatting-numeric-results-table
            Console.WriteLine("El valor de f es: {0:F2}", f); //{0:F2} f es para mostrar el punto fijo y 2 indica la cantidad de decimales despues de la coma que va a mostrar.
            Console.WriteLine("El valor de d es: {0:F2}", d);
            Console.WriteLine("El valor de la cadena es: " + cadena); //Para poner una cadena se pone + y el nombre de la cadena. (Las cadenas se suman)
            Console.WriteLine("El valor de bandera es: " + bandera.ToString()); //ToString combierte bandera en un string para sumarlo al anterior.
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString()); //ToShortDateString sirve para presentar en formato de fecha corta esa fecha.

            Console.ReadKey();
        }
    }
}

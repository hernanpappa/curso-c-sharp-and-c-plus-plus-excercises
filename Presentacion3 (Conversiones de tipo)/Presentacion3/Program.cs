using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = string.Empty; //string.Empty declara la cadena como vacia
            DateTime fecha = DateTime.MinValue;

            //Para convertir una variable en otra se puede hacer de la siguiente manera (conversion de manera implicita):
            // (Tabla de conversiones implicitas) https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/implicit-numeric-conversions-table
            x = i;

            //x = i; se puede
            //i = x; no se puede porque se perderian datos
            //para convertir i en x se procede de la siguiente manera (conversion de manera explicita):
            // (Tabla de conversiones explicitas) https://docs.microsoft.com/es-es/dotnet/csharp/language-reference/keywords/explicit-numeric-conversions-table
            i = (int)x;
            //Tambien se puede hacer asi:
            i = Convert.ToInt32(x); //En este caso se usa ToInt32 porque es el int general

            //Se puede convertir un valor booleano en entero de la siguiente manera
            i = Convert.ToInt32(bandera);

            //Una cadena no puede ser convertida a una entero si por ejemplo cadena = "H";
            //i = Convert.ToInt32(cadena); Va a dar error

            //Pero si cadena tiene un valor numerico si se puede
            cadena = "123465";
            i = Convert.ToInt32(cadena);



            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de cadena es: " + cadena);
            Console.WriteLine("El valor de fecha es: " + fecha.ToShortDateString());
            
            Console.ReadKey();
        }
    }
}

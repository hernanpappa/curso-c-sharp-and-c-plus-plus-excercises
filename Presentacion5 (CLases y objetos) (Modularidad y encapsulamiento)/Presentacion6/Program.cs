using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion6
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados empleado;
            empleado = new Empleados();

            empleado.Edad = 17;
            empleado.Nombre = "Hernan";
            empleado.SueldoDiario = 462.5m;

            decimal total;
            total = empleado.CalculaSalario(30);

            Console.WriteLine("El salario mensual del empleado " + empleado.Nombre);
            Console.WriteLine("es de " + total.ToString("C"));
            Console.ReadKey();


        }
    }
}

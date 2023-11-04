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
            ClientesVentas cliente;
            cliente = new ClientesVentas();

            cliente.IdCliente = 123;
            cliente.Apellidos = "Pappa Puglisi";
            cliente.Nombres = "Hernan David";
            cliente.RFC = "HEHM";
            cliente.Direccion = "Av. Luro 9739";
            cliente.Colonia = "Jorge Newery";
            cliente.Municipio = "General Puyrredon";
            cliente.EsCredito = true;

            Console.WriteLine(cliente.Apellidos + " " + cliente.Nombres);
            Console.WriteLine(cliente.Direccion + " " + cliente.Colonia + " " + cliente.Municipio);
            Console.WriteLine(cliente.RFC);

            if (cliente.EsCredito)
            {
                Console.WriteLine("El cliente tiene credito");
            }
            else
            {
                Console.WriteLine("El cliente no tiene credito");
            }

            Console.ReadKey();






        }
    }
}

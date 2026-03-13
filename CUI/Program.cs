using BLL;
using EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI
{
    internal class Program
    {
        // instancia de la clase ClienteBLL
        private static ClienteBLL _clienteBLL;

        static void Main(string[] args)
        {
            // menu

            do
            {
                Console.WriteLine("Ingresa una opcion:");
                Console.WriteLine("1. Insertar un cliente\n2. Mostrar listado de clientes\n0. Salir");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Hasta pronto! ....");
                            return;
                        case 1:
                            GuardarCliente();
                            break;
                        case 2:
                            Console.WriteLine("Proximamente...");
                            break;
                        default:
                            break;
                    }
                }

            } while (true);
        }

        private static void GuardarCliente()
        {
            // crear un objeto cliente vacio
            Cliente cliente = new Cliente();

            Console.Write("Ingresa los nombres: ");
            cliente.Nombres = Console.ReadLine();

            Console.Write("Ingresa los apellidos: ");
            cliente.Apellidos = Console.ReadLine();

            Console.Write("Ingresa el documento: ");
            cliente.Documento = Console.ReadLine();

            Console.Write("Ingresa el correo electronico: ");
            cliente.Email = Console.ReadLine();

            Console.Write("Ingresa el numero de telefono: ");
            cliente.Telefono = Console.ReadLine();

            cliente.FechaRegistro = DateTime.Now;

            // incializamos la instancia de la clase ClienteBLL
            _clienteBLL = new ClienteBLL();

            // guardar el cliente
            int resultado = _clienteBLL.Guardar(cliente);

            if (resultado > 0)
            {
                Console.WriteLine("Cliente almacenado con exito!");
            }
            else
            {
                Console.WriteLine("Ocurrio un error al guardar el cliente!");
            }
        }
    }
}

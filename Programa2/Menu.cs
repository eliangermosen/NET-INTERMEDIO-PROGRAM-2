using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    internal class Menu
    {
        Cliente clienteManuel = new Cliente()
        {
            Id = 11,
            FullName = "Manuel",
            Ahorros = 200200.86m
        };
        Cliente clienteStacy = new Cliente()
        {
            Id = 22,
            FullName = "Stacy",
            Ahorros = 150200.23m
        };
        Cliente clienteJohn = new Cliente()
        {
            Id = 33,
            FullName = "John",
            Ahorros = 100200.86m
        };
        List<Cliente> clientesLista;
        public Menu()
        {
            clientesLista = new List<Cliente>
            {
                clienteManuel,
                clienteStacy,
                clienteJohn
            };
        }

        public void MenuInicio()
        {
            Console.WriteLine("\nBanco\n");
            Console.WriteLine("Ingrese su PIN unico:");
            int pin = Convert.ToInt32(Console.ReadLine());

            var consultarCliente = clientesLista.FirstOrDefault(x => x.Id == pin);

            if (consultarCliente is not null)
            {
                MenuBancario(consultarCliente);
            }
            else
            {
                Console.WriteLine("EL CLIENTE NO EXISTE!");
            }

        }

        public void MenuBancario(Cliente cliente)
        {
            int opcion;
            do
            {
                Console.WriteLine($"\nBienvenido a su Banco {cliente.FullName}\n");
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1: Deposito");
                Console.WriteLine("2: Extraccion");
                Console.WriteLine("3: Consulta Balance");
                Console.WriteLine("4: Cerrar Sesion y Realizar Calculo");

                opcion = Convert.ToInt32(Console.ReadLine());
                Opciones(opcion, cliente);

            } while (opcion != 4);
        }

        public void Opciones(int opcion, Cliente cliente)
        {
            Banco banco = new Banco(cliente);
            decimal cantidad;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la cantidad a Depositar");
                    cantidad = Convert.ToDecimal(Console.ReadLine());
                    banco.Deposito(cantidad);
                    break;
                case 2:
                    Console.WriteLine("Ingrese la cantidad a Extraer");
                    cantidad = Convert.ToDecimal(Console.ReadLine());
                    banco.Extraccion(cantidad);
                    break;
                case 3:
                    banco.ConsultarBalance();
                    break;
                case 4:
                    banco.CalculoFinal(clientesLista);
                    break;
                default:
                    break;
            }
        }
    }
}

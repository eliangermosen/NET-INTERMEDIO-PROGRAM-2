using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    internal class Banco : IBanco
    {
        Cliente cliente = new Cliente();

        public Banco(Cliente cliente)
        {
            this.cliente = cliente;
        }

        public void Deposito(decimal cantidad)
        {
            cliente.Ahorros = cliente.Ahorros + cantidad;
            Console.WriteLine("\nDeposito realizado exitosamente!\n");
        }
        public void Extraccion(decimal cantidad)
        {
            if(cliente.Ahorros > cantidad)
            {
                cliente.Ahorros = cliente.Ahorros - cantidad;
                Console.WriteLine("\nExtraccion realizada exitosamente!\n");
            }
            else
            {
                Console.WriteLine("\nNo cuenta con balance disponible para la Extraccion!\n");
            }
        }
        public void CalculoFinal(List<Cliente> clientes)
        {
            var calculo = clientes.Sum(s => s.Ahorros);
            Console.WriteLine($"\nCantidad disponible {calculo}");
            Console.WriteLine("\nSesion Cerrada y Calculo Realizado Exitosamente!\n");
        }
        public void ConsultarBalance()
        {
            Console.WriteLine($"\nSus ahorros disponibles son {cliente.Ahorros}\n");
        }
    }
}

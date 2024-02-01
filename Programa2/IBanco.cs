using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa2
{
    internal interface IBanco
    {
        void Deposito(decimal cantidad);
        void Extraccion(decimal cantidad);
        void ConsultarBalance();
        void CalculoFinal(List<Cliente> clientes);
    }
}

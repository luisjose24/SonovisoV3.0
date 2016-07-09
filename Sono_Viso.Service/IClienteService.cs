using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Service
{
    public interface IClienteService
    {
        IEnumerable<Cliente> GetClientes(string criterio);
        Cliente GetCliente(Int32 id);
        Cliente AddCliente(Cliente cliente);
        void EditCliente(Cliente cliente);
        void DeleteCliente(Int32 id);
    }
}

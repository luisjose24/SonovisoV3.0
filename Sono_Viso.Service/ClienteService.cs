using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class ClienteService:IClienteService
    {
        public IClienteRepository ClienteRepository { get; set; }

        public ClienteService()
        {
            if (ClienteRepository == null)
            {
                ClienteRepository = new ClienteRepository();
                ;
            }
        }
        public Cliente AddCliente(Cliente cliente)
        {
            return ClienteRepository.AddCliente(cliente);
        }

        public void DeleteCliente(int id)
        {
            ClienteRepository.DeleteCliente(id);
        }

        public void EditCliente(Cliente cliente)
        {
            ClienteRepository.EditCliente(cliente);
        }

        public Cliente GetCliente(int id)
        {
            return ClienteRepository.GetCliente(id);
        }

        public IEnumerable<Cliente> GetClientes(string criterio)
        {
            return ClienteRepository.GetClientes(criterio);
        }
    }
}

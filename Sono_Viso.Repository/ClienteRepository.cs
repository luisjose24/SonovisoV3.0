using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class ClienteRepository: MasterRepository,IClienteRepository
    {
        public Cliente AddCliente(Cliente cliente)
        {
            Context.Clientes.Add(cliente);
            Context.SaveChanges();
            return cliente;
        }

        public void DeleteCliente(int id)
        {
            var existe = Context.Clientes.Find(id);
            if (existe != null)
            {
                Context.Clientes.Remove(existe);
                Context.SaveChanges();
            }
        }

        public void EditCliente(Cliente cliente)
        {

            Context.Entry(cliente).State = EntityState.Modified;
            Context.SaveChanges();

        }

        public Cliente GetCliente(int id)
        {
            return Context.Clientes.Find(id);
        }

        public IEnumerable<Cliente> GetClientes(string criterio)
        {
            var query = from c in Context.Clientes
                        select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                        where c.Apellidos.ToUpper().Contains(criterio.ToUpper()) || c.Nombres.ToUpper().Contains(criterio.ToUpper())
                        select c;
            }
            return query;
        }
    }
}

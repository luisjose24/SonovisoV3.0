using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class ProduccionRepository : MasterRepository, IProduccionRepository
    {

        public IEnumerable<Produccion> GetProduccions(string criterio)
        {
            var query = from p in Context.Produccions
                select p;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from p in query
                    where p.Nombre.ToUpper().Contains(criterio.ToUpper())
                    select p;
            }
            return query;
        }

        public Produccion GetProduccion(int id)
        {
            return Context.Produccions.Find(id);
        }


        public Produccion AddProduccion(Produccion produccion)
        {
            Context.Produccions.Add(produccion);
            Context.SaveChanges();
            return produccion;
        }

        public void DeleteProduccion(int id)
        {
            var existe = Context.Produccions.Find(id);
            if (existe!= null)
            {
                Context.Produccions.Remove(existe);
                Context.SaveChanges();
            }
        }

        public Produccion EditProduccion(Produccion produccion)
        {
            throw new NotImplementedException();
        }

    }
}

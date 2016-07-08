using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class MedioRepository : MasterRepository, IMedioRepository
    {

        public IEnumerable<Medio> GetMedios(string criterio)
        {
            var query = from m in Context.Medios
                select m;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from m in query
                    where m.Titulo.ToUpper().Contains(criterio.ToUpper())
                    select m;
            }
            return query;
        }
        public Medio GetMedio(int id)
        {
            return Context.Medios.Find(id);
        }
        public Medio AddMedio(Medio medio)
        {
            Context.Medios.Add(medio);
            Context.SaveChanges();
            return medio;
        }

        public void DeleteMedio(int id)
        {
            var existe = Context.Medios.Find(id);
            if (existe != null)
            {
                Context.Medios.Remove(existe);
                Context.SaveChanges();
            }
        }

        public Medio EditMedio(Medio medio)
        {
            throw new NotImplementedException();
        }

    }
}

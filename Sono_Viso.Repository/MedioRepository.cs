using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class MedioRepository : MasterRepository, IMedioRepository
    {

        public IEnumerable<Medio> GetMedios(string criterio, int? areaId, int? formatoId)
        {
            var query = from m in Context.Medios.Include("Formato").Include("Area")
                select m;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from m in query
                    where m.Titulo.ToUpper().Contains(criterio.ToUpper())
                    select m;
            }
            if (areaId.HasValue && areaId != 0)
            {
                query = query.Where(m => m.AreaId.Equals(areaId.Value)).Where(m => m.FormatoId.Equals(formatoId.Value));
            }

            return query;
        }

        public IEnumerable<Medio> GetMedios(string criterio)
        {
            var query = from m in Context.Medios.Include("Formato").Include("Area")
                        select m;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from m in query
                        where m.Titulo.ToUpper().Contains(criterio.ToUpper())
                        select m;
            }

            return query;
        }

        public Medio GetMedio(string id)
        {
            var medio = Context.Medios.Find(id);
            return medio;
        }
        public Medio AddMedio(Medio medio)
        {
            Context.Medios.Add(medio);
            Context.SaveChanges();
            return medio;
        }

        public void DeleteMedio(string id)
        {
            var existe = Context.Medios.Find(id);
            if (existe != null)
            {
                Context.Medios.Remove(existe);
                Context.SaveChanges();
            }
        }

        public void EditMedio(Medio medio)
        {
            Context.Entry(medio).State = EntityState.Modified;
            Context.SaveChanges();
        }

    }
}

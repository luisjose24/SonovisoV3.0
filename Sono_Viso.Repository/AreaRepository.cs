using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class AreaRepository : MasterRepository, IAreaRepository
    {

        public IEnumerable<Area> GetAreas(string criterio)
        {
            var query = from a in Context.Areas
                select a;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from a in query
                    where a.Nombre.ToUpper().Contains(criterio.ToUpper())
                    select a;
            }
            return query;
        }

        public Area GetArea(int id)
        {
            return Context.Areas.Find(id);
        }

        public Area AddArea(Area area)
        {
            Context.Areas.Add(area);
            Context.SaveChanges();
            return area;
        }

        public void DeleteArea(int id)
        {
            var existe = Context.Areas.Find(id);
            if (existe!= null)
            {
                Context.Areas.Remove(existe);
                Context.SaveChanges();
            }

        }

        public Area EditArea(Area area)
        {
            throw new NotImplementedException();
        }

    }
}

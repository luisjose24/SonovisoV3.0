using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class CategoriaMaterialRepository : MasterRepository, ICategoriaMaterialRepository
    {

        public IEnumerable<CategoriaMaterial> GetCategoriaMaterials(string criterio)
        {
            var query = from c in Context.CategoriaMaterials
                select c;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from c in query
                    where c.Nombre.ToUpper().Contains(criterio.ToUpper())
                    select c;

            }
            return query;

        }
        public CategoriaMaterial GetCategoriaMaterial(int id)
        {
            return Context.CategoriaMaterials.Find(id);
        }

        public CategoriaMaterial AddCategoriaMaterial(CategoriaMaterial categoriaMaterial)
        {
            Context.CategoriaMaterials.Add(categoriaMaterial);
            Context.SaveChanges();
            return categoriaMaterial;
        }

        public void DeleteCategoriaMaterial(int id)
        {
            var existe = Context.CategoriaMaterials.Find(id);
            if (existe!=null)
            {
                Context.CategoriaMaterials.Remove(existe);
                Context.SaveChanges();
            }
            
        }

        public CategoriaMaterial EditCategoriaMaterial(CategoriaMaterial categoriaMaterial)
        {
            throw new NotImplementedException();
        }

    }
}

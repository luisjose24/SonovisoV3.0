using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class MaterialRepository : MasterRepository, IMaterialRepository
    {
        public Material AddMaterial(Material material)
        {
            Context.Materials.Add(material);
            Context.SaveChanges();
            return material;
        }

        public void DeleteMaterial(Int32 id)
        {
            var existe = Context.Materials.Find(id);
            if (existe != null)
            {
                Context.Materials.Remove(existe);
                Context.SaveChanges();
            }
        }

        public void EditMaterial(Material material)
        {

            Context.Entry(material).State = EntityState.Modified;
            Context.SaveChanges();
        }

        public IEnumerable<Material> GetMaterials(string criterio)
        {
            var query = from m in Context.Materials.Include("CategoriaMaterial")
                select m;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from m in query
                    where m.CategoriaMaterial.Nombre.ToUpper().Contains(criterio.ToUpper())
                    select m;
            }
            return query;
        }

        public IEnumerable<Material> GetMaterials(string criterio, int? categoriaMaterialId)
        {
            var query = from m in Context.Materials.Include("CategoriaMaterial")
                select m;

            if (!string.IsNullOrEmpty(criterio))
            {
                query = from m in query
                    where m.CategoriaMaterial.Nombre.ToUpper().Contains(criterio.ToUpper())
                    select m;
            }
            if (categoriaMaterialId.HasValue && categoriaMaterialId!=0)
            {
                query = query.Where(m => m.CategoriaMaterialId.Equals(categoriaMaterialId.Value));
            }
            return query;
        }

        public Material GetMaterial(Int32 id)
        {
            var material = Context.Materials.Find(id);
            return material;
        }
    }
}

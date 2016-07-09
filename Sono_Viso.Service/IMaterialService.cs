using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Service
{
    public interface IMaterialService
    {
        IEnumerable<Material> GetMaterials(string criterio, Int32? categoriaMaterialId);
        IEnumerable<Material> GetMaterials(string criterio);
        Material GetMaterial(Int32 id);
        Material AddMaterial(Material material);
        void EditMaterial(Material material);
        void DeleteMaterial(Int32 id);
    }
}

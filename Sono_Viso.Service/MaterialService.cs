using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class MaterialService : IMaterialService
    {
        public IMaterialRepository MaterialRepository { get; set; }

        public MaterialService()
        {
            if (MaterialRepository==null)
            {
                MaterialRepository = new MaterialRepository();
            }
        }
        public Material AddMaterial(Material material)
        {
            return MaterialRepository.AddMaterial(material);
        }

        public void DeleteMaterial(int id)
        {
            MaterialRepository.DeleteMaterial(id);
        }

        public void EditMaterial(Material material)
        {
            MaterialRepository.EditMaterial(material);
        }

        public Material GetMaterial(int id)
        {
            return MaterialRepository.GetMaterial(id);
        }

        public IEnumerable<Material> GetMaterials(string criterio)
        {
            return MaterialRepository.GetMaterials(criterio);
        }

        public IEnumerable<Material> GetMaterials(string criterio, int? categoriaMaterialId)
        {
            return MaterialRepository.GetMaterials(criterio, categoriaMaterialId);
        }
    }
}

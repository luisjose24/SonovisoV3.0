using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class CategoriaMaterialService : ICategoriaMaterialService
    {
        public ICategoriaMaterialRepository CategoriaMaterialRepository { get; set; }

        public CategoriaMaterialService()
        {
            if (CategoriaMaterialRepository==null)
            {
                CategoriaMaterialRepository = new CategoriaMaterialRepository();
            }
        }

        public CategoriaMaterial AddCategoriaMaterial(CategoriaMaterial categoriaMaterial)
        {
            return CategoriaMaterialRepository.AddCategoriaMaterial(categoriaMaterial);
        }

        public void DeleteCategoriaMaterial(int id)
        {
            CategoriaMaterialRepository.DeleteCategoriaMaterial(id);
        }

        public CategoriaMaterial EditCategoriaMaterial(CategoriaMaterial categoriaMaterial)
        {
            return CategoriaMaterialRepository.EditCategoriaMaterial(categoriaMaterial);
        }

        public CategoriaMaterial GetCategoriaMaterial(int id)
        {
            return CategoriaMaterialRepository.GetCategoriaMaterial(id);
        }

        public IEnumerable<CategoriaMaterial> GetCategoriaMaterials(string criterio)
        {
            return CategoriaMaterialRepository.GetCategoriaMaterials(criterio);
        }
    }
}

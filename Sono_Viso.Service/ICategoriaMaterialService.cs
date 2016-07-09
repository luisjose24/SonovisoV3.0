using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Service
{
    public interface ICategoriaMaterialService
    {
        IEnumerable<CategoriaMaterial> GetCategoriaMaterials(string criterio);
        CategoriaMaterial GetCategoriaMaterial(Int32 id);
        void DeleteCategoriaMaterial(Int32 id);
        CategoriaMaterial EditCategoriaMaterial(CategoriaMaterial categoriaMaterial);
        CategoriaMaterial AddCategoriaMaterial(CategoriaMaterial categoriaMaterial);
    }
}

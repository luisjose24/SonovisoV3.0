using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Service
{
    public interface IProduccionService
    {
        IEnumerable<Produccion> GetProduccions(string criterio);
        Produccion GetProduccion(Int32 id);
        Produccion AddProduccion(Produccion produccion);
        Produccion EditProduccion(Produccion produccion);
        void DeleteProduccion(Int32 id);
    }
}

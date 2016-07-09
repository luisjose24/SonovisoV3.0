using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public interface IMedioRepository
    {
        IEnumerable<Medio> GetMedios(string criterio, Int32? areaId, Int32? formatoId);
        IEnumerable<Medio> GetMedios(string criterio);
        Medio GetMedio(string id);
        Medio AddMedio(Medio medio);
        void EditMedio(Medio medio);
        void DeleteMedio(string id);
    }
}

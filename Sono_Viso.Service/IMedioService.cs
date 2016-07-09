using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Service
{
    public interface IMedioService
    {
        IEnumerable<Medio> GetMedios(string criterio, int? areaId, int? formatoId);
        IEnumerable<Medio> GetMedios(string criterio);
        Medio GetMedio(string id);
        Medio AddMedio(Medio medio);
        void EditMedio(Medio medio);
        void DeleteMedio(string id);
    }
}

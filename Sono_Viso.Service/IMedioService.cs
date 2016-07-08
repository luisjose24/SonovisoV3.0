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
        IEnumerable<Medio> GetMedios(string criterio);
        Medio GetMedio(Int32 id);
        Medio AddMedio(Medio medio);
        Medio EditMedio(Medio medio);
        void DeleteMedio(Int32 id);
    }
}

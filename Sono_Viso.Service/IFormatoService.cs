using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Service
{
    public interface IFormatoService
    {
        IEnumerable<Formato> GetFormatos(string criterio);
        Formato GetFormato(Int32 id);
        Formato AddFormato(Formato formato);
        Formato EditFormato(Formato formato);
        void DeleteFormato(Int32 id);
    }
}

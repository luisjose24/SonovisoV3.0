using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public interface IAreaRepository
    {
        IEnumerable<Area> GetAreas(string criterio);
        Area GetArea(Int32 id);
        Area AddArea(Area area);
        Area EditArea(Area area);
        void DeleteArea(Int32 id);

    }
}

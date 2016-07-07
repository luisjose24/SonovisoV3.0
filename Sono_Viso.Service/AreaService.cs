using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class AreaService : IAreaService
    {
        public IAreaRepository AreaRepository { get; set; }

        public AreaService()
        {
            if (AreaRepository == null)
            {
                AreaRepository = new AreaRepository();
            }
        }

        public IEnumerable<Area> GetAreas(string criterio)
        {
            return AreaRepository.GetAreas(criterio);
        }

        public Area GetArea(int id)
        {
            return AreaRepository.GetArea(id);
        }

        public Area AddArea(Area area)
        {
            return AreaRepository.AddArea(area);
        }

        public void DeleteArea(int id)
        {
            AreaRepository.DeleteArea(id);
        }

        public Area EditArea(Area area)
        {
            return AreaRepository.EditArea(area);
        }
        
    }
}

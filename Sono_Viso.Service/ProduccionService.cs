using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class ProduccionService : IProduccionService
    {
        public IProduccionRepository ProduccionRepository { get; set; }

        public ProduccionService()
        {
            if (ProduccionRepository== null)
            {
                ProduccionRepository = new ProduccionRepository();
            }
        }
        public IEnumerable<Produccion> GetProduccions(string criterio)
        {
            return ProduccionRepository.GetProduccions(criterio);
        }

        public Produccion GetProduccion(int id)
        {
            return ProduccionRepository.GetProduccion(id);
        }

        public Produccion AddProduccion(Produccion produccion)
        {
            return ProduccionRepository.AddProduccion(produccion);
        }

        public void DeleteProduccion(int id)
        {
            ProduccionRepository.DeleteProduccion(id);
        }

        public Produccion EditProduccion(Produccion produccion)
        {
            return ProduccionRepository.EditProduccion(produccion);
        }

    }
}

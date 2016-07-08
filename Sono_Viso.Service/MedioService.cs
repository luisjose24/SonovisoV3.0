using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class MedioService : IMedioService
    {
        public IMedioRepository MedioRepository { get; set; }

        public MedioService()
        {
            if (MedioRepository==null)
            {
                MedioRepository = new MedioRepository();
            }
        }

        public IEnumerable<Medio> GetMedios(string criterio)
        {
            return MedioRepository.GetMedios(criterio);
        }
        public Medio GetMedio(int id)
        {
            return MedioRepository.GetMedio(id);
        }
        public Medio AddMedio(Medio medio)
        {
            return MedioRepository.AddMedio(medio);
        }

        public void DeleteMedio(int id)
        {
            MedioRepository.DeleteMedio(id);
        }

        public Medio EditMedio(Medio medio)
        {
            return MedioRepository.EditMedio(medio);
        }

    }
}

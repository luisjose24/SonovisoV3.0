using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class FormatoService : IFormatoService
    {
        public IFormatoRepository FormatoRepository { get; set; }

        public FormatoService()
        {
            if (FormatoRepository== null)
            {
                FormatoRepository = new FormatoRepository();
            }
        }

        public IEnumerable<Formato> GetFormatos(string criterio)
        {
            return FormatoRepository.GetFormatos(criterio);
        }
        public Formato GetFormato(int id)
        {
            return FormatoRepository.GetFormato(id);
        }

        public Formato AddFormato(Formato formato)
        {
            return FormatoRepository.AddFormato(formato);
        }

        public void DeleteFormato(int id)
        {
            FormatoRepository.DeleteFormato(id);
        }

        public Formato EditFormato(Formato formato)
        {
            return FormatoRepository.EditFormato(formato);
        }

    }
}

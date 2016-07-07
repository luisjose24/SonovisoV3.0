using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository;

namespace Sono_Viso.Service
{
    public class GeneroService : IGeneroService
    {
        public IGeneroRepository GeneroRepository { get; set; }

        public GeneroService()
        {
            if (GeneroRepository == null)
            {
                GeneroRepository = new GeneroRepository();
            }
        }
        public Genero AddGenero(Genero genero)
        {
            return GeneroRepository.AddGenero(genero);
        }

        public void DeleteGenero(int id)
        {
            GeneroRepository.DeleteGenero(id);
        }

        public Genero EditGenero(Genero genero)
        {
            return GeneroRepository.EditGenero(genero);
        }

        public Genero GetGenero(int id)
        {
            return GeneroRepository.GetGenero(id);
        }

        public IEnumerable<Genero> GetGeneros(string criterio)
        {
            return GeneroRepository.GetGeneros(criterio);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Service
{
    public interface IGeneroService
    {
        IEnumerable<Genero> GetGeneros(string criterio);
        Genero GetGenero(Int32 id);
        Genero AddGenero(Genero genero);
        Genero EditGenero(Genero genero);
        void DeleteGenero(Int32 id);
    }
}

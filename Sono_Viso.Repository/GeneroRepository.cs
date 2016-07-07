using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class GeneroRepository : MasterRepository, IGeneroRepository
    {
        public Genero AddGenero(Genero genero)
        {
            Context.Generos.Add(genero);
            Context.SaveChanges();
            return genero;
        }

        public void DeleteGenero(int id)
        {
            var existe = Context.Generos.Find(id);
            if (existe!=null)
            {
                Context.Generos.Remove(existe);
                Context.SaveChanges();
            }
        }

        public Genero EditGenero(Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero GetGenero(int id)
        {
            return Context.Generos.Find(id);
        }

        public IEnumerable<Genero> GetGeneros(string criterio)
        {
            var query = from g in Context.Generos
                select g;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from g in query
                    where g.Nombre.ToUpper().Contains(criterio.ToUpper())
                    select g;
                
            }
            return query;
        }
    }
}

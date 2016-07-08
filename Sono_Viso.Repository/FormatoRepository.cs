using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository
{
    public class FormatoRepository : MasterRepository, IFormatoRepository
    {


        public IEnumerable<Formato> GetFormatos(string criterio)
        {
            var query = from f in Context.Formatos
                select f;
            if (!string.IsNullOrEmpty(criterio))
            {
                query = from f in query
                    where f.Nombre.ToUpper().Contains(criterio.ToUpper())
                    select f;

            }
            return query;

        }
        public Formato GetFormato(int id)
        {
            return Context.Formatos.Find(id);
        }
        public Formato AddFormato(Formato formato)
        {
            Context.Formatos.Add(formato);
            Context.SaveChanges();
            return formato;
        }

        public void DeleteFormato(int id)
        {
            var existe = Context.Formatos.Find(id);
            if (existe !=null)
            {
                Context.Formatos.Remove(existe);
                Context.SaveChanges();
            }
        }

        public Formato EditFormato(Formato formato)
        {
            throw new NotImplementedException();
        }

    }
}

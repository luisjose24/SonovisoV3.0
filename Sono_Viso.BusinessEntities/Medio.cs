using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Sono_Viso.BusinessEntities
{
    public class Medio
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Int32 ProduccionId { get; set; }
        public Produccion Produccion { get; set; }
        public Int32 IdArea { get; set; }
        public Area Area { get; set; }
        public Int32 IdGenero { get; set; }
        public Genero Genero { get; set; }
        public Int32 IdFormato { get; set; }
        public Formato Formato { get; set; }
        public Int32 Duracion { get; set; }
        public Int32 Anio { get; set; }
        public bool IsActivo { get; set; }
    }
}

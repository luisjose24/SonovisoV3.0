using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sono_Viso.BusinessEntities
{
    public class Material
    {
        public Int32 Id { get; set; }
        public Int32 CategoriaMaterialId { get; set; }
        public CategoriaMaterial CategoriaMaterial { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string NumSerie { get; set; }
        public Int32 Anio { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Int32 VidaUtil { get; set; }
        public bool Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sono_Viso.BusinessEntities
{
    public class Cliente
    {
        public Int32 IdCliente { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string DNI { get; set; }
        public string TelefCliente { get; set; }
        public string EmailCliente { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }
    }
}

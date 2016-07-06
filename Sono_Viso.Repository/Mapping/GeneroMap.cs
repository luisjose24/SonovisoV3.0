using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository.Mapping
{
    public class GeneroMap:EntityTypeConfiguration<Genero>
    {
        public GeneroMap()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).IsRequired();
            this.Property(e => e.Nombre).IsRequired();
        }
    }
}

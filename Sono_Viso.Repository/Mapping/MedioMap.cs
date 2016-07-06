using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository.Mapping
{
    public class MedioMap:EntityTypeConfiguration<Medio>
    {
        public MedioMap()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).IsRequired();
            this.Property(e => e.Titulo).IsRequired();
            this.Property(e => e.Descripcion).HasColumnType("text").IsRequired();
            this.Property(e => e.ProduccionId).IsRequired();
            this.Property(e => e.IdArea).IsRequired();
            this.Property(e => e.IdGenero).IsRequired();
            this.Property(e => e.IdFormato).IsRequired();
            this.Property(e => e.Duracion).IsOptional();
            this.Property(e => e.Anio).IsOptional();
            this.Property(e => e.IsActivo).IsRequired();
        }
    }
}

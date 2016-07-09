using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;

namespace Sono_Viso.Repository.Mapping
{
    public class MaterialMap:EntityTypeConfiguration<Material>
    {
        public MaterialMap()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            this.Property(e => e.CategoriaMaterialId).IsRequired();
            this.Property(e => e.Modelo).IsRequired();
            this.Property(e => e.Marca).IsRequired();
            this.Property(e => e.NumSerie).IsOptional();
            this.Property(e => e.Anio).IsRequired();
            this.Property(e => e.FechaIngreso).IsRequired();
            this.Property(e => e.VidaUtil).IsRequired();
            this.Property(e => e.Estado).IsRequired();
        }
    }
}

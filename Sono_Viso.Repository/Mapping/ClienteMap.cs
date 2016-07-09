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
    public class ClienteMap:EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            this.HasKey(e => e.IdCliente);
            this.Property(e => e.IdCliente).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.IdCliente).IsRequired();
            this.Property(e => e.Apellidos).HasColumnType("char").HasMaxLength(20).IsRequired();
            this.Property(e => e.Nombres).HasMaxLength(50).IsRequired();
            this.Property(e => e.TelefCliente).HasColumnType("char").HasMaxLength(13).IsOptional();
            this.Property(e => e.EmailCliente).HasMaxLength(40).IsOptional();
            this.Property(e => e.Direccion).HasColumnType("char").HasMaxLength(40).IsRequired();
            this.Property(e => e.Estado).HasColumnType("bit").IsRequired();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sono_Viso.BusinessEntities;
using Sono_Viso.Repository.Mapping;

namespace Sono_Viso.Repository
{
    public class Sono_VisoContext:DbContext
    {
        public DbSet<Area> Areas { get; set; }
        public DbSet<Formato> Formatos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Produccion> Produccions { get; set; }
        public DbSet<Medio> Medios { get; set; }
        public DbSet<CategoriaMaterial> CategoriaMaterials { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AreaMap());
            modelBuilder.Configurations.Add(new FormatoMap());
            modelBuilder.Configurations.Add(new GeneroMap());
            modelBuilder.Configurations.Add(new ProduccionMap());
            modelBuilder.Configurations.Add(new MedioMap());
            modelBuilder.Configurations.Add(new CategoriaMaterialMap());
            modelBuilder.Configurations.Add(new MaterialMap());
            modelBuilder.Configurations.Add(new ClienteMap());
        }
    }
}

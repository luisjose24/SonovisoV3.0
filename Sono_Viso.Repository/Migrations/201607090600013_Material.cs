namespace Sono_Viso.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Material : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriaMaterial",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoriaMaterialId = c.Int(nullable: false),
                        Modelo = c.String(nullable: false),
                        Marca = c.String(nullable: false),
                        NumSerie = c.String(),
                        Anio = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        VidaUtil = c.Int(nullable: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CategoriaMaterial", t => t.CategoriaMaterialId)
                .Index(t => t.CategoriaMaterialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Material", "CategoriaMaterialId", "dbo.CategoriaMaterial");
            DropIndex("dbo.Material", new[] { "CategoriaMaterialId" });
            DropTable("dbo.Material");
            DropTable("dbo.CategoriaMaterial");
        }
    }
}

namespace Sono_Viso.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Formato",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medio",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Titulo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false, unicode: false, storeType: "text"),
                        ProduccionId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                        GeneroId = c.Int(nullable: false),
                        FormatoId = c.Int(nullable: false),
                        Duracion = c.Int(),
                        Anio = c.Int(),
                        IsActivo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Area", t => t.AreaId)
                .ForeignKey("dbo.Formato", t => t.FormatoId)
                .ForeignKey("dbo.Genero", t => t.GeneroId)
                .ForeignKey("dbo.Produccion", t => t.ProduccionId)
                .Index(t => t.ProduccionId)
                .Index(t => t.AreaId)
                .Index(t => t.GeneroId)
                .Index(t => t.FormatoId);
            
            CreateTable(
                "dbo.Produccion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medio", "ProduccionId", "dbo.Produccion");
            DropForeignKey("dbo.Medio", "GeneroId", "dbo.Genero");
            DropForeignKey("dbo.Medio", "FormatoId", "dbo.Formato");
            DropForeignKey("dbo.Medio", "AreaId", "dbo.Area");
            DropIndex("dbo.Medio", new[] { "FormatoId" });
            DropIndex("dbo.Medio", new[] { "GeneroId" });
            DropIndex("dbo.Medio", new[] { "AreaId" });
            DropIndex("dbo.Medio", new[] { "ProduccionId" });
            DropTable("dbo.Produccion");
            DropTable("dbo.Medio");
            DropTable("dbo.Genero");
            DropTable("dbo.Formato");
            DropTable("dbo.Area");
        }
    }
}

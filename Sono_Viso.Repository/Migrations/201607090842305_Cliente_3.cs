namespace Sono_Viso.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente_3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Apellidos = c.String(maxLength: 20, fixedLength: true, unicode: false),
                        Nombres = c.String(maxLength: 50),
                        NomEmpresa = c.String(maxLength: 40),
                        RucEmpresa = c.String(maxLength: 11, fixedLength: true, unicode: false),
                        DirCliente = c.String(maxLength: 40),
                        TelefCliente = c.String(maxLength: 13, fixedLength: true, unicode: false),
                        EmailCliente = c.String(maxLength: 40),
                        Contacto = c.String(maxLength: 50),
                        FechaNac = c.DateTime(),
                        Tipo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cliente");
        }
    }
}

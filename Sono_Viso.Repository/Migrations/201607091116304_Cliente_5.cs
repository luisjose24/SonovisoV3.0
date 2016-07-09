namespace Sono_Viso.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente_5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Genero", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.Cliente", "Apellidos", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.Cliente", "Nombres", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Cliente", "NomEmpresa");
            DropColumn("dbo.Cliente", "RucEmpresa");
            DropColumn("dbo.Cliente", "DirCliente");
            DropColumn("dbo.Cliente", "Contacto");
            DropColumn("dbo.Cliente", "Tipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "Tipo", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AddColumn("dbo.Cliente", "Contacto", c => c.String(maxLength: 50));
            AddColumn("dbo.Cliente", "DirCliente", c => c.String(maxLength: 40));
            AddColumn("dbo.Cliente", "RucEmpresa", c => c.String(maxLength: 11, fixedLength: true, unicode: false));
            AddColumn("dbo.Cliente", "NomEmpresa", c => c.String(maxLength: 40));
            AlterColumn("dbo.Cliente", "Nombres", c => c.String(maxLength: 50));
            AlterColumn("dbo.Cliente", "Apellidos", c => c.String(maxLength: 20, fixedLength: true, unicode: false));
            DropColumn("dbo.Cliente", "Genero");
        }
    }
}

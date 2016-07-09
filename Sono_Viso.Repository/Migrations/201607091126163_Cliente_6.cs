namespace Sono_Viso.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente_6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cliente", "Direccion", c => c.String(nullable: false, maxLength: 40, fixedLength: true, unicode: false));
            DropColumn("dbo.Cliente", "Genero");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "Genero", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            DropColumn("dbo.Cliente", "Direccion");
        }
    }
}

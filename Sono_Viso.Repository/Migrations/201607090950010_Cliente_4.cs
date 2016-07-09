namespace Sono_Viso.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cliente_4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cliente", "FechaNac");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cliente", "FechaNac", c => c.DateTime());
        }
    }
}

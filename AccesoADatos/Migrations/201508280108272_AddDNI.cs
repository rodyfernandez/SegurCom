namespace AccesoADatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDNI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Dni", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Dni");
        }
    }
}

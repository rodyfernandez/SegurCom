namespace AccesoADatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFechaNacimiento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "FechaNacimiento", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "FechaNacimiento");
        }
    }
}

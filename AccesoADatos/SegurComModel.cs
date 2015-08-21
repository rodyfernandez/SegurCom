namespace AccesoADatos
{
    using Entidades;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;


    public class SegurComModel : DbContext
    {
        // Your context has been configured to use a 'SegurComModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'AccesoADatos.SegurComModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SegurComModel' 
        // connection string in the application configuration file.
        public SegurComModel()
            : base("name=SegurComModel")
        {

            Database.SetInitializer<SegurComModel>(new CreateDatabaseIfNotExists<SegurComModel>());
            //this.Configuration.LazyLoadingEnabled = true;
            //this.Configuration.ProxyCreationEnabled = true;

        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //remuevo la pluralizacion de nombres, y las predefino como a mi me gusta!
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
      
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}



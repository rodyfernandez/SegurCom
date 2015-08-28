using System;
namespace AccesoADatos
{
    public interface IContextFactory<T>
      where T : System.Data.Entity.DbContext
    {
        T GetDbContext();
    }
}

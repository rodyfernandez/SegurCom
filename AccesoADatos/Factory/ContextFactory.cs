using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoADatos
{
    public class ContextFactory<T> : AccesoADatos.IContextFactory<T> where T : DbContext
    {
        private IUnityContainer container;

        public ContextFactory(IUnityContainer container)
        {

            this.container = container;

        }
        public T GetDbContext()
        {
            return container.Resolve<T>();
        }
    }
}
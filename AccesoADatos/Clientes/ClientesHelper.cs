using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;

namespace AccesoADatos.Clientes
{
   public class ClientesHelper : IClientesHelper
    {

        private IContextFactory<SegurComModel> contextFactory;

        public ClientesHelper(IContextFactory<SegurComModel> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public List<Cliente> Get()
        {
            using (var contexto = contextFactory.GetDbContext())
            {

                var q = contexto.Clientes.ToList();
                return q;
            }
        }


        public Cliente Get(int id)
        {
            using (var contexto = contextFactory.GetDbContext())
            {

                var q = contexto.Clientes.Where(p => p.ID == id).FirstOrDefault();
                return q;
            }
        }

        public void Add(Cliente obj)
        {
            using (var contexto = contextFactory.GetDbContext())
            {

                if (obj.ID == 0)
                {

                    contexto.Clientes.Add(obj);
                    contexto.SaveChanges();

                }
                else

                {

                    contexto.Clientes.Attach(obj);
                    contexto.Entry(obj).State = EntityState.Modified;
                    contexto.SaveChanges();


                }

            }


        }


        public void Delete(Cliente obj)
        {

            using (var contexto = contextFactory.GetDbContext())
            {
                 
                contexto.Clientes.Attach(obj);
                contexto.Clientes.Remove(obj);
                contexto.SaveChanges();
            }


        }






    }
}

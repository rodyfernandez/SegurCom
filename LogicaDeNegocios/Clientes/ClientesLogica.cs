using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoADatos.Clientes;

namespace LogicaDeNegocios.Clientes
{
    public class ClientesLogica : IClientesLogica
    {
        private IClientesHelper helper;
        public ClientesLogica(IClientesHelper helper)
        {
            this.helper = helper;
        }

        public List<Cliente> Get()
        {
            return helper.Get();

        }

        
        public Cliente Get(int id)
        {

            return helper.Get(id);

        }


        public void Add(Cliente obj)
        {
            helper.Add(obj);

        }


        public void Delete(Cliente obj)
        {

            helper.Delete(obj);

        }





    }
}

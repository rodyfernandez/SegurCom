using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AccesoADatos.Clientes
{
   public  interface IClientesHelper
    {

        System.Collections.Generic.List<Entidades.Cliente> Get();
        Cliente Get(int id);
        void Delete(Cliente obj);
        void Add(Cliente obj);


    }
}

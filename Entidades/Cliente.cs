using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Cliente
    {

        public int ID { get; set; }
        public int Codigo { get; set; }
        public string RazonSocial { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        
    }
}

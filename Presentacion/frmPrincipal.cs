using AccesoADatos;
using AccesoADatos.Clientes;
using LogicaDeNegocios.Clientes;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var container = new UnityContainer();
            //container.RegisterTypes(AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes()));

            //registrando factory
            container.RegisterType(typeof(IContextFactory<>), typeof(ContextFactory<>));
            //registrando el modelo
            container.RegisterType<SegurComModel>();
            //registrando contactos
            container.RegisterType<IClientesHelper, ClientesHelper>();
            container.RegisterType<IClientesLogica, ClientesLogica>();

         


            //Application.Run(new Form1());
            //Application.Run(container.Resolve<frmClientes>());


            frmClientes frm = new frmClientes(container.Resolve<ClientesLogica>());
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

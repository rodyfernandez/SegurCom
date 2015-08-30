using AccesoADatos;
using Entidades;
using LogicaDeNegocios.Clientes;
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
    public partial class frmClientes : Form
    {

        private IClientesLogica clientesLogica;
        public frmClientes(IClientesLogica clientesLogica)

        {
            this.clientesLogica = clientesLogica;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cliente cliente = new Cliente

            {

                Codigo = Convert.ToInt32(txtCodigo.Text),
                Dni = txtDni.Text,
                FechaNacimiento = dtpFechaNac.Value,
                RazonSocial = txtNombre.Text

            };

            clientesLogica.Add(cliente);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTraer1_Click(object sender, EventArgs e)
        {
            Cliente cliente = clientesLogica.Get(4);

            txtID.Text = cliente.ID.ToString();
            txtCodigo.Text = cliente.Codigo.ToString();
            txtNombre.Text = cliente.RazonSocial;
            txtDni.Text = cliente.Dni.ToString();
            dtpFechaNac.Value = cliente.FechaNacimiento.Value.Date;



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //elimmino el id 7
            Cliente cliente = clientesLogica.Get(7);
            clientesLogica.Delete(cliente);
        }



        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}

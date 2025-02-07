using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenFinal.Controladores;

namespace ExamenFinal.Vistas
{
    public partial class ControlUsuarioRuta : UserControl
    {
        private RutaController rutaController;

        public ControlUsuarioRuta()
        {
            InitializeComponent();
            rutaController = new RutaController();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridViewAutobus.DataSource = rutaController.ObtenerRutas();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            rutaController.AgregarRuta(textBoxPlaca.Text, textBoxModelo.Text);
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutobus.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewAutobus.SelectedRows[0].Cells[0].Value);
                rutaController.EditarRuta(id, textBoxPlaca.Text, textBoxModelo.Text);
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutobus.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewAutobus.SelectedRows[0].Cells[0].Value);
                rutaController.EliminarRuta(id);
                CargarDatos();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenFinal.Controladores;

namespace ExamenFinal.Vistas
{
    public partial class ControlUsuarioConductor : UserControl
    {
        private ConductorController conductorController;

        public ControlUsuarioConductor()
        {
            InitializeComponent();
            conductorController = new ConductorController();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridViewAutobus.DataSource = conductorController.ObtenerConductores();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            conductorController.AgregarConductor(textBoxPlaca.Text, textBoxLicencia.Text);
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutobus.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewAutobus.SelectedRows[0].Cells[0].Value);
                conductorController.EditarConductor(id, textBoxPlaca.Text, textBoxLicencia.Text);
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutobus.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewAutobus.SelectedRows[0].Cells[0].Value);
                conductorController.EliminarConductor(id);
                CargarDatos();
            }
        }
    }
}

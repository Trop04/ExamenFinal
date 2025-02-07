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
    public partial class ControlUsuarioAutobus : UserControl
    {
        private AutobusController autobusController;

        public ControlUsuarioAutobus()
        {
            InitializeComponent();
            autobusController = new AutobusController();
            CargarDatos();
        }

        private void CargarDatos()
        {
            dataGridViewAutobus.DataSource = autobusController.ObtenerAutobuses();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            autobusController.AgregarAutobus(textBoxPlaca.Text, textBoxModelo.Text);
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutobus.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewAutobus.SelectedRows[0].Cells[0].Value);
                autobusController.EditarAutobus(id, textBoxPlaca.Text, textBoxModelo.Text);
                CargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutobus.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewAutobus.SelectedRows[0].Cells[0].Value);
                autobusController.EliminarAutobus(id);
                CargarDatos();
            }
        }
    }
}

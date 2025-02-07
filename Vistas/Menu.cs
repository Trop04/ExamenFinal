using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenFinal.Vistas;

namespace ExamenFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRutas_Click(object sender, EventArgs e)
        {
            ControlUsuarioRuta ucruta = new ControlUsuarioRuta();
            panelPantalla.Controls.Clear();
            ucruta.Dock = DockStyle.Fill;
            panelPantalla.Controls.Add(ucruta);
        }

        private void btnConductor_Click(object sender, EventArgs e)
        {
            ControlUsuarioConductor ucconductor = new ControlUsuarioConductor();
            panelPantalla.Controls.Clear();
            ucconductor.Dock = DockStyle.Fill;
            panelPantalla.Controls.Add(ucconductor);
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            ControlUsuarioAutobus ucautobus = new ControlUsuarioAutobus();
            panelPantalla.Controls.Clear();
            ucautobus.Dock = DockStyle.Fill;
            panelPantalla.Controls.Add(ucautobus);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ControlUsuarioReporte ucreporte = new ControlUsuarioReporte();
            panelPantalla.Controls.Clear();
            ucreporte.Dock = DockStyle.Fill;
            panelPantalla.Controls.Add(ucreporte);
        }
    }
}

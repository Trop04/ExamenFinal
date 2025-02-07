using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ExamenFinal.Vistas
{
    public partial class ControlUsuarioReporte : UserControl
    {
        public ControlUsuarioReporte()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ExamenFinalDataSet dataSet = new ExamenFinalDataSet();
            this.autobusTableAdapter.Fill(dataSet.Autobus);
            this.rutaTableAdapter.Fill(dataSet.Ruta);
            this.conductorTableAdapter.Fill(dataSet.Conductor);
            this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\Jonathan\\source\\repos\\ExamenFinal\\Vistas\\Report1.rdlc";
            ReportDataSource reportDataSource1 = new ReportDataSource("DataSet1", dataSet.Tables["Autobus"]);
            ReportDataSource reportDataSource2 = new ReportDataSource("DataSet2", dataSet.Tables["Conductor"]);
            ReportDataSource reportDataSource3 = new ReportDataSource("DataSet3", dataSet.Tables["Ruta"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.RefreshReport(); //tuve que hacerlo manualmente por un bug...
        }
    }
}

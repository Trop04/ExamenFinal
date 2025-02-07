namespace ExamenFinal.Vistas
{
    partial class ControlUsuarioReporte
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.examenFinalDataSet = new ExamenFinal.ExamenFinalDataSet();
            this.examenFinalDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AutobusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autobusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autobusTableAdapter = new ExamenFinal.ExamenFinalDataSetTableAdapters.AutobusTableAdapter();
            this.conductorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conductorTableAdapter = new ExamenFinal.ExamenFinalDataSetTableAdapters.ConductorTableAdapter();
            this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rutaTableAdapter = new ExamenFinal.ExamenFinalDataSetTableAdapters.RutaTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.examenFinalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenFinalDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutobusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.autobusBindingSource1;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.conductorBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.rutaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ExamenFinal.Vistas.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(764, 598);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // examenFinalDataSet
            // 
            this.examenFinalDataSet.DataSetName = "ExamenFinalDataSet";
            this.examenFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // examenFinalDataSetBindingSource
            // 
            this.examenFinalDataSetBindingSource.DataSource = this.examenFinalDataSet;
            this.examenFinalDataSetBindingSource.Position = 0;
            // 
            // AutobusBindingSource
            // 
            this.AutobusBindingSource.DataMember = "Autobus";
            this.AutobusBindingSource.DataSource = this.examenFinalDataSet;
            // 
            // autobusBindingSource1
            // 
            this.autobusBindingSource1.DataMember = "Autobus";
            this.autobusBindingSource1.DataSource = this.examenFinalDataSetBindingSource;
            // 
            // autobusTableAdapter
            // 
            this.autobusTableAdapter.ClearBeforeFill = true;
            // 
            // conductorBindingSource
            // 
            this.conductorBindingSource.DataMember = "Conductor";
            this.conductorBindingSource.DataSource = this.examenFinalDataSetBindingSource;
            // 
            // conductorTableAdapter
            // 
            this.conductorTableAdapter.ClearBeforeFill = true;
            // 
            // rutaBindingSource
            // 
            this.rutaBindingSource.DataMember = "Ruta";
            this.rutaBindingSource.DataSource = this.examenFinalDataSetBindingSource;
            // 
            // rutaTableAdapter
            // 
            this.rutaTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 604);
            this.panel1.TabIndex = 1;
            // 
            // ControlUsuarioReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ControlUsuarioReporte";
            this.Size = new System.Drawing.Size(776, 610);
            ((System.ComponentModel.ISupportInitialize)(this.examenFinalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenFinalDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutobusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autobusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conductorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource examenFinalDataSetBindingSource;
        private ExamenFinalDataSet examenFinalDataSet;
        private System.Windows.Forms.BindingSource autobusBindingSource1;
        private System.Windows.Forms.BindingSource conductorBindingSource;
        private System.Windows.Forms.BindingSource rutaBindingSource;
        private System.Windows.Forms.BindingSource AutobusBindingSource;
        private ExamenFinalDataSetTableAdapters.AutobusTableAdapter autobusTableAdapter;
        private ExamenFinalDataSetTableAdapters.ConductorTableAdapter conductorTableAdapter;
        private ExamenFinalDataSetTableAdapters.RutaTableAdapter rutaTableAdapter;
        private System.Windows.Forms.Panel panel1;
    }
}

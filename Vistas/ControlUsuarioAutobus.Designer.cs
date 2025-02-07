namespace ExamenFinal.Vistas
{
    partial class ControlUsuarioAutobus
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
            this.labelKilometraje = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.dataGridViewAutobus = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutobus)).BeginInit();
            this.SuspendLayout();
            // 
            // labelKilometraje
            // 
            this.labelKilometraje.AutoSize = true;
            this.labelKilometraje.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKilometraje.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelKilometraje.Location = new System.Drawing.Point(18, 107);
            this.labelKilometraje.Name = "labelKilometraje";
            this.labelKilometraje.Size = new System.Drawing.Size(43, 13);
            this.labelKilometraje.TabIndex = 15;
            this.labelKilometraje.Text = "Modelo";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.DarkMagenta;
            this.labelNombre.Location = new System.Drawing.Point(18, 56);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(34, 13);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "Placa";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnEditar.Location = new System.Drawing.Point(601, 178);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnEliminar.Location = new System.Drawing.Point(682, 178);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAñadir.Location = new System.Drawing.Point(108, 149);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 11;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.Location = new System.Drawing.Point(21, 123);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(162, 20);
            this.textBoxModelo.TabIndex = 10;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(21, 72);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(162, 20);
            this.textBoxPlaca.TabIndex = 9;
            // 
            // dataGridViewAutobus
            // 
            this.dataGridViewAutobus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAutobus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutobus.Location = new System.Drawing.Point(3, 222);
            this.dataGridViewAutobus.Name = "dataGridViewAutobus";
            this.dataGridViewAutobus.Size = new System.Drawing.Size(770, 385);
            this.dataGridViewAutobus.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ExamenFinal.Properties.Resources.bus;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(189, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 171);
            this.panel1.TabIndex = 16;
            // 
            // ControlUsuarioAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelKilometraje);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.dataGridViewAutobus);
            this.Name = "ControlUsuarioAutobus";
            this.Size = new System.Drawing.Size(776, 610);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutobus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKilometraje;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.DataGridView dataGridViewAutobus;
        private System.Windows.Forms.Panel panel1;
    }
}

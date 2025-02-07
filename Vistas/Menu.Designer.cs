namespace ExamenFinal
{
    partial class Menu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelPantalla = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAutobus = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnConductor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPantalla.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPantalla
            // 
            this.panelPantalla.Controls.Add(this.label1);
            this.panelPantalla.Location = new System.Drawing.Point(12, 64);
            this.panelPantalla.Name = "panelPantalla";
            this.panelPantalla.Size = new System.Drawing.Size(776, 610);
            this.panelPantalla.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btnConductor);
            this.panel2.Controls.Add(this.btnRutas);
            this.panel2.Controls.Add(this.btnAutobus);
            this.panel2.Location = new System.Drawing.Point(12, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 47);
            this.panel2.TabIndex = 1;
            // 
            // btnAutobus
            // 
            this.btnAutobus.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobus.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnAutobus.Location = new System.Drawing.Point(31, 3);
            this.btnAutobus.Name = "btnAutobus";
            this.btnAutobus.Size = new System.Drawing.Size(102, 41);
            this.btnAutobus.TabIndex = 0;
            this.btnAutobus.Text = "Autobuses";
            this.btnAutobus.UseVisualStyleBackColor = true;
            this.btnAutobus.Click += new System.EventHandler(this.btnAutobus_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnRutas.Location = new System.Drawing.Point(229, 3);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Size = new System.Drawing.Size(102, 41);
            this.btnRutas.TabIndex = 1;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.UseVisualStyleBackColor = true;
            this.btnRutas.Click += new System.EventHandler(this.btnRutas_Click);
            // 
            // btnConductor
            // 
            this.btnConductor.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConductor.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btnConductor.Location = new System.Drawing.Point(456, 3);
            this.btnConductor.Name = "btnConductor";
            this.btnConductor.Size = new System.Drawing.Size(102, 41);
            this.btnConductor.TabIndex = 2;
            this.btnConductor.Text = "Conductores";
            this.btnConductor.UseVisualStyleBackColor = true;
            this.btnConductor.Click += new System.EventHandler(this.btnConductor_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkMagenta;
            this.button4.Location = new System.Drawing.Point(662, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Reportes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(89, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Sistema de Transporte\r\nSeleccione una opción";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Sistema de Transporte";
            this.panelPantalla.ResumeLayout(false);
            this.panelPantalla.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPantalla;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnConductor;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button btnAutobus;
        private System.Windows.Forms.Label label1;
    }
}


namespace TP2_CorrioneroJuan
{
    partial class frmVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picBoxAgregar = new System.Windows.Forms.PictureBox();
            this.picBoxBuscar = new System.Windows.Forms.PictureBox();
            this.picBoxListar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxListar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(67, 166);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(356, 166);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(214, 166);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Trabajo Práctico 2- Corrionero - Programación 3.";
            // 
            // picBoxAgregar
            // 
            this.picBoxAgregar.Image = global::TP2_CorrioneroJuan.Properties.Resources.Agregar;
            this.picBoxAgregar.Location = new System.Drawing.Point(54, 89);
            this.picBoxAgregar.Name = "picBoxAgregar";
            this.picBoxAgregar.Size = new System.Drawing.Size(100, 50);
            this.picBoxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAgregar.TabIndex = 5;
            this.picBoxAgregar.TabStop = false;
            // 
            // picBoxBuscar
            // 
            this.picBoxBuscar.Image = global::TP2_CorrioneroJuan.Properties.Resources.Lupa;
            this.picBoxBuscar.Location = new System.Drawing.Point(205, 89);
            this.picBoxBuscar.Name = "picBoxBuscar";
            this.picBoxBuscar.Size = new System.Drawing.Size(100, 50);
            this.picBoxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBuscar.TabIndex = 6;
            this.picBoxBuscar.TabStop = false;
            // 
            // picBoxListar
            // 
            this.picBoxListar.Image = global::TP2_CorrioneroJuan.Properties.Resources.Listado;
            this.picBoxListar.Location = new System.Drawing.Point(342, 89);
            this.picBoxListar.Name = "picBoxListar";
            this.picBoxListar.Size = new System.Drawing.Size(100, 50);
            this.picBoxListar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxListar.TabIndex = 7;
            this.picBoxListar.TabStop = false;
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(484, 293);
            this.Controls.Add(this.picBoxListar);
            this.Controls.Add(this.picBoxBuscar);
            this.Controls.Add(this.picBoxAgregar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmVentanaPrincipal";
            this.Text = "TP2_Corrionero";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxListar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picBoxAgregar;
        private System.Windows.Forms.PictureBox picBoxBuscar;
        private System.Windows.Forms.PictureBox picBoxListar;
    }
}


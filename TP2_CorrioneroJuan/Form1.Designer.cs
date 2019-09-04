namespace TP2_CorrioneroJuan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlSpButton_Listar = new System.Windows.Forms.ToolStripButton();
            this.tlSpButton_Buscar = new System.Windows.Forms.ToolStripButton();
            this.tlSpButton_Agregar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlSpButton_Listar,
            this.tlSpButton_Buscar,
            this.tlSpButton_Agregar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(486, 67);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlSpButton_Listar
            // 
            this.tlSpButton_Listar.AutoSize = false;
            this.tlSpButton_Listar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlSpButton_Listar.Image = ((System.Drawing.Image)(resources.GetObject("tlSpButton_Listar.Image")));
            this.tlSpButton_Listar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlSpButton_Listar.Name = "tlSpButton_Listar";
            this.tlSpButton_Listar.Size = new System.Drawing.Size(23, 42);
            this.tlSpButton_Listar.Text = "Listar Productos";
            this.tlSpButton_Listar.ToolTipText = "Listar Productos";
            this.tlSpButton_Listar.Click += new System.EventHandler(this.tlSpButton_Listar_Click);
            // 
            // tlSpButton_Buscar
            // 
            this.tlSpButton_Buscar.AutoSize = false;
            this.tlSpButton_Buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlSpButton_Buscar.Image = ((System.Drawing.Image)(resources.GetObject("tlSpButton_Buscar.Image")));
            this.tlSpButton_Buscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlSpButton_Buscar.Name = "tlSpButton_Buscar";
            this.tlSpButton_Buscar.Size = new System.Drawing.Size(23, 42);
            this.tlSpButton_Buscar.Text = "Buscar Productos";
            this.tlSpButton_Buscar.ToolTipText = "Buscar Producto";
            this.tlSpButton_Buscar.Click += new System.EventHandler(this.tlSpButton_Buscar_Click);
            // 
            // tlSpButton_Agregar
            // 
            this.tlSpButton_Agregar.AutoSize = false;
            this.tlSpButton_Agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlSpButton_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("tlSpButton_Agregar.Image")));
            this.tlSpButton_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlSpButton_Agregar.Name = "tlSpButton_Agregar";
            this.tlSpButton_Agregar.Size = new System.Drawing.Size(23, 42);
            this.tlSpButton_Agregar.Text = "Agregar Producto";
            this.tlSpButton_Agregar.ToolTipText = "Agregar Producto";
            this.tlSpButton_Agregar.Click += new System.EventHandler(this.tlSpButton_Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 237);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlSpButton_Listar;
        private System.Windows.Forms.ToolStripButton tlSpButton_Buscar;
        private System.Windows.Forms.ToolStripButton tlSpButton_Agregar;
    }
}


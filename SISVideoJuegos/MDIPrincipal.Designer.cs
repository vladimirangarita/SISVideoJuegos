namespace SISVideoJuegos
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonCliente = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonVideoJuegos = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonTiposVideoJuegos = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonAlquiler = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonHistorialAlquiler = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonCliente,
            this.ToolStripButtonVideoJuegos,
            this.ToolStripButtonTiposVideoJuegos,
            this.ToolStripButtonAlquiler,
            this.ToolStripButtonHistorialAlquiler});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(1072, 39);
            this.ToolStrip.TabIndex = 10;
            this.ToolStrip.Text = "ToolStrip";
            // 
            // ToolStripButtonCliente
            // 
            this.ToolStripButtonCliente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonCliente.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonCliente.Image")));
            this.ToolStripButtonCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonCliente.Name = "ToolStripButtonCliente";
            this.ToolStripButtonCliente.Size = new System.Drawing.Size(36, 36);
            this.ToolStripButtonCliente.Text = "Cliente";
            this.ToolStripButtonCliente.ToolTipText = "Almacen";
            this.ToolStripButtonCliente.Click += new System.EventHandler(this.ToolStripButtonCliente_Click);
            // 
            // ToolStripButtonVideoJuegos
            // 
            this.ToolStripButtonVideoJuegos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonVideoJuegos.Image = global::SISVideoJuegos.Properties.Resources.el_videojuego;
            this.ToolStripButtonVideoJuegos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonVideoJuegos.Name = "ToolStripButtonVideoJuegos";
            this.ToolStripButtonVideoJuegos.Size = new System.Drawing.Size(36, 36);
            this.ToolStripButtonVideoJuegos.Text = "Video juegos";
            this.ToolStripButtonVideoJuegos.Click += new System.EventHandler(this.ToolStripButtonVideoJuegos_Click);
            // 
            // ToolStripButtonTiposVideoJuegos
            // 
            this.ToolStripButtonTiposVideoJuegos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonTiposVideoJuegos.Image = global::SISVideoJuegos.Properties.Resources.categorias;
            this.ToolStripButtonTiposVideoJuegos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonTiposVideoJuegos.Name = "ToolStripButtonTiposVideoJuegos";
            this.ToolStripButtonTiposVideoJuegos.Size = new System.Drawing.Size(36, 36);
            this.ToolStripButtonTiposVideoJuegos.Text = "Tipo de video juegos";
            this.ToolStripButtonTiposVideoJuegos.Click += new System.EventHandler(this.ToolStripButtonTiposVideoJuegos_Click);
            // 
            // ToolStripButtonAlquiler
            // 
            this.ToolStripButtonAlquiler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonAlquiler.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonAlquiler.Image")));
            this.ToolStripButtonAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonAlquiler.Name = "ToolStripButtonAlquiler";
            this.ToolStripButtonAlquiler.Size = new System.Drawing.Size(36, 36);
            this.ToolStripButtonAlquiler.Text = "Alquileres";
            this.ToolStripButtonAlquiler.Click += new System.EventHandler(this.ToolStripButtonAlquiler_Click);
            // 
            // ToolStripButtonHistorialAlquiler
            // 
            this.ToolStripButtonHistorialAlquiler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonHistorialAlquiler.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButtonHistorialAlquiler.Image")));
            this.ToolStripButtonHistorialAlquiler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonHistorialAlquiler.Name = "ToolStripButtonHistorialAlquiler";
            this.ToolStripButtonHistorialAlquiler.Size = new System.Drawing.Size(36, 36);
            this.ToolStripButtonHistorialAlquiler.Text = "toolStripButton1";
            this.ToolStripButtonHistorialAlquiler.Click += new System.EventHandler(this.ToolStripButtonHistorialAlquiler_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 728);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(1072, 22);
            this.StatusStrip.TabIndex = 11;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.ToolStripStatusLabel.Text = "Estado";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 750);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.StatusStrip);
            this.IsMdiContainer = true;
            this.Name = "MDIPrincipal";
            this.Text = "Sistema de video juegos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        internal System.Windows.Forms.ToolTip ToolTip;
        internal System.Windows.Forms.ToolStrip ToolStrip;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonCliente;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonVideoJuegos;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonTiposVideoJuegos;
        internal System.Windows.Forms.ToolStripButton ToolStripButtonAlquiler;
        internal System.Windows.Forms.StatusStrip StatusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton ToolStripButtonHistorialAlquiler;

    }
}




namespace SISVideoJuegos
{
    partial class FrmAlquilerVideoJuegos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlquilerVideoJuegos));
            this.dtgClientes = new System.Windows.Forms.DataGridView();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.lvVideoJuegos = new System.Windows.Forms.ListView();
            this.lvClienteSeleccionado = new System.Windows.Forms.ListView();
            this.cmdAlquilarVideoJuegos = new System.Windows.Forms.Button();
            this.cmdEliminarClienteSeleccionado = new System.Windows.Forms.Button();
            this.cmdAgregarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgClientes
            // 
            this.dtgClientes.AllowUserToAddRows = false;
            this.dtgClientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgClientes.Location = new System.Drawing.Point(16, 51);
            this.dtgClientes.Name = "dtgClientes";
            this.dtgClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgClientes.Size = new System.Drawing.Size(623, 106);
            this.dtgClientes.TabIndex = 116;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(79, 13);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(157, 20);
            this.txtcedula.TabIndex = 118;
            this.txtcedula.TextChanged += new System.EventHandler(this.txtcedula_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(14, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(46, 13);
            this.Label2.TabIndex = 119;
            this.Label2.Text = "Cedula";
            // 
            // lvVideoJuegos
            // 
            this.lvVideoJuegos.CheckBoxes = true;
            this.lvVideoJuegos.Location = new System.Drawing.Point(16, 215);
            this.lvVideoJuegos.Name = "lvVideoJuegos";
            this.lvVideoJuegos.Size = new System.Drawing.Size(623, 232);
            this.lvVideoJuegos.TabIndex = 120;
            this.lvVideoJuegos.UseCompatibleStateImageBehavior = false;
            this.lvVideoJuegos.View = System.Windows.Forms.View.Details;
            this.lvVideoJuegos.SelectedIndexChanged += new System.EventHandler(this.lvVideoJuegos_SelectedIndexChanged);
            // 
            // lvClienteSeleccionado
            // 
            this.lvClienteSeleccionado.Location = new System.Drawing.Point(16, 158);
            this.lvClienteSeleccionado.Name = "lvClienteSeleccionado";
            this.lvClienteSeleccionado.Size = new System.Drawing.Size(623, 51);
            this.lvClienteSeleccionado.TabIndex = 165;
            this.lvClienteSeleccionado.UseCompatibleStateImageBehavior = false;
            // 
            // cmdAlquilarVideoJuegos
            // 
            this.cmdAlquilarVideoJuegos.Location = new System.Drawing.Point(16, 453);
            this.cmdAlquilarVideoJuegos.Name = "cmdAlquilarVideoJuegos";
            this.cmdAlquilarVideoJuegos.Size = new System.Drawing.Size(138, 36);
            this.cmdAlquilarVideoJuegos.TabIndex = 166;
            this.cmdAlquilarVideoJuegos.Text = "Alquilar";
            this.cmdAlquilarVideoJuegos.UseVisualStyleBackColor = true;
            this.cmdAlquilarVideoJuegos.Click += new System.EventHandler(this.cmdAlquilarVideoJuegos_Click);
            // 
            // cmdEliminarClienteSeleccionado
            // 
            this.cmdEliminarClienteSeleccionado.Enabled = false;
            this.cmdEliminarClienteSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarClienteSeleccionado.Location = new System.Drawing.Point(642, 157);
            this.cmdEliminarClienteSeleccionado.Name = "cmdEliminarClienteSeleccionado";
            this.cmdEliminarClienteSeleccionado.Size = new System.Drawing.Size(20, 33);
            this.cmdEliminarClienteSeleccionado.TabIndex = 167;
            this.cmdEliminarClienteSeleccionado.Text = "X";
            this.cmdEliminarClienteSeleccionado.UseVisualStyleBackColor = true;
            this.cmdEliminarClienteSeleccionado.Click += new System.EventHandler(this.cmdEliminarClienteSeleccionado_Click);
            // 
            // cmdAgregarCliente
            // 
            this.cmdAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregarCliente.Image")));
            this.cmdAgregarCliente.Location = new System.Drawing.Point(640, 51);
            this.cmdAgregarCliente.Name = "cmdAgregarCliente";
            this.cmdAgregarCliente.Size = new System.Drawing.Size(27, 34);
            this.cmdAgregarCliente.TabIndex = 121;
            this.cmdAgregarCliente.UseVisualStyleBackColor = true;
            this.cmdAgregarCliente.Click += new System.EventHandler(this.cmdAgregarCliente_Click);
            // 
            // FrmAlquilerVideoJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(737, 556);
            this.Controls.Add(this.cmdEliminarClienteSeleccionado);
            this.Controls.Add(this.cmdAlquilarVideoJuegos);
            this.Controls.Add(this.lvClienteSeleccionado);
            this.Controls.Add(this.cmdAgregarCliente);
            this.Controls.Add(this.lvVideoJuegos);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtgClientes);
            this.MaximizeBox = false;
            this.Name = "FrmAlquilerVideoJuegos";
            this.Text = "Alquiler de video juegos";
            this.Load += new System.EventHandler(this.FrmAlquilerVideoJuegos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgClientes;
        internal System.Windows.Forms.TextBox txtcedula;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ListView lvVideoJuegos;
        private System.Windows.Forms.Button cmdAgregarCliente;
        internal System.Windows.Forms.ListView lvClienteSeleccionado;
        private System.Windows.Forms.Button cmdAlquilarVideoJuegos;
        private System.Windows.Forms.Button cmdEliminarClienteSeleccionado;
    }
}
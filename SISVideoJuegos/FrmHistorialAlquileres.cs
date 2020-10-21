using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISVideoJuegos
{
    public partial class FrmHistorialAlquileres : Form
    {
        Globales ObjGlobales = new Globales();
        cDatos Objdatos = new cDatos();
        DataSet ObjDataSet = new DataSet();
    


        public FrmHistorialAlquileres()
        {
            InitializeComponent();
        }
        private void darformato()
        {
            dtgClientesHistorial.Columns[0].Visible = false;
            dtgClientesHistorial.Columns[1].Visible = false;
            dtgClientesHistorial.Columns[2].HeaderText = "Cedula";
            dtgClientesHistorial.Columns[3].HeaderText = "Nombre";
            dtgClientesHistorial.Columns[4].HeaderText = "Apellido";
            dtgClientesHistorial.Columns[5].HeaderText = "Video juego";
            dtgClientesHistorial.Columns[6].HeaderText = "Tipo de video juego";
            dtgClientesHistorial.Columns[7].HeaderText = "N° de Alquileres";
            dtgClientesHistorial.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientesHistorial.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientesHistorial.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientesHistorial.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientesHistorial.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientesHistorial.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientesHistorial.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void FrmHistorialAlquileres_Load(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAMostrarClientesVideoJuegos();
            dtgClientesHistorial.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgClientesHistorial);
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAFiltrarClienteVideoJuegos(txtcedula.Text);
            dtgClientesHistorial.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgClientesHistorial);
        }
    }
}

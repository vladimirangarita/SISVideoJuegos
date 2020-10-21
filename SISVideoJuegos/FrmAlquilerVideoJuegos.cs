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
    public partial class FrmAlquilerVideoJuegos : Form
    {
        Globales ObjGlobales = new Globales();
        cDatos Objdatos = new cDatos();
        DataSet ObjDataSet = new DataSet();
      
        DialogResult Resp;
        int IdCliente;

        public FrmAlquilerVideoJuegos()
        {
            InitializeComponent();
        }
        private void darformato()
        {
            dtgClientes.Columns[0].Visible = false;
            dtgClientes.Columns[1].Visible = true;
            dtgClientes.Columns[1].HeaderText = "Cedula";
            dtgClientes.Columns[2].HeaderText = "Nombre";
            dtgClientes.Columns[3].HeaderText = "Apellido";
            dtgClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void FrmAlquilerVideoJuegos_Load(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAMostrarClientes();
            dtgClientes.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgClientes);

            lvClienteSeleccionado.View = View.Details;
            lvClienteSeleccionado.Columns.Add("Cedula", 100);
            lvClienteSeleccionado.Columns.Add("Nombre", 150);
            lvClienteSeleccionado.Columns.Add("Apellido", 150);


            lvVideoJuegos.View = View.Details;
            lvVideoJuegos.Columns.Add("Código", 100);
            lvVideoJuegos.Columns.Add("Video juego", 150);
            lvVideoJuegos.Columns.Add("Tipo video juego", 150);
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAFiltrarCliente(txtcedula.Text);
            dtgClientes.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgClientes);
        }

        private void cmdAgregarCliente_Click(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAFiltrarCliente(this.dtgClientes.CurrentRow.Cells[0].Value.ToString());
            ListViewItem oreg = new ListViewItem(this.dtgClientes.CurrentRow.Cells[1].Value.ToString());
            oreg.SubItems.Add(this.dtgClientes.CurrentRow.Cells[2].Value.ToString());
            oreg.SubItems.Add(this.dtgClientes.CurrentRow.Cells[3].Value.ToString());

            lvClienteSeleccionado.Items.Add(oreg);
            IdCliente = Convert.ToInt32(dtgClientes.CurrentRow.Cells[0].Value.ToString());
            cmdAgregarCliente.Enabled = false;
            cmdEliminarClienteSeleccionado.Enabled = true;


            //DataTable dt = ObtenerDatos();

            ObjDataSet = Objdatos.PAMostrarVideoJuegos();

            foreach (DataRow row in ObjDataSet.Tables[0].Rows)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(row["IdVideoJuego"]));
                item.SubItems.Add(Convert.ToString(row["DescripcionVideoJuego"]));
                item.SubItems.Add(Convert.ToString(row["DescripcionTipoVideoJuego"]));

                lvVideoJuegos.Items.Add(item);

            }



        }

        private void cmdEliminarClienteSeleccionado_Click(object sender, EventArgs e)
        {
            lvClienteSeleccionado.Clear();
            lvClienteSeleccionado.View = View.Details;
            lvClienteSeleccionado.Columns.Add("Cedula", 100);
            lvClienteSeleccionado.Columns.Add("Nombre", 150);
            lvClienteSeleccionado.Columns.Add("Apellido", 150);

            lvVideoJuegos.Clear();
            lvVideoJuegos.View = View.Details;
            lvVideoJuegos.Columns.Add("Código", 100);
            lvVideoJuegos.Columns.Add("Video juego", 150);
            lvVideoJuegos.Columns.Add("Tipo video juego", 150);

            cmdEliminarClienteSeleccionado.Enabled = false;
            cmdAgregarCliente.Enabled = true;
            cmdAgregarCliente.Focus();
        }

        private void cmdAlquilarVideoJuegos_Click(object sender, EventArgs e)
        {

           
            int i;


            Resp = MessageBox.Show("¿Desea Alquilar los videos seleccionados?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //NSeleccionados = Convert.ToInt32(lvVideoJuegos.Items.Count);
                if (Resp==DialogResult.Yes)
                     {
            DateTime FechaActual;
            FechaActual=DateTime.Now;
            int IdVideoJuego;
            for (i = 0; i <= lvVideoJuegos.CheckedItems.Count - 1; i++)
            {

                IdVideoJuego = Convert.ToInt32(lvVideoJuegos.CheckedItems[i].Text);
                Objdatos.PAInsertarClienteVideoJuegos(IdCliente, IdVideoJuego, DateTime.Now);
                //ltvSeriales.CheckedItems.Item(i).SubItems(1).Text
            }



                     }

            lvClienteSeleccionado.Clear();
            lvClienteSeleccionado.View = View.Details;
            lvClienteSeleccionado.Columns.Add("Cedula", 100);
            lvClienteSeleccionado.Columns.Add("Nombre", 150);
            lvClienteSeleccionado.Columns.Add("Apellido", 150);

            lvVideoJuegos.Clear();
            lvVideoJuegos.View = View.Details;
            lvVideoJuegos.Columns.Add("Código", 100);
            lvVideoJuegos.Columns.Add("Video juego", 150);
            lvVideoJuegos.Columns.Add("Tipo video juego", 150);

            cmdEliminarClienteSeleccionado.Enabled = false;
            cmdAgregarCliente.Enabled = true;
            cmdAgregarCliente.Focus();


        }

        private void lvVideoJuegos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

     
    }
}

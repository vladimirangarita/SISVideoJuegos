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
    public partial class frmClientes : Form
    {
        Globales ObjGlobales = new Globales();
        cDatos Objdatos = new cDatos();

        DataSet ObjDataSet = new DataSet();
        String StrIdCliente;
       
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Btn_Aceptar.Text == "Guardar")
            {
                if (Objdatos.PABuscarCliente(txtcedula.Text) == false)
                {
                    if (txtcedula.TextLength == 0)
                    {
                        MessageBox.Show("Debe ingresar cedula");
                        txtcedula.Focus();
                        return;
                    }
                    if (txtNombre.TextLength == 0)
                    {
                        MessageBox.Show("Debe ingresar nombre");
                        txtNombre.Focus();
                        return;
                    }
                    if (txtApellido.TextLength == 0)
                    {
                        MessageBox.Show("Debe ingresar apellido");
                        txtApellido.Focus();
                        return;
                    }
                    Objdatos.PAInsertarCliente(txtcedula.Text,txtNombre.Text,txtApellido.Text);
                    darformato();
                    ObjGlobales.FormatearGrid(dtgClientes);
                    txtcedula.Text = "";
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    Btn_Aceptar.Text = "Guardar";
                    ObjDataSet = Objdatos.PAMostrarClientes();
                    dtgClientes.DataSource = ObjDataSet.Tables[0];
                    darformato();
                    ObjGlobales.FormatearGrid(dtgClientes);
                 
                }
                else
                {

                    MessageBox.Show("Ya esta registado");
          

                }
            }



            if (Btn_Aceptar.Text == "Modificar")
            {

                Objdatos.PAModificarCliente(txtcedula.Text, txtNombre.Text, txtApellido.Text);
                darformato();
                ObjGlobales.FormatearGrid(dtgClientes);

                txtcedula.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                Btn_Aceptar.Text = "Guardar";
                ObjDataSet = Objdatos.PAMostrarClientes();
                dtgClientes.DataSource = ObjDataSet.Tables[0];
                darformato();
                ObjGlobales.FormatearGrid(dtgClientes);


            }
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

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAMostrarClientes();
            dtgClientes.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgClientes);
       
        }

        private void dtgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StrIdCliente = Convert.ToString(dtgClientes.Rows[e.RowIndex].Cells[0].Value);
            txtcedula.Text = Convert.ToString(dtgClientes.Rows[e.RowIndex].Cells[1].Value);
            txtNombre.Text = Convert.ToString(dtgClientes.Rows[e.RowIndex].Cells[2].Value);
            txtApellido.Text = Convert.ToString(dtgClientes.Rows[e.RowIndex].Cells[3].Value);
            Btn_Aceptar.Text = "Modificar";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            darformato();
            ObjGlobales.FormatearGrid(dtgClientes);

            txtcedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            Btn_Aceptar.Text = "Guardar";
            ObjDataSet = Objdatos.PAMostrarClientes();
            dtgClientes.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgClientes);
        }
    }
}

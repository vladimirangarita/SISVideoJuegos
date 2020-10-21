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
    public partial class frmVideoJuegos : Form
    {
        Globales ObjGlobales = new Globales();
        cDatos Objdatos = new cDatos();
        DataSet ObjDataSet = new DataSet();
        String StrIdVideoJuego;
       
        public frmVideoJuegos()
        {
            InitializeComponent();
        }


        private DataSet CargarCboUnidades()
        {



            ObjDataSet = Objdatos.PAMostrarTipoVideJuegosActivos();

            DataRow row = ObjDataSet.Tables[0].NewRow();
            row["DescripcionTipoVideoJuego"] = "<- selecciona uno->";
            ObjDataSet.Tables[0].Rows.InsertAt(row, 0);

            cboTipo.DataSource = ObjDataSet.Tables[0];
            cboTipo.DisplayMember = ObjDataSet.Tables[0].Columns[1].Caption;
            cboTipo.ValueMember = ObjDataSet.Tables[0].Columns[0].Caption;

            return ObjDataSet;
        }

        private void darformato()
        {
            dtgVideoJuegos.Columns[0].Visible = false;
            dtgVideoJuegos.Columns[1].Visible = true;
            dtgVideoJuegos.Columns[0].HeaderText = "Codigo";
            dtgVideoJuegos.Columns[1].HeaderText = "Descripción video juego";
            dtgVideoJuegos.Columns[2].HeaderText = "Descripción tipo de video juego";
            dtgVideoJuegos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgVideoJuegos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgVideoJuegos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void frmVideoJuegos_Load(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAMostrarVideoJuegos();
            dtgVideoJuegos.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgVideoJuegos);
            CargarCboUnidades();
        }

        private void dtgVideoJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StrIdVideoJuego = Convert.ToString(dtgVideoJuegos.Rows[e.RowIndex].Cells[0].Value);
            txtVideoJuego.Text = Convert.ToString(dtgVideoJuegos.Rows[e.RowIndex].Cells[1].Value);
            cboTipo.Text = Convert.ToString(dtgVideoJuegos.Rows[e.RowIndex].Cells[2].Value);   
            Btn_Aceptar.Text = "Modificar";
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {


            if (Btn_Aceptar.Text == "Guardar")
            {



                if (Objdatos.PABuscarVideoJuego(txtVideoJuego.Text) == false)
                {


                    if (txtVideoJuego.TextLength == 0)
                    {
                        MessageBox.Show("Debe ingresar video juego");
                        txtVideoJuego.Focus();
                        return;
                    }

                    if (cboTipo.Text == "<- selecciona uno->")
                    {
                        MessageBox.Show("Debe ingresar tipo de video juego");
                        cboTipo.Focus();
                        return;
                    }

                    Objdatos.PAInsertarVideoJuego(txtVideoJuego.Text,Convert.ToInt32(cboTipo.SelectedValue));

                    
                    darformato();
                    ObjGlobales.FormatearGrid(dtgVideoJuegos);

                    txtVideoJuego.Text = "";
                    cboTipo.Refresh();
                    Btn_Aceptar.Text = "Guardar";
                    ObjDataSet = Objdatos.PAMostrarVideoJuegos();
                    dtgVideoJuegos.DataSource = ObjDataSet.Tables[0];
                    darformato();
                    ObjGlobales.FormatearGrid(dtgVideoJuegos);
                    CargarCboUnidades();
                }
                else
                {

                    MessageBox.Show("Ya esta registado");
                    CargarCboUnidades();

                }
            }



            if (Btn_Aceptar.Text == "Modificar")
            {


                int IdVideoJuego;
                int IdTipoVideoJuego;

                IdVideoJuego=Convert.ToInt16(StrIdVideoJuego);
                IdTipoVideoJuego = Convert.ToInt16(cboTipo.SelectedValue);


                Objdatos.PAModificarVideoJuego(IdVideoJuego, txtVideoJuego.Text, IdTipoVideoJuego);
                txtVideoJuego.Text = "";
                cboTipo.Refresh();
                Btn_Aceptar.Text = "Guardar";
                ObjDataSet = Objdatos.PAMostrarVideoJuegos();
                dtgVideoJuegos.DataSource = ObjDataSet.Tables[0];
                darformato();
                ObjGlobales.FormatearGrid(dtgVideoJuegos);
                CargarCboUnidades();


            }


        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Btn_Aceptar.Text = "Guardar";
            ObjDataSet = Objdatos.PAMostrarVideoJuegos();
            dtgVideoJuegos.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgVideoJuegos);
            CargarCboUnidades();
            txtVideoJuego.Text = "";
            cboTipo.Refresh();
        }

        
    }
}

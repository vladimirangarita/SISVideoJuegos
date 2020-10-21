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
    public partial class FrmTiposDeVideoJuegos : Form
    {
        Globales ObjGlobales = new Globales();
        cDatos Objdatos = new cDatos();
        DataSet ObjDataSet = new DataSet();
        int intIdTipoVideoJuego;
      
        public FrmTiposDeVideoJuegos()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Btn_Aceptar.Text == "Guardar")
            {



                if (Objdatos.PABuscarTipoVideoJuego(txtVideoJuegoTipo.Text) == false)
                {



                    if (txtVideoJuegoTipo.TextLength == 0)
                    {
                        MessageBox.Show("Debe ingresar tipo de video juego");
                        txtVideoJuegoTipo.Focus();
                        return;
                    }


                    bool blbEstatus = false;


                    if (rbActivo.Checked == true)
                    {
                        blbEstatus = true;
                    }
                    else
                    {
                        blbEstatus = false;
                    }


                    Objdatos.PAInsertarTipoVideoJuego(txtVideoJuegoTipo.Text, blbEstatus);


                    darformato();
                    ObjGlobales.FormatearGrid(dtgVideoJuegosTipo);

                    txtVideoJuegoTipo.Text = "";
                    Btn_Aceptar.Text = "Guardar";
                    ObjDataSet = Objdatos.PAMostrarTipoVideJuegos();
                    dtgVideoJuegosTipo.DataSource = ObjDataSet.Tables[0];
                    darformato();
                    ObjGlobales.FormatearGrid(dtgVideoJuegosTipo);
              
                }
                else
                {

                    MessageBox.Show("Ya esta registado");
                    

                }
            }



            if (Btn_Aceptar.Text == "Modificar")
            {


                bool blbEstatus = false;


                if (rbActivo.Checked == true)
                {
                    blbEstatus = true;
                }
                else
                {
                    blbEstatus = false;
                }

                Objdatos.PAModificarTipoVideoJuego(intIdTipoVideoJuego, txtVideoJuegoTipo.Text, blbEstatus);
                darformato();
                ObjGlobales.FormatearGrid(dtgVideoJuegosTipo);

                txtVideoJuegoTipo.Text = "";
                Btn_Aceptar.Text = "Guardar";
                ObjDataSet = Objdatos.PAMostrarTipoVideJuegos();
                dtgVideoJuegosTipo.DataSource = ObjDataSet.Tables[0];
                darformato();
                ObjGlobales.FormatearGrid(dtgVideoJuegosTipo);


            }

        }

        private void darformato()
        {
            dtgVideoJuegosTipo.Columns[0].Visible = false;
            dtgVideoJuegosTipo.Columns[1].Visible = true;
            dtgVideoJuegosTipo.Columns[0].HeaderText = "Codigo";
            dtgVideoJuegosTipo.Columns[1].HeaderText = "Descripción tipo video juego";
            dtgVideoJuegosTipo.Columns[2].HeaderText = "Estatus";
            dtgVideoJuegosTipo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgVideoJuegosTipo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgVideoJuegosTipo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmTiposDeVideoJuegos_Load(object sender, EventArgs e)
        {
            ObjDataSet = Objdatos.PAMostrarTipoVideJuegos();
            dtgVideoJuegosTipo.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgVideoJuegosTipo);
       
        }

        private void dtgVideoJuegosTipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            intIdTipoVideoJuego = Convert.ToInt32(dtgVideoJuegosTipo.Rows[e.RowIndex].Cells[0].Value);
            txtVideoJuegoTipo.Text = Convert.ToString(dtgVideoJuegosTipo.Rows[e.RowIndex].Cells[1].Value);

            bool blnEstatus = Convert.ToBoolean(dtgVideoJuegosTipo.Rows[e.RowIndex].Cells[2].Value);

            if (blnEstatus == true)
            {
                rbActivo.Checked = true;
            }
            if (blnEstatus == false)
            {
                rbInactivo.Checked = true;
            }
            
            Btn_Aceptar.Text = "Modificar";
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            darformato();
            ObjGlobales.FormatearGrid(dtgVideoJuegosTipo);

            txtVideoJuegoTipo.Text = "";
            Btn_Aceptar.Text = "Guardar";
            ObjDataSet = Objdatos.PAMostrarTipoVideJuegos();
            dtgVideoJuegosTipo.DataSource = ObjDataSet.Tables[0];
            darformato();
            ObjGlobales.FormatearGrid(dtgVideoJuegosTipo);
        }
    }
}

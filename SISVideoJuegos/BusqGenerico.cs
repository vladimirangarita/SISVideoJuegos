using System;
using System.Data;
using System.Windows.Forms;
namespace SISVideoJuegos
{
    public partial class BusqGenerico : Form
    {
        public string Form = "";
        DataSet datos = new DataSet();
       Globales objGlobales = new Globales();
        cDatos objDatos = new cDatos();

        public BusqGenerico()
        {
            InitializeComponent();
        }



        private void pasar()
{

	try {
		if (data_busqueda.RowCount == 0) {
			return;
		}
		int Fila_Seleccionada = data_busqueda.CurrentCell.RowIndex;
        //switch (Form) {
        //    case "MARCAS":
        //        // MsgBox(Trim(data_busqueda.Rows(Fila_Seleccionada).Cells(1).Value.ToString))
        //        string strMarca = data_busqueda.Rows[Fila_Seleccionada].Cells[1].Value;
        //        intIdVideoJuego = Convert.ToInt32(data_busqueda.Rows[Fila_Seleccionada].Cells[0].Value);
        //        FrmMarcas.txtMarcas.Text = (Strings.Trim(strMarca));
        //        FrmMarcas.Btn_Guardar.Text = "Modificar";
        //        blnEstatusMarca = data_busqueda.Rows(Fila_Seleccionada).Cells(2).Value;
        //        if (blnEstatusMarca == true) {
        //            FrmMarcas.rbActivo.Checked = true;
        //        } else {
        //            FrmMarcas.rbInactivo.Checked = true;
        //        }

        //        break;
        //}
        //Form = "";
		this.Close();



	} catch (Exception ex) {
	}
}


        private void Txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Txt_Filtro_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Txt_Filtro_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void BusqGenerico_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}

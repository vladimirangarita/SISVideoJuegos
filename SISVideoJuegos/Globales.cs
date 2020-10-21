using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace SISVideoJuegos
{
     

    class Globales
    {

      

        internal void FormatearGrid(DataGridView DgView)
        {
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            DgView.EnableHeadersVisualStyles = false;

            columnHeaderStyle.BackColor = Color.LightBlue;

            columnHeaderStyle.ForeColor = Color.Black;

            DgView.DefaultCellStyle.BackColor = Color.White;

            DgView.DefaultCellStyle.ForeColor = Color.Black;

            DgView.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;

            DgView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            DgView.BackgroundColor = Color.White;

            DgView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;

            DgView.RowHeadersVisible = false;

            DgView.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            DgView.MultiSelect = false;




        }


    }
}

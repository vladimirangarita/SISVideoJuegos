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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ToolStripButtonCliente_Click(object sender, EventArgs e)
        {
            frmClientes ObjformularioClientes = new frmClientes();

            try
            {

                if (ObjformularioClientes.Created == false)
                {
                    ObjformularioClientes.StartPosition = FormStartPosition.CenterScreen;
                    ObjformularioClientes.Show();
                }
                else
                {
                    ObjformularioClientes.BringToFront();
                }


            }
            catch (Exception ex)
            {
            }





        }

        private void ToolStripButtonVideoJuegos_Click(object sender, EventArgs e)
        {

            frmVideoJuegos ObjformularioVideoJuegos = new frmVideoJuegos();

            try
            {

                if (ObjformularioVideoJuegos.Created == false)
                {
                    ObjformularioVideoJuegos.StartPosition = FormStartPosition.CenterScreen;
                    ObjformularioVideoJuegos.Show();
                }
                else
                {
                    ObjformularioVideoJuegos.BringToFront();
                }


            }
            catch (Exception ex)
            {
            }

        }

        private void ToolStripButtonTiposVideoJuegos_Click(object sender, EventArgs e)
        {
            FrmTiposDeVideoJuegos ObjformularioTipoVideoJuegos = new FrmTiposDeVideoJuegos();

            try
            {

                if (ObjformularioTipoVideoJuegos.Created == false)
                {
                    ObjformularioTipoVideoJuegos.StartPosition = FormStartPosition.CenterScreen;
                    ObjformularioTipoVideoJuegos.Show();
                }
                else
                {
                    ObjformularioTipoVideoJuegos.BringToFront();
                }


            }
            catch (Exception ex)
            {
            }
        }

        private void ToolStripButtonAlquiler_Click(object sender, EventArgs e)
        {
            FrmAlquilerVideoJuegos ObjformularioTipoVideoJuegos = new FrmAlquilerVideoJuegos();

            try
            {

                if (ObjformularioTipoVideoJuegos.Created == false)
                {
                    ObjformularioTipoVideoJuegos.StartPosition = FormStartPosition.CenterScreen;
                    ObjformularioTipoVideoJuegos.Show();
                }
                else
                {
                    ObjformularioTipoVideoJuegos.BringToFront();
                }


            }
            catch (Exception ex)
            {
            }
        }

        private void ToolStripButtonHistorialAlquiler_Click(object sender, EventArgs e)
        {
            FrmHistorialAlquileres ObjformularioTipoVideoJuegos = new FrmHistorialAlquileres();

            try
            {

                if (ObjformularioTipoVideoJuegos.Created == false)
                {
                    ObjformularioTipoVideoJuegos.StartPosition = FormStartPosition.CenterScreen;
                    ObjformularioTipoVideoJuegos.Show();
                }
                else
                {
                    ObjformularioTipoVideoJuegos.BringToFront();
                }


            }
            catch (Exception ex)
            {
            }
        }
    }
}

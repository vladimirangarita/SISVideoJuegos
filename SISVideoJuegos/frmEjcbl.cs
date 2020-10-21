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
    public partial class frmEjcbl : Form
    {
        public frmEjcbl()
        {
            InitializeComponent();
        }

        private void frmEjcbl_Load(object sender, EventArgs e)
        {
            Product product;
            List<Product> productsCollection = new List<Product>();
            product = new Product();
            product.Code = "A01";
            product.Name = "Naranjas";
            productsCollection.Add(product);
            product = new Product();
            product.Code = "A02";
            product.Name = "Peras";
            product = new Product();
            product.Code = "A03";
            product.Name = "Bananas";
            productsCollection.Add(product);
            this.checkedListBox1.DataSource = productsCollection.ToList();
            this.checkedListBox1.DisplayMember = "Code";
            this.checkedListBox1.ValueMember = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in this.checkedListBox1.CheckedItems)
            {
                Product product = (Product)(item);
                MessageBox.Show(product.Code + Environment.NewLine + product.Name);
            }
        }
    }
}

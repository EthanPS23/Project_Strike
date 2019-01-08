using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPkg_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnAddEditPkg.Text = "Add Package";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            btnAddEditPkg.Text = "Edit Package";
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            btnAddEditProd.Text = "Add Product";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            btnAddEditProd.Text = "Edit Product";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            btnAddEditSup.Text = "Add Supplier";
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            btnAddEditSup.Text = "Edit Supplier";
        }
    }
}

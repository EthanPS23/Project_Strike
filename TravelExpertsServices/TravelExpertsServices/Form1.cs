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
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 1;
            btnAddEditPkg.Text = "Add Package";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 1;
            btnAddEditPkg.Text = "Edit Package";
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the products pages and changes to the products page
            tabControl1.SelectedIndex = 2;
            btnAddEditProd.Text = "Add Product";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the products pages and changes to the products page
            tabControl1.SelectedIndex = 2;
            btnAddEditProd.Text = "Edit Product";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the suppliers pages and changes to the suppliers page
            tabControl1.SelectedIndex = 3;
            btnAddEditSup.Text = "Add Supplier";
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 3;
            btnAddEditSup.Text = "Edit Supplier";
        }

        private void btnAddEditPkg_Click(object sender, EventArgs e)
        {
            // Checks the text of the Add/edit package button in order to perform various logic
            if (btnAddEditPkg.Text=="Add Package")
            {

            }
            else if (btnAddEditPkg.Text=="Edit Package")
            {

            }
        }

        private void btnAddEditProd_Click(object sender, EventArgs e)
        {
            // Checks the text of the Add/edit product button in order to perform various logic
            if (btnAddEditProd.Text == "Add Product")
            {

            }
            else if (btnAddEditProd.Text == "Edit Product")
            {

            }
        }

        private void btnAddEditSup_Click(object sender, EventArgs e)
        {
            // Checks the text of the Add/edit supplier button in order to perform various logic
            if (btnAddEditSup.Text == "Add Supplier")
            {

            }
            else if (btnAddEditSup.Text == "Edit Supplier")
            {

            }
        }

        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

        }
    }
}

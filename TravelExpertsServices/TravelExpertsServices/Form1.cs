using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsDB;

namespace TravelExpertsServices
{
    public partial class Form1 : Form
    {
        List<Packages> PackagesList = PackagesDB.GetPackages();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPkg_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 1;
            txtPackageName.Text = "";
            dtpPkgStartDate.Text = "";
            dtpPkgEndDate.Text = "";
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgAgencyCommission.Text = "";
            btnAddEditPkg.Text = "Save New Package";
        }

        private void btnEditPkg_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 1;
            btnAddEditPkg.Text = "Save Edited Package";
            //int rw = packagesDataGridView.CurrentCell.RowIndex;
            int rw = gvPackages.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvPackages.Rows[rw];
            var Packages = from Pkg in PackagesList
                           //where Pkg.PackageID == Convert.ToInt32(packagesDataGridView[0, rw].Value)
                           where Pkg.PackageID == Convert.ToInt32(selectedRow.Cells[0].Value)
                           select new
                           {
                               Pkg.PackageID,
                               Pkg.PkgName,
                               Pkg.PkgStartDate,
                               Pkg.PkgEndDate,
                               Pkg.PkgDesc,
                               Pkg.PkgBasePrice,
                               Pkg.PkgAgencyCommission
                           };
            //packagesDataGridView.Rows[0].Cells[0];
            foreach (var item in Packages)
            {
                txtPackageName.Text = item.PkgName;
                dtpPkgStartDate.Text = item.PkgStartDate.ToString();
                dtpPkgEndDate.Text = item.PkgEndDate.ToString();
                txtPkgDesc.Text = item.PkgDesc;
                txtPkgBasePrice.Text = item.PkgBasePrice.ToString("c");

                txtPkgAgencyCommission.Text = item.PkgAgencyCommission.ToString();


                //cmbProdName=item.pr
                //cmbSupName

            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the products pages and changes to the products page
            tabControl1.SelectedIndex = 2;
            txtProdName.Text = "";
            btnAddEditProd.Text = "Save New Product";
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the products pages and changes to the products page
            tabControl1.SelectedIndex = 2;
            btnAddEditProd.Text = "Save Edited Product";
        }

        private void btnAddSup_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the suppliers pages and changes to the suppliers page
            tabControl1.SelectedIndex = 3;
            txtSupName.Text = "";
            btnAddEditSup.Text = "Save New Supplier";
        }

        private void btnEditSup_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 3;
            btnAddEditSup.Text = "Save Edited Supplier";
        }

        private void btnAddEditPkg_Click(object sender, EventArgs e)
        {
            // Checks the text of the Add/edit package button in order to perform various logic
            if (btnAddEditPkg.Text== "Save New Package")
            {

            }
            else if (btnAddEditPkg.Text== "Save Edited Package")
            {
                                
            }
        }

        private void btnAddEditProd_Click(object sender, EventArgs e)
        {
            // Checks the text of the Add/edit product button in order to perform various logic
            if (btnAddEditProd.Text == "Save New Product")
            {

            }
            else if (btnAddEditProd.Text == "Save Edited Product")
            {

            }
        }

        private void btnAddEditSup_Click(object sender, EventArgs e)
        {
            // Checks the text of the Add/edit supplier button in order to perform various logic
            if (btnAddEditSup.Text == "Save New Supplier")
            {

            }
            else if (btnAddEditSup.Text == "Save Edited Supplier")
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
            gvPackages.Columns[0].Visible = false;

        }

        List<PackageProductSuppliers> ppss = new List<PackageProductSuppliers>();
        private void gvPackages_SelectionChanged(object sender, EventArgs e)
        {
            Packages selectedPackage = null;
            try
            {
                foreach (DataGridViewRow row in gvPackages.SelectedRows)
                {
                    selectedPackage = new Packages(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                      row.Cells[1].Value.ToString(),
                                      (DateTime?)(row.Cells[2].Value),
                                      (DateTime?)(row.Cells[3].Value),
                                      row.Cells[4].Value.ToString(),
                                      Convert.ToDecimal(row.Cells[5].Value.ToString()),
                                      (decimal?)(row.Cells[6].Value));                    
                }
                ppss = PackageProductSuppliersDB.GetProductSuppliersByPackage(selectedPackage);
                gvProducts.DataSource = ppss;
                gvSuppliers.DataSource = ppss;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // display products & suppliers
        List<Products> Prod = null;
        List<Products> selectProducts;
        List<Suppliers> Sup = null;
        List<Suppliers> selectSuppliers;

        private void GetProduct(int productID)
        {
            Prod = ProductDB.GetProducts();
            selectProducts = (from Pd in Prod
                              where Pd.ProductId == productID
                    select Pd).ToList();

            grProducts1.DataSource = selectProducts;

        }

        private void GetSupplier(int supplierID)
        {
            Sup = SuppliersDB.GetSuppliers();
            selectSuppliers = (from Sp in Sup
                              where Sp.SupplierId == supplierID
                              select Sp).ToList();

            gvSuppliers2.DataSource = selectSuppliers;
        }

        private void grProducts1_SelectionChanged(object sender, EventArgs e)
        {
            
            Products selectedProduct = null;
            try
            {
                foreach (DataGridViewRow row in grProducts1.SelectedRows)
                {
                    selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                   row.Cells[1].Value.ToString());
                    
                }
               
                Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                grSuppliers1.DataSource = Sup;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    
        private void gvSuppliers2_SelectionChanged(object sender, EventArgs e)
        {
            Suppliers selectedSupplier = null;
            try
            {
                foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
                {
                    selectedSupplier = new Suppliers(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                   row.Cells[1].Value.ToString());
                }

                Prod = SuppliersDB.GetProductsByProductSupplier(selectedSupplier);
                gvProducts2.DataSource = Prod;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


    }
}

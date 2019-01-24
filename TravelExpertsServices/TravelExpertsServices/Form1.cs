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
using Microsoft.VisualBasic;

namespace TravelExpertsServices
{
    // Ethan Shipley
    public partial class Form1 : Form
    {
        // create constants
        const int PKG_NAME_LENGTH = 50;
        const int PKG_DESC_LENGTH = 50;
        // variables
        int pkgid;
        int slct_colmn;
        // display products & suppliers
        List<Products> Prod = null;
        List<Products> selectProducts;
        List<Suppliers> Sup = null;
        List<Suppliers> selectSuppliers;
        List<PackageProductSuppliers> ppss = new List<PackageProductSuppliers>();
        List<ProdSuppliersNames> psn = new List<ProdSuppliersNames>();
        List<Packages> PackagesList = PackagesDB.GetPackages();
        public Form1()
        {
            InitializeComponent();
        }

        // Ethan Shipley
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
            gvSuppliers_pkgs.DataSource = "";
            gvProducts_pkgs.DataSource = "";
            cmbProdName.Enabled = false;
            cmbSupName.Enabled = false;
            btnAddEditPkg.Text = "Save New Package";
        }

        // Ethan Shipley
        private void btnEditPkg_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 1;
            btnAddEditPkg.Text = "Save Edited Package";
            //int rw = packagesDataGridView.CurrentCell.RowIndex;
            //int rw = gvPackages.SelectedCells[0].RowIndex;
            //DataGridViewRow selectedRow = gvPackages.Rows[rw];
            var Packages = from Pkg in PackagesList
                               //where Pkg.PackageID == Convert.ToInt32(packagesDataGridView[0, rw].Value)
                           //where Pkg.PackageID == Convert.ToInt32(selectedRow.Cells[0].Value)
                           where Pkg.PackageID == getSelectedCellValue(gvPackages, 0)
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
                pkgid = item.PackageID;
                txtPackageName.Text = item.PkgName;
                dtpPkgStartDate.Text = item.PkgStartDate.ToString();
                dtpPkgEndDate.Text = item.PkgEndDate.ToString();
                txtPkgDesc.Text = item.PkgDesc;
                txtPkgBasePrice.Text = item.PkgBasePrice.ToString("c");
                txtPkgAgencyCommission.Text = item.PkgAgencyCommission.ToString("c");
            }
            UpdateBinding();
            PackagesListDetails(gvProdSup_pkg);
            getSelectedProduct();
            supplierComboBoxMatch();
            cmbProdName.Enabled = false;
            cmbSupName.Enabled = false;
        }

        // Ethan Shipley
        // Updates the datasource for grid views
        private void UpdateBinding()
        {
            gvProducts_pkgs.DataSource = ppss;
            gvSuppliers_pkgs.DataSource = ppss;
            gvProdSup_pkg.DataSource = ppss;
            gvProdSup_all_pkgs.DataSource = psn;
        }

        //Ethan Shipley
        // Formats the ppackages prod and supplier details
        private static void PackagesListDetails(DataGridView dataGridView)
        {
            //dataGridView.Columns[0].Visible = false;
            //dataGridView.Columns[1].Visible = false;
            //dataGridView.Columns[2].Visible = false;
            //dataGridView.Columns[3].Visible = false;
            //dataGridView.Columns[4].Visible = false;
            //dataGridView.Columns[5].Visible = false;
            dataGridView.Columns[5].HeaderText = "Product Name";
            dataGridView.Columns[6].HeaderText = "Supplier Name";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        // Ethan Shipley
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the products pages and changes to the products page
            tabControl1.SelectedIndex = 2;
            txtProdName.Text = "";
            btnAddEditProd.Text = "Save New Product";
        }

        // Ethan Shipley
        private void btnEditProd_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the products pages and changes to the products page
            tabControl1.SelectedIndex = 2;
            btnAddEditProd.Text = "Save Edited Product";
        }

        // Ethan Shipley
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the suppliers pages and changes to the suppliers page
            tabControl1.SelectedIndex = 3;
            txtSupName.Text = "";
            btnAddEditSup.Text = "Save New Supplier";
        }

        // Ethan Shipley
        private void btnEditSup_Click(object sender, EventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 3;
            btnAddEditSup.Text = "Save Edited Supplier";
        }

        // Ethan Shipley
        // creates or edits a package based and verifies the correct input of data
        private void btnAddEditPkg_Click(object sender, EventArgs e)
        {
            // declare variables
            Packages pack = new Packages();
            DateTime strt = dtpPkgStartDate.Value;
            DateTime end = dtpPkgEndDate.Value;
            // verifies that the user entered a package name shorter then 50 characters
            if (txtPackageName.Text.Length > 50)
            {
                MessageBox.Show("Please enter a package name shorter then 50 characters.");
                return;
            }
            else
            {
                pack.PkgName = txtPackageName.Text.ToString();
            }

            // verifies that the user entered a package description shorter then 50 characters
            if (txtPkgDesc.Text.Length > 50)
            {
                MessageBox.Show("Please enter a package description shorter then 50 characters.");
                return;
            }
            else
            {
                pack.PkgDesc = txtPkgDesc.Text.ToString();
            }

            // checks that the user inputted valid dates for the package
            if (end < strt && !end.ToShortDateString().Equals(strt.ToShortDateString()))
            {
                dtpPkgEndDate.Value = dtpPkgStartDate.Value;
                MessageBox.Show("Please enter an end date that is equal to or greater than the start date.");
                return;
            }
            else if (strt < DateTime.Now && !DateTime.Now.ToShortDateString().Equals(dtpPkgEndDate.Value.ToShortDateString()))
            {

                MessageBox.Show("Please enter a start date that is greater than todays date.");
                dtpPkgStartDate.Value = DateTime.Now;
                return;
            }
            else if (end < DateTime.Now && !DateTime.Now.ToShortDateString().Equals(dtpPkgEndDate.Value.ToShortDateString()))
            {
                MessageBox.Show("Please enter an end date that is greater than todays date.");
                dtpPkgEndDate.Value = DateTime.Now;
                return;
            }
            else
            {
                pack.PkgStartDate = Convert.ToDateTime(strt.ToShortDateString());
                pack.PkgEndDate = Convert.ToDateTime(end.ToShortDateString());
            }
            // removes the unnecessary dollar sign and comma in the base price and commision
            pack.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text.ToString().Replace("$", "").Replace(",", ""));
            pack.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text.ToString().Replace("$", "").Replace(",", ""));


            // Checks the text of the Add/edit package button in order to perform various logic
            if (btnAddEditPkg.Text == "Save New Package")
            {
                //Inserts the package into the database and then refreshes the mainpage
                PackagesDB.InsertPackages(pack);
                this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            }
            else if (btnAddEditPkg.Text == "Save Edited Package")
            {
                // updates the package and then refreshes the main page
                PackagesDB.UpdatePackages(pack, pkgid);
                this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            }
        }

        //Ethan Shipley
        // Deletes a selected package
        private void btnDeletepkg_Click(object sender, EventArgs e)
        {
            if (!deleteConfirm())
            {
                return;
            }
            PackagesDB.DeletePackage(pkgid);
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);            
        }
        // Ethan Shipley
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

        // Ethan Shipley
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

        //Ethan Shipley
        // Code for the navigator save item button on click event
        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        //Ethan Shipley
        // On form load performs these actions
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages_Products_Suppliers' table. You can move, or remove it, as needed.
            this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

            //THIS TO BE UNCOMMENTED AFTER TESTING

            gvPackages.Columns[0].Visible = false;
            gvProducts.Columns[0].Visible = false;
            gvSuppliers.Columns[0].Visible = false;
            gvProducts_pkgs.Columns[0].Visible = false;
            gvSuppliers_pkgs.Columns[0].Visible = false;
            
            btnSave_Prod_Sup_pkg.Enabled = false;
            btnSave_Prod_Sup_pkg.Visible = false;
        }

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
                                      (decimal)(row.Cells[6].Value));
                }
                ppss = PackageProductSuppliersDB.GetProductSuppliersByPackage(selectedPackage);
                pkgid = selectedPackage.PackageID;
                gvProducts.DataSource = ppss;
                gvSuppliers.DataSource = ppss;
            }
            catch (NullReferenceException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

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

        //Ethan Shipley
        //Removes an error that occurs on application close
        private void gvProducts_pkgs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        //Ethan Shipley
        //Removes an error that occurs on application close
        private void gvSuppliers_pkgs_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            return;
        }

        //Ethan Shipley
        private void btnAddProd_pkg_Click(object sender, EventArgs e)
        {
            var index = gvProducts_pkgs.Rows.Add();
        }

        
        private void btnChangeProd_Click(object sender, EventArgs e)
        {
            //getSelectedSupplier();
            cmbProdName.Enabled = true;
            cmbSupName.Enabled = true;
            btnSave_Prod_Sup_pkg.Enabled = true;
            btnSave_Prod_Sup_pkg.Visible = true;

        }


        // Ethan Shipley
        // Gets the selected data to fill in the combo box
        // Gets the supplier from products data to fill in the supplier combo box
        private void getSelectedProduct()
        {
            Products selectedProduct = null;
            try
            {
                foreach (DataGridViewRow row in gvProducts_pkgs.SelectedRows)
                {
                    selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                   row.Cells[1].Value.ToString());

                }

                Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                cmbSupName.DataSource = Sup;
                supplierComboBoxMatch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Ethan Shipley
        // Gets the product from suppliers data to fill in the product combo box
        private void getSelectedSupplier()
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
                cmbProdName.DataSource = Prod;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Ethan Shipley
        // this may be slowing the code
        private void gvSuppliers_pkgs_SelectionChanged(object sender, EventArgs e)
        {
            getSelectedProduct();
            //getSelectedSupplier();
            supplierComboBoxMatch();
            productComboBoxMatch();
        }
        // Ethan Shipley
        // Get set the value of the combobox to match that of the supplier
        // this may be slowing the code
        private void gvProducts_pkgs_SelectionChanged(object sender, EventArgs e)
        {
            getSelectedProduct();
            //getSelectedSupplier();
            supplierComboBoxMatch();
            productComboBoxMatch();
        }

        // Ethan Shipley
        // Get set the value of the combobox to match that of the supplier
        // this may be slowing the code
        private void supplierComboBoxMatch()
        {
            string c;
            int i;
            try
            {
                i = gvSuppliers_pkgs.CurrentCell.RowIndex;
                c = gvSuppliers_pkgs[1, i].Value.ToString();
                cmbSupName.SelectedIndex = cmbSupName.FindString(c);
            }
            catch (Exception)
            {

                return;
            }   
            
        }

        // Ethan Shipley
        // Get set the value of the combobox to match that of the product
        // this may be slowing the code
        private void productComboBoxMatch()
        {
            string c;
            int i;
            try
            {
                i = gvProducts_pkgs.CurrentCell.RowIndex;
                c = gvProducts_pkgs[1, i].Value.ToString();
                cmbProdName.SelectedIndex = cmbProdName.FindString(c);
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void btnDelProd_pkg_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSup_pkg_Click(object sender, EventArgs e)
        {

        }

        private void btnDelSup_pkg_Click(object sender, EventArgs e)
        {

        }

        // Ethan Shipley
        // Lets the user know how many cahracters they have left for the package name
        private void txtPackageName_TextChanged(object sender, EventArgs e)
        {
            lblPkgNameLength.Text = "Remaining length " + Convert.ToString(PKG_NAME_LENGTH - txtPackageName.Text.Length);
        }

        // Ethan Shipley
        // Lets the user know how many cahracters they have left for the package name
        private void txtPkgDesc_TextChanged(object sender, EventArgs e)
        {
            lblPkgDescLength.Text = "Remaining length " + Convert.ToString(PKG_DESC_LENGTH - txtPkgDesc.Text.Length);
        }

        //Ethan Shipley
        // Checks that the user enter in a date equivalent to today or greater then
        private void dtpPkgStartDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime start = dtpPkgStartDate.Value;
            DateTime now = DateTime.Now;
            if (start<now && !DateTime.Now.ToShortDateString().Equals(dtpPkgStartDate.Value.ToShortDateString()))
            {
                MessageBox.Show("Please enter a date greater then todays date");
                dtpPkgStartDate.Value = DateTime.Now;
            }
        }

        //Ethan Shipley
        // Checks that the user enter in a date equivalent to today or greater then
        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime end = dtpPkgEndDate.Value;
            DateTime now = DateTime.Now;
            if (end < now && !DateTime.Now.ToShortDateString().Equals(dtpPkgEndDate.Value.ToShortDateString()))
            {
                MessageBox.Show("Please enter a date greater then todays date");
                dtpPkgEndDate.Value = DateTime.Now;
            }
        }
        //Ethan Shipley
        // determines the prodcuctId and product supplierid in order to change the product for the package
        private void btnSaveProdPkg_Click(object sender, EventArgs e)
        {
            //Declare the variables that will be used for updating the database
            int selectedvalueprodid = Convert.ToInt32(cmbProdName.SelectedValue);
            int selectedprodsupId = -9;
            int selectedindex;

            // this if statement is used to prevent updates to the database upon opening of the program and closing of program
            if (selectedvalueprodid == 0)
            {
                return;
            }
            // goes through ppss to determine the productsupplier id that will be used to determine the coorect field is properly updated
            foreach (var item in ppss)
            {
                // this if statement find matching packageID and productID in order to determine the selected products products supplierID
                if ((pkgid == item.PackageId) && (Convert.ToInt32(gvProducts_pkgs[0, gvProducts_pkgs.CurrentCell.RowIndex].Value) == item.ProductId))
                {
                    selectedprodsupId = item.ProductSupplierId;
                    break;
                }
            }
            if (selectedvalueprodid == 0 || selectedprodsupId == -9)
            {
                return;
            }
            //MessageBox.Show(selectedvalueprodid + "   " + selectedprodsupId);
            //Updated the data base and
            ProdSupplierDB.UpdateProductIDByPackage(pkgid, selectedvalueprodid, selectedprodsupId);
            //selectedindex = Convert.ToInt32(gvPackages[0, gvPackages.CurrentCell.RowIndex].Value);Rows(selectedindex).Cells(0);
            selectedindex = gvPackages.CurrentCell.RowIndex;
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            gvPackages.CurrentCell = gvPackages[1, selectedindex];
            UpdateBinding();
        }

        //Ethan Shipley
        // on click of the change supplier it enables the supplier combo box and gets the required dat for the drop down list
        private void btnChangeSup_Click(object sender, EventArgs e)
        {
            //getSelectedPoduct();
            cmbSupName.Enabled = true;
        }

        //Ethan Shipley
        // determines the supplierId and product supplierid in order to change the supplier for the package
        private void btnSaveSupPkg_Click(object sender, EventArgs e)
        {
            //Declare the variables that will be used for updating the database
            int selectedvaluesupid = Convert.ToInt32(cmbSupName.SelectedValue);
            int selectedprodsupId = -9;
            int selectedindex;

            // this if statement is used to prevent updates to the database upon opening of the program and closing of program
            if (selectedvaluesupid == 0)
            {
                return;
            }
            // goes through ppss to determine the productsupplier id that will be used to determine the coorect field is properly updated
            foreach (var item in ppss)
            {
                // this if statement find matching packageID and productID in order to determine the selected products products supplierID
                if ((pkgid == item.PackageId) && (Convert.ToInt32(gvSuppliers_pkgs[0, gvSuppliers_pkgs.CurrentCell.RowIndex].Value) == item.SupplierId))
                {
                    selectedprodsupId = item.ProductSupplierId;
                    break;
                }
            }
            if (selectedvaluesupid == 0 || selectedprodsupId == -9)
            {
                return;
            }
            //MessageBox.Show(selectedvalueprodid + "   " + selectedprodsupId);
            //Updated the data base and
            ProdSupplierDB.UpdateSupplierIDByPackage(pkgid, selectedvaluesupid, selectedprodsupId);
            //selectedindex = Convert.ToInt32(gvPackages[0, gvPackages.CurrentCell.RowIndex].Value);Rows(selectedindex).Cells(0);
            selectedindex = gvPackages.CurrentCell.RowIndex;
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            gvPackages.CurrentCell = gvPackages[1, selectedindex];
            UpdateBinding();
        }

        //Ethan Shipley
        // Dsiplays the list of available product suppliers
        private void btnUpdatePkgProdSup_Click(object sender, EventArgs e)
        {
            psn = ProdSuppliersNamesDB.GetProdSupAll();
            gvProdSup_all_pkgs.DataSource = psn;
            //ProdSupListDetails(gvProdSup_all_pkgs);
            gvProdSup_all_pkgs.Visible = true;
        }

        //Ethan Shipley
        // Formats the prod and supplier details
        private static void ProdSupListDetails(DataGridView dataGridView)
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[3].HeaderText = "Product Name";
            dataGridView.Columns[4].HeaderText = "Supplier Name";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Ethan Shipley
        // Adds the products suppliers to the package
        private void btnAddPkgProdSup_Click(object sender, EventArgs e)
        {
            PackageProductSuppliersDB.InsertProductSupplierIdPpkg(pkgid, getSelectedCellValue(gvProdSup_all_pkgs, 0));
            slct_colmn = gvPackages.CurrentCell.RowIndex; 
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            gvPackages.CurrentCell = gvPackages[3, slct_colmn];
            UpdateBinding();
        }

        //Ethan Shipley
        // Deletes the products suppliers to the package
        private void btnDeletePkgProdSup_Click_Click(object sender, EventArgs e)
        {
            //string useranswer = Interaction.InputBox("My msg", "title", "default response");
            if (!deleteConfirm())
            {
                return;
            }
            PackageProductSuppliersDB.DeleteProductSupplierIdPpkg(pkgid, getSelectedCellValue(gvProdSup_pkg, 1));
            slct_colmn = gvPackages.CurrentCell.RowIndex;
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            gvPackages.CurrentCell = gvPackages[3, slct_colmn];

            UpdateBinding();
        }

        //Ethan Shipley
        // Gets the cells value from selected cell based on required column
        private int getSelectedCellValue(DataGridView dataGridView, int column)
        {
            int rw = dataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView.Rows[rw];
            return Convert.ToInt32(selectedRow.Cells[column].Value);
        }

        private bool deleteConfirm()
        {
            var confirm = MessageBox.Show("Do you want to delete the package?", "Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                confirm = MessageBox.Show("Do you really want to delete the package?", "Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

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
using System.Data.SqlClient;

namespace TravelExpertsServices
{
    // Ethan Shipley
    // Ethans test 
    //of code added
    public partial class Form1 : Form
    {
        // create constants
        const int PKG_NAME_LENGTH = 50;
        const int PKG_DESC_LENGTH = 50;
        const double PRICE_MAX = 922337203685477.5807;
        // variables
        int pkgid;
        int slct_colmn = -1;
        // display products & suppliers
        List<Products> Prod = null;
        List<Products> selectProducts;
        List<Supplier> Sup = null;
        List<Supplier> selectSuppliers;
        List<PackageProductSuppliers> ppss = new List<PackageProductSuppliers>();
        List<ProdSuppliersNames> psn = new List<ProdSuppliersNames>();
        List<Packages> PackagesList;

        List<Products> Prodd = ProductDB.GetProducts();
        List<Supplier> Supp = SupplierDB.GetSuppliers();
        public Form1()
        {
            InitializeComponent();
        }

        //Ethan Shipley
        // On form load performs these actions
        private void Form1_Load(object sender, EventArgs e)
        {
            PackagesGrid();
            ProductList();
            SupplierList();
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Packages_Products_Suppliers' table. You can move, or remove it, as needed.
            //this.packages_Products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Packages_Products_Suppliers);
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Products_Suppliers' table. You can move, or remove it, as needed.
            //this.products_SuppliersTableAdapter.Fill(this.travelExpertsDataSet.Products_Suppliers);
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Suppliers' table. You can move, or remove it, as needed.
            //this.suppliersTableAdapter.Fill(this.travelExpertsDataSet.Suppliers);
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            //// TODO: This line of code loads data into the 'travelExpertsDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            //this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);

            //THIS TO BE UNCOMMENTED AFTER TESTING

            //dtpPkgStartDate.MinDate = DateTime.Now;
            //dtpPkgEndDate.MinDate = DateTime.Now;


            gvProducts.Columns[0].Visible = false;
            gvSuppliers.Columns[0].Visible = false;
            btnSaveP.Visible = false;
            btnSaveS.Visible = false;

            gvProdBySup.Visible = false;
            gvSupByProd.Visible = false;

            btnAddSP.Visible = false;
            btnDelSP.Visible = false;
            btnAddPS.Visible = false;
            btnDelPS.Visible = false;

            //DataGridViewSettings();
        }

        //Ethan Shipley January 28 2019
        //Sets the data source and formatting for the packages datagridview
        private void PackagesGrid()
        {
            PackagesList = PackagesDB.GetPackages();
            gvPackages.DataSource = PackagesList;
            gvPackages.Columns[0].Visible = false;
            gvPackages.Columns[1].HeaderText = "Package Name";
            gvPackages.Columns[2].HeaderText = "Package Start Date";
            gvPackages.Columns[3].HeaderText = "Package End Date";
            gvPackages.Columns[4].HeaderText = "Package Description";
            gvPackages.Columns[5].HeaderText = "Package Base Price";
            gvPackages.Columns[5].DefaultCellStyle.Format = "C";
            gvPackages.Columns[6].HeaderText = "Package Agency Commision";
            gvPackages.Columns[6].DefaultCellStyle.Format = "C";
            gvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvPackages.Rows[0].Selected = true;
            gvPackages.CurrentCell = gvPackages[1, 0];

        }

        //Ethan SHipley January 28 2019
        //sets the datasource and formatting for the products datagridview
        private void ProductsGrid()
        {
            gvProducts.DataSource = ppss;
            gvProducts.Columns[0].Visible = false;
            gvProducts.Columns[1].Visible = false;
            gvProducts.Columns[2].HeaderText = "Product ID";
            gvProducts.Columns[3].Visible = false;
            gvProducts.Columns[4].Visible = false;
            gvProducts.Columns[5].HeaderText = "Product Name";
            gvProducts.Columns[6].Visible = false;
            gvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //Ethan SHipley January 28 2019
        //sets the datasource and formatting for the products datagridview
        private void SuppliersGrid()
        {
            gvSuppliers.DataSource = ppss;
            gvSuppliers.Columns[0].Visible = false;
            gvSuppliers.Columns[1].Visible = false;
            gvSuppliers.Columns[2].Visible = false;
            gvSuppliers.Columns[3].HeaderText = "Supplier ID";
            gvSuppliers.Columns[4].Visible = false;
            gvSuppliers.Columns[5].Visible = false;
            gvSuppliers.Columns[6].HeaderText = "Supplier Name";
            gvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Mike added this on Jan 28 2019
        //private void DataGridViewSettings()
        //{
        //    //AutoFill(gvPackages);
        //    //AutoFill(gvProducts);
        //    //AutoFill(gvSuppliers);

        //    //gvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    //gvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    //gvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    //gvPackages.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;


        //    List<string> list = new List<string>();

        //    list.Add("First");
        //    list.Add("Second");
        //    list.Add("Thrid");

        //    DGVtest.DataSource = list;
        //    DGVtest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    DGVtest.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
        //}

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

            gvProdSup_pkg.DataSource = "";
            gvProdSup_all_pkgs.DataSource = "";

            hideunhide(false);
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
            UpdateBinding(true);
            PackagesListDetails(gvProdSup_pkg);
            //getSelectedProduct();
            //supplierComboBoxMatch();
            //cmbProdName.Enabled = false;
            //cmbSupName.Enabled = false;
            hideunhide(false);
        }

        // Ethan Shipley
        // Updates the datasource for grid views. if input is true then there is already an existing selected row
        // if false then new row is what is wanted to be selected
        private void UpdateBinding(bool crnt_cell)
        {
            //
            PackagesList = PackagesDB.GetPackages();
            if (crnt_cell)
            {
                slct_colmn = gvPackages.CurrentCell.RowIndex;
                //this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
                PackagesGrid();
                gvPackages.CurrentCell = gvPackages[3, slct_colmn];
            }
            else
            {
                int indx = gvPackages.Rows.Count + 0;
                PackagesGrid();
                gvPackages.Rows[indx].Selected = true;
                gvPackages.CurrentCell = gvPackages[1, indx];
                //MessageBox.Show(gvPackages.CurrentCell.Value.ToString());
            }
            gvProdSup_pkg.DataSource = ppss;
            gvProdSup_all_pkgs.DataSource = psn;

            gvProducts1.DataSource = Prodd;
            gvSuppliers2.DataSource = Supp;

            PackagesListDetails(gvProdSup_pkg);
        }

        //Ethan Shipley
        // Formats the ppackages prod and supplier details
        private static void PackagesListDetails(DataGridView dataGridView)
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[3].Visible = false;
            dataGridView.Columns[4].Visible = false;
            dataGridView.Columns[5].HeaderText = "Product Name";
            dataGridView.Columns[6].HeaderText = "Supplier Name";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            decimal PkgBasePrice;
            decimal PkgAgencyCommission;
            try
            {
                PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text.ToString().Replace("$", "").Replace(",", ""));
                if (PkgBasePrice <= 0)
                {
                    MessageBox.Show("Please enter a number for base price greater than zero.");
                    txtPkgBasePrice.Text = "";
                    return;
                }
                if ((double)PkgBasePrice > PRICE_MAX)
                {
                    MessageBox.Show("Please enter a number for base price less than 922,337,203,685,477.5807.");
                    txtPkgBasePrice.Text = "";
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number for base price.");
                txtPkgBasePrice.Text = "";
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a number for base price below 7.9228 x 102^8.");
                txtPkgBasePrice.Text = "";
                return;
            }
            pack.PkgBasePrice = PkgBasePrice;
            try
            {
                PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text.ToString().Replace("$", "").Replace(",", ""));
                if (PkgAgencyCommission <= 0)
                {
                    MessageBox.Show("Please enter a number for agency commision greater than zero.");
                    txtPkgAgencyCommission.Text = "";
                    return;
                }
                if ((double)PkgAgencyCommission > PRICE_MAX)
                {
                    MessageBox.Show("Please enter a number for agency commision less than 922,337,203,685,477.5807.");
                    txtPkgAgencyCommission.Text = "";
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number for agency commision.");
                txtPkgAgencyCommission.Text = "";
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please enter a number for agency commision below 7.9228 x 102^8.");
                txtPkgAgencyCommission.Text = "";
                return;
            }
            pack.PkgAgencyCommission = PkgAgencyCommission;


            // Checks the text of the Add/edit package button in order to perform various logic
            if (btnAddEditPkg.Text == "Save New Package")
            {
                //Inserts the package into the database and then refreshes the mainpage
                PackagesDB.InsertPackages(pack);
                UpdateBinding(false);
                btnAddEditPkg.Text = "Save Edited Package";
            }
            else if (btnAddEditPkg.Text == "Save Edited Package")
            {
                // updates the package and then refreshes the main page
                PackagesDB.UpdatePackages(pack, pkgid);
                UpdateBinding(true);
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
            PackagesGrid();
            //PackagesDB.DeletePackage(pkgid);
            //this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            //hideunhide(false);
            //this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);            
        }

        //Ethan Shipley
        // Code for the navigator save item button on click event
        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }


        // Sheila Zhao
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
                ProductsGrid();
                SuppliersGrid();
                //gvProducts.DataSource = ppss;
                //gvSuppliers.DataSource = ppss;
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

        // Ethan Shipley
        // Gets the selected data to fill in the combo box
        // Gets the supplier from products data to fill in the supplier combo box
        //private void getSelectedProduct()
        //{
        //    Products selectedProduct = null;
        //    try
        //    {
        //        foreach (DataGridViewRow row in gvProducts_pkgs.SelectedRows)
        //        {
        //            selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
        //                                           row.Cells[1].Value.ToString());

        //        }

        //        Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
        //        cmbSupName.DataSource = Sup;
        //        supplierComboBoxMatch();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, ex.GetType().ToString());
        //    }
        //}

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
            if (start < now && !DateTime.Now.ToShortDateString().Equals(dtpPkgStartDate.Value.ToShortDateString()))
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
        // Dsiplays the list of available product suppliers
        private void btnUpdatePkgProdSup_Click(object sender, EventArgs e)
        {
            psn = ProdSuppliersNamesDB.GetProdSupAll(ppss);
            gvProdSup_all_pkgs.DataSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(true);
            //ProdSupListDetails(gvProdSup_all_pkgs);
            gvProdSup_all_pkgs.Visible = true;
        }

        //Ethan Shipley
        // Hides and unhides prod suppplier gridview and button
        private void hideunhide(bool hd)
        {
            if (hd)
            {
                btnAddPkgProdSup.Visible = true;
                gvProdSup_all_pkgs.Visible = true;
            }
            else
            {
                btnAddPkgProdSup.Visible = false;
                gvProdSup_all_pkgs.Visible = false;
            }
        }

        //Ethan Shipley
        // Formats the prod and supplier details
        private void ProdSupListDetails(DataGridView dataGridView)
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
            UpdateBinding(true);

            //duplicate code
            psn = ProdSuppliersNamesDB.GetProdSupAll(ppss);
            gvProdSup_all_pkgs.DataSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(true);
            gvProdSup_all_pkgs.DataSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(true);
            //slct_colmn = gvPackages.CurrentCell.RowIndex; 
            //this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            //gvPackages.CurrentCell = gvPackages[3, slct_colmn];
            //UpdateBinding(true);
        }

        //Ethan Shipley
        // Deletes the products suppliers to the package
        private void btnDeletePkgProdSup_Click_Click(object sender, EventArgs e)
        {
            //string useranswer = Interaction.InputBox("My msg", "title", "default response");
            if (slct_colmn == -1)
            {
                MessageBox.Show("Cannot delete product. Please add a package or edit an existing package.");
                return;
            }
            if (!deleteConfirm())
            {
                return;
            }
            PackageProductSuppliersDB.DeleteProductSupplierIdPpkg(pkgid, getSelectedCellValue(gvProdSup_pkg, 1));
            slct_colmn = gvPackages.CurrentCell.RowIndex;
            gvPackages.CurrentCell = gvPackages[1, slct_colmn];

            UpdateBinding(true);

            //duplicate code
            psn = ProdSuppliersNamesDB.GetProdSupAll(ppss);
            gvProdSup_all_pkgs.DataSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(false);
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

        /*=======================================================================================================================*/
        /*=======================================================================================================================*/
        /*===================================================PRODUCT=============================================================*/
        /*=======================================================================================================================*/
        /*=======================================================================================================================*/


        private void ProductList()
        {
            gvProducts1.DataSource = Prodd;
            gvProducts1.Columns[0].HeaderText = "ID";
            gvProducts1.Columns[1].HeaderText = "Product Name";
            gvProducts1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Sheila Zhao
        private void GetProduct(int productID)
        {
            Prod = ProductDB.GetProducts();
            selectProducts = (from Pd in Prod
                              where Pd.ProductId == productID
                              select Pd).ToList();

            gvProducts1.DataSource = selectProducts;

        }

        // Sheila Zhao
        private void grProducts1_SelectionChanged(object sender, EventArgs e)
        {
            Products selectedProduct = null;

            try
            {
                foreach (DataGridViewRow row in gvProducts1.SelectedRows)
                {
                    selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                   row.Cells[1].Value.ToString());
                }

                Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                gvSuppliers1.DataSource = Sup;
                if (selectedProduct != null)
                {
                    Sup = SupplierDB.GetProSupNotInList(selectedProduct);
                    gvSupByProd.DataSource = Sup;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        // Sheila Zhao
        private void btnAddNewProd_Click(object sender, EventArgs e)
        {
            //np = Convert.ToString(txtProdName.Text);
            Products np = new Products();
            //int selectedindex;
            btnSaveP.Visible = false;

            try
            {
                if (np != null)
                {
                    np.ProdName = txtProdName.Text;
                    ProductDB.InsertProduct(np);
                    Prodd = ProductDB.GetProducts();
                    UpdateBinding(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            txtProdName.Text = "";
            //selectedindex = gvProducts1.CurrentCell.RowIndex;
            //this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            //gvProducts1.CurrentCell = gvProducts1[1, selectedindex];

            if (gvProducts1.Rows.Count > 0)
            {
                gvProducts1.ClearSelection();

                int nRowIndex = gvProducts1.Rows.Count - 1;
                //int nColumnIndex = 0;

                gvProducts1.Rows[nRowIndex].Selected = true;
                //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                //In case if you want to scroll down as well.
                gvProducts1.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
        }

        // Sheila Zhao
        private void btnEditP_Click(object sender, EventArgs e)
        {
            Products oldp = null;
            btnSaveP.Visible = true;
            foreach (DataGridViewRow row in gvProducts1.SelectedRows)
            {
                oldp = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                    row.Cells[1].Value.ToString());
            }
            txtProdName.Text = oldp.ProdName;
            txtProdName.Focus();

        }

        // Sheila Zhao
        private Products GetEditProduct(Products oldp)
        {
            Products newp = new Products();
            foreach (DataGridViewRow row in gvProducts1.SelectedRows)
            {
                oldp = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                    row.Cells[1].Value.ToString());
            }
            newp.ProdName = oldp.ProdName;
            newp.ProductId = oldp.ProductId;
            return newp;
        }

        // Sheila Zhao
        private void btnSaveP_Click(object sender, EventArgs e)
        {
            Products newp = new Products();
            Products oldp = null;
            foreach (DataGridViewRow row in gvProducts1.SelectedRows)
            {
                oldp = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                    row.Cells[1].Value.ToString());
            }
            newp = GetEditProduct(oldp);
            try
            {
                newp.ProdName = txtProdName.Text;
                ProductDB.UpdateProduct(newp, oldp);
                Prod = ProductDB.GetProducts();
                UpdateBinding(true);
                MessageBox.Show("Product Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            btnSaveP.Visible = false;
            txtProdName.Text = "";
        }

        // Sheila Zhao
        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnSaveP.Visible = false;
            try
            {
                Products delProd = null;
                foreach (DataGridViewRow row in gvProducts1.SelectedRows)
                {
                    delProd = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                        row.Cells[1].Value.ToString());
                    txtProdName.Text = delProd.ProdName;
                }
                if (!deleteConfirm())
                {
                    return;
                }
                ProductDB.DeleteProduct(delProd);
                txtProdName.Text = "";
                Prod = ProductDB.GetProducts();
                UpdateBinding(true);

                int nRowIndex = gvProducts1.Rows.Count - 1;
                gvProducts1.ClearSelection();
                gvProducts1.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Sheila Zhao
        private void btnShowPS_Click(object sender, EventArgs e)
        {
            if (btnShowPS.Text == "Show")
            {
                gvSupByProd.Visible = true;
                btnDelPS.Visible = true;
                btnAddPS.Visible = true;

                btnShowPS.Text = "Hide";
            }
            else if (btnShowPS.Text == "Hide")
            {
                gvSupByProd.Visible = false;
                btnDelPS.Visible = false;
                btnAddPS.Visible = false;
                btnShowPS.Text = "Show";
            }
        }
        private void btnClearP_Click(object sender, EventArgs e)
        {
            txtProdName.Text = "";
            btnDelSP.Visible = false;
            btnAddSP.Visible = false;
            btnSaveP.Visible = false;
            gvSupByProd.Visible = false;
            btnShowPS.Text = "Show";
            UpdateBinding(true);
        }

        private void btnAddPS_Click(object sender, EventArgs e)
        {
            int ProdSupID, SupID, ProdID;
            int Success = 0;
            Products selectedProduct = null;

            if (gvProducts1.SelectedCells.Count > 0 && gvSupByProd.SelectedCells.Count > 0
                && gvSuppliers1.SelectedCells.Count > 0)
            {
                ProdID = Convert.ToInt32(gvProducts1.SelectedCells[0].Value);
                SupID = Convert.ToInt32(gvSupByProd.SelectedCells[0].Value);
                ProdSupID = Convert.ToInt32(gvSuppliers1.SelectedCells[0].Value);

                try
                {
                    // Make new object
                    ProdSuppliers addNew = new ProdSuppliers();

                    addNew.ProdId = ProdID;
                    addNew.SupplierId = SupID;

                    // Now sql query to add

                    Success = ProdSupplierDB.InsertProdSupplier(addNew);

                    if (Success == 1)
                    {

                        // Refresh gridview
                        try
                        {
                            foreach (DataGridViewRow row in gvProducts1.SelectedRows)
                            {
                                selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                               row.Cells[1].Value.ToString());
                            }

                            // Fix me
                            Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                            gvSuppliers1.DataSource = Sup;
                            if (selectedProduct != null)
                            {
                                Sup = SupplierDB.GetProSupNotInList(selectedProduct);
                                gvSupByProd.DataSource = Sup;
                            }
                            MessageBox.Show("Supplier Added Successfully!");

                            if (gvSuppliers1.Rows.Count > 0)
                            {
                                gvSuppliers1.ClearSelection();

                                int RowIndex = gvSuppliers1.Rows.Count - 1;
                                //    //int nColumnIndex = 0;

                                gvSuppliers1.Rows[RowIndex].Selected = true;
                                //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                                //    //In case if you want to scroll down as well.
                                gvSuppliers1.FirstDisplayedScrollingRowIndex = RowIndex;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else if (gvSuppliers1.SelectedCells.Count == 0)
            {
                ProdID = Convert.ToInt32(gvProducts1.SelectedCells[0].Value);
                SupID = Convert.ToInt32(gvSupByProd.SelectedCells[0].Value);
                //ProdSupID = Convert.ToInt32(gvSuppliers1.SelectedCells[0].Value);

                try
                {
                    // Make new object
                    ProdSuppliers addNew = new ProdSuppliers();

                    addNew.ProdId = ProdID;
                    addNew.SupplierId = SupID;

                    // Now sql query to add

                    Success = ProdSupplierDB.InsertProdSupplier(addNew);

                    if (Success == 1)
                    {

                        // Refresh gridview
                        try
                        {
                            foreach (DataGridViewRow row in gvProducts1.SelectedRows)
                            {
                                selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                               row.Cells[1].Value.ToString());
                            }

                            // Fix me
                            Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                            gvSuppliers1.DataSource = Sup;
                            if (selectedProduct != null)
                            {
                                Sup = SupplierDB.GetProSupNotInList(selectedProduct);
                                gvSupByProd.DataSource = Sup;
                            }
                            MessageBox.Show("Supplier Added Successfully!");

                            if (gvSuppliers1.Rows.Count > 0)
                            {
                                gvSuppliers1.ClearSelection();

                                int RowIndex = gvSuppliers1.Rows.Count - 1;
                                //    //int nColumnIndex = 0;

                                gvSuppliers1.Rows[RowIndex].Selected = true;
                                //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                                //    //In case if you want to scroll down as well.
                                gvSuppliers1.FirstDisplayedScrollingRowIndex = RowIndex;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnDelPS_Click(object sender, EventArgs e)
        {
            int ProdSupID, SupID, ProdID;
            int Success = 0;
            Products selectedProduct = null;

            if (gvProducts1.SelectedCells.Count > 0 && gvSupByProd.SelectedCells.Count > 0
                && gvSuppliers1.SelectedCells.Count > 0)
            {
                ProdID = Convert.ToInt32(gvProducts1.SelectedCells[0].Value);
                SupID = Convert.ToInt32(gvSupByProd.SelectedCells[0].Value);
                ProdSupID = Convert.ToInt32(gvSuppliers1.SelectedCells[0].Value);

                try
                {

                    ProdSuppliers del = new ProdSuppliers();

                    del.ProdId = ProdID;
                    del.SupplierId = ProdSupID;
                    //del.ProductSupplierId = ProdSupID;

                    // Now sql query to add

                    Success = ProdSupplierDB.DeleteProdSupplier(del);

                    if (Success == 1)
                    {

                        // Refresh gridview
                        try
                        {
                            foreach (DataGridViewRow row in gvProducts1.SelectedRows)
                            {
                                selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                               row.Cells[1].Value.ToString());
                            }

                            // Fix me
                            Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                            gvSuppliers1.DataSource = Sup;
                            if (selectedProduct != null)
                            {
                                Sup = SupplierDB.GetProSupNotInList(selectedProduct);
                                gvSupByProd.DataSource = Sup;
                            }
                            MessageBox.Show("Supplier Deleted Successfully!");

                            if (gvSupByProd.Rows.Count > 0)
                            {
                                gvSupByProd.ClearSelection();

                                int RowIndex = gvSupByProd.Rows.Count - 1;
                                //    //int nColumnIndex = 0;

                                gvSupByProd.Rows[RowIndex].Selected = true;
                                //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                                //    //In case if you want to scroll down as well.
                                gvSupByProd.FirstDisplayedScrollingRowIndex = RowIndex;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        /*=======================================================================================================================*/
        /*=======================================================================================================================*/
        /*===================================================SUPPLIER============================================================*/
        /*=======================================================================================================================*/
        /*=======================================================================================================================*/



        // Sheila Zhao
        private void GetSupplier(int supplierID)
        {
            Sup = SupplierDB.GetSuppliers();
            selectSuppliers = (from Sp in Sup
                               where Sp.SupplierId == supplierID
                               select Sp).ToList();

            gvSuppliers2.DataSource = selectSuppliers;
        }

        private void SupplierList()
        {
            gvSuppliers2.DataSource = Supp;
            gvSuppliers2.Columns[0].HeaderText = "ID";
            gvSuppliers2.Columns[1].HeaderText = "Supplier Name";
            gvSuppliers2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Sheila Zhao
        private void gvSuppliers2_SelectionChanged(object sender, EventArgs e)
        {
            Supplier selectedSupplier = null;
            try
            {
                foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
                {
                    selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                   row.Cells[1].Value.ToString());
                }

                Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
                gvProducts2.DataSource = Prod;

                if (selectedSupplier != null)
                {
                    Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
                    gvProdBySup.DataSource = Prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        // Sheila Zhao
        private void btnNewS_Click(object sender, EventArgs e)
        {
            Supplier ns = new Supplier();
            //int selectedindex;
            btnSaveS.Visible = false;

            try
            {
                if (ns != null)
                {
                    ns.SupName = txtSupName.Text;
                    SupplierDB.InsertSupplier(ns);
                    Supp = SupplierDB.GetSuppliers();
                    UpdateBinding(true);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            txtSupName.Text = "";
            //selectedindex = gvProducts1.CurrentCell.RowIndex;
            //this.productsTableAdapter.Fill(this.travelExpertsDataSet.Products);
            //gvProducts1.CurrentCell = gvProducts1[1, selectedindex];

            if (gvSuppliers2.Rows.Count > 0)
            {
                gvSuppliers2.ClearSelection();

                int RowIndex = gvSuppliers2.Rows.Count - 1;
                //    //int nColumnIndex = 0;

                gvSuppliers2.Rows[RowIndex].Selected = true;
                //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                //    //In case if you want to scroll down as well.
                gvSuppliers2.FirstDisplayedScrollingRowIndex = RowIndex;

            }
        }
        // Sheila Zhao
        private void btnEditS_Click(object sender, EventArgs e)
        {
            Supplier olds = null;
            btnSaveS.Visible = true;
            foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
            {
                olds = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                    row.Cells[1].Value.ToString());
            }
            txtSupName.Text = olds.SupName;
            txtSupName.Focus();
        }

        // Sheila Zhao
        private Supplier GetEditSupplier(Supplier olds)
        {
            Supplier news = new Supplier();
            foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
            {
                olds = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                    row.Cells[1].Value.ToString());
            }
            news.SupName = olds.SupName;
            news.SupplierId = olds.SupplierId;
            return news;
        }

        // Sheila Zhao
        private void btnSaveS_Click(object sender, EventArgs e)
        {
            Supplier news = new Supplier();
            Supplier olds = null;
            foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
            {
                olds = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                    row.Cells[1].Value.ToString());
            }
            news = GetEditSupplier(olds);
            try
            {
                news.SupName = txtSupName.Text;
                SupplierDB.UpdateSupplier(news, olds);
                Sup = SupplierDB.GetSuppliers();
                UpdateBinding(true);
                MessageBox.Show("Supplier Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            btnSaveS.Visible = false;
            txtSupName.Text = "";
        }

        // Sheila Zhao
        private void btnDelSup_Click(object sender, EventArgs e)
        {
            btnSaveS.Visible = false;
            try
            {
                Supplier delSup = null;
                foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
                {
                    delSup = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                        row.Cells[1].Value.ToString());
                    txtSupName.Text = delSup.SupName;
                }
                if (!deleteConfirm())
                {
                    return;
                }
                SupplierDB.DeleteSupplier(delSup);
                txtSupName.Text = "";
                Sup = SupplierDB.GetSuppliers();
                UpdateBinding(true);

                int nRowIndex = gvSuppliers2.Rows.Count - 1;
                gvSuppliers2.ClearSelection();
                gvSuppliers2.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        // Sheila Zhao
        private void btnShowSP_Click(object sender, EventArgs e)
        {
            if (btnShowSP.Text == "Show")
            {
                gvProdBySup.Visible = true;
                btnDelSP.Visible = true;
                btnAddSP.Visible = true;
                btnShowSP.Text = "Hide";
            }
            else if (btnShowSP.Text == "Hide")
            {
                gvProdBySup.Visible = false;
                btnDelSP.Visible = true;
                btnAddSP.Visible = true;
                btnShowSP.Text = "Show";
            }
        }




        private void btnAddSP_Click(object sender, EventArgs e)
        {
            int ProdSupID, SupID, ProdID;
            int Success = 0;
            Supplier selectedSupplier = null;

            if (gvProducts2.SelectedCells.Count > 0 && gvProdBySup.SelectedCells.Count > 0
                && gvSuppliers2.SelectedCells.Count > 0)
            {
                ProdID = Convert.ToInt32(gvProducts2.SelectedCells[0].Value);
                SupID = Convert.ToInt32(gvSuppliers2.SelectedCells[0].Value);
                ProdSupID = Convert.ToInt32(gvProdBySup.SelectedCells[0].Value);

                try
                {
                    // Make new object
                    ProdSuppliers addNew = new ProdSuppliers();

                    addNew.ProdId = ProdSupID;
                    addNew.SupplierId = SupID;

                    // Now sql query to add

                    Success = ProdSupplierDB.InsertSupProduct(addNew);

                    if (Success == 1)
                    {

                        // Refresh gridview
                        try
                        {
                            foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
                            {
                                selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                               row.Cells[1].Value.ToString());
                            }

                            // Fix me
                            Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
                            gvProducts2.DataSource = Prod;
                            if (selectedSupplier != null)
                            {
                                Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
                                gvProdBySup.DataSource = Prod;
                            }
                            MessageBox.Show("Product Added Successfully!");

                            if (gvProducts2.Rows.Count > 0)
                            {
                                gvProducts2.ClearSelection();

                                int RowIndex = gvProducts2.Rows.Count - 1;
                                //    //int nColumnIndex = 0;

                                gvProducts2.Rows[RowIndex].Selected = true;
                                //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                                //    //In case if you want to scroll down as well.
                                gvProducts2.FirstDisplayedScrollingRowIndex = RowIndex;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
            else if (gvProducts2.SelectedCells.Count == 0)
            {
                //ProdID = Convert.ToInt32(gvProducts2.SelectedCells[0].Value);
                SupID = Convert.ToInt32(gvSuppliers2.SelectedCells[0].Value);
                ProdSupID = Convert.ToInt32(gvProdBySup.SelectedCells[0].Value);

                try
                {
                    // Make new object
                    ProdSuppliers addNew = new ProdSuppliers();

                    addNew.ProdId = ProdSupID;
                    addNew.SupplierId = SupID;

                    // Now sql query to add

                    Success = ProdSupplierDB.InsertSupProduct(addNew);

                    if (Success == 1)
                    {

                        // Refresh gridview
                        try
                        {
                            foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
                            {
                                selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                               row.Cells[1].Value.ToString());
                            }

                            // Fix me
                            Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
                            gvProducts2.DataSource = Prod;
                            if (selectedSupplier != null)
                            {
                                Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
                                gvProdBySup.DataSource = Prod;
                            }
                            MessageBox.Show("Product Added Successfully!");

                            if (gvProducts2.Rows.Count > 0)
                            {
                                gvProducts2.ClearSelection();

                                int RowIndex = gvProducts2.Rows.Count - 1;
                                //    //int nColumnIndex = 0;

                                gvProducts2.Rows[RowIndex].Selected = true;
                                //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                                //    //In case if you want to scroll down as well.
                                gvProducts2.FirstDisplayedScrollingRowIndex = RowIndex;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void btnDelSP_Click(object sender, EventArgs e)
        {
            int ProdSupID, SupID, ProdID;
            int Success = 0;
            Supplier selectedSupplier = null;

            if (gvProducts2.SelectedCells.Count > 0 && gvProdBySup.SelectedCells.Count > 0
                && gvSuppliers2.SelectedCells.Count > 0)
            {
                ProdID = Convert.ToInt32(gvProducts2.SelectedCells[0].Value);
                SupID = Convert.ToInt32(gvSuppliers2.SelectedCells[0].Value);
                ProdSupID = Convert.ToInt32(gvProdBySup.SelectedCells[0].Value);

                try
                {
                    // Make new object
                    ProdSuppliers del = new ProdSuppliers();

                    del.ProdId = ProdID;
                    del.SupplierId = SupID;

                    // Now sql query to add

                    Success = ProdSupplierDB.DeleteSupProduct(del);

                    if (Success == 1)
                    {

                        // Refresh gridview
                        try
                        {
                            foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
                            {
                                selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                                                               row.Cells[1].Value.ToString());
                            }

                            // Fix me
                            Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
                            gvProducts2.DataSource = Prod;
                            if (selectedSupplier != null)
                            {
                                Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
                                gvProdBySup.DataSource = Prod;
                            }
                            MessageBox.Show("Product Deleted Successfully!");

                            if (gvProdBySup.Rows.Count > 0)
                            {
                                gvProdBySup.ClearSelection();

                                int RowIndex = gvProdBySup.Rows.Count - 1;
                                //    //int nColumnIndex = 0;

                                gvProdBySup.Rows[RowIndex].Selected = true;
                                //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                                //    //In case if you want to scroll down as well.
                                gvProdBySup.FirstDisplayedScrollingRowIndex = RowIndex;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.GetType().ToString());
                        }

                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Product deleted Failed, Go Home");
                }
            }
        }

        private void btnClearS_Click(object sender, EventArgs e)
        {
            txtSupName.Text = "";
            btnDelPS.Visible = false;
            btnAddPS.Visible = false;
            gvProdBySup.Visible = false;
            btnSaveS.Visible = false;
            btnShowSP.Text = "Show";
            UpdateBinding(true);
        }

        // =======================================================================================//

    }
}

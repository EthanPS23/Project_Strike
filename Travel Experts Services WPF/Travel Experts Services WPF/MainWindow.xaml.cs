using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using TravelExpertsDB;


namespace Travel_Experts_Services_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create constants
        const int PKG_NAME_LENGTH = 50;
        const int PKG_DESC_LENGTH = 50;
        const double PRICE_MAX = 922337203685477.5807;
        // variables
        int pkgid;
        int check = -1;
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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GvPackages_Loaded(object sender, RoutedEventArgs e)
        {
            check = 1;

        }

        //Ethan Shipley
        // On form load performs these actions
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PackagesGrid();
            ProductList();
            SupplierList();

            //gvProducts.Columns[0].Visibility = Visibility.Hidden;
            //gvSuppliers.Columns[0].Visibility = Visibility.Hidden;
            btnSaveP.Visibility = Visibility.Hidden;
            btnSaveS.Visibility = Visibility.Hidden;

            gvProdBySup.Visibility = Visibility.Hidden;
            gvSupByProd.Visibility = Visibility.Hidden;

            btnAddSP.Visibility = Visibility.Hidden;
            btnDelSP.Visibility = Visibility.Hidden;
            btnAddPS.Visibility = Visibility.Hidden;
            btnDelPS.Visibility = Visibility.Hidden;
            gvProdSup_pkg.ItemsSource = "";
            gvProdSup_pkg.ItemsSource = ppss;
            tabControl1.TabIndex = 7;
            gvProdSup_all_pkgs.Visibility = Visibility.Hidden;
            btnAddPkgProdSup.Visibility = Visibility.Hidden;
            //gvPackages.SelectedItem = 0;
            //tabControl1.SelectedIndex = 1;
            //tabControl1.SelectedIndex = 0;
        }

        //Ethan Shipley January 28 2019
        //Sets the data source and formatting for the packages datagridview
        private void PackagesGrid()
        {
            //if (check==1)
            //{

            //}
            PackagesList = PackagesDB.GetPackages();
            gvPackages.ItemsSource = PackagesList;
            //gvPackages.Columns[0].Visibility = Visibility.Hidden;
            ////gvPackages.Columns[1].Header = "Package Name";
            ////gvPackages.Columns[2].Header = "Package Start Date";
            ////gvPackages.Columns[3].Header = "Package End Date";
            ////gvPackages.Columns[4].Header = "Package Description";
            ////gvPackages.Columns[5].Header = "Package Base Price";
            ////gvPackages.Columns[5].DefaultCellStyle.Format = "C";
            //gvPackages.Columns[6].Header = "Package Agency Commision";
            ////gvPackages.Columns[6].DefaultCellStyle.Format = "C";
            //gvPackages.CurrentItem = gvPackages.Items[0];
            //gvPackages.SelectedIndex = 1;
            gvPackages.Focus();
            //gvPackages.CurrentCell = gvPackages[1, 0];

        }

        //Ethan SHipley January 28 2019
        //sets the datasource and formatting for the products datagridview
        private void ProductsGrid()
        {
            gvProducts.ItemsSource = ppss;
            //gvProducts.Columns[0].Visibility = Visibility.Hidden;
            //gvProducts.Columns[1].Visibility = Visibility.Hidden;
            //gvProducts.Columns[2].Header = "Product ID";
            //gvProducts.Columns[3].Visibility = Visibility.Hidden;
            //gvProducts.Columns[4].Visibility = Visibility.Hidden;
            //gvProducts.Columns[5].Header = "Product Name";
            //gvProducts.Columns[6].Visibility = Visibility.Hidden;
        }

        //Ethan SHipley January 28 2019
        //sets the datasource and formatting for the products datagridview
        private void SuppliersGrid()
        {
            gvSuppliers.ItemsSource = ppss;
            //gvSuppliers.Columns[0].Visibility = Visibility.Hidden;
            //gvSuppliers.Columns[1].Visibility = Visibility.Hidden;
            //gvSuppliers.Columns[2].Visibility = Visibility.Hidden;
            //gvSuppliers.Columns[3].Header = "Supplier ID";
            //gvSuppliers.Columns[4].Visibility = Visibility.Hidden;
            //gvSuppliers.Columns[5].Visibility = Visibility.Hidden;
            //gvSuppliers.Columns[6].Header = "Supplier Name";
        }



        //Ethan Shipley
        // Hides and unhides prod suppplier gridview and button
        private void hideunhide(bool hd)
        {
            if (hd)
            {
                btnAddPkgProdSup.Visibility = Visibility.Visible;
                gvProdSup_all_pkgs.Visibility = Visibility.Visible;
            }
            else
            {
                btnAddPkgProdSup.Visibility = Visibility.Hidden;
                gvProdSup_all_pkgs.Visibility = Visibility.Hidden;
            }
        }

        // Ethan Shipley
        // Sets the text boxes and user inputs on the packages tab to be cleared
        private void BtnAddPkg_Click(object sender, RoutedEventArgs e)
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 2;
            PackagesReset();
        }

        //Ethan Shipley
        // Resets the data fields on the packages page
        public void PackagesReset()
        {
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            txtPackageName.Text = "";
            dtpPkgStartDate.Text = "";
            dtpPkgEndDate.Text = "";
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgAgencyCommission.Text = "";

            gvProdSup_pkg.ItemsSource = "";
            gvProdSup_all_pkgs.ItemsSource = "";

            hideunhide(false);
            btnAddEditPkg.Content = "Save New Package";
        }

        //Ethan Shipley
        // Gets the cells value from selected cell based on required column
        private int getSelectedCellValue(DataGrid dataGridView)
        {
            object item = dataGridView.SelectedItem;
            return Convert.ToInt32(item.GetType().GetProperty("PackageID").GetValue(item, null));
        }

        // Ethan Shipley
        // When user selects a package to edit it is then filled out automatically in the packages tab
        private void BtnEditPkg_Click(object sender, EventArgs e)
        {
            if (gvPackages.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a package.");
                return;
            }
            //MessageBox.Show(Convert.ToString(gvPackages.SelectedIndex));
            // changes the text for the add/edit button on the packages pages and changes to the packages page
            tabControl1.SelectedIndex = 2;
            //tabControl1.SelectedIndex = 0;
            //tabControl1.SelectedIndex = 1;
            btnAddEditPkg.Content = "Save Edited Package";

            var Packages = from Pkg in PackagesList
                           where Pkg.PackageID == getSelectedCellValue(gvPackages)
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
            //PackagesListDetails(gvProdSup_pkg);
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
                //slct_colmn = gvPackages.CurrentCell.RowIndex;
                slct_colmn = gvPackages.SelectedIndex;
                //this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
                PackagesGrid();
                //gvPackages.CurrentCell = gvPackages[3, slct_colmn];
                gvPackages.SelectedIndex = slct_colmn;
                gvPackages.Focus();
            }
            else
            {
                int indx = gvPackages.Items.Count + 0;
                PackagesGrid();
                //gvPackages.Rows[indx].Selected = true;
                //gvPackages.CurrentCell = gvPackages[1, indx];
                gvPackages.SelectedIndex = indx;
                gvPackages.Focus();
                slct_colmn = indx;
                //MessageBox.Show(Convert.ToString(gvPackages.SelectedIndex));
                //MessageBox.Show(gvPackages.CurrentCell.Value.ToString());
            }

            gvProdSup_pkg.ItemsSource = ppss;
            gvProdSup_all_pkgs.ItemsSource = psn;

            gvProducts1.ItemsSource = Prodd;
            gvSuppliers2.ItemsSource = Supp;

            PackagesListDetails(gvProdSup_pkg);
            
        }

        //Ethan Shipley
        // Formats the ppackages prod and supplier details
        private void PackagesListDetails(DataGrid dataGridView)
        {
            ////if (dataGridView.Columns.Count > 0)
            ////{
            //dataGridView.Columns[0].Visibility = Visibility.Hidden;
            //dataGridView.Columns[1].Visibility = Visibility.Hidden;
            //dataGridView.Columns[2].Visibility = Visibility.Hidden;
            //dataGridView.Columns[3].Visibility = Visibility.Hidden;
            //dataGridView.Columns[4].Visibility = Visibility.Hidden;
            //dataGridView.Columns[5].Header = "Product Name";
            //dataGridView.Columns[6].Header = "Supplier Name";
            ////}
        }

        //Ethan Shipley
        // Deletes a selected package
        private void BtnDeletepkg_Click(object sender, RoutedEventArgs e)
        {
            if (gvPackages.SelectedIndex==-1)
            {
                MessageBox.Show("Cannot delete package. Please select a package to delete.");
                return;
            }
            if (!deleteConfirm())
            {
                return;
            }
            PackagesDB.DeletePackage(pkgid);
            PackagesGrid();
            PackagesReset();
        }

        //Ethan Shipley
        // Confirms that the user wants to delete
        private bool deleteConfirm()
        {
            var confirm = MessageBox.Show("Do you want to delete the package?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (confirm == MessageBoxResult.Yes)
            {
                confirm = MessageBox.Show("Do you really want to delete the package?", "Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (confirm == MessageBoxResult.Yes)
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

        private void GvPackages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Packages selectedPackage = null;
            try
            {
                object row = gvPackages.SelectedItem;
                //int PackageID = Convert.ToInt32(row.GetType().GetProperty("PackageID").GetValue(row, null));
                //string PkgName = row.GetType().GetProperty("PkgName").GetValue(row, null).ToString();
                //DateTime? PkgStartDate = (DateTime?)(row.GetType().GetProperty("PkgStartDate").GetValue(row, null));
                //DateTime? PkgEndDate = (DateTime?)(row.GetType().GetProperty("PkgEndDate").GetValue(row, null));
                //string PkgDesc = row.GetType().GetProperty("PkgDesc").GetValue(row, null).ToString();
                //decimal PkgBasePrice = Convert.ToDecimal(row.GetType().GetProperty("PkgBasePrice").GetValue(row, null));
                //decimal PkgAgencyCommission = Convert.ToDecimal(row.GetType().GetProperty("PkgAgencyCommission").GetValue(row, null));
                selectedPackage = new Packages(
                        Convert.ToInt32(row.GetType().GetProperty("PackageID").GetValue(row, null)),
                        row.GetType().GetProperty("PkgName").GetValue(row, null).ToString(),
                        (DateTime?)(row.GetType().GetProperty("PkgStartDate").GetValue(row, null)),
                        (DateTime?)(row.GetType().GetProperty("PkgEndDate").GetValue(row, null)),
                        row.GetType().GetProperty("PkgDesc").GetValue(row, null).ToString(),
                        Convert.ToDecimal(row.GetType().GetProperty("PkgBasePrice").GetValue(row, null)),
                        (decimal)(row.GetType().GetProperty("PkgAgencyCommission").GetValue(row, null)));
                ppss = PackageProductSuppliersDB.GetProductSuppliersByPackage(selectedPackage);
                pkgid = selectedPackage.PackageID;
                ProductsGrid();
                SuppliersGrid();
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

        /*=======================================================================================================================*/
        /*=======================================================================================================================*/
        /*===================================================PACKAGES============================================================*/
        /*=======================================================================================================================*/
        /*=======================================================================================================================*/

        // Ethan Shipley
        // creates or edits a package based and verifies the correct input of data
        private void BtnAddEditPkg_Click(object sender, RoutedEventArgs e)
        {
            // declare variables
            Packages pack = new Packages();
            DateTime? strt = dtpPkgStartDate.SelectedDate;
            DateTime? end = dtpPkgEndDate.SelectedDate;
            //DateTime? strt = dtpPkgStartDate.SelectedDate.Value.Date.ToShortDateString();
            //DateTime? end = dtpPkgEndDate.SelectedDate.ToString();
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
            if (end < strt && !end.Value.Date.ToShortDateString().Equals(strt.Value.Date.ToShortDateString()))
            //if (end < strt)
            {
                dtpPkgEndDate.SelectedDate = dtpPkgStartDate.SelectedDate;
                MessageBox.Show("Please enter an end date that is equal to or greater than the start date.");
                return;
            }
            else if (strt < DateTime.Now && !DateTime.Now.ToShortDateString().Equals(dtpPkgEndDate.SelectedDate.Value.Date.ToShortDateString()))
            //else if (strt < DateTime.Now && !DateTime.Now.ToShortDateString().Equals(dtpPkgEndDate.SelectedDate))
            {

                MessageBox.Show("Please enter a start date that is greater than todays date.");
                dtpPkgStartDate.SelectedDate = DateTime.Now;
                return;
            }
            else if (end < DateTime.Now && !DateTime.Now.ToShortDateString().Equals(dtpPkgEndDate.SelectedDate.Value.Date.ToShortDateString()))
            //else if (end < DateTime.Now && !DateTime.Now.ToShortDateString().Equals(dtpPkgEndDate.SelectedDate))
            {
                MessageBox.Show("Please enter an end date that is greater than todays date.");
                dtpPkgEndDate.SelectedDate = DateTime.Now;
                return;
            }
            else
            {
                pack.PkgStartDate = Convert.ToDateTime(strt.Value.Date.ToShortDateString());
                pack.PkgEndDate = Convert.ToDateTime(end.Value.Date.ToShortDateString());
                //pack.PkgStartDate = Convert.ToDateTime(strt);
                //pack.PkgEndDate = Convert.ToDateTime(end);
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
            if (Convert.ToString(btnAddEditPkg.Content) == "Save New Package")
            {
                //Inserts the package into the database and then refreshes the mainpage
                PackagesDB.InsertPackages(pack);
                UpdateBinding(false);
                btnAddEditPkg.Content = "Save Edited Package";
            }
            else if (Convert.ToString(btnAddEditPkg.Content) == "Save Edited Package")
            {
                // updates the package and then refreshes the main page
                PackagesDB.UpdatePackages(pack, pkgid);
                UpdateBinding(true);
            }
        }

        //Ethan Shipley
        // Dsiplays the list of available product suppliers
        private void BtnNewPkgProdSup_Click(object sender, RoutedEventArgs e)
        {
            psn = ProdSuppliersNamesDB.GetProdSupAll(ppss);
            gvProdSup_all_pkgs.ItemsSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(true);
            //ProdSupListDetails(gvProdSup_all_pkgs);
            gvProdSup_all_pkgs.Visibility = Visibility.Visible;
        }

        //Ethan Shipley
        // Formats the prod and supplier details
        private void ProdSupListDetails(DataGrid dataGridView)
        {
            dataGridView.Columns[0].Visibility = Visibility.Hidden;
            dataGridView.Columns[1].Visibility = Visibility.Hidden;
            dataGridView.Columns[2].Visibility = Visibility.Hidden;
            dataGridView.Columns[3].Header = "Product Name";
            dataGridView.Columns[4].Header = "Supplier Name";
        }

        //Ethan Shipley
        // Adds the products suppliers to the package
        private void BtnAddPkgProdSup_Click(object sender, RoutedEventArgs e)
        {
            //if (gvProdSup_all_pkgs.SelectedIndex==-1 || slct_colmn==-1)
            if (gvProdSup_all_pkgs.SelectedIndex==-1 || slct_colmn==-1)
            {
                MessageBox.Show("Cannot add product. Please add a package or edit an existing package.");
                return;
            }
            //PackageProductSuppliersDB.InsertProductSupplierIdPpkg(pkgid, getSelectedCellValue(gvProdSup_all_pkgs, 0));
            PackageProductSuppliersDB.InsertProductSupplierIdPpkg(pkgid, getSelectedCellValueProdSup(gvProdSup_all_pkgs));
            UpdateBinding(true);

            //duplicate code
            psn = ProdSuppliersNamesDB.GetProdSupAll(ppss);
            gvProdSup_all_pkgs.ItemsSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(true);
            gvProdSup_all_pkgs.ItemsSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(true);
            //slct_colmn = gvPackages.CurrentCell.RowIndex; 
            //this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);
            //gvPackages.CurrentCell = gvPackages[3, slct_colmn];
            //UpdateBinding(true);
        }

        //Ethan Shipley
        // Deletes the products suppliers to the package
        private void BtnDeletePkgProdSup_Click(object sender, RoutedEventArgs e)
        {
            //string useranswer = Interaction.InputBox("My msg", "title", "default response");
            if (gvProdSup_pkg.SelectedIndex==-1)
            {
                MessageBox.Show("Cannot delete product. Please add a package or edit an existing package.");
                return;
            }
            if (!deleteConfirm())
            {
                return;
            }
            //PackageProductSuppliersDB.DeleteProductSupplierIdPpkg(pkgid, getSelectedCellValue(gvProdSup_pkg, 1));
            PackageProductSuppliersDB.DeleteProductSupplierIdPpkg(pkgid, getSelectedCellValueProdSup(gvProdSup_pkg));
            //slct_colmn = gvPackages.CurrentCell.RowIndex;
            slct_colmn = gvPackages.SelectedIndex;
            //gvPackages.CurrentCell = gvPackages[1, slct_colmn];

            UpdateBinding(true);

            //duplicate code
            psn = ProdSuppliersNamesDB.GetProdSupAll(ppss);
            gvProdSup_all_pkgs.ItemsSource = psn;
            ProdSupListDetails(gvProdSup_all_pkgs);
            hideunhide(false);
        }

        // Ethan Shipley
        // Lets the user know how many cahracters they have left for the package name
        private void TxtPackageName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblPkgNameLength.Text = "Remaining length " + Convert.ToString(PKG_NAME_LENGTH - txtPackageName.Text.Length);
        }

        // Ethan Shipley
        // Lets the user know how many cahracters they have left for the package name
        private void TxtPkgDesc_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblPkgDescLength.Text = "Remaining length " + Convert.ToString(PKG_DESC_LENGTH - txtPkgDesc.Text.Length);
        }

        //Ethan Shipley
        // Gets the cells value from selected cell based on required column
        private int getSelectedCellValueProdSup(DataGrid dataGridView)
        {
            object item = dataGridView.SelectedItem;
            return Convert.ToInt32(item.GetType().GetProperty("ProductSupplierId").GetValue(item, null));
        }

        //Ethan SHipley
        // CLear the contents of the packages page
        private void BtnClearPkg_Click(object sender, RoutedEventArgs e)
        {
            PackagesReset();
        }
        /*=======================================================================================================================*/
        /*=======================================================================================================================*/
        /*===================================================SUPPLIER============================================================*/
        /*=======================================================================================================================*/
        /*=======================================================================================================================*/



        // Sheila Zhao
        // Gets the supplier information
        private void GetSupplier(int supplierID)
        {
            Sup = SupplierDB.GetSuppliers();
            selectSuppliers = (from Sp in Sup
                               where Sp.SupplierId == supplierID
                               select Sp).ToList();

            gvSuppliers2.ItemsSource = selectSuppliers;
        }

        //Sheila Zhao, with edits by Ethan SHipley
        // Displays all of the suppliers available in the suppliers gridview
        private void SupplierList()
        {
            gvSuppliers2.ItemsSource = Supp;
            //gvSuppliers2.Columns[0].Header = "ID";
            //gvSuppliers2.Columns[1].Header = "Supplier Name";
        }

        //Sheila Zhao
        //Gets the selected supplier and displays the corresponding product when supplier selection changes
        private void GvSuppliers2_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            Supplier selectedSupplier = null;
            try
            {
                //foreach (DataGridRow row in gvSuppliers2.SelectedItems)
                //{
                //    selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                //                                   row.Cells[1].Value.ToString());
                //}

                selectedSupplier = (Supplier)GetSelected(gvSuppliers2, "Supplier");

                Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
                gvProducts2.ItemsSource = Prod;

                if (selectedSupplier != null)
                {
                    Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
                    gvProdBySup.ItemsSource = Prod;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Sheila Zhao, with edit by Ethan Shipley
        // upon button click of the add new supplier button, the new supplier is saved
        private void BtnNewS_Click(object sender, RoutedEventArgs e)
        {
            Supplier ns = new Supplier();
            //int selectedindex;
            btnSaveS.Visibility = Visibility.Hidden;

            try
            {
                if (ns != null)
                {
                    if (txtSupName.Text == "")
                    {
                        MessageBox.Show("Name can not be empty!");
                    }
                    else
                    {
                        ns.SupName = txtSupName.Text;
                        SupplierDB.InsertSupplier(ns);
                        Supp = SupplierDB.GetSuppliers();
                        UpdateBindingProdSup();

                        ScrollDown(gvSuppliers2);

                        //if (gvSuppliers2.Items.Count > 0)
                        //{
                        //    //gvSuppliers2.ClearSelection();
                        //    gvSuppliers2.UnselectAll();

                        //    int RowIndex = gvSuppliers2.Items.Count - 1;
                        //    //    //int nColumnIndex = 0;

                        //    gvSuppliers2.Rows[RowIndex].Selected = true;
                        //    //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                        //    //    //In case if you want to scroll down as well.
                        //    gvSuppliers2.FirstDisplayedScrollingRowIndex = RowIndex;

                        //}
                    }

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
        }

        // Sheila Zhao, with edits by Ethan SHipley February 1, 2019
        // upon button click for the edit button it gets the selected product and then fills the information into the suppliername textbox
        private void BtnEditS_Click(object sender, RoutedEventArgs e)
        {
            Supplier olds = null;
            btnSaveS.Visibility = Visibility.Visible;
            //foreach (DataGridRow row in gvSuppliers2.SelectedItems)
            //{
            //    olds = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                        row.Cells[1].Value.ToString());
            //}
            olds = (Supplier)GetSelected(gvSuppliers2, "Supplier");
            txtSupName.Text = olds.SupName;
            txtSupName.Focus();
        }

        // Sheila Zhao, with edits by Ethan Shipley February 1, 2019
        //Gets the edited supplier for the save function
        private Supplier GetEditSupplier(Supplier olds)
        {
            Supplier news = new Supplier();
            news = (Supplier)GetSelected(gvSuppliers2, "Supplier");
            //foreach (DataGridRow row in gvSuppliers2.SelectedItems)
            //{
            //    olds = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                        row.Cells[1].Value.ToString());
            //}
            news.SupName = olds.SupName;
            news.SupplierId = olds.SupplierId;
            return news;
        }

        // Sheila Zhao, with edits by Ethan Shipley February 1, 2019
        // Saves the edited supplier name overwriting the name that was existing
        private void BtnSaveS_Click(object sender, RoutedEventArgs e)
        {
            Supplier news = new Supplier();
            Supplier olds = null;
            olds = (Supplier)GetSelected(gvSuppliers2, "Supplier");
            //foreach (DataGridRow row in gvSuppliers2.SelectedItems)
            //{
            //    olds = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                        row.Cells[1].Value.ToString());
            //}
            if (txtSupName.Text == "")
            {
                MessageBox.Show("Name can not be empty!");
            }
            else
            {
                news = GetEditSupplier(olds);
                try
                {
                    news.SupName = txtSupName.Text;
                    SupplierDB.UpdateSupplier(news, olds);
                    Supp = SupplierDB.GetSuppliers();
                    UpdateBindingProdSup();
                    MessageBox.Show("Supplier Saved!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                btnSaveS.Visibility = Visibility.Hidden;
                txtSupName.Text = "";
            }
        }

        // Sheila Zhao, with edits by Ethan Shipley February 1 2019
        // Upon button click, the selected supplier is deleted
        private void BtnDelSup_Click(object sender, RoutedEventArgs e)
        {
            btnSaveS.Visibility = Visibility.Hidden;
            try
            {
                Supplier delSup = null;
                delSup = (Supplier)GetSelected(gvSuppliers2, "Supplier");
                //foreach (DataGridRow row in gvSuppliers2.SelectedItems)
                //{
                //    delSup = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                //                                        row.Cells[1].Value.ToString());
                //    txtSupName.Text = delSup.SupName;
                //}
                if (!deleteConfirm())
                {
                    return;
                }
                MessageBox.Show("Item deleted");
                SupplierDB.DeleteSupplier(delSup);
                txtSupName.Text = "";
                Supp = SupplierDB.GetSuppliers();
                UpdateBindingProdSup();
                ScrollDown(gvSuppliers2);
                //int nRowIndex = gvSuppliers2.Rows.Count - 1;
                //gvSuppliers2.ClearSelection();
                //gvSuppliers2.FirstDisplayedScrollingRowIndex = nRowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Sheila Zhao, with edits by Ethan Shipley February 1 2019
        // Displays the list of products that are not connected to the supplier as well as some buttons
        private void BtnShowSP_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(btnShowSP.Content) == "Show")
            {
                gvProdBySup.Visibility = Visibility.Visible;
                btnDelSP.Visibility = Visibility.Visible;
                btnAddSP.Visibility = Visibility.Visible;
                lblPNL.Visibility = Visibility.Visible;

                btnShowSP.Content = "Hide";
            }
            else if (Convert.ToString(btnShowSP.Content) == "Hide")
            {
                gvProdBySup.Visibility = Visibility.Hidden;
                btnDelSP.Visibility = Visibility.Hidden;
                btnAddSP.Visibility = Visibility.Hidden;
                lblPNL.Visibility = Visibility.Hidden;
                btnShowSP.Content = "Show";
            }
        }

        //Sheila Zhao, with edits by Ethan Shipley February 1 2019
        // Clears the fields for the products page
        private void BtnClearS_Click(object sender, RoutedEventArgs e)
        {
            txtSupName.Text = "";
            btnDelPS.Visibility = Visibility.Hidden;
            btnAddPS.Visibility = Visibility.Hidden;
            gvProdBySup.Visibility = Visibility.Hidden;
            btnSaveS.Visibility = Visibility.Hidden;
            lblPNL.Visibility = Visibility.Hidden;
            btnShowSP.Content = "Show";
            UpdateBindingProdSup();
        }

        //Sheila Zhao, with edits by Ethan Shipley February 1 2019
        // Deletes the product supplier
        private void BtnDelSP_Click(object sender, RoutedEventArgs e)
        {
            int SupID, ProdID;
            int Success = 0;
            Supplier selectedSupplier = null;

            if (gvProducts2.SelectedCells.Count > 0 && gvSuppliers2.SelectedCells.Count > 0)
            {
                ProdID = Convert.ToInt32(gvProducts2.SelectedItem.GetType().GetProperty("ProductId").GetValue(gvProducts2.SelectedItem, null));
                SupID = Convert.ToInt32(gvSuppliers2.SelectedItem.GetType().GetProperty("SupplierId").GetValue(gvSuppliers2.SelectedItem, null));
                //ProdSupID = Convert.ToInt32(gvProdBySup.SelectedCells[0].Value);

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
                            selectedSupplier = (Supplier)GetSelected(gvSuppliers2, "Supplier");
                            //foreach (DataGridRow row in gvSuppliers2.SelectedItems)
                            //{
                            //    selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                            //                                   row.Cells[1].Value.ToString());
                            //}

                            // Fix me
                            Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
                            gvProducts2.ItemsSource = Prod;
                            if (selectedSupplier != null)
                            {
                                Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
                                gvProdBySup.ItemsSource = Prod;
                            }
                            MessageBox.Show("Product Deleted Successfully!");
                            ScrollDown(gvProdBySup);
                            //if (gvProdBySup.Rows.Count > 0)
                            //{
                            //    gvProdBySup.ClearSelection();

                            //    int RowIndex = gvProdBySup.Rows.Count - 1;
                            //    //    //int nColumnIndex = 0;

                            //    gvProdBySup.Rows[RowIndex].Selected = true;
                            //    //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                            //    //    //In case if you want to scroll down as well.
                            //    gvProdBySup.FirstDisplayedScrollingRowIndex = RowIndex;
                            //}
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

        //Sheila Zhao, with edits by Ethan Shipley February 1 2019
        // Creates the product supplier
        private void BtnAddSP_Click(object sender, RoutedEventArgs e)
        {
            int ProdSupID, SupID;
            int Success = 0;
            Supplier selectedSupplier = null;

            if ((gvProdBySup.SelectedCells.Count > 0 && gvSuppliers2.SelectedCells.Count > 0) || (gvProducts2.SelectedCells.Count == 0))
            {
                SupID = Convert.ToInt32(gvSuppliers2.SelectedItem.GetType().GetProperty("SupplierId").GetValue(gvSuppliers2.SelectedItem, null));
                ProdSupID = Convert.ToInt32(gvProdBySup.SelectedItem.GetType().GetProperty("ProductId").GetValue(gvProdBySup.SelectedItem, null));

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
                            selectedSupplier = (Supplier)GetSelected(gvSuppliers2, "Supplier");
                            //foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
                            //{
                            //    selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
                            //                                   row.Cells[1].Value.ToString());
                            //}

                            // Fix me
                            Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
                            gvProducts2.ItemsSource = Prod;
                            if (selectedSupplier != null)
                            {
                                Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
                                gvProdBySup.ItemsSource = Prod;
                            }
                            MessageBox.Show("Product Added Successfully!");
                            ScrollDown(gvProducts2);
                            //if (gvProducts2.Rows.Count > 0)
                            //{
                            //    gvProducts2.ClearSelection();

                            //    int RowIndex = gvProducts2.Rows.Count - 1;
                            //    //    //int nColumnIndex = 0;

                            //    gvProducts2.Rows[RowIndex].Selected = true;
                            //    //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                            //    //    //In case if you want to scroll down as well.
                            //    gvProducts2.FirstDisplayedScrollingRowIndex = RowIndex;
                            //}
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
            //else if (gvProducts2.SelectedCells.Count == 0)
            //{
            //    //ProdID = Convert.ToInt32(gvProducts2.SelectedCells[0].Value);
            //    SupID = Convert.ToInt32(gvSuppliers2.SelectedCells[0].Value);
            //    ProdSupID = Convert.ToInt32(gvProdBySup.SelectedCells[0].Value);

            //    try
            //    {
            //        // Make new object
            //        ProdSuppliers addNew = new ProdSuppliers();

            //        addNew.ProdId = ProdSupID;
            //        addNew.SupplierId = SupID;

            //        // Now sql query to add

            //        Success = ProdSupplierDB.InsertSupProduct(addNew);

            //        if (Success == 1)
            //        {

            //            // Refresh gridview
            //            try
            //            {
            //                foreach (DataGridViewRow row in gvSuppliers2.SelectedRows)
            //                {
            //                    selectedSupplier = new Supplier(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                                   row.Cells[1].Value.ToString());
            //                }

            //                // Fix me
            //                Prod = SupplierDB.GetProductsByProductSupplier(selectedSupplier);
            //                gvProducts2.DataSource = Prod;
            //                if (selectedSupplier != null)
            //                {
            //                    Prod = ProductDB.GetSupProdNotInList(selectedSupplier);
            //                    gvProdBySup.DataSource = Prod;
            //                }
            //                MessageBox.Show("Product Added Successfully!");

            //                if (gvProducts2.Rows.Count > 0)
            //                {
            //                    gvProducts2.ClearSelection();

            //                    int RowIndex = gvProducts2.Rows.Count - 1;
            //                    //    //int nColumnIndex = 0;

            //                    gvProducts2.Rows[RowIndex].Selected = true;
            //                    //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

            //                    //    //In case if you want to scroll down as well.
            //                    gvProducts2.FirstDisplayedScrollingRowIndex = RowIndex;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message, ex.GetType().ToString());
            //            }

            //        }
            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show(ex.Message, ex.GetType().ToString());
            //    }
            //}
        }

        //Ethan Shipley February 1, 2019
        // Gets the selected datagrid row properties for product or supplier depending on user input. By default gets products
        private object GetSelected(DataGrid dg, string supprod="")
        {
            object row = dg.SelectedItem;
            if (row == null)
            {
                dg.SelectedIndex = (dg.Items.Count) - 1;
                row = dg.SelectedItem;
            }
            object p;
            if (supprod=="Supplier")
            {
                p = new Supplier(Convert.ToInt32(row.GetType().GetProperty("SupplierId").GetValue(row, null)),
                                    Convert.ToString(row.GetType().GetProperty("SupName").GetValue(row, null)));
            }
            else
            {
                p = new Products(Convert.ToInt32(row.GetType().GetProperty("ProductId").GetValue(row, null)),
                                    Convert.ToString(row.GetType().GetProperty("ProdName").GetValue(row, null)));
            }
            return p;
        }

        /*=======================================================================================================================*/
        /*=======================================================================================================================*/
        /*===================================================PRODUCT=============================================================*/
        /*=======================================================================================================================*/
        /*=======================================================================================================================*/

        //Sheila Zhao, with edits by Ethan Shipley
        //Displays all of the propucts available in the products gridview
        private void ProductList()
        {
            gvProducts1.ItemsSource = Prodd;
            //gvProducts1.Columns[0].Header = "ID";
            //gvProducts1.Columns[1].Header = "Product Name";
        }

        // Sheila Zhao
        // Gets the products itemsource for the products datagrid
        private void GetProduct(int productID)
        {
            Prod = ProductDB.GetProducts();
            selectProducts = (from Pd in Prod
                              where Pd.ProductId == productID
                              select Pd).ToList();

            gvProducts1.ItemsSource = selectProducts;

        }
        //SHeila Zhao, with edits by Ethan Shipley
        //Updates the item sources 
        private void UpdateBindingProdSup()
        {
            gvProducts1.ItemsSource = Prodd;
            gvSuppliers2.ItemsSource = Supp;
        }

        //Sheila Zhao, Edits by ethan shipley
        // As the user makes selections of the products datagrid this method changes the supplier that are shown in its corresponding datagrid
        private void GvProducts1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Products selectedProduct = null;

            try
            {
                //foreach (DataGridRow row in gvProducts1.SelectedItems)
                //{
                //object row = gvProducts1.SelectedItem;
                //selectedProduct = new Products(Convert.ToInt32(row.GetType().GetProperty("ProductId").GetValue(row, null)), 
                //                    Convert.ToString(row.GetType().GetProperty("ProdName").GetValue(row, null)));
                //}
                //selectedProduct = SelectedProd(gvProducts1);
                selectedProduct = (Products)GetSelected(gvProducts1);
                Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                gvSuppliers1.ItemsSource = Sup;
                if (selectedProduct != null)
                {
                    Sup = SupplierDB.GetProSupNotInList(selectedProduct);
                    gvSupByProd.ItemsSource = Sup;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        // Sheila Zhao
        // On button click saves a new product to the database
        private void BtnAddNewProd_Click(object sender, RoutedEventArgs e)
        {
            Products np = new Products();
            btnSaveP.Visibility = Visibility.Hidden;

            try
            {
                //if (np != null)
                //{
                //    np.ProdName = txtProdName.Text;
                //    ProductDB.InsertProduct(np);
                //    Prodd = ProductDB.GetProducts();
                //    UpdateBinding(true);
                //}
                if (np != null)
                {
                    if (txtProdName.Text == "")
                    {
                        MessageBox.Show("Name can not be empty!");
                    }
                    else
                    {
                        np.ProdName = txtProdName.Text;
                        ProductDB.InsertProduct(np);
                        Prodd = ProductDB.GetProducts();
                        UpdateBindingProdSup();

                        ScrollDown(gvProducts1);
                        //if (gvProducts1.Items.Count > 0)
                        //{
                        //    gvProducts1.UnselectAll();

                        //    //int nRowIndex = gvProducts1.Items.Count - 1;
                        //    //int nColumnIndex = 0;

                        //    //gvProducts1.Rows[nRowIndex].Selected = true;
                        //    ////gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                        //    ////In case if you want to scroll down as well.
                        //    //gvProducts1.FirstDisplayedScrollingRowIndex = nRowIndex;
                        //    ScrollDown(gvProducts1);
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            txtProdName.Text = "";

            //if (gvProducts1.Items.Count > 0)
            //{
            //    gvProducts1.UnselectAll();

            //    int nRowIndex = gvProducts1.Items.Count - 1;
            //    gvProducts1.SelectedItem = nRowIndex;

            //    //In case if you want to scroll down as well.
            //    ScrollDown(gvProducts1, nRowIndex);
            //}
        }

        // Sheila Zhao, with edits by Ethan SHipley
        // Allows editing of the products page
        private void BtnEditP_Click(object sender, RoutedEventArgs e)
        {
            Products oldp = null;
            btnSaveP.Visibility = Visibility.Visible;
            //foreach (DataGridRow row in gvProducts1.SelectedItems)
            //{
            //    oldp = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                        row.Cells[1].Value.ToString());
            //}
            //object row = gvProducts1.SelectedItem;
            //oldp = new Products(Convert.ToInt32(row.GetType().GetProperty("ProductId").GetValue(row, null)),
            //                    Convert.ToString(row.GetType().GetProperty("ProdName").GetValue(row, null)));
            //oldp = SelectedProd(gvProducts1);
            oldp = (Products)GetSelected(gvProducts1);
            txtProdName.Text = oldp.ProdName;
            txtProdName.Focus();
        }

        // Sheila Zhao, Edits by Ethan Shipley
        // Gets the edited products for the save function
        private Products GetEditProduct(Products oldp)
        {
            Products newp = new Products();
            //foreach (DataGridRow row in gvProducts1.SelectedItems)
            //{
            //    oldp = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                        row.Cells[1].Value.ToString());
            //}
            //object row = gvProducts1.SelectedItem;
            //oldp = new Products(Convert.ToInt32(row.GetType().GetProperty("ProductId").GetValue(row, null)),
            //                    Convert.ToString(row.GetType().GetProperty("ProdName").GetValue(row, null)));
            //oldp = SelectedProd(gvProducts1);
            oldp = (Products)GetSelected(gvProducts1);
            newp.ProdName = oldp.ProdName;
            newp.ProductId = oldp.ProductId;
            return newp;
        }

        // Sheila Zhao, edits by Ethan SHipley, January 30 2019
        // Upon user click of the save button, the edited product is changed in the database
        private void BtnSaveP_Click(object sender, RoutedEventArgs e)
        {
            Products newp = new Products();
            Products oldp = null;
            //foreach (DataGridRow row in gvProducts1.SelectedItems)
            //{
            //    oldp = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                        row.Cells[1].Value.ToString());
            //}
            //oldp = SelectedProd(gvProducts1);
            oldp = (Products)GetSelected(gvProducts1);
            if (txtProdName.Text == "")
            {
                MessageBox.Show("Name can not be empty!");
                return;
            }
            else
            {
                newp = GetEditProduct(oldp);
                try
                {
                    newp.ProdName = txtProdName.Text;
                    ProductDB.UpdateProduct(newp, oldp);
                    Prodd = ProductDB.GetProducts();
                    UpdateBindingProdSup();
                    MessageBox.Show("Product Saved!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                btnSaveP.Visibility = Visibility.Hidden;
                txtProdName.Text = "";
            }
            
        }
        //Sheila Zhao, with edits by Ethan Shipley
        // Clears the fields for the products page
        private void BtnClearP_Click(object sender, RoutedEventArgs e)
        {
            txtProdName.Text = "";
            btnDelSP.Visibility = Visibility.Hidden;
            btnAddSP.Visibility = Visibility.Hidden;
            btnSaveP.Visibility = Visibility.Hidden;
            gvSupByProd.Visibility = Visibility.Hidden;
            lblSNL.Visibility = Visibility.Hidden;
            btnShowPS.Content = "Show";
            UpdateBindingProdSup();
        }

        // Sheila Zhao, with edits by Ethan Shipley
        // Deletes the selected product from database when user clicks button
        private void BtnDelProd_Click(object sender, RoutedEventArgs e)
        {
            btnSaveP.Visibility = Visibility.Hidden;
            try
            {
                Products delProd = null;
                //delProd = SelectedProd(gvProducts1);
                delProd = (Products)GetSelected(gvProducts1);
                //foreach (DataGridRow row in gvProducts1.SelectedItems)
                //{
                //    delProd = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                //                                        row.Cells[1].Value.ToString());
                //    txtProdName.Text = delProd.ProdName;
                //}
                if (!deleteConfirm())
                {
                    return;
                }
                MessageBox.Show("Item deleted");
                ProductDB.DeleteProduct(delProd);
                txtProdName.Text = "";
                Prodd = ProductDB.GetProducts();
                UpdateBindingProdSup();

                //int nRowIndex = gvProducts1.Rows.Count - 1;
                //gvProducts1.ClearSelection();
                //gvProducts1.FirstDisplayedScrollingRowIndex = nRowIndex;
                ScrollDown(gvProducts1);
                //gvProducts1.CurrentItem = gvProducts1.Items[-1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Sheila Zhao, with edits by Ethan Shipley
        // SHows and hided the suppliers that are not connected to the product in products suppliers textbox
        private void BtnShowPS_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(btnShowPS.Content) == "Show")
            {
                gvSupByProd.Visibility = Visibility.Visible;
                btnDelPS.Visibility = Visibility.Visible;
                btnAddPS.Visibility = Visibility.Visible;
                lblSNL.Visibility = Visibility.Visible;

                btnShowPS.Content = "Hide";
            }
            else if (Convert.ToString(btnShowPS.Content) == "Hide")
            {
                gvSupByProd.Visibility = Visibility.Hidden;
                btnDelPS.Visibility = Visibility.Hidden;
                btnAddPS.Visibility = Visibility.Hidden;
                lblSNL.Visibility = Visibility.Hidden;
                btnShowPS.Content = "Show";
            }
        }

        // Sheila Zhao, with edits by Ethan Shipley
        // Deletes the product supplier
        private void BtnDelPS_Click(object sender, RoutedEventArgs e)
        {
            int ProdSupID, ProdID;
            int Success = 0;
            Products selectedProduct = null;


            //if (gvProducts1.SelectedCells.Count > 0 && gvSupByProd.SelectedCells.Count > 0
            //    && gvSuppliers1.SelectedCells.Count > 0)
            if (gvProducts1.SelectedCells.Count > 0 && gvSuppliers1.SelectedCells.Count > 0)
            {
                //ProdID = Convert.ToInt32(gvProducts1.SelectedCells[0].Value);
                //SupID = Convert.ToInt32(gvSupByProd.SelectedCells[0].Value);
                //ProdSupID = Convert.ToInt32(gvSuppliers1.SelectedCells[0].Value);
                ProdID = Convert.ToInt32(gvProducts1.SelectedItem.GetType().GetProperty("ProductId").GetValue(gvProducts1.SelectedItem,null));
                //SupID = Convert.ToInt32(gvSupByProd.SelectedItem.GetType().GetProperty("SupplierId").GetValue(gvSupByProd.SelectedItem, null));
                ProdSupID = Convert.ToInt32(gvSuppliers1.SelectedItem.GetType().GetProperty("SupplierId").GetValue(gvSuppliers1.SelectedItem, null));

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
                            //foreach (DataGridRow row in gvProducts1.SelectedItems)
                            //{
                            //    selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                            //                                   row.Cells[1].Value.ToString());
                            //}
                            //selectedProduct = SelectedProd(gvProducts1);
                            selectedProduct = (Products)GetSelected(gvProducts1);

                            // Fix me
                            Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                            gvSuppliers1.ItemsSource = Sup;
                            if (selectedProduct != null)
                            {
                                Sup = SupplierDB.GetProSupNotInList(selectedProduct);
                                gvSupByProd.ItemsSource = Sup;
                            }
                            MessageBox.Show("Supplier Deleted Successfully!");

                            ScrollDown(gvSupByProd);
                            //if (gvSupByProd.Items.Count > 0)
                            //{
                            //    //gvSupByProd.ClearSelection();
                            //    gvSupByProd.UnselectAll();
                            //    ScrollDown(gvSupByProd);
                            //    //int RowIndex = gvSupByProd.Items.Count - 1;
                            //    ////    //int nColumnIndex = 0;

                            //    //gvSupByProd.SelectedIndex = RowIndex;
                            //    //gvSupByProd.Focus();
                            //    ////gvSupByProd.Items[RowIndex].Selected = true;
                            //    ////    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                            //    ////    //In case if you want to scroll down as well.
                            //    //gvSupByProd.FirstDisplayedScrollingRowIndex = RowIndex;
                            //}
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
            else
            {
                MessageBox.Show("Please select a supplier to delete");
            }
        }

        //Sheila Zhoa
        private void BtnAddPS_Click(object sender, RoutedEventArgs e)
        {
            //int ProdSupID, SupID, ProdID;
            int SupID, ProdID;
            int Success = 0;
            Products selectedProduct = null;

            //if (gvProducts1.SelectedCells.Count > 0 && gvSupByProd.SelectedCells.Count > 0
            //    && gvSuppliers1.SelectedCells.Count > 0)
            if ((gvProducts1.SelectedCells.Count > 0 && gvSupByProd.SelectedCells.Count > 0) || (gvSuppliers1.SelectedCells.Count == 0 && gvSupByProd.SelectedCells.Count > 0))
            {
                ProdID = Convert.ToInt32(gvProducts1.SelectedItem.GetType().GetProperty("ProductId").GetValue(gvProducts1.SelectedItem, null));
                SupID = Convert.ToInt32(gvSupByProd.SelectedItem.GetType().GetProperty("SupplierId").GetValue(gvSupByProd.SelectedItem, null));
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
                            //foreach (DataGridViewRow row in gvProducts1.SelectedRows)
                            //{
                            //    selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
                            //                                   row.Cells[1].Value.ToString());
                            //}
                            //selectedProduct = SelectedProd(gvProducts1);
                            selectedProduct = (Products)GetSelected(gvProducts1);

                            // Fix me, Sheila needs to fix this
                            Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
                            gvSuppliers1.ItemsSource = Sup;
                            if (selectedProduct != null)
                            {
                                Sup = SupplierDB.GetProSupNotInList(selectedProduct);
                                gvSupByProd.ItemsSource = Sup;
                            }
                            MessageBox.Show("Supplier Added Successfully!");

                            //if (gvSuppliers1.Items.Count > 0)
                            //{
                            //    gvSuppliers1.ClearSelection();

                            //    int RowIndex = gvSuppliers1.Items.Count - 1;
                            //    //    //int nColumnIndex = 0;

                            //    gvSuppliers1.Rows[RowIndex].Selected = true;
                            //    //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

                            //    //    //In case if you want to scroll down as well.
                            //    gvSuppliers1.FirstDisplayedScrollingRowIndex = RowIndex;
                            //}
                            ScrollDown(gvSuppliers1);
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
            else
            {
                MessageBox.Show("Please select a supplier to add");
            }
            //else if (gvSuppliers1.SelectedCells.Count == 0)
            //{
            //    ProdID = Convert.ToInt32(gvProducts1.SelectedCells[0].Value);
            //    SupID = Convert.ToInt32(gvSupByProd.SelectedCells[0].Value);
            //    //ProdSupID = Convert.ToInt32(gvSuppliers1.SelectedCells[0].Value);

            //    try
            //    {
            //        // Make new object
            //        ProdSuppliers addNew = new ProdSuppliers();

            //        addNew.ProdId = ProdID;
            //        addNew.SupplierId = SupID;

            //        // Now sql query to add

            //        Success = ProdSupplierDB.InsertProdSupplier(addNew);

            //        if (Success == 1)
            //        {

            //            // Refresh gridview
            //            try
            //            {
            //                foreach (DataGridViewRow row in gvProducts1.SelectedRows)
            //                {
            //                    selectedProduct = new Products(Convert.ToInt32(row.Cells[0].Value.ToString()),
            //                                                   row.Cells[1].Value.ToString());
            //                }

            //                // Fix me
            //                Sup = ProductDB.GetProductSuppliersByProduct(selectedProduct);
            //                gvSuppliers1.DataSource = Sup;
            //                if (selectedProduct != null)
            //                {
            //                    Sup = SupplierDB.GetProSupNotInList(selectedProduct);
            //                    gvSupByProd.DataSource = Sup;
            //                }
            //                MessageBox.Show("Supplier Added Successfully!");

            //                if (gvSuppliers1.Rows.Count > 0)
            //                {
            //                    gvSuppliers1.ClearSelection();

            //                    int RowIndex = gvSuppliers1.Rows.Count - 1;
            //                    //    //int nColumnIndex = 0;

            //                    gvSuppliers1.Rows[RowIndex].Selected = true;
            //                    //    //gvProducts1.Rows[nRowIndex].Cells[nColumnIndex].Selected = true;

            //                    //    //In case if you want to scroll down as well.
            //                    gvSuppliers1.FirstDisplayedScrollingRowIndex = RowIndex;
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show(ex.Message, ex.GetType().ToString());
            //            }

            //        }
            //    }
            //    catch (SqlException ex)
            //    {
            //        MessageBox.Show(ex.Message, ex.GetType().ToString());
            //    }
            //}
        }

        ////Ethan SHipley January 30 2019
        //// Gets the properties of the selected products
        //private Products SelectedProd(DataGrid dg)
        //{
        //    object row = dg.SelectedItem;
        //    if (row == null)
        //    {
        //        dg.SelectedIndex = (dg.Items.Count)-1;
        //        row = dg.SelectedItem;
        //    }
        //    Products p = new Products(Convert.ToInt32(row.GetType().GetProperty("ProductId").GetValue(row, null)),
        //                        Convert.ToString(row.GetType().GetProperty("ProdName").GetValue(row, null)));
        //    return p;
        //}

        //Ethan Shipley January 30 2019
        // Scroll to bottom
        private void ScrollDown(DataGrid dg)
        {
            if (dg.Items.Count > 0)
            {
                dg.UnselectAll();
                int nRowIndex = dg.Items.Count - 1;
                dg.SelectedIndex = nRowIndex;
                dg.Focus();
                dg.ScrollIntoView(dg.Items[dg.Items.Count - 1]);
                dg.UpdateLayout();
                dg.ScrollIntoView(dg.Items[nRowIndex]);
            }
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}




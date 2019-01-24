namespace TravelExpertsServices
{
    partial class   Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new TravelExpertsServices.TravelExpertsDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.suppliersTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.SuppliersTableAdapter();
            this.products_SuppliersTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter();
            this.packagesProductsSuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packages_Products_SuppliersTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter();
            this.tabProductSuppliers = new System.Windows.Forms.TabPage();
            this.btnSaveSupPkg = new System.Windows.Forms.Button();
            this.btnSaveProdPkg = new System.Windows.Forms.Button();
            this.btnSave_Prod_Sup_pkg = new System.Windows.Forms.Button();
            this.btnChangeProd = new System.Windows.Forms.Button();
            this.cmbSupName = new System.Windows.Forms.ComboBox();
            this.btnDelSup_pkg = new System.Windows.Forms.Button();
            this.btnDelProd_pkg = new System.Windows.Forms.Button();
            this.btnChangeSup = new System.Windows.Forms.Button();
            this.btnAddSup_pkg = new System.Windows.Forms.Button();
            this.btnAddProd_pkg = new System.Windows.Forms.Button();
            this.gvSuppliers_pkgs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProducts_pkgs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.btnDelSup = new System.Windows.Forms.Button();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.btnEditS = new System.Windows.Forms.Button();
            this.btnNewS = new System.Windows.Forms.Button();
            this.gvProducts2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSuppliers2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEditSup = new System.Windows.Forms.Button();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.lblSupName2 = new System.Windows.Forms.Label();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.btnEditP = new System.Windows.Forms.Button();
            this.btnAddNewProd = new System.Windows.Forms.Button();
            this.gvSuppliers1 = new System.Windows.Forms.DataGridView();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProducts1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEditProd = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName2 = new System.Windows.Forms.Label();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.btnDeletepkg = new System.Windows.Forms.Button();
            this.gvSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvPackages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditSup = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.btnEditPkg = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.btnDeletePkgProdSup_Click = new System.Windows.Forms.Button();
            this.btnAddPkgProdSup = new System.Windows.Forms.Button();
            this.gvProdSup_all_pkgs = new System.Windows.Forms.DataGridView();
            this.btnNewPkgProdSup = new System.Windows.Forms.Button();
            this.gvProdSup_pkg = new System.Windows.Forms.DataGridView();
            this.lblPkgDescLength = new System.Windows.Forms.Label();
            this.lblPkgNameLength = new System.Windows.Forms.Label();
            this.btnAddEditPkg = new System.Windows.Forms.Button();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPkgAgencyCommission = new System.Windows.Forms.Label();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).BeginInit();
            this.tabProductSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers_pkgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts_pkgs)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers2)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts1)).BeginInit();
            this.tabMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackages)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_all_pkgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_pkg)).BeginInit();
            this.SuspendLayout();
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // products_SuppliersBindingSource
            // 
            this.products_SuppliersBindingSource.DataMember = "Products_Suppliers";
            this.products_SuppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packagesTableAdapter
            // 
            this.packagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AffiliationsTableAdapter = null;
            this.tableAdapterManager.AgenciesTableAdapter = null;
            this.tableAdapterManager.AgentsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingDetailsTableAdapter = null;
            this.tableAdapterManager.BookingsTableAdapter = null;
            this.tableAdapterManager.ClassesTableAdapter = null;
            this.tableAdapterManager.CreditCardsTableAdapter = null;
            this.tableAdapterManager.Customers_RewardsTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FeesTableAdapter = null;
            this.tableAdapterManager.Packages_Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.PackagesTableAdapter = this.packagesTableAdapter;
            this.tableAdapterManager.Products_SuppliersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.RegionsTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.SupplierContactsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = this.suppliersTableAdapter;
            this.tableAdapterManager.TripTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelExpertsServices.TravelExpertsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // products_SuppliersTableAdapter
            // 
            this.products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // packagesProductsSuppliersBindingSource
            // 
            this.packagesProductsSuppliersBindingSource.DataMember = "Packages_Products_Suppliers";
            this.packagesProductsSuppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // packages_Products_SuppliersTableAdapter
            // 
            this.packages_Products_SuppliersTableAdapter.ClearBeforeFill = true;
            // 
            // tabProductSuppliers
            // 
            this.tabProductSuppliers.Controls.Add(this.btnSaveSupPkg);
            this.tabProductSuppliers.Controls.Add(this.btnSaveProdPkg);
            this.tabProductSuppliers.Controls.Add(this.btnSave_Prod_Sup_pkg);
            this.tabProductSuppliers.Controls.Add(this.btnChangeProd);
            this.tabProductSuppliers.Controls.Add(this.cmbSupName);
            this.tabProductSuppliers.Controls.Add(this.btnDelSup_pkg);
            this.tabProductSuppliers.Controls.Add(this.btnDelProd_pkg);
            this.tabProductSuppliers.Controls.Add(this.btnChangeSup);
            this.tabProductSuppliers.Controls.Add(this.btnAddSup_pkg);
            this.tabProductSuppliers.Controls.Add(this.btnAddProd_pkg);
            this.tabProductSuppliers.Controls.Add(this.gvSuppliers_pkgs);
            this.tabProductSuppliers.Controls.Add(this.gvProducts_pkgs);
            this.tabProductSuppliers.Controls.Add(this.cmbProdName);
            this.tabProductSuppliers.Controls.Add(this.lblSupName);
            this.tabProductSuppliers.Controls.Add(this.lblProdName);
            this.tabProductSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabProductSuppliers.Name = "tabProductSuppliers";
            this.tabProductSuppliers.Size = new System.Drawing.Size(1014, 400);
            this.tabProductSuppliers.TabIndex = 4;
            this.tabProductSuppliers.Text = "Product Suppliers";
            this.tabProductSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnSaveSupPkg
            // 
            this.btnSaveSupPkg.Location = new System.Drawing.Point(356, 304);
            this.btnSaveSupPkg.Name = "btnSaveSupPkg";
            this.btnSaveSupPkg.Size = new System.Drawing.Size(100, 23);
            this.btnSaveSupPkg.TabIndex = 46;
            this.btnSaveSupPkg.Text = "Save Supplier";
            this.btnSaveSupPkg.UseVisualStyleBackColor = true;
            // 
            // btnSaveProdPkg
            // 
            this.btnSaveProdPkg.Location = new System.Drawing.Point(356, 275);
            this.btnSaveProdPkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveProdPkg.Name = "btnSaveProdPkg";
            this.btnSaveProdPkg.Size = new System.Drawing.Size(100, 23);
            this.btnSaveProdPkg.TabIndex = 45;
            this.btnSaveProdPkg.Text = "Save Product";
            this.btnSaveProdPkg.UseVisualStyleBackColor = true;
            // 
            // btnSave_Prod_Sup_pkg
            // 
            this.btnSave_Prod_Sup_pkg.Enabled = false;
            this.btnSave_Prod_Sup_pkg.Location = new System.Drawing.Point(211, 328);
            this.btnSave_Prod_Sup_pkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave_Prod_Sup_pkg.Name = "btnSave_Prod_Sup_pkg";
            this.btnSave_Prod_Sup_pkg.Size = new System.Drawing.Size(103, 36);
            this.btnSave_Prod_Sup_pkg.TabIndex = 44;
            this.btnSave_Prod_Sup_pkg.Text = "Save Product Suppliers";
            this.btnSave_Prod_Sup_pkg.UseVisualStyleBackColor = true;
            this.btnSave_Prod_Sup_pkg.Visible = false;
            // 
            // btnChangeProd
            // 
            this.btnChangeProd.Location = new System.Drawing.Point(817, 170);
            this.btnChangeProd.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeProd.Name = "btnChangeProd";
            this.btnChangeProd.Size = new System.Drawing.Size(96, 23);
            this.btnChangeProd.TabIndex = 43;
            this.btnChangeProd.Text = "Change Product";
            this.btnChangeProd.UseVisualStyleBackColor = true;
            // 
            // cmbSupName
            // 
            this.cmbSupName.DataSource = this.suppliersBindingSource;
            this.cmbSupName.DisplayMember = "SupName";
            this.cmbSupName.Enabled = false;
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(164, 304);
            this.cmbSupName.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(188, 21);
            this.cmbSupName.TabIndex = 42;
            this.cmbSupName.ValueMember = "SupplierId";
            // 
            // btnDelSup_pkg
            // 
            this.btnDelSup_pkg.Location = new System.Drawing.Point(917, 346);
            this.btnDelSup_pkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelSup_pkg.Name = "btnDelSup_pkg";
            this.btnDelSup_pkg.Size = new System.Drawing.Size(87, 23);
            this.btnDelSup_pkg.TabIndex = 37;
            this.btnDelSup_pkg.Text = "Delete Supplier";
            this.btnDelSup_pkg.UseVisualStyleBackColor = true;
            // 
            // btnDelProd_pkg
            // 
            this.btnDelProd_pkg.Location = new System.Drawing.Point(917, 170);
            this.btnDelProd_pkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelProd_pkg.Name = "btnDelProd_pkg";
            this.btnDelProd_pkg.Size = new System.Drawing.Size(87, 23);
            this.btnDelProd_pkg.TabIndex = 38;
            this.btnDelProd_pkg.Text = "Delete Product";
            this.btnDelProd_pkg.UseVisualStyleBackColor = true;
            // 
            // btnChangeSup
            // 
            this.btnChangeSup.Location = new System.Drawing.Point(817, 346);
            this.btnChangeSup.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeSup.Name = "btnChangeSup";
            this.btnChangeSup.Size = new System.Drawing.Size(96, 23);
            this.btnChangeSup.TabIndex = 39;
            this.btnChangeSup.Text = "Change Supplier";
            this.btnChangeSup.UseVisualStyleBackColor = true;
            // 
            // btnAddSup_pkg
            // 
            this.btnAddSup_pkg.Location = new System.Drawing.Point(725, 346);
            this.btnAddSup_pkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSup_pkg.Name = "btnAddSup_pkg";
            this.btnAddSup_pkg.Size = new System.Drawing.Size(87, 23);
            this.btnAddSup_pkg.TabIndex = 40;
            this.btnAddSup_pkg.Text = "Add Suppplier";
            this.btnAddSup_pkg.UseVisualStyleBackColor = true;
            // 
            // btnAddProd_pkg
            // 
            this.btnAddProd_pkg.Location = new System.Drawing.Point(725, 170);
            this.btnAddProd_pkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProd_pkg.Name = "btnAddProd_pkg";
            this.btnAddProd_pkg.Size = new System.Drawing.Size(87, 23);
            this.btnAddProd_pkg.TabIndex = 41;
            this.btnAddProd_pkg.Text = "Add Product";
            this.btnAddProd_pkg.UseVisualStyleBackColor = true;
            // 
            // gvSuppliers_pkgs
            // 
            this.gvSuppliers_pkgs.AutoGenerateColumns = false;
            this.gvSuppliers_pkgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers_pkgs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn14});
            this.gvSuppliers_pkgs.DataSource = this.suppliersBindingSource;
            this.gvSuppliers_pkgs.Location = new System.Drawing.Point(725, 207);
            this.gvSuppliers_pkgs.Margin = new System.Windows.Forms.Padding(2);
            this.gvSuppliers_pkgs.Name = "gvSuppliers_pkgs";
            this.gvSuppliers_pkgs.RowTemplate.Height = 24;
            this.gvSuppliers_pkgs.Size = new System.Drawing.Size(279, 135);
            this.gvSuppliers_pkgs.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn15.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn14.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.Width = 101;
            // 
            // gvProducts_pkgs
            // 
            this.gvProducts_pkgs.AutoGenerateColumns = false;
            this.gvProducts_pkgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts_pkgs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn16});
            this.gvProducts_pkgs.DataSource = this.productsBindingSource;
            this.gvProducts_pkgs.Location = new System.Drawing.Point(725, 31);
            this.gvProducts_pkgs.Margin = new System.Windows.Forms.Padding(2);
            this.gvProducts_pkgs.Name = "gvProducts_pkgs";
            this.gvProducts_pkgs.RowTemplate.Height = 24;
            this.gvProducts_pkgs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts_pkgs.Size = new System.Drawing.Size(279, 135);
            this.gvProducts_pkgs.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn17.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 2;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 2;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn16.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cmbProdName
            // 
            this.cmbProdName.DataSource = this.productsBindingSource;
            this.cmbProdName.DisplayMember = "ProdName";
            this.cmbProdName.Enabled = false;
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(164, 277);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(188, 21);
            this.cmbProdName.TabIndex = 34;
            this.cmbProdName.ValueMember = "ProductId";
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(11, 306);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(79, 13);
            this.lblSupName.TabIndex = 32;
            this.lblSupName.Text = "Supplier Name:";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(11, 280);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(78, 13);
            this.lblProdName.TabIndex = 33;
            this.lblProdName.Text = "Product Name:";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.btnDelSup);
            this.tabSuppliers.Controls.Add(this.btnSaveS);
            this.tabSuppliers.Controls.Add(this.btnEditS);
            this.tabSuppliers.Controls.Add(this.btnNewS);
            this.tabSuppliers.Controls.Add(this.gvProducts2);
            this.tabSuppliers.Controls.Add(this.gvSuppliers2);
            this.tabSuppliers.Controls.Add(this.btnAddEditSup);
            this.tabSuppliers.Controls.Add(this.txtSupName);
            this.tabSuppliers.Controls.Add(this.lblSupName2);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1014, 400);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnDelSup
            // 
            this.btnDelSup.Location = new System.Drawing.Point(176, 318);
            this.btnDelSup.Name = "btnDelSup";
            this.btnDelSup.Size = new System.Drawing.Size(107, 23);
            this.btnDelSup.TabIndex = 12;
            this.btnDelSup.Text = "&Delete Product";
            this.btnDelSup.UseVisualStyleBackColor = true;
            this.btnDelSup.Click += new System.EventHandler(this.btnDelSup_Click);
            // 
            // btnSaveS
            // 
            this.btnSaveS.Location = new System.Drawing.Point(273, 290);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(75, 23);
            this.btnSaveS.TabIndex = 11;
            this.btnSaveS.Text = "&Save";
            this.btnSaveS.UseVisualStyleBackColor = true;
            this.btnSaveS.Click += new System.EventHandler(this.btnSaveS_Click);
            // 
            // btnEditS
            // 
            this.btnEditS.Location = new System.Drawing.Point(176, 289);
            this.btnEditS.Name = "btnEditS";
            this.btnEditS.Size = new System.Drawing.Size(75, 23);
            this.btnEditS.TabIndex = 10;
            this.btnEditS.Text = "&Edit Supplier";
            this.btnEditS.UseVisualStyleBackColor = true;
            this.btnEditS.Click += new System.EventHandler(this.btnEditS_Click);
            // 
            // btnNewS
            // 
            this.btnNewS.Location = new System.Drawing.Point(34, 290);
            this.btnNewS.Name = "btnNewS";
            this.btnNewS.Size = new System.Drawing.Size(105, 23);
            this.btnNewS.TabIndex = 9;
            this.btnNewS.Text = "&Add New Supplier";
            this.btnNewS.UseVisualStyleBackColor = true;
            this.btnNewS.Click += new System.EventHandler(this.btnNewS_Click);
            // 
            // gvProducts2
            // 
            this.gvProducts2.AutoGenerateColumns = false;
            this.gvProducts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.gvProducts2.DataSource = this.productsBindingSource;
            this.gvProducts2.Location = new System.Drawing.Point(535, 51);
            this.gvProducts2.Name = "gvProducts2";
            this.gvProducts2.ReadOnly = true;
            this.gvProducts2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts2.Size = new System.Drawing.Size(300, 220);
            this.gvProducts2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn12.HeaderText = "ProductId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn13.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // gvSuppliers2
            // 
            this.gvSuppliers2.AllowUserToAddRows = false;
            this.gvSuppliers2.AutoGenerateColumns = false;
            this.gvSuppliers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.gvSuppliers2.DataSource = this.suppliersBindingSource;
            this.gvSuppliers2.Location = new System.Drawing.Point(34, 51);
            this.gvSuppliers2.Name = "gvSuppliers2";
            this.gvSuppliers2.ReadOnly = true;
            this.gvSuppliers2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSuppliers2.Size = new System.Drawing.Size(300, 220);
            this.gvSuppliers2.TabIndex = 6;
            this.gvSuppliers2.SelectionChanged += new System.EventHandler(this.gvSuppliers2_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn8.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn10.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // btnAddEditSup
            // 
            this.btnAddEditSup.Location = new System.Drawing.Point(34, 343);
            this.btnAddEditSup.Name = "btnAddEditSup";
            this.btnAddEditSup.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditSup.TabIndex = 6;
            this.btnAddEditSup.Text = "Add Supplier";
            this.btnAddEditSup.UseVisualStyleBackColor = true;
            this.btnAddEditSup.Click += new System.EventHandler(this.btnAddEditSup_Click);
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(87, 7);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(100, 20);
            this.txtSupName.TabIndex = 5;
            // 
            // lblSupName2
            // 
            this.lblSupName2.AutoSize = true;
            this.lblSupName2.Location = new System.Drawing.Point(3, 10);
            this.lblSupName2.Name = "lblSupName2";
            this.lblSupName2.Size = new System.Drawing.Size(79, 13);
            this.lblSupName2.TabIndex = 4;
            this.lblSupName2.Text = "Supplier Name:";
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnDelProd);
            this.tabProduct.Controls.Add(this.btnSaveP);
            this.tabProduct.Controls.Add(this.btnEditP);
            this.tabProduct.Controls.Add(this.btnAddNewProd);
            this.tabProduct.Controls.Add(this.gvSuppliers1);
            this.tabProduct.Controls.Add(this.gvProducts1);
            this.tabProduct.Controls.Add(this.btnAddEditProd);
            this.tabProduct.Controls.Add(this.txtProdName);
            this.tabProduct.Controls.Add(this.lblProdName2);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(1014, 400);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnDelProd
            // 
            this.btnDelProd.Location = new System.Drawing.Point(172, 307);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(109, 23);
            this.btnDelProd.TabIndex = 8;
            this.btnDelProd.Text = "&Delete Product";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveP
            // 
            this.btnSaveP.Location = new System.Drawing.Point(269, 279);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveP.TabIndex = 7;
            this.btnSaveP.Text = "Save";
            this.btnSaveP.UseVisualStyleBackColor = true;
            this.btnSaveP.Click += new System.EventHandler(this.btnSaveP_Click);
            // 
            // btnEditP
            // 
            this.btnEditP.Location = new System.Drawing.Point(172, 278);
            this.btnEditP.Name = "btnEditP";
            this.btnEditP.Size = new System.Drawing.Size(75, 23);
            this.btnEditP.TabIndex = 6;
            this.btnEditP.Text = "&Edit Product";
            this.btnEditP.UseVisualStyleBackColor = true;
            this.btnEditP.Click += new System.EventHandler(this.btnEditP_Click);
            // 
            // btnAddNewProd
            // 
            this.btnAddNewProd.Location = new System.Drawing.Point(30, 279);
            this.btnAddNewProd.Name = "btnAddNewProd";
            this.btnAddNewProd.Size = new System.Drawing.Size(105, 23);
            this.btnAddNewProd.TabIndex = 5;
            this.btnAddNewProd.Text = "&Add New Product";
            this.btnAddNewProd.UseVisualStyleBackColor = true;
            this.btnAddNewProd.Click += new System.EventHandler(this.btnAddNewProd_Click);
            // 
            // gvSuppliers1
            // 
            this.gvSuppliers1.AutoGenerateColumns = false;
            this.gvSuppliers1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIdDataGridViewTextBoxColumn,
            this.supNameDataGridViewTextBoxColumn});
            this.gvSuppliers1.DataSource = this.suppliersBindingSource;
            this.gvSuppliers1.Location = new System.Drawing.Point(471, 78);
            this.gvSuppliers1.Name = "gvSuppliers1";
            this.gvSuppliers1.ReadOnly = true;
            this.gvSuppliers1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSuppliers1.Size = new System.Drawing.Size(300, 183);
            this.gvSuppliers1.TabIndex = 4;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            this.supplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supNameDataGridViewTextBoxColumn
            // 
            this.supNameDataGridViewTextBoxColumn.DataPropertyName = "SupName";
            this.supNameDataGridViewTextBoxColumn.HeaderText = "SupName";
            this.supNameDataGridViewTextBoxColumn.Name = "supNameDataGridViewTextBoxColumn";
            this.supNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gvProducts1
            // 
            this.gvProducts1.AutoGenerateColumns = false;
            this.gvProducts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn});
            this.gvProducts1.DataSource = this.productsBindingSource;
            this.gvProducts1.Location = new System.Drawing.Point(30, 78);
            this.gvProducts1.Name = "gvProducts1";
            this.gvProducts1.ReadOnly = true;
            this.gvProducts1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts1.Size = new System.Drawing.Size(259, 183);
            this.gvProducts1.TabIndex = 4;
            this.gvProducts1.SelectionChanged += new System.EventHandler(this.grProducts1_SelectionChanged);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnAddEditProd
            // 
            this.btnAddEditProd.Location = new System.Drawing.Point(30, 331);
            this.btnAddEditProd.Name = "btnAddEditProd";
            this.btnAddEditProd.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditProd.TabIndex = 4;
            this.btnAddEditProd.Text = "Add Product";
            this.btnAddEditProd.UseVisualStyleBackColor = true;
            this.btnAddEditProd.Click += new System.EventHandler(this.btnAddEditProd_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(111, 31);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 3;
            // 
            // lblProdName2
            // 
            this.lblProdName2.AutoSize = true;
            this.lblProdName2.Location = new System.Drawing.Point(27, 34);
            this.lblProdName2.Name = "lblProdName2";
            this.lblProdName2.Size = new System.Drawing.Size(78, 13);
            this.lblProdName2.TabIndex = 2;
            this.lblProdName2.Text = "Product Name:";
            // 
            // tabMainPage
            // 
            this.tabMainPage.AutoScroll = true;
            this.tabMainPage.Controls.Add(this.btnDeletepkg);
            this.tabMainPage.Controls.Add(this.gvSuppliers);
            this.tabMainPage.Controls.Add(this.gvProducts);
            this.tabMainPage.Controls.Add(this.gvPackages);
            this.tabMainPage.Controls.Add(this.btnEditSup);
            this.tabMainPage.Controls.Add(this.btnEditProd);
            this.tabMainPage.Controls.Add(this.btnAddSup);
            this.tabMainPage.Controls.Add(this.btnEditPkg);
            this.tabMainPage.Controls.Add(this.btnAddProd);
            this.tabMainPage.Controls.Add(this.btnAddPkg);
            this.tabMainPage.Location = new System.Drawing.Point(4, 22);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(1014, 400);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            this.tabMainPage.UseVisualStyleBackColor = true;
            // 
            // btnDeletepkg
            // 
            this.btnDeletepkg.Location = new System.Drawing.Point(430, 162);
            this.btnDeletepkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletepkg.Name = "btnDeletepkg";
            this.btnDeletepkg.Size = new System.Drawing.Size(87, 23);
            this.btnDeletepkg.TabIndex = 10;
            this.btnDeletepkg.Text = "Delete Package";
            this.btnDeletepkg.UseVisualStyleBackColor = true;
            this.btnDeletepkg.Click += new System.EventHandler(this.btnDeletepkg_Click);
            // 
            // gvSuppliers
            // 
            this.gvSuppliers.AutoGenerateColumns = false;
            this.gvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.dataGridViewTextBoxColumn11});
            this.gvSuppliers.DataSource = this.suppliersBindingSource;
            this.gvSuppliers.Location = new System.Drawing.Point(393, 191);
            this.gvSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.gvSuppliers.Name = "gvSuppliers";
            this.gvSuppliers.RowTemplate.Height = 24;
            this.gvSuppliers.Size = new System.Drawing.Size(238, 136);
            this.gvSuppliers.TabIndex = 9;
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "SupplierId";
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn11.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 79;
            // 
            // gvProducts
            // 
            this.gvProducts.AutoGenerateColumns = false;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.dataGridViewTextBoxColumn9});
            this.gvProducts.DataSource = this.productsBindingSource;
            this.gvProducts.Location = new System.Drawing.Point(6, 191);
            this.gvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.RowTemplate.Height = 24;
            this.gvProducts.Size = new System.Drawing.Size(327, 135);
            this.gvProducts.TabIndex = 9;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn9.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 82;
            // 
            // gvPackages
            // 
            this.gvPackages.AllowUserToAddRows = false;
            this.gvPackages.AutoGenerateColumns = false;
            this.gvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPackages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.gvPackages.DataSource = this.packagesBindingSource;
            this.gvPackages.Location = new System.Drawing.Point(5, 6);
            this.gvPackages.Margin = new System.Windows.Forms.Padding(2);
            this.gvPackages.MultiSelect = false;
            this.gvPackages.Name = "gvPackages";
            this.gvPackages.ReadOnly = true;
            this.gvPackages.RowTemplate.Height = 24;
            this.gvPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPackages.Size = new System.Drawing.Size(1006, 150);
            this.gvPackages.TabIndex = 8;
            this.gvPackages.SelectionChanged += new System.EventHandler(this.gvPackages_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackageId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Package Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Package Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 97;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Package Start Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Package End Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Package Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn6.HeaderText = "Package Base Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 96;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 115;
            // 
            // btnEditSup
            // 
            this.btnEditSup.Location = new System.Drawing.Point(547, 332);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(84, 23);
            this.btnEditSup.TabIndex = 1;
            this.btnEditSup.Text = "Edit Supplier";
            this.btnEditSup.UseVisualStyleBackColor = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(249, 331);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(84, 23);
            this.btnEditProd.TabIndex = 1;
            this.btnEditProd.Text = "Edit Product";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Location = new System.Drawing.Point(393, 332);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(84, 23);
            this.btnAddSup.TabIndex = 1;
            this.btnAddSup.Text = "Add Supplier";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // btnEditPkg
            // 
            this.btnEditPkg.Location = new System.Drawing.Point(926, 162);
            this.btnEditPkg.Name = "btnEditPkg";
            this.btnEditPkg.Size = new System.Drawing.Size(84, 23);
            this.btnEditPkg.TabIndex = 1;
            this.btnEditPkg.Text = "Edit Package";
            this.btnEditPkg.UseVisualStyleBackColor = true;
            this.btnEditPkg.Click += new System.EventHandler(this.btnEditPkg_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(6, 332);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(84, 23);
            this.btnAddProd.TabIndex = 1;
            this.btnAddProd.Text = "Add Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(6, 162);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(84, 23);
            this.btnAddPkg.TabIndex = 1;
            this.btnAddPkg.Text = "Add Package";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainPage);
            this.tabControl1.Controls.Add(this.tabPackages);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Controls.Add(this.tabProductSuppliers);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPackages
            // 
            this.tabPackages.AutoScroll = true;
            this.tabPackages.Controls.Add(this.btnDeletePkgProdSup_Click);
            this.tabPackages.Controls.Add(this.btnAddPkgProdSup);
            this.tabPackages.Controls.Add(this.gvProdSup_all_pkgs);
            this.tabPackages.Controls.Add(this.btnNewPkgProdSup);
            this.tabPackages.Controls.Add(this.gvProdSup_pkg);
            this.tabPackages.Controls.Add(this.lblPkgDescLength);
            this.tabPackages.Controls.Add(this.lblPkgNameLength);
            this.tabPackages.Controls.Add(this.btnAddEditPkg);
            this.tabPackages.Controls.Add(this.txtPkgDesc);
            this.tabPackages.Controls.Add(this.txtPkgAgencyCommission);
            this.tabPackages.Controls.Add(this.txtPkgBasePrice);
            this.tabPackages.Controls.Add(this.txtPackageName);
            this.tabPackages.Controls.Add(this.dtpPkgEndDate);
            this.tabPackages.Controls.Add(this.dtpPkgStartDate);
            this.tabPackages.Controls.Add(this.lblPkgEndDate);
            this.tabPackages.Controls.Add(this.lblPkgStartDate);
            this.tabPackages.Controls.Add(this.label1);
            this.tabPackages.Controls.Add(this.lblPkgAgencyCommission);
            this.tabPackages.Controls.Add(this.lblPkgBasePrice);
            this.tabPackages.Controls.Add(this.lblPkgName);
            this.tabPackages.Location = new System.Drawing.Point(4, 22);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPackages.Size = new System.Drawing.Size(1014, 400);
            this.tabPackages.TabIndex = 1;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
            // 
            // btnDeletePkgProdSup_Click
            // 
            this.btnDeletePkgProdSup_Click.Location = new System.Drawing.Point(689, 167);
            this.btnDeletePkgProdSup_Click.Name = "btnDeletePkgProdSup_Click";
            this.btnDeletePkgProdSup_Click.Size = new System.Drawing.Size(91, 23);
            this.btnDeletePkgProdSup_Click.TabIndex = 36;
            this.btnDeletePkgProdSup_Click.Text = "Delete Product";
            this.btnDeletePkgProdSup_Click.UseVisualStyleBackColor = true;
            this.btnDeletePkgProdSup_Click.Click += new System.EventHandler(this.btnDeletePkgProdSup_Click_Click);
            // 
            // btnAddPkgProdSup
            // 
            this.btnAddPkgProdSup.Location = new System.Drawing.Point(465, 365);
            this.btnAddPkgProdSup.Name = "btnAddPkgProdSup";
            this.btnAddPkgProdSup.Size = new System.Drawing.Size(75, 23);
            this.btnAddPkgProdSup.TabIndex = 35;
            this.btnAddPkgProdSup.Text = "Add New";
            this.btnAddPkgProdSup.UseVisualStyleBackColor = true;
            this.btnAddPkgProdSup.Click += new System.EventHandler(this.btnAddPkgProdSup_Click);
            // 
            // gvProdSup_all_pkgs
            // 
            this.gvProdSup_all_pkgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdSup_all_pkgs.Location = new System.Drawing.Point(465, 196);
            this.gvProdSup_all_pkgs.MultiSelect = false;
            this.gvProdSup_all_pkgs.Name = "gvProdSup_all_pkgs";
            this.gvProdSup_all_pkgs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProdSup_all_pkgs.Size = new System.Drawing.Size(543, 150);
            this.gvProdSup_all_pkgs.TabIndex = 34;
            this.gvProdSup_all_pkgs.Visible = false;
            // 
            // btnNewPkgProdSup
            // 
            this.btnNewPkgProdSup.Location = new System.Drawing.Point(465, 167);
            this.btnNewPkgProdSup.Name = "btnNewPkgProdSup";
            this.btnNewPkgProdSup.Size = new System.Drawing.Size(91, 23);
            this.btnNewPkgProdSup.TabIndex = 33;
            this.btnNewPkgProdSup.Text = "New Product";
            this.btnNewPkgProdSup.UseVisualStyleBackColor = true;
            this.btnNewPkgProdSup.Click += new System.EventHandler(this.btnUpdatePkgProdSup_Click);
            // 
            // gvProdSup_pkg
            // 
            this.gvProdSup_pkg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProdSup_pkg.Location = new System.Drawing.Point(465, 11);
            this.gvProdSup_pkg.Name = "gvProdSup_pkg";
            this.gvProdSup_pkg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProdSup_pkg.Size = new System.Drawing.Size(543, 150);
            this.gvProdSup_pkg.TabIndex = 32;
            // 
            // lblPkgDescLength
            // 
            this.lblPkgDescLength.AutoSize = true;
            this.lblPkgDescLength.Location = new System.Drawing.Point(351, 89);
            this.lblPkgDescLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgDescLength.Name = "lblPkgDescLength";
            this.lblPkgDescLength.Size = new System.Drawing.Size(0, 13);
            this.lblPkgDescLength.TabIndex = 27;
            // 
            // lblPkgNameLength
            // 
            this.lblPkgNameLength.AutoSize = true;
            this.lblPkgNameLength.Location = new System.Drawing.Point(351, 11);
            this.lblPkgNameLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPkgNameLength.Name = "lblPkgNameLength";
            this.lblPkgNameLength.Size = new System.Drawing.Size(0, 13);
            this.lblPkgNameLength.TabIndex = 26;
            // 
            // btnAddEditPkg
            // 
            this.btnAddEditPkg.Location = new System.Drawing.Point(214, 218);
            this.btnAddEditPkg.Name = "btnAddEditPkg";
            this.btnAddEditPkg.Size = new System.Drawing.Size(80, 23);
            this.btnAddEditPkg.TabIndex = 5;
            this.btnAddEditPkg.Text = "Add Package";
            this.btnAddEditPkg.UseVisualStyleBackColor = true;
            this.btnAddEditPkg.Click += new System.EventHandler(this.btnAddEditPkg_Click);
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(159, 89);
            this.txtPkgDesc.MaxLength = 50;
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(188, 72);
            this.txtPkgDesc.TabIndex = 3;
            this.txtPkgDesc.TextChanged += new System.EventHandler(this.txtPkgDesc_TextChanged);
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(159, 193);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(188, 20);
            this.txtPkgAgencyCommission.TabIndex = 0;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(159, 167);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(188, 20);
            this.txtPkgBasePrice.TabIndex = 0;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(159, 8);
            this.txtPackageName.MaxLength = 50;
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(188, 20);
            this.txtPackageName.TabIndex = 0;
            this.txtPackageName.TextChanged += new System.EventHandler(this.txtPackageName_TextChanged);
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Location = new System.Drawing.Point(159, 60);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(188, 20);
            this.dtpPkgEndDate.TabIndex = 2;
            this.dtpPkgEndDate.ValueChanged += new System.EventHandler(this.dtpPkgEndDate_ValueChanged);
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Location = new System.Drawing.Point(159, 34);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(188, 20);
            this.dtpPkgStartDate.TabIndex = 2;
            this.dtpPkgStartDate.ValueChanged += new System.EventHandler(this.dtpPkgStartDate_ValueChanged);
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Location = new System.Drawing.Point(6, 66);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(101, 13);
            this.lblPkgEndDate.TabIndex = 1;
            this.lblPkgEndDate.Text = "Package End Date:";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(6, 40);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(104, 13);
            this.lblPkgStartDate.TabIndex = 1;
            this.lblPkgStartDate.Text = "Package Start Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package Description:";
            // 
            // lblPkgAgencyCommission
            // 
            this.lblPkgAgencyCommission.AutoSize = true;
            this.lblPkgAgencyCommission.Location = new System.Drawing.Point(6, 196);
            this.lblPkgAgencyCommission.Name = "lblPkgAgencyCommission";
            this.lblPkgAgencyCommission.Size = new System.Drawing.Size(145, 13);
            this.lblPkgAgencyCommission.TabIndex = 1;
            this.lblPkgAgencyCommission.Text = "Package Agency Commision:";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(6, 170);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(107, 13);
            this.lblPkgBasePrice.TabIndex = 1;
            this.lblPkgBasePrice.Text = "Package Base Price:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(6, 11);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(84, 13);
            this.lblPkgName.TabIndex = 1;
            this.lblPkgName.Text = "Package Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 453);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Travel Experts Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).EndInit();
            this.tabProductSuppliers.ResumeLayout(false);
            this.tabProductSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers_pkgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts_pkgs)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers2)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts1)).EndInit();
            this.tabMainPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackages)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_all_pkgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_pkg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TravelExpertsDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.BindingSource products_SuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter products_SuppliersTableAdapter;
        private System.Windows.Forms.BindingSource packagesProductsSuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Packages_Products_SuppliersTableAdapter packages_Products_SuppliersTableAdapter;
        private System.Windows.Forms.TabPage tabProductSuppliers;
        private System.Windows.Forms.Button btnSaveSupPkg;
        private System.Windows.Forms.Button btnSaveProdPkg;
        private System.Windows.Forms.Button btnSave_Prod_Sup_pkg;
        private System.Windows.Forms.Button btnChangeProd;
        private System.Windows.Forms.ComboBox cmbSupName;
        private System.Windows.Forms.Button btnDelSup_pkg;
        private System.Windows.Forms.Button btnDelProd_pkg;
        private System.Windows.Forms.Button btnChangeSup;
        private System.Windows.Forms.Button btnAddSup_pkg;
        private System.Windows.Forms.Button btnAddProd_pkg;
        private System.Windows.Forms.DataGridView gvSuppliers_pkgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridView gvProducts_pkgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.DataGridView gvProducts2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridView gvSuppliers2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button btnAddEditSup;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblSupName2;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.DataGridView gvSuppliers1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gvProducts1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddEditProd;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName2;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.Button btnDeletepkg;
        private System.Windows.Forms.DataGridView gvSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridView gvPackages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.Button btnEditPkg;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.DataGridView gvProdSup_pkg;
        private System.Windows.Forms.Label lblPkgDescLength;
        private System.Windows.Forms.Label lblPkgNameLength;
        private System.Windows.Forms.Button btnAddEditPkg;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPkgAgencyCommission;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.Button btnNewPkgProdSup;
        private System.Windows.Forms.DataGridView gvProdSup_all_pkgs;
        private System.Windows.Forms.Button btnAddPkgProdSup;
        private System.Windows.Forms.Button btnDeletePkgProdSup_Click;
        private System.Windows.Forms.Button btnAddNewProd;
        private System.Windows.Forms.Button btnEditP;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.Button btnDelSup;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.Button btnEditS;
        private System.Windows.Forms.Button btnNewS;
    }
}


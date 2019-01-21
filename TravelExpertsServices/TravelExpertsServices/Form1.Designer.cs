namespace TravelExpertsServices
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.gvSuppliers = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelExpertsDataSet = new TravelExpertsServices.TravelExpertsDataSet();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPackages = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditSup = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.btnEditPkg = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.btnChangeProd = new System.Windows.Forms.Button();
            this.cmbSupName = new System.Windows.Forms.ComboBox();
            this.btnDelSup_pkg = new System.Windows.Forms.Button();
            this.btnDelProd_pkg = new System.Windows.Forms.Button();
            this.btnChangeSup = new System.Windows.Forms.Button();
            this.btnAddSup_pkg = new System.Windows.Forms.Button();
            this.btnAddProd_pkg = new System.Windows.Forms.Button();
            this.gvSuppliers_pkgs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvProducts_pkgs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEditPkg = new System.Windows.Forms.Button();
            this.cmbProdName = new System.Windows.Forms.ComboBox();
            this.txtPkgDesc = new System.Windows.Forms.TextBox();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblPkgEndDate = new System.Windows.Forms.Label();
            this.lblPkgStartDate = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblPkgAgencyCommission = new System.Windows.Forms.Label();
            this.lblPkgBasePrice = new System.Windows.Forms.Label();
            this.lblPkgName = new System.Windows.Forms.Label();
            this.txtPkgAgencyCommission = new System.Windows.Forms.TextBox();
            this.txtPkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.grSuppliers1 = new System.Windows.Forms.DataGridView();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grProducts1 = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEditProd = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName2 = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.gvProducts2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvSuppliers2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddEditSup = new System.Windows.Forms.Button();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.lblSupName2 = new System.Windows.Forms.Label();
            this.products_SuppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.suppliersTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.SuppliersTableAdapter();
            this.products_SuppliersTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            this.tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers_pkgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts_pkgs)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSuppliers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grProducts1)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainPage);
            this.tabControl1.Controls.Add(this.tabPackages);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Location = new System.Drawing.Point(16, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1363, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMainPage
            // 
            this.tabMainPage.AutoScroll = true;
            this.tabMainPage.Controls.Add(this.gvSuppliers);
            this.tabMainPage.Controls.Add(this.gvProducts);
            this.tabMainPage.Controls.Add(this.gvPackages);
            this.tabMainPage.Controls.Add(this.btnEditSup);
            this.tabMainPage.Controls.Add(this.btnEditProd);
            this.tabMainPage.Controls.Add(this.btnAddSup);
            this.tabMainPage.Controls.Add(this.btnEditPkg);
            this.tabMainPage.Controls.Add(this.btnAddProd);
            this.tabMainPage.Controls.Add(this.btnAddPkg);
            this.tabMainPage.Location = new System.Drawing.Point(4, 25);
            this.tabMainPage.Margin = new System.Windows.Forms.Padding(4);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(4);
            this.tabMainPage.Size = new System.Drawing.Size(1355, 495);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            this.tabMainPage.UseVisualStyleBackColor = true;
            // 
            // gvSuppliers
            // 
            this.gvSuppliers.AutoGenerateColumns = false;
            this.gvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.dataGridViewTextBoxColumn11});
            this.gvSuppliers.DataSource = this.suppliersBindingSource;
            this.gvSuppliers.Location = new System.Drawing.Point(524, 235);
            this.gvSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvSuppliers.Name = "gvSuppliers";
            this.gvSuppliers.RowTemplate.Height = 24;
            this.gvSuppliers.Size = new System.Drawing.Size(317, 167);
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
            this.dataGridViewTextBoxColumn11.Width = 99;
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
            // gvProducts
            // 
            this.gvProducts.AutoGenerateColumns = false;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.dataGridViewTextBoxColumn9});
            this.gvProducts.DataSource = this.productsBindingSource;
            this.gvProducts.Location = new System.Drawing.Point(8, 235);
            this.gvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.RowTemplate.Height = 24;
            this.gvProducts.Size = new System.Drawing.Size(436, 166);
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
            this.dataGridViewTextBoxColumn9.Width = 104;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // gvPackages
            // 
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
            this.gvPackages.Location = new System.Drawing.Point(7, 7);
            this.gvPackages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvPackages.Name = "gvPackages";
            this.gvPackages.ReadOnly = true;
            this.gvPackages.RowTemplate.Height = 24;
            this.gvPackages.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPackages.Size = new System.Drawing.Size(1341, 185);
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
            this.dataGridViewTextBoxColumn2.Width = 122;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Package Start Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 119;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Package End Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Package Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 153;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Package Base Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 121;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 149;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // btnEditSup
            // 
            this.btnEditSup.Location = new System.Drawing.Point(729, 409);
            this.btnEditSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(112, 28);
            this.btnEditSup.TabIndex = 1;
            this.btnEditSup.Text = "Edit Supplier";
            this.btnEditSup.UseVisualStyleBackColor = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(332, 407);
            this.btnEditProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(112, 28);
            this.btnEditProd.TabIndex = 1;
            this.btnEditProd.Text = "Edit Product";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Location = new System.Drawing.Point(524, 409);
            this.btnAddSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(112, 28);
            this.btnAddSup.TabIndex = 1;
            this.btnAddSup.Text = "Add Supplier";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // btnEditPkg
            // 
            this.btnEditPkg.Location = new System.Drawing.Point(1235, 199);
            this.btnEditPkg.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditPkg.Name = "btnEditPkg";
            this.btnEditPkg.Size = new System.Drawing.Size(112, 28);
            this.btnEditPkg.TabIndex = 1;
            this.btnEditPkg.Text = "Edit Package";
            this.btnEditPkg.UseVisualStyleBackColor = true;
            this.btnEditPkg.Click += new System.EventHandler(this.btnEditPkg_Click);
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(8, 409);
            this.btnAddProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(112, 28);
            this.btnAddProd.TabIndex = 1;
            this.btnAddProd.Text = "Add Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(8, 199);
            this.btnAddPkg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(112, 28);
            this.btnAddPkg.TabIndex = 1;
            this.btnAddPkg.Text = "Add Package";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // tabPackages
            // 
            this.tabPackages.AutoScroll = true;
            this.tabPackages.Controls.Add(this.btnChangeProd);
            this.tabPackages.Controls.Add(this.cmbSupName);
            this.tabPackages.Controls.Add(this.btnDelSup_pkg);
            this.tabPackages.Controls.Add(this.btnDelProd_pkg);
            this.tabPackages.Controls.Add(this.btnChangeSup);
            this.tabPackages.Controls.Add(this.btnAddSup_pkg);
            this.tabPackages.Controls.Add(this.btnAddProd_pkg);
            this.tabPackages.Controls.Add(this.gvSuppliers_pkgs);
            this.tabPackages.Controls.Add(this.gvProducts_pkgs);
            this.tabPackages.Controls.Add(this.btnAddEditPkg);
            this.tabPackages.Controls.Add(this.cmbProdName);
            this.tabPackages.Controls.Add(this.txtPkgDesc);
            this.tabPackages.Controls.Add(this.dtpPkgEndDate);
            this.tabPackages.Controls.Add(this.dtpPkgStartDate);
            this.tabPackages.Controls.Add(this.lblPkgEndDate);
            this.tabPackages.Controls.Add(this.lblPkgStartDate);
            this.tabPackages.Controls.Add(this.lblSupName);
            this.tabPackages.Controls.Add(this.label1);
            this.tabPackages.Controls.Add(this.lblProdName);
            this.tabPackages.Controls.Add(this.lblPkgAgencyCommission);
            this.tabPackages.Controls.Add(this.lblPkgBasePrice);
            this.tabPackages.Controls.Add(this.lblPkgName);
            this.tabPackages.Controls.Add(this.txtPkgAgencyCommission);
            this.tabPackages.Controls.Add(this.txtPkgBasePrice);
            this.tabPackages.Controls.Add(this.txtPackageName);
            this.tabPackages.Location = new System.Drawing.Point(4, 25);
            this.tabPackages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(4);
            this.tabPackages.Size = new System.Drawing.Size(1355, 495);
            this.tabPackages.TabIndex = 1;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
            // 
            // btnChangeProd
            // 
            this.btnChangeProd.Location = new System.Drawing.Point(937, 177);
            this.btnChangeProd.Name = "btnChangeProd";
            this.btnChangeProd.Size = new System.Drawing.Size(128, 28);
            this.btnChangeProd.TabIndex = 25;
            this.btnChangeProd.Text = "Change Product";
            this.btnChangeProd.UseVisualStyleBackColor = true;
            this.btnChangeProd.Click += new System.EventHandler(this.btnChangeProd_Click);
            // 
            // cmbSupName
            // 
            this.cmbSupName.DataSource = this.suppliersBindingSource;
            this.cmbSupName.DisplayMember = "SupName";
            this.cmbSupName.Enabled = false;
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(212, 303);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(249, 24);
            this.cmbSupName.TabIndex = 24;
            this.cmbSupName.ValueMember = "SupplierId";
            // 
            // btnDelSup_pkg
            // 
            this.btnDelSup_pkg.Location = new System.Drawing.Point(1071, 394);
            this.btnDelSup_pkg.Name = "btnDelSup_pkg";
            this.btnDelSup_pkg.Size = new System.Drawing.Size(116, 28);
            this.btnDelSup_pkg.TabIndex = 12;
            this.btnDelSup_pkg.Text = "Delete Supplier";
            this.btnDelSup_pkg.UseVisualStyleBackColor = true;
            this.btnDelSup_pkg.Click += new System.EventHandler(this.btnDelSup_pkg_Click);
            // 
            // btnDelProd_pkg
            // 
            this.btnDelProd_pkg.Location = new System.Drawing.Point(1071, 177);
            this.btnDelProd_pkg.Name = "btnDelProd_pkg";
            this.btnDelProd_pkg.Size = new System.Drawing.Size(116, 28);
            this.btnDelProd_pkg.TabIndex = 12;
            this.btnDelProd_pkg.Text = "Delete Product";
            this.btnDelProd_pkg.UseVisualStyleBackColor = true;
            this.btnDelProd_pkg.Click += new System.EventHandler(this.btnDelProd_pkg_Click);
            // 
            // btnChangeSup
            // 
            this.btnChangeSup.Location = new System.Drawing.Point(937, 394);
            this.btnChangeSup.Name = "btnChangeSup";
            this.btnChangeSup.Size = new System.Drawing.Size(128, 28);
            this.btnChangeSup.TabIndex = 12;
            this.btnChangeSup.Text = "Change Supplier";
            this.btnChangeSup.UseVisualStyleBackColor = true;
            this.btnChangeSup.Click += new System.EventHandler(this.btnChangeSup_Click);
            // 
            // btnAddSup_pkg
            // 
            this.btnAddSup_pkg.Location = new System.Drawing.Point(815, 394);
            this.btnAddSup_pkg.Name = "btnAddSup_pkg";
            this.btnAddSup_pkg.Size = new System.Drawing.Size(116, 28);
            this.btnAddSup_pkg.TabIndex = 12;
            this.btnAddSup_pkg.Text = "Add Suppplier";
            this.btnAddSup_pkg.UseVisualStyleBackColor = true;
            this.btnAddSup_pkg.Click += new System.EventHandler(this.btnAddSup_pkg_Click);
            // 
            // btnAddProd_pkg
            // 
            this.btnAddProd_pkg.Location = new System.Drawing.Point(815, 177);
            this.btnAddProd_pkg.Name = "btnAddProd_pkg";
            this.btnAddProd_pkg.Size = new System.Drawing.Size(116, 28);
            this.btnAddProd_pkg.TabIndex = 12;
            this.btnAddProd_pkg.Text = "Add Product";
            this.btnAddProd_pkg.UseVisualStyleBackColor = true;
            this.btnAddProd_pkg.Click += new System.EventHandler(this.btnAddProd_pkg_Click);
            // 
            // gvSuppliers_pkgs
            // 
            this.gvSuppliers_pkgs.AutoGenerateColumns = false;
            this.gvSuppliers_pkgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers_pkgs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.gvSuppliers_pkgs.DataSource = this.suppliersBindingSource;
            this.gvSuppliers_pkgs.Location = new System.Drawing.Point(815, 223);
            this.gvSuppliers_pkgs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvSuppliers_pkgs.Name = "gvSuppliers_pkgs";
            this.gvSuppliers_pkgs.RowTemplate.Height = 24;
            this.gvSuppliers_pkgs.Size = new System.Drawing.Size(372, 166);
            this.gvSuppliers_pkgs.TabIndex = 10;
            this.gvSuppliers_pkgs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvSuppliers_pkgs_DataError);
            this.gvSuppliers_pkgs.SelectionChanged += new System.EventHandler(this.gvSuppliers_pkgs_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn14.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn14.Width = 130;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn15.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // gvProducts_pkgs
            // 
            this.gvProducts_pkgs.AutoGenerateColumns = false;
            this.gvProducts_pkgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts_pkgs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn16});
            this.gvProducts_pkgs.DataSource = this.productsBindingSource;
            this.gvProducts_pkgs.Location = new System.Drawing.Point(815, 6);
            this.gvProducts_pkgs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvProducts_pkgs.Name = "gvProducts_pkgs";
            this.gvProducts_pkgs.RowTemplate.Height = 24;
            this.gvProducts_pkgs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts_pkgs.Size = new System.Drawing.Size(372, 166);
            this.gvProducts_pkgs.TabIndex = 11;
            this.gvProducts_pkgs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gvProducts_pkgs_DataError);
            this.gvProducts_pkgs.SelectionChanged += new System.EventHandler(this.gvProducts_pkgs_SelectionChanged);
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
            this.dataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn16.Width = 127;
            // 
            // btnAddEditPkg
            // 
            this.btnAddEditPkg.Location = new System.Drawing.Point(173, 361);
            this.btnAddEditPkg.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEditPkg.Name = "btnAddEditPkg";
            this.btnAddEditPkg.Size = new System.Drawing.Size(107, 28);
            this.btnAddEditPkg.TabIndex = 5;
            this.btnAddEditPkg.Text = "Add Package";
            this.btnAddEditPkg.UseVisualStyleBackColor = true;
            this.btnAddEditPkg.Click += new System.EventHandler(this.btnAddEditPkg_Click);
            // 
            // cmbProdName
            // 
            this.cmbProdName.DataSource = this.productsBindingSource;
            this.cmbProdName.DisplayMember = "ProdName";
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(212, 270);
            this.cmbProdName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(249, 24);
            this.cmbProdName.TabIndex = 4;
            this.cmbProdName.ValueMember = "ProductId";
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(212, 110);
            this.txtPkgDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(249, 88);
            this.txtPkgDesc.TabIndex = 3;
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Location = new System.Drawing.Point(212, 74);
            this.dtpPkgEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(249, 22);
            this.dtpPkgEndDate.TabIndex = 2;
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Location = new System.Drawing.Point(212, 42);
            this.dtpPkgStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(249, 22);
            this.dtpPkgStartDate.TabIndex = 2;
            // 
            // lblPkgEndDate
            // 
            this.lblPkgEndDate.AutoSize = true;
            this.lblPkgEndDate.Location = new System.Drawing.Point(8, 81);
            this.lblPkgEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgEndDate.Name = "lblPkgEndDate";
            this.lblPkgEndDate.Size = new System.Drawing.Size(130, 17);
            this.lblPkgEndDate.TabIndex = 1;
            this.lblPkgEndDate.Text = "Package End Date:";
            // 
            // lblPkgStartDate
            // 
            this.lblPkgStartDate.AutoSize = true;
            this.lblPkgStartDate.Location = new System.Drawing.Point(8, 49);
            this.lblPkgStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgStartDate.Name = "lblPkgStartDate";
            this.lblPkgStartDate.Size = new System.Drawing.Size(135, 17);
            this.lblPkgStartDate.TabIndex = 1;
            this.lblPkgStartDate.Text = "Package Start Date:";
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(8, 306);
            this.lblSupName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(105, 17);
            this.lblSupName.TabIndex = 1;
            this.lblSupName.Text = "Supplier Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package Description:";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(8, 273);
            this.lblProdName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(102, 17);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "Product Name:";
            // 
            // lblPkgAgencyCommission
            // 
            this.lblPkgAgencyCommission.AutoSize = true;
            this.lblPkgAgencyCommission.Location = new System.Drawing.Point(8, 241);
            this.lblPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgAgencyCommission.Name = "lblPkgAgencyCommission";
            this.lblPkgAgencyCommission.Size = new System.Drawing.Size(190, 17);
            this.lblPkgAgencyCommission.TabIndex = 1;
            this.lblPkgAgencyCommission.Text = "Package Agency Commision:";
            // 
            // lblPkgBasePrice
            // 
            this.lblPkgBasePrice.AutoSize = true;
            this.lblPkgBasePrice.Location = new System.Drawing.Point(8, 209);
            this.lblPkgBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgBasePrice.Name = "lblPkgBasePrice";
            this.lblPkgBasePrice.Size = new System.Drawing.Size(139, 17);
            this.lblPkgBasePrice.TabIndex = 1;
            this.lblPkgBasePrice.Text = "Package Base Price:";
            // 
            // lblPkgName
            // 
            this.lblPkgName.AutoSize = true;
            this.lblPkgName.Location = new System.Drawing.Point(8, 14);
            this.lblPkgName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPkgName.Name = "lblPkgName";
            this.lblPkgName.Size = new System.Drawing.Size(108, 17);
            this.lblPkgName.TabIndex = 1;
            this.lblPkgName.Text = "Package Name:";
            // 
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(212, 238);
            this.txtPkgAgencyCommission.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(249, 22);
            this.txtPkgAgencyCommission.TabIndex = 0;
            // 
            // txtPkgBasePrice
            // 
            this.txtPkgBasePrice.Location = new System.Drawing.Point(212, 206);
            this.txtPkgBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(249, 22);
            this.txtPkgBasePrice.TabIndex = 0;
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(212, 10);
            this.txtPackageName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(249, 22);
            this.txtPackageName.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.grSuppliers1);
            this.tabProduct.Controls.Add(this.grProducts1);
            this.tabProduct.Controls.Add(this.btnAddEditProd);
            this.tabProduct.Controls.Add(this.txtProdName);
            this.tabProduct.Controls.Add(this.lblProdName2);
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(4);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(1355, 495);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // grSuppliers1
            // 
            this.grSuppliers1.AutoGenerateColumns = false;
            this.grSuppliers1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grSuppliers1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIdDataGridViewTextBoxColumn,
            this.supNameDataGridViewTextBoxColumn});
            this.grSuppliers1.DataSource = this.suppliersBindingSource;
            this.grSuppliers1.Location = new System.Drawing.Point(427, 119);
            this.grSuppliers1.Margin = new System.Windows.Forms.Padding(4);
            this.grSuppliers1.Name = "grSuppliers1";
            this.grSuppliers1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grSuppliers1.Size = new System.Drawing.Size(400, 271);
            this.grSuppliers1.TabIndex = 4;
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "SupplierId";
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            // 
            // supNameDataGridViewTextBoxColumn
            // 
            this.supNameDataGridViewTextBoxColumn.DataPropertyName = "SupName";
            this.supNameDataGridViewTextBoxColumn.HeaderText = "SupName";
            this.supNameDataGridViewTextBoxColumn.Name = "supNameDataGridViewTextBoxColumn";
            // 
            // grProducts1
            // 
            this.grProducts1.AutoGenerateColumns = false;
            this.grProducts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grProducts1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn});
            this.grProducts1.DataSource = this.productsBindingSource;
            this.grProducts1.Location = new System.Drawing.Point(40, 119);
            this.grProducts1.Margin = new System.Windows.Forms.Padding(4);
            this.grProducts1.Name = "grProducts1";
            this.grProducts1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grProducts1.Size = new System.Drawing.Size(355, 271);
            this.grProducts1.TabIndex = 4;
            this.grProducts1.SelectionChanged += new System.EventHandler(this.grProducts1_SelectionChanged);
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
            // 
            // btnAddEditProd
            // 
            this.btnAddEditProd.Location = new System.Drawing.Point(63, 55);
            this.btnAddEditProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEditProd.Name = "btnAddEditProd";
            this.btnAddEditProd.Size = new System.Drawing.Size(100, 28);
            this.btnAddEditProd.TabIndex = 4;
            this.btnAddEditProd.Text = "Add Product";
            this.btnAddEditProd.UseVisualStyleBackColor = true;
            this.btnAddEditProd.Click += new System.EventHandler(this.btnAddEditProd_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(116, 7);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(132, 22);
            this.txtProdName.TabIndex = 3;
            // 
            // lblProdName2
            // 
            this.lblProdName2.AutoSize = true;
            this.lblProdName2.Location = new System.Drawing.Point(4, 11);
            this.lblProdName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdName2.Name = "lblProdName2";
            this.lblProdName2.Size = new System.Drawing.Size(102, 17);
            this.lblProdName2.TabIndex = 2;
            this.lblProdName2.Text = "Product Name:";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.gvProducts2);
            this.tabSuppliers.Controls.Add(this.gvSuppliers2);
            this.tabSuppliers.Controls.Add(this.btnAddEditSup);
            this.tabSuppliers.Controls.Add(this.txtSupName);
            this.tabSuppliers.Controls.Add(this.lblSupName2);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1355, 495);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // gvProducts2
            // 
            this.gvProducts2.AutoGenerateColumns = false;
            this.gvProducts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProducts2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.gvProducts2.DataSource = this.productsBindingSource;
            this.gvProducts2.Location = new System.Drawing.Point(712, 127);
            this.gvProducts2.Margin = new System.Windows.Forms.Padding(4);
            this.gvProducts2.Name = "gvProducts2";
            this.gvProducts2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts2.Size = new System.Drawing.Size(400, 271);
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
            // 
            // gvSuppliers2
            // 
            this.gvSuppliers2.AutoGenerateColumns = false;
            this.gvSuppliers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSuppliers2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10});
            this.gvSuppliers2.DataSource = this.suppliersBindingSource;
            this.gvSuppliers2.Location = new System.Drawing.Point(81, 127);
            this.gvSuppliers2.Margin = new System.Windows.Forms.Padding(4);
            this.gvSuppliers2.Name = "gvSuppliers2";
            this.gvSuppliers2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSuppliers2.Size = new System.Drawing.Size(400, 271);
            this.gvSuppliers2.TabIndex = 6;
            this.gvSuppliers2.SelectionChanged += new System.EventHandler(this.gvSuppliers2_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SupplierId";
            this.dataGridViewTextBoxColumn8.HeaderText = "SupplierId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn10.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // btnAddEditSup
            // 
            this.btnAddEditSup.Location = new System.Drawing.Point(63, 55);
            this.btnAddEditSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEditSup.Name = "btnAddEditSup";
            this.btnAddEditSup.Size = new System.Drawing.Size(100, 28);
            this.btnAddEditSup.TabIndex = 6;
            this.btnAddEditSup.Text = "Add Supplier";
            this.btnAddEditSup.UseVisualStyleBackColor = true;
            this.btnAddEditSup.Click += new System.EventHandler(this.btnAddEditSup_Click);
            // 
            // txtSupName
            // 
            this.txtSupName.Location = new System.Drawing.Point(116, 9);
            this.txtSupName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(132, 22);
            this.txtSupName.TabIndex = 5;
            // 
            // lblSupName2
            // 
            this.lblSupName2.AutoSize = true;
            this.lblSupName2.Location = new System.Drawing.Point(4, 12);
            this.lblSupName2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupName2.Name = "lblSupName2";
            this.lblSupName2.Size = new System.Drawing.Size(105, 17);
            this.lblSupName2.TabIndex = 4;
            this.lblSupName2.Text = "Supplier Name:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 558);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Travel Experts Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers_pkgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts_pkgs)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grSuppliers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grProducts1)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblPkgAgencyCommission;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.TextBox txtPkgBasePrice;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName2;
        private System.Windows.Forms.Button btnAddEditProd;
        private System.Windows.Forms.Button btnAddEditSup;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblSupName2;
        private System.Windows.Forms.Button btnAddEditPkg;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Button btnEditPkg;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnAddSup;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gvPackages;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridView gvProducts;
        private TravelExpertsDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.DataGridView gvSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private System.Windows.Forms.DataGridView grSuppliers1;
        private System.Windows.Forms.DataGridView grProducts1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView gvProducts2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridView gvSuppliers2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridView gvSuppliers_pkgs;
        private System.Windows.Forms.DataGridView gvProducts_pkgs;
        private System.Windows.Forms.Button btnDelProd_pkg;
        private System.Windows.Forms.Button btnAddProd_pkg;
        private System.Windows.Forms.Button btnDelSup_pkg;
        private System.Windows.Forms.Button btnAddSup_pkg;
        private System.Windows.Forms.BindingSource products_SuppliersBindingSource;
        private TravelExpertsDataSetTableAdapters.Products_SuppliersTableAdapter products_SuppliersTableAdapter;
        private System.Windows.Forms.ComboBox cmbSupName;
        private System.Windows.Forms.Button btnChangeSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Button btnChangeProd;
    }
}


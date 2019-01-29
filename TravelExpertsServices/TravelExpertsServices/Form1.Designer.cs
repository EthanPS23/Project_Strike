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

            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();

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
            this.travelExpertsDataSet1 = new TravelExpertsServices.TravelExpertsDataSet();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.btnClearS = new System.Windows.Forms.Button();
            this.btnDelSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.btnShowSP = new System.Windows.Forms.Button();
            this.gvProdBySup = new System.Windows.Forms.DataGridView();
            this.btnDelSup = new System.Windows.Forms.Button();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.btnEditS = new System.Windows.Forms.Button();
            this.btnNewS = new System.Windows.Forms.Button();
            this.gvProducts2 = new System.Windows.Forms.DataGridView();
            this.gvSuppliers2 = new System.Windows.Forms.DataGridView();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.lblSupName2 = new System.Windows.Forms.Label();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.btnClearP = new System.Windows.Forms.Button();
            this.btnDelPS = new System.Windows.Forms.Button();
            this.btnAddPS = new System.Windows.Forms.Button();
            this.btnShowPS = new System.Windows.Forms.Button();
            this.gvSupByProd = new System.Windows.Forms.DataGridView();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnSaveP = new System.Windows.Forms.Button();
            this.btnEditP = new System.Windows.Forms.Button();
            this.btnAddNewProd = new System.Windows.Forms.Button();
            this.gvSuppliers1 = new System.Windows.Forms.DataGridView();
            this.gvProducts1 = new System.Windows.Forms.DataGridView();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName2 = new System.Windows.Forms.Label();
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
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.btnDeletepkg = new System.Windows.Forms.Button();
            this.gvSuppliers = new System.Windows.Forms.DataGridView();
            this.gvProducts = new System.Windows.Forms.DataGridView();
            this.gvPackages = new System.Windows.Forms.DataGridView();
            this.btnEditPkg = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).BeginInit();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdBySup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers2)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupByProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts1)).BeginInit();
            this.tabPackages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_all_pkgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_pkg)).BeginInit();
            this.tabMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackages)).BeginInit();
            this.tabControl1.SuspendLayout();
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
            // travelExpertsDataSet1
            //
            this.travelExpertsDataSet1.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //
            // tabSuppliers
            //
            this.tabSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.tabSuppliers.Controls.Add(this.btnClearS);
            this.tabSuppliers.Controls.Add(this.btnDelSP);
            this.tabSuppliers.Controls.Add(this.btnAddSP);
            this.tabSuppliers.Controls.Add(this.btnShowSP);
            this.tabSuppliers.Controls.Add(this.gvProdBySup);
            this.tabSuppliers.Controls.Add(this.btnDelSup);
            this.tabSuppliers.Controls.Add(this.btnSaveS);
            this.tabSuppliers.Controls.Add(this.btnEditS);
            this.tabSuppliers.Controls.Add(this.btnNewS);
            this.tabSuppliers.Controls.Add(this.gvProducts2);
            this.tabSuppliers.Controls.Add(this.gvSuppliers2);
            this.tabSuppliers.Controls.Add(this.txtSupName);
            this.tabSuppliers.Controls.Add(this.lblSupName2);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(1036, 427);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Suppliers";
            //
            // btnClearS
            //
            this.btnClearS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnClearS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearS.Location = new System.Drawing.Point(252, 15);
            this.btnClearS.Name = "btnClearS";
            this.btnClearS.Size = new System.Drawing.Size(75, 23);
            this.btnClearS.TabIndex = 18;
            this.btnClearS.Text = "&Clear";
            this.btnClearS.UseVisualStyleBackColor = false;
            this.btnClearS.Click += new System.EventHandler(this.btnClearS_Click);
            //
            // btnDelSP
            //
            this.btnDelSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnDelSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSP.Location = new System.Drawing.Point(679, 110);
            this.btnDelSP.Name = "btnDelSP";
            this.btnDelSP.Size = new System.Drawing.Size(34, 23);
            this.btnDelSP.TabIndex = 17;
            this.btnDelSP.Text = ">>";
            this.btnDelSP.UseVisualStyleBackColor = false;
            this.btnDelSP.Click += new System.EventHandler(this.btnDelSP_Click);
            //
            // btnAddSP
            //
            this.btnAddSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnAddSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSP.Location = new System.Drawing.Point(679, 177);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(34, 23);
            this.btnAddSP.TabIndex = 16;
            this.btnAddSP.Text = "<<";
            this.btnAddSP.UseVisualStyleBackColor = false;
            this.btnAddSP.Click += new System.EventHandler(this.btnAddSP_Click);
            //
            // btnShowSP
            //
            this.btnShowSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnShowSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowSP.Location = new System.Drawing.Point(491, 277);
            this.btnShowSP.Name = "btnShowSP";
            this.btnShowSP.Size = new System.Drawing.Size(75, 23);
            this.btnShowSP.TabIndex = 14;
            this.btnShowSP.Text = "Show";
            this.btnShowSP.UseVisualStyleBackColor = false;
            this.btnShowSP.Click += new System.EventHandler(this.btnShowSP_Click);
            //
            // gvProdBySup
            //
            this.gvProdBySup.AllowUserToAddRows = false;
            this.gvProdBySup.AllowUserToDeleteRows = false;
            this.gvProdBySup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvProdBySup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProdBySup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProdBySup.DefaultCellStyle = dataGridViewCellStyle1;

            this.gvProdBySup.Location = new System.Drawing.Point(726, 51);
            this.gvProdBySup.Name = "gvProdBySup";
            this.gvProdBySup.ReadOnly = true;
            this.gvProdBySup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProdBySup.Size = new System.Drawing.Size(254, 220);
            this.gvProdBySup.TabIndex = 13;
            //
            // btnDelSup
            //
            this.btnDelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnDelSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelSup.Location = new System.Drawing.Point(239, 279);
            this.btnDelSup.Name = "btnDelSup";
            this.btnDelSup.Size = new System.Drawing.Size(107, 23);
            this.btnDelSup.TabIndex = 12;
            this.btnDelSup.Text = "&Delete Product";
            this.btnDelSup.UseVisualStyleBackColor = false;
            this.btnDelSup.Click += new System.EventHandler(this.btnDelSup_Click);
            //
            // btnSaveS
            //
            this.btnSaveS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnSaveS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveS.Location = new System.Drawing.Point(141, 327);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(75, 23);
            this.btnSaveS.TabIndex = 11;
            this.btnSaveS.Text = "&Save";
            this.btnSaveS.UseVisualStyleBackColor = false;
            this.btnSaveS.Click += new System.EventHandler(this.btnSaveS_Click);
            //
            // btnEditS
            //
            this.btnEditS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnEditS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditS.Location = new System.Drawing.Point(141, 279);
            this.btnEditS.Name = "btnEditS";
            this.btnEditS.Size = new System.Drawing.Size(75, 23);
            this.btnEditS.TabIndex = 10;
            this.btnEditS.Text = "&Edit Supplier";
            this.btnEditS.UseVisualStyleBackColor = false;
            this.btnEditS.Click += new System.EventHandler(this.btnEditS_Click);
            //
            // btnNewS
            //
            this.btnNewS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnNewS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewS.Location = new System.Drawing.Point(13, 279);
            this.btnNewS.Name = "btnNewS";
            this.btnNewS.Size = new System.Drawing.Size(105, 23);
            this.btnNewS.TabIndex = 9;
            this.btnNewS.Text = "&Add New Supplier";
            this.btnNewS.UseVisualStyleBackColor = false;
            this.btnNewS.Click += new System.EventHandler(this.btnNewS_Click);
            //
            // gvProducts2
            //
            this.gvProducts2.AllowUserToAddRows = false;
            this.gvProducts2.AllowUserToDeleteRows = false;
            this.gvProducts2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvProducts2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProducts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            this.gvProducts2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.gvProducts2.Location = new System.Drawing.Point(372, 51);
            this.gvProducts2.MultiSelect = false;
            this.gvProducts2.Name = "gvProducts2";
            this.gvProducts2.ReadOnly = true;
            this.gvProducts2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts2.Size = new System.Drawing.Size(300, 220);
            this.gvProducts2.TabIndex = 6;
            //
            // gvSuppliers2
            //
            this.gvSuppliers2.AllowUserToAddRows = false;
            this.gvSuppliers2.AllowUserToDeleteRows = false;
            this.gvSuppliers2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvSuppliers2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSuppliers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            this.gvSuppliers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.gvSuppliers2.Location = new System.Drawing.Point(34, 51);
            this.gvSuppliers2.MultiSelect = false;
            this.gvSuppliers2.Name = "gvSuppliers2";
            this.gvSuppliers2.ReadOnly = true;
            this.gvSuppliers2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSuppliers2.Size = new System.Drawing.Size(300, 220);
            this.gvSuppliers2.TabIndex = 6;
            this.gvSuppliers2.SelectionChanged += new System.EventHandler(this.gvSuppliers2_SelectionChanged);
            //
            // txtSupName
            //
            this.txtSupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.txtSupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSupName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.txtSupName.Location = new System.Drawing.Point(125, 20);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(100, 13);
            this.txtSupName.TabIndex = 5;
            //
            // lblSupName2
            //
            this.lblSupName2.AutoSize = true;
            this.lblSupName2.Location = new System.Drawing.Point(40, 20);
            this.lblSupName2.Name = "lblSupName2";
            this.lblSupName2.Size = new System.Drawing.Size(79, 13);
            this.lblSupName2.TabIndex = 4;
            this.lblSupName2.Text = "Supplier Name:";
            //
            // tabProduct
            //
            this.tabProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.tabProduct.Controls.Add(this.btnClearP);
            this.tabProduct.Controls.Add(this.btnDelPS);
            this.tabProduct.Controls.Add(this.btnAddPS);
            this.tabProduct.Controls.Add(this.btnShowPS);
            this.tabProduct.Controls.Add(this.gvSupByProd);
            this.tabProduct.Controls.Add(this.btnDelProd);
            this.tabProduct.Controls.Add(this.btnSaveP);
            this.tabProduct.Controls.Add(this.btnEditP);
            this.tabProduct.Controls.Add(this.btnAddNewProd);
            this.tabProduct.Controls.Add(this.gvSuppliers1);
            this.tabProduct.Controls.Add(this.gvProducts1);
            this.tabProduct.Controls.Add(this.txtProdName);
            this.tabProduct.Controls.Add(this.lblProdName2);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(1036, 427);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Product";
            //
            // btnClearP
            //
            this.btnClearP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnClearP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearP.Location = new System.Drawing.Point(252, 15);
            this.btnClearP.Name = "btnClearP";
            this.btnClearP.Size = new System.Drawing.Size(75, 23);
            this.btnClearP.TabIndex = 14;
            this.btnClearP.Text = "&Clear";
            this.btnClearP.UseVisualStyleBackColor = false;
            this.btnClearP.Click += new System.EventHandler(this.btnClearP_Click);
            //
            // btnDelPS
            //
            this.btnDelPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnDelPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelPS.Location = new System.Drawing.Point(679, 110);
            this.btnDelPS.Name = "btnDelPS";
            this.btnDelPS.Size = new System.Drawing.Size(34, 23);
            this.btnDelPS.TabIndex = 13;
            this.btnDelPS.Text = ">>";
            this.btnDelPS.UseVisualStyleBackColor = false;
            this.btnDelPS.Click += new System.EventHandler(this.btnDelPS_Click);
            //
            // btnAddPS
            //
            this.btnAddPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnAddPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPS.Location = new System.Drawing.Point(679, 177);
            this.btnAddPS.Name = "btnAddPS";
            this.btnAddPS.Size = new System.Drawing.Size(33, 23);
            this.btnAddPS.TabIndex = 12;
            this.btnAddPS.Text = "<<";
            this.btnAddPS.UseVisualStyleBackColor = false;
            this.btnAddPS.Click += new System.EventHandler(this.btnAddPS_Click);
            //
            // btnShowPS
            //
            this.btnShowPS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnShowPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPS.Location = new System.Drawing.Point(491, 277);
            this.btnShowPS.Name = "btnShowPS";
            this.btnShowPS.Size = new System.Drawing.Size(75, 23);
            this.btnShowPS.TabIndex = 10;
            this.btnShowPS.Text = "Show";
            this.btnShowPS.UseVisualStyleBackColor = false;
            this.btnShowPS.Click += new System.EventHandler(this.btnShowPS_Click);
            //
            // gvSupByProd
            //
            this.gvSupByProd.AllowUserToAddRows = false;
            this.gvSupByProd.AllowUserToDeleteRows = false;
            this.gvSupByProd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvSupByProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSupByProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSupByProd.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvSupByProd.Location = new System.Drawing.Point(726, 51);
            this.gvSupByProd.MultiSelect = false;
            this.gvSupByProd.Name = "gvSupByProd";
            this.gvSupByProd.ReadOnly = true;
            this.gvSupByProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSupByProd.Size = new System.Drawing.Size(254, 220);
            this.gvSupByProd.TabIndex = 9;
            //
            // btnDelProd
            //
            this.btnDelProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnDelProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelProd.Location = new System.Drawing.Point(239, 279);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(109, 23);
            this.btnDelProd.TabIndex = 8;
            this.btnDelProd.Text = "&Delete Product";
            this.btnDelProd.UseVisualStyleBackColor = false;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnSaveP
            //
            this.btnSaveP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnSaveP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveP.Location = new System.Drawing.Point(141, 327);
            this.btnSaveP.Name = "btnSaveP";
            this.btnSaveP.Size = new System.Drawing.Size(75, 23);
            this.btnSaveP.TabIndex = 7;
            this.btnSaveP.Text = "Save";
            this.btnSaveP.UseVisualStyleBackColor = false;
            this.btnSaveP.Click += new System.EventHandler(this.btnSaveP_Click);
            //
            // btnEditP
            //
            this.btnEditP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnEditP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditP.Location = new System.Drawing.Point(141, 279);
            this.btnEditP.Name = "btnEditP";
            this.btnEditP.Size = new System.Drawing.Size(75, 23);
            this.btnEditP.TabIndex = 6;
            this.btnEditP.Text = "&Edit Product";
            this.btnEditP.UseVisualStyleBackColor = false;
            this.btnEditP.Click += new System.EventHandler(this.btnEditP_Click);
            //
            // btnAddNewProd
            //
            this.btnAddNewProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnAddNewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProd.Location = new System.Drawing.Point(13, 279);
            this.btnAddNewProd.Name = "btnAddNewProd";
            this.btnAddNewProd.Size = new System.Drawing.Size(105, 23);
            this.btnAddNewProd.TabIndex = 5;
            this.btnAddNewProd.Text = "&Add New Product";
            this.btnAddNewProd.UseVisualStyleBackColor = false;
            this.btnAddNewProd.Click += new System.EventHandler(this.btnAddNewProd_Click);
            //
            // gvSuppliers1
            //
            this.gvSuppliers1.AllowUserToAddRows = false;
            this.gvSuppliers1.AllowUserToDeleteRows = false;
            this.gvSuppliers1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvSuppliers1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSuppliers1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSuppliers1.DefaultCellStyle = dataGridViewCellStyle5;
            this.gvSuppliers1.Location = new System.Drawing.Point(372, 51);
            this.gvSuppliers1.MultiSelect = false;
            this.gvSuppliers1.Name = "gvSuppliers1";
            this.gvSuppliers1.ReadOnly = true;
            this.gvSuppliers1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSuppliers1.Size = new System.Drawing.Size(300, 220);
            this.gvSuppliers1.TabIndex = 4;
            //
            // gvProducts1
            //
            this.gvProducts1.AllowUserToAddRows = false;
            this.gvProducts1.AllowUserToDeleteRows = false;
            this.gvProducts1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvProducts1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProducts1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProducts1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvProducts1.Location = new System.Drawing.Point(34, 51);
            this.gvProducts1.MultiSelect = false;
            this.gvProducts1.Name = "gvProducts1";
            this.gvProducts1.ReadOnly = true;
            this.gvProducts1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts1.Size = new System.Drawing.Size(300, 220);
            this.gvProducts1.TabIndex = 4;
            this.gvProducts1.SelectionChanged += new System.EventHandler(this.grProducts1_SelectionChanged);
            //
            // txtProdName
            //
            this.txtProdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.txtProdName.Location = new System.Drawing.Point(125, 20);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 13);
            this.txtProdName.TabIndex = 3;
            //
            // lblProdName2
            //
            this.lblProdName2.AutoSize = true;
            this.lblProdName2.Location = new System.Drawing.Point(40, 20);
            this.lblProdName2.Name = "lblProdName2";
            this.lblProdName2.Size = new System.Drawing.Size(78, 13);
            this.lblProdName2.TabIndex = 2;
            this.lblProdName2.Text = "Product Name:";
            //
            // tabPackages
            //
            this.tabPackages.AutoScroll = true;
            this.tabPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
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
            this.tabPackages.Size = new System.Drawing.Size(1036, 427);
            this.tabPackages.TabIndex = 1;
            this.tabPackages.Text = "Packages";
            //
            // btnDeletePkgProdSup_Click
            //
            this.btnDeletePkgProdSup_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnDeletePkgProdSup_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePkgProdSup_Click.Location = new System.Drawing.Point(689, 167);
            this.btnDeletePkgProdSup_Click.Name = "btnDeletePkgProdSup_Click";
            this.btnDeletePkgProdSup_Click.Size = new System.Drawing.Size(91, 23);
            this.btnDeletePkgProdSup_Click.TabIndex = 8;
            this.btnDeletePkgProdSup_Click.Text = "Delete Product";
            this.btnDeletePkgProdSup_Click.UseVisualStyleBackColor = false;
            this.btnDeletePkgProdSup_Click.Click += new System.EventHandler(this.btnDeletePkgProdSup_Click_Click);
            //
            // btnAddPkgProdSup
            //
            this.btnAddPkgProdSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnAddPkgProdSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPkgProdSup.Location = new System.Drawing.Point(465, 365);
            this.btnAddPkgProdSup.Name = "btnAddPkgProdSup";
            this.btnAddPkgProdSup.Size = new System.Drawing.Size(75, 23);
            this.btnAddPkgProdSup.TabIndex = 9;
            this.btnAddPkgProdSup.Text = "Add New";
            this.btnAddPkgProdSup.UseVisualStyleBackColor = false;
            this.btnAddPkgProdSup.Visible = false;
            this.btnAddPkgProdSup.Click += new System.EventHandler(this.btnAddPkgProdSup_Click);
            //
            // gvProdSup_all_pkgs
            //
            this.gvProdSup_all_pkgs.AllowUserToAddRows = false;
            this.gvProdSup_all_pkgs.AllowUserToDeleteRows = false;
            this.gvProdSup_all_pkgs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvProdSup_all_pkgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProdSup_all_pkgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProdSup_all_pkgs.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.btnNewPkgProdSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnNewPkgProdSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPkgProdSup.Location = new System.Drawing.Point(465, 167);
            this.btnNewPkgProdSup.Name = "btnNewPkgProdSup";
            this.btnNewPkgProdSup.Size = new System.Drawing.Size(91, 23);
            this.btnNewPkgProdSup.TabIndex = 7;
            this.btnNewPkgProdSup.Text = "New Product";
            this.btnNewPkgProdSup.UseVisualStyleBackColor = false;
            this.btnNewPkgProdSup.Click += new System.EventHandler(this.btnUpdatePkgProdSup_Click);
            //
            // gvProdSup_pkg
            //
            this.gvProdSup_pkg.AllowUserToAddRows = false;
            this.gvProdSup_pkg.AllowUserToDeleteRows = false;
            this.gvProdSup_pkg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvProdSup_pkg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvProdSup_pkg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gvProdSup_pkg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProdSup_pkg.DefaultCellStyle = dataGridViewCellStyle9;
            this.gvProdSup_pkg.Location = new System.Drawing.Point(465, 11);
            this.gvProdSup_pkg.MultiSelect = false;
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
            this.btnAddEditPkg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnAddEditPkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEditPkg.Location = new System.Drawing.Point(214, 218);
            this.btnAddEditPkg.Name = "btnAddEditPkg";
            this.btnAddEditPkg.Size = new System.Drawing.Size(80, 23);
            this.btnAddEditPkg.TabIndex = 6;
            this.btnAddEditPkg.Text = "Save New Package";
            this.btnAddEditPkg.UseVisualStyleBackColor = false;
            this.btnAddEditPkg.Click += new System.EventHandler(this.btnAddEditPkg_Click);
            //
            // txtPkgDesc
            //
            this.txtPkgDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.txtPkgDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPkgDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.txtPkgDesc.Location = new System.Drawing.Point(159, 92);
            this.txtPkgDesc.MaxLength = 50;
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(188, 72);
            this.txtPkgDesc.TabIndex = 3;
            this.txtPkgDesc.TextChanged += new System.EventHandler(this.txtPkgDesc_TextChanged);
            //
            // txtPkgAgencyCommission
            //
            this.txtPkgAgencyCommission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.txtPkgAgencyCommission.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPkgAgencyCommission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(159, 196);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(188, 13);
            this.txtPkgAgencyCommission.TabIndex = 5;
            //
            // txtPkgBasePrice
            //
            this.txtPkgBasePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.txtPkgBasePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPkgBasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.txtPkgBasePrice.Location = new System.Drawing.Point(159, 170);
            this.txtPkgBasePrice.Name = "txtPkgBasePrice";
            this.txtPkgBasePrice.Size = new System.Drawing.Size(188, 13);
            this.txtPkgBasePrice.TabIndex = 4;
            //
            // txtPackageName
            //
            this.txtPackageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.txtPackageName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPackageName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.txtPackageName.Location = new System.Drawing.Point(159, 11);
            this.txtPackageName.MaxLength = 50;
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.Size = new System.Drawing.Size(188, 13);
            this.txtPackageName.TabIndex = 0;
            this.txtPackageName.TextChanged += new System.EventHandler(this.txtPackageName_TextChanged);
            //
            // dtpPkgEndDate
            //
            this.dtpPkgEndDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            this.dtpPkgEndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.dtpPkgEndDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.dtpPkgEndDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            this.dtpPkgEndDate.Location = new System.Drawing.Point(159, 60);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(188, 20);
            this.dtpPkgEndDate.TabIndex = 2;
            this.dtpPkgEndDate.ValueChanged += new System.EventHandler(this.dtpPkgEndDate_ValueChanged);
            //
            // dtpPkgStartDate
            //
            this.dtpPkgStartDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            this.dtpPkgStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.dtpPkgStartDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.dtpPkgStartDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            this.dtpPkgStartDate.Location = new System.Drawing.Point(159, 34);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(188, 20);
            this.dtpPkgStartDate.TabIndex = 1;
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
            // tabMainPage
            //
            this.tabMainPage.AutoScroll = true;
            this.tabMainPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.tabMainPage.Controls.Add(this.btnDeletepkg);
            this.tabMainPage.Controls.Add(this.gvSuppliers);
            this.tabMainPage.Controls.Add(this.gvProducts);
            this.tabMainPage.Controls.Add(this.gvPackages);
            this.tabMainPage.Controls.Add(this.btnEditPkg);
            this.tabMainPage.Controls.Add(this.btnAddPkg);
            this.tabMainPage.ImageKey = "(none)";
            this.tabMainPage.Location = new System.Drawing.Point(4, 22);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainPage.Size = new System.Drawing.Size(1036, 427);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            //
            // btnDeletepkg
            //
            this.btnDeletepkg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnDeletepkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletepkg.Location = new System.Drawing.Point(475, 162);
            this.btnDeletepkg.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletepkg.Name = "btnDeletepkg";
            this.btnDeletepkg.Size = new System.Drawing.Size(87, 23);
            this.btnDeletepkg.TabIndex = 10;
            this.btnDeletepkg.Text = "Delete Package";
            this.btnDeletepkg.UseVisualStyleBackColor = false;
            this.btnDeletepkg.Click += new System.EventHandler(this.btnDeletepkg_Click);
            //
            // gvSuppliers
            //
            this.gvSuppliers.AllowUserToAddRows = false;
            this.gvSuppliers.AllowUserToDeleteRows = false;
            this.gvSuppliers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSuppliers.DefaultCellStyle = dataGridViewCellStyle10;
            this.gvSuppliers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.gvSuppliers.Location = new System.Drawing.Point(684, 191);
            this.gvSuppliers.Margin = new System.Windows.Forms.Padding(2);
            this.gvSuppliers.MultiSelect = false;
            this.gvSuppliers.Name = "gvSuppliers";
            this.gvSuppliers.RowTemplate.Height = 24;
            this.gvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSuppliers.Size = new System.Drawing.Size(327, 135);
            this.gvSuppliers.TabIndex = 9;
            //
            // gvProducts
            //
            this.gvProducts.AllowUserToAddRows = false;
            this.gvProducts.AllowUserToDeleteRows = false;
            this.gvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.gvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            this.gvProducts.Location = new System.Drawing.Point(6, 191);
            this.gvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.gvProducts.MultiSelect = false;
            this.gvProducts.Name = "gvProducts";
            this.gvProducts.RowTemplate.Height = 24;
            this.gvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvProducts.Size = new System.Drawing.Size(327, 135);
            this.gvProducts.TabIndex = 9;
            //
            // gvPackages
            //
            this.gvPackages.AllowUserToAddRows = false;
            this.gvPackages.AllowUserToDeleteRows = false;
            this.gvPackages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.gvPackages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPackages.DefaultCellStyle = dataGridViewCellStyle13;
            this.gvPackages.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(137)))), ((int)(((byte)(252)))));
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
            // btnEditPkg
            //
            this.btnEditPkg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnEditPkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPkg.Location = new System.Drawing.Point(927, 162);
            this.btnEditPkg.Name = "btnEditPkg";
            this.btnEditPkg.Size = new System.Drawing.Size(84, 23);
            this.btnEditPkg.TabIndex = 1;
            this.btnEditPkg.Text = "Edit Package";
            this.btnEditPkg.UseVisualStyleBackColor = false;
            this.btnEditPkg.Click += new System.EventHandler(this.btnEditPkg_Click);
            //
            // btnAddPkg
            //
            this.btnAddPkg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(78)))));
            this.btnAddPkg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPkg.Location = new System.Drawing.Point(6, 162);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(84, 23);
            this.btnAddPkg.TabIndex = 0;
            this.btnAddPkg.Text = "Add Package";
            this.btnAddPkg.UseVisualStyleBackColor = false;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabMainPage);
            this.tabControl1.Controls.Add(this.tabPackages);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1044, 453);
            this.tabControl1.TabIndex = 0;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1044, 453);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(227)))), ((int)(((byte)(202)))));
            this.Name = "Form1";
            this.Text = "Travel Experts Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_SuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesProductsSuppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet1)).EndInit();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdBySup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers2)).EndInit();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSupByProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts1)).EndInit();
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_all_pkgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProdSup_pkg)).EndInit();
            this.tabMainPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPackages)).EndInit();
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private TravelExpertsDataSet travelExpertsDataSet1;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.Button btnDelSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Button btnShowSP;
        private System.Windows.Forms.DataGridView gvProdBySup;
        private System.Windows.Forms.Button btnDelSup;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.Button btnEditS;
        private System.Windows.Forms.Button btnNewS;
        private System.Windows.Forms.DataGridView gvProducts2;
        private System.Windows.Forms.DataGridView gvSuppliers2;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblSupName2;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.Button btnClearP;
        private System.Windows.Forms.Button btnDelPS;
        private System.Windows.Forms.Button btnAddPS;
        private System.Windows.Forms.Button btnShowPS;
        private System.Windows.Forms.DataGridView gvSupByProd;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.Button btnSaveP;
        private System.Windows.Forms.Button btnEditP;
        private System.Windows.Forms.Button btnAddNewProd;
        private System.Windows.Forms.DataGridView gvSuppliers1;
        private System.Windows.Forms.DataGridView gvProducts1;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName2;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.Button btnDeletePkgProdSup_Click;
        private System.Windows.Forms.Button btnAddPkgProdSup;
        private System.Windows.Forms.DataGridView gvProdSup_all_pkgs;
        private System.Windows.Forms.Button btnNewPkgProdSup;
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
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.Button btnDeletepkg;
        private System.Windows.Forms.DataGridView gvSuppliers;
        private System.Windows.Forms.DataGridView gvProducts;
        private System.Windows.Forms.DataGridView gvPackages;
        private System.Windows.Forms.Button btnEditPkg;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnClearS;
    }
}

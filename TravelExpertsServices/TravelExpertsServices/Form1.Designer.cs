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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.btnEditSup = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.tabPackages = new System.Windows.Forms.TabPage();
            this.btnAddEditPkg = new System.Windows.Forms.Button();
            this.cmbSupName = new System.Windows.Forms.ComboBox();
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
            this.PkgBasePrice = new System.Windows.Forms.TextBox();
            this.txtPackageId = new System.Windows.Forms.TextBox();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.btnAddEditProd = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.lblProdName2 = new System.Windows.Forms.Label();
            this.tabSuppliers = new System.Windows.Forms.TabPage();
            this.btnAddEditSup = new System.Windows.Forms.Button();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.lblSupName2 = new System.Windows.Forms.Label();
            this.travelExpertsDataSet = new TravelExpertsServices.TravelExpertsDataSet();
            this.packagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packagesTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.PackagesTableAdapter();
            this.tableAdapterManager = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.TableAdapterManager();
            this.packagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.packagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.packagesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.ProductsTableAdapter();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliersTableAdapter = new TravelExpertsServices.TravelExpertsDataSetTableAdapters.SuppliersTableAdapter();
            this.suppliersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            this.tabPackages.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingNavigator)).BeginInit();
            this.packagesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).BeginInit();
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
            this.tabMainPage.Controls.Add(this.suppliersDataGridView);
            this.tabMainPage.Controls.Add(this.productsDataGridView);
            this.tabMainPage.Controls.Add(this.packagesDataGridView);
            this.tabMainPage.Controls.Add(this.btnEditSup);
            this.tabMainPage.Controls.Add(this.button3);
            this.tabMainPage.Controls.Add(this.btnAddSup);
            this.tabMainPage.Controls.Add(this.button1);
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
            // btnEditSup
            // 
            this.btnEditSup.Location = new System.Drawing.Point(1235, 409);
            this.btnEditSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(112, 28);
            this.btnEditSup.TabIndex = 1;
            this.btnEditSup.Text = "Edit Supplier";
            this.btnEditSup.UseVisualStyleBackColor = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(546, 409);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Edit Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Location = new System.Drawing.Point(697, 409);
            this.btnAddSup.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(112, 28);
            this.btnAddSup.TabIndex = 1;
            this.btnAddSup.Text = "Add Supplier";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1235, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit Package";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tabPackages.Controls.Add(this.btnAddEditPkg);
            this.tabPackages.Controls.Add(this.cmbSupName);
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
            this.tabPackages.Controls.Add(this.PkgBasePrice);
            this.tabPackages.Controls.Add(this.txtPackageId);
            this.tabPackages.Location = new System.Drawing.Point(4, 25);
            this.tabPackages.Margin = new System.Windows.Forms.Padding(4);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(4);
            this.tabPackages.Size = new System.Drawing.Size(916, 495);
            this.tabPackages.TabIndex = 1;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
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
            // cmbSupName
            // 
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(212, 303);
            this.cmbSupName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(249, 24);
            this.cmbSupName.TabIndex = 4;
            // 
            // cmbProdName
            // 
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(212, 270);
            this.cmbProdName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(249, 24);
            this.cmbProdName.TabIndex = 4;
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
            // PkgBasePrice
            // 
            this.PkgBasePrice.Location = new System.Drawing.Point(212, 206);
            this.PkgBasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.Size = new System.Drawing.Size(249, 22);
            this.PkgBasePrice.TabIndex = 0;
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(212, 10);
            this.txtPackageId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(249, 22);
            this.txtPackageId.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnAddEditProd);
            this.tabProduct.Controls.Add(this.txtProdName);
            this.tabProduct.Controls.Add(this.lblProdName2);
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Margin = new System.Windows.Forms.Padding(4);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(916, 497);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
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
            this.tabSuppliers.Controls.Add(this.btnAddEditSup);
            this.tabSuppliers.Controls.Add(this.txtSupName);
            this.tabSuppliers.Controls.Add(this.lblSupName2);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 25);
            this.tabSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(916, 497);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
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
            // travelExpertsDataSet
            // 
            this.travelExpertsDataSet.DataSetName = "TravelExpertsDataSet";
            this.travelExpertsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // packagesBindingSource
            // 
            this.packagesBindingSource.DataMember = "Packages";
            this.packagesBindingSource.DataSource = this.travelExpertsDataSet;
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
            // packagesBindingNavigator
            // 
            this.packagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.packagesBindingNavigator.BindingSource = this.packagesBindingSource;
            this.packagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.packagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.packagesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.packagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.packagesBindingNavigatorSaveItem});
            this.packagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.packagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.packagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.packagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.packagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.packagesBindingNavigator.Name = "packagesBindingNavigator";
            this.packagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.packagesBindingNavigator.Size = new System.Drawing.Size(1392, 27);
            this.packagesBindingNavigator.TabIndex = 1;
            this.packagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // packagesBindingNavigatorSaveItem
            // 
            this.packagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.packagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("packagesBindingNavigatorSaveItem.Image")));
            this.packagesBindingNavigatorSaveItem.Name = "packagesBindingNavigatorSaveItem";
            this.packagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.packagesBindingNavigatorSaveItem.Text = "Save Data";
            this.packagesBindingNavigatorSaveItem.Click += new System.EventHandler(this.packagesBindingNavigatorSaveItem_Click);
            // 
            // packagesDataGridView
            // 
            this.packagesDataGridView.AutoGenerateColumns = false;
            this.packagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.packagesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.packagesDataGridView.DataSource = this.packagesBindingSource;
            this.packagesDataGridView.Location = new System.Drawing.Point(7, 7);
            this.packagesDataGridView.Name = "packagesDataGridView";
            this.packagesDataGridView.ReadOnly = true;
            this.packagesDataGridView.RowTemplate.Height = 24;
            this.packagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.packagesDataGridView.Size = new System.Drawing.Size(1341, 185);
            this.packagesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackageId";
            this.dataGridViewTextBoxColumn1.HeaderText = "Package Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 107;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            this.dataGridViewTextBoxColumn2.HeaderText = "Package Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 122;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Package Start Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 119;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "Package End Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgDesc";
            this.dataGridViewTextBoxColumn5.HeaderText = "Package Description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 153;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn6.HeaderText = "Package Base Price";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 121;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.Width = 149;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Location = new System.Drawing.Point(8, 235);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.RowTemplate.Height = 24;
            this.productsDataGridView.Size = new System.Drawing.Size(651, 166);
            this.productsDataGridView.TabIndex = 9;
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.travelExpertsDataSet;
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // suppliersDataGridView
            // 
            this.suppliersDataGridView.AutoGenerateColumns = false;
            this.suppliersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppliersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11});
            this.suppliersDataGridView.DataSource = this.suppliersBindingSource;
            this.suppliersDataGridView.Location = new System.Drawing.Point(697, 235);
            this.suppliersDataGridView.Name = "suppliersDataGridView";
            this.suppliersDataGridView.RowTemplate.Height = 24;
            this.suppliersDataGridView.Size = new System.Drawing.Size(651, 167);
            this.suppliersDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn9.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 104;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SupName";
            this.dataGridViewTextBoxColumn11.HeaderText = "SupName";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 99;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 558);
            this.Controls.Add(this.packagesBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Travel Experts Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelExpertsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packagesBindingNavigator)).EndInit();
            this.packagesBindingNavigator.ResumeLayout(false);
            this.packagesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packagesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainPage;
        private System.Windows.Forms.TabPage tabPackages;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.Label lblPkgStartDate;
        private System.Windows.Forms.Label lblPkgName;
        private System.Windows.Forms.TextBox txtPackageId;
        private System.Windows.Forms.TabPage tabSuppliers;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.Label lblPkgEndDate;
        private System.Windows.Forms.ComboBox cmbSupName;
        private System.Windows.Forms.ComboBox cmbProdName;
        private System.Windows.Forms.TextBox txtPkgDesc;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblPkgAgencyCommission;
        private System.Windows.Forms.Label lblPkgBasePrice;
        private System.Windows.Forms.TextBox txtPkgAgencyCommission;
        private System.Windows.Forms.TextBox PkgBasePrice;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label lblProdName2;
        private System.Windows.Forms.Button btnAddEditProd;
        private System.Windows.Forms.Button btnAddEditSup;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label lblSupName2;
        private System.Windows.Forms.Button btnAddEditPkg;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnAddSup;
        private TravelExpertsDataSet travelExpertsDataSet;
        private System.Windows.Forms.BindingSource packagesBindingSource;
        private TravelExpertsDataSetTableAdapters.PackagesTableAdapter packagesTableAdapter;
        private TravelExpertsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator packagesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton packagesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView packagesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private TravelExpertsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private TravelExpertsDataSetTableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private System.Windows.Forms.DataGridView suppliersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}


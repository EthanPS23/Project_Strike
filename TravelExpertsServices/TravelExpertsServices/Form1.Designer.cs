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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.dgvPkgs = new System.Windows.Forms.DataGridView();
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
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.btnEditSup = new System.Windows.Forms.Button();
            this.dgvSup = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPkgs)).BeginInit();
            this.tabPackages.SuspendLayout();
            this.tabProduct.SuspendLayout();
            this.tabSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainPage);
            this.tabControl1.Controls.Add(this.tabPackages);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabSuppliers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(693, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMainPage
            // 
            this.tabMainPage.Controls.Add(this.dgvSup);
            this.tabMainPage.Controls.Add(this.btnEditSup);
            this.tabMainPage.Controls.Add(this.dgvProd);
            this.tabMainPage.Controls.Add(this.button3);
            this.tabMainPage.Controls.Add(this.btnAddSup);
            this.tabMainPage.Controls.Add(this.button1);
            this.tabMainPage.Controls.Add(this.btnAddProd);
            this.tabMainPage.Controls.Add(this.btnAddPkg);
            this.tabMainPage.Controls.Add(this.dgvPkgs);
            this.tabMainPage.Location = new System.Drawing.Point(4, 22);
            this.tabMainPage.Name = "tabMainPage";
            this.tabMainPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabMainPage.Size = new System.Drawing.Size(685, 400);
            this.tabMainPage.TabIndex = 0;
            this.tabMainPage.Text = "Main Page";
            this.tabMainPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit Package";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Location = new System.Drawing.Point(28, 162);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(84, 23);
            this.btnAddPkg.TabIndex = 1;
            this.btnAddPkg.Text = "Add Package";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // dgvPkgs
            // 
            this.dgvPkgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPkgs.Location = new System.Drawing.Point(28, 21);
            this.dgvPkgs.Name = "dgvPkgs";
            this.dgvPkgs.Size = new System.Drawing.Size(623, 135);
            this.dgvPkgs.TabIndex = 0;
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
            this.tabPackages.Location = new System.Drawing.Point(4, 22);
            this.tabPackages.Name = "tabPackages";
            this.tabPackages.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPackages.Size = new System.Drawing.Size(685, 400);
            this.tabPackages.TabIndex = 1;
            this.tabPackages.Text = "Packages";
            this.tabPackages.UseVisualStyleBackColor = true;
            // 
            // btnAddEditPkg
            // 
            this.btnAddEditPkg.Location = new System.Drawing.Point(130, 293);
            this.btnAddEditPkg.Name = "btnAddEditPkg";
            this.btnAddEditPkg.Size = new System.Drawing.Size(80, 23);
            this.btnAddEditPkg.TabIndex = 5;
            this.btnAddEditPkg.Text = "Add Package";
            this.btnAddEditPkg.UseVisualStyleBackColor = true;
            // 
            // cmbSupName
            // 
            this.cmbSupName.FormattingEnabled = true;
            this.cmbSupName.Location = new System.Drawing.Point(159, 246);
            this.cmbSupName.Name = "cmbSupName";
            this.cmbSupName.Size = new System.Drawing.Size(188, 21);
            this.cmbSupName.TabIndex = 4;
            // 
            // cmbProdName
            // 
            this.cmbProdName.FormattingEnabled = true;
            this.cmbProdName.Location = new System.Drawing.Point(159, 219);
            this.cmbProdName.Name = "cmbProdName";
            this.cmbProdName.Size = new System.Drawing.Size(188, 21);
            this.cmbProdName.TabIndex = 4;
            // 
            // txtPkgDesc
            // 
            this.txtPkgDesc.Location = new System.Drawing.Point(159, 89);
            this.txtPkgDesc.Multiline = true;
            this.txtPkgDesc.Name = "txtPkgDesc";
            this.txtPkgDesc.Size = new System.Drawing.Size(188, 72);
            this.txtPkgDesc.TabIndex = 3;
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Location = new System.Drawing.Point(159, 60);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(188, 20);
            this.dtpPkgEndDate.TabIndex = 2;
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Location = new System.Drawing.Point(159, 34);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(188, 20);
            this.dtpPkgStartDate.TabIndex = 2;
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
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(6, 249);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(79, 13);
            this.lblSupName.TabIndex = 1;
            this.lblSupName.Text = "Supplier Name:";
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
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(6, 222);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(78, 13);
            this.lblProdName.TabIndex = 1;
            this.lblProdName.Text = "Product Name:";
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
            // txtPkgAgencyCommission
            // 
            this.txtPkgAgencyCommission.Location = new System.Drawing.Point(159, 193);
            this.txtPkgAgencyCommission.Name = "txtPkgAgencyCommission";
            this.txtPkgAgencyCommission.Size = new System.Drawing.Size(188, 20);
            this.txtPkgAgencyCommission.TabIndex = 0;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.Location = new System.Drawing.Point(159, 167);
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.Size = new System.Drawing.Size(188, 20);
            this.PkgBasePrice.TabIndex = 0;
            // 
            // txtPackageId
            // 
            this.txtPackageId.Location = new System.Drawing.Point(159, 8);
            this.txtPackageId.Name = "txtPackageId";
            this.txtPackageId.Size = new System.Drawing.Size(188, 20);
            this.txtPackageId.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.btnAddEditProd);
            this.tabProduct.Controls.Add(this.txtProdName);
            this.tabProduct.Controls.Add(this.lblProdName2);
            this.tabProduct.Location = new System.Drawing.Point(4, 22);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(685, 400);
            this.tabProduct.TabIndex = 2;
            this.tabProduct.Text = "Product";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddEditProd
            // 
            this.btnAddEditProd.Location = new System.Drawing.Point(47, 45);
            this.btnAddEditProd.Name = "btnAddEditProd";
            this.btnAddEditProd.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditProd.TabIndex = 4;
            this.btnAddEditProd.Text = "Add Product";
            this.btnAddEditProd.UseVisualStyleBackColor = true;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(87, 6);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(100, 20);
            this.txtProdName.TabIndex = 3;
            // 
            // lblProdName2
            // 
            this.lblProdName2.AutoSize = true;
            this.lblProdName2.Location = new System.Drawing.Point(3, 9);
            this.lblProdName2.Name = "lblProdName2";
            this.lblProdName2.Size = new System.Drawing.Size(78, 13);
            this.lblProdName2.TabIndex = 2;
            this.lblProdName2.Text = "Product Name:";
            // 
            // tabSuppliers
            // 
            this.tabSuppliers.Controls.Add(this.btnAddEditSup);
            this.tabSuppliers.Controls.Add(this.txtSupName);
            this.tabSuppliers.Controls.Add(this.lblSupName2);
            this.tabSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabSuppliers.Name = "tabSuppliers";
            this.tabSuppliers.Size = new System.Drawing.Size(685, 400);
            this.tabSuppliers.TabIndex = 3;
            this.tabSuppliers.Text = "Suppliers";
            this.tabSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnAddEditSup
            // 
            this.btnAddEditSup.Location = new System.Drawing.Point(47, 45);
            this.btnAddEditSup.Name = "btnAddEditSup";
            this.btnAddEditSup.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditSup.TabIndex = 6;
            this.btnAddEditSup.Text = "Add Supplier";
            this.btnAddEditSup.UseVisualStyleBackColor = true;
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
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(28, 191);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(284, 135);
            this.dgvProd.TabIndex = 2;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Location = new System.Drawing.Point(28, 332);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(84, 23);
            this.btnAddProd.TabIndex = 1;
            this.btnAddProd.Text = "Add Product";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Edit Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddSup
            // 
            this.btnAddSup.Location = new System.Drawing.Point(367, 332);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(84, 23);
            this.btnAddSup.TabIndex = 1;
            this.btnAddSup.Text = "Add Supplier";
            this.btnAddSup.UseVisualStyleBackColor = true;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click);
            // 
            // btnEditSup
            // 
            this.btnEditSup.Location = new System.Drawing.Point(567, 332);
            this.btnEditSup.Name = "btnEditSup";
            this.btnEditSup.Size = new System.Drawing.Size(84, 23);
            this.btnEditSup.TabIndex = 1;
            this.btnEditSup.Text = "Edit Supplier";
            this.btnEditSup.UseVisualStyleBackColor = true;
            this.btnEditSup.Click += new System.EventHandler(this.btnEditSup_Click);
            // 
            // dgvSup
            // 
            this.dgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSup.Location = new System.Drawing.Point(367, 191);
            this.dgvSup.Name = "dgvSup";
            this.dgvSup.Size = new System.Drawing.Size(284, 135);
            this.dgvSup.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 442);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Travel Experts Services";
            this.tabControl1.ResumeLayout(false);
            this.tabMainPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPkgs)).EndInit();
            this.tabPackages.ResumeLayout(false);
            this.tabPackages.PerformLayout();
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            this.tabSuppliers.ResumeLayout(false);
            this.tabSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSup)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvPkgs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.DataGridView dgvSup;
        private System.Windows.Forms.Button btnEditSup;
        private System.Windows.Forms.Button btnAddSup;
    }
}


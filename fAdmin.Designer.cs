
namespace CafeShop {
    partial class fAdmin {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdmin));
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpFoods = new System.Windows.Forms.TabPage();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnResetFood = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmrFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpCategory = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFoodCategory = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.tpTables = new System.Windows.Forms.TabPage();
            this.tbSearchTable = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.btnResetTable = new System.Windows.Forms.Button();
            this.btnUpdateTable = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.panel21 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.Label();
            this.tbTableName = new System.Windows.Forms.TextBox();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.panel24 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel25 = new System.Windows.Forms.Panel();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel26 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDeletebill = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tcAdmin.SuspendLayout();
            this.tpFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCategory)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tpTables.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel21.SuspendLayout();
            this.tpAccounts.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpFoods);
            this.tcAdmin.Controls.Add(this.tpCategory);
            this.tcAdmin.Controls.Add(this.tpTables);
            this.tcAdmin.Controls.Add(this.tpAccounts);
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Location = new System.Drawing.Point(2, 5);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1187, 690);
            this.tcAdmin.TabIndex = 1;
            this.tcAdmin.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcAdmin_Selecting);
            // 
            // tpFoods
            // 
            this.tpFoods.Controls.Add(this.btnAddFood);
            this.tpFoods.Controls.Add(this.label6);
            this.tpFoods.Controls.Add(this.dgvFoods);
            this.tpFoods.Controls.Add(this.panel6);
            this.tpFoods.Controls.Add(this.panel4);
            this.tpFoods.Location = new System.Drawing.Point(4, 29);
            this.tpFoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpFoods.Name = "tpFoods";
            this.tpFoods.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpFoods.Size = new System.Drawing.Size(1179, 657);
            this.tpFoods.TabIndex = 1;
            this.tpFoods.Text = "Foods";
            this.tpFoods.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(664, 4);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(128, 62);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "List foods";
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(6, 70);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersWidth = 40;
            this.dgvFoods.RowTemplate.Height = 24;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFoods.Size = new System.Drawing.Size(786, 591);
            this.dgvFoods.TabIndex = 0;
            this.dgvFoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoods_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(803, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(370, 66);
            this.panel6.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 54);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search Food";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btnResetFood);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(803, 74);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 573);
            this.panel4.TabIndex = 1;
            // 
            // btnResetFood
            // 
            this.btnResetFood.Location = new System.Drawing.Point(6, 200);
            this.btnResetFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetFood.Name = "btnResetFood";
            this.btnResetFood.Size = new System.Drawing.Size(128, 62);
            this.btnResetFood.TabIndex = 10;
            this.btnResetFood.Text = "Reset";
            this.btnResetFood.UseVisualStyleBackColor = true;
            this.btnResetFood.Click += new System.EventHandler(this.btnResetFood_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmrFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(6, 134);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(361, 58);
            this.panel10.TabIndex = 9;
            // 
            // nmrFoodPrice
            // 
            this.nmrFoodPrice.Location = new System.Drawing.Point(108, 16);
            this.nmrFoodPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmrFoodPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmrFoodPrice.Name = "nmrFoodPrice";
            this.nmrFoodPrice.Size = new System.Drawing.Size(221, 27);
            this.nmrFoodPrice.TabIndex = 8;
            this.nmrFoodPrice.ValueChanged += new System.EventHandler(this.nmrFoodPrice_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.txbFoodName);
            this.panel9.Location = new System.Drawing.Point(6, 4);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(361, 58);
            this.panel9.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txbFoodName
            // 
            this.txbFoodName.AcceptsTab = true;
            this.txbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbFoodName.Location = new System.Drawing.Point(108, 12);
            this.txbFoodName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFoodName.MaxLength = 30;
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(221, 24);
            this.txbFoodName.TabIndex = 7;
            this.txbFoodName.TabStop = false;
            this.txbFoodName.TextChanged += new System.EventHandler(this.txbFoodName_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cbCategory);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(6, 69);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(361, 58);
            this.panel8.TabIndex = 6;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(108, 15);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(221, 28);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // tpCategory
            // 
            this.tpCategory.Controls.Add(this.label12);
            this.tpCategory.Controls.Add(this.label1);
            this.tpCategory.Controls.Add(this.dgvFoodCategory);
            this.tpCategory.Controls.Add(this.panel15);
            this.tpCategory.Location = new System.Drawing.Point(4, 29);
            this.tpCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpCategory.Name = "tpCategory";
            this.tpCategory.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpCategory.Size = new System.Drawing.Size(1179, 657);
            this.tpCategory.TabIndex = 2;
            this.tpCategory.Text = "Category";
            this.tpCategory.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(783, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 54);
            this.label12.TabIndex = 10;
            this.label12.Text = "Add new category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "List categories";
            // 
            // dgvFoodCategory
            // 
            this.dgvFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodCategory.Location = new System.Drawing.Point(6, 73);
            this.dgvFoodCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFoodCategory.MultiSelect = false;
            this.dgvFoodCategory.Name = "dgvFoodCategory";
            this.dgvFoodCategory.ReadOnly = true;
            this.dgvFoodCategory.RowHeadersWidth = 51;
            this.dgvFoodCategory.RowTemplate.Height = 24;
            this.dgvFoodCategory.Size = new System.Drawing.Size(768, 584);
            this.dgvFoodCategory.TabIndex = 0;
            this.dgvFoodCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodCategory_CellContentClick);
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel15.Controls.Add(this.panel11);
            this.panel15.Location = new System.Drawing.Point(780, 73);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(393, 576);
            this.panel15.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.btnAddCategory);
            this.panel11.Controls.Add(this.txbCategoryName);
            this.panel11.Location = new System.Drawing.Point(3, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(390, 139);
            this.panel11.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(3, 54);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(128, 62);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txbCategoryName
            // 
            this.txbCategoryName.AcceptsTab = true;
            this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCategoryName.Location = new System.Drawing.Point(79, 12);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCategoryName.MaxLength = 30;
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(247, 24);
            this.txbCategoryName.TabIndex = 7;
            this.txbCategoryName.TabStop = false;
            // 
            // tpTables
            // 
            this.tpTables.Controls.Add(this.tbSearchTable);
            this.tpTables.Controls.Add(this.label17);
            this.tpTables.Controls.Add(this.label13);
            this.tpTables.Controls.Add(this.flpTables);
            this.tpTables.Controls.Add(this.panel20);
            this.tpTables.Location = new System.Drawing.Point(4, 29);
            this.tpTables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTables.Name = "tpTables";
            this.tpTables.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpTables.Size = new System.Drawing.Size(1179, 657);
            this.tpTables.TabIndex = 3;
            this.tpTables.Text = "Tables";
            this.tpTables.UseVisualStyleBackColor = true;
            // 
            // tbSearchTable
            // 
            this.tbSearchTable.Location = new System.Drawing.Point(556, 24);
            this.tbSearchTable.MaxLength = 30;
            this.tbSearchTable.Name = "tbSearchTable";
            this.tbSearchTable.Size = new System.Drawing.Size(242, 27);
            this.tbSearchTable.TabIndex = 16;
            this.tbSearchTable.TextChanged += new System.EventHandler(this.tbSearchTable_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(475, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 28);
            this.label17.TabIndex = 14;
            this.label17.Text = "Search";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 54);
            this.label13.TabIndex = 13;
            this.label13.Text = "List tables";
            // 
            // flpTables
            // 
            this.flpTables.AutoScroll = true;
            this.flpTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpTables.Location = new System.Drawing.Point(6, 61);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(792, 584);
            this.flpTables.TabIndex = 12;
            // 
            // panel20
            // 
            this.panel20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel20.Controls.Add(this.btnResetTable);
            this.panel20.Controls.Add(this.btnUpdateTable);
            this.panel20.Controls.Add(this.panel23);
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Location = new System.Drawing.Point(815, 61);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(358, 241);
            this.panel20.TabIndex = 9;
            // 
            // btnResetTable
            // 
            this.btnResetTable.Location = new System.Drawing.Point(223, 136);
            this.btnResetTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnResetTable.Name = "btnResetTable";
            this.btnResetTable.Size = new System.Drawing.Size(128, 85);
            this.btnResetTable.TabIndex = 10;
            this.btnResetTable.Text = "Reset";
            this.btnResetTable.UseVisualStyleBackColor = true;
            this.btnResetTable.Click += new System.EventHandler(this.btnResetTable_Click);
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Location = new System.Drawing.Point(3, 136);
            this.btnUpdateTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(128, 85);
            this.btnUpdateTable.TabIndex = 1;
            this.btnUpdateTable.Text = "Update ";
            this.btnUpdateTable.UseVisualStyleBackColor = true;
            this.btnUpdateTable.Click += new System.EventHandler(this.btnUpdateTable_Click);
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.rbtnInactive);
            this.panel23.Controls.Add(this.label9);
            this.panel23.Controls.Add(this.rbtnActive);
            this.panel23.Location = new System.Drawing.Point(3, 70);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(348, 58);
            this.panel23.TabIndex = 9;
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnInactive.ForeColor = System.Drawing.Color.Red;
            this.rbtnInactive.Location = new System.Drawing.Point(236, 15);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(93, 29);
            this.rbtnInactive.TabIndex = 11;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Status";
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.rbtnActive.Location = new System.Drawing.Point(102, 15);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(81, 29);
            this.rbtnActive.TabIndex = 10;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.table);
            this.panel21.Controls.Add(this.tbTableName);
            this.panel21.Location = new System.Drawing.Point(3, 4);
            this.panel21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(348, 58);
            this.panel21.TabIndex = 8;
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.table.Location = new System.Drawing.Point(3, 15);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(55, 20);
            this.table.TabIndex = 2;
            this.table.Text = "Table";
            // 
            // tbTableName
            // 
            this.tbTableName.AcceptsTab = true;
            this.tbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTableName.Location = new System.Drawing.Point(93, 12);
            this.tbTableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTableName.MaxLength = 30;
            this.tbTableName.Name = "tbTableName";
            this.tbTableName.Size = new System.Drawing.Size(236, 24);
            this.tbTableName.TabIndex = 7;
            this.tbTableName.TabStop = false;
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.panel24);
            this.tpAccounts.Controls.Add(this.panel25);
            this.tpAccounts.Controls.Add(this.panel26);
            this.tpAccounts.Location = new System.Drawing.Point(4, 29);
            this.tpAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tpAccounts.Size = new System.Drawing.Size(1179, 657);
            this.tpAccounts.TabIndex = 4;
            this.tpAccounts.Text = "Accounts";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.dgvAccount);
            this.panel24.Location = new System.Drawing.Point(5, 72);
            this.panel24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(1165, 574);
            this.panel24.TabIndex = 16;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AllowUserToOrderColumns = true;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 6);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(1162, 564);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellContentClick);
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.btnAddAccount);
            this.panel25.Location = new System.Drawing.Point(812, 2);
            this.panel25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(358, 68);
            this.panel25.TabIndex = 15;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(153, 4);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(202, 62);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Create new Account";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.label7);
            this.panel26.Location = new System.Drawing.Point(5, 2);
            this.panel26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(781, 68);
            this.panel26.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 54);
            this.label7.TabIndex = 10;
            this.label7.Text = "List accounts";
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.label8);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Controls.Add(this.dgvBill);
            this.tpBill.Controls.Add(this.label16);
            this.tpBill.Controls.Add(this.tbTotal);
            this.tpBill.Location = new System.Drawing.Point(4, 29);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(1179, 657);
            this.tpBill.TabIndex = 5;
            this.tpBill.Text = "Bill Manager";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 54);
            this.label8.TabIndex = 18;
            this.label8.Text = "List Bills";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTables);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.btnDeletebill);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(874, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 568);
            this.panel1.TabIndex = 17;
            // 
            // cbTables
            // 
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(72, 109);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(210, 28);
            this.cbTables.TabIndex = 18;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(0, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tables";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.35231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.64769F));
            this.tableLayoutPanel2.Controls.Add(this.dtpToDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpFromDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(323, 99);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(71, 52);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(210, 27);
            this.dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(71, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(210, 27);
            this.dtpFromDate.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(3, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 28);
            this.label14.TabIndex = 4;
            this.label14.Text = "From";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 28);
            this.label15.TabIndex = 5;
            this.label15.Text = "To";
            // 
            // btnDeletebill
            // 
            this.btnDeletebill.Location = new System.Drawing.Point(170, 152);
            this.btnDeletebill.Name = "btnDeletebill";
            this.btnDeletebill.Size = new System.Drawing.Size(112, 56);
            this.btnDeletebill.TabIndex = 16;
            this.btnDeletebill.Text = "Delete";
            this.btnDeletebill.UseVisualStyleBackColor = true;
            this.btnDeletebill.Click += new System.EventHandler(this.btnDeletebill_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(4, 529);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(134, 29);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export to excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(4, 152);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(122, 56);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(6, 82);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 29;
            this.dgvBill.ShowEditingIcon = false;
            this.dgvBill.Size = new System.Drawing.Size(862, 569);
            this.dgvBill.TabIndex = 10;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(486, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 23);
            this.label16.TabIndex = 12;
            this.label16.Text = "Revenue (VNĐ)";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(623, 46);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(245, 27);
            this.tbTotal.TabIndex = 13;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 697);
            this.Controls.Add(this.tcAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Management";
            this.Load += new System.EventHandler(this.fAdmin_Load);
            this.Shown += new System.EventHandler(this.fAdmin_Shown);
            this.tcAdmin.ResumeLayout(false);
            this.tpFoods.ResumeLayout(false);
            this.tpFoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tpCategory.ResumeLayout(false);
            this.tpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodCategory)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tpTables.ResumeLayout(false);
            this.tpTables.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.tpAccounts.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.tpBill.ResumeLayout(false);
            this.tpBill.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpFoods;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmrFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.TabPage tpCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCategoryName;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnResetFood;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.DataGridView dgvFoodCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tpTables;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnUpdateTable;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label table;
        private System.Windows.Forms.TextBox tbTableName;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.Button btnResetTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeletebill;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbSearchTable;
        private System.Windows.Forms.Label label17;
    }
}
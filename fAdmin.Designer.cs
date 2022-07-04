
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
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFoodCategory = new System.Windows.Forms.DataGridView();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCategoryName = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.tpTables = new System.Windows.Forms.TabPage();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dgvTables = new System.Windows.Forms.DataGridView();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.btnUpdateTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.table = new System.Windows.Forms.Label();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txbTableId = new System.Windows.Forms.TextBox();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.panel24 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.btnViewAccount = new System.Windows.Forms.Button();
            this.btnUpdateAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.panel27 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panel28 = new System.Windows.Forms.Panel();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.panel30 = new System.Windows.Forms.Panel();
            this.user = new System.Windows.Forms.Label();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.tbpBill = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
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
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).BeginInit();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tpAccounts.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpFoods);
            this.tcAdmin.Controls.Add(this.tpCategory);
            this.tcAdmin.Controls.Add(this.tpTables);
            this.tcAdmin.Controls.Add(this.tpAccounts);
            this.tcAdmin.Controls.Add(this.tbpBill);
            this.tcAdmin.Location = new System.Drawing.Point(2, 5);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1187, 690);
            this.tcAdmin.TabIndex = 1;
            // 
            // tpFoods
            // 
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 54);
            this.label6.TabIndex = 4;
            this.label6.Text = "Food list";
            // 
            // dgvFoods
            // 
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Location = new System.Drawing.Point(6, 66);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersWidth = 40;
            this.dgvFoods.RowTemplate.Height = 24;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFoods.Size = new System.Drawing.Size(786, 595);
            this.dgvFoods.TabIndex = 0;
            this.dgvFoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoods_CellContentClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(803, 8);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(370, 54);
            this.panel6.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 54);
            this.label11.TabIndex = 0;
            this.label11.Text = "Search ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.btnResetFood);
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(803, 70);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 577);
            this.panel4.TabIndex = 1;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(239, 200);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(128, 62);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
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
            276447232,
            23283,
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "List categories";
            // 
            // dgvFoodCategory
            // 
            this.dgvFoodCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodCategory.Location = new System.Drawing.Point(10, 61);
            this.dgvFoodCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFoodCategory.MultiSelect = false;
            this.dgvFoodCategory.Name = "dgvFoodCategory";
            this.dgvFoodCategory.ReadOnly = true;
            this.dgvFoodCategory.RowHeadersWidth = 51;
            this.dgvFoodCategory.RowTemplate.Height = 24;
            this.dgvFoodCategory.Size = new System.Drawing.Size(851, 589);
            this.dgvFoodCategory.TabIndex = 0;
            this.dgvFoodCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodCategory_CellContentClick);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.panel11);
            this.panel15.Controls.Add(this.btnAddCategory);
            this.panel15.Location = new System.Drawing.Point(867, 62);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(306, 588);
            this.panel15.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.txbCategoryName);
            this.panel11.Location = new System.Drawing.Point(3, 4);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(300, 69);
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
            // txbCategoryName
            // 
            this.txbCategoryName.AcceptsTab = true;
            this.txbCategoryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbCategoryName.Location = new System.Drawing.Point(97, 12);
            this.txbCategoryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCategoryName.MaxLength = 30;
            this.txbCategoryName.Name = "txbCategoryName";
            this.txbCategoryName.Size = new System.Drawing.Size(200, 24);
            this.txbCategoryName.TabIndex = 7;
            this.txbCategoryName.TabStop = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(6, 81);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(131, 92);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // tpTables
            // 
            this.tpTables.Controls.Add(this.panel16);
            this.tpTables.Controls.Add(this.panel17);
            this.tpTables.Controls.Add(this.panel19);
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
            // panel16
            // 
            this.panel16.Controls.Add(this.dgvTables);
            this.panel16.Location = new System.Drawing.Point(5, 84);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(804, 562);
            this.panel16.TabIndex = 12;
            // 
            // dgvTables
            // 
            this.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTables.Location = new System.Drawing.Point(0, 6);
            this.dgvTables.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTables.Name = "dgvTables";
            this.dgvTables.RowHeadersWidth = 51;
            this.dgvTables.RowTemplate.Height = 24;
            this.dgvTables.Size = new System.Drawing.Size(801, 552);
            this.dgvTables.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.Location = new System.Drawing.Point(815, 8);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(338, 70);
            this.panel17.TabIndex = 11;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.btnViewTable);
            this.panel19.Controls.Add(this.btnUpdateTable);
            this.panel19.Controls.Add(this.btnDeleteTable);
            this.panel19.Controls.Add(this.btnAddTable);
            this.panel19.Location = new System.Drawing.Point(5, 2);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(801, 70);
            this.panel19.TabIndex = 10;
            // 
            // btnViewTable
            // 
            this.btnViewTable.Location = new System.Drawing.Point(346, 4);
            this.btnViewTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(75, 62);
            this.btnViewTable.TabIndex = 4;
            this.btnViewTable.Text = "View";
            this.btnViewTable.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTable
            // 
            this.btnUpdateTable.Location = new System.Drawing.Point(236, 4);
            this.btnUpdateTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateTable.Name = "btnUpdateTable";
            this.btnUpdateTable.Size = new System.Drawing.Size(75, 62);
            this.btnUpdateTable.TabIndex = 3;
            this.btnUpdateTable.Text = "Update";
            this.btnUpdateTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Location = new System.Drawing.Point(122, 4);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(75, 62);
            this.btnDeleteTable.TabIndex = 2;
            this.btnDeleteTable.Text = "Delete";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            this.btnAddTable.Location = new System.Drawing.Point(3, 4);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(75, 62);
            this.btnAddTable.TabIndex = 1;
            this.btnAddTable.Text = "Add";
            this.btnAddTable.UseVisualStyleBackColor = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.panel23);
            this.panel20.Controls.Add(this.panel21);
            this.panel20.Controls.Add(this.panel22);
            this.panel20.Location = new System.Drawing.Point(815, 86);
            this.panel20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(358, 560);
            this.panel20.TabIndex = 9;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.comboBox1);
            this.panel23.Controls.Add(this.label9);
            this.panel23.Location = new System.Drawing.Point(3, 134);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(352, 58);
            this.panel23.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 15);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Status";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.table);
            this.panel21.Controls.Add(this.txbTableName);
            this.panel21.Location = new System.Drawing.Point(3, 69);
            this.panel21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(352, 58);
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
            // txbTableName
            // 
            this.txbTableName.AcceptsTab = true;
            this.txbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTableName.Location = new System.Drawing.Point(93, 12);
            this.txbTableName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTableName.MaxLength = 30;
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(236, 24);
            this.txbTableName.TabIndex = 7;
            this.txbTableName.TabStop = false;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label8);
            this.panel22.Controls.Add(this.txbTableId);
            this.panel22.Location = new System.Drawing.Point(3, 4);
            this.panel22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(352, 58);
            this.panel22.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "ID";
            // 
            // txbTableId
            // 
            this.txbTableId.AcceptsTab = true;
            this.txbTableId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTableId.Location = new System.Drawing.Point(93, 12);
            this.txbTableId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbTableId.MaxLength = 30;
            this.txbTableId.Name = "txbTableId";
            this.txbTableId.ReadOnly = true;
            this.txbTableId.Size = new System.Drawing.Size(236, 24);
            this.txbTableId.TabIndex = 7;
            this.txbTableId.TabStop = false;
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.panel24);
            this.tpAccounts.Controls.Add(this.panel25);
            this.tpAccounts.Controls.Add(this.panel26);
            this.tpAccounts.Controls.Add(this.panel27);
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
            this.panel24.Location = new System.Drawing.Point(5, 84);
            this.panel24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(801, 562);
            this.panel24.TabIndex = 16;
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(0, 4);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 24;
            this.dgvAccount.Size = new System.Drawing.Size(798, 554);
            this.dgvAccount.TabIndex = 0;
            // 
            // panel25
            // 
            this.panel25.Location = new System.Drawing.Point(812, 2);
            this.panel25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(338, 70);
            this.panel25.TabIndex = 15;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.btnViewAccount);
            this.panel26.Controls.Add(this.btnUpdateAccount);
            this.panel26.Controls.Add(this.btnDeleteAccount);
            this.panel26.Controls.Add(this.btnAddAccount);
            this.panel26.Location = new System.Drawing.Point(5, 2);
            this.panel26.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(801, 70);
            this.panel26.TabIndex = 14;
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Location = new System.Drawing.Point(346, 4);
            this.btnViewAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.Size = new System.Drawing.Size(75, 62);
            this.btnViewAccount.TabIndex = 4;
            this.btnViewAccount.Text = "View";
            this.btnViewAccount.UseVisualStyleBackColor = true;
            // 
            // btnUpdateAccount
            // 
            this.btnUpdateAccount.Location = new System.Drawing.Point(236, 4);
            this.btnUpdateAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateAccount.Name = "btnUpdateAccount";
            this.btnUpdateAccount.Size = new System.Drawing.Size(75, 62);
            this.btnUpdateAccount.TabIndex = 3;
            this.btnUpdateAccount.Text = "Update";
            this.btnUpdateAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(122, 4);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(75, 62);
            this.btnDeleteAccount.TabIndex = 2;
            this.btnDeleteAccount.Text = "Delete";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(3, 4);
            this.btnAddAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(75, 62);
            this.btnAddAccount.TabIndex = 1;
            this.btnAddAccount.Text = "Add";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.btnChangePassword);
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Controls.Add(this.panel29);
            this.panel27.Controls.Add(this.panel30);
            this.panel27.Location = new System.Drawing.Point(812, 84);
            this.panel27.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(361, 562);
            this.panel27.TabIndex = 13;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(226, 200);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(129, 62);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.cbAccountType);
            this.panel28.Controls.Add(this.label7);
            this.panel28.Location = new System.Drawing.Point(3, 134);
            this.panel28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(355, 58);
            this.panel28.TabIndex = 9;
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Location = new System.Drawing.Point(135, 15);
            this.cbAccountType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(217, 28);
            this.cbAccountType.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Type";
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.label10);
            this.panel29.Controls.Add(this.txbDisplayName);
            this.panel29.Location = new System.Drawing.Point(3, 69);
            this.panel29.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(355, 58);
            this.panel29.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Display Name";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.AcceptsTab = true;
            this.txbDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbDisplayName.Location = new System.Drawing.Point(135, 12);
            this.txbDisplayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDisplayName.MaxLength = 30;
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(217, 24);
            this.txbDisplayName.TabIndex = 7;
            this.txbDisplayName.TabStop = false;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.user);
            this.panel30.Controls.Add(this.txbUsername);
            this.panel30.Location = new System.Drawing.Point(3, 4);
            this.panel30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(355, 58);
            this.panel30.TabIndex = 5;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(3, 15);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(93, 18);
            this.user.TabIndex = 2;
            this.user.Text = "User Name";
            // 
            // txbUsername
            // 
            this.txbUsername.AcceptsTab = true;
            this.txbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbUsername.Location = new System.Drawing.Point(135, 12);
            this.txbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbUsername.MaxLength = 30;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.ReadOnly = true;
            this.txbUsername.Size = new System.Drawing.Size(217, 24);
            this.txbUsername.TabIndex = 7;
            this.txbUsername.TabStop = false;
            // 
            // tbpBill
            // 
            this.tbpBill.Location = new System.Drawing.Point(4, 29);
            this.tbpBill.Name = "tbpBill";
            this.tbpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBill.Size = new System.Drawing.Size(1179, 657);
            this.tbpBill.TabIndex = 5;
            this.tbpBill.Text = "Bill Manager";
            this.tbpBill.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(867, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(271, 41);
            this.label12.TabIndex = 10;
            this.label12.Text = "Add new category";
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
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTables)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.tpAccounts.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel29.PerformLayout();
            this.panel30.ResumeLayout(false);
            this.panel30.PerformLayout();
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
        private System.Windows.Forms.TabPage tpTables;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dgvTables;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnViewTable;
        private System.Windows.Forms.Button btnUpdateTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Label table;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbTableId;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Button btnViewAccount;
        private System.Windows.Forms.Button btnUpdateAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.TabPage tbpBill;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnResetFood;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.DataGridView dgvFoodCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
    }
}
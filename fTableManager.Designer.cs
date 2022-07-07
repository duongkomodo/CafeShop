
namespace CafeShop {
    partial class fTableManager {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lbxFoods = new System.Windows.Forms.ListBox();
            this.nmrQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.ptbFood = new System.Windows.Forms.PictureBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.FoodName = new System.Windows.Forms.ColumnHeader();
            this.count = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.nmrDiscount = new System.Windows.Forms.NumericUpDown();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbTableName = new System.Windows.Forms.Label();
            this.lbTableStatus = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbDisplayTable = new System.Windows.Forms.Label();
            this.flpTables = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearBill = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInfoToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.billToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1492, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountInfoToolStripMenuItem
            // 
            this.accountInfoToolStripMenuItem.Name = "accountInfoToolStripMenuItem";
            this.accountInfoToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.accountInfoToolStripMenuItem.Text = "Account Info";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.billToolStripMenuItem.Text = "Bill";
            this.billToolStripMenuItem.Click += new System.EventHandler(this.billToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnClearBill);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Controls.Add(this.lbxFoods);
            this.panel1.Controls.Add(this.nmrQuantity);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.ptbFood);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Location = new System.Drawing.Point(767, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 197);
            this.panel1.TabIndex = 2;
            // 
            // btnSubtract
            // 
            this.btnSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubtract.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(570, 121);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(124, 68);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbxFoods
            // 
            this.lbxFoods.FormattingEnabled = true;
            this.lbxFoods.ItemHeight = 20;
            this.lbxFoods.Location = new System.Drawing.Point(193, 45);
            this.lbxFoods.Name = "lbxFoods";
            this.lbxFoods.Size = new System.Drawing.Size(230, 144);
            this.lbxFoods.TabIndex = 6;
            this.lbxFoods.SelectedIndexChanged += new System.EventHandler(this.lbxFoods_SelectedIndexChanged);
            // 
            // nmrQuantity
            // 
            this.nmrQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmrQuantity.Location = new System.Drawing.Point(429, 77);
            this.nmrQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrQuantity.Name = "nmrQuantity";
            this.nmrQuantity.Size = new System.Drawing.Size(124, 38);
            this.nmrQuantity.TabIndex = 5;
            this.nmrQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.Location = new System.Drawing.Point(429, 121);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(124, 68);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // ptbFood
            // 
            this.ptbFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbFood.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbFood.ErrorImage")));
            this.ptbFood.InitialImage = null;
            this.ptbFood.Location = new System.Drawing.Point(6, 10);
            this.ptbFood.Name = "ptbFood";
            this.ptbFood.Size = new System.Drawing.Size(180, 180);
            this.ptbFood.TabIndex = 2;
            this.ptbFood.TabStop = false;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(193, 9);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(231, 28);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(767, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 514);
            this.panel2.TabIndex = 3;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FoodName,
            this.count,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 3);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(708, 504);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // FoodName
            // 
            this.FoodName.Text = "Food Name";
            this.FoodName.Width = 200;
            // 
            // count
            // 
            this.count.Text = "Count";
            this.count.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total";
            this.columnHeader4.Width = 180;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnCheckout);
            this.panel3.Controls.Add(this.nmrDiscount);
            this.panel3.Controls.Add(this.tbTotalPrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Location = new System.Drawing.Point(767, 754);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(713, 89);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(386, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "VNĐ";
            // 
            // btnCheckout
            // 
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckout.Font = new System.Drawing.Font("Pristina", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheckout.Location = new System.Drawing.Point(535, 12);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(159, 70);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // nmrDiscount
            // 
            this.nmrDiscount.Location = new System.Drawing.Point(3, 54);
            this.nmrDiscount.Name = "nmrDiscount";
            this.nmrDiscount.Size = new System.Drawing.Size(122, 27);
            this.nmrDiscount.TabIndex = 5;
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(193, 53);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(187, 27);
            this.tbTotalPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(178, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Price:";
            // 
            // btnDiscount
            // 
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiscount.Location = new System.Drawing.Point(3, 3);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(122, 45);
            this.btnDiscount.TabIndex = 2;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lbTableName);
            this.panel4.Controls.Add(this.lbTableStatus);
            this.panel4.Controls.Add(this.label);
            this.panel4.Controls.Add(this.lbDisplayTable);
            this.panel4.Location = new System.Drawing.Point(12, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(749, 77);
            this.panel4.TabIndex = 5;
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTableName.ForeColor = System.Drawing.Color.Olive;
            this.lbTableName.Location = new System.Drawing.Point(175, 11);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(0, 35);
            this.lbTableName.TabIndex = 3;
            // 
            // lbTableStatus
            // 
            this.lbTableStatus.AutoSize = true;
            this.lbTableStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTableStatus.Location = new System.Drawing.Point(175, 47);
            this.lbTableStatus.Name = "lbTableStatus";
            this.lbTableStatus.Size = new System.Drawing.Size(0, 23);
            this.lbTableStatus.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(107, 47);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 23);
            this.label.TabIndex = 1;
            this.label.Text = "Status:";
            // 
            // lbDisplayTable
            // 
            this.lbDisplayTable.AutoSize = true;
            this.lbDisplayTable.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbDisplayTable.Location = new System.Drawing.Point(3, 9);
            this.lbDisplayTable.Name = "lbDisplayTable";
            this.lbDisplayTable.Size = new System.Drawing.Size(179, 38);
            this.lbDisplayTable.TabIndex = 0;
            this.lbDisplayTable.Text = "Table Name:";
            // 
            // flpTables
            // 
            this.flpTables.BackColor = System.Drawing.Color.White;
            this.flpTables.BackgroundImage = global::CafeShop.Properties.Resources.background;
            this.flpTables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.flpTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpTables.Location = new System.Drawing.Point(12, 115);
            this.flpTables.Name = "flpTables";
            this.flpTables.Size = new System.Drawing.Size(749, 728);
            this.flpTables.TabIndex = 1;
            // 
            // btnClearBill
            // 
            this.btnClearBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearBill.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearBill.Location = new System.Drawing.Point(570, 47);
            this.btnClearBill.Name = "btnClearBill";
            this.btnClearBill.Size = new System.Drawing.Size(124, 68);
            this.btnClearBill.TabIndex = 8;
            this.btnClearBill.Text = "Clear Bill";
            this.btnClearBill.UseVisualStyleBackColor = true;
            this.btnClearBill.Click += new System.EventHandler(this.btnClearBill_Click);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1492, 855);
            this.Controls.Add(this.flpTables);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafeshop System Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbDisplayTable;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Label lbTableStatus;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox ptbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.NumericUpDown nmrQuantity;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader FoodName;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.NumericUpDown nmrDiscount;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxFoods;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTables;
        private System.Windows.Forms.Button btnClearBill;
    }
}
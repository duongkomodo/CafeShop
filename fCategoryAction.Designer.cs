
namespace CafeShop {
    partial class fCategoryAction {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCategoryAction));
            this.dgvFoods1 = new System.Windows.Forms.DataGridView();
            this.dgvFoods2 = new System.Windows.Forms.DataGridView();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbCurrentCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoods1
            // 
            this.dgvFoods1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods1.Location = new System.Drawing.Point(12, 77);
            this.dgvFoods1.Name = "dgvFoods1";
            this.dgvFoods1.RowHeadersWidth = 20;
            this.dgvFoods1.RowTemplate.Height = 29;
            this.dgvFoods1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods1.Size = new System.Drawing.Size(377, 551);
            this.dgvFoods1.TabIndex = 0;
            // 
            // dgvFoods2
            // 
            this.dgvFoods2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods2.Location = new System.Drawing.Point(581, 76);
            this.dgvFoods2.Name = "dgvFoods2";
            this.dgvFoods2.RowHeadersWidth = 20;
            this.dgvFoods2.RowTemplate.Height = 29;
            this.dgvFoods2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods2.Size = new System.Drawing.Size(382, 551);
            this.dgvFoods2.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(581, 42);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(219, 28);
            this.cbCategory.TabIndex = 3;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(441, 237);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "=>";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(441, 332);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "<=";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbCurrentCategory
            // 
            this.lbCurrentCategory.AutoSize = true;
            this.lbCurrentCategory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCurrentCategory.Location = new System.Drawing.Point(12, 28);
            this.lbCurrentCategory.Name = "lbCurrentCategory";
            this.lbCurrentCategory.Size = new System.Drawing.Size(104, 41);
            this.lbCurrentCategory.TabIndex = 6;
            this.lbCurrentCategory.Text = "label1";
            // 
            // fCategoryAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 640);
            this.Controls.Add(this.lbCurrentCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.dgvFoods2);
            this.Controls.Add(this.dgvFoods1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCategoryAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fCategoryAction";
            this.Load += new System.EventHandler(this.fCategoryAction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoods1;
        private System.Windows.Forms.DataGridView dgvFoods2;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbCurrentCategory;
    }
}
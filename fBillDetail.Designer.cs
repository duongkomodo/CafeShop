
namespace CafeShop {
    partial class fBillDetail {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBillDetail));
            this.lsvBill = new System.Windows.Forms.ListView();
            this.FoodName = new System.Windows.Forms.ColumnHeader();
            this.count = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.tbTotalPrice = new System.Windows.Forms.Label();
            this.tbCheckout = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCheckin = new System.Windows.Forms.TextBox();
            this.tbDiscount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCashier = new System.Windows.Forms.TextBox();
            this.tbBillId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDiscountnum = new System.Windows.Forms.Label();
            this.lbTotalnum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsvBill
            // 
            this.lsvBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FoodName,
            this.count,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.FullRowSelect = true;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(12, 142);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(641, 486);
            this.lsvBill.TabIndex = 1;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
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
            // tbTotalPrice
            // 
            this.tbTotalPrice.AutoSize = true;
            this.tbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbTotalPrice.Location = new System.Drawing.Point(12, 671);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(178, 32);
            this.tbTotalPrice.TabIndex = 9;
            this.tbTotalPrice.Text = "Total Price: ";
            // 
            // tbCheckout
            // 
            this.tbCheckout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCheckout.Location = new System.Drawing.Point(114, 114);
            this.tbCheckout.Name = "tbCheckout";
            this.tbCheckout.ReadOnly = true;
            this.tbCheckout.Size = new System.Drawing.Size(245, 20);
            this.tbCheckout.TabIndex = 7;
            this.tbCheckout.Text = "12/2/222";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(365, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Check Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check In:";
            // 
            // tbCheckin
            // 
            this.tbCheckin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCheckin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCheckin.Location = new System.Drawing.Point(480, 114);
            this.tbCheckin.Name = "tbCheckin";
            this.tbCheckin.ReadOnly = true;
            this.tbCheckin.Size = new System.Drawing.Size(173, 20);
            this.tbCheckin.TabIndex = 6;
            this.tbCheckin.Text = "18/7/2002";
            // 
            // tbDiscount
            // 
            this.tbDiscount.AutoSize = true;
            this.tbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDiscount.Location = new System.Drawing.Point(12, 631);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(182, 29);
            this.tbDiscount.TabIndex = 13;
            this.tbDiscount.Text = "Discount (10%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(26, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cashier:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(404, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Bill ID:";
            // 
            // tbCashier
            // 
            this.tbCashier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCashier.Location = new System.Drawing.Point(114, 82);
            this.tbCashier.Name = "tbCashier";
            this.tbCashier.ReadOnly = true;
            this.tbCashier.Size = new System.Drawing.Size(273, 20);
            this.tbCashier.TabIndex = 16;
            this.tbCashier.Text = "name";
            // 
            // tbBillId
            // 
            this.tbBillId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBillId.Location = new System.Drawing.Point(480, 82);
            this.tbBillId.Name = "tbBillId";
            this.tbBillId.ReadOnly = true;
            this.tbBillId.Size = new System.Drawing.Size(173, 20);
            this.tbBillId.TabIndex = 17;
            this.tbBillId.Text = "2022";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(345, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 67);
            this.label9.TabIndex = 20;
            this.label9.Text = "RECEIPT";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(16, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 72);
            this.panel1.TabIndex = 21;
            // 
            // lbDiscountnum
            // 
            this.lbDiscountnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDiscountnum.Location = new System.Drawing.Point(455, 635);
            this.lbDiscountnum.Name = "lbDiscountnum";
            this.lbDiscountnum.Size = new System.Drawing.Size(198, 25);
            this.lbDiscountnum.TabIndex = 22;
            this.lbDiscountnum.Text = "100.000.000 VNĐ";
            this.lbDiscountnum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalnum
            // 
            this.lbTotalnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalnum.Location = new System.Drawing.Point(464, 671);
            this.lbTotalnum.Name = "lbTotalnum";
            this.lbTotalnum.Size = new System.Drawing.Size(198, 29);
            this.lbTotalnum.TabIndex = 23;
            this.lbTotalnum.Text = "100.000.000 VNĐ";
            this.lbTotalnum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fBillDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 721);
            this.Controls.Add(this.lbTotalnum);
            this.Controls.Add(this.lbDiscountnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbCheckout);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbCashier);
            this.Controls.Add(this.tbBillId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCheckin);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lsvBill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fBillDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Detail";
            this.Load += new System.EventHandler(this.fBillDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ColumnHeader FoodName;
        private System.Windows.Forms.ColumnHeader count;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label tbTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCheckout;
        private System.Windows.Forms.TextBox tbCheckin;
        private System.Windows.Forms.Label tbDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCashier;
        private System.Windows.Forms.TextBox tbBillId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDiscountnum;
        private System.Windows.Forms.Label lbTotalnum;
    }
}
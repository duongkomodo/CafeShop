using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeShop.DAO;
using CafeShop.DTO;
namespace CafeShop {
    public partial class fBillDetail :Form {
        public fBillDetail() {
            InitializeComponent();
        }
        public int currbillId {
            get;
        }
        public fBillDetail(int billId) {
            InitializeComponent();
            currbillId = billId;
        }

        #region Function

        #endregion


        #region Event
        private void fBillDetail_Load(object sender,EventArgs e) {
       
            lsvBill.Items.Clear();
            List<FoodOrdered> billDetail = DAO.FoodOrderedDAO.Instance.GetBillDetail(currbillId);
            Bill bill = DAO.BillDAO.Instance.GetBill(currbillId);
            tbCheckin.Text = bill.DateCheckIn == null ? "" : bill.DateCheckIn.Value.ToString("dd-MMM-yyyy HH:mm");
            tbCheckout.Text  = bill.DateCheckOut == null ? "" : bill.DateCheckOut.Value.ToString("dd-MMM-yyyy HH:mm");
            Double totalBill = 0;
            tbBillId.Text = bill.Id.ToString();
       
            tbCashier.Text = AccountDAO.Instance.CashierName(bill.IdAccount);
            foreach (FoodOrdered item in billDetail) {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.Tag = item;
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString("c",CultureInfo.CreateSpecificCulture("vi-VN")));
                listViewItem.SubItems.Add(item.TotalPrice.ToString("c",CultureInfo.CreateSpecificCulture("vi-VN")));
                totalBill += item.TotalPrice;

                lsvBill.Items.Add(listViewItem);
            }
            double discountCash = (totalBill * bill.Discount) / 100;

            tbDiscount.Text = $"Discount {bill.Discount}%:";
            tbTotalPrice.Text = $"Total:";
            lbDiscountnum.Text = $"{discountCash.ToString("#,##0.#####")} VNĐ";
            lbTotalnum.Text = $"{bill.Total.ToString("#,##0.#####")} VNĐ";

        }


        #endregion


    }
}

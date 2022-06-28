using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fBillManager :Form {
        public fBillManager() {
            InitializeComponent();
        }

        #region Function

        public void DisplayBills(DateTime fromDate, DateTime toDate) {

            DataTable data = DAO.BillDAO.Instance.GetBillsCheckOut(fromDate.ToString("yyyy-MM-dd"),toDate.ToString("yyyy-MM-dd"));
            dgvBill.DataSource = data;
            decimal revenue = 0;
            foreach (DataRow row in data.Rows) {
                revenue +=  Convert.ToDecimal( row["Total Price"]);
            }
            tbTotal.Text = revenue.ToString("#,###.##");
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Setup() {
            DateTime myDate = DateTime.Now;
            DateTime startOfMonth = new DateTime(myDate.Year,myDate.Month,1);
            DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
            dtpFromDate.Value = startOfMonth;
            dtpToDate.Value = endOfMonth;

            DisplayBills(dtpFromDate.Value,dtpToDate.Value);
        }
        #endregion

        #region Event
        private void fBillManager_Load(object sender,EventArgs e) {
            Setup();
        }

        #endregion

        private void btnSearch_Click(object sender,EventArgs e) {
            DisplayBills(dtpFromDate.Value,dtpToDate.Value);
        }
    }
}

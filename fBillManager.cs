using ClosedXML.Excel;
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

        DataTable currDataTable = new DataTable();
        #region Function

        public void DisplayBills(DateTime fromDate,DateTime toDate) {

            currDataTable = DAO.BillDAO.Instance.GetBillsCheckOut(fromDate.ToString("yyyy-MM-dd"),toDate.ToString("yyyy-MM-dd"));
            dgvBill.DataSource = currDataTable;
            decimal revenue = 0;
            foreach (DataRow row in currDataTable.Rows) {
                revenue += Convert.ToDecimal(row["Total Price"]);
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

        private void btnSearch_Click(object sender,EventArgs e) {
            DisplayBills(dtpFromDate.Value,dtpToDate.Value);
        }

        private void btnExport_Click(object sender,EventArgs e) {
            if (currDataTable.Rows.Count != 0) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Files|*.xlsx;*.xlsm;*.xltx;*.xltm";
                sfd.FileName = "Doanh_thu_thang_.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK) {

                    using (var wb = new XLWorkbook()) {
                        wb.Worksheets.Add("Sheet1");
                        var wbSheet = wb.Worksheet(1);

                        var title1 = wbSheet.Cell("A1");
                        title1.Value = $"BÁO CÁO DOANH THU";
                        title1.Style.Font.Bold = true;
                        title1.Style.Font.FontName = "Times New Roman";
                        title1.Style.Font.FontSize = 16;
                        title1.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        title1.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        wbSheet.Range("A1:F1").Merge();

                        var title2 = wbSheet.Cell("A2");
                        title2.Value = $"Từ ngày {dtpFromDate.Value}      Đến ngày{dtpToDate.Value}";
                        title2.Style.Font.FontName = "Times New Roman";
                        title2.Style.Font.FontSize = 12;
                        title2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        title2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        wbSheet.Range("A2:F2").Merge();

                        var data = wbSheet.Cell("A5");
                        data.InsertTable(currDataTable);
                        wbSheet.Columns("A","O").AdjustToContents();
                        wb.SaveAs(sfd.FileName);

                    }

                }
            } else {
                MessageBox.Show("No bill exists in the table!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
        #endregion


    }
    
}

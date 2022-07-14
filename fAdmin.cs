using CafeShop.DTO;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fAdmin :Form {
        public fAdmin() {
            InitializeComponent();
            tcAdmin.SelectTab(0);
        }

        private void tcAdmin_Selecting(object sender,TabControlCancelEventArgs e) {
            TabPage current = (sender as TabControl).SelectedTab;
            switch (current.Name) {
                case "tpFoods":
                    SetUpFoodsTab();
                    break;
                case "tpAccounts":
                    SetUpAccountsTab();
                    break;
                case "tpCategory":
                    SetUpCategorysTab();
                    break;
                case "tpTables":
                    SetUpTablesTab();
                    break;
                case "tpBill":
                    SetupBillsTab();
                    break;

            }

            // Validate the current page. To cancel the select, use:

        }
        private void fAdmin_Shown(object sender,EventArgs e) {
            SetUpFoodsTab();

        }

        #region Food Tab
        #region Function
        public List<Food> ListFoods {
            get; set;
        }
        public List<Food> TempListFoods {
            get; set;
        }

        public void SetUpFoodsTab() {
            //dgvFoods
            ListFoods = DAO.FoodDAO.Instance.LoadAllFood();
            TempListFoods = ListFoods;
            DiplayFoods(TempListFoods);

            //cbCategory
            
            List<Category> categories = DAO.CategoryDAO.Instance.LoadAllCategory();
            categories.Insert(0,new Category() { Id = -1,Name = "Show All" });
            cbCategory.DataSource = categories;
            cbCategory.ValueMember = "id";
            cbCategory.DisplayMember = "name";
            cbCategory.SelectedValue = -1;
            CheckSetUp = true;
        }

        public void DiplayFoods(List<Food> list) {

            if (list.Count != 0) {
                dgvFoods.DataSource = null;
                dgvFoods.DataSource = list;

                dgvFoods.Columns["idCategory"].Visible = false;
                dgvFoods.Columns["id"].Visible = false;
                dgvFoods.Columns["inUse"].Visible = false;
                dgvFoods.Columns["image"].Visible = false;
                dgvFoods.AllowUserToResizeRows = false;
         


                if (dgvFoods.Columns.Contains("FoodImage")) {
                    dgvFoods.Columns.Remove("FoodImage");
                }

                if (dgvFoods.Columns.Contains("Edit")) {
                    dgvFoods.Columns.Remove("Edit");

                }
                if (dgvFoods.Columns.Contains("Delete")) {
                    dgvFoods.Columns.Remove("Delete");

                }
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn {
                    Name = "FoodImage",
                    HeaderText = "Food Image",
                    ValuesAreIcons = false,
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    Width = 150,
                    
                };
                dgvFoods.Columns.Insert(1,imageColumn);

                foreach (DataGridViewRow item in dgvFoods.Rows) {
                    Image img = Image.FromFile(@"D:\.Net Project\CafeShop\Image\Food\placeholder (Custom).png");
                    if (File.Exists(item.Cells["Image"].Value.ToString())) {

                      img = Image.FromFile(item.Cells["Image"].Value.ToString());

                    } 

                    item.Height = 150;
                    DataGridViewImageCell cell = item.Cells["FoodImage"] as DataGridViewImageCell;
                    cell.Value = img;

                }
                DataGridViewButtonColumn editcol = new DataGridViewButtonColumn() {
                    Name = "Edit",
                    Text = "Edit",
                    Width = 100,
                    FlatStyle = FlatStyle.Standard,
                    UseColumnTextForButtonValue = true
                };


                DataGridViewButtonColumn deletecol = new DataGridViewButtonColumn() {
                    Name = "Delete",
                    Text = "Delete",
                    Width = 100,
                    FlatStyle = FlatStyle.Standard,
                    UseColumnTextForButtonValue = true
                };
              
                dgvFoods.Columns.Add(editcol);
                dgvFoods.Columns.Add(deletecol);
                dgvFoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
  

        }


        public void InputFilter() {
           
         TempListFoods = ListFoods;

            if (cbCategory.SelectedIndex != 0) {
                TempListFoods = (from f in ListFoods where f.IdCategory == (int)cbCategory.SelectedValue select f).ToList();
            } 


            if (txbFoodName.Text.Trim() != "") {

                TempListFoods = (from f in TempListFoods where f.Name.ToLower().Contains(txbFoodName.Text.ToLower().Trim()) select f).ToList();
            }

            if (nmrFoodPrice.Value != 0) {
                TempListFoods = (from f in TempListFoods where Convert.ToDecimal(f.Price) >= nmrFoodPrice.Value select f).ToList();
            }

            DiplayFoods(TempListFoods);


        }

        #endregion

        #region Event
        bool CheckSetUp = false;


        private void btnResetFood_Click(object sender,EventArgs e) {
            nmrFoodPrice.Value = 0;
            txbFoodName.Text = "";
            cbCategory.SelectedValue = -1;
        }
        private void txbFoodId_TextChanged(object sender,EventArgs e) {
            if (CheckSetUp is true) {
                InputFilter();
            }
        }

        private void txbFoodName_TextChanged(object sender,EventArgs e) {
            if (CheckSetUp is true) {
                InputFilter();
            }
        }

        private void cbCategory_SelectedIndexChanged(object sender,EventArgs e) {
            if (CheckSetUp is true) {
                InputFilter();
            }
        }

        private void nmrFoodPrice_ValueChanged(object sender,EventArgs e) {
            if (CheckSetUp is true) {
                InputFilter();
            }
        }

        private void btnAddFood_Click(object sender,EventArgs e) {
            fFoodAction fFoodAction = new fFoodAction();
            var result = fFoodAction.ShowDialog();
            if (result != DialogResult.Cancel) {
                SetUpFoodsTab();
            }
        }

        private void dgvFoods_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;



            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Food food = TempListFoods[e.RowIndex];
            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Edit")) {

                fFoodAction fFoodAction = new fFoodAction(food);
             var result =  fFoodAction.ShowDialog();
                if (result == DialogResult.OK) {
                    SetUpFoodsTab();
                }
            }

            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Delete")) {
                //TODO - Button Clicked - Execute Code Here
                if (MessageBox.Show($"Delete {food.Name} ?","Waring",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes) {

                    DAO.FoodDAO.Instance.removeFood(food.Id);
                    SetUpFoodsTab();
                }
             }
            }



        #endregion

        #endregion

        #region Category Tab
        #region Function
        public List<Category> ListCategorys {
            get; set;
        }
 
        public List<Category> TempListCategorys {
            get; set;
        }

        public void SetUpCategorysTab() {
            //dgvCategorys
            ListCategorys = DAO.CategoryDAO.Instance.LoadAllCategory();
            ListCategorys = (from c in ListCategorys where c.Id > 1 select c).ToList();
            TempListCategorys = ListCategorys;
            DiplayCategorys(TempListCategorys);
            txbCategoryName.Text = "";
        }

        public void DiplayCategorys(List<Category> list) {

            if (list.Count != 0) {
                dgvFoodCategory.DataSource = null;
                
                dgvFoodCategory.DataSource = list;
                dgvFoodCategory.CurrentCell = null;


                dgvFoodCategory.Columns["id"].Visible = false;

                dgvFoodCategory.AllowUserToResizeRows = false;
             
                if (dgvFoodCategory.Columns.Contains("Edit")) {
                    dgvFoodCategory.Columns.Remove("Edit");
                }

                if (dgvFoodCategory.Columns.Contains("Delete")) {
                    dgvFoodCategory.Columns.Remove("Delete");
                }
     
                DataGridViewButtonColumn editcol = new DataGridViewButtonColumn() {
                    Name = "Edit",
                    Text = "Edit",
                    Width = 100,
                    FlatStyle = FlatStyle.Standard,
                    UseColumnTextForButtonValue = true
                };


                DataGridViewButtonColumn deletecol = new DataGridViewButtonColumn() {
                    Name = "Delete",
                    Text = "Delete",
                    Width = 100,
                    FlatStyle = FlatStyle.Standard,
                    UseColumnTextForButtonValue = true
                };
                dgvFoodCategory.Columns["name"].Width =(int) (dgvFoodCategory.Width * 0.67) ;
                dgvFoodCategory.Columns.Add(editcol);
                dgvFoodCategory.Columns.Add(deletecol);                          
            }
        }

        #endregion

        #region Event
        private void dgvFoodCategory_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;


          
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Category category = TempListCategorys[e.RowIndex];
            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Edit")) {
                fCategoryAction fCategoryAction = new fCategoryAction(category.Id);
                var result = fCategoryAction.ShowDialog();
                if (result == DialogResult.OK) {
                    SetUpCategorysTab();
                }
            }
            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Delete")) {
                //TODO - Button Clicked - Execute Code Here
                if (MessageBox.Show($"Delete {category.Name} ?","Waring",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {

                    DAO.CategoryDAO.Instance.removeCategory(category.Id);
                    SetUpCategorysTab();
                }
            }
        }
        private void btnAddCategory_Click(object sender,EventArgs e) {
            if (txbCategoryName.Text != "") {
                DAO.CategoryDAO.Instance.addCategory(txbCategoryName.Text.Trim());
                SetUpCategorysTab();
            } else {
                MessageBox.Show("Category's name is blank!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #endregion

        #region Table Tab
        #region Function
        public void SetUpTablesTab() {
            flpTables.Controls.Clear();
            List<Table> tableList = DAO.TableDAO.Instance.LoadTableList(true);
            foreach (Table table in tableList) {
                if (table.Id == 1) {
                    continue;
                }
                Button btnTable = new Button() {
                    Width = 143,
                    Height = 143,
                    Text = table.Name
                  + " " + Environment.NewLine + "In use: " + table.InUse
                  ,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1 },
                    BackgroundImage = Image.FromFile(@"D:\.Net Project\CafeShop\Image\Logo\TableLogo (Custom).png"),
                    ForeColor = Color.White,
                    Font = new Font(Font.FontFamily,10)
                };
                btnTable.Click += btn_Click;
                btnTable.Tag = table;
                switch (table.InUse) {
                    case false:
                        btnTable.BackColor = Color.Firebrick;
                        break;

                    default:
                        btnTable.BackColor = Color.Green;
                        break;
                }
                flpTables.Controls.Add(btnTable);
            }
        }


        #endregion

        #region Event
        private void btn_Click(object sender,EventArgs e) {
            Table table = (sender as Button).Tag as Table;
            tbTableName.Text = table.Name.Trim();
            tbTableName.Tag = table;
            if (table.InUse) {
                rbtnActive.Checked = true;

            } else {
                rbtnInactive.Checked = true;
            }

        }
        private void btnUpdateTable_Click(object sender,EventArgs e) {
            if (tbTableName.Tag != null) {
                Table table = tbTableName.Tag as Table;
                if (table.Status.Equals("Taken")) {
                    MessageBox.Show("This table is still working!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (table.Id == 1) {
                    MessageBox.Show("You cannot deactive takeaway, this will cause fatal damage to the system!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                bool inUse = false;
                if (rbtnActive.Checked) {
                    inUse = true;
                }
                string tableName = tbTableName.Text.Trim();
                DAO.TableDAO.Instance.UpdateTable(table.Id,tableName,inUse);
                SetUpTablesTab();
            } else {
                MessageBox.Show("Select a table first!","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnResetTable_Click(object sender,EventArgs e) {
            if (tbTableName.Tag != null) {
                Table table = tbTableName.Tag as Table;
                tbTableName.Text = table.Name.Trim();
                if (table.InUse) {
                    rbtnActive.Checked = true;

                } else {
                    rbtnInactive.Checked = true;
                }
            }
        }
        #endregion

        #endregion

        #region Account Tab
        #region Function
        public List<Account> ListAccounts {
            get; set;
        }

        public List<Account> TempListAccounts {
            get; set;
        }
        public void SetUpAccountsTab() {
            ListAccounts = DAO.AccountDAO.Instance.LoadAllAccount();
            DiplayAccounts(ListAccounts);

        }
        public void DiplayAccounts(List<Account> list) {

            if (list.Count != 0) {
                dgvAccount.DataSource = null;

                dgvAccount.DataSource = list;



                dgvAccount.Columns["id"].Visible = false;
                dgvAccount.Columns["password"].Visible = false;
                dgvAccount.Columns["avatar"].Visible = false;
                dgvAccount.Columns["roleid"].Visible = false;
                //dgvAccount.Columns["avatar"].Visible = false;

                if (dgvAccount.Columns.Contains("Edit")) {
                    dgvAccount.Columns.Remove("Edit");
                }

                if (dgvAccount.Columns.Contains("Delete")) {
                    dgvAccount.Columns.Remove("Delete");
                }

                DataGridViewButtonColumn editcol = new DataGridViewButtonColumn() {
                    Name = "Edit",
                    Text = "Edit",
                    Width = 100,
                    FlatStyle = FlatStyle.Standard,
                    UseColumnTextForButtonValue = true
                };


                DataGridViewButtonColumn deletecol = new DataGridViewButtonColumn() {
                    Name = "Delete",
                    Text = "Delete",
                    Width = 100,
                    FlatStyle = FlatStyle.Standard,
                    UseColumnTextForButtonValue = true
                };
                
                dgvAccount.Columns.Add(editcol);
                dgvAccount.Columns.Add(deletecol);
                dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                
            }
        }
        #endregion

        #region Event
        private void dgvAccount_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;



            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            Account account = ListAccounts[e.RowIndex];
            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Edit")) {

                fAccountAction action = new fAccountAction(account.Id);
                var result = action.ShowDialog();
                if (result == DialogResult.OK) {
                    SetUpAccountsTab();
                }
            }
            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Delete")) {
                /* TODO - Button Clicked - Execute Code Here*/
                if (MessageBox.Show($"Delete {account.UserName} ?","Waring",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes) {

                    DAO.AccountDAO.Instance.DeleteAccount(account.Id);
                    SetUpAccountsTab();
                }
            }
        }
        private void btnAddAccount_Click(object sender,EventArgs e) {
            fAccountAction action = new fAccountAction();
            var result = action.ShowDialog();
            if (result == DialogResult.OK) {
                SetUpAccountsTab();
            }
        }


        #endregion

        #endregion

        #region Bill Tab
        #region Function

        public DataTable currDataTable {
            get; set;
        }


        public void FilterBills() {
            currDataTable = DAO.BillDAO.Instance.GetCheckOutBillsByDate(dtpFromDate.Value.ToString("yyyy-MM-dd"),dtpToDate.Value.ToString("yyyy-MM-dd"));

            string TableName = ((Table)cbTables.SelectedItem).Name;
   
            if ((int)cbTables.SelectedValue != -1) {

                dgvBill.DataSource = null;
                dgvBill.DataSource = currDataTable;
                (dgvBill.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Table Name] = '{0}'",TableName);

            } else {
                dgvBill.DataSource = currDataTable;
            }

          
          

            decimal revenue = 0;
            foreach (DataRow row in currDataTable.Rows) {
                revenue += Convert.ToDecimal(row["Total Price"]);
            }

            if (dgvBill.Columns.Contains("Detail")) {
                dgvBill.Columns.Remove("Detail");
            }
 
            DataGridViewButtonColumn detailcol = new DataGridViewButtonColumn() {
                Name = "Detail",
                Text = "Detail",
                Width = 100,
                FlatStyle = FlatStyle.Standard,
                UseColumnTextForButtonValue = true
            };
            dgvBill.Columns.Add(detailcol);
            tbTotal.Text = revenue.ToString("#,###.##");
            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public void SetupBillsTab() {
            DateTime myDate = DateTime.Now;
            DateTime startOfYear = new DateTime(myDate.Year,1,1);
            DateTime endOfYear = new DateTime(myDate.Year,12,31);
            dtpFromDate.Value = startOfYear;
            dtpToDate.Value = endOfYear;
            List<Table> tables = DAO.TableDAO.Instance.LoadTableList(false);
            tables.Insert(0,new Table() { Id = -1,Name = "--Show All--" });
            cbTables.DataSource = tables;
            cbTables.ValueMember = "id";
            cbTables.DisplayMember = "Name";
            FilterBills();

            setupbilltab = true;
        }
        #endregion
        #region Event

        bool setupbilltab = false;
        private void btnSearch_Click(object sender,EventArgs e) {
            FilterBills();
        }


        private void cbTables_SelectedIndexChanged(object sender,EventArgs e) {
            if (setupbilltab is true) {
                FilterBills();
            }
         
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
                        title2.Value = $"Từ ngày {dtpFromDate.Value}      Đến ngày {dtpToDate.Value}";
                        title2.Style.Font.FontName = "Times New Roman";
                        title2.Style.Font.FontSize = 12;
                        title2.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        title2.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                        wbSheet.Range("A2:F2").Merge();

                        var data = wbSheet.Cell("A5");
                        data.InsertTable(currDataTable);
                        wbSheet.Columns("A","O").AdjustToContents();

                        var total = wbSheet.Cell(wbSheet.LastRowUsed().RowBelow().RowNumber(),"E");
                        var total2 = wbSheet.Cell(wbSheet.LastRowUsed().RowBelow().RowNumber(),"F");

                        wbSheet.Range(total,total2).Merge();
                        var total3 = wbSheet.Cell(wbSheet.LastRowUsed().RowBelow().RowNumber(),"G");
                        total.Value = $"Tổng doanh thu:";
                        total.Style.Font.FontName = "Times New Roman";
                        total.Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                        total.Style.Font.Bold = true;
                        total.Style.Font.FontSize = 16;
                        total3.Value = $"{tbTotal.Text} VNĐ";
                       
                        wb.SaveAs(sfd.FileName);
                        new Process {
                            StartInfo = new ProcessStartInfo(sfd.FileName) {
                                UseShellExecute = true
                            }
                        }.Start();

                    }

                }
            } else {
                MessageBox.Show("No bill exists in the table!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void dgvBill_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;


            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Detail")) {
                //TODO - Button Clicked - Execute Code Here
                fBillDetail view = new fBillDetail((int)senderGrid.Rows[e.RowIndex].Cells["id"].Value);

                view.ShowDialog();

            }
        }

        private void btnDeletebill_Click(object sender,EventArgs e) {
            if (dgvBill.SelectedRows.Count == 0 ) {
                MessageBox.Show("No bill selected!","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show($"Do you really want delete {dgvBill.SelectedRows.Count} bill(s)? ","Caution",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
                foreach (DataGridViewRow item in dgvBill.SelectedRows) {
                int selectedBill = Convert.ToInt32(item.Cells["id"].Value);
                DAO.BillInfoDAO.Instance.RemoveAllBillInfoByBillId(selectedBill);
                    SetupBillsTab();
            }

        }

        #endregion

        #endregion

    }

}


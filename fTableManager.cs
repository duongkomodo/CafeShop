using CafeShop.DAO;
using CafeShop.DTO;
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

namespace CafeShop {
    public partial class fTableManager :Form {
        public fTableManager() {
            InitializeComponent();
            try {
             LoadTable();
             loadCategory();
            } catch (Exception) {

                throw;
            }
         
        }


        #region Function
        void refreshTakeaway(int billId) {
         
            LoadBill(billId);
            LoadTakeaway();
        }
        void refreshTable(int tableId) {
            LoadBill(tableId);
            LoadTable();
        }

        void loadCategory() {
            List<Category> categories = CategoryDAO.Instance.LoadAllCategory();
            cbCategory.DataSource = categories;
            cbCategory.DisplayMember = "name";
            cbCategory.ValueMember = "id";
        }

        void loadFoodbyCategoryId(int id) {

            List<Food> foods = FoodDAO.Instance.LoadAllFoodByCategoryId(id);
            lbxFoods.DataSource = foods;
            lbxFoods.DisplayMember = "name";
            lbxFoods.ValueMember = "id";
        }

        void LoadBill(int id) {
            lsvBill.Items.Clear();

            List<FoodOrdered> listBillInfo = (isTakeAway == true? FoodOrderedDAO.Instance.GetListFoodOrderTakeAway(id): FoodOrderedDAO.Instance.GetListFoodOrder(id)) ;
            Double totalBill = 0;
            lbListCount.Tag = listBillInfo.Count;
            foreach (FoodOrdered item in listBillInfo) {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.Tag = item;
            
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString("c",CultureInfo.CreateSpecificCulture("vi-VN")));
                listViewItem.SubItems.Add(item.TotalPrice.ToString("c",CultureInfo.CreateSpecificCulture("vi-VN")));
                totalBill += item.TotalPrice;

                lsvBill.Items.Add(listViewItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            tbTotalPrice.Text = totalBill.ToString("#,##0.#####");


        }

        void LoadTable() {
            flpTables.Controls.Clear();
            List<Table> tableList = DAO.TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList) {
                Button btnTable = new Button() {
                    Width = 143,
                    Height = 143,
                    Text = table.Name
                  + " " + Environment.NewLine + "Status: " + table.Status
                  ,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1 },
                    BackgroundImage = Image.FromFile(@"D:\.Net Project\CafeShop\Image\Logo\TableLogo (Custom).png"),
                    ForeColor = Color.White,
                    Font = new Font(Font.FontFamily, 10)
            };
                btnTable.Click += btn_Click;
                btnTable.Tag = table;
                switch (table.Status) {
                    case "Empty":
                        btnTable.BackColor = Color.Firebrick;
                        break;

                    default:
                        btnTable.BackColor = Color.Green;
                        break;
                }
                flpTables.Controls.Add(btnTable);
            }
        }


        void LoadTakeaway() {
            flpTables.Controls.Clear();
            List<Bill> billList = DAO.BillDAO.Instance.GetBillTakeAway();
            int i = 1;
            foreach (Bill bill in billList) {
                Button btnBill = new Button() {
                    Width = 143,
                    Height = 143,
                    Text = $"Take Away {i}" 
                  ,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1 },
                    BackgroundImage = Image.FromFile(@"D:\.Net Project\CafeShop\Image\Logo\TableLogo (Custom).png"),
                    ForeColor = Color.White,
                    Font = new Font(Font.FontFamily,10)
                };
                btnBill.Click += BtnBill_Click;
                btnBill.Tag = bill;
                switch (bill.Status) {
                    case 0:
                        btnBill.BackColor = Color.Firebrick;
                        break;

                    default:
                        btnBill.BackColor = Color.Green;
                        break;
                }
                flpTables.Controls.Add(btnBill);
                i++;
            }
        }

        #endregion



        #region Events

        bool isTakeAway = false;
        private void btnTakeAway_Click(object sender,EventArgs e) {
            if (isTakeAway) {
                btnTakeAway.Text = "Tables List";
                lbTitle.Text = "Table Name:";
                lbStatus.Text = "Status:";
                lbTableName.Text = "";
                lbTableStatus.Text = "";
                btnAddTakeawayBill.Visible = false;
                btnRemoveTakeaway.Visible = false;
                LoadTable();
            } else {
                btnTakeAway.Text = "TakeAway List";
                lbTitle.Text = "Take Away:";
                lbStatus.Text = "";
                lbTableName.Text = "";
                lbTableStatus.Text = "";
                btnAddTakeawayBill.Visible = true;
                btnRemoveTakeaway.Visible = true;
                LoadTakeaway();
            }
            isTakeAway = !isTakeAway;
        }
        private void btnRemoveTakeaway_Click(object sender,EventArgs e) {
    
                Bill currBill = lsvBill.Tag as Bill;
                if (currBill != null) {
                    if (MessageBox.Show($"Do you really want to remove this takeaway bill ? ","Caution",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK) {
                        BillInfoDAO.Instance.RemoveAllBillInfoByBillId(currBill.Id);
                    BillDAO.Instance.RemoveTakeawayBill(currBill.Id);
                    refreshTakeaway(currBill.Id);
                    lsvBill.Tag = null;
                    lbTableName.Text = "";
                }
                }
        }
        private void btnAddTakeawayBill_Click(object sender,EventArgs e) {
            int idBillMax = BillDAO.Instance.InsertBill(1);
            refreshTakeaway(idBillMax);

        }
        private void BtnBill_Click(object sender,EventArgs e) {
            Bill currbill = ((sender as Button).Tag as Bill);
            lbTableName.Text = (sender as Button).Text;
            lsvBill.Tag = (sender as Button).Tag;
            LoadBill(currbill.Id);
        }

        private void btn_Click(object sender,EventArgs e) {
          
                Table currTable = ((sender as Button).Tag as Table);
                lbTableName.Text = currTable.Name;
                lbTableStatus.Text = currTable.Status;
            switch (currTable.Status) {
                case "Empty":
                    lbTableStatus.ForeColor = Color.Firebrick;
                    break;

                default:
                    lbTableStatus.ForeColor = Color.Green;
                    break;
            }
            lsvBill.Tag = (sender as Button).Tag;
                int tableId = currTable.Id;

                LoadBill(tableId);
        

        }

        private void cbCategory_SelectedIndexChanged(object sender,EventArgs e) {
       

            ComboBox cb = (sender as ComboBox);
            if (cb.SelectedItem == null) {

                return;

            } else {
                Category selected = cb.SelectedItem as Category;
                int id = selected.Id;

                loadFoodbyCategoryId(id);
            }


        }

        private void lbxFoods_SelectedIndexChanged(object sender,EventArgs e) {
            Food selectFood = lbxFoods.SelectedItem as Food;
            if (selectFood != null) {
                ptbFood.BackgroundImage = Image.FromFile(selectFood.Image);
                ptbFood.BackgroundImageLayout = ImageLayout.Stretch;
            }
           
        }


        private void btnAddFood_Click(object sender,EventArgs e) {

            if (isTakeAway) {
                Bill bill = lsvBill.Tag as Bill;
                if (bill != null) {
                
                    int foodID = (lbxFoods.SelectedItem as Food).Id;
                    int addCount = (int)nmrQuantity.Value;
                    BillInfoDAO.Instance.InsertBillInfo(bill.Id,foodID,addCount);
                    refreshTakeaway(bill.Id);
                } else {
                    MessageBox.Show("Choose a take away bill first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            } else {
                Table table = lsvBill.Tag as Table;
                if (table != null) {
                    int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                    int foodID = (lbxFoods.SelectedItem as Food).Id;
                    int addCount = (int)nmrQuantity.Value;

                    if (idBill == -1) {
                        int idBillMax = BillDAO.Instance.InsertBill(table.Id);

                        BillInfoDAO.Instance.InsertBillInfo(idBillMax,foodID,addCount);
                    } else {
                        BillInfoDAO.Instance.InsertBillInfo(idBill,foodID,addCount);
                    }
                    refreshTable(table.Id);
                } else {
                    MessageBox.Show("Choose a table first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            


        }

        private void btnClearBill_Click(object sender,EventArgs e) {
            if (isTakeAway) {
                Bill bill = lsvBill.Tag as Bill;
                if (bill != null) {

                    int result = BillInfoDAO.Instance.RemoveAllBillInfoByBillId(bill.Id);
                    refreshTakeaway(bill.Id);
                } else {
                    MessageBox.Show("Choose a take away bill first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            } else {
                Table table = lsvBill.Tag as Table;
                if (table != null) {
                    int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);


                    if (idBill == -1) {
                        MessageBox.Show("No item to clear !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    } else {
                        int result = BillInfoDAO.Instance.RemoveAllBillInfoByBillId(idBill);
                    }

                    refreshTable(table.Id);
                } else {
                    MessageBox.Show("Choose a table first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }

           
        }
        private void btnRemove_Click(object sender,EventArgs e) {
            if (isTakeAway) {
                Bill bill = lsvBill.Tag as Bill;
                if (bill != null) {

                    int foodID = (lbxFoods.SelectedItem as Food).Id;
                    int subtractCount = (int)nmrQuantity.Value * (-1);
                    BillInfoDAO.Instance.InsertBillInfo(bill.Id,foodID,subtractCount);
                    refreshTakeaway(bill.Id);
                } else {
                    MessageBox.Show("Choose a take away bill first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            } else {
                Table table = lsvBill.Tag as Table;
                if (table != null) {
                    int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                    int foodID = (lbxFoods.SelectedItem as Food).Id;
                    int subtractCount = (int)nmrQuantity.Value * (-1);

                    if (idBill == -1) {
                        int idBillMax = BillDAO.Instance.InsertBill(table.Id);

                        BillInfoDAO.Instance.InsertBillInfo(idBillMax,foodID,subtractCount);
                    } else {
                        BillInfoDAO.Instance.InsertBillInfo(idBill,foodID,subtractCount);
                    }

                    refreshTable(table.Id);
                } else {
                    MessageBox.Show("Choose a table first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }


        }

        private void lsvBill_SelectedIndexChanged(object sender,EventArgs e) {
            if (lsvBill.SelectedItems.Count > 0) {
                FoodOrdered item = (FoodOrdered)lsvBill.SelectedItems[0].Tag;
                Food currFood = FoodDAO.Instance.getFoodById(item.FoodId);
                cbCategory.SelectedValue = currFood.IdCategory;
                lbxFoods.SelectedValue = currFood.Id;

            }
        }

        private void btnCheckout_Click(object sender,EventArgs e) {
            if (isTakeAway) {
                Bill bill = lsvBill.Tag as Bill;
                if (bill != null) {
                    int discount = (int)nmrDiscount.Value;
                    decimal totalPrice = Convert.ToDecimal(tbTotalPrice.Text);
                    decimal finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

                    if ((int)lbListCount.Tag == 0) {
                        MessageBox.Show($"This takeaway have no item !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }

                    if (MessageBox.Show($"Do you really want to checkout this takeaway order?\n {totalPrice} - ({totalPrice} / 100) x {discount} = {finalTotalPrice}","Caution",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                        BillDAO.Instance.CheckOut(bill.Id,discount,finalTotalPrice);
                        lbTableName.Text = "";
                        lsvBill.Tag = null;
                        refreshTakeaway(bill.Id);
                    }
         
                } else {
                    MessageBox.Show("Choose a take away bill first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            } else {
                Table table = lsvBill.Tag as Table;
                if (table != null) {
                    int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                    int discount = (int)nmrDiscount.Value;

                    decimal totalPrice = Convert.ToDecimal(tbTotalPrice.Text);

                    decimal finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
                    if (idBill != -1 && (int)lbListCount.Tag > 0) {

                        if (MessageBox.Show($"Do you really want to checkout {table.Name}\n {totalPrice} - ({totalPrice} / 100) x {discount} = {finalTotalPrice}","Caution",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                            BillDAO.Instance.CheckOut(idBill,discount,finalTotalPrice);
                            refreshTable(table.Id);
                        }
                    } else {
                        MessageBox.Show($"This {table.Name} have no item !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                } else {
                    MessageBox.Show("Choose a table first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }


        }
        private void billToolStripMenuItem_Click(object sender,EventArgs e) {
            fBillManager fBill = new fBillManager();
            this.Hide();
            fBill.ShowDialog();
            this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender,EventArgs e) {
            fAdmin fAdmin = new fAdmin();
            this.Hide();
            fAdmin.ShowDialog();
            this.Show();
        }





        #endregion


    }
}

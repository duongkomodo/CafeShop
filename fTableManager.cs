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

            List<FoodOrdered> listBillInfo = FoodOrderedDAO.Instance.GetListMenu(id);
            Double totalBill = 0;
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
            List<Table> tables = DAO.TableDAO.Instance.LoadTableList();
            foreach (var item in tables) {
                Button btn = new Button() {
                    Width = 143,
                    Height = 143,
                    Text = item.Name
                  + " " + Environment.NewLine + "Status: " + item.Status
                  ,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 1 },
                    BackgroundImage = Image.FromFile(@"D:\.Net Project\CafeShop\Image\Logo\TableLogo (Custom).png"),
                    ForeColor = Color.White,
                    Font = new Font(Font.FontFamily, 10)
            };
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status) {
                    case "Empty":
                        btn.BackColor = Color.Firebrick;
                        break;

                    default:
                        btn.BackColor = Color.Green;
                        break;
                }
                flpTables.Controls.Add(btn);
            }
        }

        #endregion



        #region Events
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

                LoadBill(table.Id);
                LoadTable();
            } else {
                MessageBox.Show("Choose a table first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }


        }

        private void btnRemove_Click(object sender,EventArgs e) {
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

                LoadBill(table.Id);
                LoadTable();
            } else {
                MessageBox.Show("Choose a table first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            Table table = lsvBill.Tag as Table;
            if (table != null) {
                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.Id);
                int discount = (int)nmrDiscount.Value;

                decimal totalPrice = Convert.ToDecimal(tbTotalPrice.Text);

                decimal finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
                if (idBill != -1) {

                    if (MessageBox.Show($"Do you really want to checkout {table.Name}\n {totalPrice} - ({totalPrice} / 100) x {discount} = {finalTotalPrice}","Caution",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) {
                        BillDAO.Instance.CheckOut(idBill,discount,finalTotalPrice);
                        LoadBill(table.Id);
                        LoadTable();
                    }
                } else {
                    MessageBox.Show($"This {table.Name} is empty !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("Choose a table first !","Noti",MessageBoxButtons.OK,MessageBoxIcon.Information);
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

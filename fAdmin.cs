using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fAdmin :Form {
        public fAdmin() {
            InitializeComponent();

        }


        #region Food Tab
        #region Function
        public List<Food> ListFoods = new List<Food>();

        public void SetUpFoodsTab() {
            //dgvFoods
            ListFoods = DAO.FoodDAO.Instance.LoadAllFood();
            DiplayFoods(ListFoods);

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
                    ImageLayout = DataGridViewImageCellLayout.Stretch,
                    Width = 150,
                    
                };
                dgvFoods.Columns.Insert(1,imageColumn);

                foreach (DataGridViewRow item in dgvFoods.Rows) {
                    Image img = Image.FromFile(item.Cells["Image"].Value.ToString());
                    if (img != null) {
                        item.Height = 150;
                        DataGridViewImageCell cell = item.Cells[1] as DataGridViewImageCell;
                        cell.Value = img;
                        
                    }
                   
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
            String pattern;
            List<Food> TempList = ListFoods;

            if (cbCategory.SelectedIndex != 0) {
                TempList = (from f in ListFoods where f.IdCategory == (int)cbCategory.SelectedValue select f).ToList();
            } 


            if (txbFoodName.Text != "") {
                pattern = $"{txbFoodName.Text.ToLower()}+";
                TempList = (from f in TempList where Regex.IsMatch(f.Name.ToLower(),pattern) select f).ToList();
            }

            if (nmrFoodPrice.Value != 0) {
                TempList = (from f in TempList where Convert.ToDecimal(f.Price) >= nmrFoodPrice.Value select f).ToList();
            }

            DiplayFoods(TempList);


        }



        #endregion

        #region Event
        bool CheckSetUp = false;



        private void fAdmin_Shown(object sender,EventArgs e) {
            SetUpFoodsTab();
        }
        private void btnReset_Click(object sender,EventArgs e) {
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
            fFoodAction.ShowDialog();
            SetUpFoodsTab();
        }

        private void dgvFoods_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;


            Food food = ListFoods[e.RowIndex];
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (senderGrid.Columns[e.ColumnIndex].Name.Equals("Edit")) {
                fFoodAction fFoodAction = new fFoodAction(food);
                fFoodAction.ShowDialog();
                SetUpFoodsTab();
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

        #region

        #endregion

        #region

        #endregion

        #region

        #endregion


    }

}


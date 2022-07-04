using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fAdmin :Form {
        public fAdmin() {
            InitializeComponent();
            tcAdmin.SelectTab(0);
        }
        private void fAdmin_Shown(object sender,EventArgs e) {
            SetUpFoodsTab();
            SetUpCategorysTab();
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
                    DataGridViewImageCell cell = item.Cells[1] as DataGridViewImageCell;
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


            Food food = TempListFoods[e.RowIndex];
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
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

                dgvFoodCategory.Columns.Add(editcol);
                dgvFoodCategory.Columns.Add(deletecol);
                dgvFoodCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
             
            }


        }




        #endregion

        #region Event
        private void dgvFoodCategory_CellContentClick(object sender,DataGridViewCellEventArgs e) {
            var senderGrid = (DataGridView)sender;


            Category category = TempListCategorys[e.RowIndex];
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
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

        #region

        #endregion

        #region

        #endregion


    }

}


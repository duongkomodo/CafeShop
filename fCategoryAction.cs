using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fCategoryAction :Form {
        public fCategoryAction() {
            InitializeComponent();
        }

        public int currCategoryId {
            get;
        
        }

        public List<Category> listCategory {
            get;

        }

        bool checkSetup = false;
        public fCategoryAction(int categoryId) {
            InitializeComponent();
            currCategoryId = categoryId;
            listCategory = DAO.CategoryDAO.Instance.LoadAllCategory();
            Category currCategory = (from c in listCategory where c.Id == currCategoryId select c).FirstOrDefault();
            lbCurrentCategory.Text = currCategory.Name;
            this.Text = $"Edit Category - {currCategory.Name} ";
        }

        #region Function
        public void Setup() {
            if (currCategoryId != 0) {
                cbCategory.DataSource = (from c in listCategory where c.Id != currCategoryId select c).ToList();
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "id";
                SetupDgv(dgvFoods1,currCategoryId);
                SetupDgv(dgvFoods2,(int)cbCategory.SelectedValue);
                checkSetup = true;
            }

        }
        public void SetupDgv(DataGridView dgvFood, int categoryId) {

            dgvFood.DataSource = DAO.FoodDAO.Instance.LoadAllFoodByCategoryId(categoryId);
            dgvFood.Columns["idCategory"].Visible = false;
            dgvFood.Columns["id"].Visible = false;
            dgvFood.Columns["inUse"].Visible = false;
            dgvFood.Columns["image"].Visible = false;
            dgvFood.Columns["price"].Visible = false;
            if (dgvFood.Columns.Contains("FoodImage")) {
                dgvFood.Columns.Remove("FoodImage");
            }
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn {
                Name = "FoodImage",
                HeaderText = "Food Image",
                ValuesAreIcons = false,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100
            };

            dgvFood.Columns.Insert(1,imageColumn);
            foreach (DataGridViewRow item in dgvFood.Rows) {
                Image img = Image.FromFile(@"D:\.Net Project\CafeShop\Image\Food\placeholder (Custom).png");
                if (File.Exists(item.Cells["Image"].Value.ToString())) {
                    img = Image.FromFile(item.Cells["Image"].Value.ToString());
                }

                item.Height = 150;
                DataGridViewImageCell cell = item.Cells[1] as DataGridViewImageCell;
                cell.Value = img;
                dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
 
        #endregion

        #region Event
        private void fCategoryAction_Load(object sender,EventArgs e) {
            Setup();
        }
  private void cbCategory_SelectedIndexChanged(object sender,EventArgs e) {
            if (checkSetup == true) {
                SetupDgv(dgvFoods2,(int)cbCategory.SelectedValue);
            }
       
        }

        private void btnRemove_Click(object sender,EventArgs e) {
            foreach (DataGridViewRow selectedFood in dgvFoods1.SelectedRows) {
                DAO.FoodDAO.Instance.updateFoodCategory((int)cbCategory.SelectedValue,(int)selectedFood.Cells["id"].Value);
            }
            SetupDgv(dgvFoods1,currCategoryId);
            SetupDgv(dgvFoods2,(int)cbCategory.SelectedValue);
        }

        private void btnAdd_Click(object sender,EventArgs e) {
            foreach (DataGridViewRow selectedFood in dgvFoods2.SelectedRows) {
                DAO.FoodDAO.Instance.updateFoodCategory(currCategoryId,(int)selectedFood.Cells["id"].Value);
            }
            SetupDgv(dgvFoods1,currCategoryId);
            SetupDgv(dgvFoods2,(int)cbCategory.SelectedValue);
        }
    }
        #endregion

      
}

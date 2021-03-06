using CafeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeShop {
    public partial class fFoodAction :Form {
        public fFoodAction() {
            InitializeComponent();
        }
        public Food currFood {
            get;
        }
        public fFoodAction(Food f) {
            currFood = f;
            InitializeComponent();

        }

        #region Function
        public void SetUp() {
            if (currFood != null) {
                this.Text = $"Edit - {currFood.Name}";
                txbFoodName.Text = currFood.Name;

                cbCategory.DataSource = DAO.CategoryDAO.Instance.LoadAllCategory();
                cbCategory.ValueMember = "id";
                cbCategory.DisplayMember = "name";
                cbCategory.SelectedValue = currFood.IdCategory;

                nmrFoodPrice.Value = (int)currFood.Price;
                if (File.Exists(currFood.Image)) {
                    ptbFood.BackgroundImage = Image.FromFile(currFood.Image);
                    ptbFood.Tag = currFood.Image;
                } else {
                    ptbFood.BackgroundImage = Image.FromFile(@"Image\Food\placeholder (Custom).png");

                }
           

                
                ptbFood.BackgroundImageLayout = ImageLayout.Stretch;

            } else {
                this.Text = $"Add Food";
                cbCategory.DataSource = DAO.CategoryDAO.Instance.LoadAllCategory();
                cbCategory.ValueMember = "id";
                cbCategory.DisplayMember = "name";
            }
        
        }
        #endregion

        #region Event
        private void fFoodAction_Load(object sender,EventArgs e) {
            SetUp();
        }

        private void btnReset_Click(object sender,EventArgs e) {
            SetUp();
        }


        private void btnSaveChanges_Click(object sender,EventArgs e) {


            if (txbFoodName.Text =="") {
                MessageBox.Show("Food's name cannot leave blank!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
                return;
            }

            if (ptbFood.Tag == null) {
                MessageBox.Show("Food's image is not set!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            if (currFood != null) {

                if (MessageBox.Show($"Do you want save the changes for this food ?","Save changes",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) {

                    Food updFood = new Food() { Id = currFood.Id,Name = txbFoodName.Text,IdCategory = (int)cbCategory.SelectedValue,Price = (double)nmrFoodPrice.Value,Image = ptbFood.Tag.ToString() };
                    int result = DAO.FoodDAO.Instance.updateFood(updFood);
                    if (result < 0) {
                        MessageBox.Show("Save changes fail !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                    } else {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            } else {

                if (MessageBox.Show($"Do you want to add this food ? ","Save changes",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes) {
                    Food updFood = new Food() { Name = txbFoodName.Text,IdCategory = (int)cbCategory.SelectedValue,Price = (double)nmrFoodPrice.Value,Image = ptbFood.Tag.ToString() };
                    int result = DAO.FoodDAO.Instance.addFood(updFood);
                    if (result < 0) {
                        MessageBox.Show("Save changes fail !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.Cancel;
                    } else {
                        this.DialogResult = DialogResult.OK;
                    }

                }

            }
            this.Close();
        }
        private void btnUploadImage_Click(object sender,EventArgs e) {
            //Create a new instance of openFileDialog
            OpenFileDialog image = new OpenFileDialog();
            image.InitialDirectory = @"D:\.Net Project\CafeShop\Image\Food";
            //Filter
            image.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.tif;...";

            //When the user select the file
            if (image.ShowDialog() == DialogResult.OK) {
                //Get the file's path
                string imgPath = image.FileName;
                //Do something
                ptbFood.BackgroundImage = Image.FromFile(imgPath);
                ptbFood.BackgroundImageLayout = ImageLayout.Stretch;
                ptbFood.Tag = imgPath;
              

            }
        }

        private void fFoodAction_FormClosing(object sender,FormClosingEventArgs e) {
    
        }
        #endregion


    }
}

using Microsoft.EntityFrameworkCore;
using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKho1
{
    public partial class EditProduct : Form
    {
        Context db = new Context();
        Product product;
        long ProductID;
        public EditProduct(long ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            product = db.Products.Include(p => p.Category).Single(p => p.ProductID == ProductID);
            Text += " - Mã SP " + product.ProductID.ToString();
            txtName.Text = product.NameProduct;
            txtPrice.Text = product.Price.ToString();
            txtOrigin.Text = product.Origin;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DataSource = db.Categories.Select(c => new
            {
                c.CategoryID,
                c.NameCategory
            }).ToList();
            cbCategory.Text = product.Category.NameCategory;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                product.NameProduct = txtName.Text;
                product.Origin = txtOrigin.Text;
                product.Price = (int)Convert.ToDecimal(txtPrice.Text);
                product.CategoryID = Convert.ToInt64(cbCategory.SelectedValue);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, -0,
               0, 1000);
            }
        }
    }
}

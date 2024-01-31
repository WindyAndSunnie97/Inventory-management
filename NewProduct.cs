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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlyKho1
{
    public partial class NewProduct : Form
    {
        ProductDetail productDetail;
        Product product;
        public NewProduct()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                cbCategory.DisplayMember = "NameCategory";
                cbCategory.ValueMember = "CategoryID";
                cbCategory.DataSource = db.Categories.Select(c => new { c.CategoryID, c.NameCategory }).ToList();
                cbCategory.Text = null;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product();
                product.NameProduct = txtName.Text;
                product.Origin = txtOrigin.Text;
                product.Price = (int)Convert.ToDecimal(txtPrice.Text);
                product.CategoryID = Convert.ToInt64(cbCategory.SelectedValue);
                using (var db = new Context())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }
                txtName.Text = null;
                txtPrice.Text = null;
                txtOrigin.Text = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtName.Focus();

        }
    }
}

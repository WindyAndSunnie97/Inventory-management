using Microsoft.EntityFrameworkCore;
using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanlyKho1
{
    public partial class FormProduct : Form
    {
        public long CategoryID;
        public long InventoryID;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                cbInventory.DisplayMember = "NameInventory";
                cbInventory.ValueMember = "InventoryID";
                cbInventory.DataSource = db.Inventory.Select(c => new { c.InventoryID, c.NameInventory }).ToList();
                cbInventory.Text = null;
                cbCategory.DisplayMember = "NameCategory";
                cbCategory.ValueMember = "CategoryID";
                cbCategory.DataSource = db.Categories.Select(c => new { c.CategoryID, c.NameCategory }).ToList();
                cbCategory.Text = null;

            }

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                CategoryID = Convert.ToInt64(cbCategory.SelectedValue);
                dataGridView1.DataSource = db.Products.Where(p =>
               p.CategoryID == CategoryID).Select(p => new
               {
                   p.ProductID,
                   p.NameProduct,
                   p.Price,
                   p.Origin,
               }).ToList();

            }
        }

        private void cbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                InventoryID = Convert.ToInt64(cbInventory.SelectedValue);
                dataGridView1.DataSource = db.ProductsDetail.Where(p => p.InventoryID == InventoryID).Join(
            db.Products,
            ProductDetail => ProductDetail.ProductID,
            Product => Product.ProductID,
            (ProductDetail, Product) => new
            {
                ProductID = Product.ProductID,
                NameProduct = Product.NameProduct,
                Price = Product.Price,
                Origin = Product.Origin,
                Quantity = ProductDetail.Quantity,
            }).ToList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("NewProduct"))
                return;
            NewProduct f = new NewProduct();
            f.MdiParent = this.MdiParent;
            f.Show();

            /*var form = new NewProduct();
            form.Show();*/

        }

        private void FormProduct_Activated(object sender, EventArgs e)
        {
            cbCategory_SelectedIndexChanged(sender, e);
            cbInventory_SelectedIndexChanged(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long ProductID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["ProductID"].Value);
                    using (var db = new Context())
                    {
                        Product product =
                        db.Products.Single(c => c.ProductID == ProductID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + product.NameProduct, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                        {
                            db.Products.Remove(product);
                            db.SaveChanges();
                            FormProduct_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("EditProduct"))
                    return;
                EditProduct f = new EditProduct
               (Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();

                /*var form = new EditProduct(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value));
                form.Show();*/

            }
        }
    }
}

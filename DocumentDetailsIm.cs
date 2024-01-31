using Microsoft.EntityFrameworkCore;
using QuanlyKho1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyKho1
{
    public partial class DocumentDetailsIm : Form
    {
        private Context db = new Context();
        private long documentID;
        private long productID;
        private long inventoryID;
        public DocumentDetailsIm()
        {
            InitializeComponent();
        }
        private void groupBoxPerson_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 56);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 72);
        }



        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 115);
        }

        private void paint(PaintEventArgs e, int width)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            gfx.DrawLine(p, 0, 5, 0, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, 0, 5, 10, 5);
            gfx.DrawLine(p, width, 5, e.ClipRectangle.Width - 2, 5);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 5, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }
        private void DocumentDetails_Load_1(object sender, EventArgs e)
        {
            comboBoxDocument.DataSource = db.Documents.Where(i => i.Classify == 1).Select(i => i.DocumentID).ToList();
            comboBoxInventory.DisplayMember = "NameInventory";
            comboBoxInventory.ValueMember = "InventoryID";
            comboBoxInventory.DataSource = db.Inventory.Select(i => new Inventory { NameInventory = i.NameInventory, InventoryID = i.InventoryID }).ToList();
            comboBoxProduct.DisplayMember = "NameProduct";
            comboBoxProduct.ValueMember = "ProductID";
            comboBoxProduct.DataSource = db.Products.Select(i => new Product { NameProduct = i.NameProduct, ProductID = i.ProductID }).ToList();
            /*textBoxEmployeeName.Text = Utility.Employee.Name;*/
            textBoxEmployeeTitle.Text = "Nhân viên";
            loadData();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 80);
        }

        private void comboBoxDocument_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            documentID = Convert.ToInt64(comboBoxDocument.SelectedValue);
            var data = db.Documents.Include(i => i.Person)
                .Include(i => i.User)
                .Select(i => new { DocumentID = i.DocumentID, PersonName = i.Person.NamePerson, PersonAddress = i.Person.Address, PersonEmail = i.Person.Email, PersonPhone = i.Person.Phone, Classify = i.Classify, CreateDate = i.CreateDate, EmployeeName = i.User.NameUser, EmployeeEmail = i.User.Email })
                .Single(i => i.DocumentID == documentID);
            PersonName.Text = data.PersonName;
            PersonAddress.Text = data.PersonAddress;
            PersonEmail.Text = data.PersonEmail;
            PersonPhone.Text = data.PersonPhone;

            textBoxEmployeeName.Text = data.EmployeeName;
            UserEmail.Text = data.EmployeeEmail;
            textBoxCreateDate.Text = data.CreateDate.ToShortDateString();
            Classify.Text = data.Classify == 1 ? "Đơn nhập" : "Đơn xuất";
            groupBoxPerson.Text = data.Classify == 1 ? "SUPPLIER" : "CLIENT";
            groupBoxInventory.Text = data.Classify == 1 ? "IM_INVENTORY" : "EX_INVENTORY";
            loadData();
        }

        private void groupBoxPerson_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            productID = Convert.ToInt64(comboBoxProduct.SelectedValue);
            var data = db.Products.Include(i => i.Category).Single(i => i.ProductID == productID);
            textBoxCategory.Text = data.Category.NameCategory;
            textBoxPriceCurrent.Text = data.Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            documentID = Convert.ToInt64(comboBoxDocument.SelectedValue);
            productID = Convert.ToInt64(comboBoxProduct.SelectedValue);
            inventoryID = Convert.ToInt64(comboBoxInventory.SelectedValue);
            DcDetail detail = new DcDetail();
            ProductDetail productDetail = db.ProductsDetail.SingleOrDefault(i => i.ProductID == productID && i.InventoryID == inventoryID);
            if (productDetail != null)
            {
                productDetail.Quantity += Convert.ToInt32(maskedTextBoxQuantity.Text);
            }
            else
            {
                productDetail = new ProductDetail();
                productDetail.Quantity = Convert.ToInt32(maskedTextBoxQuantity.Text);
                productDetail.InventoryID = inventoryID;
                productDetail.ProductID = productID;
                db.ProductsDetail.Add(productDetail);
                db.SaveChanges();
            }
            detail.DocumentID = documentID;
            detail.Price = Convert.ToInt32(maskedTextBoxPrice.Text);
            detail.Quantity = Convert.ToInt32(maskedTextBoxQuantity.Text);
            detail.ProductDetailID = productDetail.ProductDetailID;
            db.DcDetail.Add(detail);
            db.SaveChanges();
            toolTip1.Show("Lưu thành công", button1, button1.Width, 0, 2000);
            loadData();
        }

        private void comboBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventoryID = Convert.ToInt64(comboBoxInventory.SelectedValue);
            var data = db.Inventory.Single(i => i.InventoryID == inventoryID);
            textBoxInventoryAddress.Text = data.Address;
        }
        private void loadData()
        {
            documentID = Convert.ToInt64(comboBoxDocument.SelectedValue);
            dataGridView1.DataSource = db.DcDetail
                 .Include(i => i.ProductDetail)
                 .Include(i => i.ProductDetail.Product)
                 .Include(i => i.ProductDetail.Inventory)
                 .Where(i => i.DocumentID == documentID)
                 .Select(i => new { DcDetailID = i.DcDetailID, ProductID = i.ProductDetail.ProductID, Price = i.Price, Quantity = i.Quantity, InventoryID = i.ProductDetail.InventoryID, TotalPrice = i.Price * i.Quantity })
                 .ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                long dcDetailID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["DcDetailID"].Value);
                var dcDetail = db.DcDetail.Single(i => i.DcDetailID == dcDetailID);
                long productID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID_"].Value);
                long InventoryName = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["InventoryID_"].Value);
                int Quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value);
                if (MessageBox.Show("Bạn muốn xóa " + dcDetail.DcDetailID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var productDetail = db.ProductsDetail
                        .Single(i => i.ProductID == productID && i.InventoryID == inventoryID);
                    if (productDetail.Quantity > 0)
                    {
                        productDetail.Quantity -= Quantity;
                        db.SaveChanges();
                    }
                    db.Remove(dcDetail);
                    db.SaveChanges();
                    loadData();
                }
            }
        }
    }
}

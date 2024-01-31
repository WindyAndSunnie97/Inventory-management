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
    public partial class DocumentDetailsEx : Form
    {
        private Context db = new Context();
        private long documentID { get; set; }
        private long inventoryID { get; set; }
        private long productID { get; set; }
        public DocumentDetailsEx()
        {
            InitializeComponent();
        }

        private void DocumentDetailsEx_Load(object sender, EventArgs e)
        {
            comboBoxDocument.DataSource = db.Documents.Where(i => i.Classify == 0).Select(i => i.DocumentID).ToList();
            comboBoxInventory.DisplayMember = "NameInventory";
            comboBoxInventory.ValueMember = "InventoryID";
            comboBoxInventory.DataSource = db.Inventory.Select(i => new Inventory { NameInventory = i.NameInventory, InventoryID = i.InventoryID }).ToList();
            comboBoxProduct.DisplayMember = "NameProduct";
            comboBoxProduct.ValueMember = "ProductID";
            /*textBoxEmployeeName.Text = Utility.Employee.Name;*/
            textBoxEmployeeTitle.Text = "Nhân viên";
            loadData();
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

        private void groupBoxPerson_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 72);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 72);
        }

        private void groupBoxInventory_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 115);
        }


        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            paint(e, 80);

        }

        private void comboBoxDocument_SelectedIndexChanged(object sender, EventArgs e)
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
            groupBoxPerson.Text = data.Classify == 1 ? "Nhà cung cấp" : "Khách hàng";
            groupBoxInventory.Text = data.Classify == 1 ? "Chọn kho nhập" : "Chọn kho xuất";
            loadData();
        }

        private void comboBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventoryID = Convert.ToInt64(comboBoxInventory.SelectedValue);
            var data = db.Inventory.Single(i => i.InventoryID == inventoryID);
            textBoxInventoryAddress.Text = data.Address;
            comboBoxProduct.DataSource = db.ProductsDetail
                .Include(i => i.Product)
                .Where(i => i.InventoryID == inventoryID)
                .Select(i => new { Name = i.Product.NameProduct, ProductID = i.ProductID }).ToList();
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


        private void comboBoxProduct_SelectionChangeCommitted(object sender, EventArgs e)
        {
            productID = Convert.ToInt64(comboBoxProduct.SelectedValue);
            inventoryID = Convert.ToInt64(comboBoxInventory.SelectedValue);
            var data = db.ProductsDetail
                .Include(i => i.Product)
                .Include(i => i.Product.Category)
                .Single(i => i.ProductID == productID && i.InventoryID == inventoryID);
            maskedTextBoxQuantityCurrent.Text = data.Quantity.ToString();
            textBoxCategory.Text = data.Product.Category.NameCategory.ToString();
            textBoxPriceCurrent.Text = data.Product.Price.ToString() + "đ";
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
                if (productDetail.Quantity > 0)
                {
                    productDetail.Quantity -= Convert.ToInt32(maskedTextBoxQuantity.Text);
                }
                else
                {
                    productDetail.Quantity = 0;
                }
            }
            else
            {
                MessageBox.Show("Lỗi không tìm thấy sản phẩm trong ProductDetails", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            detail.DocumentID = documentID;
            String[] price = textBoxPriceCurrent.Text.Split("đ");
            detail.Price = Convert.ToInt32(price[0]);
            detail.Quantity = Convert.ToInt32(maskedTextBoxQuantity.Text);
            detail.ProductDetailID = productDetail.ProductDetailID;
            db.DcDetail.Add(detail);
            db.SaveChanges();
            toolTip1.Show("Lưu thành công", button1, button1.Width, 0, 2000);
            loadData();
            maskedTextBoxQuantity.Text = null;
            comboBoxProduct_SelectionChangeCommitted(sender, e);
        }

        private void maskedTextBoxQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(maskedTextBoxQuantity.Text) > Convert.ToInt32(maskedTextBoxQuantityCurrent.Text))
            {
                toolTip1.Show("Vui lòng nhập số lượng nhỏ hơn: " + maskedTextBoxQuantity.Text.ToString(), maskedTextBoxQuantity, maskedTextBoxQuantity.Width, 0, 1000);
                maskedTextBoxQuantity.Focus();
            }
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
                if (MessageBox.Show("Bạn muốn xóa chi tiết phiếu " + dcDetail.DcDetailID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

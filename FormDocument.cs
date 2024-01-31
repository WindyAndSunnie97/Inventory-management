using Microsoft.EntityFrameworkCore;
using QLKH;
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
    public partial class FormDocument : Form
    {
        private const byte DOCUMENT_TYPE_IM = 1;
        private const byte DOCUMENT_TYPE_EX = 0;
        public FormDocument()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Documents.Include(i => i.User)
                    .Include(i => i.Person)
                    .Include(i => i.Person);
            }
        }

        private void FormDocument_Load(object sender, EventArgs e)
        {

            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Value";

        }

        private void getData(int type)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Documents
                    .Include(i => i.Person)
                    .Include(i => i.User)
                    .Where(i => i.Classify == type)
                    .Select(i => new { DocumentID = i.DocumentID, NamePerson = i.Person.NamePerson, Address = i.Person.Address, Phone = i.Person.Phone, Employee = i.User.NameUser, EmployeeEmail = i.User.Email, CreateDate = i.CreateDate })
                    .ToList();
            }
        }
        /*


                private void button1_Click(object sender, EventArgs e)
                {
                    String type = comboBox1.SelectedValue.ToString();
                    if (type == "Đơn nhập")
                    {
                        getData(DOCUMENT_TYPE_IM);
                    }
                    else if (type == "Đơn xuất")
                    {
                        getData(DOCUMENT_TYPE_EX);
                    }
                }*/

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("NewDocument"))
                return;
            NewDocument f = new NewDocument();
            f.MdiParent = this.MdiParent;
            f.Show();
            /*var form = new NewDocument();
            form.Show();*/

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Đơn nhập")
            {
                getData(DOCUMENT_TYPE_IM);
            }
            else if (comboBox1.Text == "Đơn xuất")
            {
                getData(DOCUMENT_TYPE_EX);
            }
        }

        private void btEx_Click(object sender, EventArgs e)
        {
            var form = new DocumentDetailsEx();
            form.Show();
        }

        private void btIm_Click(object sender, EventArgs e)
        {
            var form = new DocumentDetailsIm();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long DocumentID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["DocumentID"].Value);
                    using (var db = new Context())
                    {
                        Document document =
                        db.Documents.Single(c => c.DocumentID == DocumentID);
                        if (MessageBox.Show("Bạn muốn xóa phiếu " + document.DocumentID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                        {
                            db.Documents.Remove(document);
                            db.SaveChanges();
                            FormDocument_Activated(sender, e);
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

                /*var form = new EditDocument(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["DocumentID"].Value));
                form.Show();*/
            }
        }

        private void FormDocument_Activated(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                db.Documents.Load();
                dataGridView1.DataSource = db.Documents
                    .Include(i => i.Person)
                    .Include(i => i.User)
                    .Select(i => new { DocumentID = i.DocumentID, NamePerson = i.Person.NamePerson, Address = i.Person.Address, Phone = i.Person.Phone, Employee = i.User.NameUser, EmployeeEmail = i.User.Email, CreateDate = i.CreateDate })
                    .ToList();
            }
            comboBox1_SelectedIndexChanged_1(sender, e);

        }
    }
}

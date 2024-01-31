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
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void FormPerson_Activated(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Persons.Select(person => new { PersonID = person.PersonID, NamePerson = person.NamePerson, Address = person.Address, Phone = person.Phone, Email = person.Email }).ToList();
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                dataGridView1.DataSource = db.Persons.Select(person => new { PersonID = person.PersonID, NamePerson = person.NamePerson, Address = person.Address, Phone = person.Phone, Email = person.Email }).Where(c => c.NamePerson.Contains(txtName.Text)).ToList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("NewPerson"))
                return;
            NewPerson f = new NewPerson();
            f.MdiParent = this.MdiParent;
            f.Show();

            /*var form = new NewPerson();
            form.Show();*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long PersonID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["PersonID"].Value);
                    using (var db = new Context())
                    {
                        Person person =
                        db.Persons.Single(c => c.PersonID == PersonID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + person.NamePerson, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Persons.Remove(person);
                            db.SaveChanges();
                            FormPerson_Activated(sender, e);
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
                if (Utility.IsOpeningForm("EditPerson"))
                    return;
                EditPerson f = new EditPerson
               (Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["PersonID"].
               Value));
                f.MdiParent = this.MdiParent;
                f.Show();

                /*var form = new EditPerson(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["PersonID"].Value));
                form.Show();*/
            }
        }
    }
}

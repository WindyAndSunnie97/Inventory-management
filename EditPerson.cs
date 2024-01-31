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
    public partial class EditPerson : Form
    {
        Context db = new Context();
        Person person;
        long PersonID;
        public EditPerson(long PersonID)
        {
            InitializeComponent();
            this.PersonID = PersonID;
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            person = db.Persons.Single(p => p.PersonID == PersonID);
            Text += " - Mã Ps " + person.PersonID.ToString();
            txtName.Text = person.NamePerson;
            txtAddress.Text = person.Address;
            txtPhone.Text = person.Phone;
            txtEmail.Text = person.Email;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                person.NamePerson = txtName.Text;
                person.Address = txtAddress.Text;
                person.Phone = txtPhone.Text;
                person.Email = txtEmail.Text;
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, -0,
               0, 1000);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}

using SolrNet.Utils;
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
    public partial class FormMain : Form
    {
        private ToolStripMenuItem reportToolStripMenuItem;
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin form = new FormLogin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (Utility.employee.RoleID != 1)
                {
                    foreach (ToolStripMenuItem t in menuStrip1.Items)
                        foreach (ToolStripItem c in t.DropDownItems)
                            if (t != reportToolStripMenuItem)
                            {
                                if (c.Name.Contains("Document") && Utility.employee.RoleID == 0)
                                    break;
                                c.Enabled = false; //hoặc c.Visible = false;

                            }
                }
            }
        }


        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser f = new FormUser();
            f.MdiParent = this;
            f.Show();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerson f = new FormPerson();
            f.MdiParent = this;
            f.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInventory f = new FormInventory();
            f.MdiParent = this;
            f.Show();
        }



        private void manageDocumentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormDocument f = new FormDocument();
            f.MdiParent = this;
            f.Show();
        }


        private void manageProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProduct f = new FormProduct();
            f.MdiParent = this;
            f.Show();
        }

       

        private void processDocumentDetailsToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("reportbill"))
                return;
            reportbill f = new reportbill();
            f.MdiParent = this;
            f.Show();
        }
    }
}

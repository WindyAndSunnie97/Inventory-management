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
    public partial class FormLogin : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public FormLogin()
        {
            InitializeComponent();
            /*this.MouseDown += YourForm_MouseDown;
            this.MouseMove += YourForm_MouseMove;
            this.MouseUp += YourForm_MouseUp;*/
        }
        private void YourForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        /*private void YourForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void YourForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }*/
        private void FormLogin_Load(object sender, EventArgs e)
        {
            /*this.BackgroundImage = new Bitmap(Utility.ImagePath + "background1.jpg");
            this.textBox2.AutoSize = false;
            this.textBox1.AutoSize = false;
            this.textBox2.Size = new System.Drawing.Size(247, 40);
            this.textBox1.Size = new System.Drawing.Size(247, 40);*/
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox1.Text))
            {
                toolTip1.Show("Vui lòng nhập tên đăng nhập", textBox1, textBox1.Width, 0, 2000);
                textBox1.Focus();
                return;
            }
            if (String.IsNullOrEmpty(this.textBox2.Text))
            {
                toolTip1.Show("Vui lòng nhập mật khẩu", textBox2, textBox2.Width, 0, 2000);
                textBox2.Focus();
                return;
            }
            try
            {
                using (var db = new Context())
                {
                    Utility.employee = db.Users.SingleOrDefault(i => i.UserName == textBox1.Text && i.Password == textBox2.Text);
                }

                if (Utility.employee != null)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

namespace QuanlyKho1
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Loginbtn = new Button();
            ExitBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            toolTip1 = new ToolTip(components);
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(535, 166);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tên đăng nhập";
            textBox1.Size = new Size(280, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(535, 249);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Mật khẩu";
            textBox2.Size = new Size(280, 31);
            textBox2.TabIndex = 1;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = Color.FromArgb(255, 192, 255);
            Loginbtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            Loginbtn.FlatAppearance.BorderSize = 2;
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Poor Richard", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Loginbtn.ForeColor = Color.Black;
            Loginbtn.Location = new Point(13, 14);
            Loginbtn.Margin = new Padding(4, 4, 4, 4);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(188, 62);
            Loginbtn.TabIndex = 3;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.BackColor = Color.FromArgb(255, 192, 255);
            ExitBtn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 255);
            ExitBtn.FlatAppearance.BorderSize = 2;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Font = new Font("Poor Richard", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ExitBtn.ForeColor = Color.Black;
            ExitBtn.Location = new Point(233, 14);
            ExitBtn.Margin = new Padding(4, 4, 4, 4);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(188, 62);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Close";
            ExitBtn.UseVisualStyleBackColor = false;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(356, 166);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 37);
            label1.TabIndex = 5;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(379, 242);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 37);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poor Richard", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(513, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(193, 63);
            label3.TabIndex = 7;
            label3.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(ExitBtn);
            panel1.Controls.Add(Loginbtn);
            panel1.Location = new Point(379, 320);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 94);
            panel1.TabIndex = 8;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 212, 237);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1250, 834);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            DoubleBuffered = true;
            ForeColor = Color.SteelBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button Loginbtn;
        private Button ExitBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolTip toolTip1;
        private Panel panel1;
    }
}
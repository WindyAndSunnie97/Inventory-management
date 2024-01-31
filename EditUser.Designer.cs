namespace QuanlyKho1
{
    partial class EditUser
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
            panel2 = new Panel();
            txtRoleID = new TextBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btClose = new Button();
            btSave = new Button();
            txtName = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            tkh = new Label();
            em = new Label();
            panel1 = new Panel();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Honeydew;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtRoleID);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(tkh);
            panel2.Controls.Add(btClose);
            panel2.Controls.Add(em);
            panel2.Controls.Add(btSave);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(31, 31);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 710);
            panel2.TabIndex = 11;
            // 
            // txtRoleID
            // 
            txtRoleID.BackColor = Color.White;
            txtRoleID.Location = new Point(208, 536);
            txtRoleID.Margin = new Padding(4);
            txtRoleID.Name = "txtRoleID";
            txtRoleID.Size = new Size(344, 31);
            txtRoleID.TabIndex = 48;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Location = new Point(208, 435);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(344, 31);
            txtPassword.TabIndex = 46;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Location = new Point(208, 342);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(344, 31);
            txtUserName.TabIndex = 44;
            // 
            // btClose
            // 
            btClose.BackColor = Color.SeaGreen;
            btClose.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(385, 620);
            btClose.Margin = new Padding(4);
            btClose.Name = "btClose";
            btClose.Size = new Size(118, 50);
            btClose.TabIndex = 33;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.SeaGreen;
            btSave.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(244, 620);
            btSave.Margin = new Padding(4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 50);
            btSave.TabIndex = 32;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(208, 158);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 31);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(208, 247);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 31);
            txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(552, 130);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(752, 29);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(74, 435);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 29);
            label2.TabIndex = 52;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(59, 342);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 29);
            label1.TabIndex = 51;
            label1.Text = "User name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(106, 536);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 29);
            label3.TabIndex = 50;
            label3.Text = "RoleID:";
            // 
            // tkh
            // 
            tkh.AutoSize = true;
            tkh.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tkh.ForeColor = Color.SeaGreen;
            tkh.Location = new Point(114, 160);
            tkh.Margin = new Padding(4, 0, 4, 0);
            tkh.Name = "tkh";
            tkh.Size = new Size(86, 29);
            tkh.TabIndex = 48;
            tkh.Text = "Name:";
            // 
            // em
            // 
            em.AutoSize = true;
            em.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            em.ForeColor = Color.SeaGreen;
            em.Location = new Point(116, 247);
            em.Margin = new Padding(4, 0, 4, 0);
            em.Name = "em";
            em.Size = new Size(84, 29);
            em.TabIndex = 49;
            em.Text = "Email:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 102);
            panel1.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(231, 29);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 45);
            label4.TabIndex = 2;
            label4.Text = "EDIT USER";
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(741, 770);
            ControlBox = false;
            Controls.Add(panel2);
            Name = "EditUser";
            Text = "EditUser";
            FormClosing += EditUser_FormClosing;
            Load += EditUser_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btClose;
        private Button btSave;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label5;
        private Label label6;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private TextBox txtRoleID;
        private ToolTip toolTip1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label tkh;
        private Label em;
        private Panel panel1;
        private Label label4;
    }
}
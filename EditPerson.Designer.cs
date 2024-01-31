namespace QuanlyKho1
{
    partial class EditPerson
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
            btClose = new Button();
            btSave = new Button();
            txtName = new TextBox();
            tkh = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(btClose);
            panel2.Controls.Add(btSave);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(tkh);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtAddress);
            panel2.Location = new Point(30, 30);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(779, 376);
            panel2.TabIndex = 43;
            // 
            // btClose
            // 
            btClose.BackColor = Color.DarkCyan;
            btClose.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(570, 186);
            btClose.Margin = new Padding(4);
            btClose.Name = "btClose";
            btClose.Size = new Size(148, 54);
            btClose.TabIndex = 33;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.DarkCyan;
            btSave.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(570, 110);
            btSave.Margin = new Padding(4);
            btSave.Name = "btSave";
            btSave.Size = new Size(148, 54);
            btSave.TabIndex = 32;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Location = new Point(160, 50);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(344, 31);
            txtName.TabIndex = 0;
            // 
            // tkh
            // 
            tkh.AutoSize = true;
            tkh.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tkh.ForeColor = Color.DarkCyan;
            tkh.Location = new Point(66, 50);
            tkh.Margin = new Padding(4, 0, 4, 0);
            tkh.Name = "tkh";
            tkh.Size = new Size(86, 29);
            tkh.TabIndex = 28;
            tkh.Text = "Name:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(160, 270);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 31);
            txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 29);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 23;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Location = new Point(160, 199);
            txtPhone.Margin = new Padding(4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(344, 31);
            txtPhone.TabIndex = 4;
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
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.Location = new Point(160, 123);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(344, 31);
            txtAddress.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(60, 199);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 29);
            label1.TabIndex = 34;
            label1.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(43, 123);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 35;
            label2.Text = "Address:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(66, 270);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 29);
            label3.TabIndex = 36;
            label3.Text = "Email:";
            // 
            // EditPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(850, 440);
            ControlBox = false;
            Controls.Add(panel2);
            Name = "EditPerson";
            Text = "EditPerson";
            FormClosing += EditPerson_FormClosing;
            Load += EditPerson_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btClose;
        private Button btSave;
        private TextBox txtName;
        private Label tkh;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtAddress;
        private ToolTip toolTip1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
namespace QuanlyKho1
{
    partial class EditDocument
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
            PersonEmail = new TextBox();
            PersonPhone = new TextBox();
            PersonAddress = new TextBox();
            comboBoxPerson = new ComboBox();
            panel1 = new Panel();
            UserEmail = new TextBox();
            cbUser = new ComboBox();
            CreateDate = new DateTimePicker();
            btSave = new Button();
            panel2 = new Panel();
            toolTip1 = new ToolTip(components);
            btClose = new Button();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label6 = new Label();
            label10 = new Label();
            label5 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // PersonEmail
            // 
            PersonEmail.BackColor = Color.AliceBlue;
            PersonEmail.Enabled = false;
            PersonEmail.Location = new Point(701, 93);
            PersonEmail.Margin = new Padding(4);
            PersonEmail.Name = "PersonEmail";
            PersonEmail.Size = new Size(351, 31);
            PersonEmail.TabIndex = 7;
            // 
            // PersonPhone
            // 
            PersonPhone.BackColor = Color.AliceBlue;
            PersonPhone.Enabled = false;
            PersonPhone.Location = new Point(701, 34);
            PersonPhone.Margin = new Padding(4);
            PersonPhone.Name = "PersonPhone";
            PersonPhone.Size = new Size(351, 31);
            PersonPhone.TabIndex = 6;
            // 
            // PersonAddress
            // 
            PersonAddress.BackColor = Color.AliceBlue;
            PersonAddress.Enabled = false;
            PersonAddress.Location = new Point(149, 93);
            PersonAddress.Margin = new Padding(4);
            PersonAddress.Name = "PersonAddress";
            PersonAddress.Size = new Size(363, 31);
            PersonAddress.TabIndex = 5;
            // 
            // comboBoxPerson
            // 
            comboBoxPerson.BackColor = Color.AliceBlue;
            comboBoxPerson.FormattingEnabled = true;
            comboBoxPerson.Location = new Point(149, 34);
            comboBoxPerson.Margin = new Padding(4);
            comboBoxPerson.Name = "comboBoxPerson";
            comboBoxPerson.Size = new Size(351, 33);
            comboBoxPerson.TabIndex = 4;
            comboBoxPerson.SelectedIndexChanged += comboBoxPerson_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PersonEmail);
            panel1.Controls.Add(PersonPhone);
            panel1.Controls.Add(PersonAddress);
            panel1.Controls.Add(comboBoxPerson);
            panel1.Location = new Point(30, 27);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 168);
            panel1.TabIndex = 9;
            // 
            // UserEmail
            // 
            UserEmail.BackColor = Color.AliceBlue;
            UserEmail.Enabled = false;
            UserEmail.Location = new Point(227, 105);
            UserEmail.Margin = new Padding(4);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(397, 31);
            UserEmail.TabIndex = 13;
            // 
            // cbUser
            // 
            cbUser.BackColor = Color.AliceBlue;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(227, 40);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(397, 33);
            cbUser.TabIndex = 11;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // CreateDate
            // 
            CreateDate.CustomFormat = "dd/MM/yyyy";
            CreateDate.Format = DateTimePickerFormat.Custom;
            CreateDate.Location = new Point(783, 40);
            CreateDate.Margin = new Padding(4);
            CreateDate.Name = "CreateDate";
            CreateDate.Size = new Size(225, 31);
            CreateDate.TabIndex = 8;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Navy;
            btSave.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(878, 416);
            btSave.Margin = new Padding(4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 48);
            btSave.TabIndex = 11;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(UserEmail);
            panel2.Controls.Add(cbUser);
            panel2.Controls.Add(CreateDate);
            panel2.Location = new Point(30, 215);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 175);
            panel2.TabIndex = 10;
            // 
            // btClose
            // 
            btClose.BackColor = Color.Navy;
            btClose.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(1022, 416);
            btClose.Margin = new Padding(4);
            btClose.Name = "btClose";
            btClose.Size = new Size(118, 48);
            btClose.TabIndex = 12;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(32, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 13;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(55, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 29);
            label1.TabIndex = 12;
            label1.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(609, 93);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 29);
            label4.TabIndex = 15;
            label4.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(601, 34);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 29);
            label6.TabIndex = 14;
            label6.Text = "Phone:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(135, 105);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 29);
            label10.TabIndex = 18;
            label10.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(32, 40);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(188, 29);
            label5.TabIndex = 17;
            label5.Text = "Emloyee name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(701, 40);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 19;
            label7.Text = "Date:";
            // 
            // EditDocument
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1188, 492);
            ControlBox = false;
            Controls.Add(panel1);
            Controls.Add(btSave);
            Controls.Add(panel2);
            Controls.Add(btClose);
            Name = "EditDocument";
            Text = "EditDocument";
            FormClosing += EditDocument_FormClosing_1;
            Load += EditDocument_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox PersonEmail;
        private TextBox PersonPhone;
        private TextBox PersonAddress;
        private ComboBox comboBoxPerson;
        private Panel panel1;
        private TextBox UserEmail;
        private ComboBox cbUser;
        private DateTimePicker CreateDate;
        private Button btSave;
        private Panel panel2;
        private ToolTip toolTip1;
        private Button btClose;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label6;
        private Label label10;
        private Label label5;
        private Label label7;
    }
}
namespace QLKH
{
    partial class NewDocument
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
            btClose = new Button();
            btSave = new Button();
            panel2 = new Panel();
            label9 = new Label();
            comboBoxType = new ComboBox();
            UserEmail = new TextBox();
            label10 = new Label();
            cbUser = new ComboBox();
            CreateDate = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            PersonEmail = new TextBox();
            PersonPhone = new TextBox();
            PersonAddress = new TextBox();
            comboBoxPerson = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btClose
            // 
            btClose.BackColor = Color.Navy;
            btClose.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(1019, 405);
            btClose.Margin = new Padding(4);
            btClose.Name = "btClose";
            btClose.Size = new Size(118, 51);
            btClose.TabIndex = 7;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Navy;
            btSave.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(882, 405);
            btSave.Margin = new Padding(4);
            btSave.Name = "btSave";
            btSave.Size = new Size(118, 51);
            btSave.TabIndex = 6;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(comboBoxType);
            panel2.Controls.Add(UserEmail);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(cbUser);
            panel2.Controls.Add(CreateDate);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(27, 203);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 175);
            panel2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(668, 101);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 29);
            label9.TabIndex = 10;
            label9.Text = "Classify:";
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.AliceBlue;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Đơn nhập", "Đơn xuất" });
            comboBoxType.Location = new Point(780, 96);
            comboBoxType.Margin = new Padding(2);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(182, 33);
            comboBoxType.TabIndex = 9;
            // 
            // UserEmail
            // 
            UserEmail.BackColor = Color.AliceBlue;
            UserEmail.Enabled = false;
            UserEmail.Location = new Point(216, 99);
            UserEmail.Margin = new Padding(4);
            UserEmail.Name = "UserEmail";
            UserEmail.Size = new Size(386, 31);
            UserEmail.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(124, 101);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 29);
            label10.TabIndex = 12;
            label10.Text = "Email:";
            // 
            // cbUser
            // 
            cbUser.BackColor = Color.AliceBlue;
            cbUser.FormattingEnabled = true;
            cbUser.Location = new Point(216, 36);
            cbUser.Name = "cbUser";
            cbUser.Size = new Size(386, 33);
            cbUser.TabIndex = 11;
            cbUser.SelectedIndexChanged += cbUser_SelectedIndexChanged;
            // 
            // CreateDate
            // 
            CreateDate.CustomFormat = "dd/MM/yyyy";
            CreateDate.Format = DateTimePickerFormat.Custom;
            CreateDate.Location = new Point(780, 38);
            CreateDate.Margin = new Padding(4);
            CreateDate.Name = "CreateDate";
            CreateDate.Size = new Size(182, 31);
            CreateDate.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(698, 40);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 2;
            label7.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(32, 36);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(188, 29);
            label5.TabIndex = 0;
            label5.Text = "Emloyee name:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(PersonEmail);
            panel1.Controls.Add(PersonPhone);
            panel1.Controls.Add(PersonAddress);
            panel1.Controls.Add(comboBoxPerson);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 31);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1110, 143);
            panel1.TabIndex = 4;
            // 
            // PersonEmail
            // 
            PersonEmail.BackColor = Color.AliceBlue;
            PersonEmail.Enabled = false;
            PersonEmail.Location = new Point(688, 83);
            PersonEmail.Margin = new Padding(4);
            PersonEmail.Name = "PersonEmail";
            PersonEmail.Size = new Size(370, 31);
            PersonEmail.TabIndex = 7;
            // 
            // PersonPhone
            // 
            PersonPhone.BackColor = Color.AliceBlue;
            PersonPhone.Enabled = false;
            PersonPhone.Location = new Point(688, 24);
            PersonPhone.Margin = new Padding(4);
            PersonPhone.Name = "PersonPhone";
            PersonPhone.Size = new Size(370, 31);
            PersonPhone.TabIndex = 6;
            // 
            // PersonAddress
            // 
            PersonAddress.BackColor = Color.AliceBlue;
            PersonAddress.Enabled = false;
            PersonAddress.Location = new Point(149, 81);
            PersonAddress.Margin = new Padding(4);
            PersonAddress.Name = "PersonAddress";
            PersonAddress.Size = new Size(370, 31);
            PersonAddress.TabIndex = 5;
            // 
            // comboBoxPerson
            // 
            comboBoxPerson.BackColor = Color.AliceBlue;
            comboBoxPerson.FormattingEnabled = true;
            comboBoxPerson.Location = new Point(149, 24);
            comboBoxPerson.Margin = new Padding(4);
            comboBoxPerson.Name = "comboBoxPerson";
            comboBoxPerson.Size = new Size(370, 33);
            comboBoxPerson.TabIndex = 4;
            comboBoxPerson.SelectedIndexChanged += comboBoxPerson_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(596, 83);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 29);
            label4.TabIndex = 3;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(588, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 29);
            label3.TabIndex = 2;
            label3.Text = "Phone:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(32, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(55, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 29);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // NewDocument
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1193, 492);
            ControlBox = false;
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "NewDocument";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo đơn";
            Load += NewDocument_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btClose;
        private Button btSave;
        private Panel panel2;
        private DateTimePicker CreateDate;
        private Label label7;
        private Label label5;
        private Panel panel1;
        private TextBox PersonEmail;
        private TextBox PersonPhone;
        private TextBox PersonAddress;
        private ComboBox comboBoxPerson;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private ComboBox comboBoxType;
        private ToolTip toolTip1;
        private ComboBox cbUser;
        private TextBox UserEmail;
        private Label label10;
    }
}
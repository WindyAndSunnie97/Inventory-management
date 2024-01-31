namespace QuanlyKho1
{
    partial class NewInventory
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btClose = new Button();
            btSave = new Button();
            txtAddress = new TextBox();
            txtName = new TextBox();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btClose);
            panel1.Controls.Add(btSave);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(36, 35);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 357);
            panel1.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleVioletRed;
            label2.Location = new Point(36, 196);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 31;
            label2.Text = "Address:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleVioletRed;
            label1.Location = new Point(59, 128);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 29);
            label1.TabIndex = 30;
            label1.Text = "Name:";
            // 
            // btClose
            // 
            btClose.BackColor = Color.PaleVioletRed;
            btClose.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btClose.ForeColor = Color.White;
            btClose.Location = new Point(363, 274);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Size = new Size(161, 48);
            btClose.TabIndex = 29;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = false;
            btClose.Click += btClose_Click;
            // 
            // btSave
            // 
            btSave.BackColor = Color.PaleVioletRed;
            btSave.Font = new Font("Comic Sans MS", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(178, 274);
            btSave.Margin = new Padding(2);
            btSave.Name = "btSave";
            btSave.Size = new Size(161, 48);
            btSave.TabIndex = 28;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(151, 196);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(456, 31);
            txtAddress.TabIndex = 27;
            // 
            // txtName
            // 
            txtName.Location = new Point(151, 128);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(456, 31);
            txtName.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleVioletRed;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(683, 52);
            panel2.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(2, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(312, 45);
            label3.TabIndex = 2;
            label3.Text = "NEW INVENTORY";
            // 
            // NewInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(770, 440);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "NewInventory";
            Text = "NewInventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btClose;
        private Button btSave;
        private TextBox txtAddress;
        private TextBox txtName;
        private ToolTip toolTip1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
    }
}
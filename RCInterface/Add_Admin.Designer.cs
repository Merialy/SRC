namespace RCInterface
{
    partial class Add_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Admin));
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            maskedTextBox_phone = new MaskedTextBox();
            label1 = new Label();
            textBox_email = new TextBox();
            btn_add_Admin = new Button();
            textBox_middleName = new TextBox();
            textBox_firstName = new TextBox();
            textBox_lastName = new TextBox();
            mtb_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(161, 12);
            label8.Name = "label8";
            label8.Size = new Size(132, 23);
            label8.TabIndex = 0;
            label8.Text = "Заповніть поля:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(227, 204);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 0;
            label6.Text = "Пароль";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(174, 175);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 0;
            label5.Text = "Номер телефону";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(201, 143);
            label4.Name = "label4";
            label4.Size = new Size(78, 17);
            label4.TabIndex = 0;
            label4.Text = "По-батькові";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 111);
            label3.Name = "label3";
            label3.Size = new Size(35, 17);
            label3.TabIndex = 0;
            label3.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 79);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 0;
            label2.Text = "Прізвище";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Icon_Employee;
            pictureBox1.Location = new Point(14, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox_phone
            // 
            maskedTextBox_phone.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTextBox_phone.Location = new Point(285, 172);
            maskedTextBox_phone.Mask = "0000000000";
            maskedTextBox_phone.Name = "maskedTextBox_phone";
            maskedTextBox_phone.Size = new Size(126, 24);
            maskedTextBox_phone.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(164, 47);
            label1.Name = "label1";
            label1.Size = new Size(115, 17);
            label1.TabIndex = 0;
            label1.Text = "Електронна пошта";
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_email.Location = new Point(285, 44);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(126, 24);
            textBox_email.TabIndex = 1;
            textBox_email.KeyPress += textBox_email_KeyPress;
            // 
            // btn_add_Admin
            // 
            btn_add_Admin.BackColor = Color.LightGray;
            btn_add_Admin.FlatAppearance.BorderSize = 0;
            btn_add_Admin.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_Admin.Location = new Point(14, 175);
            btn_add_Admin.Name = "btn_add_Admin";
            btn_add_Admin.Size = new Size(141, 53);
            btn_add_Admin.TabIndex = 0;
            btn_add_Admin.Text = "Додати працівника";
            btn_add_Admin.UseVisualStyleBackColor = false;
            btn_add_Admin.Click += btn_add_Admin_Click;
            // 
            // textBox_middleName
            // 
            textBox_middleName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_middleName.Location = new Point(285, 140);
            textBox_middleName.Name = "textBox_middleName";
            textBox_middleName.Size = new Size(126, 24);
            textBox_middleName.TabIndex = 4;
            textBox_middleName.KeyPress += textBox_middleName_KeyPress;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_firstName.Location = new Point(285, 108);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(126, 24);
            textBox_firstName.TabIndex = 3;
            textBox_firstName.KeyPress += textBox_firstName_KeyPress;
            // 
            // textBox_lastName
            // 
            textBox_lastName.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_lastName.Location = new Point(285, 76);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(126, 24);
            textBox_lastName.TabIndex = 2;
            textBox_lastName.KeyPress += textBox_lastName_KeyPress;
            // 
            // mtb_password
            // 
            mtb_password.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_password.Location = new Point(285, 202);
            mtb_password.Name = "mtb_password";
            mtb_password.Size = new Size(126, 24);
            mtb_password.TabIndex = 6;
            mtb_password.KeyPress += mtb_password_KeyPress;
            // 
            // Add_Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 240);
            Controls.Add(mtb_password);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(maskedTextBox_phone);
            Controls.Add(label1);
            Controls.Add(textBox_email);
            Controls.Add(btn_add_Admin);
            Controls.Add(textBox_middleName);
            Controls.Add(textBox_firstName);
            Controls.Add(textBox_lastName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(440, 279);
            MinimizeBox = false;
            MinimumSize = new Size(440, 279);
            Name = "Add_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додавання адміністратора";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox_phone;
        private Label label1;
        private TextBox textBox_email;
        private Button btn_add_Admin;
        private TextBox textBox_middleName;
        private TextBox textBox_firstName;
        private TextBox textBox_lastName;
        private TextBox mtb_password;
    }
}
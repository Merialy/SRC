namespace RCApp
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label_surname = new Label();
            maskedTextBox_phone = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox_middleName = new TextBox();
            label_email = new Label();
            textBox_email = new TextBox();
            dtp_driverLicense = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label_phoneNumber = new Label();
            label_password = new Label();
            label3 = new Label();
            label_name = new Label();
            textBox_lastName = new TextBox();
            textBox_firstName = new TextBox();
            btn_sign_up = new Button();
            panel1 = new Panel();
            textBox_password = new TextBox();
            mtb_driverLicense = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label_surname
            // 
            label_surname.AutoSize = true;
            label_surname.Font = new Font("Comic Sans MS", 9.75F);
            label_surname.Location = new Point(208, 101);
            label_surname.Name = "label_surname";
            label_surname.Size = new Size(119, 18);
            label_surname.TabIndex = 12;
            label_surname.Text = "Введіть прізвище:";
            // 
            // maskedTextBox_phone
            // 
            maskedTextBox_phone.Font = new Font("Comic Sans MS", 9.75F);
            maskedTextBox_phone.Location = new Point(23, 286);
            maskedTextBox_phone.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox_phone.Mask = "0000000000";
            maskedTextBox_phone.Name = "maskedTextBox_phone";
            maskedTextBox_phone.Size = new Size(171, 26);
            maskedTextBox_phone.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Client;
            pictureBox1.Location = new Point(23, 71);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9.75F);
            label1.Location = new Point(208, 205);
            label1.Name = "label1";
            label1.Size = new Size(134, 18);
            label1.TabIndex = 30;
            label1.Text = "Введіть по-батькові:";
            // 
            // textBox_middleName
            // 
            textBox_middleName.Font = new Font("Comic Sans MS", 9.75F);
            textBox_middleName.Location = new Point(208, 227);
            textBox_middleName.Margin = new Padding(3, 4, 3, 4);
            textBox_middleName.Name = "textBox_middleName";
            textBox_middleName.Size = new Size(193, 26);
            textBox_middleName.TabIndex = 29;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Comic Sans MS", 9.75F);
            label_email.Location = new Point(208, 51);
            label_email.Name = "label_email";
            label_email.Size = new Size(93, 18);
            label_email.TabIndex = 28;
            label_email.Text = "Введіть email:";
            // 
            // textBox_email
            // 
            textBox_email.CharacterCasing = CharacterCasing.Lower;
            textBox_email.Font = new Font("Comic Sans MS", 9.75F);
            textBox_email.Location = new Point(208, 71);
            textBox_email.Margin = new Padding(3, 4, 3, 4);
            textBox_email.MaxLength = 30;
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(193, 26);
            textBox_email.TabIndex = 27;
            // 
            // dtp_driverLicense
            // 
            dtp_driverLicense.CalendarFont = new Font("Segoe UI", 11.25F);
            dtp_driverLicense.Font = new Font("Comic Sans MS", 9.75F);
            dtp_driverLicense.Format = DateTimePickerFormat.Short;
            dtp_driverLicense.Location = new Point(208, 346);
            dtp_driverLicense.Margin = new Padding(3, 4, 3, 4);
            dtp_driverLicense.MinDate = new DateTime(1940, 1, 1, 0, 0, 0, 0);
            dtp_driverLicense.Name = "dtp_driverLicense";
            dtp_driverLicense.RightToLeft = RightToLeft.No;
            dtp_driverLicense.Size = new Size(193, 26);
            dtp_driverLicense.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9.75F);
            label7.Location = new Point(208, 325);
            label7.Name = "label7";
            label7.Size = new Size(120, 18);
            label7.TabIndex = 23;
            label7.Text = "Дата народження:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 9.75F);
            label6.Location = new Point(23, 325);
            label6.Name = "label6";
            label6.Size = new Size(98, 18);
            label6.TabIndex = 21;
            label6.Text = "Введіть права:";
            // 
            // label_phoneNumber
            // 
            label_phoneNumber.AutoSize = true;
            label_phoneNumber.Font = new Font("Comic Sans MS", 9.75F);
            label_phoneNumber.Location = new Point(23, 264);
            label_phoneNumber.Name = "label_phoneNumber";
            label_phoneNumber.Size = new Size(166, 18);
            label_phoneNumber.TabIndex = 19;
            label_phoneNumber.Text = "Введіть номер телефону:";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Comic Sans MS", 9.75F);
            label_password.Location = new Point(208, 266);
            label_password.Name = "label_password";
            label_password.Size = new Size(106, 18);
            label_password.TabIndex = 15;
            label_password.Text = "Введіть пароль:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 20, 0, 0);
            label3.Size = new Size(185, 46);
            label3.TabIndex = 0;
            label3.Text = "Реєстрація в SRC";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Comic Sans MS", 9.75F);
            label_name.Location = new Point(208, 153);
            label_name.Name = "label_name";
            label_name.Size = new Size(88, 18);
            label_name.TabIndex = 9;
            label_name.Text = "Введіть ім'я:";
            // 
            // textBox_lastName
            // 
            textBox_lastName.Font = new Font("Comic Sans MS", 9.75F);
            textBox_lastName.Location = new Point(208, 123);
            textBox_lastName.Margin = new Padding(3, 4, 3, 4);
            textBox_lastName.Name = "textBox_lastName";
            textBox_lastName.Size = new Size(193, 26);
            textBox_lastName.TabIndex = 8;
            // 
            // textBox_firstName
            // 
            textBox_firstName.Font = new Font("Comic Sans MS", 9.75F);
            textBox_firstName.Location = new Point(208, 175);
            textBox_firstName.Margin = new Padding(3, 4, 3, 4);
            textBox_firstName.Name = "textBox_firstName";
            textBox_firstName.Size = new Size(193, 26);
            textBox_firstName.TabIndex = 7;
            // 
            // btn_sign_up
            // 
            btn_sign_up.BackColor = Color.Tan;
            btn_sign_up.Dock = DockStyle.Bottom;
            btn_sign_up.FlatAppearance.BorderSize = 0;
            btn_sign_up.FlatStyle = FlatStyle.Flat;
            btn_sign_up.Font = new Font("Comic Sans MS", 9F);
            btn_sign_up.Location = new Point(20, 400);
            btn_sign_up.Margin = new Padding(3, 4, 3, 4);
            btn_sign_up.Name = "btn_sign_up";
            btn_sign_up.Size = new Size(384, 38);
            btn_sign_up.TabIndex = 6;
            btn_sign_up.Text = "Створити акаунт";
            btn_sign_up.UseVisualStyleBackColor = false;
            btn_sign_up.Click += Btn_sign_up_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox_password);
            panel1.Controls.Add(mtb_driverLicense);
            panel1.Controls.Add(label_surname);
            panel1.Controls.Add(maskedTextBox_phone);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_middleName);
            panel1.Controls.Add(label_email);
            panel1.Controls.Add(textBox_email);
            panel1.Controls.Add(dtp_driverLicense);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label_phoneNumber);
            panel1.Controls.Add(label_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label_name);
            panel1.Controls.Add(textBox_lastName);
            panel1.Controls.Add(textBox_firstName);
            panel1.Controls.Add(btn_sign_up);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 20);
            panel1.Size = new Size(424, 458);
            panel1.TabIndex = 4;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Comic Sans MS", 9.75F);
            textBox_password.Location = new Point(208, 286);
            textBox_password.Margin = new Padding(3, 4, 3, 4);
            textBox_password.MaxLength = 30;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(193, 26);
            textBox_password.TabIndex = 114;
            // 
            // mtb_driverLicense
            // 
            mtb_driverLicense.Font = new Font("Comic Sans MS", 9.75F);
            mtb_driverLicense.Location = new Point(23, 346);
            mtb_driverLicense.Mask = ">LLL-000000";
            mtb_driverLicense.Name = "mtb_driverLicense";
            mtb_driverLicense.Size = new Size(171, 26);
            mtb_driverLicense.TabIndex = 113;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 473);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(460, 512);
            MinimizeBox = false;
            MinimumSize = new Size(460, 512);
            Name = "SignUp";
            Padding = new Padding(10, 10, 10, 5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація нового користувача";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label_surname;
        private MaskedTextBox maskedTextBox_phone;
        private PictureBox pictureBox1;
        private Label label1;
        protected TextBox textBox_middleName;
        private Label label_email;
        private TextBox textBox_email;
        private DateTimePicker dtp_driverLicense;
        private Label label7;
        private Label label6;
        private Label label_phoneNumber;
        private Label label_password;
        private Label label3;
        private Label label_name;
        private TextBox textBox_lastName;
        protected TextBox textBox_firstName;
        private Button btn_sign_up;
        private Panel panel1;
        private TextBox textBox_password;
        private MaskedTextBox mtb_driverLicense;
    }
}
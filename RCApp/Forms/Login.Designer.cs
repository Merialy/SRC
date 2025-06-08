namespace RCApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox_Hide = new PictureBox();
            linkLabel = new LinkLabel();
            label2 = new Label();
            mtb_password = new MaskedTextBox();
            label3 = new Label();
            btn_login = new Button();
            label1 = new Label();
            label_email = new Label();
            textBox_email = new TextBox();
            btn_sign_up = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Hide).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox_Hide);
            panel1.Controls.Add(linkLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(mtb_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label_email);
            panel1.Controls.Add(textBox_email);
            panel1.Controls.Add(btn_sign_up);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(7, 7);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20, 0, 20, 20);
            panel1.Size = new Size(285, 312);
            panel1.TabIndex = 0;
            // 
            // pictureBox_Hide
            // 
            pictureBox_Hide.Image = Properties.Resources.free_icon_hide_2767146;
            pictureBox_Hide.Location = new Point(241, 143);
            pictureBox_Hide.Name = "pictureBox_Hide";
            pictureBox_Hide.Size = new Size(15, 26);
            pictureBox_Hide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_Hide.TabIndex = 12;
            pictureBox_Hide.TabStop = false;
            pictureBox_Hide.Click += pictureBox_Hide_Click;
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new Point(153, 172);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(88, 15);
            linkLabel.TabIndex = 11;
            linkLabel.TabStop = true;
            linkLabel.Text = "Reset password";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F);
            label2.Location = new Point(41, 122);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 0;
            label2.Text = "Введіть пароль:";
            // 
            // mtb_password
            // 
            mtb_password.Font = new Font("Comic Sans MS", 9.75F);
            mtb_password.Location = new Point(41, 143);
            mtb_password.Name = "mtb_password";
            mtb_password.PasswordChar = '*';
            mtb_password.Size = new Size(200, 26);
            mtb_password.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Comic Sans MS", 14.25F);
            label3.Location = new Point(20, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(60, 20, 0, 0);
            label3.Size = new Size(189, 46);
            label3.TabIndex = 0;
            label3.Text = "Увійти в SRC";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Tan;
            btn_login.Dock = DockStyle.Bottom;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Comic Sans MS", 9F);
            btn_login.Location = new Point(20, 196);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(245, 37);
            btn_login.TabIndex = 0;
            btn_login.Text = "Увійти";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += Btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Comic Sans MS", 9.75F);
            label1.Location = new Point(20, 233);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 3, 0, 0);
            label1.Size = new Size(10, 21);
            label1.TabIndex = 10;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Font = new Font("Comic Sans MS", 9.75F);
            label_email.Location = new Point(41, 69);
            label_email.Name = "label_email";
            label_email.Size = new Size(93, 18);
            label_email.TabIndex = 0;
            label_email.Text = "Введіть email:";
            // 
            // textBox_email
            // 
            textBox_email.CharacterCasing = CharacterCasing.Lower;
            textBox_email.Font = new Font("Comic Sans MS", 9.75F);
            textBox_email.Location = new Point(41, 90);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(200, 26);
            textBox_email.TabIndex = 1;
            // 
            // btn_sign_up
            // 
            btn_sign_up.BackColor = Color.Tan;
            btn_sign_up.Dock = DockStyle.Bottom;
            btn_sign_up.FlatAppearance.BorderSize = 0;
            btn_sign_up.FlatStyle = FlatStyle.Flat;
            btn_sign_up.Font = new Font("Comic Sans MS", 9F);
            btn_sign_up.Location = new Point(20, 254);
            btn_sign_up.Name = "btn_sign_up";
            btn_sign_up.Size = new Size(245, 38);
            btn_sign_up.TabIndex = 0;
            btn_sign_up.Text = "Створити акаунт";
            btn_sign_up.UseVisualStyleBackColor = false;
            btn_sign_up.Click += Btn_sign_up_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 326);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(315, 365);
            MinimizeBox = false;
            MinimumSize = new Size(315, 365);
            Name = "Login";
            Padding = new Padding(7);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизація";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Hide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private MaskedTextBox mtb_password;
        private Label label3;
        private Button btn_login;
        private Label label1;
        private Label label_email;
        protected TextBox textBox_email;
        private Button btn_sign_up;
        private LinkLabel linkLabel;
        private PictureBox pictureBox_Hide;
    }
}
namespace RCApp
{
    partial class ResetPassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPassForm));
            panel1 = new Panel();
            ctb_newPass = new RCInterface.Controls.CustomTextBox();
            btn_changePass = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_userCode = new RCInterface.Controls.CustomTextBox();
            ctb_Email = new RCInterface.Controls.CustomTextBox();
            label = new Label();
            btn_confirmCode = new Button();
            btn_SendCode = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ctb_newPass);
            panel1.Controls.Add(btn_changePass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tb_userCode);
            panel1.Controls.Add(ctb_Email);
            panel1.Controls.Add(label);
            panel1.Controls.Add(btn_confirmCode);
            panel1.Controls.Add(btn_SendCode);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 500);
            panel1.TabIndex = 0;
            // 
            // ctb_newPass
            // 
            ctb_newPass.BackColor = Color.White;
            ctb_newPass.customBackColor = Color.White;
            ctb_newPass.customForeColor = Color.Black;
            ctb_newPass.customLabel = "Новий пароль";
            ctb_newPass.customMultiline = false;
            ctb_newPass.customText = "";
            ctb_newPass.Location = new Point(12, 294);
            ctb_newPass.Name = "ctb_newPass";
            ctb_newPass.Padding = new Padding(3);
            ctb_newPass.Password = false;
            ctb_newPass.Size = new Size(265, 44);
            ctb_newPass.TabIndex = 20;
            // 
            // btn_changePass
            // 
            btn_changePass.Location = new Point(12, 447);
            btn_changePass.Name = "btn_changePass";
            btn_changePass.Size = new Size(265, 44);
            btn_changePass.TabIndex = 19;
            btn_changePass.Text = "Змінити пароль";
            btn_changePass.UseVisualStyleBackColor = true;
            btn_changePass.Click += btn_changePass_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 186);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 18;
            label3.Text = "Змінити пароль";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(191, 17);
            label2.TabIndex = 17;
            label2.Text = "Для відновлення введіть email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(38, 24);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 16;
            label1.Text = "Забули свій пароль?";
            // 
            // tb_userCode
            // 
            tb_userCode.BackColor = Color.White;
            tb_userCode.customBackColor = Color.White;
            tb_userCode.customForeColor = Color.Black;
            tb_userCode.customLabel = "Введіть код";
            tb_userCode.customMultiline = false;
            tb_userCode.customText = "";
            tb_userCode.Location = new Point(12, 229);
            tb_userCode.Name = "tb_userCode";
            tb_userCode.Padding = new Padding(3);
            tb_userCode.Password = false;
            tb_userCode.Size = new Size(265, 44);
            tb_userCode.TabIndex = 15;
            // 
            // ctb_Email
            // 
            ctb_Email.BackColor = Color.White;
            ctb_Email.customBackColor = Color.White;
            ctb_Email.customForeColor = Color.Black;
            ctb_Email.customLabel = "Email";
            ctb_Email.customMultiline = false;
            ctb_Email.customText = "";
            ctb_Email.Location = new Point(12, 116);
            ctb_Email.Name = "ctb_Email";
            ctb_Email.Padding = new Padding(3);
            ctb_Email.Password = false;
            ctb_Email.Size = new Size(265, 44);
            ctb_Email.TabIndex = 14;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label.ForeColor = Color.FromArgb(0, 192, 0);
            label.Location = new Point(12, 276);
            label.Name = "label";
            label.Size = new Size(87, 15);
            label.TabIndex = 13;
            label.Text = "✅ Вірний код!";
            // 
            // btn_confirmCode
            // 
            btn_confirmCode.Location = new Point(12, 397);
            btn_confirmCode.Name = "btn_confirmCode";
            btn_confirmCode.Size = new Size(265, 44);
            btn_confirmCode.TabIndex = 12;
            btn_confirmCode.Text = "Підтвердити";
            btn_confirmCode.UseVisualStyleBackColor = true;
            btn_confirmCode.Click += Btn_CheckCode_Click;
            // 
            // btn_SendCode
            // 
            btn_SendCode.Location = new Point(12, 344);
            btn_SendCode.Name = "btn_SendCode";
            btn_SendCode.Size = new Size(265, 47);
            btn_SendCode.TabIndex = 7;
            btn_SendCode.Text = "Скинути пароль";
            btn_SendCode.UseVisualStyleBackColor = true;
            btn_SendCode.Click += btn_SendCode_Click;
            // 
            // ResetPassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 500);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResetPassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Скинути пароль";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label;
        private Button btn_confirmCode;
        private Button btn_SendCode;
        private RCInterface.Controls.CustomTextBox ctb_Email;
        private RCInterface.Controls.CustomTextBox tb_userCode;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btn_changePass;
        private RCInterface.Controls.CustomTextBox ctb_newPass;
    }
}
namespace RCApp.Forms
{
    partial class AboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMe));
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F);
            label3.Location = new Point(108, 12);
            label3.Name = "label3";
            label3.Size = new Size(227, 17);
            label3.TabIndex = 4;
            label3.Text = "Автор: Комолов Ілля Олександрович";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F);
            label2.Location = new Point(108, 35);
            label2.Name = "label2";
            label2.Size = new Size(203, 17);
            label2.TabIndex = 5;
            label2.Text = "Email: i.o.komolov@student.khai.edu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F);
            label4.Location = new Point(108, 59);
            label4.Name = "label4";
            label4.Size = new Size(207, 17);
            label4.TabIndex = 6;
            label4.Text = "Проєкт: SRC – облік оренди авто  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F);
            label5.Location = new Point(108, 82);
            label5.Name = "label5";
            label5.Size = new Size(60, 17);
            label5.TabIndex = 7;
            label5.Text = "Рік: 2025";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Client;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AboutMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 110);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(460, 264);
            MinimizeBox = false;
            Name = "AboutMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Про розробника";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
namespace RCInterface
{
    partial class Add_Auto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Auto));
            cb_class = new ComboBox();
            cb_type = new ComboBox();
            cb_color = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            mtb_price = new MaskedTextBox();
            label1 = new Label();
            tb_brand = new TextBox();
            btn_add_Admin = new Button();
            tb_model = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cb_class
            // 
            cb_class.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_class.FormattingEnabled = true;
            cb_class.Location = new Point(267, 109);
            cb_class.Name = "cb_class";
            cb_class.Size = new Size(126, 23);
            cb_class.TabIndex = 3;
            // 
            // cb_type
            // 
            cb_type.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_type.FormattingEnabled = true;
            cb_type.Location = new Point(267, 141);
            cb_type.Name = "cb_type";
            cb_type.Size = new Size(126, 23);
            cb_type.TabIndex = 4;
            // 
            // cb_color
            // 
            cb_color.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_color.FormattingEnabled = true;
            cb_color.Location = new Point(267, 173);
            cb_color.Name = "cb_color";
            cb_color.Size = new Size(126, 23);
            cb_color.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(320, 207);
            label7.Name = "label7";
            label7.Size = new Size(67, 17);
            label7.TabIndex = 0;
            label7.Text = "(грн/добу)";
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
            label6.Location = new Point(180, 207);
            label6.Name = "label6";
            label6.Size = new Size(79, 17);
            label6.TabIndex = 0;
            label6.Text = "Ціна оренди";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(180, 175);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 0;
            label5.Text = "Колір";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(180, 143);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 0;
            label4.Text = "Тип КПП";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 111);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 0;
            label3.Text = "Клас авто";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(180, 79);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 0;
            label2.Text = "Модель";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Auto;
            pictureBox1.Location = new Point(14, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 87;
            pictureBox1.TabStop = false;
            // 
            // mtb_price
            // 
            mtb_price.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mtb_price.Location = new Point(267, 204);
            mtb_price.Mask = "0000";
            mtb_price.Name = "mtb_price";
            mtb_price.Size = new Size(47, 24);
            mtb_price.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 0;
            label1.Text = "Бренд";
            // 
            // tb_brand
            // 
            tb_brand.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_brand.Location = new Point(267, 44);
            tb_brand.Name = "tb_brand";
            tb_brand.Size = new Size(126, 24);
            tb_brand.TabIndex = 1;
            // 
            // btn_add_Admin
            // 
            btn_add_Admin.BackColor = Color.LightGray;
            btn_add_Admin.FlatAppearance.BorderSize = 0;
            btn_add_Admin.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_Admin.Location = new Point(14, 175);
            btn_add_Admin.Name = "btn_add_Admin";
            btn_add_Admin.Size = new Size(152, 53);
            btn_add_Admin.TabIndex = 0;
            btn_add_Admin.Text = "Додати автомобіль";
            btn_add_Admin.UseVisualStyleBackColor = false;
            btn_add_Admin.Click += btn_add_Admin_Click;
            // 
            // tb_model
            // 
            tb_model.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_model.Location = new Point(267, 76);
            tb_model.Name = "tb_model";
            tb_model.Size = new Size(126, 24);
            tb_model.TabIndex = 2;
            // 
            // Add_Auto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 240);
            Controls.Add(cb_class);
            Controls.Add(cb_type);
            Controls.Add(cb_color);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(mtb_price);
            Controls.Add(label1);
            Controls.Add(tb_brand);
            Controls.Add(btn_add_Admin);
            Controls.Add(tb_model);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(423, 279);
            MinimizeBox = false;
            MinimumSize = new Size(423, 279);
            Name = "Add_Auto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додавання автомобіля";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_class;
        private ComboBox cb_type;
        private ComboBox cb_color;
        private Label label7;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private MaskedTextBox mtb_price;
        private Label label1;
        private TextBox tb_brand;
        private Button btn_add_Admin;
        private TextBox tb_model;
    }
}
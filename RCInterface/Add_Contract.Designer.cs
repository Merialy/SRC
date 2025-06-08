namespace RCInterface
{
    partial class Add_Contract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Contract));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            button_Add = new Button();
            freeCarsBindingSource = new BindingSource(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            tableClients1 = new TableClients();
            panel2 = new Panel();
            tableFreeCars1 = new TableFreeCars();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)freeCarsBindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_Add);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1087, 35);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 9);
            label2.Name = "label2";
            label2.Size = new Size(361, 20);
            label2.TabIndex = 2;
            label2.Text = "Вкажіть проміжок оренди та виберіть автомобіль:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(593, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Виберіть клієнта:";
            // 
            // button_Add
            // 
            button_Add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button_Add.BackColor = Color.DarkSeaGreen;
            button_Add.FlatAppearance.BorderSize = 0;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Location = new Point(913, 6);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(162, 26);
            button_Add.TabIndex = 0;
            button_Add.Text = "Додати договір";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += Button_Add_Click;
            // 
            // freeCarsBindingSource
            // 
            freeCarsBindingSource.DataSource = typeof(RCLibrary.FreeCars);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.42594F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.57406F));
            tableLayoutPanel1.Controls.Add(tableClients1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1087, 558);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // tableClients1
            // 
            tableClients1.Dock = DockStyle.Fill;
            tableClients1.IsColumn5Enabled = false;
            tableClients1.IsColumn7Enabled = false;
            tableClients1.Location = new Point(562, 3);
            tableClients1.Name = "tableClients1";
            tableClients1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableClients1.Size = new Size(522, 552);
            tableClients1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableFreeCars1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(553, 552);
            panel2.TabIndex = 3;
            // 
            // tableFreeCars1
            // 
            tableFreeCars1.Dock = DockStyle.Fill;
            tableFreeCars1.Location = new Point(0, 0);
            tableFreeCars1.Name = "tableFreeCars1";
            tableFreeCars1.Size = new Size(553, 552);
            tableFreeCars1.TabIndex = 0;
            // 
            // Add_Contract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 593);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1103, 632);
            MinimizeBox = false;
            MinimumSize = new Size(1103, 632);
            Name = "Add_Contract";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Додавання договору";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)freeCarsBindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private BindingSource freeCarsBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private TableClients tableClients1;
        private Panel panel2;
        private Button button_Add;
        private Label label2;
        private Label label1;
        private TableFreeCars tableFreeCars1;
    }
}
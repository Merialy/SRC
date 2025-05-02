using RCLibrary.Entities;

namespace RCInterface
{
    partial class TableClients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            clientBindingSource = new BindingSource(components);
            tSButton_Update = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tSButton_Remove = new ToolStripButton();
            tSButton_Add = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            textBox_search = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            driverLicenseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeClassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(726, 364);
            panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { emailDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, driverLicenseDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, typeClassDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clientBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(706, 364);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValidating += DataGridView1_CellValidating;
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataSource = typeof(Client);
            // 
            // tSButton_Update
            // 
            tSButton_Update.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSButton_Update.Image = Properties.Resources.refresh;
            tSButton_Update.ImageTransparentColor = Color.Magenta;
            tSButton_Update.Name = "tSButton_Update";
            tSButton_Update.Size = new Size(23, 22);
            tSButton_Update.Text = "toolStripButton3";
            tSButton_Update.ToolTipText = "Оновити дані у таблиці";
            tSButton_Update.Click += TSButton_Update_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tSButton_Remove
            // 
            tSButton_Remove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSButton_Remove.Image = Properties.Resources.Remove_User;
            tSButton_Remove.ImageTransparentColor = Color.Magenta;
            tSButton_Remove.Name = "tSButton_Remove";
            tSButton_Remove.Size = new Size(23, 22);
            tSButton_Remove.Text = "toolStripButton2";
            tSButton_Remove.ToolTipText = "Видалити клієнта";
            tSButton_Remove.Click += TSButton_Remove_Click;
            // 
            // tSButton_Add
            // 
            tSButton_Add.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSButton_Add.Image = Properties.Resources.Add_User;
            tSButton_Add.ImageTransparentColor = Color.Magenta;
            tSButton_Add.Name = "tSButton_Add";
            tSButton_Add.Size = new Size(23, 22);
            tSButton_Add.Text = "toolStripButton1";
            tSButton_Add.ToolTipText = "Додати нового клієнта";
            tSButton_Add.Click += TSButton_Add_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // textBox_search
            // 
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(100, 25);
            textBox_search.KeyUp += TextBox_search_KeyUp;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(49, 22);
            toolStripLabel1.Text = "Пошук:";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, textBox_search, toolStripSeparator1, tSButton_Add, tSButton_Remove, toolStripSeparator2, tSButton_Update });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(726, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Електронна пошта";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "Ім'я";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "По-батькові";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // driverLicenseDataGridViewTextBoxColumn
            // 
            driverLicenseDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            driverLicenseDataGridViewTextBoxColumn.DataPropertyName = "DriverLicense";
            driverLicenseDataGridViewTextBoxColumn.HeaderText = "Права";
            driverLicenseDataGridViewTextBoxColumn.Name = "driverLicenseDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "Дата народження";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "Номер телефону";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // typeClassDataGridViewTextBoxColumn
            // 
            typeClassDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            typeClassDataGridViewTextBoxColumn.DataPropertyName = "TypeClass";
            typeClassDataGridViewTextBoxColumn.HeaderText = "Роль";
            typeClassDataGridViewTextBoxColumn.Name = "typeClassDataGridViewTextBoxColumn";
            // 
            // TableClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "TableClients";
            Size = new Size(726, 389);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private ToolStripButton tSButton_Update;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tSButton_Remove;
        private ToolStripButton tSButton_Add;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox textBox_search;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip1;
        private BindingSource clientBindingSource;
        //private DataGridViewTextBoxColumn dateDriverLicenseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn driverLicenseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeClassDataGridViewTextBoxColumn;
    }
}

using RCLibrary.Entities;

namespace RCInterface
{
    partial class TableContracts
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
            contractBindingSource = new BindingSource(components);
            tSButton_Update = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tSButton_Remove = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            textBox_search = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            tSButton_Add = new ToolStripButton();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            renterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rentalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contractBindingSource).BeginInit();
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
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, renterDataGridViewTextBoxColumn, carDataGridViewTextBoxColumn, employeeDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, rentalPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = contractBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(706, 364);
            dataGridView1.TabIndex = 0;
            // 
            // contractBindingSource
            // 
            contractBindingSource.DataSource = typeof(Contract);
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
            tSButton_Update.Click += tSButton_Update_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // tSButton_Remove
            // 
            tSButton_Remove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSButton_Remove.Image = Properties.Resources.document_delete_256_icon_icons_com_75995;
            tSButton_Remove.ImageTransparentColor = Color.Magenta;
            tSButton_Remove.Name = "tSButton_Remove";
            tSButton_Remove.Size = new Size(23, 22);
            tSButton_Remove.Text = "toolStripButton2";
            tSButton_Remove.ToolTipText = "Видалити договір";
            tSButton_Remove.Click += tSButton_Remove_Click;
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
            textBox_search.KeyUp += textBox_search_KeyUp;
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
            // tSButton_Add
            // 
            tSButton_Add.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSButton_Add.Image = Properties.Resources.document_add_256_icon_icons_com_75994;
            tSButton_Add.ImageTransparentColor = Color.Magenta;
            tSButton_Add.Name = "tSButton_Add";
            tSButton_Add.Size = new Size(23, 22);
            tSButton_Add.Text = "toolStripButton1";
            tSButton_Add.ToolTipText = "Додати новий договір";
            tSButton_Add.Click += tSButton_Add_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Номер договору";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // renterDataGridViewTextBoxColumn
            // 
            renterDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            renterDataGridViewTextBoxColumn.DataPropertyName = "Renter";
            renterDataGridViewTextBoxColumn.HeaderText = "Орендар";
            renterDataGridViewTextBoxColumn.Name = "renterDataGridViewTextBoxColumn";
            renterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carDataGridViewTextBoxColumn
            // 
            carDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            carDataGridViewTextBoxColumn.HeaderText = "Автомобіль";
            carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            carDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Працівник";
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Дата початку оренди";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "Дата закінчення оренди";
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalPriceDataGridViewTextBoxColumn
            // 
            rentalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            rentalPriceDataGridViewTextBoxColumn.DataPropertyName = "RentalPrice";
            rentalPriceDataGridViewTextBoxColumn.HeaderText = "Ціна оренди (грн)";
            rentalPriceDataGridViewTextBoxColumn.Name = "rentalPriceDataGridViewTextBoxColumn";
            rentalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TableContracts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "TableContracts";
            Size = new Size(726, 389);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)contractBindingSource).EndInit();
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
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripTextBox textBox_search;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip1;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private BindingSource contractBindingSource;
        private ToolStripButton tSButton_Add;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn renterDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rentalPriceDataGridViewTextBoxColumn;
    }
}

using RCLibrary.Entities;

namespace RCInterface
{
    partial class TableAutos
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
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            textBox_search = new ToolStripTextBox();
            toolStripSeparator1 = new ToolStripSeparator();
            tSButton_Add = new ToolStripButton();
            tSButton_Remove = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tSButton_Update = new ToolStripButton();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            autoBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aclassDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            atypeDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            acolorDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            dailyPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)autoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, textBox_search, toolStripSeparator1, tSButton_Add, tSButton_Remove, toolStripSeparator2, tSButton_Update });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(747, 25);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(49, 22);
            toolStripLabel1.Text = "Пошук:";
            // 
            // textBox_search
            // 
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(100, 25);
            textBox_search.KeyUp += TextBox_search_KeyUp;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tSButton_Add
            // 
            tSButton_Add.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSButton_Add.Image = Properties.Resources.car;
            tSButton_Add.ImageTransparentColor = Color.Magenta;
            tSButton_Add.Name = "tSButton_Add";
            tSButton_Add.Size = new Size(23, 22);
            tSButton_Add.Text = "toolStripButton1";
            tSButton_Add.ToolTipText = "Додати новий автомобіль";
            tSButton_Add.Click += TSButton_Add_Click;
            // 
            // tSButton_Remove
            // 
            tSButton_Remove.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tSButton_Remove.Image = Properties.Resources.Remove_Car;
            tSButton_Remove.ImageTransparentColor = Color.Magenta;
            tSButton_Remove.Name = "tSButton_Remove";
            tSButton_Remove.Size = new Size(23, 22);
            tSButton_Remove.Text = "toolStripButton2";
            tSButton_Remove.ToolTipText = "Видалити автомобіль";
            tSButton_Remove.Click += TSButton_Remove_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
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
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 25);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(747, 360);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, aclassDataGridViewTextBoxColumn, atypeDataGridViewTextBoxColumn, acolorDataGridViewTextBoxColumn, dailyPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = autoBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(727, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValidating += DataGridView1_CellValidating;
            // 
            // autoBindingSource
            // 
            autoBindingSource.DataSource = typeof(Auto);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Бренд";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // aclassDataGridViewTextBoxColumn
            // 
            aclassDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aclassDataGridViewTextBoxColumn.DataPropertyName = "Aclass";
            aclassDataGridViewTextBoxColumn.FlatStyle = FlatStyle.Flat;
            aclassDataGridViewTextBoxColumn.HeaderText = "Клас авто";
            aclassDataGridViewTextBoxColumn.Name = "aclassDataGridViewTextBoxColumn";
            aclassDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            aclassDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // atypeDataGridViewTextBoxColumn
            // 
            atypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            atypeDataGridViewTextBoxColumn.DataPropertyName = "Atype";
            atypeDataGridViewTextBoxColumn.FlatStyle = FlatStyle.Flat;
            atypeDataGridViewTextBoxColumn.HeaderText = "Тип КПП";
            atypeDataGridViewTextBoxColumn.Name = "atypeDataGridViewTextBoxColumn";
            atypeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            atypeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // acolorDataGridViewTextBoxColumn
            // 
            acolorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            acolorDataGridViewTextBoxColumn.DataPropertyName = "Acolor";
            acolorDataGridViewTextBoxColumn.FlatStyle = FlatStyle.Flat;
            acolorDataGridViewTextBoxColumn.HeaderText = "Колір";
            acolorDataGridViewTextBoxColumn.Name = "acolorDataGridViewTextBoxColumn";
            acolorDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            acolorDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dailyPriceDataGridViewTextBoxColumn
            // 
            dailyPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dailyPriceDataGridViewTextBoxColumn.DataPropertyName = "DailyPrice";
            dailyPriceDataGridViewTextBoxColumn.HeaderText = "Ціна оренди (грн/добу)";
            dailyPriceDataGridViewTextBoxColumn.Name = "dailyPriceDataGridViewTextBoxColumn";
            // 
            // TableAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "TableAutos";
            Size = new Size(747, 385);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)autoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox textBox_search;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tSButton_Add;
        private ToolStripButton tSButton_Remove;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tSButton_Update;
        private Panel panel1;
        private DataGridView dataGridView1;
        private BindingSource autoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn aclassDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn atypeDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn acolorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dailyPriceDataGridViewTextBoxColumn;
    }
}

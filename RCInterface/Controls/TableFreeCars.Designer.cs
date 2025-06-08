namespace RCInterface
{
    partial class TableFreeCars
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            aclassDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            atypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            acolorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dailyPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            freeCarsBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            textBox_search = new ToolStripTextBox();
            panel1 = new Panel();
            statusStrip1 = new StatusStrip();
            tssl_1 = new ToolStripStatusLabel();
            panel2 = new Panel();
            btn_next = new Button();
            endDateTimePicker = new DateTimePicker();
            label2 = new Label();
            startDateTimePicker = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)freeCarsBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, modelDataGridViewTextBoxColumn, aclassDataGridViewTextBoxColumn, atypeDataGridViewTextBoxColumn, acolorDataGridViewTextBoxColumn, dailyPriceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = freeCarsBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(10, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(780, 393);
            dataGridView1.TabIndex = 0;
            dataGridView1.DataError += DataGridView1_DataError;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Бренд";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.HeaderText = "Модель";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aclassDataGridViewTextBoxColumn
            // 
            aclassDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aclassDataGridViewTextBoxColumn.DataPropertyName = "Aclass";
            aclassDataGridViewTextBoxColumn.HeaderText = "Клас авто";
            aclassDataGridViewTextBoxColumn.Name = "aclassDataGridViewTextBoxColumn";
            aclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atypeDataGridViewTextBoxColumn
            // 
            atypeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            atypeDataGridViewTextBoxColumn.DataPropertyName = "Atype";
            atypeDataGridViewTextBoxColumn.HeaderText = "Тип КПП";
            atypeDataGridViewTextBoxColumn.Name = "atypeDataGridViewTextBoxColumn";
            atypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // acolorDataGridViewTextBoxColumn
            // 
            acolorDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            acolorDataGridViewTextBoxColumn.DataPropertyName = "Acolor";
            acolorDataGridViewTextBoxColumn.HeaderText = "Колір";
            acolorDataGridViewTextBoxColumn.Name = "acolorDataGridViewTextBoxColumn";
            acolorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailyPriceDataGridViewTextBoxColumn
            // 
            dailyPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dailyPriceDataGridViewTextBoxColumn.DataPropertyName = "DailyPrice";
            dailyPriceDataGridViewTextBoxColumn.HeaderText = "Ціна оренди (грн/добу)";
            dailyPriceDataGridViewTextBoxColumn.Name = "dailyPriceDataGridViewTextBoxColumn";
            dailyPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freeCarsBindingSource
            // 
            freeCarsBindingSource.DataSource = typeof(RCLibrary.FreeCars);
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, textBox_search });
            toolStrip1.Location = new Point(0, 32);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 3;
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
            // panel1
            // 
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 57);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 10, 0);
            panel1.Size = new Size(800, 393);
            panel1.TabIndex = 4;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssl_1 });
            statusStrip1.Location = new Point(10, 371);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(780, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssl_1
            // 
            tssl_1.Name = "tssl_1";
            tssl_1.Size = new Size(69, 17);
            tssl_1.Text = "Rental price";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_next);
            panel2.Controls.Add(endDateTimePicker);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(startDateTimePicker);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 32);
            panel2.TabIndex = 5;
            // 
            // btn_next
            // 
            btn_next.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_next.Location = new Point(662, 2);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(135, 27);
            btn_next.TabIndex = 5;
            btn_next.Text = "Орендувати";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Visible = false;
            btn_next.Click += Btn_next_Click;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Font = new Font("Segoe UI", 9.75F);
            endDateTimePicker.Format = DateTimePickerFormat.Short;
            endDateTimePicker.Location = new Point(337, 3);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(106, 25);
            endDateTimePicker.TabIndex = 4;
            endDateTimePicker.ValueChanged += EndDateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(306, 5);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 3;
            label2.Text = "до:";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Font = new Font("Segoe UI", 9.75F);
            startDateTimePicker.Format = DateTimePickerFormat.Short;
            startDateTimePicker.Location = new Point(198, 3);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(106, 25);
            startDateTimePicker.TabIndex = 2;
            startDateTimePicker.ValueChanged += StartDateTimePicker_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(10, 6);
            label1.Name = "label1";
            label1.Padding = new Padding(40, 0, 0, 0);
            label1.Size = new Size(186, 20);
            label1.TabIndex = 1;
            label1.Text = "Дата бронювання з";
            // 
            // TableFreeCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(panel2);
            Name = "TableFreeCars";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)freeCarsBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox textBox_search;
        private Panel panel1;
        private BindingSource freeCarsBindingSource;
        private Panel panel2;
        private DateTimePicker startDateTimePicker;
        private Label label1;
        private DateTimePicker endDateTimePicker;
        private Label label2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aclassDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn atypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acolorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dailyPriceDataGridViewTextBoxColumn;
        private Button btn_next;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssl_1;
    }
}

using RCLibrary.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCInterface
{
    // ToDo #5.2 Таблица с менеджерами +
    public partial class TableManagers : UserControl
    {
        private Manager manager = new Manager();
        private Administrator admin = new Administrator();
        public TableManagers()
        {
            InitializeComponent();
            manager.Deserialize();
            managerBindingSource.DataSource = Manager.Managers;
            dataGridView1.ClearSelection();
        }

        // Обновление данных в таблице
        private void upDate()
        {
            managerBindingSource.DataSource = "";
            manager.Serialize();
            manager.Deserialize();
            managerBindingSource.DataSource = Manager.Managers;
            dataGridView1.ClearSelection();
        }

        private void tSButton_Add_Click(object sender, EventArgs e)
        {
            new Add_Manager().ShowDialog();
        }

        private void tSButton_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Менеджеры отсутствуют в таблице!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                admin.RemoveManager(dataGridView1.CurrentRow.Index);
            upDate();
        }

        private void tSButton_Update_Click(object sender, EventArgs e)
        {
            upDate();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                // Проверяем, что изменяется фамилия
                if (e.ColumnIndex == dataGridView1.Columns[1].Index)
                {
                    Manager.Managers[dataGridView1.CurrentRow.Index].LastName = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется имя
                if (e.ColumnIndex == dataGridView1.Columns[2].Index)
                {
                    Manager.Managers[dataGridView1.CurrentRow.Index].FirstName = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется отчество
                if (e.ColumnIndex == dataGridView1.Columns[3].Index)
                {
                    Manager.Managers[dataGridView1.CurrentRow.Index].MiddleName = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется номер телефона
                if (e.ColumnIndex == dataGridView1.Columns[4].Index)
                {
                    Manager.Managers[dataGridView1.CurrentRow.Index].PhoneNumber = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется пароль
                if (e.ColumnIndex == dataGridView1.Columns[5].Index)
                {
                    Manager.Managers[dataGridView1.CurrentRow.Index].Password = e.FormattedValue?.ToString();
                }
            }
            catch (ArgumentException ex)
            {
                e.Cancel = true;
                dataGridView1.CancelEdit();
                MessageBox.Show(ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning); // выводим сообщение об ошибке
            }
        }

        private void textBox_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_search.Text))
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    dataGridView1.Rows[i].Visible = true;
                dataGridView1.ClearSelection();
            }
            else
            {
                dataGridView1.CurrentCell = null;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Visible = false;
                    dataGridView1.Rows[i].Selected = false;

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox_search.Text))
                            {
                                dataGridView1.Rows[i].Visible = true;
                                dataGridView1.Rows[i].Selected = true;
                            }
                }
            }
        }
    }
}

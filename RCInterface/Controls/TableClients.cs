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
    // ToDo #5.5 Таблица с клиентами +
    public partial class TableClients : UserControl
    {
        public bool IsColumn5Enabled
        {
            get { return dataGridView1.Columns[5].Visible; }
            set
            {
                dataGridView1.Columns[5].Visible = value;
            }
        }
        public bool IsColumn7Enabled
        {
            get { return dataGridView1.Columns[7].Visible; }
            set
            {
                dataGridView1.Columns[7].Visible = value;
            }
        }

        public Client? SelectedClient
        {
            get
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Получение выделенной строки
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Получение объекта Manager из свойства DataBoundItem строки
                    return (Client)selectedRow.DataBoundItem;
                }

                return null;
            }
        }

        // Определение свойства
        public DataGridViewSelectionMode SelectionMode
        {
            get { return dataGridView1.SelectionMode; }
            set { dataGridView1.SelectionMode = value; }
        }

        private Manager manager = new();
        private Client client = new();
        public TableClients()
        {
            InitializeComponent();

            client.Deserialize();
            clientBindingSource.DataSource = Client.Clients;
            dataGridView1.ClearSelection();
        }

        // Обновление данных в таблице
        private void UpDate()
        {
            clientBindingSource.DataSource = "";
            client.Serialize();
            client.Deserialize();
            clientBindingSource.DataSource = Client.Clients;
            dataGridView1.ClearSelection();
        }

        private void TSButton_Add_Click(object sender, EventArgs e)
        {
            new Add_Client().ShowDialog();
        }

        private void TSButton_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Клієнтів немає в таблиці!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                manager.RemoveClient(dataGridView1.CurrentRow.Index);
            UpDate();
        }

        private void TSButton_Update_Click(object sender, EventArgs e)
        {
            UpDate();
        }

        private void TextBox_search_KeyUp(object sender, KeyEventArgs e)
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

        private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                // Проверяем, что изменяется фамилия
                if (e.ColumnIndex == dataGridView1.Columns[1].Index)
                {
                    Client.Clients[dataGridView1.CurrentRow.Index].LastName = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется имя
                if (e.ColumnIndex == dataGridView1.Columns[2].Index)
                {
                    Client.Clients[dataGridView1.CurrentRow.Index].FirstName = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется отчество
                if (e.ColumnIndex == dataGridView1.Columns[3].Index)
                {
                    Client.Clients[dataGridView1.CurrentRow.Index].MiddleName = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяются права
                if (e.ColumnIndex == dataGridView1.Columns[4].Index)
                {
                    Client.Clients[dataGridView1.CurrentRow.Index].DriverLicense = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется дата получения прав
                if (e.ColumnIndex == dataGridView1.Columns[5].Index)
                {
                    Client.Clients[dataGridView1.CurrentRow.Index].BirthDate = Convert.ToDateTime(e.FormattedValue);
                }
                // Проверяем, что изменяется номер телефона
                if (e.ColumnIndex == dataGridView1.Columns[6].Index)
                {
                    Client.Clients[dataGridView1.CurrentRow.Index].PhoneNumber = e.FormattedValue?.ToString();
                }
                // Проверяем, что изменяется пароль
                if (e.ColumnIndex == dataGridView1.Columns[7].Index)
                {
                    Client.Clients[dataGridView1.CurrentRow.Index].Password = e.FormattedValue?.ToString();
                }
            }
            catch (ArgumentException ex)
            {
                e.Cancel = true;
                dataGridView1.CancelEdit();
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning); // выводим сообщение об ошибке
            }
        }
    }
}

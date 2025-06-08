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
    public partial class TableContracts : UserControl
    {
        private Contract contract = new();
        private Auto auto = new();
        private Client client = new();
        private Manager manager = new();
        public TableContracts()
        {
            InitializeComponent();
            auto.Deserialize();
            manager.Deserialize();
            client.Deserialize();
            contract.Deserialize();

            contractBindingSource.DataSource = Contract.Contracts;
            dataGridView1.ClearSelection();
        }

        // Обновление данных в таблице
        private void upDate()
        {
            contractBindingSource.DataSource = "";
            contract.Serialize();
            contract.Deserialize();
            contractBindingSource.DataSource = Contract.Contracts;
            dataGridView1.ClearSelection();
        }

        private void tSButton_Add_Click(object sender, EventArgs e)
        {
            //new Add_Contract().ShowDialog();
            new Add_Contract().Show();
        }

        private void tSButton_Remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                MessageBox.Show("Договори відсутні у таблиці!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                manager.RemoveContract(dataGridView1.CurrentRow.Index);
            upDate();
        }

        private void tSButton_Update_Click(object sender, EventArgs e)
        {
            upDate();
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

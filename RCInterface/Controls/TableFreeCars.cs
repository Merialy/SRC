using RCLibrary;
using RCLibrary.Entities;

namespace RCInterface
{
    public partial class TableFreeCars : UserControl
    {
        private readonly FreeCars freeCars = new();
        DataGridViewRow? selectedRow;
        public TableFreeCars()
        {
            InitializeComponent();
            startDateTimePicker.MinDate = endDateTimePicker.MinDate = DateTime.Today;
            SearchFreeCar();

            // Вибираємо перший рядок (якщо дані є)
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true; // Виділяємо перший рядок
                selectedRow = dataGridView1.Rows[0];
                UpdatePriceLabel(); // Оновлюємо інформацію про ціну
            }
        }

        private void UpdatePriceLabel()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                decimal price = Convert.ToDecimal(selectedRow.Cells[6].Value);
                int calculateRentalDays = (endDateTimePicker.Value.Date - startDateTimePicker.Value.Date).Days + 1;
                tssl_1.Text = $"Ціна оренди з {startDateTimePicker.Value:dd.MM.yyyy} по {endDateTimePicker.Value:dd.MM.yyyy} = {calculateRentalDays * price} грн/добу";
            }
        }

        private void SearchFreeCar()
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = freeCars.AvailableCars(startDateTimePicker.Value.Date, endDateTimePicker.Value.Date); ;
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchFreeCar();
            endDateTimePicker.MinDate = startDateTimePicker.Value;
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SearchFreeCar();
            UpdatePriceLabel();
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private Administrator admin = new();
        private void Btn_next_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.Car = SelectedAuto;
            contract.Renter = Client.Clients.FirstOrDefault(u => u.Email == UserSystem.activeUser.Email);
            contract.Employee = Administrator.Administrators.FirstOrDefault(u => u.Email == "root@gmail.com"); 
            contract.StartDate = startDate;
            contract.EndDate = endDate;

            bool action = admin.AddContract(contract);

            if (action)
            {
                DialogResult dialogResult = MessageBox.Show("Договір було додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                throw new ArgumentException("Користувач із таким email вже існує! Будь ласка, використовуйте інший email для додавання користувача до системи.");
            }
            SearchFreeCar();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            UpdatePriceLabel();
        }

        // Визначення властивості
        public Auto? SelectedAuto
        {
            get
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Отримання виділеного рядка
                    selectedRow = dataGridView1.SelectedRows[0];

                    // Отримання об'єкта Manager з властивості рядка DataBoundItem
                    return (Auto)selectedRow.DataBoundItem;
                }

                return null;
            }
        }

        public DateTime startDate
        {
            get { return startDateTimePicker.Value.Date; }
        }

        public DateTime endDate
        {
            get { return endDateTimePicker.Value.Date; }
        }

        public bool EnableBtnNext
        {
            get => btn_next.Visible;
            set => btn_next.Visible = value;
        }
    }
}

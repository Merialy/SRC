using RCLibrary;
using RCLibrary.Entities;

namespace RCInterface
{
    // ToDo #5.3 Таблица со всеми пользователями +
    public partial class TableUsersSystem : UserControl
    {
        public TableUsersSystem()
        {
            InitializeComponent();
            Administrator admin = new Administrator();
            Manager manager = new Manager();
            Client client = new Client();
            UserSystem users = new UserSystem();

            client.Deserialize();
            manager.Deserialize();
            admin.Deserialize();
            users.Serialize();
            users.Deserialize();

            dataGridView1.DataSource = UserSystem.Users;
            dataGridView1.ClearSelection();
        }

        public void textBox_search_KeyUp(object sender, KeyEventArgs e)
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
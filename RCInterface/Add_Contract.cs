using RCLibrary;
using RCLibrary.Entities;

namespace RCInterface
{
    //ToDo #5.6 Форма для добавления нового договора +
    public partial class Add_Contract : Form
    {
        private Manager manager = new Manager();
        public Add_Contract()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                // Поиск пользователя по email
                Manager? activeManager = Manager.Managers.FirstOrDefault(u => u.Email == UserSystem.activeUser.Email);
                Administrator? activeAdmin = Administrator.Administrators.FirstOrDefault(u => u.Email == UserSystem.activeUser.Email);

                RCLibrary.Entities.Contract contract = new RCLibrary.Entities.Contract();
                contract.Car = tableFreeCars1.SelectedAuto;
                contract.Renter = tableClients1.SelectedClient;
                if (activeManager != null)
                    contract.Employee = activeManager;
                else if (activeAdmin != null)
                    contract.Employee = activeAdmin;

                contract.StartDate = tableFreeCars1.startDate;
                contract.EndDate = tableFreeCars1.endDate;

                bool action = manager.AddContract(contract);

                if (action)
                {
                    DialogResult dialogResult = MessageBox.Show("Договір було додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                        Close();
                }
                else
                {
                    throw new ArgumentException("Користувач із таким email вже існує! Будь ласка, використовуйте інший email для додавання користувача до системи.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

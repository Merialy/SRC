using RCLibrary.Entities;

namespace RCApp
{
    public partial class SignUp : Form
    {
        private readonly Client client = new();
        public SignUp()
        {
            InitializeComponent();
        }

        private void Btn_sign_up_Click(object sender, EventArgs e)
        {
            try
            {
                Client newClient = new ()
                {
                    Email = textBox_email.Text.Replace(" ", ""),
                    LastName = textBox_lastName.Text.Replace(" ", ""),
                    FirstName = textBox_firstName.Text.Replace(" ", ""),
                    MiddleName = textBox_middleName.Text.Replace(" ", ""),
                    PhoneNumber = maskedTextBox_phone.Text,
                    Password = textBox_password.Text.Replace(" ", ""),
                    DriverLicense = mtb_driverLicense.Text,
                    BirthDate = dtp_driverLicense.Value
                };
                bool action = client.Register(newClient);

                if (action)
                {
                    DialogResult dialogResult = MessageBox.Show("Обліковий запис було створено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    client.Serialize();
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

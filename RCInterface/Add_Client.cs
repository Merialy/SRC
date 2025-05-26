using RCLibrary.Entities;

namespace RCInterface
{
    //ToDo #5.5.1 Форма для додавання нового клієнта
    public partial class Add_Client : Form
    {
        private Manager manager = new();
        public Add_Client()
        {
            InitializeComponent();
            dtp_driverLicense.Value = DateTime.Now;
        }

        private void Btn_add_Client_Click(object sender, EventArgs e)
        {
            try
            {
                Client newClient = new()
                {
                    Email = textBox_email.Text.Replace(" ", ""),
                    LastName = textBox_lastName.Text.Replace(" ", ""),
                    FirstName = textBox_firstName.Text.Replace(" ", ""),
                    MiddleName = textBox_middleName.Text.Replace(" ", ""),
                    PhoneNumber = maskedTextBox_phone.Text,
                    Password = mtb_password.Text.Replace(" ", ""),
                    DriverLicense = mtb_driverLicense.Text,
                    BirthDate = dtp_driverLicense.Value
                };
                bool action = manager.AddClient(newClient);

                if (action)
                {
                    DialogResult dialogResult = MessageBox.Show("Клієнта було додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TextBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void Mtb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела
        }

        private void TextBox_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела

            if (textBox_lastName.SelectionStart == 0)
                e.KeyChar = char.ToUpper(e.KeyChar);
            else
                e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void TextBox_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела

            if (textBox_firstName.SelectionStart == 0)
                e.KeyChar = char.ToUpper(e.KeyChar);
            else
                e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void TextBox_middleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела

            if (textBox_middleName.SelectionStart == 0)
                e.KeyChar = char.ToUpper(e.KeyChar);
            else
                e.KeyChar = char.ToLower(e.KeyChar);
        }
    }
}

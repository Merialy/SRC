using RCLibrary.Entities;

namespace RCInterface
{
    // ToDo #5.2.1 Форма добавления нового менеджера +
    public partial class Add_Manager : Form
    {
        private Administrator admin = new();
        public Add_Manager()
        {
            InitializeComponent();
        }

        private void btn_add_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                Manager manager = new Manager
                {
                    Email = textBox_email.Text.Replace(" ", ""),
                    LastName = textBox_lastName.Text.Replace(" ", ""),
                    FirstName = textBox_firstName.Text.Replace(" ", ""),
                    MiddleName = textBox_middleName.Text.Replace(" ", ""),
                    PhoneNumber = maskedTextBox_phone.Text,
                    Password = mtb_password.Text.Replace(" ", "")
                };
                bool action = admin.AddManager(manager);

                if (action)
                {
                    DialogResult dialogResult = MessageBox.Show("Менеджер було додано!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела
            e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void mtb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела
        }

        private void textBox_lastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела

            if (textBox_lastName.SelectionStart == 0)
                e.KeyChar = char.ToUpper(e.KeyChar);
            else
                e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void textBox_firstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true; // отмена события для пробела

            if (textBox_firstName.SelectionStart == 0)
                e.KeyChar = char.ToUpper(e.KeyChar);
            else
                e.KeyChar = char.ToLower(e.KeyChar);
        }

        private void textBox_middleName_KeyPress(object sender, KeyPressEventArgs e)
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

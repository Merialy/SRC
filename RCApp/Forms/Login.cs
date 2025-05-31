using RCLibrary;
using RCLibrary.Entities;

namespace RCApp
{
    public partial class Login : Form
    {
        private string email = string.Empty;
        private string password = string.Empty;
        private UserSystem userSystem = new();
        private Administrator admin = new();
        private Manager manager = new();
        private Client client = new();
        private Auto auto = new();
        private Contract contract = new();
        public Login()
        {
            InitializeComponent();
            admin.Deserialize();
            manager.Deserialize();
            client.Deserialize();
            userSystem.Serialize();
            userSystem.Deserialize();
            auto.Deserialize();
            contract.Deserialize();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            email = textBox_email.Text;
            password = mtb_password.Text;

            // Вход в систему
            bool authResult = userSystem.Authenticate(email, password);

            if (authResult == true)
            {
                MessageBox.Show("Вхід виконано успішно!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*MainForm f = new();
                f.Show();*/
                this.Hide();

                using (MainForm mainForm = new MainForm())
                {
                    this.Visible = false;
                    DialogResult result = mainForm.ShowDialog();
                    this.Close(); // Закрываем текущую форму
                }
            }
            else
                MessageBox.Show("Неправильний логін чи пароль.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Btn_sign_up_Click(object sender, EventArgs e)
        {
            new SignUp().ShowDialog(this);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ResetPassForm().ShowDialog(this);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Hide_Click(object sender, EventArgs e)
        {
            if (mtb_password.PasswordChar == '\0')
            {
                //pictureBox_Hide.Image = Properties.Resources.free_icon_eye_158746;
                pictureBox_Hide.Image = Properties.Resources.free_icon_hide_2767146;
                mtb_password.PasswordChar = '*';
            }
            else if (mtb_password.PasswordChar == '*')
            {
                //pictureBox_Hide.Image = Properties.Resources.free_icon_hide_2767146;
                pictureBox_Hide.Image = Properties.Resources.free_icon_eye_158746;
                mtb_password.PasswordChar = '\0';
            }
        }
    }
}
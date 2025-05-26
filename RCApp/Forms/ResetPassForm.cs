using RCLibrary;

namespace RCApp
{
    public partial class ResetPassForm : Form
    {
        public ResetPassForm()
        {
            InitializeComponent();
            SetSize(305, 264);
            btn_SendCode.Location = new Point(12, 165);
        }

        private string _currentCode; // Зберігаємо поточний код
        private DateTime _codeExpirationTime; // Час закінчення
        private string _email;

        private void btn_SendCode_Click(object sender, EventArgs e)
        {
            _email = ctb_Email.customText;
            if (UserSystem.IsEmailAvailable(_email))
            {
                btn_SendCode.Visible = false;
                btn_confirmCode.Location = btn_SendCode.Location;

                label2.Location = new Point(12, 76);
                label2.Text = $"Код підтвердження надіслано на пошту \n{ctb_Email.customText}";
                ctb_Email.Visible = false;
                tb_userCode.Location = ctb_Email.Location;

                _currentCode = GenerateCode(); // Генеруємо код
                _codeExpirationTime = DateTime.Now.AddMinutes(2); // Діє 2 хвилини
                SaveCodeInfoToFile();
            }
            else
            {
                MessageBox.Show("Такої електронної пошти у системі немає!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_CheckCode_Click(object sender, EventArgs e)
        {
            SetSize(305, 277);
            label.Location = new Point(12, 162);
            btn_confirmCode.Location = new Point(12, 182);

            string userInput = tb_userCode.customText;

            if (IsCodeValid(userInput))
            {
                SetSize(305, 353);
                label.ForeColor = Color.FromArgb(0, 192, 0);
                label.Text = "✅ Вірний код!";
                tb_userCode.Enabled = false;
                btn_confirmCode.Visible = false;

                label3.Visible = true;
                ctb_newPass.Location = new Point(12, 212);
                btn_changePass.Location = new Point(12, 262);
            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = "❌ Неправильний або застарілий код!";
            }
        }

        private void SaveCodeInfoToFile()
        {
            string message = $"Код: {_currentCode} (діє до {_codeExpirationTime:T})";
            File.WriteAllText("code.txt", message);
            System.Diagnostics.Process.Start("notepad.exe", "code.txt");
        }

        private string GenerateCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var rand = new Random();
            string randomCode = new string(Enumerable.Repeat(chars, 6).
                Select(s => s[rand.Next(s.Length)]).ToArray());
            return randomCode;
        }

        private bool IsCodeValid(string input)
        {
            // Перевіряємо:
            // 1. Що код збігається
            // 2. Що час не минув
            return input == _currentCode && DateTime.Now <= _codeExpirationTime;
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            string newPass = ctb_newPass.customText;
            try
            {
                UserSystem.ResetPassword(_email, newPass);


                DialogResult dialogResult = MessageBox.Show("Пароль змінено!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.OK)
                    Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SetSize(int width, int height)
        {
            this.Size = new Size(width, height);
            this.MinimumSize = new Size(width, height); 
            this.MaximumSize = new Size(width, height);
        }
    }
}

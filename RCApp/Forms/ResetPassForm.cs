
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

        private string _currentCode; // Храним текущий код
        private DateTime _codeExpirationTime; // Время истечения

        private void btn_SendCode_Click(object sender, EventArgs e)
        {
            btn_SendCode.Visible = false;
            btn_confirmCode.Location = btn_SendCode.Location;

            label2.Location = new Point(12, 76);
            label2.Text = $"Код підтвердження надіслано на пошту \n{ctb_Email.customText}";
            ctb_Email.Visible = false;
            tb_userCode.Location = ctb_Email.Location;

            _currentCode = GenerateCode(); // Генерируем код
            _codeExpirationTime = DateTime.Now.AddMinutes(2); // Действует 2 минуты
            SaveCodeInfoToFile();
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
                label.Text = "✅ Верный код!";
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
            string message = $"Код: {_currentCode} (действует до {_codeExpirationTime:T})";
            File.WriteAllText("code.txt", message);
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
            // Проверяем:
            // 1. Что код совпадает
            // 2. Что время не истекло
            return input == _currentCode && DateTime.Now <= _codeExpirationTime;
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {

        }

        private void SetSize(int width, int height)
        {
            this.Size = new Size(width, height);
            this.MinimumSize = new Size(width, height); 
            this.MaximumSize = new Size(width, height);
        }
    }
}

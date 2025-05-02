using RCLibrary;
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

            //email = "root@gmail.com";
            //password = "Admin_01";

            // Вход в систему
            bool authResult = userSystem.Authenticate(email, password);

            if (authResult == true)
            {
                MessageBox.Show("Вхід виконано успішно!", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm f = new();
                f.Show();
                this.Hide();
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
    }
}
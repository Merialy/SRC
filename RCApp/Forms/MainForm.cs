using RCApp.Forms;
using RCInterface;
using RCLibrary;
using RCLibrary.Entities;

namespace RCApp
{
    public partial class MainForm : Form
    {
        private Administrator admin = new();
        private Manager manager = new();
        private Auto auto = new();
        private Client client = new();
        public MainForm()
        {
            InitializeComponent();
            if (UserSystem.activeUser.TypeClass == "�����������")
            {
                OpenChildControl(new TableUsersSystem());
                statusBar_user.Text = UserSystem.activeUser.ToString() + " (�����������)";
            }
            else if (UserSystem.activeUser.TypeClass == "�볺��")
            {
                ClientMode();
            }
            else if (UserSystem.activeUser.TypeClass == "��������")
            {
                ManagerMode();
            }
        }

        private void ManagerMode()
        {
            ToolStripMI_admins.Visible = false;
            ToolStripMI_managers.Visible = false;
            OpenChildControl(new TableFreeCars());
            statusBar_user.Text = UserSystem.activeUser.ToString() + " (��������)";
        }

        private void ClientMode()
        {
            �������ToolStripMenuItem.Visible = false;
            TableFreeCars mainMenuClient = new TableFreeCars();
            OpenChildControl(mainMenuClient);
            mainMenuClient.EnableBtnNext = true;
            statusBar_user.Text = UserSystem.activeUser.ToString();
        }

        private UserControl? activeControl = null;
        // ����� ��� �������� UserControl �� �����
        private void OpenChildControl(UserControl childControl)
        {
            if (activeControl != null && activeControl.GetType() == childControl.GetType())
            {
                // UserControl ��� �������, ������ �������� ����
                activeControl.Focus();
                return;
            }

            if (activeControl != null)
            {
                if (activeControl.ToString() == "RCInterface.TableAdmins")
                {
                    admin.Serialize();
                }
                else if (activeControl.ToString() == "RCInterface.TableManagers")
                {
                    manager.Serialize();
                }
                else if (activeControl.ToString() == "RCInterface.TableAutos")
                {
                    auto.Serialize();
                }
                else if (activeControl.ToString() == "RCInterface.TableClients")
                {
                    client.Serialize();
                }

                activeControl.Dispose();
            }
            activeControl = childControl;
            childControl.Dock = DockStyle.Fill;
            panel_info.Controls.Add(childControl);
            panel_info.Tag = childControl;
            childControl.BringToFront();
            childControl.Show();

            if (childControl.ToString() == "RCInterface.TableAdmins")
                StatusLabel_NForm.Text = "������� ������������";
            else if (childControl.ToString() == "RCInterface.TableManagers")
                StatusLabel_NForm.Text = "������� ���������";
            else if (childControl.ToString() == "RCInterface.TableUsersSystem")
                StatusLabel_NForm.Text = "������� � ���� �������������";
            else if (childControl.ToString() == "RCInterface.TableAutos")
                StatusLabel_NForm.Text = "������� � �����������";
            else if (childControl.ToString() == "RCInterface.TableClients")
                StatusLabel_NForm.Text = "������� �� �볺�����";
            else if (childControl.ToString() == "RCInterface.TableContracts")
                StatusLabel_NForm.Text = "������� �� ����������";
        }

        private void ToolStripMI_autos_Click(object sender, EventArgs e)
        {
            OpenChildControl(new TableAutos());
        }

        private void ToolStripMI_admins_Click(object sender, EventArgs e)
        {
            OpenChildControl(new TableAdmins());
        }

        private void ToolStripMI_clients_Click(object sender, EventArgs e)
        {
            OpenChildControl(new TableClients());
        }

        private void ToolStripMI_managers_Click(object sender, EventArgs e)
        {
            OpenChildControl(new TableManagers());
        }

        private void ToolStripMI_menu_Click(object sender, EventArgs e)
        {
            if (UserSystem.activeUser.TypeClass == "�����������")
            {
                OpenChildControl(new TableUsersSystem());
            }
            else if (UserSystem.activeUser.TypeClass == "�볺��")
            {
                OpenChildControl(new TableFreeCars());
            }
            else if (UserSystem.activeUser.TypeClass == "��������")
            {
                OpenChildControl(new TableFreeCars());
            }
        }

        private void MainAdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            admin.Serialize();
            manager.Serialize();
            auto.Serialize();
            client.Serialize();
            Application.Exit();
        }

        private void ContractsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildControl(new TableContracts());
        }

        private void AboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        private void ToolStripMI_Exit_Click(object sender, EventArgs e)
        {
            this.Hide(); // ��������� ������� �����

            using (Login loginForm = new Login())
            {
                this.Visible = false;
                DialogResult result = loginForm.ShowDialog();
                this.Close(); // ��������� ������� �����
            }
        }
    }
}
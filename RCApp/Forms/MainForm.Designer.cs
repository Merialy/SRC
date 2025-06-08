namespace RCApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            ToolStripMI_menu = new ToolStripMenuItem();
            таблицыToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMI_autos = new ToolStripMenuItem();
            ToolStripMI_admins = new ToolStripMenuItem();
            договорыToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMI_clients = new ToolStripMenuItem();
            ToolStripMI_managers = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            оРазработчикеToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            StatusLabel_NForm = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusBar_user = new ToolStripStatusLabel();
            panel_info = new Panel();
            ToolStripMI_Exit = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMI_menu, таблицыToolStripMenuItem, справкаToolStripMenuItem, ToolStripMI_Exit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(796, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMI_menu
            // 
            ToolStripMI_menu.Name = "ToolStripMI_menu";
            ToolStripMI_menu.Size = new Size(65, 20);
            ToolStripMI_menu.Text = "Головна";
            ToolStripMI_menu.Click += ToolStripMI_menu_Click;
            // 
            // таблицыToolStripMenuItem
            // 
            таблицыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMI_autos, ToolStripMI_admins, договорыToolStripMenuItem, ToolStripMI_clients, ToolStripMI_managers });
            таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            таблицыToolStripMenuItem.Size = new Size(62, 20);
            таблицыToolStripMenuItem.Text = "Таблиці";
            // 
            // ToolStripMI_autos
            // 
            ToolStripMI_autos.Name = "ToolStripMI_autos";
            ToolStripMI_autos.Size = new Size(180, 22);
            ToolStripMI_autos.Text = "Автомобили";
            ToolStripMI_autos.Click += ToolStripMI_autos_Click;
            // 
            // ToolStripMI_admins
            // 
            ToolStripMI_admins.Name = "ToolStripMI_admins";
            ToolStripMI_admins.Size = new Size(180, 22);
            ToolStripMI_admins.Text = "Адміністратори";
            ToolStripMI_admins.Click += ToolStripMI_admins_Click;
            // 
            // договорыToolStripMenuItem
            // 
            договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            договорыToolStripMenuItem.Size = new Size(180, 22);
            договорыToolStripMenuItem.Text = "Договори";
            договорыToolStripMenuItem.Click += ContractsToolStripMenuItem_Click;
            // 
            // ToolStripMI_clients
            // 
            ToolStripMI_clients.Name = "ToolStripMI_clients";
            ToolStripMI_clients.Size = new Size(180, 22);
            ToolStripMI_clients.Text = "Клієнти";
            ToolStripMI_clients.Click += ToolStripMI_clients_Click;
            // 
            // ToolStripMI_managers
            // 
            ToolStripMI_managers.Name = "ToolStripMI_managers";
            ToolStripMI_managers.Size = new Size(180, 22);
            ToolStripMI_managers.Text = "Менеджери";
            ToolStripMI_managers.Click += ToolStripMI_managers_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { оРазработчикеToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(61, 20);
            справкаToolStripMenuItem.Text = "Довідка";
            // 
            // оРазработчикеToolStripMenuItem
            // 
            оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            оРазработчикеToolStripMenuItem.Size = new Size(180, 22);
            оРазработчикеToolStripMenuItem.Text = "Про розробника";
            оРазработчикеToolStripMenuItem.Click += AboutMeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel_NForm, toolStripStatusLabel1, statusBar_user });
            statusStrip1.Location = new Point(0, 445);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(796, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel_NForm
            // 
            StatusLabel_NForm.Name = "StatusLabel_NForm";
            StatusLabel_NForm.Size = new Size(81, 17);
            StatusLabel_NForm.Text = "Назва форми";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(674, 17);
            toolStripStatusLabel1.Spring = true;
            toolStripStatusLabel1.Text = "Користувач:";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // statusBar_user
            // 
            statusBar_user.Name = "statusBar_user";
            statusBar_user.Size = new Size(26, 17);
            statusBar_user.Text = "ПІБ";
            // 
            // panel_info
            // 
            panel_info.Dock = DockStyle.Fill;
            panel_info.Location = new Point(0, 24);
            panel_info.Name = "panel_info";
            panel_info.Size = new Size(796, 421);
            panel_info.TabIndex = 2;
            // 
            // ToolStripMI_Exit
            // 
            ToolStripMI_Exit.Name = "ToolStripMI_Exit";
            ToolStripMI_Exit.Size = new Size(48, 20);
            ToolStripMI_Exit.Text = "Вихід";
            ToolStripMI_Exit.Click += ToolStripMI_Exit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 467);
            Controls.Add(panel_info);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(812, 506);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RCApp";
            FormClosing += MainAdminForm_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMI_menu;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem ToolStripMI_autos;
        private ToolStripMenuItem ToolStripMI_admins;
        private ToolStripMenuItem ToolStripMI_clients;
        private ToolStripMenuItem ToolStripMI_managers;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel_NForm;
        private Panel panel_info;
        private ToolStripMenuItem договорыToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel statusBar_user;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private ToolStripMenuItem ToolStripMI_Exit;
    }
}
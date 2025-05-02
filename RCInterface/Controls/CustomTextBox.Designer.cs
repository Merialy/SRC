namespace RCInterface.Controls
{
    partial class CustomTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lableTimer = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            label1 = new Label();
            textBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lableTimer
            // 
            lableTimer.Interval = 1;
            lableTimer.Tick += lableTimer_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 8);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 3;
            label1.Text = "Text";
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox.Location = new Point(5, 19);
            textBox.Name = "textBox";
            textBox.Size = new Size(200, 16);
            textBox.TabIndex = 2;
            textBox.Enter += textBox_Enter;
            textBox.Leave += textBox_Leave;
            // 
            // CustomTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Name = "CustomTextBox";
            Padding = new Padding(3);
            Size = new Size(217, 44);
            Load += CustomTextBox_Load;
            Paint += CustomTextBox_Paint;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer lableTimer;
        private Panel panel1;
        private Label label1;
        private TextBox textBox;
    }
}

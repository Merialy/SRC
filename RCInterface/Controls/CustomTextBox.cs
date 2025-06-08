
namespace RCInterface.Controls
{
    public partial class CustomTextBox : UserControl
    {
        public CustomTextBox()
        {
            InitializeComponent();
        }

        bool isFocused = false;
        private string label = "label";
        private bool pass = false;
        private bool multiline = false;
        private Color backColor = Color.White;
        private Color foreColor = Color.Black;
        public string customLabel
        {
            get { return label; }
            set
            {
                label = value;
                this.Invalidate();
            }
        }


        public string customText
        {
            get { return textBox.Text; }
            set
            {
                textBox.Text = value;
                this.Invalidate();
            }
        }


        public Color customBackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                this.Invalidate();
            }
        }

        public Color customForeColor
        {
            get { return foreColor; }
            set
            {
                foreColor = value;
                this.Invalidate();
            }
        }

        public bool customMultiline
        {
            get { return multiline; }
            set
            {
                multiline = value;
                this.Invalidate();
            }
        }

        public bool Password
        {
            get { return pass; }
            set
            {
                pass = value;
                this.Invalidate();
            }
        }

        private void lableTimer_Tick(object sender, EventArgs e)
        {
            int y = label1.Location.Y;
            if (isFocused == false)
            {
                y -= 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y <= 2)
                {
                    isFocused = true;
                    lableTimer.Stop();
                    label1.Font = new Font("Segoi UI", 8);
                    y = 0;
                    label1.ForeColor = Color.Silver;
                }
            }
            else
            {
                y += 2;
                label1.Location = new Point(label1.Location.X, y);
                if (y >= 8)
                {
                    isFocused = false;
                    lableTimer.Stop();
                    label1.Font = new Font("Segoi UI", 9);
                    y = 8;
                    label1.ForeColor = Color.Black;
                }
            }

        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                lableTimer.Start();
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                lableTimer.Start();
            }
        }

        private void CustomTextBox_Paint(object sender, PaintEventArgs e)
        {
            this.backColor = customBackColor;
            label1.BackColor = customBackColor;
            textBox.BackColor = customBackColor;
                        
            label1.Text = customLabel;
            if(customMultiline == true)
            {
                textBox.Multiline = true;
                textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                textBox.Height = this.Height;
            }          

            label1.ForeColor = customForeColor;
        }

        private void CustomTextBox_Load(object sender, EventArgs e)
        {
            if(Password == true)
            {
                textBox.UseSystemPasswordChar = true;
            }
        }
    }
}

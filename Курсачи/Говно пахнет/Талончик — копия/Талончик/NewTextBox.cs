using System;
using System.Drawing;
using System.Windows.Forms;


namespace Талончик
{
    public partial class NewTextBox : UserControl
    {
        public event EventHandler TextChangedB;
        public void Clear()
        {
            switch (IsPassword)
            {
                case true:
                    {
                        textBox1.Text = SaveText;
                        textBox1.UseSystemPasswordChar = false;
                        textBox1.ForeColor = Color.DimGray;
                    }
                    break;
                case false:
                    {
                        textBox1.Text = SaveText;
                        textBox1.ForeColor = Color.DimGray;
                    }
                    break;
            }
        }
        public string CurrentText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string SaveText;
        public string StandartText
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SaveText = value;
            }
        }
        public int SelectionStart
        {
            get
            {
                return textBox1.SelectionStart;
            }
            set
            {
                textBox1.SelectionStart = value;
            }
        }
        public bool IsPassword { get; set; }
        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                textBox1.MaxLength = value;
            }
        }
        public bool PasswordVisible
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }
        public NewTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            switch (IsPassword)
            {
                case false:
                    {
                        if ((sender as TextBox).Text == SaveText)
                        {

                            (sender as TextBox).Text = "";
                            (sender as TextBox).ForeColor = Color.Black;
                        }
                    }
                    break;
                case true:
                    {
                        if ((sender as TextBox).Text == SaveText)
                        {
                            (sender as TextBox).UseSystemPasswordChar = true;
                            (sender as TextBox).Text = "";
                            (sender as TextBox).ForeColor = Color.Black;
                        }
                    }
                    break;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            switch (IsPassword)
            {
                case false:
                    {
                        if ((sender as TextBox).Text == "")
                        {
                            (sender as TextBox).Text = SaveText;
                            (sender as TextBox).ForeColor = Color.Gray;
                        }
                    }
                    break;
                case true:
                    {
                        if ((sender as TextBox).Text == "")
                        {
                            (sender as TextBox).UseSystemPasswordChar = false;
                            (sender as TextBox).Text = SaveText;
                            (sender as TextBox).ForeColor = Color.Gray;
                        }
                    }
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CurrentText = textBox1.Text;
            if (TextChangedB != null) TextChangedB(this,e);
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Талончик
{
    public partial class Buttonchik : UserControl
    {
        public event EventHandler ButtonClick;
        public Buttonchik()
        {
            InitializeComponent();
        }

        public string TextButton
        {
            get
            {
                return textbutton.Text;
            }
            set
            {
                textbutton.Text = value;
            }
        }

        private void textbutton_MouseEnter(object sender, EventArgs e)
        {
            textbutton.BackColor = Color.PaleGreen;
        }

        public bool EnableButton
        {
            get
            {
                return textbutton.Enabled;
            }
            set
            {
                textbutton.Enabled = value;
                if (value == false) textbutton.BackColor = Color.Crimson;
                else { textbutton.BackColor = Color.MediumSeaGreen; }
            }
        }

        private void textbutton_Click(object sender, EventArgs e)
        {
           if(ButtonClick != null)
           {
                ButtonClick(this,e);
           }
        }

        private void textbutton_MouseLeave(object sender, EventArgs e)
        {
            textbutton.BackColor = Color.MediumSeaGreen;
        }
    }
}

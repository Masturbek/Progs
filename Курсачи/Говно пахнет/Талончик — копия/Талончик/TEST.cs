using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Талончик
{
    public partial class TEST : Form
    {
        public TEST()
        {
            InitializeComponent();
        }

        private void TEST_Load(object sender, EventArgs e)
        {
            ////tx1.StandartText = "Введите СНИЛС или телефон";
            ////tx1.MaxLength = 11;
            ////tx1.IsPassword = false;
            //tx2.StandartText = "Введите СНИЛС или телефон";
            //tx2.MaxLength = 11;
            //tx2.IsPassword = true;
            //tx2.Chkchanged
            tx2.TextChangedB += checkBox1_CheckedChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (tx2.SaveText != tx2.CurrentText)
            {
                if (checkBox1.Checked) tx2.PasswordVisible = false;
                else tx2.PasswordVisible = true;
            }
            else checkBox1.Checked = false;
        }

    }
}

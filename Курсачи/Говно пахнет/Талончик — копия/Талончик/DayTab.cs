using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Талончик
{
    public partial class DayTab : UserControl
    {
        public DayTab()
        {
            InitializeComponent();
        }
        public string SelectedDay 
        {
            get
            {
                return daylabel.Text;
            }
            set
            {
                daylabel.Text = value;
            }
        }

        public void AddB(Control button)
        {
            daypanel.Controls.Add(button);
        }
        public void ClearB()
        {
            daypanel.Controls.Clear();
        }
    }
}

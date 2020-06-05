using System.Windows.Forms;

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

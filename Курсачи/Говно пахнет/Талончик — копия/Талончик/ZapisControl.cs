using System;
using System.Windows.Forms;

namespace Талончик
{
    public partial class ZapisControl : UserControl
    {
        public event EventHandler Print;
        public event EventHandler Delete;
        public ZapisControl()
        {
            InitializeComponent();
        }
        public bool PrinterVisible
        {
            get { return pictureBox1.Visible; }
            set { pictureBox1.Visible = value; }
        }
        public string Speciality
        {
            get { return labelspec.Text; }
            set { labelspec.Text = value; }
        }
        public string Doc
        {
            get { return labeldoc.Text; }
            set { labeldoc.Text = value; }
        }
        public string Day
        {
            get { return labelday.Text; }
            set { labelday.Text = value; }
        }
        public string Time
        {
            get { return labeltime.Text; }
            set { labeltime.Text = value; }
        }


        public void Print_Click(object sender, EventArgs e)
        {
            if (Print != null)
                Print(this, e);
        }
        
        public void Trash_Click(object sender, EventArgs e)
        {

            if (Delete != null)
                Delete(this, e);
        }
    }
}

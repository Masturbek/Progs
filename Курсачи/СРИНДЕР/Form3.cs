using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace СРИНДЕР
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            OPtionsGUI();
        }

        public void OPtionsGUI()
        {
            this.Controls.Clear();
            groupboxtheme = new GroupBox();
            if (Properties.Settings.Default.theme == "светлая")
            {
                this.BackColor = Color.FromArgb(230, 230, 230);
                this.ForeColor = Color.Black;
            }
            if (Properties.Settings.Default.theme == "темная")
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
                this.ForeColor = Color.White;
                groupboxtheme.ForeColor = Color.White;
            }

            groupboxtheme.Location = new Point(30,30);
            groupboxtheme.Width = 150;
            groupboxtheme.Height = 70;
            groupboxtheme.Text = "Тема";

            radiolight = new RadioButton();
            radiolight.Text = "Светлая";
            radiolight.Location = new Point(10,15);
            radiodark = new RadioButton();
            radiodark.Text = "Темная";
            radiodark.Location = new Point(10, 40);
            groupboxtheme.Controls.Add(radiolight);
            groupboxtheme.Controls.Add(radiodark);

            if (Properties.Settings.Default.theme == "светлая")
            {
                radiolight.Checked = true;
            }
            if (Properties.Settings.Default.theme == "темная")
            {
                radiodark.Checked = true;
            }

            okbutton = new Button();
            okbutton.Location = new Point(300,320);
            okbutton.Width = 80;
            okbutton.Height = 40;
            okbutton.Text = "Принять";
            okbutton.Click += apply;
            okbutton.DialogResult = DialogResult.OK;

            cancelbutton = new Button();
            cancelbutton.Location = new Point(300, 300);
            cancelbutton.Location = new Point(200, 320);
            cancelbutton.Width = 80;
            cancelbutton.Height = 40;
            cancelbutton.Text = "Отмена";
            cancelbutton.Click += cancel;


            this.Controls.Add(groupboxtheme);
            this.Controls.Add(okbutton);
            this.Controls.Add(cancelbutton);


        }


        public void cancel(object sender, EventArgs e)
        {
            this.Close();
        }
        public void apply(object sender, EventArgs e)
        {
            if (radiolight.Checked == true)
            {
                Properties.Settings.Default.theme = "светлая";
                Properties.Settings.Default.Save();
            }
            if (radiodark.Checked == true)
            {
                Properties.Settings.Default.theme = "темная";
                Properties.Settings.Default.Save();
            }
            this.Close();
            OPtionsGUI();
        }



    }
}

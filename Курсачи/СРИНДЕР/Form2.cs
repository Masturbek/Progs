using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.IO;

namespace СРИНДЕР
{
    public partial class Form2 : Form
    {
        public Form2(string Login, string Password)
        {
            string login = Login;
            string password = Password;
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.StartPosition = FormStartPosition.CenterScreen;
            mainprofileGUIload(login, password);
        }
        public void Form2_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = Properties.Resources.sds;
         
        }

        public void mainprofileGUIload(string login, string password)
        {
            //this.BackColor = SystemColors.ControlText;
            this.Controls.Clear();
            if (Properties.Settings.Default.theme == "светлая")
            {
                this.BackColor = Color.FromArgb(230, 230, 230);
                this.ForeColor = Color.Black;
            }
            if (Properties.Settings.Default.theme == "темная")
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
                this.ForeColor = Color.White;

            }
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("оДНОгруппники");
            var collection = database.GetCollection<BsonDocument>("accounts");
            var filter = new BsonDocument
            {
              {"_id",$"{login}"},
              {"password", $"{password}"}
            };
            var acc = collection.Find(filter).ToList();
            profilename = new Label();
            profileimage = new PictureBox();
            byte[] photoimg = null;
            BsonValue bs = null;
            labelnameage = new Label();
            labelnameage.Location = new Point(70, 18);
            foreach (var doc in acc)
            {
                labelnameage.Text = $"{doc.GetValue("name")}, {doc.GetValue("age")}";
                bs = doc.GetValue("photo");
            }
            photoimg = bs.AsByteArray;
            MemoryStream ms = new MemoryStream(photoimg, 0, photoimg.Length);
            profileimage.Location = new Point(5, 43);
            profileimage.Width = 200;
            profileimage.Height = 220;
            profileimage.SizeMode = PictureBoxSizeMode.StretchImage;
            profileimage.Image = new Bitmap(ms);
            profileimage.BorderStyle = BorderStyle.FixedSingle;
            editprofile = new Button();
            editprofile.Location = new Point(5, 274);
            editprofile.Width = 200;
            editprofile.Height = 37;
            editprofile.Text = "Редактировать профиль";
            //editprofile.Click += ;
            messages = new Button();
            messages.Location = new Point(525, 88);
            messages.Width = 243;
            messages.Height = 58;
            messages.Text = "СООБЩЕНИЯ";
            //messages.Click += ;
            notifications = new Button();
            notifications.Location = new Point(525, 201);
            notifications.Width = 243;
            notifications.Height = 58;
            notifications.Text = "УВЕДОМЛЕНИЯ";
            //notifications.Click += ;
            findcouple = new Button();
            findcouple.Location = new Point(525, 316);
            findcouple.Width = 243;
            findcouple.Height = 58;
            findcouple.Text = "ПОИСК ПАРЫ";
            //findcouple.Click += ;
            pnl = new Panel();
            pnl.Location = new Point(388, 0);
            pnl.Width = 10;
            pnl.Height = 666;
            aboutme = new Label();
            aboutme.AutoSize = true;
            aboutme.Text = "0000000000";
            pnl.BackColor = SystemColors.ScrollBar;   
            infopanel = new FlowLayoutPanel();
            infopanel.Location = new Point(8, 452);
            infopanel.BackColor = Color.White;
            infopanel.BorderStyle = BorderStyle.FixedSingle;
            infopanel.AutoScroll = true;
            infopanel.WrapContents = true;
            infopanel.HorizontalScroll.Visible = false;
            infopanel.Width = 170;
            infopanel.Height = 116;
            if (Properties.Settings.Default.theme == "светлая")
            {
                infopanel.BackColor = Color.White;

            }
            if (Properties.Settings.Default.theme == "темная")
            {
                infopanel.BackColor = Color.FromArgb(96, 96, 96);
            }
            infopanel.Controls.Add(aboutme);

            options = new Button();
            options.Location = new Point(830, 15);
            options.Width = 40;
            options.Height = 40;
            options.BackgroundImage = Properties.Resources.options;
            options.FlatStyle = FlatStyle.Flat;
            options.FlatAppearance.BorderSize = 0;
            options.FlatAppearance.MouseDownBackColor = Color.Transparent;
            options.FlatAppearance.MouseOverBackColor = Color.Transparent;
            options.Click += Options;

            this.Controls.Add(labelnameage);
            this.Controls.Add(profileimage);
            this.Controls.Add(editprofile);
            this.Controls.Add(messages);
            this.Controls.Add(notifications);
            this.Controls.Add(findcouple);
            this.Controls.Add(pnl);
            this.Controls.Add(infopanel);
            this.Controls.Add(options);

        }
        private void Options(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.FormClosing += closed;


        }
        public void closed(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                this.BackColor = Color.FromArgb(230, 230, 230);
                this.ForeColor = Color.Black;
            }
            if (Properties.Settings.Default.theme == "темная")
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
                this.ForeColor = Color.White;

            }
        }
        private void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}

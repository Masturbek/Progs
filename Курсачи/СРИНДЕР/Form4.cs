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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string filepath;
        private void Form4_Load(object sender, EventArgs e)
        {
            EditGUI();
        }
        public void EditGUI()
        {
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
            nameedit = new Button();
            nameedit.Location = new Point(90, 50);
            nameedit.Width = 200;
            nameedit.Height = 50;
            nameedit.Text = "Изменить имя";
            nameedit.FlatStyle = FlatStyle.Flat;
            //nameedit.Font = new Font("Microsoft Sans Serif", 10);
            nameedit.Click += NameEdit;
            ageedit = new Button();
            ageedit.Location = new Point(90, 140);
            ageedit.Width = 200;
            ageedit.Height = 50;
            ageedit.Text = "Изменить возраст";
            ageedit.FlatStyle = FlatStyle.Flat;
            ageedit.Click += AgeEdit;
            profileimagedit = new Button();
            profileimagedit.Location = new Point(90, 230);
            profileimagedit.Width = 200;
            profileimagedit.Height = 50;
            profileimagedit.Text = "Изменить аватар";
            profileimagedit.FlatStyle = FlatStyle.Flat;
            profileimagedit.Click += AvatarEdit;
            infoedit = new Button();
            infoedit.Location = new Point(90, 320);
            infoedit.Width = 200;
            infoedit.Height = 50;
            infoedit.Text = "Изменить информацию о себе";
            infoedit.FlatStyle = FlatStyle.Flat;
            infoedit.Click += InfoEdit;
            passwordedit = new Button();
            passwordedit.Location = new Point(90, 410);
            passwordedit.Width = 200;
            passwordedit.Height = 50;
            passwordedit.Text = "Изменить пароль";
            passwordedit.FlatStyle = FlatStyle.Flat;
            passwordedit.Click += PasswordEdit;




            this.Controls.Add(nameedit);
            this.Controls.Add(ageedit);
            this.Controls.Add(profileimagedit);
            this.Controls.Add(infoedit);
            this.Controls.Add(passwordedit);
        }
        private void NameEdit(object sender, EventArgs e)
        {
            this.Controls.Clear();
            labeledit = new Label();
            labeledit.Location = new Point(160, 160);
            //labelname.Width = 200;
            //labelname.Height = 50;
            labeledit.Text = "Введите имя";
            textboxname = new TextBox();
            textboxname.Location = new Point(128, 195);
            textboxname.Width = 130;
            textboxname.Height = 20;
            textboxname.MaxLength = 16;
            textboxname.TextChanged += NameCheckEdit;
            buttonedit = new Button();
            buttonedit.Location = new Point(128, 350);
            buttonedit.Width = 130;
            buttonedit.Height = 40;
            buttonedit.Text = "Принять";
            buttonedit.Click += ApplyEditName;
            buttonedit.FlatStyle = FlatStyle.Flat;
            backbutton = new Button();
            backbutton.Location = new Point(15, 20);
            backbutton.Width = 75;
            backbutton.Height = 23;
            backbutton.Text = "Назад";
            backbutton.Click += backbt;
            backbutton.FlatStyle = FlatStyle.Flat;

            okpict = new PictureBox();
            okpict.Width = 20;
            okpict.Height = 20;
            okpict.Location = new Point(261, 195);
            okpict.Image = Properties.Resources.ok;

            nullnameedit = new PictureBox();
            nullnameedit.Width = 20;
            nullnameedit.Height = 20;
            nullnameedit.Location = new Point(261, 195);
            nullnameedit.Image = Properties.Resources.err;
            tooltip1 = new ToolTip();
            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 100;
            tooltip1.ReshowDelay = 100;
            tooltip1.SetToolTip(nullnameedit, "Поле не может быть пустым");

            incorrectnameedit = new PictureBox();
            incorrectnameedit.Width = 20;
            incorrectnameedit.Height = 20;
            incorrectnameedit.Location = new Point(261, 195);
            incorrectnameedit.Image = Properties.Resources.err;
            tooltip2 = new ToolTip();
            tooltip2.AutoPopDelay = 5000;
            tooltip2.InitialDelay = 100;
            tooltip2.ReshowDelay = 100;
            tooltip2.SetToolTip(incorrectnameedit, "Только латиница[A-z] и кириллица[А-я]");

            this.Controls.Add(labeledit);
            this.Controls.Add(textboxname);
            this.Controls.Add(buttonedit);
            this.Controls.Add(backbutton);
            this.Controls.Add(okpict);
            this.Controls.Add(nullnameedit);
            this.Controls.Add(incorrectnameedit);
            okpict.Hide();
            incorrectnameedit.Hide();
            buttonedit.Enabled = false;
        }
        private void AgeEdit(object sender, EventArgs e)
        {
            this.Controls.Clear();
            labeledit = new Label();
            labeledit.Location = new Point(145, 160);
            labeledit.Text = "Введите возраст";
            age = new NumericUpDown();
            age.Location = new Point(150, 180);
            age.Maximum = 80;
            age.Minimum = 18;
            age.Width = 80;
            age.Height = 40;
            buttonedit = new Button();
            buttonedit.Location = new Point(128, 350);
            buttonedit.Width = 130;
            buttonedit.Height = 40;
            buttonedit.Text = "Принять";
            buttonedit.Click += ApplyEditAge;
            buttonedit.FlatStyle = FlatStyle.Flat;
            backbutton = new Button();
            backbutton.Location = new Point(15, 20);
            backbutton.Width = 75;
            backbutton.Height = 23;
            backbutton.Text = "Назад";
            backbutton.Click += backbt;
            backbutton.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(age);
            this.Controls.Add(labeledit);
            this.Controls.Add(buttonedit);
            this.Controls.Add(backbutton);
        }
        private void AvatarEdit(object sender, EventArgs e)
        {
            this.Controls.Clear();
            labeledit = new Label();
            labeledit.Location = new Point(146, 160);
            labeledit.Text = "Выберите файл";
            buttonedit = new Button();
            buttonedit.Location = new Point(128, 350);
            buttonedit.Width = 130;
            buttonedit.Height = 40;
            buttonedit.Text = "Принять";
            buttonedit.Click += ImageEdit;
            buttonedit.FlatStyle = FlatStyle.Flat;
            backbutton = new Button();
            backbutton.Location = new Point(15, 20);
            backbutton.Width = 75;
            backbutton.Height = 23;
            backbutton.Text = "Назад";
            backbutton.Click += backbt;
            backbutton.FlatStyle = FlatStyle.Flat;
            filepick = new Button();
            filepick.Location = new Point(130, 210);
            filepick.Width = 120;
            filepick.Height = 30;
            filepick.Text = "Выбрать файл";
            filepick.Click += FilePick;
            filepick.FlatStyle = FlatStyle.Flat;
            this.Controls.Add(buttonedit);
            this.Controls.Add(backbutton);
            this.Controls.Add(labeledit);
            this.Controls.Add(filepick);
        }
        public void InfoEdit(object sender, EventArgs e)
        {
            this.Controls.Clear();
            labeledit = new Label();
            labeledit.Location = new Point(115, 160);
            labeledit.Width = 200;
            labeledit.Height = 30;
            labeledit.Text = "Введите информацию о себе";
            backbutton = new Button();
            backbutton.Location = new Point(15, 20);
            backbutton.Width = 75;
            backbutton.Height = 23;
            backbutton.Text = "Назад";
            backbutton.Click += backbt;
            backbutton.FlatStyle = FlatStyle.Flat;
            buttonedit = new Button();
            buttonedit.Location = new Point(128, 350);
            buttonedit.Width = 130;
            buttonedit.Height = 40;
            buttonedit.Text = "Принять";
            buttonedit.Click += ApplyEditInfo;
            buttonedit.FlatStyle = FlatStyle.Flat;
            textboxedit = new TextBox();
            textboxedit.Location = new Point(77,200);
            textboxedit.Multiline = true;
            textboxedit.Width = 230;
            textboxedit.Height = 90;
            textboxedit.MaxLength = 350;
            textboxedit.ScrollBars = ScrollBars.Vertical;
            //textboxinfoedit.TextChanged += ;

            this.Controls.Add(labeledit);
            this.Controls.Add(buttonedit);
            this.Controls.Add(backbutton);
            this.Controls.Add(textboxedit);
        }
        public void PasswordEdit(object sender, EventArgs e)
        {
            this.Controls.Clear();
            labeledit = new Label();
            labeledit.Location = new Point(130, 160);
            labeledit.Width = 200;
            labeledit.Height = 20;
            labeledit.Text = "Введите новый пароль";
            backbutton = new Button();
            backbutton.Location = new Point(15, 18);
            backbutton.Width = 75;
            backbutton.Height = 23;
            backbutton.Text = "Назад";
            backbutton.Click += backbt;
            backbutton.FlatStyle = FlatStyle.Flat;
            buttonedit = new Button();
            buttonedit.Location = new Point(128, 350);
            buttonedit.Width = 130;
            buttonedit.Height = 40;
            buttonedit.Text = "Принять";
            buttonedit.Click += ApplyEditPass;
            buttonedit.FlatStyle = FlatStyle.Flat;
            textboxedit = new TextBox();
            textboxedit.Location = new Point(140, 190);
            textboxedit.MaxLength = 24;
            textboxedit.UseSystemPasswordChar = true;
            textboxedit.TextChanged += PassCheckEdit;
            passbutton = new Button();
            passbutton.Location = new Point(250, 189);
            passbutton.Text = "👁";
            passbutton.TextAlign = ContentAlignment.MiddleCenter;
            passbutton.Width = 22;
            passbutton.Height = 22;
            passbutton.Click += passSwitch;
            passbutton.FlatStyle = FlatStyle.Flat;
            okpict = new PictureBox();
            okpict.Width = 20;
            okpict.Height = 20;
            okpict.Location = new Point(275, 190);
            okpict.Image = Properties.Resources.ok;
            errpasspict = new PictureBox();
            errpasspict.Width = 20;
            errpasspict.Height = 20;
            errpasspict.Location = new Point(275, 190);
            errpasspict.Image = Properties.Resources.err;
            emptypasspict = new PictureBox();
            emptypasspict.Width = 20;
            emptypasspict.Height = 20;
            emptypasspict.Location = new Point(275, 190);
            emptypasspict.Image = Properties.Resources.err;
            tooltip1 = new ToolTip();
            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 100;
            tooltip1.ReshowDelay = 100;
            tooltip1.SetToolTip(errpasspict, "Пароль не может быть короче 4 символов");
            tooltip2 = new ToolTip();
            tooltip2.AutoPopDelay = 5000;
            tooltip2.InitialDelay = 100;
            tooltip2.ReshowDelay = 100;
            tooltip2.SetToolTip(emptypasspict, "Поле не может быть пустым");


            this.Controls.Add(labeledit);
            this.Controls.Add(buttonedit);
            this.Controls.Add(backbutton);
            this.Controls.Add(passbutton);
            this.Controls.Add(textboxedit);
            this.Controls.Add(okpict);
            this.Controls.Add(errpasspict);
            this.Controls.Add(emptypasspict);
            errpasspict.Hide();
            okpict.Hide();
            buttonedit.Enabled = false;
        }
        public void backbt(object sender, EventArgs e)
        {
            EditGUI();
        }
        public void FilePick(object sender, EventArgs e)
        {
            filepickdialog = new OpenFileDialog();
            filepickdialog.Filter = "Файлы png|*.png|Файлы jpg|*.jpg|Файлы jpeg|*.jpeg";
            if (filepickdialog.ShowDialog() == DialogResult.OK)
            {

                filepath = $"{filepickdialog.FileName}";

                //MessageBox.Show(filepickdialog.FileName);
            }
        }
        public void ImageEdit(object sender, EventArgs e)
        {

            try
            {
                if (filepath != null)
                {
                    string connectionString = "mongodb://localhost:27017";
                    MongoClient client = new MongoClient(connectionString);
                    var database = client.GetDatabase("оДНОгруппники");
                    var collection = database.GetCollection<BsonDocument>("accounts");

                    var filter = new BsonDocument
                    {
                       {"_id",$"{Properties.Settings.Default.Ulogin}"},
                       {"password", $"{Properties.Settings.Default.Upassword}"}
                    };
                    byte[] array = File.ReadAllBytes($"{filepath}");


                    var update = new BsonDocument("$set", new BsonDocument {
                       {"photo", array},
                    });
                    collection.UpdateOne(filter, update);
                    this.Close();
                }
                else { MessageBox.Show("Файл не выбран"); }
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
        public void NameCheckEdit(object sender, EventArgs e)
        {
            char[] ch = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            int charch = 0;
            incorrectnameedit.Hide();
            okpict.Hide();
            nullnameedit.Hide();
            for (int i = 0; i < textboxname.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (textboxname.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }

                }
            }
            if (textboxname.Text == "")
            {
                nullnameedit.Show();
                buttonedit.Enabled = false;
            }
            else
            {
                if (charch != textboxname.Text.Length && textboxname.Text != "")
                {
                    incorrectnameedit.Show();
                    buttonedit.Enabled = false;
                }
                else
                {
                    okpict.Show();
                    buttonedit.Enabled = true;
                }
            }
        }
        public void PassCheckEdit(object sender, EventArgs e)
        {
            okpict.Hide();
            errpasspict.Hide();
            if (textboxedit.Text == "")
            {
                emptypasspict.Show();
                buttonedit.Enabled = false;
            }
            else
            {
                okpict.Show();
                buttonedit.Enabled = true;
            }
            if (textboxedit.Text.Length < 4 && textboxedit.Text != "")
            {
                okpict.Hide();
                errpasspict.Show();
                buttonedit.Enabled = false;
            }

        }

        public void ApplyEditName(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<BsonDocument>("accounts");

                var filter = new BsonDocument
                {
                  {"_id",$"{Properties.Settings.Default.Ulogin}"},
                  {"password", $"{Properties.Settings.Default.Upassword}"}
                };
                string namestr = textboxname.Text;
                char[] c = new char[textboxname.Text.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    if (i == 0)
                        c[i] = Char.ToUpper(textboxname.Text[i]);
                    else c[i] = Char.ToLower(textboxname.Text[i]);
                }
                namestr = new string(c);
                var update = new BsonDocument("$set", new BsonDocument {
                  {"name", $"{namestr}"},
                });
                collection.UpdateOne(filter, update);
                this.Close();
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
        public void ApplyEditAge(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<BsonDocument>("accounts");

                var filter = new BsonDocument
                {
                  {"_id",$"{Properties.Settings.Default.Ulogin}"},
                  {"password", $"{Properties.Settings.Default.Upassword}"}
                };
              
                var update = new BsonDocument("$set", new BsonDocument {
                  {"age", Convert.ToInt32(age.Value)},
                });
                collection.UpdateOne(filter, update);
                this.Close();
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
        public void ApplyEditInfo(object sender, EventArgs e)
        {

            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("оДНОгруппники");
            var collection = database.GetCollection<BsonDocument>("accounts");

            var filter = new BsonDocument
                {
                  {"_id",$"{Properties.Settings.Default.Ulogin}"},
                  {"password", $"{Properties.Settings.Default.Upassword}"}
                };

            var update = new BsonDocument("$set", new BsonDocument {
                  {"info", $"{textboxedit.Text}"},
                });
            collection.UpdateOne(filter, update);
            this.Close();
        }
        public void passSwitch(object sender, EventArgs e)
        {
            if (textboxedit.UseSystemPasswordChar == true)
                textboxedit.UseSystemPasswordChar = false;
            else textboxedit.UseSystemPasswordChar = true;

        }
        public void ApplyEditPass(object sender, EventArgs e)
        {;
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("оДНОгруппники");
            var collection = database.GetCollection<BsonDocument>("accounts");
            var filter = new BsonDocument
                {
                  {"_id",$"{Properties.Settings.Default.Ulogin}"},
                  {"password", $"{Properties.Settings.Default.Upassword}"}
                };
            Properties.Settings.Default.Upassword = textboxedit.Text;
            Properties.Settings.Default.Save();
            var update = new BsonDocument("$set", new BsonDocument {
               {"password", $"{textboxedit.Text}"},
            });
            collection.UpdateOne(filter, update);
            this.Close();
        }
    }
}

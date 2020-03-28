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
using Mongo.GridFs;
using MongoDB.GridFS;
using MongoDB.Driver.GridFS;
using System.IO;


namespace СРИНДЕР
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.BackColor = SystemColors.Control;          
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                this.BackColor = Color.FromArgb(230, 230, 230);
            }
            if (Properties.Settings.Default.theme == "темная")
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            //this.BackgroundImage = Properties.Resources.sds;
            AuthGUI();
        }          
        public void AuthGUI()
        {
            
            label1 = new Label();
            label1.Location = new Point(160, 74);
            label1.Text = "FriendZoned®";
            label1.BackColor = Color.Transparent;
            this.Controls.Add(label1);
            bt1 = new Button();
            bt1.Name = "button1";
            bt1.Text = "Регистрация";
            bt1.Width = 129;
            bt1.Height = 42;
            bt1.Location = new Point(123, 159);
            bt1.FlatStyle = FlatStyle.Flat;
            bt1.FlatAppearance.BorderColor = Color.DarkGray;
            bt1.Click += this.bt1_reg;
            bt2 = new Button();
            bt2.Name = "button2";
            bt2.Text = "Вход";
            bt2.Width = 129;
            bt2.Height = 44;
            bt2.Location = new Point(123, 244);
            bt2.Click += this.bt2auth;
            this.Controls.Add(bt1);
            this.Controls.Add(bt2);
        }
        public void bt2auth(object sender, EventArgs e)
        {
            this.Controls.Clear();
            loginGUIload();
        }

        public void bt1_reg(object sender,EventArgs e)
        {
            this.Controls.Clear();
            regGUIload();
        }
        public void backbt(object sender, EventArgs e)
        {
            this.Controls.Clear();
            AuthGUI();
        }
        public void loginGUIload()
        {
            this.Controls.Clear();
            labelauth1 = new Label();
            labelauth2 = new Label();
            labelauth1.Location = new Point(169, 75);
            labelauth2.Location = new Point(169, 165);
            labelauth1.Text = "Логин";
            labelauth2.Text = "Пароль";
            buttonauth = new Button();
            buttonauth.Text = "Вход";
            buttonauth.Width = 144;
            buttonauth.Height = 44;
            buttonauth.Click += logIN;
            buttonauth.Location = new Point(121, 288);
            //buttonauth.FlatStyle = FlatStyle.Flat;
            //buttonauth.FlatAppearance.BorderColor = Color.Black;
            //buttonauth.FlatAppearance.BorderSize = 1;
            textboxauth1 = new TextBox();
            textboxauth2 = new TextBox();
            textboxauth1.MaxLength = 16;
            textboxauth2.MaxLength = 24;
            textboxauth1.BorderStyle = BorderStyle.FixedSingle;
            textboxauth2.BorderStyle = BorderStyle.FixedSingle;
            textboxauth1.BackColor = SystemColors.Menu;
            textboxauth2.BackColor = SystemColors.Menu;
            textboxauth1.Location = new Point(140, 101);
            textboxauth2.Location = new Point(140, 190);
            textboxauth2.UseSystemPasswordChar = true;
            if (Properties.Settings.Default.state == 1)
            {
                textboxauth1.Text =Properties.Settings.Default.Userlogin;
                textboxauth2.Text = Properties.Settings.Default.Userpassword;
            }
            backbutton = new Button();
            backbutton.Text = "Назад";
            backbutton.Width = 75;
            backbutton.Height = 23;
            backbutton.Location = new Point(12, 12);
            backbutton.Click += this.backbt;
            passbutton = new Button();
            passbutton.Location = new Point(244, 189);
            passbutton.Text = "👁";
            passbutton.TextAlign = ContentAlignment.MiddleCenter;
            passbutton.Width = 22;
            passbutton.Height = 22;
            passbutton.Click += this.passSwitch2;
            remember = new CheckBox();
            remember.Location = new Point(155,350);
            remember.Text = "Запомнить";
            //remember.CheckedChanged += remembercheck;
            this.Controls.Add(labelauth1);
            this.Controls.Add(labelauth2);
            this.Controls.Add(buttonauth);
            this.Controls.Add(textboxauth1);
            this.Controls.Add(textboxauth2);
            this.Controls.Add(backbutton);
            this.Controls.Add(passbutton);
            this.Controls.Add(remember);

        }
        public void regGUIload()
        {
            this.Controls.Clear();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            regbt1 = new Button();
            regbt1.Enabled = false;
            regbt2 = new Button();
            regbt2.Enabled = false;
            regbt3 = new Button();
            regbt3.Enabled = false;
            regbt4 = new Button();
            regbt4.Enabled = false;
            regbt5 = new Button();
            regbt5.Enabled = false;
            labelreg1 = new Label();
            labelreg2 = new Label();
            labelreg3 = new Label();
            labelreg4 = new Label();
            labelreg5 = new Label();
            labelreg6 = new Label();
            labelreg1.Location = new Point(179, 38);
            labelreg2.Location = new Point(175, 94);
            labelreg3.Location = new Point(180, 144);
            labelreg4.Location = new Point(181, 194);
            labelreg5.Location = new Point(176, 240);
            labelreg6.Location = new Point(185, 290);
            labelreg1.BackColor = TransparencyKey;
            labelreg2.BackColor = TransparencyKey;
            labelreg3.BackColor = TransparencyKey;
            labelreg4.BackColor = TransparencyKey;
            labelreg5.BackColor = TransparencyKey;
            labelreg6.BackColor = TransparencyKey;
            labelreg1.Text = "Логин";
            labelreg2.Text = "Пароль";
            labelreg3.Text = "E-mail";
            labelreg4.Text = "Имя";
            labelreg5.Text = "Возраст";
            labelreg6.Text = "Пол";
            labelreg1.BackColor = Color.Transparent;
            labelreg2.BackColor = Color.Transparent;
            labelreg3.BackColor = Color.Transparent;
            labelreg4.BackColor = Color.Transparent;
            labelreg5.BackColor = Color.Transparent;
            labelreg6.BackColor = Color.Transparent;
            textbox1 = new TextBox();
            textbox2 = new TextBox();
            textbox3 = new TextBox();
            textbox4 = new TextBox();
            textbox1.MaxLength = 24;            
            textbox2.MaxLength = 24;
            textbox3.MaxLength = 36;
            textbox4.MaxLength = 16;
            textbox1.BackColor = SystemColors.Menu;
            textbox2.BackColor = SystemColors.Menu;
            textbox3.BackColor = SystemColors.Menu;
            textbox4.BackColor = SystemColors.Menu;
            textbox1.BorderStyle = BorderStyle.FixedSingle;
            textbox2.BorderStyle = BorderStyle.FixedSingle;
            textbox3.BorderStyle = BorderStyle.FixedSingle;
            textbox4.BorderStyle = BorderStyle.FixedSingle;
            textbox1.Location = new Point(146, 60);
            textbox2.Location = new Point(146, 110);
            textbox3.Location = new Point(146, 160);
            textbox4.Location = new Point(146, 210);
            textbox1.TextChanged += logincheckReg;
            textbox2.TextChanged += passcheckReg;
            textbox3.TextChanged += emailcheckReg;
            textbox4.TextChanged += namecheckReg;
            textbox2.UseSystemPasswordChar = true;
            regbutton = new Button();
            regbutton.Text = "Регистрация";
            regbutton.Width = 144;
            regbutton.Height = 44;
            regbutton.Location = new Point(125, 358);
            regbutton.Click += registration;
            backbutton = new Button();
            backbutton.Text = "Назад";
            backbutton.Width = 75;
            backbutton.Height = 23;
            backbutton.Location = new Point(12, 12);
            backbutton.Click += backbt;
            passbutton = new Button();
            passbutton.Location = new Point(250, 109);         
            passbutton.Text = "👁"; 
            passbutton.TextAlign = ContentAlignment.MiddleCenter;
            passbutton.Width = 22;
            passbutton.Height = 22;
            passbutton.Click += this.passSwitch1;
            age = new NumericUpDown();
            age.Location = new Point(180, 260);
            age.Maximum = 80;
            age.Minimum = 18;
            age.Width = 40;
            age.Height = 20;
            age.BackColor = SystemColors.Menu;
            gendermale = new RadioButton();
            gendermale.Location = new Point(155, 300);
            gendermale.Text = "М";
            gendermale.Width = 40;
            gendermale.Height = 40;
            gendermale.CheckedChanged += gendercheckReg;
            genderfemale = new RadioButton();
            genderfemale.Text = "Ж";
            genderfemale.Location = new Point(210, 300);
            genderfemale.Width = 40;
            genderfemale.Height = 40;
            genderfemale.CheckedChanged += gendercheckReg;
            errpict = new PictureBox();
            okpict = new PictureBox();
            emptypict = new PictureBox();
            littlepict = new PictureBox();
            okpasspict = new PictureBox();
            errpasspict = new PictureBox();
            okemailpict = new PictureBox();
            erremailpict = new PictureBox();
            emptypasspict = new PictureBox();
            incorrectemailpict = new PictureBox();
            emptynamepict = new PictureBox();
            oknamepict = new PictureBox();
            incorrectnamepict = new PictureBox();
            incorrectnamepict.Width = 20;
            incorrectnamepict.Height = 20;
            oknamepict.Width = 20;
            oknamepict.Height = 20;
            emptynamepict.Width = 20;
            emptynamepict.Height = 20;
            emptypasspict.Width = 20;
            emptypasspict.Height = 20;
            erremailpict.Width = 20;
            erremailpict.Height = 20;
            okemailpict.Width = 20;
            okemailpict.Height = 20;
            errpasspict.Width = 20;
            errpasspict.Height = 20;
            okpasspict.Width = 20;
            okpasspict.Height = 20;                 
            errpict.Width = 20;
            errpict.Height = 20;
            okpict.Width = 20;
            okpict.Height = 20;
            emptypict.Width = 20;
            emptypict.Height = 20;
            littlepict.Width = 20;
            littlepict.Height = 20;
            incorrectnamepict.Location = new Point(250, 210);
            emptynamepict.Location = new Point(250, 210);
            oknamepict.Location = new Point(250, 210);
            erremailpict.Location = new Point(250, 160);
            okemailpict.Location = new Point(250, 160);
            errpict.Location = new Point(250, 60);
            okpict.Location = new Point(250, 60);
            littlepict.Location = new Point(250, 60);
            emptypict.Location = new Point(250, 60);
            errpasspict.Location = new Point(280, 110);
            okpasspict.Location = new Point(280, 110);
            emptypasspict.Location = new Point(280, 110);
            incorrectemailpict.Location = new Point(250, 160);
            incorrectnamepict.Image = Properties.Resources.err;
            emptynamepict.Image = Properties.Resources.err;
            oknamepict.Image = Properties.Resources.ok;
            errpict.Image = Properties.Resources.err;
            okpict.Image = Properties.Resources.ok;
            emptypict.Image = Properties.Resources.err;
            littlepict.Image = Properties.Resources.err;
            errpasspict.Image = Properties.Resources.err;
            okpasspict.Image = Properties.Resources.ok;
            erremailpict.Image = Properties.Resources.err;
            okemailpict.Image = Properties.Resources.ok;
            emptypasspict.Image = Properties.Resources.err;
            incorrectemailpict.Image = Properties.Resources.err;
            tooltip1 = new ToolTip();
            tooltip1.AutoPopDelay = 5000;
            tooltip1.InitialDelay = 100;
            tooltip1.ReshowDelay = 100;
            tooltip1.SetToolTip(this.errpict, "Только латиница[A-z] и цифры[0-9]");
            tooltip2 = new ToolTip();
            tooltip2.AutoPopDelay = 5000;
            tooltip2.InitialDelay = 100;
            tooltip2.ReshowDelay = 100;
            tooltip2.SetToolTip(this.emptypict, "Поле не может быть пустым");
            tooltip3 = new ToolTip();
            tooltip3.AutoPopDelay = 5000;
            tooltip3.InitialDelay = 100;
            tooltip3.ReshowDelay = 100;
            tooltip3.SetToolTip(this.littlepict, "Логин не может быть короче 5 символов");
            tooltip4 = new ToolTip();
            tooltip4.AutoPopDelay = 5000;
            tooltip4.InitialDelay = 100;
            tooltip4.ReshowDelay = 100;
            tooltip4.SetToolTip(this.errpasspict, "Пароль не может быть короче 4 символов");
            tooltip5 = new ToolTip();
            tooltip5.AutoPopDelay = 5000;
            tooltip5.InitialDelay = 100;
            tooltip5.ReshowDelay = 100;
            tooltip5.SetToolTip(this.emptypasspict, "Поле не может быть пустым");
            tooltip5 = new ToolTip();
            tooltip5.AutoPopDelay = 5000;
            tooltip5.InitialDelay = 100;
            tooltip5.ReshowDelay = 100;
            tooltip5.SetToolTip(this.erremailpict, "Поле не может быть пустым");
            tooltip6 = new ToolTip();
            tooltip6.AutoPopDelay = 5000;
            tooltip6.InitialDelay = 100;
            tooltip6.ReshowDelay = 100;
            tooltip6.SetToolTip(this.incorrectemailpict, "Неккоректная почта");
            tooltip7 = new ToolTip();
            tooltip7.AutoPopDelay = 5000;
            tooltip7.InitialDelay = 100;
            tooltip7.ReshowDelay = 100;
            tooltip7.SetToolTip(this.emptynamepict, "Поле не может быть пустым");
            tooltip8 = new ToolTip();
            tooltip8.AutoPopDelay = 5000;
            tooltip8.InitialDelay = 100;
            tooltip8.ReshowDelay = 100;
            tooltip8.SetToolTip(this.incorrectnamepict, "Только латиница[A-z] и кириллица[А-я]");
            this.Controls.Add(labelreg1);
            this.Controls.Add(labelreg2);
            this.Controls.Add(labelreg3);
            this.Controls.Add(labelreg4);
            this.Controls.Add(labelreg5);
            this.Controls.Add(labelreg6);
            this.Controls.Add(textbox1);
            this.Controls.Add(textbox2);
            this.Controls.Add(textbox3);
            this.Controls.Add(textbox4);
            this.Controls.Add(regbutton);
            this.Controls.Add(backbutton);
            this.Controls.Add(passbutton);
            this.Controls.Add(errpict);
            this.Controls.Add(okpict);
            this.Controls.Add(emptypict);
            this.Controls.Add(littlepict);
            this.Controls.Add(okpasspict);
            this.Controls.Add(errpasspict);
            this.Controls.Add(okemailpict);
            this.Controls.Add(erremailpict);
            this.Controls.Add(emptypasspict);
            this.Controls.Add(incorrectemailpict);
            this.Controls.Add(emptynamepict);
            this.Controls.Add(oknamepict);
            this.Controls.Add(incorrectnamepict);
            this.Controls.Add(age);
            this.Controls.Add(gendermale);
            this.Controls.Add(genderfemale);
            passbutton.BringToFront();
            textbox1.BringToFront();
            textbox2.BringToFront();
            textbox3.BringToFront();
            okemailpict.BringToFront();
            erremailpict.BringToFront();
            incorrectemailpict.BringToFront();
            errpict.BringToFront();
            emptypict.BringToFront();
            littlepict.BringToFront();
            okpict.BringToFront();
            textbox4.BringToFront();
            oknamepict.BringToFront();
            emptynamepict.BringToFront();
            age.BringToFront();
            incorrectnamepict.BringToFront();
            errpict.Hide();
            okpict.Hide();
            littlepict.Hide();
            okpasspict.Hide();           
            okemailpict.Hide();
            errpasspict.Hide();
            incorrectemailpict.Hide();
            oknamepict.Hide();
            incorrectnamepict.Hide();
            regbutton.Enabled = false;          
        }
        public void logincheckReg(object sender, EventArgs e)
        {         
            emptypict.Hide();
            okpict.Hide();
            errpict.Hide();
            littlepict.Hide();
            char[] ch = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T', 'U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0'};
            int charch = 0;
            for (int i = 0; i < textbox1.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (textbox1.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }
                    
                }
            }
            if (charch == textbox1.Text.Length && textbox1.Text != "" && textbox1.Text.Length > 4)
            {
                okpict.Show();
                regbt1.Enabled = true;
                buttonregenabled();
            }
            if (charch != textbox1.Text.Length && textbox1.Text != "")
            {              
                errpict.Show();
                regbt1.Enabled = false;
                buttonregenabled();
            }
            if (textbox1.Text == "")
            {
                emptypict.Show();
                regbt1.Enabled = false;
                buttonregenabled();
            }
            if (textbox1.Text.Length <= 4)
            {
                littlepict.Show();
                regbt1.Enabled = false;
                buttonregenabled();
            }
        }
        public void passcheckReg(object sender, EventArgs e)
        {
            okpasspict.Hide();
            errpasspict.Hide();
            if (textbox2.Text == "")
            {
                emptypasspict.Show();
                regbt2.Enabled = false;
                buttonregenabled();
            }
            else
            {
                okpasspict.Show();
                regbt2.Enabled = true;
                buttonregenabled();
            }
            if (textbox2.Text.Length < 4 && textbox2.Text != "")
            {
                okpasspict.Hide();              
                errpasspict.Show();
                regbt2.Enabled = false;
                buttonregenabled();
            }          
            
        }
        public void emailcheckReg(object sender, EventArgs e)
        {
            okemailpict.Hide();
            erremailpict.Hide();
            incorrectemailpict.Hide();
            if (textbox3.Text.Contains("@mail.ru") || textbox3.Text.Contains("@gmail.com") || textbox3.Text.Contains("@yandex.ru") || textbox3.Text.Contains("@bk.ru") || textbox3.Text.Contains("@rambler.ru") || textbox3.Text.Contains("@list.ru") && textbox3.Text != "")
            {
                okemailpict.Show();
                regbt3.Enabled = true;
                buttonregenabled();
            }
            else {
                if (textbox3.Text == "")
                {
                    erremailpict.Show();
                    regbt3.Enabled = false;
                    buttonregenabled();
                }
                else
                {
                    incorrectemailpict.Show();
                    regbt3.Enabled = false;
                    buttonregenabled();
                }
            }
           
        }
        public void namecheckReg(object sender, EventArgs e)
        {
            char[] ch = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З','И', 'Й','К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й','к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я'};
            int charch = 0;
            incorrectnamepict.Hide();
            oknamepict.Hide();
            emptynamepict.Hide();
            for (int i = 0; i < textbox4.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (textbox4.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }

                }
            }
            if (textbox4.Text == "")
            {
                emptynamepict.Show();
                regbt4.Enabled = false;
                buttonregenabled();
            }
            else
            {
                if (charch != textbox4.Text.Length && textbox4.Text != "")
                {
                    incorrectnamepict.Show();
                    regbt4.Enabled = false;
                    buttonregenabled();
                }
                else
                {
                    oknamepict.Show();
                    regbt4.Enabled = true;
                    buttonregenabled();
                }
            } 
        }
        public void gendercheckReg(object sender, EventArgs e)
        {
            if (gendermale.Checked == true || genderfemale.Checked == true)
            {
                regbt5.Enabled = true;
                buttonregenabled();
            }
            else
            {
                regbt5.Enabled = false;
                buttonregenabled();
            }
        }
        //public void remembercheck(object sender, EventArgs e)
        //{

        //}
        public void buttonregenabled()
        {
            if (regbt1.Enabled == true && regbt2.Enabled == true && regbt3.Enabled == true && regbt4.Enabled == true && regbt5.Enabled == true)
            regbutton.Enabled = true;
            else regbutton.Enabled = false;
        }
        public void passSwitch1(object sender, EventArgs e)
        {
            if (textbox2.UseSystemPasswordChar == true)
                textbox2.UseSystemPasswordChar = false;
            else textbox2.UseSystemPasswordChar = true;

        }
        public void passSwitch2(object sender, EventArgs e)
        {
            if (textboxauth2.UseSystemPasswordChar == true)
                textboxauth2.UseSystemPasswordChar = false;
            else textboxauth2.UseSystemPasswordChar = true;

        }
        public void registration(object sender, EventArgs e)
        {
            try
            {               
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<BsonDocument>("accounts");
                byte[] array = File.ReadAllBytes("C:\\Users\\user\\Desktop\\noavatar.png");
                string namestr = textbox4.Text;
                char[] c = new char[textbox4.Text.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    if (i == 0)
                      c[i] = Char.ToUpper(textbox4.Text[i]);
                    else c[i] = Char.ToLower(textbox4.Text[i]);
                }
                namestr = new string(c);
                BsonDocument account = new BsonDocument {
                 {"_id",$"{textbox1.Text}"},
                 {"password", $"{textbox2.Text}"},
                 {"E-mail", $"{textbox3.Text}"},
                 {"name", $"{namestr}"},
                 {"age", Convert.ToInt32(age.Value)},
                 {"photo", array},
                };              
                collection.InsertOne(account);
                MessageBox.Show("Регистрация успешна\n      Теперь войдите");
                loginGUIload();
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
        public void logIN(object sender, EventArgs e)
        {
            if (remember.Checked == true)
            {
                Properties.Settings.Default.Userlogin = textboxauth1.Text;
                Properties.Settings.Default.Userpassword = textboxauth2.Text;
                Properties.Settings.Default.state = 1;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.state = 0;
                Properties.Settings.Default.Save();
            }
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("оДНОгруппники");
            var collection = database.GetCollection<BsonDocument>("accounts");
            var filter = new BsonDocument
            {
                {"_id",$"{textboxauth1.Text}"},
              {"password", $"{textboxauth2.Text}"}
            };
            var acc = collection.Find(filter).ToList();
            bool finded = false;
            foreach (var doc in acc)
            {
                finded = true;
                
                Form2 form2 = new Form2(textboxauth1.Text, textboxauth2.Text);
                form2.Show();
                form2.FormClosed += openAUTH;
                this.Hide();
            }
            if (finded == false)
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //!!!!!!!!APPLICATION
        }
        public void openAUTH(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.theme == "светлая")
            {
                this.BackColor = Color.FromArgb(230, 230, 230);
            }
            if (Properties.Settings.Default.theme == "темная")
            {
                this.BackColor = Color.FromArgb(64, 64, 64);
            }
            this.Show();
            
        }
    }
}

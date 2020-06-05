using MongoDB.Driver;
using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Талончик
{
    public partial class Form1 : Form
    {
        bool assistanthelp;
        bool PasswordСorrectness;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordclient.TextChangedB += checkBox1_CheckedChanged;
            regpasswordclient.TextChangedB += checkBox2_CheckedChanged;
            regpasswordclient.TextChangedB += CHek;
            surnameclient.TextChangedB += Methods.KeyPressFirstCharToUpperB;
            nameclient.TextChangedB += Methods.KeyPressFirstCharToUpperB;
            panelinput.VisibleChanged += ClearPanel;
            snilsclient.Click += (s, a) =>
            {
                snilsclient.SelectionStart = 0;
                if (snilsclient.Text != "   -   -   -") snilsclient.SelectionStart = snilsclient.Text.Length;
            };
            phoneclient.Click += (s, f) =>
            {
                phoneclient.SelectionStart = 0;
                if (phoneclient.Text != "(   )    -") phoneclient.SelectionStart = phoneclient.Text.Length;
            };
            tabControl1.DrawItem += Methods.TabControl_DrawItem;
        }
        public void ClearPanel(object sender, EventArgs e)
        {
            surnameclient.Clear();
            nameclient.Clear();
            regpasswordclient.Clear();
            buttonregistration.Focus();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordclient.SaveText != passwordclient.CurrentText)
            {
                if (checkpassword.Checked) passwordclient.PasswordVisible = false;
                else passwordclient.PasswordVisible = true;
            }
            else checkpassword.Checked = false;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (regpasswordclient.SaveText != regpasswordclient.CurrentText)
            {
                if (regcheckpassword.Checked)
                {
                    regpasswordclient.PasswordVisible = false;
                }
                else regpasswordclient.PasswordVisible = true;
            }
            else regcheckpassword.Checked = false;
        }
        private void NotRegister_Click(object sender, EventArgs e)
        {
            panelinput.Visible = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Регистрация";
            nameclient.Text = "Введите ваше имя";
            nameclient.ForeColor = Color.Gray;
            surnameclient.Text = "Введите вашу фамилию";
            surnameclient.ForeColor = Color.Gray;
            regpasswordclient.Text = "Введите пароль";
            regpasswordclient.ForeColor = Color.Gray;
            regpasswordclient.PasswordVisible = false;
            phoneclient.ResetText();
            snilsclient.ResetText();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            panelinput.Visible = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Вход";
        }
        private void ButtonRegistration_Click(object sender, EventArgs e)
        {
            if(Methods.Surname(surnameclient) && Methods.Surname(nameclient) && Methods.Snils(snilsclient) && Methods.Phone(phoneclient) && PasswordСorrectness)
            {
                string connection = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connection);
                var database = client.GetDatabase("Terminal");
                var collection = database.GetCollection<Client>("Client");
                string helpsnils = snilsclient.Text.Replace("(", "").Replace(")", "").Replace("-", "");
                string helpphone = phoneclient.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
                Client user = new Client
                {
                    Surname = surnameclient.CurrentText,
                    Name = nameclient.CurrentText,
                    Phone = helpphone,
                    Snils = helpsnils,
                    Password = regpasswordclient.CurrentText,
                };
                var snilfilter = Builders<Client>.Filter.Eq("Snils", helpsnils);
                var people = collection.Find(snilfilter).ToList();
                bool finded = false;
                foreach (var item in people)
                {
                   finded = true;
                }
                if (finded)
                {
                   MessageBox.Show("Данный СНИЛС уже существует в этом приложении <Талончик>");
                }
                else
                {
                   MessageBox.Show("Вы зарегистрированы в приложении <Талончик>");
                   collection.InsertOne(user);
                }
            }
            else
            {
                if (!Methods.Surname(surnameclient) && !Methods.Surname(nameclient) && !Methods.Snils(snilsclient) && !Methods.Phone(phoneclient) && !PasswordСorrectness) MessageBox.Show("Запоните все поля");
                if ((Methods.Surname(surnameclient) && Methods.Surname(nameclient) && !(Methods.Snils(snilsclient)) && Methods.Phone(phoneclient) && PasswordСorrectness)) MessageBox.Show("Проверьте введенный СНИЛС");
                if ((Methods.Surname(surnameclient) && Methods.Surname(nameclient) && Methods.Snils(snilsclient) && !(Methods.Phone(phoneclient)) && PasswordСorrectness)) MessageBox.Show("Проверьте введенный телефонный номер");
                if ((Methods.Surname(surnameclient) && Methods.Surname(nameclient) && Methods.Snils(snilsclient) && Methods.Phone(phoneclient) && !(PasswordСorrectness))) MessageBox.Show("Используйте цифры, большой и низкий регистор, спец. символы , чтобы сделать пароль сложнее.");
            }
        }
        public void CHek(object sender, EventArgs e)
        {
            helppassword.Visible = true;
            bool A = Regex.IsMatch(regpasswordclient.CurrentText, @"(?=\d)");
            bool B = Regex.IsMatch(regpasswordclient.CurrentText, @"(?=([-+_@.\\,/*%!;:?<>$&^~`]))");
            bool i = Regex.IsMatch(regpasswordclient.CurrentText, @"(?=.*[A-Z])");
            bool p = Regex.IsMatch(regpasswordclient.CurrentText, @"(?=.*[a-z])");
            bool I = Regex.IsMatch(regpasswordclient.CurrentText, @"(?=.*[А-Я])");
            bool P = Regex.IsMatch(regpasswordclient.CurrentText, @"(?=.*[а-я])");
            if (regpasswordclient.CurrentText != "Введите пароль" && regpasswordclient.CurrentText != "")
            {
                regpasswordclient.CurrentText = regpasswordclient.CurrentText.Replace(" ", "");
                
                if ((A == true || i == true || p == true)) { levelofdifficulty.Value = 10; PasswordСorrectness = false; }
                if (A == true || I == true || P == true) { levelofdifficulty.Value = 10; PasswordСorrectness = false; }
                if (regpasswordclient.CurrentText.Length > 11) if (B == true && A == true) { levelofdifficulty.Value = 20; PasswordСorrectness = true; }
                if (regpasswordclient.CurrentText.Length >= 8)
                {

                    if (B == true || A == true)
                    {
                        if (i == true || p == true) { levelofdifficulty.Value = 20; PasswordСorrectness = true; }
                        if (I == true || P == true) { levelofdifficulty.Value = 20; PasswordСorrectness = true;}
                    }
                    else
                    {
                        if (i == true && p == true) { levelofdifficulty.Value = 20; PasswordСorrectness = true; }
                        if (I == true && P == true) { levelofdifficulty.Value = 20; PasswordСorrectness = true;
                        }
                    }
                }
                if (regpasswordclient.CurrentText.Length > 5)
                {
                    if (A == true && B == true)
                    {
                        if (i == true || I == true)
                        {
                            PasswordСorrectness = true;
                            levelofdifficulty.Value = 30;
                        }
                        else
                        {
                            if (p == true || P == true) { levelofdifficulty.Value = 30; PasswordСorrectness = true; }
                        }
                    }
                    if (A == true || B == true)
                    {
                        if (i == true || I == true)
                        {
                            if (p == true || P == true)
                            {
                                PasswordСorrectness = true;
                                levelofdifficulty.Value = 30;
                            }
                        }

                    }
                    if (A == true && B == true) 
                    {
                        if (i == true || I == true)
                        {
                            if (p == true || P == true)
                            {
                                PasswordСorrectness = true;
                                levelofdifficulty.Value = 40;
                            }
                        }
                    }
                }
            }
            else
            {
                levelofdifficulty.Value = 0;
                PasswordСorrectness = false;
                helppassword.Visible = false;
            }

        }
        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (loginclient.CurrentText != "Введите номер телефона или СНИЛС" && passwordclient.CurrentText != "Введите пароль")
                {
                    string connection = "mongodb://localhost:27017";
                    MongoClient client = new MongoClient(connection);
                    var database = client.GetDatabase("Terminal");
                    var collection = database.GetCollection<Client>("Client");
                    var builder = Builders<Client>.Filter;
                    var filter = (builder.Eq("Snils", $"{loginclient.CurrentText}") & builder.Eq("Password", $"{passwordclient.CurrentText}")) | (builder.Eq("Phone", $"{loginclient.CurrentText}") & builder.Eq("Password", $"{passwordclient.CurrentText}"));
                    var people = collection.Find(filter).ToList();
                    bool finded = false;
                    foreach (var p in people)
                    {
                        finded = true;
                        Properties.Settings.Default.Name = p.Name;
                        Properties.Settings.Default.Surname = p.Surname;
                        Properties.Settings.Default.Phone = p.Phone;
                        Properties.Settings.Default.Snils = p.Snils;
                        Properties.Settings.Default.Password = p.Password;
                        Properties.Settings.Default.Save();
                        if (p.Name == "Admin")
                        {
                            FormAdmin admin = new FormAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        loginclient.Clear();
                        passwordclient.Clear();
                    }
                    if (finded == false)
                    {
                        MessageBox.Show($"Призошла ошибка");
                    }
                }
                else MessageBox.Show("Введите номер телефона (СНИЛС) и ваш пароль ");
            }
            catch(System.TimeoutException ex ) { MessageBox.Show("Проблемы с подключение к БД"); }
            catch(MongoDB.Driver.MongoNodeIsRecoveringException ex) { MessageBox.Show("Проблемы с подключение к БД"); }
        }
        private void Assistant_Click_1(object sender, EventArgs e)
        {
            if (!assistanthelp)
            {
                panelassisant.Visible = true;
                label1.Text = "Помощник №1";
                tabControl1.SelectedIndex = 0;
                assistanthelp = true;
            }
            else
            {
                label1.Text = "Вход";
                panelassisant.Visible = false;
                assistanthelp = false;
            }
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        label3.Text = "Приложение предназначено и создано для упрощения вашей жизни, а именно в сфере здравоохранения. Это приложение поможет записаться на прием к врачу (доктору).";
                    }
                    break;
                case 1:
                    {
                        label2.Text = "1.   Нажмите на Еще не зарегистрированы?\n"+
                                      "2.   Откроется окно Регистрации\n" +
                                      "3.   Заполните пустые поля и нажмите на кнопку зарегистрироваться\n" +
                                      "4.   Нажмите на кнопку назад и заполните пустые поля, чтобы войти в приложение\n";
                    }
                    break;
                case 2:
                    {
                        label4.Text = ":)\n Это приложение является курсовой работой студента группы 215 КСК. \n:)";
                    }
                    break;
            }
        }
    }
}

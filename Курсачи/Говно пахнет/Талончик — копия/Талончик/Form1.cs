using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Талончик
{
    public partial class Form1 : Form
    {
        private bool assistanthelp;
        bool PasswordСorrectness;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            passwordclient.TextChangedB += checkBox1_CheckedChanged;
            regpasswordclient.TextChangedB += checkBox2_CheckedChanged;
            //regcheckpassword.CheckedChanged += Checkregpassword_CheckedChanged;
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
        }
        public void ClearPanel(object sender, EventArgs e)
        {
            surnameclient.Clear();
            nameclient.Clear();
            regpasswordclient.Clear();
            buttonregistration.Focus();
        }
        //public void LoginEnterLeave(object sender, EventArgs e)
        //{
        //    switch (loginclient.Text)
        //    {
        //        case "Введите номер телефона или СНИЛС":
        //            {
        //                loginclient.Text = "";
        //                loginclient.ForeColor = Color.Black;
        //            }
        //            break;
        //        case "":
        //            {
        //                loginclient.Text = "Введите номер телефона или СНИЛС";
        //                loginclient.ForeColor = Color.Gray;
        //            }
        //             break;
        //    }
        //}
        //public void PasswordEnterLeave(object sender, EventArgs e)
        //{
        //    TextBox text = sender as TextBox;
        //    switch (text.Text)
        //    {
        //        case "Введите пароль":
        //            {
        //                text.UseSystemPasswordChar = true;
        //                checkpassword.Checked = false;
        //                regcheckpassword.Checked = false;
        //                text.Text = "";
        //                text.ForeColor = Color.Black;
        //            }
        //            break;
        //        case "":
        //            {
        //                text.UseSystemPasswordChar = false;
        //                text.Text = "Введите пароль";
        //                text.ForeColor = Color.Gray;
        //            }
        //            break;
        //    }
        //}
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
        //public void SurnameEnterLeave(object sender, EventArgs e)
        //{
        //    switch (surnameclient.Text)
        //    {
        //        case "Введите вашу фамилию":
        //            {
        //                surnameclient.Text = "";
        //                surnameclient.ForeColor = Color.Black;
        //            }
        //            break;
        //        case "":
        //            {
        //                surnameclient.Text = "Введите вашу фамилию";
        //                surnameclient.ForeColor = Color.Gray;
        //            }
        //            break;
        //    }
        //}
        //public void NameEnterLeave(object sender, EventArgs e)
        //{
        //    switch (nameclient.Text)
        //    {
        //        case "Введите ваше имя":
        //            {
        //                nameclient.Text = "";
        //                nameclient.ForeColor = Color.Black;
        //            }
        //            break;
        //        case "":
        //            {
        //                nameclient.Text = "Введите ваше имя";
        //                nameclient.ForeColor = Color.Gray;
        //            }
        //            break;
        //    }
        //}
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
        //private void Checkpassword_CheckedChanged(object sender, EventArgs e)
        //{  
        //    if (checkpassword.Checked == true) 
        //    {
        //        //passwordclient.UseSystemPasswordChar = false;
        //    }
        //    else if (passwordclient.Text == "Введите пароль")
        //    {
        //        //passwordclient.UseSystemPasswordChar = false;
        //    }
        //    if (checkpassword.Checked == false && passwordclient.Text != "Введите пароль")
        //    {
        //        //passwordclient.UseSystemPasswordChar = true;
        //    }
        //}
        //private void Checkregpassword_CheckedChanged(object sender, EventArgs e)
        //{
        //    //if (regcheckpassword.Checked == true)
        //    //{
        //    //    regpasswordclient.Pas = false;
        //    //}
        //    //else if (regpasswordclient.Text == "Введите пароль")
        //    //{
        //    //    regpasswordclient.UseSystemPasswordChar = false;
        //    //}
        //    //if (regcheckpassword.Checked == false &&  regpasswordclient.Text != "Введите пароль")
        //    //{
        //    //    regpasswordclient.UseSystemPasswordChar = true;
        //    //}
        //}
        //public void FirstCharToUppe(object sender, KeyPressEventArgs e)
        //{
            //    #region
            //    //TextBox text = sender as TextBox;
            //    //FirstCharToUpper(text);
            //    //AllCharToUpper(text);
            //    //bool A = Regex.IsMatch(text.Text, @"(?=\d)");
            //    //bool S = Regex.IsMatch(text.Text, @"[^A-z]");
            //    ////bool S = Regex.IsMatch(text.Text, @"(?![A-z])");
            //    //bool B = Regex.IsMatch(text.Text, @"(?=([-+_@.\\,/*%!'?;:<>$&^~`""]))");
            //    //if (text.Text != "" )
            //    //{
            //    //    if (text.Text != "Введите вашу фамилию" && text.Text != "Введите ваше имя") text.Text = text.Text.Replace(" ", "");
            //    //    text.SelectionStart = text.Text.Length;
            //    //    if (A == false && S == true && B == false && text.Text.Length > 1)
            //    //    {
            //    //        helpsurname.Text = "";
            //    //        //FirstCharToUpper(text);
            //    //        //AllCharToUpper(text);
            //    //        SurnameСorrectness = true;
            //    //        NameСorrectness = true;
            //    //    }
            //    //    else
            //    //    {
            //    //        SurnameСorrectness = true;
            //    //        NameСorrectness = false;
            //    //        helpsurname.Text = "Поле не может содержать такие символы";
            //    //    }
            //    //}
            //    #endregion
        //    if ((e.KeyChar >= 'А' && e.KeyChar <= 'Я') || (e.KeyChar >= 'а' && e.KeyChar <= 'я') || e.KeyChar == (char) Keys.Back)
        //    {
        //        SurnameСorrectness = true;
        //        NameСorrectness = true;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}
        //private void KeyPressFirstCharToUpper(object sender, KeyPressEventArgs e)
        //{
        //    //MessageBox.Show("ss");
        //    //TextBox textBox1 = sender as TextBox;
        //    NewTextBox textBox1 = sender as NewTextBox;
        //    string letter = e.KeyChar.ToString();
        //    if (textBox1.CurrentText.Length == 0) letter = letter.ToUpper(); //подменяем первую букву в textBox1.Text на заглавную (если она не заглавная)
        //    if (textBox1.CurrentText.Length != 0) letter = letter.ToLower();//подменяем по ходу ввода остальные буквы на прописные (если они будут вводиться заглавными)
        //    //if (!char.IsLetter(e.KeyChar)) e.Handled = true;         //запрет на ввод не буквенных символов
        //    e.KeyChar = letter[0];
        //}
        //private void KeyPressFirstCharToUpperB(object sender, EventArgs e)
        //{
        //    if ((sender as NewTextBox).CurrentText != (sender as NewTextBox).SaveText)
        //    {
        //        bool A = Regex.IsMatch((sender as NewTextBox).CurrentText, @"^[А-я]+$");
        //        string namestr = (sender as NewTextBox).CurrentText;
        //        char[] c = new char[namestr.Length];
        //        for (int i = 0; i < c.Length; i++)
        //        {
        //            //if (!(Char.IsDigit((sender as NewTextBox).CurrentText, i)))
        //            //{
        //            if (A)
        //            {
        //                if (i == 0) c[i] = Char.ToUpper((sender as NewTextBox).CurrentText[i]);
        //                else c[i] = Char.ToLower((sender as NewTextBox).CurrentText[i]);
        //            }
        //            else (sender as NewTextBox).CurrentText = "";

        //        }
        //        namestr = new string(c);
        //        (sender as NewTextBox).CurrentText = namestr;
        //        (sender as NewTextBox).SelectionStart = (sender as NewTextBox).CurrentText.Length;
        //    }
        //}
        //public void Snils()
        //{
        //    string helpsnils = snilsclient.Text.Replace("(", "").Replace(")", "").Replace("-", "");
        //    if (helpsnils != "" && helpsnils.Length == 11)
        //    {
        //        int c = int.Parse(helpsnils.Substring(9, 2));
        //        string cs = helpsnils.Substring(9, 2);
        //        int totalSum = 0;

        //        helpsnils = helpsnils.Remove(9, 2);
        //        for (int i = helpsnils.Length - 1, j = 0; i >= 0; i--, j++)
        //        {
        //            int digit = int.Parse(helpsnils[i].ToString());
        //            totalSum += digit * (j + 1);
        //        }
        //        if (totalSum < 100)
        //        {
        //            if (c == totalSum)
        //            {
        //                helpsnils += cs;
        //                SnilsСorrectness = true;
        //            }
        //            else SnilsСorrectness = false;
        //        }

        //        else if (totalSum == 100 || totalSum == 101)
        //        {
        //            helpsnils += c;
        //            SnilsСorrectness = true;
        //        }

        //        else if (totalSum > 101)
        //        {
        //            decimal qw = totalSum % 101;
        //            qw = Math.Round(qw, 2);
        //            if (qw == 0)
        //            {
        //                helpsnils += cs;
        //                SnilsСorrectness = true;
        //            }
        //            else if (c == qw)
        //            {
        //                SnilsСorrectness = true;
        //                helpsnils += c;
        //            }
        //            else
        //            {
        //                if (qw == 100 || qw == 101)
        //                {
        //                    SnilsСorrectness = true;
        //                    helpsnils += c;
        //                }
        //                else SnilsСorrectness = false;
        //            }
        //        }
        //        else SnilsСorrectness = false;
        //    }
        //}
        //public void Phone()
        //{
        //    string helpphone = phoneclient.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
        //    if (helpphone != "" && helpphone.Length == 10) PhoneСorrectness = true;
        //    else PhoneСorrectness = false;
        //}
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
                MessageBox.Show($"{Methods.Surname(surnameclient)}  {Methods.Surname(nameclient)} {Methods.Snils(snilsclient)} {Methods.Phone(phoneclient)} {PasswordСorrectness}");
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
                //regpasswordclient.SelectionStart = regpasswordclient.Text.Length;
                if ((A == true || i == true || p == true)) { levelofdifficulty.Value = 10;/*help4.Text = "легкий пароль";*/PasswordСorrectness = false; }
                if (A == true || I == true || P == true) { levelofdifficulty.Value = 10;/*help4.Text = "легкий пароль";*/ PasswordСorrectness = false; }
                if (regpasswordclient.CurrentText.Length > 11) if (B == true && A == true) { levelofdifficulty.Value = 20; /*help4.Text = "Сложность пароля:**";*/PasswordСorrectness = true; }
                if (regpasswordclient.CurrentText.Length >= 8)
                {

                    if (B == true || A == true)
                    {
                        if (i == true || p == true) { levelofdifficulty.Value = 20; /*help4.Text = "Сложность пароля:**";*/ PasswordСorrectness = true; }
                        if (I == true || P == true) { levelofdifficulty.Value = 20; /*help4.Text = "Сложность пароля:**"; */PasswordСorrectness = true;}
                    }
                    else
                    {
                        if (i == true && p == true) { levelofdifficulty.Value = 20;/*help4.Text = "Сложность пароля:**";*/
                            PasswordСorrectness = true; }
                        if (I == true && P == true) { levelofdifficulty.Value = 20;/*help4.Text = "Сложность пароля:**";*/
                            PasswordСorrectness = true;
                        }
                    }
                }
                if (regpasswordclient.CurrentText.Length > 5)
                {
                    if (A == true && B == true)
                    {
                        if (i == true || I == true)
                        {
                            /*if (p == true || P == true)*/
                            /*help4.Text = "Сложность пароля:***";*/
                            PasswordСorrectness = true;
                            levelofdifficulty.Value = 30;
                        }
                        else
                        {
                            if (p == true || P == true) { levelofdifficulty.Value = 30;/*help4.Text = "Сложность пароля:***";*/ PasswordСorrectness = true; }
                        }
                    }
                    if (A == true || B == true)
                    {
                        if (i == true || I == true)
                        {
                            if (p == true || P == true)
                            {
                                /*help4.Text = "Сложность пароля:***";*/ PasswordСorrectness = true;
                                levelofdifficulty.Value = 30;
                            }
                        }

                    }
                    if (A == true && B == true)//(...?) 
                    {
                        if (i == true || I == true)
                        {
                            if (p == true || P == true)
                            {
                                PasswordСorrectness = true;
                                //help4.Text = "Сложность пароля:****";
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
                            //MessageBox.Show("Вы вошли " + p.Name);
                            Form2 form2 = new Form2();
                            form2.Show();
                            this.Hide();
                        }
                        loginclient.Clear();
                        passwordclient.Clear();
                        //loginclient.StandartText = "Введите номер телефона или СНИЛС";
                        //loginclient.ForeColor = Color.Gray;
                        //passwordclient.StandartText = "Введите пароль";
                        //passwordclient.PasswordVisible = false;
                        //passwordclient.ForeColor = Color.Gray;
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
        private void TabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
        {
            Graphics g;
            string sText;
            int iX;
            float iY;

            SizeF sizeText;
            TabControl ctlTab;

            ctlTab = (TabControl)sender;

            g = e.Graphics;

            sText = ctlTab.TabPages[e.Index].Text;
            sizeText = g.MeasureString(sText, ctlTab.Font);
            iX = e.Bounds.Left + 6;
            iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;
            g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY);


            e.Graphics.SetClip(e.Bounds);
            string text = tabControl1.TabPages[e.Index].Text;
            SizeF sz = e.Graphics.MeasureString(text, e.Font);

            bool bSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.Highlight : SystemColors.Control))
                e.Graphics.FillRectangle(b, e.Bounds);

            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.HighlightText : SystemColors.ControlText))
                e.Graphics.DrawString(text, e.Font, b, e.Bounds.X + 2, e.Bounds.Y + (e.Bounds.Height - sz.Height) / 2);

            if (tabControl1.SelectedIndex == e.Index)
                e.DrawFocusRectangle();

            e.Graphics.ResetClip();
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

using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WPFtest.Accounts;

namespace WPFtest.Engine
{
    public class Registration
    {
        public static bool Logincheckreg(TextBox txtboxreg1, System.Windows.Controls.Image img1)
        {
            bool key;
            char[] ch = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            int charch = 0;
            for (int i = 0; i < txtboxreg1.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (txtboxreg1.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }

                }
            }
            if (charch == txtboxreg1.Text.Length && txtboxreg1.Text != "" && txtboxreg1.Text.Length > 4)
            {
                img1.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                img1.ToolTip = null;
                key = true;
            }
            else { img1.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative)); key = false; }
            if (charch != txtboxreg1.Text.Length && txtboxreg1.Text != "")
            {

                img1.ToolTip = "Только латиница[A-z] и цифры[0-9]";
            }
            if (txtboxreg1.Text.Length <= 4)
            {
                img1.ToolTip = "Логин не может быть короче 5 символов";
            }
            if (txtboxreg1.Text == "")
            {
                img1.ToolTip = "Поле не может быть пустым";
            }
            return key;
        }
        public static bool PasscheckReg(PasswordBox txtboxreg2, System.Windows.Controls.Image img2)
        {
            bool key;
            if (txtboxreg2.Password == "")
            {
                img2.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                img2.ToolTip = "Поле не может быть пустым";
                key = false;

            }
            else
            {
                img2.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                img2.ToolTip = null;
                key = true;
            }
            if (txtboxreg2.Password.Length <= 5 && txtboxreg2.Password != "")
            {
                img2.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                img2.ToolTip = "Пароль не может быть короче 6 символов";
                key = false;
            }
            return key;
        }
        public static bool EmailcheckReg(TextBox txtboxreg3, System.Windows.Controls.Image img3)
        {
            bool key;
            if (txtboxreg3.Text.Contains("@mail.ru") || txtboxreg3.Text.Contains("@gmail.com") || txtboxreg3.Text.Contains("@yandex.ru") || txtboxreg3.Text.Contains("@bk.ru") || txtboxreg3.Text.Contains("@rambler.ru") || txtboxreg3.Text.Contains("@list.ru") && txtboxreg3.Text != "")
            {
                img3.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                img3.ToolTip = null;
                key = true;
            }
            else
            {
                if (txtboxreg3.Text == "")
                {
                    img3.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                    img3.ToolTip = "Поле не может быть пустым";
                    key = false;

                }
                else
                {
                    img3.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                    img3.ToolTip = "Некорректная почта";
                    key = false;

                }
            }
            return key;
        }
        public static bool NamecheckReg(TextBox txtboxreg4, System.Windows.Controls.Image img4)
        {
            bool key;
            char[] ch = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            int charch = 0;
            for (int i = 0; i < txtboxreg4.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (txtboxreg4.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }

                }
            }
            if (txtboxreg4.Text == "")
            {
                img4.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                img4.ToolTip = "Поле не может быть пустым";
                key = false;
            }
            else
            {
                if (charch != txtboxreg4.Text.Length && txtboxreg4.Text != "")
                {
                    img4.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                    img4.ToolTip = "Только латиница[A-z] и кириллица[А-я]";
                    key = false;
                }
                else
                {
                    img4.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                    img4.ToolTip = null;
                    key = true;
                }
            }
            return key;
        }
        public static bool AgecheckReg(TextBox txtboxreg5, System.Windows.Controls.Image img5)
        {
            bool key = false;
            char[] ch = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int charch = 0;
            for (int i = 0; i < txtboxreg5.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (txtboxreg5.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }

                }
            }
            if (charch != txtboxreg5.Text.Length && txtboxreg5.Text != "")
            {
                img5.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                img5.ToolTip = "Только цифры[0-9]";
                key = false;
            }
            if (txtboxreg5.Text == "")
            {
                img5.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                img5.ToolTip = "Поле не может быть пустым";
                key = false;
            }
            try
            {
                if (Convert.ToInt32(txtboxreg5.Text) < 18)
                {
                    img5.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                    img5.ToolTip = "Регистрация доступна с 18 лет";
                    key = false;
                }
            }
            catch { }
            if (txtboxreg5.Text != "" && charch == txtboxreg5.Text.Length && txtboxreg5.Text != "" && Convert.ToInt32(txtboxreg5.Text) >= 18)
            {
                img5.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                img5.ToolTip = null;
                key = true;
            }
            return key;
        }
        public static bool GendercheckReg(RadioButton rbgm, RadioButton rbgf)
        {
            bool key;
            if (rbgm.IsChecked == true || rbgf.IsChecked == true)
            {
                key = true;
            }
            else
            {
                key = false;
            }
            return key;
        }
        public static void REGISTRATION(RadioButton rbgm, RadioButton rbgf, TextBox txtboxreg1, PasswordBox txtboxreg2, TextBox txtboxreg3, TextBox txtboxreg4, TextBox txtboxreg5, Grid RegistrationG, Grid Login, TextBox textboxauth1, PasswordBox textboxauth2)
        {
            try
            {
                string gender = "";
                if (rbgm.IsChecked == true)
                {
                    gender = "male";
                    Properties.Settings.Default.genderfind = "female";
                }
                if (rbgf.IsChecked == true)
                {
                    gender = "female";
                    Properties.Settings.Default.genderfind = "male";
                }

                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");

                Bitmap image = new Bitmap(Properties.Resources.noavatar);
                MemoryStream imgtobin = new MemoryStream();
                image.Save(imgtobin, System.Drawing.Imaging.ImageFormat.Png);
                byte[] img = imgtobin.ToArray();

                string namestr = txtboxreg4.Text;
                char[] c = new char[txtboxreg4.Text.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    if (i == 0)
                        c[i] = Char.ToUpper(txtboxreg4.Text[i]);
                    else c[i] = Char.ToLower(txtboxreg4.Text[i]);
                }
                namestr = new string(c);

                List<string> dislike = new List<string>();
                List<string> like = new List<string>();
                Account acc = new Account();
                acc.login = $"{txtboxreg1.Text}";
                acc.password = $"{txtboxreg2.Password}";
                acc.email = $"{txtboxreg3.Text}";
                acc.name = $"{namestr}";
                acc.age = Convert.ToInt32(txtboxreg5.Text);
                acc.gender = $"{gender}";
                acc.photo = img;
                acc.info = "";
                acc.lastonline = DateTime.Now;
                collection.InsertOne(acc);
                MessageBox.Show("Регистрация успешна\n      Теперь войдите");
                RegistrationG.Visibility = Visibility.Collapsed;
                Login.Visibility = Visibility.Visible;
                textboxauth1.Text = txtboxreg1.Text;
                textboxauth2.Password = txtboxreg2.Password;
                txtboxreg1.Clear();
                txtboxreg2.Clear();
                txtboxreg3.Clear();
                txtboxreg4.Clear();
                txtboxreg5.Clear();
                rbgm.IsChecked = false;
                rbgf.IsChecked = false;
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
            catch (MongoDB.Driver.MongoWriteException e1) { MessageBox.Show("Логин занят"); }
        }
       
    }
}

using MongoDB.Driver;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WPFtest.Accounts;

namespace WPFtest.Engine
{
    public class EditProfile
    {
        public static void NameCheckEdit(TextBox txtboxeditname, System.Windows.Controls.Image imgnameedit, Button buttonnameedit)
        {
            char[] ch = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            int charch = 0;

            for (int i = 0; i < txtboxeditname.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (txtboxeditname.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }
                }
            }
            if (txtboxeditname.Text == "")
            {

                imgnameedit.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                imgnameedit.ToolTip = "Поле не может быть пустым";
                buttonnameedit.IsEnabled = false;
            }
            else
            {
                if (charch != txtboxeditname.Text.Length && txtboxeditname.Text != "")
                {
                    imgnameedit.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                    imgnameedit.ToolTip = "Только латиница[A-z] и кириллица[А-я]";
                    buttonnameedit.IsEnabled = false;
                }
                else
                {
                    imgnameedit.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                    imgnameedit.ToolTip = null;
                    buttonnameedit.IsEnabled = true;
                }
            }
        }
        public static void ApplyEditName(TextBox txtboxeditname)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("login", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var accounts =  collection.Find(filter).ToList();
                string namestr = txtboxeditname.Text;
                char[] c = new char[txtboxeditname.Text.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    if (i == 0)
                        c[i] = Char.ToUpper(txtboxeditname.Text[i]);
                    else c[i] = Char.ToLower(txtboxeditname.Text[i]);
                }
                namestr = new string(c);
                foreach(var acc in accounts)
                {
                    var update = Builders<Account>.Update.Set("name", $"{namestr}");
                     collection.UpdateOneAsync(filter, update);
                }
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
        public static void AgeCheckEdit(TextBox txtboxeditage, System.Windows.Controls.Image imgageedit, Button buttonageedit)
        {
            char[] ch = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int charch = 0;
            for (int i = 0; i < txtboxeditage.Text.Length; i++)
            {

                for (int j = 0; j < ch.Length; j++)
                {
                    if (txtboxeditage.Text[i] == ch[j])
                    {
                        charch = charch + 1;
                    }
                }
            }
            if (charch != txtboxeditage.Text.Length && txtboxeditage.Text != "")
            {
                imgageedit.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                imgageedit.ToolTip = "Только цифры[0-9]";
                buttonageedit.IsEnabled = false;
            }
            if (txtboxeditage.Text == "")
            {
                imgageedit.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                imgageedit.ToolTip = "Поле не может быть пустым";
                buttonageedit.IsEnabled = false;
            }
            try
            {
                if (Convert.ToInt32(txtboxeditage.Text) < 18)
                {
                    imgageedit.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                    imgageedit.ToolTip = "Регистрация доступна с 18 лет";
                    buttonageedit.IsEnabled = false;
                }
            }
            catch { }
            if (txtboxeditage.Text != "" && charch == txtboxeditage.Text.Length && txtboxeditage.Text != "" && Convert.ToInt32(txtboxeditage.Text) >= 18)
            {
                imgageedit.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                imgageedit.ToolTip = null;
                buttonageedit.IsEnabled = true;
            }
        }
        public static void ApplyEditAge(TextBox txtboxeditage)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("login", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var accounts = collection.Find(filter).ToList();
                foreach (var acc in accounts)
                {
                    var update = Builders<Account>.Update.Set("age", Convert.ToInt32(txtboxeditage.Text));
                    collection.UpdateOneAsync(filter, update);
                }
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
        public static void ImageEdit(string filepath)
        {

            try
            {
                if (filepath != null)
                {
                    string connectionString = "mongodb://localhost:27017";
                    MongoClient client = new MongoClient(connectionString);
                    var database = client.GetDatabase("оДНОгруппники");
                    var collection = database.GetCollection<Account>("accounts");  
                    var builder = Builders<Account>.Filter;
                    var filter = builder.Eq("login", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                    var accounts = collection.Find(filter).ToList();
                    byte[] array = File.ReadAllBytes($"{filepath}");
                    foreach (var acc in accounts)
                    {
                        var update = Builders<Account>.Update.Set("photo", array);
                        collection.UpdateOneAsync(filter, update);
                    }
                }
                else { MessageBox.Show("Файл не выбран"); }
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
        public static void ApplyEditInfo(TextBox txtboxeditinfo)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("login", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var accounts = collection.Find(filter).ToList();
                foreach (var acc in accounts)
                {
                    var update = Builders<Account>.Update.Set("info", txtboxeditinfo.Text);
                    collection.UpdateOneAsync(filter, update);
                }
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }      
        }
        public static void PassCheckEdit(PasswordBox txtboxeditpassword, System.Windows.Controls.Image imgpasswordedit,Button buttonpasswordedit)
        {

            if (txtboxeditpassword.Password == "")
            {
                imgpasswordedit.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                imgpasswordedit.ToolTip = "Поле не может быть пустым";
                buttonpasswordedit.IsEnabled = false;
            }
            else
            {
                imgpasswordedit.Source = new BitmapImage(new Uri("Resources\\ok.png", UriKind.Relative));
                imgpasswordedit.ToolTip = null;
                buttonpasswordedit.IsEnabled = true;

            }
            if (txtboxeditpassword.Password.Length <= 4 && txtboxeditpassword.Password != "")
            {
                imgpasswordedit.Source = new BitmapImage(new Uri("Resources\\err.png", UriKind.Relative));
                imgpasswordedit.ToolTip = "Пароль не может быть короче 5 символов";
                buttonpasswordedit.IsEnabled = false;
            }
        }
        public static void ApplyEditPassword(PasswordBox txtboxeditpassword)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("login", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var accounts = collection.Find(filter).ToList();
                foreach (var acc in accounts)
                {
                    var update = Builders<Account>.Update.Set("password", txtboxeditpassword.Password);
                    collection.UpdateOneAsync(filter, update);
                    Properties.Settings.Default.Upassword = txtboxeditpassword.Password;
                    Properties.Settings.Default.Save();
                }
            }
            catch { MessageBox.Show("Нет соединение с сервером"); }
        }
    }
}

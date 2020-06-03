using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using WPFtest.Accounts;

namespace WPFtest.Engine
{
    public class LogIN
    {
        public static async void LOGIN(CheckBox remember, TextBox textboxauth1,PasswordBox textboxauth2,Window win)
        {
            try
            {
                if (remember.IsChecked == true)
                {
                    Properties.Settings.Default.Userlogin = textboxauth1.Text;
                    Properties.Settings.Default.Userpassword = textboxauth2.Password;
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
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("login", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var acc = await collection.Find(filter).ToListAsync();
                bool finded = false;
                Properties.Settings.Default.Ulogin = textboxauth1.Text;
                Properties.Settings.Default.Upassword = textboxauth2.Password;
                Properties.Settings.Default.Save();
                foreach (var doc in acc)
                {
                    finded = true;
                    Window1 form2 = new Window1();
                    form2.Show();
                    form2.Closed += openAUTH;
                    win.Hide();
                }
                if (finded == false)
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации"/*, MessageBoxButtons.OK, MessageBoxIcon.Error*/);//PAGEWPF
                }
                //!!!!!!!!APPLICATION
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
        }
        public static void openAUTH(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WPFtest.Accounts;

namespace WPFtest.Engine
{
    public class Couple
    {
        public static async void FindCoupleData(TextBlock labelnameageCF, System.Windows.Controls.Image profileimageCF, Grid SocialGUI, Grid CoupleGUI)
        {
            bool finded = false;
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("_id", Properties.Settings.Default.Ulogin);
                var account = await collection.Find(filter).ToListAsync();
                string profid = null;
                List<string> disname = new List<string>();
                List<string> likename = new List<string>();
                foreach (var doc in account)
                {
                    disname = doc.dislike;
                    likename = doc.like;
                    profid = $"{doc.login}";

                    var buildercople = Builders<Account>.Filter;
                    var filtercouple = buildercople.Ne("_id", profid) & buildercople.Gte("age", Properties.Settings.Default.agemin) & buildercople.Lte("age", Properties.Settings.Default.agemax) & buildercople.Lte("gender", Properties.Settings.Default.genderfind);
                    var couple = await collection.Find(filtercouple).ToListAsync();
                    int count = 0;
                    foreach (var docdc in couple)
                    {
                        count += 1;
                    }
                    bool mainkey = false;
                    var coupleacc = await collection.Find(filtercouple).Limit(1).ToListAsync();

                    int j = 0;
                    j = 0;
                    while (mainkey == false)
                    {
                        foreach (var docc in coupleacc)
                        {
                            if (!disname.Contains($"{docc.login}") && !likename.Contains($"{docc.login}"))
                            {
                                mainkey = true;
                                labelnameageCF.Tag = $"{docc.login}";
                                labelnameageCF.Text = $"{docc.name}, {docc.age}";
                                BsonValue bs = null;
                                byte[] photoimg = null;
                                bs = docc.photo;
                                photoimg = bs.AsByteArray;

                                using (MemoryStream ms = new MemoryStream(photoimg, 0, photoimg.Length))
                                {
                                    Bitmap img = new Bitmap(ms);
                                    profileimageCF.Source = Tools.ConvertIMG(img);
                                }
                                finded = true;
                            }
                            else
                            {
                                coupleacc = await collection.Find(filtercouple).Skip(j).Limit(1).ToListAsync();
                                j = j + 1;
                                finded = false;
                            }
                        }
                        if (count <= 0)
                        { mainkey = true; }
                        count -= 1;
                    }
                }
                if (finded == false)
                { MessageBox.Show("Не найдено анкет с выбранными параметрами"); if (SocialGUI.Visibility == Visibility.Collapsed) { CoupleGUI.Visibility = Visibility.Collapsed; SocialGUI.Visibility = Visibility.Visible; } }
                else
                {
                    SocialGUI.Visibility = Visibility.Collapsed;
                    CoupleGUI.Visibility = Visibility.Visible;
                }
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
            catch (MongoDB.Driver.MongoConnectionException e2) { MessageBox.Show("Соединение с сервером потеряно"); }
            GC.Collect();
        }
        public static async void Dislike(TextBlock labelnameageCF, System.Windows.Controls.Image profileimageCF, Grid SocialGUI, Grid CoupleGUI)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("_id", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var acc = await collection.Find(filter).ToListAsync();
                foreach (var doc in acc)
                {
                    var update = Builders<Account>.Update.Push("dislike", labelnameageCF.Tag);
                    collection.UpdateOne(filter, update);
                    Couple.FindCoupleData(labelnameageCF, profileimageCF, SocialGUI, CoupleGUI);
                }
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
        }
        public static async void Like(TextBlock labelnameageCF, System.Windows.Controls.Image profileimageCF, Grid SocialGUI, Grid CoupleGUI, IPEndPoint ipPoint)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("_id", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var acc = await collection.Find(filter).ToListAsync();
                foreach (var doc in acc)
                {
                    var update = Builders<Account>.Update.Push("like", labelnameageCF.Tag);
                    collection.UpdateOne(filter, update);
                    Couple.FoundedCouple(labelnameageCF,ipPoint);
                    Couple.FindCoupleData(labelnameageCF, profileimageCF, SocialGUI, CoupleGUI);
                }
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
        }
        public static async void FoundedCouple(TextBlock labelnameageCF, IPEndPoint ipPoint)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter1 = builder.Eq("_id", labelnameageCF.Tag);
                var account1 = await collection.Find(filter1).ToListAsync();
                var filter2 = builder.Eq("_id", Properties.Settings.Default.Ulogin);
                var account2 = await collection.Find(filter2).ToListAsync();            
                BsonValue bslike;
                List<string> like = new List<string>();
                string couplename = null;
                foreach (var acc in account1)
                {
                    couplename = $"{acc.name}";
                    like = acc.like;
                }
                if (like.Contains($"{Properties.Settings.Default.Ulogin}"))
                {
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(ipPoint);
                    NetworkStream nws = new NetworkStream(socket);
                    BinaryWriter bw = new BinaryWriter(nws);
                    BinaryReader br = new BinaryReader(nws);
                    bw.Write($"{Properties.Settings.Default.Ulogin}");
                    bw.Write("ntf");
                    bw.Write("ntfnewcouple");
                    bw.Write($"{labelnameageCF.Tag}");
                    foreach (var acc in account2)
                    {
                        bw.Write($"Поздравляем! Вы с пользователем {acc.name} образовали пару.");//сообщение для второго
                    }
                    bw.Write($"Поздравляем! Вы с пользователем {couplename} образовали пару.");//сообщение для нас                   
                    bw.Write($"{DateTime.Now.ToUniversalTime()}");
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
            catch (SocketException e2) { MessageBox.Show("Нет соединение с сервером"); }
        }
        public static async void DeleteCouple(IPEndPoint ipPoint,object sender)
        {

            await Task.Factory.StartNew(async () =>
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    var ch = sender as ChatControl;

                    if (MessageBox.Show($"Вы действительно хотите удалить пользователя {ch.ChatName} из пар", "Удаление из пар", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socket.Connect(ipPoint);
                        NetworkStream nws = new NetworkStream(socket);
                        BinaryWriter bw = new BinaryWriter(nws);
                        BinaryReader br = new BinaryReader(nws);
                        bw.Write($"{Properties.Settings.Default.Ulogin}");
                        bw.Write("deletecouple");
                        bw.Write($"{ch.ChatId}");
                        bw.Write($"{ch.Tag}");
                        bw.Write($"{DateTime.Now.ToUniversalTime()}");
                        socket.Shutdown(SocketShutdown.Both);
                        socket.Close();
                    }
                });
            });
        }
    }
}

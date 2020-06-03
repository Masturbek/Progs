using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using WPFtest.Accounts;

namespace WPFtest.Engine
{
    public class Main
    {  
        public static async void DataLoad(TextBlock labelnameage, TextBlock aboutme, System.Windows.Controls.Image profileimage)
        {
            Window1 win = new Window1();
            win.SocialGUI.Visibility = Visibility.Collapsed;
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("_id", Properties.Settings.Default.Ulogin) & builder.Eq("password", Properties.Settings.Default.Upassword);
                var acc = await collection.Find(filter).ToListAsync();
                List<string> notifystate = new List<string>();
                foreach (var doc in acc)
                {
                    labelnameage.Text = $"{doc.name}, {doc.age}";
                    aboutme.Text = $"{doc.info}";

                    for (int i = 0; i < notifystate.Count; i++)
                    {
                        if (doc.Notifystate[i] == "1")
                        {
                            //ntfk++;//счетчик уведомлений
                        }
                    }
                    byte[] photoimg = doc.photo;

                    using (MemoryStream ms = new MemoryStream(photoimg, 0, photoimg.Length))
                    {
                        Bitmap img = new Bitmap(ms);
                        profileimage.Source = Tools.ConvertIMG(img);
                    }

                }

                GC.Collect();
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
        }
        //public async Task PreMsgDataLoad(ItemsControl PC, ObservableCollection<ChatControl> contmsgP, ConcurrentDictionary<string, ObservableCollection<ChatControl>> container, Socket socketmsg, IPEndPoint ipPoint,ScrollViewer ScrollV)
        //{
        //    string connectionString = "mongodb://localhost:27017";
        //    MongoClient client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("оДНОгруппники");
        //    var collection = database.GetCollection<MSG>("messages");
        //    var builder = Builders<MSG>.Filter;
        //    var filter = builder.Eq("sender", Properties.Settings.Default.Ulogin);
        //    var message = await collection.Find(filter).ToListAsync();



        //    string sender = null;
        //    string idc = null;
        //    foreach (var msg in message)
        //    {

        //        await Task.Factory.StartNew(async () =>
        //        {
        //            await Application.Current.Dispatcher.InvokeAsync(() =>
        //            {
        //                ChatControl ch = new ChatControl();

        //                for (int i = 0; i < msg.sender.Count; i++)
        //                {
        //                    if (msg.sender[i] != Properties.Settings.Default.Ulogin)
        //                    {
        //                        sender = msg.sender[i];
        //                    }
        //                }
        //                //ch.Tag = sender;
        //                var collectionacc = database.GetCollection<Account>("accounts");
        //                var builderacc = Builders<Account>.Filter;
        //                var filteracc = builderacc.Eq("login", sender);
        //                var account = collectionacc.Find(filteracc).ToList();
        //                foreach (var acc in account)
        //                {
        //                    ch.ChatName = acc.name;
        //                    idc = sender;
        //                    byte[] photoimg = acc.photo;
        //                    using (MemoryStream ms = new MemoryStream(photoimg, 0, photoimg.Length))
        //                    {
        //                        Bitmap img = new Bitmap(ms);
        //                        ch.Image = Tools.ConvertIMG(img);
        //                    }

        //                }


        //                //ch.MouseLeftButtonDown += MSGCHANGE;
        //                //ch.ChatClick += Window1.MSGCHANGE;
        //                //ch.DeleteClick += DeleteCouple;
        //                ch.ChatId = msg._id;
        //                if (msg.msg.Count != 0)
        //                {
        //                    ch.Time = msg.date.Last().ToLocalTime().ToShortTimeString();
        //                    ch.Message = msg.msg.Last();
        //                }
        //                else
        //                {
        //                    ch.Time = "";
        //                    ch.Message = "Нет сообщений";
        //                }
        //                ch.Tag = sender;
        //                //ch.Message = msg.msg.Last();
        //                contmsgP.Add(ch);
        //                //msgPP.Add(new KeyValuePair<string, ChatControl>($"{sender}",ch));


        //            });
        //        });
        //        await Task.Factory.StartNew(async () =>
        //        {
        //            await Application.Current.Dispatcher.InvokeAsync(() =>
        //            {
        //                ObservableCollection<ChatControl> contmsgV = new ObservableCollection<ChatControl>();
        //                //var collectionacc = database.GetCollection<Account>("accounts");
        //                //var builderacc = Builders<Account>.Filter;
        //                //var filteracc = builderacc.Eq("login", sender);
        //                //var account = collectionacc.Find(filteracc).ToList();                                       
        //                for (int i = 0; i < msg.msg.Count; i++)
        //                {
        //                    ChatControl chm = new ChatControl();
        //                    chm.Note = Visibility.Collapsed;
        //                    var collectionacc = database.GetCollection<Account>("accounts");
        //                    var builderacc = Builders<Account>.Filter;
        //                    var filteracc = builderacc.Eq("login", msg.author[i]);
        //                    var account = collectionacc.Find(filteracc).ToList();
        //                    foreach (var acc in account)
        //                    {
        //                        //idc = acc.login;
        //                        chm.ChatName = acc.name;
        //                        chm.Message = msg.msg[i];
        //                        chm.Time = msg.date[i].ToLocalTime().ToShortTimeString();
        //                        byte[] photoimg = acc.photo;
        //                        using (MemoryStream ms = new MemoryStream(photoimg, 0, photoimg.Length))
        //                        {
        //                            Bitmap img = new Bitmap(ms);
        //                            chm.Image = Tools.ConvertIMG(img);
        //                        }
        //                    }
        //                    contmsgV.Add(chm);
        //                }
        //                container.TryAdd($"{idc}", contmsgV);
        //            });
        //        });

        //    }
        //    //container.TryAdd("msgP", contmsgP);
        //    //PC.ItemsSource = container["msgP"];


        //    PC.ItemsSource = contmsgP;


        //    socketmsg.Connect(ipPoint);
        //    NetworkStream nwsmsgc = new NetworkStream(socketmsg);
        //    BinaryWriter bwmsgc = new BinaryWriter(nwsmsgc);
        //    BinaryReader brmsgc = new BinaryReader(nwsmsgc);
        //    bwmsgc.Write($"{Properties.Settings.Default.Ulogin}%");

        //    await Task.Factory.StartNew(async () =>
        //    {

        //        //NetworkStream nws = new NetworkStream(socketmsg);
        //        //BinaryWriter bw = new BinaryWriter(nws);
        //        //BinaryReader br = new BinaryReader(nws);
        //        //try
        //        //{
        //        while (true)
        //        {
        //            string mod = "";
        //            mod = brmsgc.ReadString();
        //            switch (mod)
        //            {
        //                case "msg":
        //                    {

        //                        string id = brmsgc.ReadString();
        //                        string mesg = brmsgc.ReadString();
        //                        DateTime time = DateTime.Parse(brmsgc.ReadString());
        //                        string name = brmsgc.ReadString();
        //                        int photolenght = brmsgc.ReadInt32();
        //                        byte[] photo = brmsgc.ReadBytes(photolenght);

        //                        await Task.Factory.StartNew(async () =>
        //                        {
        //                            await Application.Current.Dispatcher.InvokeAsync(() =>
        //                            {
        //                                try { addmsg(id, mesg, time, name, photo,container,ScrollV, contmsgP); }
        //                                catch (Exception ex) { MessageBox.Show($"{ex}"); }
        //                                //addmsg(id, mesg, time, name, photo);

        //                            });
        //                        });
        //                    }
        //                    break;
        //                case "ntf":
        //                    {

        //                        await Task.Factory.StartNew(async () =>
        //                        {

        //                            //socketntf.Connect(ipPoint);
        //                            //NetworkStream nws = new NetworkStream(socketntf);
        //                            //BinaryWriter bw = new BinaryWriter(nws);
        //                            //BinaryReader br = new BinaryReader(nws);
        //                            //bw.Write($"{Properties.Settings.Default.Ulogin}!");
        //                            try
        //                            {


        //                                //string id = br.ReadString();
        //                                string mesg = brmsgc.ReadString();
        //                                DateTime date = DateTime.Parse(brmsgc.ReadString());


        //                                await Task.Factory.StartNew(async () =>
        //                                {
        //                                    await Application.Current.Dispatcher.InvokeAsync(() =>
        //                                    {
        //                                        //addntf(mesg, date);
        //                                    });
        //                                });




        //                            }
        //                            catch (Exception ex) { MessageBox.Show($"{ex}"); }

        //                        });

        //                    }
        //                    break;
        //                case "newmsgP":
        //                    {

        //                        ObjectId chatid = new ObjectId(brmsgc.ReadString());
        //                        string tag = brmsgc.ReadString();
        //                        string chatname = brmsgc.ReadString();
        //                        int photolenght = brmsgc.ReadInt32();
        //                        byte[] photo = brmsgc.ReadBytes(photolenght);


        //                        await Task.Factory.StartNew(async () =>
        //                        {
        //                            await Application.Current.Dispatcher.InvokeAsync(() =>
        //                            {



        //                                //addmsgP(chatid, tag, chatname, photolenght, photo);


        //                            });
        //                        });


        //                    }
        //                    break;
        //                case "deletecouple":
        //                    {
        //                        string id = brmsgc.ReadString();
        //                        DateTime date = DateTime.Parse(brmsgc.ReadString());
        //                        string mesg = brmsgc.ReadString();

        //                        await Task.Factory.StartNew(async () =>
        //                        {
        //                            await Application.Current.Dispatcher.InvokeAsync(() =>
        //                            {
        //                                //addntf(mesg, date);
        //                            });
        //                        });

        //                        await Task.Factory.StartNew(async () =>
        //                        {
        //                            await Application.Current.Dispatcher.InvokeAsync(() =>
        //                            {
        //                                for (int i = 0; i < contmsgP.Count; i++)
        //                                {
        //                                    if ($"{contmsgP[i].Tag}" == id)
        //                                    {
        //                                        contmsgP.Remove(contmsgP[i]);

        //                                    }

        //                                }

        //                            });
        //                        });

        //                    }
        //                    break;
        //            }


        //            //string id = brmsgc.ReadString();
        //            //string mesg = brmsgc.ReadString();
        //            //DateTime time = DateTime.Parse(brmsgc.ReadString());
        //            //string name = brmsgc.ReadString();
        //            //int photolenght = brmsgc.ReadInt32();
        //            //byte[] photo = brmsgc.ReadBytes(photolenght);

        //            //await Task.Factory.StartNew(async () =>
        //            //{
        //            //  await Application.Current.Dispatcher.InvokeAsync(() =>
        //            //  {
        //            //      try { addmsg(id, mesg, time, name, photo); }
        //            //      catch (Exception ex) { MessageBox.Show($"{ex}"); }
        //            //            //addmsg(id, mesg, time, name, photo);

        //            //  });
        //            //});



        //        }
        //        //}
        //        //catch (Exception ex) { MessageBox.Show($"Соединение с сервером потеряно"); }

        //    });

        //    //Task.Factory.StartNew(async () =>
        //    //{
        //    //    await Application.Current.Dispatcher.InvokeAsync(() =>
        //    //    {
        //    //        
        //    //        }
        //    //    });
        //    //});


        //}
        //public static void MSGChange(string idc, TextBox textmessage, ItemsControl PV, Grid MessagesPreview, Grid Messages, ScrollViewer ScrollV, ConcurrentDictionary<string, ObservableCollection<ChatControl>> container)
        //{
        //    textmessage.Tag = idc;
        //    PV.ItemsSource = container[idc];
        //    MessagesPreview.Visibility = Visibility.Collapsed;
        //    Messages.Visibility = Visibility.Visible;
        //    ScrollV.ScrollToEnd();
        //}
        public static async void NotifyDel(ObservableCollection<NTFControl> notify)
        {
            try
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("оДНОгруппники");
                var collection = database.GetCollection<Account>("accounts");
                var builder = Builders<Account>.Filter;
                var filter = builder.Eq("_id", Properties.Settings.Default.Ulogin);
                var account = await collection.Find(filter).ToListAsync();
                foreach (var acc in account)
                {
                    acc.Notify.Clear();
                    acc.Notifydate.Clear();
                    acc.Notifystate.Clear();
                    var update1 = Builders<Account>.Update.Set("Notify", acc.Notify);
                    var update2 = Builders<Account>.Update.Set("Notifydate", acc.Notifydate);
                    var update3 = Builders<Account>.Update.Set("Notifystate", acc.Notifystate);
                    collection.UpdateOne(filter, update1);
                    collection.UpdateOne(filter, update2);
                    collection.UpdateOne(filter, update3);
                }
                notify.Clear();
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
        }
        //public void addmsg(string id, string mesg, DateTime time, string name, byte[] photo, ConcurrentDictionary<string, ObservableCollection<ChatControl>> container, ScrollViewer ScrollV, ObservableCollection<ChatControl> contmsgP)
        //{
        //    ChatControl ch = new ChatControl();
        //    ch.Message = mesg;
        //    ch.Note = Visibility.Collapsed;
        //    ch.Time = time.ToLocalTime().ToShortTimeString();
        //    ch.ChatName = name;



        //    System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
        //    foreach (byte b1 in photo) memoryStream1.WriteByte(b1);
        //    System.Drawing.Image image1 = System.Drawing.Image.FromStream(memoryStream1);
        //    image1.Save(memoryStream1, System.Drawing.Imaging.ImageFormat.Bmp);
        //    Bitmap img = new Bitmap(memoryStream1);



        //    ch.Image = Tools.ConvertIMG(img);
        //    container[id].Add(ch);
        //    ScrollV.ScrollToEnd();
        //    msgsound.Play();

        //    for (int i = 0; i < contmsgP.Count; i++)
        //    {
        //        if ($"{contmsgP[i].Tag}" == id)
        //            contmsgP[i].Message = mesg;
        //        contmsgP[i].Time = time.ToLocalTime().ToShortTimeString();
        //    }
        //}
    }
}

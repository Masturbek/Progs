using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using WPFtest.Accounts;
using WPFtest.Engine;


namespace WPFtest
{

    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        ConcurrentDictionary<string, ObservableCollection<ChatControl>> container = new ConcurrentDictionary<string, ObservableCollection<ChatControl>>();
        ObservableCollection<ChatControl> contmsgP = new ObservableCollection<ChatControl>();
        static int port = 8005; 
        static string address = "127.0.0.1"; 
        static IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);
        static Socket socketmsg = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        ObservableCollection<ChatControl> chatsV = new ObservableCollection<ChatControl>();
        ObservableCollection<NTFControl> notify = new ObservableCollection<NTFControl>();      
        SoundPlayer msgsound = new SoundPlayer(Properties.Resources.msgsound);
        SoundPlayer ntfsound = new SoundPlayer(Properties.Resources.ntfsound);
        public async void WindowLoad(object sender, RoutedEventArgs e)
        {
            await Task.Factory.StartNew(async () =>
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    PreMsgDataLoad();
                });
            });
            await Task.Factory.StartNew(async () =>
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    Main.DataLoad(labelnameage, aboutme, profileimage);
                });
            });
            PV.ItemsSource = chatsV;
            NT.ItemsSource = notify;
            await NtfLoad();

            await Task.Factory.StartNew(async () =>
            {
                await Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    Online.OnlineChecker(ipPoint, textmessage);
                });
            });

        }
       
        public void ProfileEditGUI(object sender, RoutedEventArgs e)
        {
            Window2 win2 = new Window2();
            win2.Closing += win2closed;
            win2.ShowDialog();
        }
        public void win2closed(object sender, EventArgs e)
        {
            Main.DataLoad(labelnameage, aboutme, profileimage);
        }
        public void Options(object sender, RoutedEventArgs e)
        {
            Window3 win3 = new Window3();
            win3.ShowDialog();
        }
        public void MSGGUI(object sender, RoutedEventArgs e)
        {
            SocialGUI.Visibility = Visibility.Collapsed;
            MessagesPreview.Visibility = Visibility.Visible;
        }
        public void BackToSocialGUI(object sender, RoutedEventArgs e)
        {
            MessagesPreview.Visibility = Visibility.Collapsed;
            CoupleGUI.Visibility = Visibility.Collapsed;
            SocialGUI.Visibility = Visibility.Visible;
        }
        public async void BackFromNTF(object sender, RoutedEventArgs e)
        {
            Notify.Visibility = Visibility.Collapsed;
            SocialGUI.Visibility = Visibility.Visible;
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("оДНОгруппники");
            var collection = database.GetCollection<Account>("accounts");
            var builder = Builders<Account>.Filter;
            var filter = builder.Eq("_id", Properties.Settings.Default.Ulogin);
            var accounts = await collection.Find(filter).ToListAsync();
            foreach (var acc in accounts)
            {
                for (int i = 0; i < acc.Notifystate.Count; i++)
                { acc.Notifystate[i] = "0"; }
                var update = Builders<Account>.Update.Set("Notifystate", acc.Notifystate);
                collection.UpdateOne(filter, update);
            }
        }
        public void BackToMessagePreview(object sender, RoutedEventArgs e)
        {
            Messages.Visibility = Visibility.Collapsed;
            MessagesPreview.Visibility = Visibility.Visible;
        }
        public void ButtonCapture(object sender, RoutedEventArgs e)
        {

            optionsimg.ImageSource = new BitmapImage(new Uri("optionsred.png", UriKind.Relative));
        }
        public void ButtonUnCapture(object sender, RoutedEventArgs e)
        {

            optionsimg.ImageSource = new BitmapImage(new Uri("options.png", UriKind.Relative));
        }
        public void FindCople(object sender, RoutedEventArgs e)
        {
            Couple.FindCoupleData(labelnameageCF, profileimageCF,SocialGUI,CoupleGUI);
        }
        public async void NotifyGUI(object sender, RoutedEventArgs e)
        {
            SocialGUI.Visibility = Visibility.Collapsed;
            Notify.Visibility = Visibility.Visible;
        }
        
        private void Disliked(object sender, RoutedEventArgs e)
        {
            Couple.Dislike(labelnameageCF, profileimageCF, SocialGUI, CoupleGUI);
        }
        
        private void Liked(object sender, RoutedEventArgs e)
        {
            Couple.Like(labelnameageCF, profileimageCF, SocialGUI, CoupleGUI, ipPoint);
        }
        
        private void SendMessage(object sender, EventArgs e)
        {
            Chat.SendMessage(textmessage, ipPoint);
        }

        private void NotifyDel(object sender, RoutedEventArgs e)
        {
           Main.NotifyDel(notify);
        }

        public async Task PreMsgDataLoad()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("оДНОгруппники");
            var collection = database.GetCollection<MSG>("messages");
            var builder = Builders<MSG>.Filter;
            var filter = builder.Eq("sender", Properties.Settings.Default.Ulogin);
            var message = await collection.Find(filter).ToListAsync();

            string sender = null;
            string idc = null;
            foreach (var msg in message)
            {
                await Task.Factory.StartNew(async () =>
                 {
                     await Application.Current.Dispatcher.InvokeAsync(() =>
                     {
                         ChatControl ch = new ChatControl();

                         for (int i = 0; i < msg.sender.Count; i++)
                         {
                             if (msg.sender[i] != Properties.Settings.Default.Ulogin)
                             {
                                 sender = msg.sender[i];
                             }
                         }
                         var collectionacc = database.GetCollection<Account>("accounts");
                         var builderacc = Builders<Account>.Filter;
                         var filteracc = builderacc.Eq("login", sender);
                         var account = collectionacc.Find(filteracc).ToList();
                         foreach (var acc in account)
                         {
                             ch.ChatName = acc.name;
                             idc = sender;
                             byte[] photoimg = acc.photo;
                             using (MemoryStream ms = new MemoryStream(photoimg, 0, photoimg.Length))
                             {
                                 Bitmap img = new Bitmap(ms);
                                 ch.Image = Tools.ConvertIMG(img);
                             }

                         }
                         ch.ChatClick += MSGCHANGE;
                         ch.DeleteClick += DeleteCouple;
                         ch.ChatId = msg._id;
                         if (msg.msg.Count != 0)
                         {
                             ch.Time = msg.date.Last().ToLocalTime().ToShortTimeString();
                             ch.Message = msg.msg.Last();
                         }
                         else
                         {
                             ch.Time = "";
                             ch.Message ="Нет сообщений";
                         }
                         ch.Tag = sender;
                             contmsgP.Add(ch);
                     });
                 });
                await Task.Factory.StartNew(async () =>
                {
                    await Application.Current.Dispatcher.InvokeAsync(() =>
                    {
                        ObservableCollection<ChatControl> contmsgV = new ObservableCollection<ChatControl>();                         
                        for (int i = 0; i < msg.msg.Count; i++)
                        {
                            ChatControl chm = new ChatControl();
                            chm.Note = Visibility.Collapsed;
                            var collectionacc = database.GetCollection<Account>("accounts");
                            var builderacc = Builders<Account>.Filter;
                            var filteracc = builderacc.Eq("login", msg.author[i]);
                            var account = collectionacc.Find(filteracc).ToList();
                            foreach (var acc in account)
                            {
                                chm.ChatName = acc.name;
                                chm.Message = msg.msg[i];
                                chm.Time = msg.date[i].ToLocalTime().ToShortTimeString();
                                byte[] photoimg = acc.photo;
                                using (MemoryStream ms = new MemoryStream(photoimg, 0, photoimg.Length))
                                {
                                    Bitmap img = new Bitmap(ms);
                                    chm.Image = Tools.ConvertIMG(img);
                                }
                            }
                            contmsgV.Add(chm);
                        }
                        container.TryAdd($"{idc}", contmsgV);
                    });
                });
            }

            PC.ItemsSource = contmsgP;

            socketmsg.Connect(ipPoint);
            NetworkStream nwsmsgc = new NetworkStream(socketmsg);
            BinaryWriter bwmsgc = new BinaryWriter(nwsmsgc);
            BinaryReader brmsgc = new BinaryReader(nwsmsgc);
            bwmsgc.Write($"{Properties.Settings.Default.Ulogin}%");
       
            await Task.Factory.StartNew(async () =>
              {
                  //try { 
                      while (true)
                      {
                          string mod = "";
                          mod = brmsgc.ReadString();
                          switch (mod)
                          {
                              case "msg" :
                                  {
                                      string id = brmsgc.ReadString();
                                      string mesg = brmsgc.ReadString();
                                      DateTime time = DateTime.Parse(brmsgc.ReadString());
                                      string name = brmsgc.ReadString();
                                      int photolenght = brmsgc.ReadInt32();
                                      byte[] photo = brmsgc.ReadBytes(photolenght);

                                      await Task.Factory.StartNew(async () =>
                                      {
                                          await Application.Current.Dispatcher.InvokeAsync(() =>
                                          {
                                              try { addmsg(id, mesg, time, name, photo); }
                                              catch (Exception ex) { MessageBox.Show($"{ex}"); }
                                          });
                                      });
                                  }
                                  break;
                              case "ntf":
                                  {
                                       await Task.Factory.StartNew(async () =>
                                       {
                                           try
                                           {
                                                   string mesg = brmsgc.ReadString();
                                                   DateTime date = DateTime.Parse(brmsgc.ReadString());

                                                   await Task.Factory.StartNew(async () =>
                                                   {
                                                       await Application.Current.Dispatcher.InvokeAsync(() =>
                                                       {
                                                           addntf(mesg, date);
                                                       });
                                                   });   
                                           }
                                           catch (Exception ex) { MessageBox.Show($"{ex}"); }
                                       });
                                  }
                                  break;
                              case "newmsgP":
                                  {
                                      ObjectId chatid = new ObjectId(brmsgc.ReadString());
                                      string tag = brmsgc.ReadString();
                                      string chatname = brmsgc.ReadString();
                                      int photolenght = brmsgc.ReadInt32();
                                      byte[] photo = brmsgc.ReadBytes(photolenght);

                                      await Task.Factory.StartNew(async () =>
                                      {
                                          await Application.Current.Dispatcher.InvokeAsync(() =>
                                          {
                                              addmsgP(chatid,tag,chatname, photolenght, photo); 
                                          });
                                      });   
                                  }
                                  break;
                                  case "deletecouple": 
                                  {
                                     string id = brmsgc.ReadString();
                                     DateTime date = DateTime.Parse(brmsgc.ReadString());
                                     string mesg = brmsgc.ReadString();

                                     await Task.Factory.StartNew(async () =>
                                     {
                                         await Application.Current.Dispatcher.InvokeAsync(() =>
                                         {
                                             addntf(mesg, date);
                                         });
                                     });

                                    await Task.Factory.StartNew(async () =>
                                    {
                                      await Application.Current.Dispatcher.InvokeAsync(() =>
                                      {
                                          for (int i = 0; i < contmsgP.Count; i++)
                                          {
                                              if ($"{contmsgP[i].Tag}" == id)
                                              {
                                                  if (PV.ItemsSource == container[id])
                                                  {
                                                      Messages.Visibility = Visibility.Collapsed;
                                                      MessagesPreview.Visibility = Visibility.Visible;
                                                  }
                                                  ObservableCollection<ChatControl> rem = container[id];
                                                  container.TryRemove(id,out rem);
                                                  contmsgP.Remove(contmsgP[i]);
                                              }
                                             
                                          }

                                      });
                                    });

                                  }
                                  break;
                              case "onlinecheck":
                                  {
                                      string state = brmsgc.ReadString();
                                     switch(state)
                                      {
                                          case "online":
                                              {

                                              
                                              await Task.Factory.StartNew(async () =>
                                              {
                                                  await Application.Current.Dispatcher.InvokeAsync(() =>
                                                  {
                                                      labelonline.Text = "В сети";
                                                  });
                                              });
                                          }
                                              break;
                                          case "offline":
                                              {

                                             
                                                      DateTime date = DateTime.Parse(brmsgc.ReadString());                                            

                                              await Task.Factory.StartNew(async () =>
                                              {
                                                  await Application.Current.Dispatcher.InvokeAsync(() =>
                                                  {
                                                      //MessageBox.Show($"{date.AddSeconds(40).CompareTo(DateTime.Now)}");
                                                      if (date.ToLocalTime().AddHours(3).CompareTo(DateTime.Now) > 0)                                                   
                                                      {
                                                          labelonline.Text = $"Последний раз в сети: 3 часа назад";
                                                          if (date.ToLocalTime().AddHours(2).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: 2 часа назад";
                                                          if (date.ToLocalTime().AddMinutes(40).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: менее часа назад";
                                                          if (date.ToLocalTime().AddHours(1).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: час назад";
                                                          if (date.ToLocalTime().AddMinutes(30).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: 30 минут назад";
                                                          if (date.ToLocalTime().AddMinutes(15).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: 15 минут назад";
                                                          if (date.ToLocalTime().AddMinutes(10).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: 10 минут назад";
                                                          if (date.ToLocalTime().AddMinutes(5).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: 5 минут назад";
                                                          if (date.ToLocalTime().AddMinutes(3).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: 3 минуты назад";
                                                          if (date.ToLocalTime().AddSeconds(120).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: 2 минуты назад";
                                                          if (date.ToLocalTime().AddSeconds(90).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: минуту назад";
                                                          if (date.ToLocalTime().AddSeconds(59).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: менее минуты назад";
                                                          if (date.ToLocalTime().AddSeconds(10).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: несколько секунд назад";
                                                          if (date.ToLocalTime().AddSeconds(5).CompareTo(DateTime.Now) > 0)
                                                              labelonline.Text = $"Последний раз в сети: только что";
                                                      }
                                                      else 
                                                      { 
                                                          if(date.Day == DateTime.Now.Day & date.Month == DateTime.Now.Month & date.Year == DateTime.Now.Year)
                                                          labelonline.Text = $"Последний раз в сети: сегодня в {date.ToLocalTime().ToShortTimeString()}";
                                                          if (date.ToLocalTime().AddHours(24).CompareTo(DateTime.Now) > 0 & date.Day != DateTime.Now.Day & date.Month == DateTime.Now.Month & date.Year == DateTime.Now.Year)
                                                              labelonline.Text = $"Последний раз в сети: вчера в {date.ToLocalTime().ToShortTimeString()}";
                                                          else { labelonline.Text = $"Последний раз в сети: {date.ToLocalTime().ToLongDateString()} в {date.ToLocalTime().ToShortTimeString()}"; }
                                                      }
                                                     
                                                     
                                                      //if (date.Day != DateTime.Now.Day || date.Month != DateTime.Now.Month || date.Year != DateTime.Now.Year)
                                                      //    labelonline.Text = $"Последний раз в сети: {date.ToLocalTime().ToLongDateString()} в {date.ToLocalTime().ToShortTimeString()}";
                                                      //else labelonline.Text = $"Последний раз в сети в {date.ToLocalTime().ToShortTimeString()}";
                                                  });
                                              });

                                          }
                                              break;
                                      }
                                      
                                  }
                                  break;
                          }
                      }
                  //}
                  //catch (Exception ex) { MessageBox.Show($"Соединение с сервером потеряно"); }

              });

            //Task.Factory.StartNew(async () =>
            //{
            //    await Application.Current.Dispatcher.InvokeAsync(() =>
            //    {
            //        
            //        }
            //    });
            //});

        }
        public void MSGCHANGE(object sender, EventArgs e)
        {
            string idc = $"{(sender as ChatControl).Tag}";
            textmessage.Tag = idc;
            PV.ItemsSource = container[idc];
            MessagesPreview.Visibility = Visibility.Collapsed;
            Messages.Visibility = Visibility.Visible;
            ScrollV.ScrollToEnd();
        }
        public  void addmsg(string id, string mesg, DateTime time, string name, byte[] photo)
        {
            ChatControl ch = new ChatControl();
            ch.Message = mesg;
            ch.Note = Visibility.Collapsed;
            ch.Time = time.ToLocalTime().ToShortTimeString();
            ch.ChatName = name;

            System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
            foreach (byte b1 in photo) memoryStream1.WriteByte(b1);
            System.Drawing.Image image1 = System.Drawing.Image.FromStream(memoryStream1);
            Bitmap img = new Bitmap(memoryStream1);

            ch.Image = Tools.ConvertIMG(img);
            container[id].Add(ch);
            ScrollV.ScrollToEnd();
            msgsound.Play();

            for(int i = 0; i < contmsgP.Count;i++)
            {
                if($"{contmsgP[i].Tag}" == id)
                    contmsgP[i].Message = mesg;
                contmsgP[i].Time = time.ToLocalTime().ToShortTimeString();
            }
        }
        public void addmsgP(ObjectId chatid,string tag,string chatname,int photolenght, byte[] photo)
        {
            ChatControl chP = new ChatControl();

            chP.ChatId = chatid;
            chP.Tag = tag;
            chP.ChatName = chatname;
            chP.ChatClick += MSGCHANGE;
            chP.DeleteClick += DeleteCouple;

            System.IO.MemoryStream memoryStream1 = new System.IO.MemoryStream();
            foreach (byte b1 in photo) memoryStream1.WriteByte(b1);
            System.Drawing.Image image1 = System.Drawing.Image.FromStream(memoryStream1);
            Bitmap img = new Bitmap(memoryStream1);

            chP.Image = Tools.ConvertIMG(img);
            chP.Message = "Нет сообщений";

            contmsgP.Add(chP);
            container.TryAdd(tag,new ObservableCollection<ChatControl>());
        }
        public async Task NtfLoad()
        {
            ObservableCollection<NTFControl> contntf = new ObservableCollection<NTFControl>();
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("оДНОгруппники");
            var collection = database.GetCollection<Account>("accounts");
            var builder = Builders<Account>.Filter;
            var filter = builder.Eq("login", Properties.Settings.Default.Ulogin);
            var accounts = await collection.Find(filter).ToListAsync();
            foreach (var acc in accounts)
            {
                await Task.Factory.StartNew(async () =>
                {
                    await Application.Current.Dispatcher.InvokeAsync(() =>
                    {
                        for (int i = acc.Notify.Count-1; i >= 0;i--)
                        {
                            NTFControl nt = new NTFControl();
                            nt.Notify = acc.Notify[i];
                            nt.Date = acc.Notifydate[i].ToLocalTime().ToLongDateString();
                            notify.Add(nt);
                        }
                    });
                });
            }
            NT.ItemsSource = notify;
        }
        public void addntf(string message, DateTime date)
        {
            NTFControl nt = new NTFControl();
            nt.Notify = message;
            nt.Date = date.ToLocalTime().ToLongDateString();
            notify.Add(nt);
            if (notify.Count > 1)
            { notify.Move(notify.Count - 1, 0); }
            ntfsound.Play();
        }
        public async void DeleteCouple(object sender, EventArgs e)
        {          
            Couple.DeleteCouple(ipPoint,sender);
        }
    }   
}

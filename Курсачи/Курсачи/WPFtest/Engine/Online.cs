using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace WPFtest.Engine
{
    public class Online
    {
        public static  IPEndPoint IP;
        public static TextBox Textmessage;
        public static async Task OnlineChecker(IPEndPoint ipPoint,TextBox textmessage)
        {
               IP = ipPoint;
                Textmessage = textmessage;
                DispatcherTimer onlinetimer = new DispatcherTimer();
                onlinetimer.Interval = new TimeSpan(0, 0, 0, 1);
                onlinetimer.Tick += OnlineCheck;
                onlinetimer.Start();
            
            //IP = ipPoint;
            //Textmessage = textmessage;
            //DispatcherTimer onlinetimer = new DispatcherTimer();
            //onlinetimer.Interval = new TimeSpan(0,0,0,1);
            //onlinetimer.Tick += OnlineCheck;
            //onlinetimer.Start();
            //while (true)
            //{
            //    try
            //    {
            //        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //        socket.Connect(ipPoint);
            //        NetworkStream nws = new NetworkStream(socket);
            //        BinaryWriter bw = new BinaryWriter(nws);
            //        BinaryReader br = new BinaryReader(nws);
            //        bw.Write($"{Properties.Settings.Default.Ulogin}");
            //        bw.Write($"onlinecheck");
            //        bw.Write($"{textmessage.Tag}");
            //        Thread.Sleep(5000);
            //    }
            //    catch (Exception ex) { MessageBox.Show($"{ex}"); }
            //}
        }
        public async static void OnlineCheck(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {

                 Application.Current.Dispatcher.InvokeAsync(() =>
                {
                    if (Textmessage.Focusable)
                    {
                        try
                        {
                            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            socket.Connect(IP);
                            NetworkStream nws = new NetworkStream(socket);
                            BinaryWriter bw = new BinaryWriter(nws);
                            BinaryReader br = new BinaryReader(nws);
                            bw.Write($"{Properties.Settings.Default.Ulogin}");
                            bw.Write($"onlinecheck");
                            bw.Write($"{Textmessage.Tag}");
                            socket.Shutdown(SocketShutdown.Both);
                            socket.Close();

                        }
                        catch { MessageBox.Show($"Потеряно соединение с сервером, попробуйте перезайти"); Thread.Sleep(10000); }
                    }
                });
               
            });
           
        
            
        }
    }
}

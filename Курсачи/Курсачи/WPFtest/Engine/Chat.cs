using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFtest.Engine
{
   public class Chat
    {
        public static void SendMessage(TextBox textmessage, IPEndPoint ipPoint)
        {
            try
            {
                if (textmessage.Text != "")
                {
                    List<string> messagetxt = new List<string>();
                    for (int i = 0; i < textmessage.LineCount; i++)
                    {
                        if (textmessage.GetLineText(i) != "")
                        {
                            //string s = textmessage.Lines[i].Replace("  "," ");
                            string s = Regex.Replace(textmessage.GetLineText(i), " {2,}", " ");
                            s = s.Trim();
                            messagetxt.Add(s);
                        }
                    }
                    //textmessage.Line = messagetxt.ToArray();                  
                    //var id = (sender as Button).Tag;
                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(ipPoint);
                    NetworkStream nws = new NetworkStream(socket);
                    BinaryWriter bw = new BinaryWriter(nws);
                    BinaryReader br = new BinaryReader(nws);
                    bw.Write($"{Properties.Settings.Default.Ulogin}");
                    bw.Write("msg");
                    bw.Write($"{textmessage.Tag}");
                    bw.Write(textmessage.Text);
                    bw.Write($"{DateTime.Now.ToUniversalTime()}");
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();

                   
                    textmessage.Clear();


                }
            }
            catch (System.TimeoutException e1) { MessageBox.Show("Нет соединение с сервером"); }
        }
    }
}

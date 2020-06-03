using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFtest
{
    /// <summary>
    /// Логика взаимодействия для ChatControlP.xaml
    /// </summary>
    public partial class ChatControlP : UserControl
    {
        public ChatControlP()
        {
            InitializeComponent();
        }
        public string ChatName
        {
            get { return (string)GetValue(Nametext); }
            set { SetValue(Nametext, value); }
        }

        public string Message
        {
            get { return (string)GetValue(Messagetext); }
            set { SetValue(Messagetext, value); }
        }

        public string Time
        {
            get { return (string)GetValue(Timetext); }
            set { SetValue(Timetext, value); }
        }

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(img); }
            set { SetValue(img, value); }
        }
        public static readonly DependencyProperty Messagetext =
            DependencyProperty.Register("Message", typeof(string), typeof(ChatControlP));

        public static readonly DependencyProperty Nametext =
          DependencyProperty.Register("ChatName", typeof(string), typeof(ChatControlP));

        public static readonly DependencyProperty Timetext =
        DependencyProperty.Register("Time", typeof(string), typeof(ChatControlP));

        public static readonly DependencyProperty img =
        DependencyProperty.Register("Image", typeof(ImageSource), typeof(ChatControlP));

    }
}

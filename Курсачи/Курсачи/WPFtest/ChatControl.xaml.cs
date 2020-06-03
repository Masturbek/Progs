using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace WPFtest
{
    /// <summary>
    /// Логика взаимодействия для ChatControl.xaml
    /// </summary>
    /// 
    public partial class ChatControl : UserControl
    {
        public event EventHandler ChatClick;
        public event EventHandler DeleteClick;
        public ChatControl()
        {
            InitializeComponent();
        }
        public ObjectId ChatId { get; set; }
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
        //public Visibility Note
        //{
        //    get { return (Visibility)GetValue(Notestate); }
        //    set { SetValue(Notestate, value); }
        //}
        public Visibility Note
        {
            get { return VNote.Visibility; }
            set { VNote.Visibility = value; }
        }

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(img); }
            set { SetValue(img, value); }
        }
        public static readonly DependencyProperty Messagetext =
            DependencyProperty.Register("Message", typeof(string), typeof(ChatControl));

        public static readonly DependencyProperty Nametext =
          DependencyProperty.Register("ChatName", typeof(string), typeof(ChatControl));

        public static readonly DependencyProperty Timetext =
        DependencyProperty.Register("Time", typeof(string), typeof(ChatControl));

        public static readonly DependencyProperty img =
        DependencyProperty.Register("Image", typeof(ImageSource), typeof(ChatControl));

        public static readonly DependencyProperty Notestate =
       DependencyProperty.Register("Note", typeof(Visibility), typeof(ChatControl));
        DispatcherTimer timer = new DispatcherTimer(); 
        private void Note_MouseDown(object sender, RoutedEventArgs e)
        {
            if (NoteMenu.Visibility == Visibility.Collapsed)
            {
                NoteMenu.Visibility = Visibility.Visible;
                //DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = new TimeSpan(0, 0, 0, 3);
                timer.Tick += MenuClose;
                timer.Start();
            }
            else
            {
                if (NoteMenu.Visibility == Visibility.Visible)
                    NoteMenu.Visibility = Visibility.Collapsed;
            }           
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ChatClick != null)
                ChatClick(this, e);
        }
        private void DeleteCouple(object sender, RoutedEventArgs e)
        {
            if (DeleteClick != null)
                DeleteClick(this, e);
        }

        private void NoteMenu_MouseEnter(object sender, MouseEventArgs e)
        {
            var menu = sender as Button;
            menu.Foreground = Brushes.Red;
        }

        private void NoteMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            var menu = sender as Button;
            menu.Foreground = Brushes.Black;
        }

        private void VNote_MouseEnter(object sender, MouseEventArgs e)
        {
            var but = sender as Button;
            //but.Background = new ImageBrush(new BitmapImage(new Uri(@"notred.png", UriKind.Relative)));
            ImageBrush imb = new ImageBrush(new BitmapImage(new Uri(@"notred.png", UriKind.Relative)));
            imb.Stretch = Stretch.Uniform;
            but.Background = imb;
        }

        private void VNote_MouseLeave(object sender, MouseEventArgs e)
        {
            var but = sender as Button;
            //but.Background = new ImageBrush(new BitmapImage(new Uri(@"not.png", UriKind.Relative)));
            ImageBrush imb = new ImageBrush(new BitmapImage(new Uri(@"not.png", UriKind.Relative)));
            imb.Stretch = Stretch.Uniform;
            but.Background = imb;
        }
        public void MenuClose(object sender, EventArgs e)
        {
            var nm = sender as Button;
            NoteMenu.Visibility = Visibility.Collapsed;
            timer.Stop();
        }

        //public event RoutedEventHandler CustomClick;

        //public void MSGClick(object sender, RoutedEventArgs e)
        //{
        //    if (CustomClick != null)
        //        CustomClick(sender, e);
        //}

    }
}

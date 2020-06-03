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
    /// Логика взаимодействия для NTFControl.xaml
    /// </summary>
    public partial class NTFControl : UserControl
    {
        public NTFControl()
        {
            InitializeComponent();
        }

        public string Notify
        {
            get { return (string)GetValue(Notifytext); }
            set { SetValue(Notifytext, value); }
        }
        public string Date
        {
            get { return (string)GetValue(Datetext); }
            set { SetValue(Datetext, value); }
        }
        public static readonly DependencyProperty Notifytext =
          DependencyProperty.Register("Notify", typeof(string), typeof(NTFControl));

        public static readonly DependencyProperty Datetext =
       DependencyProperty.Register("Date", typeof(string), typeof(NTFControl));


    }
}

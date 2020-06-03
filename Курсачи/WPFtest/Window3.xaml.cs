using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using WPFtest.Engine;

namespace WPFtest
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
        public void WindowLoad(object sender, RoutedEventArgs e)
        {
            Settings.Preset(radiolight, radiodark, genderfindmale, genderfindfemale, slidermax, slidermin, valtxtmax, valtxtmin);
        }
        public void Apply(object sender, RoutedEventArgs e)
        {
            Settings.Apply(radiolight, radiodark, genderfindmale, genderfindfemale, slidermax, slidermin);
            this.Close();
        }
        public void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void val(object sender, RoutedEventArgs e)
        {
            try
            {
                valtxtmax.Text = Convert.ToString(Convert.ToInt32(slidermax.Value));
                if (slidermin.Value > slidermax.Value)
                {
                    slidermin.Value = slidermax.Value;
                }

                valtxtmin.Text = Convert.ToString(Convert.ToInt32(slidermin.Value));

            }
            catch { }
        }

        public void HelpEnter(object sender, RoutedEventArgs e)
        {
            help.Background = new ImageBrush(new BitmapImage(new Uri("helpred.png", UriKind.Relative)));
        }
        public void HelpLeave(object sender, RoutedEventArgs e)
        {
            help.Background = new ImageBrush(new BitmapImage(new Uri("help.png", UriKind.Relative)));
        }
        public void Help(object sender, RoutedEventArgs e)
        {
            SettingsGrid.Visibility = Visibility.Collapsed;
            HelpGrid.Visibility = Visibility.Visible;
            TgButton1.IsChecked = true;
        }       
        public void BackToSettings(object sender, RoutedEventArgs e)
        {          
            HelpGrid.Visibility = Visibility.Collapsed;
            SettingsGrid.Visibility = Visibility.Visible;
        }
        public void Help1M(object sender, RoutedEventArgs e)
        {
            Settings.HelpMenuChange(TgButton1, TgButton2, TgButton3, TgButton4, Help1, Help2, Help3, Help4);
        }
        public void Help2M(object sender, RoutedEventArgs e)
        {
            Settings.HelpMenuChange(TgButton2, TgButton1, TgButton3, TgButton4, Help2, Help1, Help3, Help4);
        }
        public void Help3M(object sender, RoutedEventArgs e)
        {
            Settings.HelpMenuChange(TgButton3, TgButton1, TgButton2, TgButton4, Help3, Help1, Help2, Help4);
        }
        public void Help4M(object sender, RoutedEventArgs e)
        {
            Settings.HelpMenuChange(TgButton4, TgButton1, TgButton2, TgButton3, Help4, Help1, Help2, Help3);
        }
    }
}

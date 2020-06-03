using System;
using System.Windows;
using System.Windows.Input;
using WPFtest.Engine;

namespace WPFtest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Main_Loaded(object sender,RoutedEventArgs e)
        {
            Engine.Settings.Theme();
        }

        public void RegistrationGUI(object sender, RoutedEventArgs e)
        {
            Main.Visibility = Visibility.Collapsed;
            RegistrationG.Visibility = Visibility.Visible;
        }
        public void BackToMain(object sender, RoutedEventArgs e)
        {
            Login.Visibility = Visibility.Collapsed;
            RegistrationG.Visibility = Visibility.Collapsed;
            Main.Visibility = Visibility.Visible;
        }
        public void Loging(object sender, RoutedEventArgs e)
        {
           
            Main.Visibility = Visibility.Collapsed;
           Login.Visibility = Visibility.Visible;
            if (Properties.Settings.Default.state == 1)
            {
                textboxauth1.Text = Properties.Settings.Default.Userlogin;
                textboxauth2.Password = Properties.Settings.Default.Userpassword;
                remember.IsChecked = true;
            }
        }
        public void LoginCheckoutRegistration(object sender, RoutedEventArgs e)
        {
            RegistrationAccess();
        }

        public void PasswordCheckoutRegistration(object sender, RoutedEventArgs e)
        {
            RegistrationAccess();
        }
        public void EmailCheckoutRegistration(object sender, RoutedEventArgs e)
        {
            RegistrationAccess();
        }
        public void NameCheckoutRegistration(object sender, RoutedEventArgs e)
        {
            RegistrationAccess();
        }
        public void intsymbol(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
        public void AgeCheckoutRegistration(object sender, RoutedEventArgs e)
        {
            RegistrationAccess();
        }
        public void GenderCheckoutRegistration(object sender, RoutedEventArgs e)
        {
            RegistrationAccess();
        }
        public void RegistrationAccess()
        {
            if (Registration.Logincheckreg(txtboxreg1, img1) == true && Registration.PasscheckReg(txtboxreg2, img2) == true && Registration.EmailcheckReg(txtboxreg3, img3) == true && Registration.NamecheckReg(txtboxreg4, img4) == true && Registration.AgecheckReg(txtboxreg5, img5) == true && Registration.GendercheckReg(rbgm, rbgf) == true)
                ButtonReg.IsEnabled = true;
            else ButtonReg.IsEnabled = false;
        }      
        public void REGISTRATION(object sender, RoutedEventArgs e)
        {     
            Registration.REGISTRATION(rbgm, rbgf, txtboxreg1, txtboxreg2, txtboxreg3, txtboxreg4, txtboxreg5, RegistrationG, Login, textboxauth1, textboxauth2);
        }
        public void LOGIN(object sender, RoutedEventArgs e)
        {
            LogIN.LOGIN(remember, textboxauth1, textboxauth2, this);
        }     
    }
}

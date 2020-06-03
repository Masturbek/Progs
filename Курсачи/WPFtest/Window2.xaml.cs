using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Input;
using WPFtest.Engine;

namespace WPFtest
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        string filepath;
        public void NameEdit(object sender, RoutedEventArgs e)
        {
            EditMain.Visibility = Visibility.Collapsed;
            EditName.Visibility = Visibility.Visible;
        }
        public void AgeEdit(object sender, RoutedEventArgs e)
        {
            EditMain.Visibility = Visibility.Collapsed;
            EditAge.Visibility = Visibility.Visible;        
        }
        public void AvatarEdit(object sender, RoutedEventArgs e)
        {
            EditMain.Visibility = Visibility.Collapsed;
            EditAvatar.Visibility = Visibility.Visible;
            
        }
        public void InfoEdit(object sender, RoutedEventArgs e)
        {
            EditMain.Visibility = Visibility.Collapsed;
            EditAboutMe.Visibility = Visibility.Visible;

        }
        public void PasswordEdit(object sender, RoutedEventArgs e)
        {
            EditMain.Visibility = Visibility.Collapsed;
            EditPassword.Visibility = Visibility.Visible;

        }
        public void backbuttonEDIT(object sender, RoutedEventArgs e)
        {
            txtboxeditname.Clear();
            txtboxeditage.Clear();
            txtboxeditinfo.Clear();
            txtboxeditpassword.Clear();
            EditName.Visibility = Visibility.Collapsed;
            EditAge.Visibility = Visibility.Collapsed;
            EditAvatar.Visibility = Visibility.Collapsed;
            EditAboutMe.Visibility = Visibility.Collapsed;
            EditPassword.Visibility = Visibility.Collapsed;
            EditMain.Visibility = Visibility.Visible;       
        }

        public void NameCheckEdit(object sender, RoutedEventArgs e)
        {
            EditProfile.NameCheckEdit(txtboxeditname, imgnameedit, buttonnameedit);
        }

        public void ApplyEditName(object sender, RoutedEventArgs e)
        {
            EditProfile.ApplyEditName(txtboxeditname);
            this.Close();
        }
       
        public void intsymbol(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
        public void AgeCheckEdit(object sender, RoutedEventArgs e)
        {
      
            EditProfile.AgeCheckEdit(txtboxeditage, imgageedit, buttonageedit);

        }
        public void ApplyEditAge(object sender, RoutedEventArgs e)
        {
            EditProfile.ApplyEditAge(txtboxeditage);
            this.Close();
        }
        public void FilePick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog filepickdialog = new OpenFileDialog();
            filepickdialog.Filter = "Файлы png|*.png|Файлы jpg|*.jpg|Файлы jpeg|*.jpeg";
            if (filepickdialog.ShowDialog() == true)
            {
                filepath = $"{filepickdialog.FileName}";           
            }
        }
        public void ImageEdit(object sender, RoutedEventArgs e)
        {
           EditProfile.ImageEdit(filepath);
            this.Close();
        }

        public void ApplyEditInfo(object sender, RoutedEventArgs e)
        {
            EditProfile.ApplyEditInfo(txtboxeditinfo);
            this.Close();
        }      
        public void PassCheckEdit(object sender, RoutedEventArgs e)
        {
            EditProfile.PassCheckEdit(txtboxeditpassword, imgpasswordedit, buttonpasswordedit);
        }
        public void ApplyEditPassword(object sender, RoutedEventArgs e)
        {
            EditProfile.ApplyEditPassword(txtboxeditpassword);
            this.Close();
        }
    }
}

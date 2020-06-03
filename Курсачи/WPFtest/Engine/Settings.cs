using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPFtest.Engine
{
    public class Settings
    {
        static public void Theme()
        {
            string style = Properties.Settings.Default.theme;
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
        public static void Preset(RadioButton radiolight, RadioButton radiodark, RadioButton genderfindmale, RadioButton genderfindfemale, Slider slidermax, Slider slidermin, TextBlock valtxtmax, TextBlock valtxtmin)
        {
            //if (Properties.Settings.Default.theme == "light")
            //{
            //    radiolight.IsChecked = true;
            //}
            //if (Properties.Settings.Default.theme == "dark")
            //{
            //    radiodark.IsChecked = true;
            //}
            //if (Properties.Settings.Default.genderfind == "male")
            //{
            //    genderfindmale.IsChecked = true;
            //}
            //if (Properties.Settings.Default.genderfind == "female")
            //{
            //    genderfindfemale.IsChecked = true;
            //}
            switch(Properties.Settings.Default.theme)
            {
                case "light": radiolight.IsChecked = true;
                    break;
                case "dark": radiodark.IsChecked = true;
                    break;
            }
            switch (Properties.Settings.Default.genderfind)
            {
                case "male": genderfindmale.IsChecked = true;
                    break;
                case "female": genderfindfemale.IsChecked = true;
                    break;
            }
            slidermax.Value = Properties.Settings.Default.agemax;
            valtxtmax.Text = Convert.ToString(Convert.ToInt32(slidermax.Value));
            slidermin.Value = Properties.Settings.Default.agemin;
            valtxtmin.Text = Convert.ToString(Convert.ToInt32(slidermin.Value));
        }
        public static void Apply(RadioButton radiolight, RadioButton radiodark, RadioButton genderfindmale, RadioButton genderfindfemale,Slider slidermax, Slider slidermin)
        {
            if (radiolight.IsChecked == true)
            {
                Properties.Settings.Default.theme = "light";
                Properties.Settings.Default.Save();
            }
            if (radiodark.IsChecked == true)
            {
                Properties.Settings.Default.theme = "dark";
                Properties.Settings.Default.Save();
            }
            Properties.Settings.Default.agemax = Convert.ToInt32(slidermax.Value);
            Properties.Settings.Default.agemin = Convert.ToInt32(slidermin.Value);
            Properties.Settings.Default.Save();
            if (genderfindmale.IsChecked == true)
            {
                Properties.Settings.Default.genderfind = "male";
            }
            if (genderfindfemale.IsChecked == true)
            {
                Properties.Settings.Default.genderfind = "female";
            }
            Properties.Settings.Default.Save();
            Settings.Theme();
        }
        public static void HelpMenuChange(ToggleButton TgButton1, ToggleButton TgButton2, ToggleButton TgButton3, ToggleButton TgButton4, Grid Help1,Grid Help2, Grid Help3, Grid Help4)
        {
            if (TgButton1.IsChecked == true)
            {
                Help1.Visibility = Visibility.Visible;
                Help2.Visibility = Visibility.Collapsed;
                Help3.Visibility = Visibility.Collapsed;
                Help4.Visibility = Visibility.Collapsed;
                TgButton2.IsChecked = false;
                TgButton3.IsChecked = false;
                TgButton4.IsChecked = false;
            }
            else
            {
                Help1.Visibility = Visibility.Collapsed;
            }

        }
    }
}

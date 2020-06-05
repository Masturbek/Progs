using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Талончик
{
     public class Methods
     {
        public static DateTimePicker dateTimePicker1;
        public static bool Snils(MaskedTextBox snilsclient)
        {
            bool SnilsСorrectness = false;
            string helpsnils = snilsclient.Text.Replace("(", "").Replace(")", "").Replace("-", "");
            if (helpsnils != "" && helpsnils.Length == 11)
            {
                int c = int.Parse(helpsnils.Substring(9, 2));
                string cs = helpsnils.Substring(9, 2);
                int totalSum = 0;

                helpsnils = helpsnils.Remove(9, 2);
                for (int i = helpsnils.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    int digit = int.Parse(helpsnils[i].ToString());
                    totalSum += digit * (j + 1);
                }
                if (totalSum < 100)
                {
                    if (c == totalSum)
                    {
                        helpsnils += cs;
                        return SnilsСorrectness = true;
                    }
                    else return SnilsСorrectness = false;
                }

                else if (totalSum == 100 || totalSum == 101)
                {
                    helpsnils += c;
                    return SnilsСorrectness = true;
                }

                else if (totalSum > 101)
                {
                    decimal qw = totalSum % 101;
                    qw = Math.Round(qw, 2);
                    if (qw == 0)
                    {
                        helpsnils += cs;
                        return SnilsСorrectness = true;
                    }
                    else if (c == qw)
                    {
                        return SnilsСorrectness = true;
                        helpsnils += c;
                    }
                    else
                    {
                        if (qw == 100 || qw == 101)
                        {
                            return SnilsСorrectness = true;
                            helpsnils += c;
                        }
                        else return SnilsСorrectness = false;
                    }
                }
                else return SnilsСorrectness = false;
            }
            return SnilsСorrectness;
        }
        public static bool Surname(NewTextBox textBox)
        {
            if (textBox.CurrentText != textBox.SaveText) return true;
            else return false;
        }
        public static bool Phone(MaskedTextBox phoneclient)
        {
            string helpphone = phoneclient.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (helpphone != "" && helpphone.Length == 10) return true;
            else return false;
        }
        public static string Method(string dayofweek)
        {
            string time_zapisDAY = null;
            switch (dayofweek)
            {

                case "Monday":
                    {
                        time_zapisDAY = "time_zapisMon";
                    }
                    break;
                case "Tuesday":
                    {
                        time_zapisDAY = "time_zapisTue";
                    }
                    break;
                case "Wednesday":
                    {
                        time_zapisDAY = "time_zapisWed";
                    }
                    break;
                case "Thursday":
                    {
                        time_zapisDAY = "time_zapisThu";
                    }
                    break;
                case "Friday":
                    {
                        time_zapisDAY = "time_zapisFri";
                    }
                    break;
                case "Saturday":
                    {
                        time_zapisDAY = "time_zapisSat";
                    }
                    break;
            }
            return time_zapisDAY;
        }
        public static void MethodLAST(string dayofweek, List<string> zapislsit, string zpsday, string NAME, string NAMESPECHIAL, string zapistime)
        {
            
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection2 = database.GetCollection<Doctors>("Doctors");
            var builder2 = Builders<Doctors>.Filter;
            var filter2 = builder2.Eq("name", $"{NAME}") & builder2.Eq("specialty", $"{NAMESPECHIAL}");
            var doctors = collection2.Find(filter2).ToList();
            foreach (var doc in doctors)
            {
                switch (dayofweek)
                {
                    case "Monday":
                        {
                            zapislsit = doc.time_zapisMon;
                            zpsday = "time_zapisMon";
                        }
                        break;
                    case "Tuesday":
                        {
                            zapislsit = doc.time_zapisTue;
                            zpsday = "time_zapisTue";
                        }
                        break;
                    case "Wednesday":
                        {
                            zapislsit = doc.time_zapisWed;
                            zpsday = "time_zapisWed";
                        }
                        break;
                    case "Thursday":
                        {
                            zapislsit = doc.time_zapisThu;
                            zpsday = "time_zapisThu";
                        }
                        break;
                    case "Friday":
                        {
                            zapislsit = doc.time_zapisFri;
                            zpsday = "time_zapisFri";
                        }
                        break;
                    case "Saturday":
                        {
                            zapislsit = doc.time_zapisSat;
                            zpsday = "time_zapisSat";
                        }
                        break;
                }
            }
            zapislsit.Remove(zapistime);
            
            var update = Builders<Doctors>.Update.Set(zpsday, zapislsit);
           
            collection2.UpdateOne(filter2, update);
        }
        public static void KeyPressFirstCharToUpperB(object sender, EventArgs e)
        {
            if ((sender as NewTextBox).CurrentText != (sender as NewTextBox).SaveText)
            {
                bool A = Regex.IsMatch((sender as NewTextBox).CurrentText, @"^[А-я]+$");
                string namestr = (sender as NewTextBox).CurrentText;
                char[] c = new char[namestr.Length];
                for (int i = 0; i < c.Length; i++)
                {
                    if (A)
                    {
                        if (i == 0) c[i] = Char.ToUpper((sender as NewTextBox).CurrentText[i]);
                        else c[i] = Char.ToLower((sender as NewTextBox).CurrentText[i]);
                    }
                    else (sender as NewTextBox).CurrentText = "";

                }
                namestr = new string(c);
                (sender as NewTextBox).CurrentText = namestr;
                (sender as NewTextBox).SelectionStart = (sender as NewTextBox).CurrentText.Length;
            }
        }

        public static void TabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g;
            string sText;
            int iX;
            float iY;

            SizeF sizeText;
            TabControl ctlTab;

            ctlTab = (TabControl)sender;

            g = e.Graphics;

            sText = ctlTab.TabPages[e.Index].Text;
            sizeText = g.MeasureString(sText, ctlTab.Font);
            iX = e.Bounds.Left + 6;
            iY = e.Bounds.Top + (e.Bounds.Height - sizeText.Height) / 2;
            g.DrawString(sText, ctlTab.Font, Brushes.Black, iX, iY);


            e.Graphics.SetClip(e.Bounds);
            string text = (sender as TabControl).TabPages[e.Index].Text;
            SizeF sz = e.Graphics.MeasureString(text, e.Font);

            bool bSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.Highlight : SystemColors.Control))
                e.Graphics.FillRectangle(b, e.Bounds);

            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.HighlightText : SystemColors.ControlText))
                e.Graphics.DrawString(text, e.Font, b, e.Bounds.X + 2, e.Bounds.Y + (e.Bounds.Height - sz.Height) / 2);

            if ((sender as TabControl).SelectedIndex == e.Index)
                e.DrawFocusRectangle();

            e.Graphics.ResetClip();
        }
     }
}

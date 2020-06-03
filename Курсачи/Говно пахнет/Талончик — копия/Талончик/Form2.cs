using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Талончик
{
    public partial class Form2 : Form
    {
        private bool assistanthelp;
        public bool bulka;
        public string textprint;

        public Form2()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[0];
            //Form1 f = new Form1();
            f.Show(); 
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                Fpanel.Location = new Point(14, 15);
                Fpanel.BorderStyle = BorderStyle.FixedSingle;
                Fpanel.AutoScroll = true;
                Fpanel.MaximumSize = new Size(410, 0);
                Fpanel.MinimumSize = new Size(410, 300);

                buttonzapis.Click += (s, a) =>
                {
                    Fpanel.Visible = false;
                    panelassisant.Visible = false;
                    panelzapis.Visible = true;
                };
                dateTimePicker1.MaxDate = DateTime.Now.AddDays(6);
                dateTimePicker1.MinDate = DateTime.Now;
                specialitydoc.SelectedIndexChanged += (s, a) =>
                {
                    if (specialitydoc.SelectedIndex >= 0)
                    {
                    //var n = specialitydoc.SelectedItem.ToString();
                    DoctorNameData(specialitydoc.SelectedItem.ToString());

                    }
                //flowLayoutPanel1.Controls.Clear();
                dayTab1.ClearB();
                };
                namedoc.SelectedIndexChanged += (s, a) =>
                {
                //selectedday.Visible = true;
                dateTimePicker1.Visible = true;
                    dateTimePicker1.Value = DateTime.Now;
                    message.Visible = false;
                    dayTab1.ClearB();
                //selectedday.ResetText();
                };
                dateTimePicker1.ValueChanged += (s, a) =>
                {
                //selectedday.Visible = true;
                //flowLayoutPanel1.Visible = true; 
                Date();
                };
                DataDoctorsSpecialty();
            }
            catch(MongoDB.Driver.MongoConnectionException ex) { MessageBox.Show("Проблемы с подключение к БД"); }
        }
        public void DataDoctorsSpecialty()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection = database.GetCollection<Doctors>("Doctors");
            var builder = Builders<Doctors>.Filter;
            var filter = builder.Ne("specialty", $"{null}");
            var people = collection.Find(filter).ToList();
            foreach (var acc in people)
            {
                if (!specialitydoc.Items.Contains(acc.specialty))
                    specialitydoc.Items.Add(acc.specialty);
            }
        }
        public void DoctorNameData(string Sp)
        {
            dateTimePicker1.Visible = false;
            message.Visible = false;
            namedoc.Items.Clear();
            namedoc.ResetText();// ="";
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection = database.GetCollection<Doctors>("Doctors");
            var builder = Builders<Doctors>.Filter;
            var filter = builder.Eq("specialty", $"{Sp}");
            var people = collection.Find(filter).ToList();
            foreach (var acc in people)
            {
                namedoc.Items.Add(acc.name);
            }
        }
        public void Date()
        {
            var dayofweek = dateTimePicker1.Value.DayOfWeek.ToString();
            var now = DateTime.Now.ToShortDateString();
            string daynow = dateTimePicker1.Value.ToShortDateString();
            if (now == daynow) bulka = true;
            else bulka = false;
            switch (dayofweek)
            {
                case "Monday":
                    {
                        dayTab1.ClearB();
                        dayTab1.SelectedDay = $"Пн,{dateTimePicker1.Value.Day.ToString()}";
                        string weekd1 = "time_Mon";
                        string weekd2 = "time_zapisMon";
                        Doctors doctors = new Doctors();
                        var monn = doctors.time_Mon;
                        string name = "time_zapisMon";
                        ButtonCreateAsync(weekd1, weekd2, monn, name);
                    }
                    break;
                case "Tuesday":
                    {
                        dayTab1.ClearB();
                        dayTab1.SelectedDay = $"Вт,{dateTimePicker1.Value.Day.ToString()}";
                        string weekd1 = "time_Tue";
                        string weekd2 = "time_zapisTue";
                        Doctors doctors = new Doctors();
                        var monn = doctors.time_Tue;
                        string name = "time_zapisTue";
                        ButtonCreateAsync(weekd1, weekd2, monn, name);
                    }
                    break;
                case "Wednesday":
                    {
                        dayTab1.ClearB();
                        dayTab1.SelectedDay = $"Ср,{dateTimePicker1.Value.Day.ToString()}";
                        string weekd1 = "time_Wed";
                        string weekd2 = "time_zapisWed";
                        Doctors doctors = new Doctors();
                        var monn = doctors.time_Wed;
                        string name = "time_zapisWed";
                        ButtonCreateAsync(weekd1, weekd2, monn, name);
                    }
                    break;
                case "Thursday":
                    {
                        dayTab1.ClearB();
                        dayTab1.SelectedDay = $"Чт,{dateTimePicker1.Value.Day.ToString()}";
                        string weekd1 = "time_Thu";
                        string weekd2 = "time_zapisThu";
                        Doctors doctors = new Doctors();
                        var monn = doctors.time_Thu;
                        string name = "time_zapisThu";
                        ButtonCreateAsync(weekd1, weekd2, monn, name);
                    }
                    break;
                case "Friday":
                    {
                        dayTab1.ClearB();
                        //flowLayoutPanel1.Controls.Clear();
                        dayTab1.SelectedDay = $"Пт,{dateTimePicker1.Value.Day.ToString()}";
                        string weekd1 = "time_Fri";
                        string weekd2 = "time_zapisFri";
                        Doctors doctors = new Doctors();
                        var monn = doctors.time_Fri;
                        string name = "time_zapisFri";
                        ButtonCreateAsync(weekd1, weekd2, monn, name);
                    }
                    break;
                case "Saturday":
                    {
                        //flowLayoutPanel1.Controls.Clear();
                        dayTab1.ClearB();
                        dayTab1.SelectedDay = $"Сб,{dateTimePicker1.Value.Day.ToString()}";
                        //selectedday.Text = $"Сб,{dateTimePicker1.Value.Day.ToString()}";
                        string weekd1 = "time_Sat";
                        string weekd2 = "time_zapisSat";
                        Doctors doctors = new Doctors();
                        var monn = doctors.time_Sat;
                        string name = "time_zapisSat";
                        ButtonCreateAsync(weekd1, weekd2, monn, name);
                    }
                    break;
                case "Sunday":
                    {
                        dayTab1.Visible = false;
                        MessageBox.Show("Нерабочий день");
                        message.Visible = true;
                    }
                    break;

            }
        }

        public  void ButtonCreateAsync(string day, string zapisDay, List<string> monn, string name)//await
        {
            new Thread(() =>
            {
                BeginInvoke((MethodInvoker)(() =>
                {
                    string connectionString = "mongodb://localhost:27017";
                    MongoClient client = new MongoClient(connectionString);
                    var database = client.GetDatabase("Terminal");
                    var collection = database.GetCollection<BsonDocument>("Doctors");
                    var collectionzapis = database.GetCollection<Zapis>("Zapis");
                    var builder = Builders<BsonDocument>.Filter;
                    var builderzapis = Builders<Zapis>.Filter;
                    var filter = builder.Eq("name", $"{namedoc.Items[namedoc.SelectedIndex].ToString()}") & builder.Eq("specialty", $"{specialitydoc.Items[specialitydoc.SelectedIndex].ToString()}");
                    var filterzapis = builderzapis.Eq("NameDoctor", $"{namedoc.Items[namedoc.SelectedIndex].ToString()}") & builderzapis.Eq("SpecialityDoctor", $"{specialitydoc.Items[specialitydoc.SelectedIndex].ToString()}") & builderzapis.Eq("ignore", 0);
                    var people = collection.Find(filter).ToList();
                    var zapises = collectionzapis.Find(filterzapis).ToList();
                    BsonValue bsweek;
                    BsonValue bszapis;
                    List<string> zapis = new List<string>();
                    foreach (var acc in people)
                    {
                        bsweek = acc.GetValue(day);
                        bszapis = acc.GetValue(zapisDay);
                        for (int i = 0; i > -1; i++)
                        {
                            try
                            {
                                zapis.Add($"{bszapis[i]}");
                            }
                            catch { i = -2; }
                        }
                        for (int i = 0; i > -1; i++)
                        {
                            try
                            {
                                monn.Add($"{bsweek[i]}");
                                if ($"{bsweek[i]}" == "-")
                                {
                                    dayTab1.Visible = false;
                                    //selectedday.Visible = false;
                                    message.Visible = true;
                                }
                                else
                                {
                                    message.Visible = false;
                                    dayTab1.Visible = true;


                                    //Button saveButton = new Button();
                                    Buttonchik saveButton = new Buttonchik();
                                    saveButton.Name = name;
                                    saveButton.ButtonClick += ZapisDay;
                                    saveButton.TextButton = $"{ monn[i]}";
                                    
                                    //panelzapis.Controls.Add(tab);
                                    //flowLayoutPanel1.Controls.Add(saveButton);
                                    if (zapis.Contains($"{bsweek[i]}"))
                                    {
                                        saveButton.EnableButton = false;
                                    }
                                    if(saveButton.EnableButton == false)
                                    {
                                        foreach (var zap in zapises)
                                        {
                                            if (zap.ZapisTime == saveButton.TextButton)
                                            {
                                                
                                                if (zap.ZapisDate.ToLocalTime().CompareTo(DateTime.Now) < 0)
                                                {
                                                    saveButton.EnableButton = true;
                                                    List<string> timedelete = new List<string>();
                                                    //MessageBox.Show(Methods.Method($"{zap.ZapisDate.DayOfWeek}"));
                                                    string dayzapis = Methods.Method($"{zap.ZapisDate.DayOfWeek}");
                                                   BsonValue val = acc.GetValue(dayzapis);
                                                    for (int f = 0; f > -1; f++)
                                                    {
                                                        try
                                                        {
                                                            timedelete.Add($"{val[f]}");
                                                        }
                                                        catch { f = -2; }
                                                        timedelete.Remove(saveButton.TextButton);
                                                        var up = Builders<BsonDocument>.Update.Set(dayzapis, timedelete);
                                                        collection.UpdateOne(filter, up);
                                                        //saveButton.EnableButton = true;
                                                        var update = Builders<Zapis>.Update.Set("ignore", 1);
                                                        collectionzapis.UpdateOne(filterzapis, update);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    
                                    if (DateTime.Now.Year.CompareTo(dateTimePicker1.Value.Year) == 0 & DateTime.Now.Month.CompareTo(dateTimePicker1.Value.Month) == 0 & DateTime.Now.Day.CompareTo(dateTimePicker1.Value.Day) == 0 & saveButton.TextButton.CompareTo(DateTime.Now.ToShortTimeString()) < 0)
                                    {
                                        //    var now = DateTime.Now.ToShortTimeString();
                                        //    var n = String.Compare(saveButton.TextButton, now);
                                        //    if (n < 0) 
                                        saveButton.EnableButton = false;
                                    }
                                dayTab1.AddB(saveButton);
                                }
                            }
                            catch { i = -2; }
                        }
                    }

                }));

            }).Start();

        }

        public void ZapisDay(object sender, EventArgs e)
        {
            string zapiss = $"{(sender as Buttonchik).TextButton}";
            string time_zapis = $"{(sender as Buttonchik).Name}";
            HELP(zapiss, time_zapis);
        }

        public void HELP(string zapiss, string time_zapis)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collectionzapis = database.GetCollection<Zapis>("Zapis");
            var collectiondoctors = database.GetCollection<Doctors>("Doctors");
            string zapistime = "";
            DateTime zapisdate = new DateTime();
            DialogResult result = MessageBox.Show(
           //$"Хотите записаться на {zapiss}, {Monday}.{date1.ToLongDateString()}.{date1.ToLocalTime().Year} ?",
           $"Хотите записаться на {zapiss}, {dateTimePicker1.Value.Day}.{DateTime.Now.ToString("MM.yyyy")} ?",
           "Сообщение",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Information,
           MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                var builderzapis = Builders<Zapis>.Filter;
                var filterzapis = builderzapis.Eq("Snils", $"{Properties.Settings.Default.Snils}") & builderzapis.Eq("NameDoctor", $"{namedoc.Items[namedoc.SelectedIndex].ToString()}") & builderzapis.Eq("SpecialityDoctor", $"{specialitydoc.Items[specialitydoc.SelectedIndex]}") & builderzapis.Eq("ignore", 0);
                var zps = collectionzapis.Find(filterzapis).ToList();

                if (zps.Count() == 0)
                {

                    var builder = Builders<Doctors>.Filter;
                    var filterdoc = builder.Eq("name", $"{namedoc.Items[namedoc.SelectedIndex].ToString()}") & builder.Eq("specialty", $"{specialitydoc.Items[specialitydoc.SelectedIndex].ToString()}");
                    var people = collectiondoctors.Find(filterdoc).ToList();
                    //List<string> zapis = new List<string>();
                    //MessageBox.Show($"{zapiss}  {time_zapis}");
                    foreach (var doc in people)
                    {
                        var update = Builders<Doctors>.Update.Push(time_zapis, zapiss);
                        collectiondoctors.UpdateOne(filterdoc, update);
                    }
                    Date();
                    //DateTime dt = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day,);
                    Zapis zp = new Zapis
                    {
                        
                        Snils = Properties.Settings.Default.Snils,
                        NameDoctor = $"{namedoc.Items[namedoc.SelectedIndex]}",
                        SpecialityDoctor = $"{specialitydoc.Items[specialitydoc.SelectedIndex]}",
                        ZapisDate = DateTime.Parse($"{dateTimePicker1.Value.Day}.{dateTimePicker1.Value.Month}.{dateTimePicker1.Value.Year} {zapiss}:00"), /*dateTimePicker1.Value,*/
                        ZapisTime = $"{zapiss}",
                    };
                    collectionzapis.InsertOne(zp);
                }
                else
                {
                   DialogResult ress = MessageBox.Show(
                   $"Вы уже записаны к этому врачу.\nХотели бы перезаписаться?",
                   "Сообщение",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1);
                    if (ress == DialogResult.Yes)
                    {
                        var builder = Builders<Zapis>.Filter;
                        var filter = builder.Eq("NameDoctor", $"{namedoc.Items[namedoc.SelectedIndex].ToString()}") & builder.Eq("SpecialityDoctor", $"{specialitydoc.Items[specialitydoc.SelectedIndex].ToString()}") & builder.Eq("Snils", $"{Properties.Settings.Default.Snils}") & builder.Eq("ignore", 0);


                        var bu = Builders<Doctors>.Filter;
                        var filte = bu.Eq("name", $"{namedoc.Items[namedoc.SelectedIndex].ToString()}") & bu.Eq("specialty", $"{specialitydoc.Items[specialitydoc.SelectedIndex].ToString()}");
                        var zapises = collectionzapis.Find(filter).ToList();
                        //MessageBox.Show($"{zapises.Cou}");
                        string zpsday = "";
                        List<string> zapislsit = new List<string>();//0
                        foreach (var zap in zapises)
                        {
                            zapistime = zap.ZapisTime;
                            zapisdate = zap.ZapisDate;
                            var dayofweek = zapisdate.DayOfWeek.ToString();
                            var peopled = collectiondoctors.Find(filte).ToList();
                            Methods.MethodLAST(dayofweek, zapislsit, zpsday, namedoc.Items[namedoc.SelectedIndex].ToString(), specialitydoc.Items[specialitydoc.SelectedIndex].ToString(), zapistime);
                            string dtzp = dateTimePicker1.Value.DayOfWeek.ToString();
                            
                            string dod = "";
                            dod = Methods.Method(dtzp);
                            var UPdate1 = Builders<Doctors>.Update.Push($"{dod}", $"{zapiss}");
                            collectiondoctors.UpdateOne(filte, UPdate1);
                            var update1 = Builders<Zapis>.Update.Set("ZapisTime", $"{zapiss}");
                            var update2 = Builders<Zapis>.Update.Set("ZapisDate", DateTime.Parse($"{dateTimePicker1.Value.Day}.{dateTimePicker1.Value.Month}.{dateTimePicker1.Value.Year} {zapiss}:00"));
                            collectionzapis.UpdateOne(filter, update1);
                            collectionzapis.UpdateOne(filter, update2);
                            Date();
                        
                        }


                    }
                }
            }

        }
        //public string Method(string dayofweek/*string time_zapis,*/)
        //{
        //    string time_zapisDAY = null;
        //    switch (dayofweek)
        //    {

        //        case "Monday":
        //            {
        //                //time_zapis = doc.time_zapisMon;
        //                time_zapisDAY = "time_zapisMon";
        //                //return "time_zapisMon";
        //            }
        //            break;
        //        case "Tuesday":
        //            {
        //                //time_zapis = doc.time_zapisTue;
        //                time_zapisDAY = "time_zapisTue";
        //                //return "time_zapisTue";
        //            }
        //            break;
        //        case "Wednesday":
        //            {
        //                //time_zapis = doc.time_zapisWed;
        //                time_zapisDAY = "time_zapisWed";
        //            }
        //            break;
        //        case "Thursday":
        //            {
        //                //time_zapis = doc.time_zapisThu;
        //                time_zapisDAY = "time_zapisThu";
        //                //return  "doc.time_zapisThu";
        //            }
        //            break;
        //        case "Friday":
        //            {
        //                //time_zapis = doc.time_zapisFri;
        //                time_zapisDAY = "time_zapisFri";
        //                //return "time_zapisFri";
        //            }
        //            break;
        //        case "Saturday":
        //            {
        //                //time_zapis = doc.time_zapisSat;
        //                time_zapisDAY = "time_zapisSat";
        //                //return "time_zapisSat";
        //            }
        //            break;
        //    }
        //    return time_zapisDAY;
        //}
        //public void MethodLAST(string dayofweek, List<string> zapislsit, string zpsday, string NAME, string NAMESPECHIAL, string zapistime)
        //{
        //    MessageBox.Show($"{dayofweek}");
        //    string connectionString = "mongodb://localhost:27017";
        //    MongoClient client = new MongoClient(connectionString);
        //    var database = client.GetDatabase("Terminal");
        //    var collection2 = database.GetCollection<Doctors>("Doctors");
        //    var builder2 = Builders<Doctors>.Filter;
        //    var filter2 = builder2.Eq("name", $"{NAME}") & builder2.Eq("specialty", $"{NAMESPECHIAL}");
        //    var doctors = collection2.Find(filter2).ToList();
        //    foreach (var doc in doctors)
        //    {
        //        switch (dayofweek)
        //        {
        //            case "Monday":
        //                {
        //                    zapislsit = doc.time_zapisMon;
        //                    zpsday = "time_zapisMon";
        //                }
        //                break;
        //            case "Tuesday":
        //                {
        //                    zapislsit = doc.time_zapisTue;
        //                    zpsday = "time_zapisTue";
        //                }
        //                break;
        //            case "Wednesday":
        //                {
        //                    zapislsit = doc.time_zapisWed;
        //                    zpsday = "time_zapisWed";
        //                }
        //                break;
        //            case "Thursday":
        //                {
        //                    zapislsit = doc.time_zapisThu;
        //                    zpsday = "time_zapisThu";
        //                }
        //                break;
        //            case "Friday":
        //                {
        //                    zapislsit = doc.time_zapisFri;
        //                    zpsday = "time_zapisFri";
        //                }
        //                break;
        //            case "Saturday":
        //                {
        //                    zapislsit = doc.time_zapisSat;
        //                    zpsday = "time_zapisSat";
        //                }
        //                break;
        //        }
        //    }
        //    zapislsit.Remove(zapistime);
        //    MessageBox.Show($"{zapistime}");
        //    var update = Builders<Doctors>.Update.Set(zpsday, zapislsit);
        //    MessageBox.Show($"{zpsday}");
        //    collection2.UpdateOne(filter2, update);
        //}
        private void Myzapis_Click(object sender, EventArgs e)
        {
            panelassisant.Visible = false;
            assistant.Visible = false;
            panelzapis.Visible = false;
            Fpanel.Visible = true;
            MyZapis();
        }

        public void MyZapis()
        {
            //string date = DateTime.Now.ToShortTimeString();
            //MessageBox.Show(date);
            Fpanel.Controls.Clear();
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection = database.GetCollection<Zapis>("Zapis");
            var builder = Builders<Zapis>.Filter;
            var filter = builder.Eq("Snils", $"{Properties.Settings.Default.Snils}");
            var zapis = collection.Find(filter).ToList();
            if (zapis.Count() != 0)
            {
                foreach (var zps in zapis)
                {
                    ZapisControl zc = new ZapisControl();
                    zc.Speciality = zps.SpecialityDoctor;
                    zc.Doc = zps.NameDoctor;
                    zc.Day = zps.ZapisDate.ToString("dd.MM.yyyy");
                    zc.Time = zps.ZapisTime;
                    zc.Tag = zps.id;
                    Fpanel.Controls.Add(zc);

                    var n = String.Compare(zc.Time, DateTime.Now.ToShortTimeString());
                    //var d = String.Compare(zps.ZapisDate.ToString("dd.MM.yyyy"), DateTime.Now.ToShortDateString());
                    switch (zps.ZapisDate.CompareTo(DateTime.Now))
                    {
                        case 0:
                            {
                                if (n >= 0) zc.Print += PrintZapis;
                                else zc.PrinterVisible = false;
                            }
                            break;
                        case 1:
                            {
                                zc.Print += PrintZapis;
                            }
                            break;
                        case -1:
                            {
                                zc.PrinterVisible = false;
                            }
                            break;
                    }
                    zc.Delete += DeletZapis;
                }
            }
            else
            {
                Label panelmessage = new Label();
                panelmessage.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
                panelmessage.TextAlign = ContentAlignment.MiddleCenter;
                panelmessage.Size = new Size(400, 290);
                //panelmessage.Location = new Point(130, 110);
                panelmessage.Text = "У вас нет записей";
                //panelmessage.Dock = DockStyle.Fill;
                //panelmessage.BorderStyle = BorderStyle.FixedSingle;
                Fpanel.Controls.Add(panelmessage);
            }
            panel6.Controls.Add(Fpanel);
        }
        public void PrintZapis(object sender, EventArgs e)
        {
           string id =  (sender as ZapisControl).Tag.ToString();
           string connectionString = "mongodb://localhost:27017";
           MongoClient client = new MongoClient(connectionString);
           var database = client.GetDatabase("Terminal");
           var collection1 = database.GetCollection<Zapis>("Zapis");
           var builder1 = Builders<Zapis>.Filter;
           ObjectId ids = new ObjectId(id);
           var filter1 = builder1.Eq("_id", ids);
           var findzps = collection1.Find(filter1).ToList();
           PrintDocument printDocument = new PrintDocument();
           PrintDialog printDialog = new PrintDialog();
           foreach (var zps in findzps)
           {
                textprint = $"Код записи:\n{zps.id}\n\nСпециальность: {zps.SpecialityDoctor}\nВрач: {zps.NameDoctor}\nДата записи: {zps.ZapisDate.ToString("dd.MM.yyyy")}\nВремя записи: {zps.ZapisTime}";
                printDocument.PrintPage += PrintEvent;
                printDialog.Document = printDocument;
           }
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDialog.Document.Print();
        }
        public void PrintEvent(object sender, PrintPageEventArgs e)//обработчик события печати
        {
            e.Graphics.DrawString(textprint, new Font("Arial", 14), Brushes.Black, 0, 600);
        }

        public void DeletZapis(object sender, EventArgs e)
        {
            string id = (sender as ZapisControl).Tag.ToString();
            //DialogResult result = MessageBox.Show(
            //$"Вы точно уверены, что хотите удалить запись ?",
            //"Сообщение",
            //MessageBoxButtons.YesNo,
            //MessageBoxIcon.Information,
            //MessageBoxDefaultButton.Button1);

            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection1 = database.GetCollection<Zapis>("Zapis");
            var builder1 = Builders<Zapis>.Filter;
            ObjectId ids = new ObjectId(id);
            var filter1 = builder1.Eq("_id", ids);
            var findzps = collection1.Find(filter1).ToList();
            string namedoctor = null;
            string namespeciality = null;
            DateTime zapisdate = new DateTime();
            string zapistime = null;
            foreach (var zps in findzps)
            {
                namedoctor = zps.NameDoctor;
                namespeciality = zps.SpecialityDoctor;
                zapisdate = zps.ZapisDate;
                zapistime = zps.ZapisTime;
            }
            string dayofweek = zapisdate.DayOfWeek.ToString();

            List<string> time_zapis = new List<string>();
            string zpsd = null;
            Methods.MethodLAST(dayofweek, time_zapis, zpsd, namedoctor, namespeciality, zapistime);
            collection1.DeleteOne(filter1);
            //panel6.Controls.Clear();
            MyZapis();
            Date();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            //Form1 f = new Form1();
            f.Show();
        }
        private void Assistant_Click_1(object sender, EventArgs e)
        {
            if (!assistanthelp)
            {
                panelassisant.Visible = true;
                //label1.Text = "Помощник №1";
                tabControl1.SelectedIndex = 0;
                assistanthelp = true;
            }
            else
            {
                //label1.Text = "Вход";
                panelassisant.Visible = false;
                assistanthelp = false;
            }
        }
        private void TabControl1_DrawItem_1(object sender, DrawItemEventArgs e)
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
            string text = tabControl1.TabPages[e.Index].Text;
            SizeF sz = e.Graphics.MeasureString(text, e.Font);

            bool bSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.Highlight : SystemColors.Control))
                e.Graphics.FillRectangle(b, e.Bounds);

            using (SolidBrush b = new SolidBrush(bSelected ? SystemColors.HighlightText : SystemColors.ControlText))
                e.Graphics.DrawString(text, e.Font, b, e.Bounds.X + 2, e.Bounds.Y + (e.Bounds.Height - sz.Height) / 2);

            if (tabControl1.SelectedIndex == e.Index)
                e.DrawFocusRectangle();

            e.Graphics.ResetClip();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        label3.Text = "\nКак записаться на прием к врачу?\n"+
                                      "Нужно нажать на кнопку «Записаться»\n" +
                                      "Затем вам нужно будет выбрать: Специальность, Имя врача, Дата и время приёма";
                    }
                    break;
                case 1:
                    {
                        label2.Text = "В данном разделе вы можете проверить наличие вашей записи и историю приёмов."+
                                      " Также можете распечатать талончик на запись или удалить вашу запись.";
                    }
                    break;
            }
        }
    }
}

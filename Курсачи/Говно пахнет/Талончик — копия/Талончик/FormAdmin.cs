using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Талончик
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = Application.OpenForms[0];
            f.Show();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            DataDoctorsSpecialty();
            specialitydoc.SelectedIndexChanged += (s, a) =>
            {
                if (specialitydoc.SelectedIndex >= 0)
                { 
                    DoctorNameData(specialitydoc.SelectedItem.ToString());
                }
            };
            namedoc.SelectedIndexChanged += (s, a) =>
            {
                if (namedoc.SelectedIndex >= 0)
                {
                    var specialty = specialitydoc.SelectedItem.ToString();
                    var name = namedoc.SelectedItem.ToString();
                    MethodSee(specialty, name);
                }
            };
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
            namedoc.Items.Clear();
            namedoc.ResetText();
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
        public void MethodSee(string S, string N)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection = database.GetCollection<Doctors>("Doctors");
            var builder = Builders<Doctors>.Filter;
            var filter = builder.Eq("specialty", $"{S}") & builder.Eq("name", $"{N}");
            var people = collection.Find(filter).ToList();
            foreach (var acc in people)
            {
                Nname.Text = acc.name;
                Sspechial.Text = acc.specialty;
                exp.Value = acc.experience;
                namedoc.Tag = acc._id;
                string[] mon = new string[acc.time_Mon.Count];
                string[] tue = new string[acc.time_Tue.Count];
                string[] wed = new string[acc.time_Wed.Count];
                string[] thu = new string[acc.time_Thu.Count];
                string[] fri = new string[acc.time_Fri.Count];
                string[] sat = new string[acc.time_Sat.Count];

                for (int i = 0; i < acc.time_Mon.Count; i++)
                {
                    mon[i] = acc.time_Mon[i];
                    monday.Lines = mon;
                }
                for (int i = 0; i < acc.time_Tue.Count; i++)
                {
                    tue[i] = acc.time_Tue[i];
                    tueday.Lines = tue;
                }

                for (int i = 0; i < acc.time_Wed.Count; i++)
                {
                    wed[i] = acc.time_Wed[i];
                    wenday.Lines = wed;
                }
                for (int i = 0; i < acc.time_Thu.Count; i++)
                {
                    thu[i] = acc.time_Thu[i];
                    thuday.Lines = thu;

                }
                for (int i = 0; i < acc.time_Fri.Count; i++)
                {
                    fri[i] = acc.time_Fri[i];
                    friday.Lines = fri;
                }
                for (int i = 0; i < acc.time_Sat.Count; i++)
                {
                    sat[i] = acc.time_Sat[i];
                    satday.Lines = sat;
                }
            }
        }
        public void ButtonAdd(object sender, EventArgs e)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection = database.GetCollection<Doctors>("Doctors");
            var builder = Builders<Doctors>.Filter;
            var filter = builder.Eq("specialty", $"{Sspechial.Text}") & builder.Eq("name", $"{Nname.Text}") & builder.Eq("experience", $"{exp.Value}");
            var doc = collection.Find(filter).ToList();
            bool finded = false;
            Doctors doctors = new Doctors();
            foreach (var item in doc)
            {
                finded = true;
            }
            if (!finded)
            {
                doctors.name = Nname.Text;
                doctors.specialty = Sspechial.Text;
                doctors.experience = Convert.ToInt32(exp.Value);
                for (int i = 0; i < monday.Lines.Count(); i++)
                {
                    if (monday.Lines[i] != "")
                        doctors.time_Mon.Add(monday.Lines[i]);
                }
                for (int i = 0; i < tueday.Lines.Count(); i++)
                {
                    if (tueday.Lines[i] != "")
                        doctors.time_Tue.Add(tueday.Lines[i]);
                }
                for (int i = 0; i < wenday.Lines.Count(); i++)
                {
                    if (wenday.Lines[i] != "")
                        doctors.time_Wed.Add(wenday.Lines[i]);
                }
                for (int i = 0; i < thuday.Lines.Count(); i++)
                {
                    if (thuday.Lines[i] != "")
                        doctors.time_Thu.Add(thuday.Lines[i]);
                }
                for (int i = 0; i < friday.Lines.Count(); i++)
                {
                    if (friday.Lines[i] != "")
                        doctors.time_Fri.Add(friday.Lines[i]);
                }
                for (int i = 0; i < satday.Lines.Count(); i++)
                {
                    if (satday.Lines[i] != "")
                        doctors.time_Sat.Add(satday.Lines[i]);
                }
                if (Nname.Text != "" & Sspechial.Text != "")
                {
                    if (monday.Text != "" & tueday.Text != "" & wenday.Text != "" & thuday.Text != "" & friday.Text != "" & satday.Text != "")
                    {
                        collection.InsertOne(doctors);
                        MessageBox.Show(
                        "Добавление прошло успешно!",
                        "Уведомление",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        MethodClose();
                    }
                    DataDoctorsSpecialty(); 
                }
            }
        }
        private void ButtonUpdate(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Уверены в обновлении данных?",
            "Уведомление",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes) 
            { 
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("Terminal");
                var collection = database.GetCollection<Doctors>("Doctors");
                var builder = Builders<Doctors>.Filter;
                var filter = builder.Eq("_id", namedoc.Tag);
                var doc = collection.Find(filter).ToList();
                foreach (var item in doc)
                {
                    item.name = Nname.Text.ToString();
                    item.specialty = Sspechial.Text.ToString();
                    item.experience = Convert.ToInt32(exp.Value);
                    item.time_Mon.Clear();
                    for (int i = 0; i < monday.Lines.Count(); i++)
                    {
                        if (monday.Lines[i] != "")
                            item.time_Mon.Add(monday.Lines[i]);
                    }
                    item.time_Tue.Clear();
                    for (int i = 0; i < tueday.Lines.Count(); i++)
                    {
                        if (tueday.Lines[i] != "")
                            item.time_Tue.Add(tueday.Lines[i]);
                    }
                    item.time_Wed.Clear();
                    for (int i = 0; i < wenday.Lines.Count(); i++)
                    {
                        if (wenday.Lines[i] != "")
                            item.time_Wed.Add(wenday.Lines[i]);
                    }
                    item.time_Thu.Clear();
                    for (int i = 0; i < thuday.Lines.Count(); i++)
                    {
                        if (thuday.Lines[i] != "")
                            item.time_Thu.Add(thuday.Lines[i]);
                    }
                    item.time_Fri.Clear();
                    for (int i = 0; i < friday.Lines.Count(); i++)
                    {
                        if (friday.Lines[i] != "")
                            item.time_Fri.Add(friday.Lines[i]);
                    }
                    item.time_Sat.Clear();
                    for (int i = 0; i < satday.Lines.Count(); i++)
                    {
                        if (satday.Lines[i] != "")
                            item.time_Sat.Add(satday.Lines[i]);
                    }
                    collection.ReplaceOne(filter, item);
                    MessageBox.Show(
                       "Обновление прошло успешно!",
                       "Уведомление",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.None,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                }
                
            }
        }
        public void ButtonRemove(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            $"Уверены в удалении данных?",
            "Уведомление",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                string connectionString = "mongodb://localhost:27017";
                MongoClient client = new MongoClient(connectionString);
                var database = client.GetDatabase("Terminal");
                var collection = database.GetCollection<Doctors>("Doctors");
                var builder = Builders<Doctors>.Filter;
                var filter = builder.Eq("_id", namedoc.Tag);
                try
                {
                    collection.DeleteOne(filter);
                     MessageBox.Show(
                        "Удаление прошло успешно!", 
                        "Уведомление", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.None, 
                        MessageBoxDefaultButton.Button1, 
                        MessageBoxOptions.DefaultDesktopOnly);
                    MethodClose();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Что удалить?");
                }
                DataDoctorsSpecialty();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel5.Visible = true;
            buttonadddata.Visible = false;
            MethodClose();
            DataDoctorsSpecialty();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel5.Visible = false;
            buttonadddata.Visible = true;
            MethodClose();
        }
        private void MethodClose()
        {
            specialitydoc.SelectedIndex = -1;
            specialitydoc.Items.Clear();
            namedoc.SelectedIndex = -1;
            namedoc.Items.Clear();
            Nname.Clear();
            Sspechial.Clear();
            exp.Value = 0;
            monday.Clear();
            tueday.Clear();
            wenday.Clear();
            thuday.Clear();
            friday.Clear();
            satday.Clear();
        }
    }
}

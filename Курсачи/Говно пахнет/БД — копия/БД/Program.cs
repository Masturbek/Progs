using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MongoDB.Driver;
using MongoDB.Bson;

namespace БД
{
    class Program
    {
        static void Data()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            database.DropCollection("Doctors");
            var collection = database.GetCollection<Client>("Client");
            var filter = Builders<Client>.Filter.Eq("Name", "Admin");
            collection.DeleteOne(filter);
            //var people = collection.Find(new BsonDocument()).ToList();
            Client admin = new Client
            {
                Surname = "Admin",
                Name = "Admin",
                Phone = "#03",
                Snils = "#03",
                Password = "Admin",
            };
            collection.InsertOne(admin);
            /*DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\Users\Ильшат\Desktop\Врачи");*/
            DirectoryInfo directoryInfo = new DirectoryInfo(@"Врачи");
            int surgeon = directoryInfo.GetFiles("Хирург\\*.txt", SearchOption.AllDirectories).Length;
            int pediatr = directoryInfo.GetFiles("Педиатр\\*.txt", SearchOption.AllDirectories).Length;
            int lor = directoryInfo.GetFiles("Лор\\*.txt", SearchOption.AllDirectories).Length;
            int oculist = directoryInfo.GetFiles("Окулист\\*.txt", SearchOption.AllDirectories).Length;
            int therapist = directoryInfo.GetFiles("Терапевт\\*.txt", SearchOption.AllDirectories).Length;
            int gynec = directoryInfo.GetFiles("Гинеколог\\*.txt", SearchOption.AllDirectories).Length;
            int psych = directoryInfo.GetFiles("Психолог\\*.txt", SearchOption.AllDirectories).Length;
            //Mmm(surgeon, @"C:\Users\Ильшат\Desktop\Врачи\Хирург");
            //Mmm(pediatr, @"C:\Users\Ильшат\Desktop\Врачи\Педиатр");
            //Mmm(lor, @"C:\Users\Ильшат\Desktop\Врачи\Лор");
            //Mmm(oculist, @"C:\Users\Ильшат\Desktop\Врачи\Окулист");
            //Mmm(therapist, @"C:\Users\Ильшат\Desktop\Врачи\Терапевт");
            //Mmm(gynec, @"C:\Users\Ильшат\Desktop\Врачи\Гинеколог");
            //Mmm(psych, @"C:\Users\Ильшат\Desktop\Врачи\Психолог");
            Mmm(surgeon, @"Врачи\Хирург");
            Mmm(pediatr, @"Врачи\Педиатр");
            Mmm(lor, @"Врачи\Лор");
            Mmm(oculist, @"Врачи\Окулист");
            Mmm(therapist, @"Врачи\Терапевт");
            Mmm(gynec, @"Врачи\Гинеколог");
            Mmm(psych, @"Врачи\Психолог");
        }
        static void Mmm(int x, string path)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            var database = client.GetDatabase("Terminal");
            var collection = database.GetCollection<Doctors>("Doctors");
            for (int i = 1; i <= x; i++)
            {
                string[] lines = File.ReadAllLines($"{path}\\{i}.txt");
                string name = lines[0];
                string speciality = lines[1];
                int experience = int.Parse(lines[2]);
                List<string> time_Mon = new List<string>();
                List<string> time_Tue = new List<string>();
                List<string> time_Wed = new List<string>();
                List<string> time_Thu = new List<string>();
                List<string> time_Fri = new List<string>();
                List<string> time_Sat = new List<string>();
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j] == "[time Mon")
                    {
                        int k = j + 1;
                        while (lines[k] != "time Mon]")
                        {
                            time_Mon.Add(lines[k]);
                            k += 1;
                        }
                    }
                }
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j] == "[time Tue")
                    {
                        int k = j + 1;
                        while (lines[k] != "time Tue]")
                        {
                            time_Tue.Add(lines[k]);
                            k += 1;
                        }
                    }
                }
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j] == "[time Wed")
                    {
                        int k = j + 1;
                        while (lines[k] != "time Wed]")
                        {
                            time_Wed.Add(lines[k]);
                            k += 1;
                        }
                    }
                }
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j] == "[time Thu")
                    {
                        int k = j + 1;
                        while (lines[k] != "time Thu]")
                        {
                            time_Thu.Add(lines[k]);
                            k += 1;
                        }
                    }
                }
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j] == "[time Fri")
                    {
                        int k = j + 1;
                        while (lines[k] != "time Fri]")
                        {
                            time_Fri.Add(lines[k]);
                            k += 1;
                        }
                    }
                }
                for (int j = 0; j < lines.Length; j++)
                {
                    if (lines[j] == "[time Sat")
                    {
                        int k = j + 1;
                        while (lines[k] != "time Sat]")
                        {
                            time_Sat.Add(lines[k]);
                            k += 1;
                        }
                    }
                }
                Doctors doc = new Doctors
                {
                    name = name,
                    specialty = speciality,
                    experience = experience,
                    time_Mon = time_Mon,
                    time_Tue = time_Tue,
                    time_Wed = time_Wed,
                    time_Thu = time_Thu,
                    time_Fri = time_Fri,
                    time_Sat = time_Sat
                };
                collection.InsertOne(doc);
            }

        }
        static void Main(string[] args)
        {
            Data();
        }

    }

}

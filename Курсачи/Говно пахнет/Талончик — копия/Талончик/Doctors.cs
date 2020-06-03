using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Талончик
{
    public class Doctors
    {
        public ObjectId _id;
        public string name;
        public string specialty;
        public int experience;
        public List<string> time_Mon = new List<string>();
        public List<string> time_Tue = new List<string>();
        public List<string> time_Wed = new List<string>();
        public List<string> time_Thu = new List<string>();
        public List<string> time_Fri = new List<string>();
        public List<string> time_Sat = new List<string>();
        public List<string> time_zapisMon = new List<string>();
        public List<string> time_zapisTue = new List<string>();
        public List<string> time_zapisWed = new List<string>();
        public List<string> time_zapisThu = new List<string>();
        public List<string> time_zapisFri = new List<string>();
        public List<string> time_zapisSat = new List<string>();
    }
}

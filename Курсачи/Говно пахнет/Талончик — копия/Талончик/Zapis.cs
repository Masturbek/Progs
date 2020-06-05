using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Талончик
{
    public class Zapis
    {
        public ObjectId id;
        public string Snils;
        public string NameDoctor;
        public string SpecialityDoctor;
        public DateTime ZapisDate;
        public string ZapisTime/*{ get; set; }*/;
        public int ignore;
    }
}

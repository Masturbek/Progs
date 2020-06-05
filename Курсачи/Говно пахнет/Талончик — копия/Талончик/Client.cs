using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Талончик
{
    public class Client
    {
        public ObjectId id;
        public string Surname;
        public string Name;
        public string Phone;
        public string Snils;
        public string Password;
    }
}

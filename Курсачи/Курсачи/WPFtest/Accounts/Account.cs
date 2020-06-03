using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace WPFtest.Accounts
{
   
    
        public class Account
        {
            [BsonId]
            public string login;
            public string password;
            public string email;
            public string name;
            public int age;
            public string gender;
            public byte[] photo;
            public string info;
            public List<string> dislike = new List<string>();
            public List<string> like = new List<string>();
            public List<string> Notify = new List<string>();
            public List<DateTime> Notifydate = new List<DateTime>();
            public List<string> Notifystate = new List<string>();
            public DateTime lastonline;
        }
     
}

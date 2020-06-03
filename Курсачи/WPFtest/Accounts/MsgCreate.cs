using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFtest.Accounts
{
    public class MSG
    {
        public ObjectId _id;
        public List<string> sender = new List<string>();
        public List<DateTime> date = new List<DateTime>();
        public List<string> author = new List<string>();
        public List<string> msg = new List<string>();
    }
}

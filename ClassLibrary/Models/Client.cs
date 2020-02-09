using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Client
    {
        public string LongName { get; set; }
        public int ClientID { get; set; }
        public DateTime DateBirth { get; set; }
        public Boolean IsResident { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();
    }
}

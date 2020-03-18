using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    [Serializable]
    public class Account
    {
        public int Number;
        public string Type;
        public string Balance;
        public DateTime CreationDate;
        public string Sms;
        public string Banking;
        public string Owner;
        public Account(int number, string type, string balance, DateTime creationdate, string sms, string banking, string owner)
        {
            this.Number = number;
            this.Type = type;
            this.Balance = balance;
            this.CreationDate = creationdate;
            this.Sms = sms;
            this.Banking = banking;
            this.Owner = owner;
        }
        public Account() { }
        public override string ToString()
        {
            return $"Номер счета: {Number}";
        }
    }
}

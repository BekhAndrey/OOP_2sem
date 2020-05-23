using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_lab.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Ballance { get; set; }
        public DateTime CreationDate { get; set; }
        public int OwnerId { get; set; }
    }
}

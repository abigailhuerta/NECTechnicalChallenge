using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Entities.ValueObjects
{
    public class Status
    {
        public DateTime Timestamp { get; set; }
        public int Error_Code { get; set; }
        public string Error_Message { get; set; }
        public int Elapsed { get; set; }
        public int Credit_Count { get; set; }
    }
}

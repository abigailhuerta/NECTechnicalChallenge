using NEC.Crypto.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEC.Crypto.Entities.POCOs
{
    public class CrytoCurrency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int Cmc_Rank { get; set; }
        public int Num_Market_Pairs { get; set; }
        public double Circulating_Supply { get; set; }
        public double Total_Supply { get; set; }
        public DateTime Last_Updated { get; set; }
        public DateTime Date_Added { get; set; }
        public Quote Quote { get; set; }

    }
}

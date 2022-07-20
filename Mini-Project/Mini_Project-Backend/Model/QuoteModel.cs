using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class QuoteModel
    {
        public int QuoteID { get; set; }

        public DateTime Date { get; set; }

        public double QuotesAmt { get; set; }

        public string Provider { get; set; }

        public string QuoteType { get; set; }

        public int SecurityID { get; set; }
    }
}

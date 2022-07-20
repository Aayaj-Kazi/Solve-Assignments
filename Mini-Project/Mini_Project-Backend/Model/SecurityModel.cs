using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class SecurityModel
    {
        public int SecurityID { get; set; }

        public string Identifier { get; set; }

        public string SecurityName { get; set; }

        public string AssetClass { get; set; }

        public int QuotesCount { get; set; }

    }
}


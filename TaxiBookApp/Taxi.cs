using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiBookApp
{
    interface Taxi
    {
        public bool TaxiBooking(string destination);

        public string CalculateBill();
    }
}

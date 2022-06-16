using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal interface Payment
    {
        public  Boolean credit(int amount);

        public Boolean credit(decimal amount);

        public Boolean debit(int  amount);

        public Boolean debit(decimal amount);
    }
}

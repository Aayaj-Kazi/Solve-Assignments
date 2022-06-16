using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class CardPayment : Payment
    {
        public bool credit(int amount)
        {
            if (amount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool credit(decimal amount)
        {
            if (amount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool debit(int amount)
        {
            if (amount > 0 && amount < 25000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool debit(decimal amount)
        {
            if (amount > 0 && amount < 25000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

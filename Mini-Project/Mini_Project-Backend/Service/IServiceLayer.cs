using Mini_Project.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Project.Service
{
    public  interface IServiceLayer
    {
        public IEnumerable<SecurityModel> GetAllSecurities();

        public IEnumerable<QuoteModel> GetQuotesBySecurity(int securityID);
    }
}

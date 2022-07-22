using DBContextFile;
using Mini_Project.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mini_Project.Service
{
    public class ServiceLayerImpl : IServiceLayer
    {
        private readonly SecurityDataContext _dataContext;

        public ServiceLayerImpl(SecurityDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<SecurityModel> GetAllSecurities()
        {


            var securitiesList = _dataContext.Security.Select(s => new SecurityModel()
            {
                SecurityID = s.SecurityID,
                Identifier = s.Identifier,
                SecurityName = s.SecurityName,
                AssetClass = s.AssetClass,
                QuotesCount = _dataContext.Quote.Where(dq => dq.SecurityID == s.SecurityID).Count()

            });



            //var securitiesList = _dataContext.Security.Join(_dataContext.Quote, s => s.SecurityID, q => q.SecurityID, (SecurityModel, QuoteModel) => new
            //{
            //    SecurityID = SecurityModel.SecurityID,
            //    Identifier = SecurityModel.Identifier,
            //    SecurityName = SecurityModel.SecurityName,
            //    AssetClass = SecurityModel.AssetClass,
            //    QuotesCount = QuoteModel.QuoteID

            //}).Select(s => new SecurityModel()
            //{
            //    SecurityID = s.SecurityID,
            //    Identifier = s.Identifier,
            //    SecurityName = s.SecurityName,
            //    AssetClass = s.AssetClass,
            //    QuotesCount = _dataContext.Quote.Where(dq => dq.SecurityID.Equals(s.SecurityID)).Count()

            //}).Distinct();


            return securitiesList.ToList();
        }











        public IEnumerable<QuoteModel> GetQuotesBySecurity(int securityID)
        {
            var quotesBySecurity = _dataContext.Quote.Where(x => x.SecurityID == securityID).Select(s => new QuoteModel()
            {
                QuoteID = s.QuoteID,
                Date = s.Date,
                QuotesAmt = s.QuotesAmt,
                Provider = s.Provider,
                QuoteType = s.QuoteType,
                SecurityID = s.SecurityID
            }
            );
            return quotesBySecurity.ToList();
        }

    }
}

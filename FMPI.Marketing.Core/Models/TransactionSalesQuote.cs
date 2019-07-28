using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionSalesQuote
    {
        public decimal SysPkSalesQ { get; set; }
        public decimal? SysFkSqSalesQ { get; set; }
        public decimal? SysFkUmSalesQ { get; set; }
        public string CodeSalesQ { get; set; }
        public string NameSalesQ { get; set; }
        public DateTime? DateIssueSalesQ { get; set; }
        public string SalesQnumSalesQ { get; set; }
        public string ParticularsSalesQ { get; set; }
        public decimal? TotalAmountSalesQ { get; set; }
        public decimal? SalesQnumOrderSalesQ { get; set; }
        public string ModuleSalesQ { get; set; }
    }
}

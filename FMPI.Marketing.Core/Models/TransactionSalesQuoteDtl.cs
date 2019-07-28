using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionSalesQuoteDtl
    {
        public decimal SysPkSalesQdtl { get; set; }
        public decimal? SysFkSqSalesQdtl { get; set; }
        public decimal? SysFkInvtySalesQdtl { get; set; }
        public decimal? QtySalesQdtl { get; set; }
        public string UnitSalesQdtl { get; set; }
        public string PartNoSalesQdtl { get; set; }
        public string DescriptionSalesQdtl { get; set; }
        public string BrandSalesQdtl { get; set; }
        public string ApplicationSalesQdtl { get; set; }
        public decimal? UnitPriceSalesQdtl { get; set; }
        public decimal? DiscSalesQdtl { get; set; }
        public decimal? SubTotalSalesQdtl { get; set; }
        public string CostCodeSalesQdtl { get; set; }
    }
}

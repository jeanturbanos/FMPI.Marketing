using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterSupplier
    {
        public decimal SysPkUmsupl { get; set; }
        public decimal SysFkCoapcsgnUmsupl { get; set; }
        public decimal SysFkUmUmsupl { get; set; }
        public decimal SysFkUmsuplParentUmsupl { get; set; }
        public short? SysSeqUmsupl { get; set; }
        public int? UserSeqUmsupl { get; set; }
        public string UserPkalternativeUmsupl { get; set; }
        public string LastUpdatedByUmsupl { get; set; }
        public short? LastUpdatedConcurrencyIdUmsupl { get; set; }
        public DateTime? LastUpdatedDateUmsupl { get; set; }
        public decimal? BondAmountUmsupl { get; set; }
        public string ModuleUmsupl { get; set; }
        public decimal? CreditLimitAmountUmsupl { get; set; }
        public decimal? CreditLimitDaysPastDueUmsupl { get; set; }
        public string DefaultDiscountUmsupl { get; set; }
        public string TermsApUmsupl { get; set; }
        public string TermsInUseApUmsupl { get; set; }
        public string StatusUmsupl { get; set; }
        public string TypeUmsupl { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterBalances
    {
        public decimal SysPkUmbal { get; set; }
        public decimal SysFkUmUmbal { get; set; }
        public short? SysSeqUmbal { get; set; }
        public int? UserSeqUmbal { get; set; }
        public string LastUpdatedByUmbal { get; set; }
        public short? LastUpdatedConcurrencyIdUmbal { get; set; }
        public DateTime? LastUpdatedDateUmbal { get; set; }
        public string ModuleUmbal { get; set; }
        public decimal? AramountUmbal { get; set; }
        public short? ArdaysPastDueUmbal { get; set; }
        public DateTime? ArasOfUmbal { get; set; }
        public decimal? ApamountUmbal { get; set; }
        public short? ApdaysPastDueUmbal { get; set; }
        public DateTime? ApasOfUmbal { get; set; }
        public decimal? CheckUnClearedUmbal { get; set; }
        public decimal? CheckBadUmbal { get; set; }
        public DateTime? CheckAsOfUmbal { get; set; }
        public decimal? SalesConsignmentAmountUmbal { get; set; }
        public short? SalesConsignmentDaysPastDueUmbal { get; set; }
    }
}

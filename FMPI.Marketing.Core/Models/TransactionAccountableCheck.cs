using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionAccountableCheck
    {
        public decimal SysPkAcctCheck { get; set; }
        public decimal? SysFkTransHAcctCheck { get; set; }
        public short? SysSeqAcctCheck { get; set; }
        public int? UserSeqAcctCheck { get; set; }
        public string UserPkAcctCheck { get; set; }
        public string BookNumAcctCheck { get; set; }
        public string LastUpdatedByAcctCheck { get; set; }
        public short? LastUpdatedConcurrencyIdAcctCheck { get; set; }
        public DateTime? LastUpdatedDateAcctCheck { get; set; }
        public string ModuleAcctCheck { get; set; }
        public DateTime? DateGeneratedAcctCheck { get; set; }
        public DateTime? DateIssueAcctCheck { get; set; }
        public DateTime? DateDueAcctCheck { get; set; }
        public string StatusAcctCheck { get; set; }
        public string SeriesAcctCheck { get; set; }
    }
}

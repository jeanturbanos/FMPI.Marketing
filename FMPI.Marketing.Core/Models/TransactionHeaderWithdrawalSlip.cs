using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderWithdrawalSlip
    {
        public decimal SysPkWslip { get; set; }
        public decimal? SysFkGenerateSeqWslip { get; set; }
        public string UserPkWslip { get; set; }
        public string LastUpdatedByWslip { get; set; }
        public string AccountNameWslip { get; set; }
        public string BookNumWslip { get; set; }
        public DateTime? DateGeneratedWslip { get; set; }
        public DateTime? DateIssueWslip { get; set; }
        public DateTime? DateReleaseWslip { get; set; }
        public int? IsServedWslip { get; set; }
        public string ParticularsWslip { get; set; }
    }
}

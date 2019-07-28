using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionPayrollAmount
    {
        public decimal SysPkPayrlAmt { get; set; }
        public decimal SysFkTransHPayrlAmt { get; set; }
        public decimal SysFkTransHpayrlPayrlAmt { get; set; }
        public decimal SysFkUmemplPayrlAmt { get; set; }
        public decimal SysFkCoaPayrlAmt { get; set; }
        public short? SysSeqPayrlAmt { get; set; }
        public int? UserSeqPayrlAmt { get; set; }
        public string UserPkPayrlAmt { get; set; }
        public string LastUpdatedByPayrlAmt { get; set; }
        public short? LastUpdatedConcurrencyIdPayrlAmt { get; set; }
        public DateTime? LastUpdatedDatePayrlAmt { get; set; }
        public string ModulePayrlAmt { get; set; }
        public decimal? QtyPayrlAmt { get; set; }
        public decimal? RatePayrlAmt { get; set; }
        public decimal? AdditionPayrlAmt { get; set; }
        public decimal? DeductionPayrlAmt { get; set; }
    }
}

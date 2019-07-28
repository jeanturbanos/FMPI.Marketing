using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterPayrollAmount
    {
        public decimal SysPkPmpayrlAmt { get; set; }
        public decimal SysFkPmPmpayrlAmt { get; set; }
        public decimal SysFkCoaPmpayrlAmt { get; set; }
        public short? SysSeqPmpayrlAmt { get; set; }
        public int? UserSeqPmpayrlAmt { get; set; }
        public string UserPkPmpayrlAmt { get; set; }
        public string LastUpdatedByPmpayrlAmt { get; set; }
        public short? LastUpdatedConcurrencyIdPmpayrlAmt { get; set; }
        public DateTime? LastUpdatedDatePmpayrlAmt { get; set; }
        public string ModulePmpayrlAmt { get; set; }
        public string ComputeMethodPmpayrlAmt { get; set; }
        public decimal? RatePmpayrlAmt { get; set; }
        public decimal? AdditionPmpayrlAmt { get; set; }
        public decimal? DeductionPmpayrlAmt { get; set; }
    }
}

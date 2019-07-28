using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterPayrollStandard
    {
        public decimal SysPkPmpyrlStndrd { get; set; }
        public decimal SysFkPmPmpyrlStndrd { get; set; }
        public short? SysSeqPmpyrlStndrd { get; set; }
        public int? UserSeqPmpyrlStndrd { get; set; }
        public string UserPkPmpyrlStndrd { get; set; }
        public string LastUpdatedByPmpyrlStndrd { get; set; }
        public short? LastUpdatedConcurrencyIdPmpyrlStndrd { get; set; }
        public DateTime? LastUpdateDatePmpyrlStndrd { get; set; }
        public string ModulePmpyrlStndrd { get; set; }
        public DateTime? TimeInPmpyrlStndrd { get; set; }
        public DateTime? BreakOutPmpyrlStndrd { get; set; }
        public DateTime? BreakInPmpyrlStndrd { get; set; }
        public DateTime? TimeOutPmpyrlStndrd { get; set; }
    }
}

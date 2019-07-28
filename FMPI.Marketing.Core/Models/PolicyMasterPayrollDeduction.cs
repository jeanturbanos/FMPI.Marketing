using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterPayrollDeduction
    {
        public decimal SysPkPmpyrlDeduct { get; set; }
        public decimal SysFkPmPmpyrlDeduct { get; set; }
        public decimal? SysFkCoaPmpyrlDeduct { get; set; }
        public short? SysSeqPmpyrlDeduct { get; set; }
        public int? UserSeqPmpyrlDeduct { get; set; }
        public string UserPkPmpyrlDeduct { get; set; }
        public string LastUpdatedByPmpyrlDeduct { get; set; }
        public short? LastUpdatedConcurrencyIdPmpyrlDeduct { get; set; }
        public DateTime? LastUpdatedDatePmpyrlDeduct { get; set; }
        public string ModulePmpyrlDeduct { get; set; }
        public string CategoryPmpyrlDeduct { get; set; }
        public string ClassificationPmpyrlDeduct { get; set; }
        public string TypePmpyrlDeduct { get; set; }
        public string StatusPmpyrlDeduct { get; set; }
        public decimal? AmountPmpyrlDeduct { get; set; }
    }
}

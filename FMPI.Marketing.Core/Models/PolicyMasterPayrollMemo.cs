using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterPayrollMemo
    {
        public decimal SysPkPmmemo { get; set; }
        public decimal SysFkPmPmmemo { get; set; }
        public short? SysSeqPmmemo { get; set; }
        public int? UserSeqPmmemo { get; set; }
        public string UserPkPmmemo { get; set; }
        public string LastUpdatedByPmmemo { get; set; }
        public short? LastUpdatedConcurrencyIdPmmemo { get; set; }
        public DateTime? LastUpdatedDatePmmemo { get; set; }
        public string ModulePmmemo { get; set; }
        public string CategoryPmmemo { get; set; }
        public string SubCategoryPmmemo { get; set; }
        public string ClassificationPmmemo { get; set; }
        public string SubClassificationPmmemo { get; set; }
        public string RegulationPmmemo { get; set; }
        public string OffensePmmemo { get; set; }
        public string DeductionRatePmmemo { get; set; }
        public string DaysSuspensionPmmemo { get; set; }
        public string StatusPmmemo { get; set; }
    }
}

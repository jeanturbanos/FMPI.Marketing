using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ReportMaster
    {
        public decimal CbdRptMstr { get; set; }
        public decimal SysPkRptMstr { get; set; }
        public decimal SysFkPmRptMstr { get; set; }
        public short? SysSeqRptMstr { get; set; }
        public int? UserSeqRptMstr { get; set; }
        public string UserPkRptMstr { get; set; }
        public string LastUpdatedByRptMstr { get; set; }
        public short? LastUpdatedConcurrencyIdRptMstr { get; set; }
        public DateTime? LastUpdatedDateRptMstr { get; set; }
        public string ModuleRptMstr { get; set; }
        public string CriteriaAppliedRptMstr { get; set; }
        public string TitleRptMstr { get; set; }
        public string ParticularsRptMstr { get; set; }
    }
}

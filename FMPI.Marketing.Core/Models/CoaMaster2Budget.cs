using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class CoaMaster2Budget
    {
        public decimal SysPkCoabdgt { get; set; }
        public decimal SysFkCoaCoabdgt { get; set; }
        public short? SysSeqCoabdgt { get; set; }
        public int? UserSeqCoabdgt { get; set; }
        public string LastUpdatedByCoabdgt { get; set; }
        public short? LastUpdatedConcurrencyIdCoabdgt { get; set; }
        public DateTime? LastUpdatedDateCoabdgt { get; set; }
        public string DateFromCoabdgt { get; set; }
        public string DateToCoabdgt { get; set; }
        public decimal? AmountBudgetedCoabdgt { get; set; }
        public decimal? AmountActualCoabdgt { get; set; }
    }
}

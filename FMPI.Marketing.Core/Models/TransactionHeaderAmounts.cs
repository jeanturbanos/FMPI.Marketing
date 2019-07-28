using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderAmounts
    {
        public decimal SysPkTransHamt { get; set; }
        public decimal SysFkTransHTransHamt { get; set; }
        public decimal SysFkTransHsourceDocTransHamt { get; set; }
        public decimal SysFkInvtyTransHamt { get; set; }
        public short? SysSeqTransHamt { get; set; }
        public int? UserSeqTransHamt { get; set; }
        public string LastUpdatedByTransHamt { get; set; }
        public short? LastUpdatedConcurrencyIdTransHamt { get; set; }
        public DateTime? LastUpdatedDateTransHamt { get; set; }
        public string ModuleTransHamt { get; set; }
        public string ModuleTypeTransHamt { get; set; }
        public decimal? AmountTransHamt { get; set; }
        public string AmountForTransHamt { get; set; }
        public string ParticularsTransHamt { get; set; }
    }
}

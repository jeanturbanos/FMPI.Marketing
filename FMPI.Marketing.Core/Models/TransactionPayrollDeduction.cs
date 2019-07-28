using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionPayrollDeduction
    {
        public decimal SysPkPayrlDeduct { get; set; }
        public decimal SysFkTransHPayrlDeduct { get; set; }
        public decimal SysFkUmemplPayrlDeduct { get; set; }
        public decimal SysFkPmdeductPayrlDeduct { get; set; }
        public decimal SysFkPmmemoPayrlDeduct { get; set; }
        public short? SysSeqPayrlDeduct { get; set; }
        public int? UserSeqPayrlDeduct { get; set; }
        public string UserPkPayrlDeduct { get; set; }
        public string LastUpdatedByPayrlDeduct { get; set; }
        public short? LastUpdatedConcurrencyIdPayrlDeduct { get; set; }
        public DateTime? LastUpdatedDatePayrlDeduct { get; set; }
        public string ModulePayrlDeduct { get; set; }
        public string DescriptionPayrlDeduct { get; set; }
        public decimal? AmountPayrlDeduct { get; set; }
        public string TypePayrlDeduct { get; set; }
        public string ParticularsPayrlDeduct { get; set; }
    }
}

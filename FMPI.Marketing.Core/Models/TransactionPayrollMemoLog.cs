using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionPayrollMemoLog
    {
        public decimal SysPkPayrlMemo { get; set; }
        public decimal SysFkTransHPayrlMemo { get; set; }
        public decimal SysFkUmemplPayrlMemo { get; set; }
        public decimal SysFkPmmemoPayrlMemo { get; set; }
        public short? SysSeqPayrlMemo { get; set; }
        public int? UserSeqPayrlMemo { get; set; }
        public string UserPkPayrlMemo { get; set; }
        public string LastUpdatedByPayrlMemo { get; set; }
        public short? LastUpdatedConcurrencyIdPayrlMemo { get; set; }
        public DateTime? LastUpdatedDatePayrlMemo { get; set; }
        public string ModulePayrlMemo { get; set; }
        public string WarningLevelPayrlMemo { get; set; }
    }
}

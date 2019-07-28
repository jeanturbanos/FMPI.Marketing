using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionPayrollTimeSheet
    {
        public decimal SysPkPayrlTimeSheet { get; set; }
        public decimal SysFkTransHPayrlTimeSheet { get; set; }
        public decimal SysFkUmpayrlPayrlTimeSheet { get; set; }
        public decimal SysFkUmemplPayrlTimeSheet { get; set; }
        public short? SysSeqPayrlTimeSheet { get; set; }
        public int? UserSeqPayrlTimeSheet { get; set; }
        public string UserPkPayrlTimeSheet { get; set; }
        public string LastUpdatedByPayrlTimeSheet { get; set; }
        public short? LastUpdatedConcurrencyIdPayrlTimeSheet { get; set; }
        public DateTime? LastUpdatedDatePayrlTimeSheet { get; set; }
        public string ModulePayrlTimeSheet { get; set; }
        public DateTime? Shift1TimeInPayrlTimeSheet { get; set; }
        public DateTime? Shift1TimeOutPayrlTimeSheet { get; set; }
        public DateTime? Shift2TimeInPayrlTimeSheet { get; set; }
        public DateTime? Shift2TimeOutPayrlTimeSheet { get; set; }
        public DateTime? Shift3TimeInPayrlTimeSheet { get; set; }
        public DateTime? Shift3TimeOutPayrlTimeSheet { get; set; }
        public DateTime? Shift4TimeInPayrlTimeSheet { get; set; }
        public DateTime? Shift4TimeOutPayrlTimeSheet { get; set; }
        public DateTime? TimeSheetDatePayrlTimeSheet { get; set; }
    }
}

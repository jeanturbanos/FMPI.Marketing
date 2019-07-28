using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterPayrollTables
    {
        public decimal SysPkPmpayTbl { get; set; }
        public decimal SysFkPmPmpayTbl { get; set; }
        public decimal SysFkCoapayrollExpensePmpayTbl { get; set; }
        public short? SysSeqPmpayTbl { get; set; }
        public int? UserSeqPmpayTbl { get; set; }
        public string UserPkPmpayTbl { get; set; }
        public string LastUpdatedByPmpayTbl { get; set; }
        public short? LastUpdatedConcurrencyIdPmpayTbl { get; set; }
        public DateTime? LastUpdatedDatePmpayTbl { get; set; }
        public string ModulePmpayTbl { get; set; }
        public decimal? BracketStartPmpayTbl { get; set; }
        public decimal? BracketEndPmpayTbl { get; set; }
    }
}

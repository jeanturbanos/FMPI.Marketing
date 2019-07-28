using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterEmployee
    {
        public decimal SysPkPmempl { get; set; }
        public decimal SysFkPmPmempl { get; set; }
        public short? SysSeqPmempl { get; set; }
        public int? UserSeqPmempl { get; set; }
        public string UserPkPmempl { get; set; }
        public string LastUpdatedByPmempl { get; set; }
        public short? LastUpdatedConcurrencyIdPmempl { get; set; }
        public DateTime? LastUpdatedDatePmempl { get; set; }
        public string ModulePmempl { get; set; }
    }
}

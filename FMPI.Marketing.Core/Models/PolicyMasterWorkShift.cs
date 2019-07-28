using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterWorkShift
    {
        public decimal SysPkPmwrkShft { get; set; }
        public decimal SysFkPmPmwrkShft { get; set; }
        public short? SysSeqPmwrkShft { get; set; }
        public int? UserSeqPmwrkShft { get; set; }
        public string UserPkPmwrkShft { get; set; }
        public string LastUpdatedByPmwrkShft { get; set; }
        public short? LastUpdatedConcurrencyIdPmwrkShft { get; set; }
        public DateTime? LastUpdatedDatePmwrkShft { get; set; }
        public string ModulePmwrkShft { get; set; }
        public short? IsDefaultPmwrkShft { get; set; }
        public int? PassesMidnightPmwrkShft { get; set; }
        public string TimeStartPmwrkShft { get; set; }
        public string TimeEndPmwrkShft { get; set; }
        public string StatusPmwrkShft { get; set; }
        public string TypePmwrkShft { get; set; }
    }
}

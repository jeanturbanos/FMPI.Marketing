using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityLog
    {
        public decimal SysPkSecurityLog { get; set; }
        public decimal? SysFkTransHSecurityLog { get; set; }
        public decimal? SysFkUserSecurityLog { get; set; }
        public short? SysSeqSecurityLog { get; set; }
        public int? UserSeqSecurityLog { get; set; }
        public short? LastUpdatedConcurrencyIdSecurityLog { get; set; }
        public DateTime? LastUpdatedDateSecurityLog { get; set; }
        public string LastUpdatedBySecurityLog { get; set; }
        public string UserPkSecurityLog { get; set; }
        public string ModuleSecurityLog { get; set; }
        public string ActionSecurityLog { get; set; }
        public string ComputerNameSecurityLog { get; set; }
        public DateTime? DateSecurityLog { get; set; }
        public DateTime? DateTimeSecurityLog { get; set; }
        public string FormNameSecurityLog { get; set; }
        public string ParticularsSecurityLog { get; set; }
        public string UserSecurityLog { get; set; }
    }
}

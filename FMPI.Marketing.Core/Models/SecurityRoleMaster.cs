using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityRoleMaster
    {
        public decimal CbdScrtyRoleMstr { get; set; }
        public decimal SysPkScrtyRoleMstr { get; set; }
        public decimal? SysSeqScrtyRoleMstr { get; set; }
        public short? LastUpdatedConcurrencyIdScrtyRoleMstr { get; set; }
        public DateTime? LastUpdatedDateScrtyRoleMstr { get; set; }
        public string LastUpdatedByScrtyRoleMstr { get; set; }
        public string UserPkScrtyRoleMstr { get; set; }
        public string ParticularsScrtyRoleMstr { get; set; }
        public DateTime? DateEffectivityScrtyRoleMstr { get; set; }
    }
}

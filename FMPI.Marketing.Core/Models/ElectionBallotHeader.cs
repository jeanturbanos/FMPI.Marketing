using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ElectionBallotHeader
    {
        public decimal SysPkElecBaltHdr { get; set; }
        public decimal SysFkPmElecBaltHdr { get; set; }
        public short? SysSeqElecBaltHdr { get; set; }
        public int? UserSeqElecBaltHdr { get; set; }
        public string LastUpdatedByElecBaltHdr { get; set; }
        public short? LastUpdatedConcurrencyIdElecBaltHdr { get; set; }
        public DateTime? LastUpdatedDateElecBaltHdr { get; set; }
        public string ModuleElecBaltHdr { get; set; }
        public string UserPkElecBaltHdr { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterElectionCandidates
    {
        public decimal SysPkPmelecCand { get; set; }
        public decimal SysFkPmPmelecCand { get; set; }
        public decimal SysFkUmPmelecCand { get; set; }
        public short? SysSeqPmelecCand { get; set; }
        public int? UserSeqPmelecCand { get; set; }
        public string LastUpdatedByPmelecCand { get; set; }
        public short? LastUpdatedConcurrencyIdPmelecCand { get; set; }
        public DateTime? LastUpdatedDatePmelecCand { get; set; }
        public string ModulePmelecCand { get; set; }
        public string PositionPmelecCand { get; set; }
        public string BallotColumnPmelecCand { get; set; }
        public string ParticularsPmelecCand { get; set; }
        public string StatusPmelecCand { get; set; }
        public string TypePmelecCand { get; set; }
    }
}

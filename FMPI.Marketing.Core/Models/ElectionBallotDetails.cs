using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ElectionBallotDetails
    {
        public decimal SysPkElecBaltDetl { get; set; }
        public decimal? SysFkElecBaltHdrElecBaltDetl { get; set; }
        public decimal? SysFkUmvotedByElecBaltDetl { get; set; }
        public decimal? SysFkUmvoteForElecBaltDetl { get; set; }
        public short? SysSeqElecBaltDetl { get; set; }
        public int? UserSeqElecBaltDetl { get; set; }
        public string LastUpdatedByElecBaltDetl { get; set; }
        public short? LastUpdatedConcurrencyIdElecBaltDetl { get; set; }
        public DateTime? LastUpdatedDateElecBaltDetl { get; set; }
        public string PositionElecBaltDetl { get; set; }
        public string TypeElecBaltDetl { get; set; }
    }
}

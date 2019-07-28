using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ZzzPcstationMaster
    {
        public decimal SysPkPcstnMstr { get; set; }
        public int? UserSeqPcstnMstr { get; set; }
        public string UserPkPcstnMstr { get; set; }
        public string LastUpdatedByPcstnMstr { get; set; }
        public short? LastUpdatedConcurrencyIdPcstnMstr { get; set; }
        public DateTime? LastUpdatedDatePcstnMstr { get; set; }
        public string ModulePcstnMstr { get; set; }
        public string ParticularsPcstnMstr { get; set; }
        public string PictureFileNamePcstnMstr { get; set; }
        public string StatusPcstnMstr { get; set; }
        public string TypePcstnMstr { get; set; }
    }
}

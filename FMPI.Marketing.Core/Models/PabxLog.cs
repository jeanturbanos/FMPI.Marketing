using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PabxLog
    {
        public decimal SysPkPabxlog { get; set; }
        public string LastUpdatedByPabxlog { get; set; }
        public short? LastUpdatedConcurrencyIdPabxlog { get; set; }
        public DateTime? LastUpdatedDatePabxlog { get; set; }
        public short? SysSeqPabxlog { get; set; }
        public int? UserSeqPabxlog { get; set; }
        public string UserPkPabxlog { get; set; }
        public DateTime? DatePabxlog { get; set; }
        public DateTime? TimePabxlog { get; set; }
        public string ExtensionNumPabxlog { get; set; }
        public string LineNumPabxlog { get; set; }
        public string DialedNumPabxlog { get; set; }
        public string RingPabxlog { get; set; }
        public string DurationPabxlog { get; set; }
        public string AccCodePabxlog { get; set; }
        public string CdPabxlog { get; set; }
        public decimal? ChargesPabxlog { get; set; }
        public short? PostedToFolioPabxlog { get; set; }
    }
}

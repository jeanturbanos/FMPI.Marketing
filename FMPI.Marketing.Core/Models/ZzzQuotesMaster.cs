using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ZzzQuotesMaster
    {
        public decimal SysPkQuotMstr { get; set; }
        public int? UserSeqQuotMstr { get; set; }
        public string UserPkQuotMstr { get; set; }
        public string LastUpdatedByQuotMstr { get; set; }
        public short? LastUpdatedConcurrencyIdQuotMstr { get; set; }
        public DateTime? LastUpdatedDateQuotMstr { get; set; }
        public string ParticularsQuotMstr { get; set; }
        public string PictureFileNameQuotMstr { get; set; }
        public string TypeQuotMstr { get; set; }
    }
}

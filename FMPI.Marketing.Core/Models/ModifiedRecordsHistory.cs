using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ModifiedRecordsHistory
    {
        public decimal SysPkModHist { get; set; }
        public string ObjectCaptionModHist { get; set; }
        public string SysFkRecordModHist { get; set; }
        public string TableNameModHist { get; set; }
        public short? LastUpdatedConcurrencyIdModHist { get; set; }
        public DateTime? LastUpdatedDateModHist { get; set; }
        public string LastUpdatedByModHist { get; set; }
    }
}

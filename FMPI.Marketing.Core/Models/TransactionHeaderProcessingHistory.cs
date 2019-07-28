using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderProcessingHistory
    {
        public decimal SysPkTransHprocHist { get; set; }
        public decimal SysFkTransHTransHprocHist { get; set; }
        public string LastImportedByTransHprocHist { get; set; }
        public DateTime? LastImportedDateTransHprocHist { get; set; }
        public string LastExportedByTransHprocHist { get; set; }
        public DateTime? LastExportedDateTransHprocHist { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ZzzProcessingHistory
    {
        public decimal CbdProcHist { get; set; }
        public decimal SysPkProcHist { get; set; }
        public string ProcessByProcHist { get; set; }
        public DateTime? ProcessDateProcHist { get; set; }
        public string ProcessTimeStartProcHist { get; set; }
        public string ProcessTimeEndProcHist { get; set; }
        public string ParticularsProcHist { get; set; }
        public string StatusProcHist { get; set; }
        public string TypeProcHist { get; set; }
    }
}

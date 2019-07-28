using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderJobs
    {
        public decimal SysPkJobTransH { get; set; }
        public decimal SysFkTransHJobTransH { get; set; }
        public string LastUpdatedByJobTransH { get; set; }
        public short? LastUpdatedConcurrencyIdJobTransH { get; set; }
        public DateTime? LastUpdatedDateJobTransH { get; set; }
        public string ModuleJobTransH { get; set; }
        public string ParticularsJobTransH { get; set; }
        public string PictureFileNameJobTransH { get; set; }
        public string StatusJobTransH { get; set; }
        public string TypeJobTransH { get; set; }
    }
}

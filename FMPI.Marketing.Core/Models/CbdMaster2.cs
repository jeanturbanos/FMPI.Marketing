using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class CbdMaster2
    {
        public decimal SysPkCbd { get; set; }
        public string UserPkCbd { get; set; }
        public string UserPktypeCbd { get; set; }
        public string LastUpdatedByCbd { get; set; }
        public short? LastUpdatedConcurrencyIdCbd { get; set; }
        public DateTime? LastUpdatedDateCbd { get; set; }
        public string BranchCbd { get; set; }
        public string CompanyCbd { get; set; }
        public string DeptCbd { get; set; }
        public string ParticularsCbd { get; set; }
        public string ReportCompanyNameCbd { get; set; }
        public string ReportAddressCbd { get; set; }
        public string ReportAdvertisementCbd { get; set; }
    }
}

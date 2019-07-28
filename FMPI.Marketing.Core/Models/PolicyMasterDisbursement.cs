using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterDisbursement
    {
        public decimal SysPkPmdis { get; set; }
        public decimal SysFkPmPmdis { get; set; }
        public decimal SysFkUmbankPmdis { get; set; }
        public short? SysSeqPmdis { get; set; }
        public int? UserSeqPmdis { get; set; }
        public string UserPkPmdis { get; set; }
        public string LastUpdatedByPmdis { get; set; }
        public short? LastUpdatedConcurrencyIdPmdis { get; set; }
        public DateTime? LastUpdatedDatePmdis { get; set; }
        public string ModulePmdis { get; set; }
        public short? IsDefaultPmdis { get; set; }
        public string StatusPmdis { get; set; }
        public string TypePmdis { get; set; }
        public int? IsIndependentPmdis { get; set; }
        public string UserFkUmbankPmdis { get; set; }
        public short? CheckedByHidePmdis { get; set; }
        public short? ApprovedByHidePmdis { get; set; }
        public short? NameShowAtReceivedByPmdis { get; set; }
    }
}

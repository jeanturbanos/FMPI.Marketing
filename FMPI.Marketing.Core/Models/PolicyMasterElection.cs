using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterElection
    {
        public decimal SysPkPmelec { get; set; }
        public decimal SysFkPmPmelec { get; set; }
        public short? SysSeqPmelec { get; set; }
        public int? UserSeqPmelec { get; set; }
        public string LastUpdatedByPmelec { get; set; }
        public short? LastUpdatedConcurrencyIdPmelec { get; set; }
        public DateTime? LastUpdatedDatePmelec { get; set; }
        public short? IsMemberMultiPositionPmelec { get; set; }
        public string ModulePmelec { get; set; }
        public int? BoyCottPmelec { get; set; }
    }
}

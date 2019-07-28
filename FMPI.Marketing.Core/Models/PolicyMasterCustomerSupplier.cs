using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterCustomerSupplier
    {
        public decimal SysPkPmccustSupl { get; set; }
        public decimal SysFkPmPmccustSupl { get; set; }
        public short? SysSeqPmccustSupl { get; set; }
        public int? UserSeqPmccustSupl { get; set; }
        public string UserPkPmccustSupl { get; set; }
        public string LastUpdatedByPmccustSupl { get; set; }
        public short? LastUpdatedConcurrencyIdPmccustSupl { get; set; }
        public DateTime? LastUpdatedDatePmccustSupl { get; set; }
        public string ModulePmccustSupl { get; set; }
        public string StatusPmccustSupl { get; set; }
        public string TypePmccustSupl { get; set; }
    }
}

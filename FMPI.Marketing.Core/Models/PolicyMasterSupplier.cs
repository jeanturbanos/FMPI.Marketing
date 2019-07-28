using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterSupplier
    {
        public decimal SysPkPmsupl { get; set; }
        public decimal SysFkPmPmsupl { get; set; }
        public decimal SysFkCoaapPmsupl { get; set; }
        public decimal SysFkCoaoutputTaxPmsupl { get; set; }
        public decimal SysFkCoainputTaxPmsupl { get; set; }
        public short? SysSeqPmsupl { get; set; }
        public int? UserSeqPmsupl { get; set; }
        public string UserPkPmsupl { get; set; }
        public string LastUpdatedByPmsupl { get; set; }
        public short? LastUpdatedConcurrencyIdPmsupl { get; set; }
        public DateTime? LastUpdatedDatePmsupl { get; set; }
        public string ModulePmsupl { get; set; }
        public short? IsDefaultPmsupl { get; set; }
        public string StatusPmsupl { get; set; }
        public string TypePmsupl { get; set; }
    }
}

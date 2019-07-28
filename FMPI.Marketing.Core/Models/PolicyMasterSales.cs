using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterSales
    {
        public decimal SysPkPmsal { get; set; }
        public decimal SysFkPmPmsal { get; set; }
        public decimal SysFkUmbankPmsal { get; set; }
        public short? SysSeqPmsal { get; set; }
        public int? UserSeqPmsal { get; set; }
        public string UserPkPmsal { get; set; }
        public string LastUpdatedByPmsal { get; set; }
        public short? LastUpdatedConcurrencyIdPmsal { get; set; }
        public DateTime? LastUpdatedDatePmsal { get; set; }
        public string ModulePmsal { get; set; }
        public short? IsDefaultPmsal { get; set; }
        public string StatusPmsal { get; set; }
        public string TypePmsal { get; set; }
        public int? IsIndependentPmsal { get; set; }
        public string UserFkUmbankPmsal { get; set; }
    }
}

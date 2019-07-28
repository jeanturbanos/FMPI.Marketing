using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterCustomer
    {
        public decimal SysPkPmcust { get; set; }
        public decimal SysFkPmPmcust { get; set; }
        public decimal SysFkCoaarPmcust { get; set; }
        public decimal SysFkCoacashPmcust { get; set; }
        public decimal SysFkCoabadDebtsPmcust { get; set; }
        public decimal SysFkCoasalesPmcust { get; set; }
        public decimal SysFkCoasalesReturnPmcust { get; set; }
        public decimal SysFkCoaoutputTaxPmcust { get; set; }
        public decimal SysFkCoainputTaxPmcust { get; set; }
        public short? SysSeqPmcust { get; set; }
        public int? UserSeqPmcust { get; set; }
        public string UserPkPmcust { get; set; }
        public string LastUpdatedByPmcust { get; set; }
        public short? LastUpdatedConcurrencyIdPmcust { get; set; }
        public DateTime? LastUpdatedDatePmcust { get; set; }
        public string CreditLimitRuleUsedPmcust { get; set; }
        public string ModulePmcust { get; set; }
        public short? IsDefaultPmcust { get; set; }
        public string StatusPmcust { get; set; }
        public string TypePmcust { get; set; }
    }
}

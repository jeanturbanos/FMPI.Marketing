using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerEntries
    {
        public decimal SysFkCoaLdgrEntries { get; set; }
        public decimal SysFkInvtyLdgrEntries { get; set; }
        public decimal SysPkLdgrEntries { get; set; }
        public decimal SysFkLdgrEntriesSlLdgrEntries { get; set; }
        public decimal SysFkTransHLdgrEntries { get; set; }
        public decimal SysFkTransHslLdgrEntries { get; set; }
        public decimal SysFkUmLdgrEntries { get; set; }
        public string UserFkGenericClassLdgrEntries { get; set; }
        public short? SysSeqLdgrEntries { get; set; }
        public int? UserSeqLdgrEntries { get; set; }
        public string UserPkLdgrEntries { get; set; }
        public string LastUpdatedByLdgrEntries { get; set; }
        public short? LastUpdatedConcurrencyIdLdgrEntries { get; set; }
        public DateTime? LastUpdatedDateLdgrEntries { get; set; }
        public string ModuleLdgrEntries { get; set; }
        public string ModuleTransLdgrEntries { get; set; }
        public string AreaLdgrEntries { get; set; }
        public decimal? AmountDueLdgrEntries { get; set; }
        public decimal? AmountPayClrLdgrEntries { get; set; }
        public decimal? AmountPayPdcLdgrEntries { get; set; }
        public decimal? ArrearsDueLdgrEntries { get; set; }
        public decimal? BalanceClrLdgrEntries { get; set; }
        public decimal? BalancePdcLdgrEntries { get; set; }
        public decimal? CramountLdgrEntries { get; set; }
        public decimal? CramountPdcLdgrEntries { get; set; }
        public decimal? CrbaseUnitQtyLdgrEntries { get; set; }
        public decimal? CrforeignAmountLdgrEntries { get; set; }
        public decimal? ForeignConversionRateLdgrEntries { get; set; }
        public string ForeignSignLdgrEntries { get; set; }
        public DateTime? DateDueLdgrEntries { get; set; }
        public string DeptLdgrEntries { get; set; }
        public decimal? DramountLdgrEntries { get; set; }
        public decimal? DramountPdcLdgrEntries { get; set; }
        public decimal? DrbaseUnitQtyLdgrEntries { get; set; }
        public decimal? DrforeignAmountLdgrEntries { get; set; }
        public string ParticularsLdgrEntries { get; set; }
        public string StatusLdgrEntries { get; set; }
        public decimal? UsualDueLdgrEntries { get; set; }
        public string TypeLdgrEntries { get; set; }

        public virtual CoaMaster2 SysFkCoaLdgrEntriesNavigation { get; set; }
        public virtual TransactionHeader SysFkTransHLdgrEntriesNavigation { get; set; }
    }
}

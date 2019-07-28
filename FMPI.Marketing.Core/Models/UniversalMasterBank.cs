using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterBank
    {
        public decimal SysPkUmbank { get; set; }
        public decimal? SysFkUmUmbank { get; set; }
        public decimal? SysFkUmbankParentUmbank { get; set; }
        public decimal? SysFkCoacashInBankUmbank { get; set; }
        public decimal? SysFkCoaarcreditCardUmbank { get; set; }
        public decimal? SysFkCoapdcUmbank { get; set; }
        public decimal? SysFkCoaapUmbank { get; set; }
        public short? SysSeqUmbank { get; set; }
        public int? UserSeqUmbank { get; set; }
        public string UserPkalternativeUmbank { get; set; }
        public string LastUpdatedByUmbank { get; set; }
        public short? LastUpdatedConcurrencyIdUmbank { get; set; }
        public DateTime? LastUpdatedDateUmbank { get; set; }
        public string ModuleUmbank { get; set; }
        public string AccountNumUmbank { get; set; }
        public decimal? MinimumBalanceUmbank { get; set; }
        public string NameManagerUmbank { get; set; }
        public string NameContactPersonUmbank { get; set; }
    }
}

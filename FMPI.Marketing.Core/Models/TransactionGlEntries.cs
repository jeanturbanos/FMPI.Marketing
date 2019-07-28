using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionGlEntries
    {
        public decimal SysPkLdgrEntries { get; set; }
        public decimal SysFkTransHLdgrEntries { get; set; }
        public decimal SysFkInvtyLdgrEntries { get; set; }
        public decimal SysFkCoaLdgrEntries { get; set; }
        public decimal SysFkUmLdgrEntries { get; set; }
        public decimal SysFkTransHslLdgrEntries { get; set; }
        public decimal SysFkLdgrEntriesSlLdgrEntries { get; set; }
        public string UserFkGenericClassLdgrEntries { get; set; }
        public string UserFkUmdeptLdgrEntries { get; set; }
        public short? SysSeqLdgrEntries { get; set; }
        public int? UserSeqLdgrEntries { get; set; }
        public string LastUpdatedByLdgrEntries { get; set; }
        public short? LastUpdatedConcurrencyIdLdgrEntries { get; set; }
        public DateTime? LastUpdatedDateLdgrEntries { get; set; }
        public string ModuleLdgrEntries { get; set; }
        public decimal? CramountLdgrEntries { get; set; }
        public decimal? DramountLdgrEntries { get; set; }
    }
}

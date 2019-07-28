using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerCollectorList
    {
        public decimal SysPkLdgrColList { get; set; }
        public decimal? SysFkTransHLdgrColList { get; set; }
        public decimal? SysFkUmLdgrColList { get; set; }
        public short? SysSeqLdgrColList { get; set; }
        public int? UserSeqLdgrColList { get; set; }
        public string UserPkLdgrColList { get; set; }
        public string LastUpdatedByLdgrColList { get; set; }
        public short? LastUpdatedConcurrencyIdLdgrColList { get; set; }
        public DateTime? LastUpdatedDateLdgrColList { get; set; }
        public string ModuleLdgrColList { get; set; }
        public decimal? AmountLdgrColList { get; set; }
        public decimal? AmountPaidLdgrColList { get; set; }
        public string ParticularsLdgrColList { get; set; }
        public string StatusLdgrColList { get; set; }
        public short? IsIncludePrintLdgrColList { get; set; }
        public short? IsReturnedLdgrColList { get; set; }
        public short? WithSoaLdgrColList { get; set; }
        public short? ForCollectionLdgrColList { get; set; }
    }
}

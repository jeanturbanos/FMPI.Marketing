using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerWslipDetail
    {
        public decimal SysPkWslipDtl { get; set; }
        public decimal? SysFkTransHWslipDtl { get; set; }
        public decimal? SysFkWslipWslipDtl { get; set; }
        public short? SysSeqWslipDtl { get; set; }
        public int? UserSeqWslipDtl { get; set; }
        public string UserPkWslipDtl { get; set; }
        public string LastUpdatedByWslipDtl { get; set; }
        public short? LastUpdatedConcurrencyIdWslipDtl { get; set; }
        public DateTime? LastUpdatedDateWslipDtl { get; set; }
        public string ModuleWslipDtl { get; set; }
        public string DescriptionWslipDtl { get; set; }
        public decimal? DisplayQtyWslipDtl { get; set; }
        public string UnitWslipDtl { get; set; }
        public string RefNoWslipDtl { get; set; }
        public decimal? DisplayReturnedQtyWslipDtl { get; set; }
    }
}

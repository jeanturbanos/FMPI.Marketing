using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerAdjustments
    {
        public decimal SysPkLdgrAdjustment { get; set; }
        public decimal? SysFkTransHLdgrAdjustment { get; set; }
        public decimal? SysFkInvtyLdgrAdjustment { get; set; }
        public decimal? SysFkLdgrInvtySlLdgrAdjustment { get; set; }
        public short? SysSeqLdgrAdjustment { get; set; }
        public int? UserSeqLdgrAdjustment { get; set; }
        public string UserFkInvtyLdgrAdjustment { get; set; }
        public string LastUpdatedByLdgrAdjustment { get; set; }
        public short? LastUpdatedConcurrencyIdLdgrAdjustment { get; set; }
        public DateTime? LastUpdatedDateLdgrAdjustment { get; set; }
        public decimal? DisplaySubTotalInLdgrAdjustment { get; set; }
        public string ModuleLdgrAdjustment { get; set; }
        public string ParticularsLdgrAdjustment { get; set; }
        public decimal? DisplayUnitPriceLdgrAdjustment { get; set; }
        public decimal? DisplayQtyInLdgrAdjustment { get; set; }
        public string DisplayUnitOfMeasureLdgrAdjustment { get; set; }
    }
}

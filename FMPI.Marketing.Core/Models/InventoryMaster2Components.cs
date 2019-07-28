using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class InventoryMaster2Components
    {
        public decimal SysPkInvtyCmpnt { get; set; }
        public decimal SysFkInvtyInvtyCmpnt { get; set; }
        public decimal SysFkInvtyUnitMsrInvtyCmpnt { get; set; }
        public decimal SysFkComponentInvtyInvtyCmpnt { get; set; }
        public int? UserSeqInvtyCmpnt { get; set; }
        public string LastUpdatedByInvtyCmpnt { get; set; }
        public short? LastUpdatedConcurrencyIdInvtyCmpnt { get; set; }
        public DateTime? LastUpdatedDateInvtyCmpnt { get; set; }
        public string ModuleInvtyCmpnt { get; set; }
        public string UserFkInvtyUnitMsrInvtyCmpnt { get; set; }
        public string ComponentQtyInvtyCmpnt { get; set; }
        public decimal? ComponentUnitPriceInvtyCmpnt { get; set; }
        public decimal? ComponentUnitBaseMultiplierInvtyCmpnt { get; set; }
        public string ComponentSubTotalInvtyCmpnt { get; set; }
    }
}

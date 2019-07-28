using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class InventoryMaster2Units
    {
        public decimal SysPkInvtyUnit { get; set; }
        public decimal SysFkInvtyInvtyUnit { get; set; }
        public int? SysSeqInvtyUnit { get; set; }
        public int? UserSeqInvtyUnit { get; set; }
        public string LastUpdatedByInvtyUnit { get; set; }
        public short? LastUpdatedConcurrencyIdInvtyUnit { get; set; }
        public DateTime? LastUpdatedDateInvtyUnit { get; set; }
        public string UserPkInvtyUnit { get; set; }
        public decimal? UnitBaseMultiplierInvtyUnit { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class InventoryMaster2MoreInfo
    {
        public decimal SysPkInvtyNfo { get; set; }
        public decimal SysFkInvtyInvtyNfo { get; set; }
        public short? SysSeqInvtyNfo { get; set; }
        public int? UserSeqInvtyNfo { get; set; }
        public string LastUpdatedByInvtyNfo { get; set; }
        public short? LastUpdatedConcurrencyIdInvtyNfo { get; set; }
        public DateTime? LastUpdatedDateInvtyNfo { get; set; }
        public string ModuleInvtyNfo { get; set; }
        public string Info1InvtyNfo { get; set; }
        public string Info2InvtyNfo { get; set; }
        public string Info3InvtyNfo { get; set; }
    }
}

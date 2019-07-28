using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class InventoryMasterJunction
    {
        public decimal SysPkInvtyJ { get; set; }
        public decimal SysFkInvty01InvtyJ { get; set; }
        public decimal SysFkInvty02InvtyJ { get; set; }
        public decimal SysFkInvty03InvtyJ { get; set; }
        public decimal SysFkUmInvtyJ { get; set; }
        public short? SysSeqInvtyJ { get; set; }
        public int? UserSeqInvtyJ { get; set; }
        public short? LastUpdatedConcurrencyIdInvtyJ { get; set; }
        public DateTime? LastUpdatedDateInvtyJ { get; set; }
        public string LastUpdatedByInvtyJ { get; set; }
        public string ModuleInvtyJ { get; set; }
        public string ModuleTypeInvtyJ { get; set; }
        public string RemarksInvtyJ { get; set; }
    }
}

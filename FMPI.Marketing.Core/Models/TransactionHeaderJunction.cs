using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderJunction
    {
        public decimal SysPkTransHj { get; set; }
        public decimal SysFkTransH01TransHj { get; set; }
        public decimal SysFkTransH02TransHj { get; set; }
        public decimal SysFkTransH03TransHj { get; set; }
        public short? SysSeqTransHj { get; set; }
        public int? UserSeqTransHj { get; set; }
        public short? LastUpdatedConcurrencyIdTransHj { get; set; }
        public DateTime? LastUpdatedDateTransHj { get; set; }
        public string LastUpdatedByTransHj { get; set; }
        public string ModuleTransHj { get; set; }
        public string ModuleTypeTransHj { get; set; }
        public string RemarksTransHj { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterJunction
    {
        public decimal SysPkUmj { get; set; }
        public decimal SysFkUm01Umj { get; set; }
        public decimal SysFkUm02Umj { get; set; }
        public decimal SysFkUm03Umj { get; set; }
        public short? SysSeqUmj { get; set; }
        public int? UserSeqUmj { get; set; }
        public short? LastUpdatedConcurrencyIdUmj { get; set; }
        public DateTime? LastUpdatedDateUmj { get; set; }
        public string LastUpdatedByUmj { get; set; }
        public string ModuleUmj { get; set; }
        public string ModuleTypeUmj { get; set; }
        public string RemarksUmj { get; set; }
    }
}

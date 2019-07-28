using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterVotes
    {
        public decimal SysPkUmvote { get; set; }
        public decimal SysFkUmUmvote { get; set; }
        public decimal SysFkPmUmvote { get; set; }
        public short? SysSeqUmvote { get; set; }
        public int? UserSeqUmvote { get; set; }
        public string LastUpdatedByUmvote { get; set; }
        public short? LastUpdatedConcurrencyIdUmvote { get; set; }
        public DateTime? LastUpdatedDateUmvote { get; set; }
        public string ModuleUmvote { get; set; }
        public string StatusUmvote { get; set; }
        public string TypeUmvote { get; set; }
    }
}

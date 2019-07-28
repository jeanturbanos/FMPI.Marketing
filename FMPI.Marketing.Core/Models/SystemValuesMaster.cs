using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SystemValuesMaster
    {
        public decimal CbdSysValMstr { get; set; }
        public decimal SysPkSysValMstr { get; set; }
        public decimal SysFkSysValMstrParentSysValMstr { get; set; }
        public short? SysSeqSysValMstr { get; set; }
        public int? UserSeqSysValMstr { get; set; }
        public string UserPkSysValMstr { get; set; }
        public string LastUpdatedBySysValMstr { get; set; }
        public short? LastUpdatedConcurrencyIdSysValMstr { get; set; }
        public DateTime? LastUpdatedDateSysValMstr { get; set; }
        public string ModuleSysValMstr { get; set; }
        public string DescriptionSysValMstr { get; set; }
    }
}

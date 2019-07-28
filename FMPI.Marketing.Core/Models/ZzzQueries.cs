using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ZzzQueries
    {
        public decimal SysPkQry { get; set; }
        public string TextQry { get; set; }
        public string TagQry { get; set; }
        public string UserPkQry { get; set; }
        public string LastUpdatedByQry { get; set; }
        public short? LastUpdatedConcurrencyIdQry { get; set; }
        public DateTime? LastUpdatedDateQry { get; set; }
    }
}

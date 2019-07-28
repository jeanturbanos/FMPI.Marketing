using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class DeleteLogMaster
    {
        public string UserName { get; set; }
        public string OneTimeDeletingRightsGrantedBy { get; set; }
        public string FormCaption { get; set; }
        public DateTime? DateTimeDeleted { get; set; }
        public string RecordInfo { get; set; }
        public decimal RecordSysPk { get; set; }
        public string TableName { get; set; }
        public string StationNum { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ZzzHelpMaster
    {
        public decimal SysPkHelpM { get; set; }
        public short? SysSeqHelpM { get; set; }
        public int? UserSeqHelpM { get; set; }
        public string UserPkHelpM { get; set; }
        public string LastUpdatedByHelpM { get; set; }
        public short? LastUpdatedConcurrencyIdHelpM { get; set; }
        public DateTime? LastUpdatedDateHelpM { get; set; }
        public string ModuleHelpM { get; set; }
        public string CausedByHelpM { get; set; }
        public string DetectedByHelpM { get; set; }
        public DateTime? DateReportedHelpM { get; set; }
        public DateTime? DateFixedHelpM { get; set; }
        public string FixedByHelpM { get; set; }
        public string ParticularsHelpM { get; set; }
        public string PictureFileNameHelpM { get; set; }
        public string StatusHelpM { get; set; }
        public string TypeHelpM { get; set; }
    }
}

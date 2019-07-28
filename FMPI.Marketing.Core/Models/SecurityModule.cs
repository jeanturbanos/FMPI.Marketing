using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityModule
    {
        public decimal SysPkScrtyMod { get; set; }
        public decimal? SysSeqScrtyMod { get; set; }
        public decimal SysFkRoleScrtyMod { get; set; }
        public int? UserSeqScrtyMod { get; set; }
        public short? LastUpdatedConcurrencyIdScrtyMod { get; set; }
        public DateTime? LastUpdatedDateScrtyMod { get; set; }
        public string LastUpdatedByScrtyMod { get; set; }
        public string ModuleScrtyMod { get; set; }
        public string ModuleTypeScrtyMod { get; set; }
        public string ModuleCaptionScrtyMod { get; set; }
        public string RightsScrtyMod { get; set; }
    }
}

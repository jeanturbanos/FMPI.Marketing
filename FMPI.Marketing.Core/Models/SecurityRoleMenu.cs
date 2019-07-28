using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityRoleMenu
    {
        public decimal SysPkScrtyRoleMnu { get; set; }
        public decimal? SysSeqScrtyRoleMnu { get; set; }
        public decimal SysFkScrtyRoleMstrScrtyRoleMnu { get; set; }
        public int? UserSeqScrtyRoleMnu { get; set; }
        public short? LastUpdatedConcurrencyIdScrtyRoleMnu { get; set; }
        public DateTime? LastUpdatedDateScrtyRoleMnu { get; set; }
        public string LastUpdatedByScrtyRoleMnu { get; set; }
        public string CaptionScrtyRoleMnu { get; set; }
        public string ModuleScrtyRoleMnu { get; set; }
        public string MainMenuScrtyRoleMnu { get; set; }
        public string SubMenuScrtyRoleMnu { get; set; }
        public string TrimmedCaptionScrtyRoleMnu { get; set; }
        public string DisplayedCaptionScrtyRoleMnu { get; set; }
    }
}

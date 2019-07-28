using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityRoleCommandButton
    {
        public decimal SysPkScrtyRoleCmd { get; set; }
        public decimal? SysSeqScrtyRoleCmd { get; set; }
        public decimal SysFkScrtyRoleMstrScrtyRoleCmd { get; set; }
        public decimal SysFkUmScrtyRoleCmd { get; set; }
        public int? UserSeqScrtyRoleCmd { get; set; }
        public short? LastUpdatedConcurrencyIdScrtyRoleCmd { get; set; }
        public DateTime? LastUpdatedDateScrtyRoleCmd { get; set; }
        public string LastUpdatedByScrtyRoleCmd { get; set; }
        public string MainMenuScrtyRoleCmd { get; set; }
        public string CaptionScrtyRoleCmd { get; set; }
        public string DisplayedCaptionScrtyRoleCmd { get; set; }
        public string TrimmedCaptionScrtyRoleCmd { get; set; }
        public string ModuleScrtyRoleCmd { get; set; }
        public int? ForeColorScrtyRoleCmd { get; set; }
        public int? BackColorScrtyRoleCmd { get; set; }
        public string PictureFileNameScrtyRoleCmd { get; set; }
        public string ToolTipTextScrtyRoleCmd { get; set; }
    }
}

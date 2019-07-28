using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityPermissions
    {
        public decimal SysPkScrtyPrm { get; set; }
        public decimal? SysSeqScrtyPrm { get; set; }
        public decimal SysFkRoleScrtyPrm { get; set; }
        public int? UserSeqScrtyPrm { get; set; }
        public short? LastUpdatedConcurrencyIdScrtyPrm { get; set; }
        public DateTime? LastUpdatedDateScrtyPrm { get; set; }
        public string LastUpdatedByScrtyPrm { get; set; }
        public string ModuleScrtyPrm { get; set; }
        public string FormCaptionScrtyPrm { get; set; }
        public string ControlCaptionScrtyPrm { get; set; }
        public string RightsScrtyPrm { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityTemporaryPermissions
    {
        public decimal SysPkScrtyTmprm { get; set; }
        public decimal? SysSeqScrtyTmprm { get; set; }
        public decimal SysFkRoleScrtyTmprm { get; set; }
        public decimal SysFkUserScrtyTmprm { get; set; }
        public int? UserSeqScrtyTmprm { get; set; }
        public string UserPkusersScrtyTmprm { get; set; }
        public short? LastUpdatedConcurrencyIdScrtyTmprm { get; set; }
        public DateTime? LastUpdatedDateScrtyTmprm { get; set; }
        public string LastUpdatedByScrtyTmprm { get; set; }
        public string ModuleScrtyTmprm { get; set; }
        public string ModuleTypeScrtyTmprm { get; set; }
        public string ModuleCaptionScrtyTmprm { get; set; }
        public string ActiveScrtyTmprm { get; set; }
        public DateTime? DateActiveActiveScrtyTmprm { get; set; }
        public DateTime? DateInActiveScrtyTmprm { get; set; }
        public string DurationScrtyTmprm { get; set; }
        public string PermissionScrtyTmprm { get; set; }
        public string RightsScrtyTmprm { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class SecurityUser
    {
        public decimal SysPkScrtyUser { get; set; }
        public decimal? SysSeqScrtyUser { get; set; }
        public decimal SysFkRoleScrtyUser { get; set; }
        public decimal SysFkUserScrtyUser { get; set; }
        public int? UserSeqScrtyUser { get; set; }
        public short? LastUpdatedConcurrencyIdScrtyUser { get; set; }
        public DateTime? LastUpdatedDateScrtyUser { get; set; }
        public string LastUpdatedByScrtyUser { get; set; }
        public string UserPkusersScrtyUser { get; set; }
        public string UserNameScrtyUser { get; set; }
        public string EditOnceModuleCaptionScrtyUser { get; set; }
        public string UserFkUsersScrtyUser { get; set; }
    }
}

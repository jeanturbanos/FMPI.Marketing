using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class GuestRegistrationCompanions
    {
        public decimal SysPkGcomp { get; set; }
        public decimal SysFkGregGcomp { get; set; }
        public decimal SysFkInvtyGcomp { get; set; }
        public decimal SysFkFaclGcomp { get; set; }
        public short? SysSeqGcomp { get; set; }
        public int? UserSeqGcomp { get; set; }
        public short? LastUpdatedConcurrencyIdGcomp { get; set; }
        public DateTime? LastUpdatedDateGcomp { get; set; }
        public string LastUpdatedByGcomp { get; set; }
        public string UserFkFaclGcomp { get; set; }
        public string UserPkGcomp { get; set; }
        public string CountryGcomp { get; set; }
        public string IsGcomp { get; set; }
        public string ModuleGcomp { get; set; }
        public string NameGcomp { get; set; }
        public string NationalityGcomp { get; set; }
        public int? PaxGcomp { get; set; }
        public string PassportRemarksGcomp { get; set; }
        public string PictureFileNameGcomp { get; set; }
        public string RemarksGcomp { get; set; }
    }
}

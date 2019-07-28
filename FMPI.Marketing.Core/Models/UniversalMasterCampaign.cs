using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterCampaign
    {
        public decimal SysPkUmcamp { get; set; }
        public string UserPkalternativeUmcamp { get; set; }
        public decimal SysFkUmUmcamp { get; set; }
        public decimal SysFkUmcampParentUmcamp { get; set; }
        public short? SysSeqUmcamp { get; set; }
        public int? UserSeqUmcamp { get; set; }
        public short? LastUpdatedConcurrencyIdUmcamp { get; set; }
        public DateTime? LastUpdatedDateUmcamp { get; set; }
        public string LastUpdatedByUmcamp { get; set; }
        public string ModuleUmcamp { get; set; }
        public string SmsnumUmcamp { get; set; }
        public string EmailUmcamp { get; set; }
        public string MailingAddressUmcamp { get; set; }
    }
}

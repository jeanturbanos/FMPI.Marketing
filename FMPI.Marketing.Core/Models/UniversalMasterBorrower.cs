using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterBorrower
    {
        public decimal SysPkUmbrwr { get; set; }
        public decimal SysFkUmUmbrwr { get; set; }
        public decimal SysFkUmbrwrParentUmbrwr { get; set; }
        public short? SysSeqUmbrwr { get; set; }
        public int? UserSeqUmbrwr { get; set; }
        public string UserPkalternativeUmbrwr { get; set; }
        public string LastUpdatedByUmbrwr { get; set; }
        public short? LastUpdatedConcurrencyIdUmbrwr { get; set; }
        public DateTime? LastUpdatedDateUmbrwr { get; set; }
        public string ModuleUmbrwr { get; set; }
        public string AddressBusinessUmbrwr { get; set; }
        public string AreaUmbrwr { get; set; }
        public DateTime? BirthdateUmbrwr { get; set; }
        public string MaritalRoleUmbrwr { get; set; }
        public string MaritalStatusUmbrwr { get; set; }
        public string SalutationUmbrwr { get; set; }
        public string SpaUmbrwr { get; set; }
        public string RelationUmbrwr { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class FacilityJunction
    {
        public decimal SysPkFaclJ { get; set; }
        public decimal SysFkFacl01FaclJ { get; set; }
        public decimal SysFkFacl02FaclJ { get; set; }
        public decimal SysFkFacl03FaclJ { get; set; }
        public short? SysSeqFaclJ { get; set; }
        public int? UserSeqFaclJ { get; set; }
        public short? LastUpdatedConcurrencyIdFaclJ { get; set; }
        public DateTime? LastUpdatedDateFaclJ { get; set; }
        public string LastUpdatedByFaclJ { get; set; }
        public string ModuleFaclJ { get; set; }
        public string ModuleTypeFaclJ { get; set; }
    }
}

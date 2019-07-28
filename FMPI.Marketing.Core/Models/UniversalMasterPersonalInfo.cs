using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterPersonalInfo
    {
        public decimal SysPkUmpinfo { get; set; }
        public decimal SysFkUmUmpinfo { get; set; }
        public short? SysSeqUmpinfo { get; set; }
        public int? UserSeqUmpinfo { get; set; }
        public string LastUpdatedByUmpinfo { get; set; }
        public short? LastUpdatedConcurrencyIdUmpinfo { get; set; }
        public DateTime? LastUpdatedDateUmpinfo { get; set; }
        public string ModuleUmpinfo { get; set; }
        public string ParticularsUmpinfo { get; set; }
        public string PictureFileNameUmpinfo { get; set; }
        public string StatusUmpinfo { get; set; }
        public string TypeUmpinfo { get; set; }
    }
}

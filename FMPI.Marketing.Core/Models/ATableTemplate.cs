using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ATableTemplate
    {
        public decimal CbdTableCode { get; set; }
        public decimal SysPkTableCode { get; set; }
        public decimal SysFkTableCodeTableCode { get; set; }
        public decimal SysFkTableCodeParentTableCode { get; set; }
        public short? SysSeqTableCode { get; set; }
        public int? UserSeqTableCode { get; set; }
        public string UserPkTableCode { get; set; }
        public string LastUpdatedByTableCode { get; set; }
        public short? LastUpdatedConcurrencyIdTableCode { get; set; }
        public DateTime? LastUpdatedDateTableCode { get; set; }
        public string ModuleTableCode { get; set; }
        public string ParticularsTableCode { get; set; }
        public string PictureFileNameTableCode { get; set; }
        public string StatusTableCode { get; set; }
        public string TypeTableCode { get; set; }
    }
}

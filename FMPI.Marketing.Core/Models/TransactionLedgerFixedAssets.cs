using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerFixedAssets
    {
        public decimal SysPkFixdAset { get; set; }
        public decimal SysFkTransHFixdAset { get; set; }
        public short? SysSeqFixdAset { get; set; }
        public int? UserSeqFixdAset { get; set; }
        public string LastUpdatedByFixdAset { get; set; }
        public short? LastUpdatedConcurrencyIdFixdAset { get; set; }
        public DateTime? LastUpdatedDateFixdAset { get; set; }
        public string ModuleFixdAset { get; set; }
        public string ParticularsFixdAset { get; set; }
        public string PictureFileNameTableCode { get; set; }
        public string StatusFixdAset { get; set; }
        public string TypeFixdAset { get; set; }
    }
}

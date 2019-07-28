using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMasterBusinessFinancial
    {
        public long SysPkUmbusnFinc { get; set; }
        public long SysFkUmUmbusnFinc { get; set; }
        public short? SysSeqUmbusnFinc { get; set; }
        public int? UserSeqUmbusnFinc { get; set; }
        public string LastUpdatedByUmbusnFinc { get; set; }
        public short? LastUpdatedConcurrencyIdUmbusnFinc { get; set; }
        public DateTime? LastUpdatedDateUmbusnFinc { get; set; }
        public DateTime? DateUmbusnFinc { get; set; }
        public string ModuleUmbusnFinc { get; set; }
        public string NameUmbusnFinc { get; set; }
        public string ContactUmbusnFinc { get; set; }
        public string RemarksUmbusnFinc { get; set; }
        public string TypeUmbusnFinc { get; set; }
        public decimal? Value1UmbusnFinc { get; set; }
        public decimal? Value2UmbusnFinc { get; set; }
        public decimal? Value3UmbusnFinc { get; set; }
    }
}

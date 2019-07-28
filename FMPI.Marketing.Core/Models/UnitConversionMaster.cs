using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UnitConversionMaster
    {
        public decimal SysPkUnitConvMstr { get; set; }
        public string UserPkUnitConvMstr { get; set; }
        public decimal SysFkInvtyUnitConvMstr { get; set; }
        public decimal SysFkInvtyBatchUnitConvMstr { get; set; }
        public decimal SysFkUmUnitConvMstr { get; set; }
        public short? SysSeqUnitConvMstr { get; set; }
        public int? UserSeqUnitConvMstr { get; set; }
        public short? LastUpdatedConcurrencyIdUnitConvMstr { get; set; }
        public DateTime? LastUpdatedDateUnitConvMstr { get; set; }
        public string LastUpdatedByUnitConvMstr { get; set; }
        public DateTime? DateDefinedUnitConvMstr { get; set; }
        public string DefinedByUnitConvMstr { get; set; }
        public string DescriptionUnitConvMstr { get; set; }
        public string ParticularsUnitConvMstr { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class InventoryMasterFixedAssets
    {
        public decimal CbdFixAst { get; set; }
        public decimal SysPkFixAst { get; set; }
        public decimal SysFkInvtyFixAst { get; set; }
        public decimal SysFkUmFixAst { get; set; }
        public short? SysSeqFixAst { get; set; }
        public int? UserSeqFixAst { get; set; }
        public string UserPkFixAst { get; set; }
        public string LastUpdatedByFixAst { get; set; }
        public short? LastUpdatedConcurrencyIdFixAst { get; set; }
        public DateTime? LastUpdatedDateFixAst { get; set; }
        public string ModuleFixAst { get; set; }
        public string ParticularsFixAst { get; set; }
        public string PictureFileNameFixAst { get; set; }
        public string StatusFixAst { get; set; }
        public string TypeFixAst { get; set; }
        public decimal? LifeSpanInvtyFixAst { get; set; }
        public string SerialNumberInvtyFixAst { get; set; }
        public decimal? ResaleValueInvtyFixAst { get; set; }
        public DateTime? AquisitionDateInvtyFixAst { get; set; }
        public decimal? MonthlyUsualDepreciationInvtyFixAst { get; set; }
        public decimal? AquisitionAmountLocalInvtyFixAst { get; set; }
        public decimal? AquisitionAmountForeignInvtyFixAst { get; set; }
    }
}

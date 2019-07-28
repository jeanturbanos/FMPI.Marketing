using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterReport
    {
        public decimal SysPkPmrpt { get; set; }
        public decimal SysFkPmPmrpt { get; set; }
        public short? SysSeqPmrpt { get; set; }
        public int? UserSeqPmrpt { get; set; }
        public string LastUpdatedByPmrpt { get; set; }
        public short? LastUpdatedConcurrencyIdPmrpt { get; set; }
        public DateTime? LastUpdatedDatePmrpt { get; set; }
        public int? RowNumPmrpt { get; set; }
        public string RowGroupPmrpt { get; set; }
        public string RowGroupSubTotalPmrpt { get; set; }
        public short? RowHiddenPmrpt { get; set; }
        public string FontNamePmrpt { get; set; }
        public short? FontBoldPmrpt { get; set; }
        public short? FontUnderlinePmrpt { get; set; }
        public short? FontItalicPmrpt { get; set; }
        public short? HasBottomLinePmrpt { get; set; }
        public short? HasTopLinePmrpt { get; set; }
        public short? HasLeftLinePmrpt { get; set; }
        public short? HasRightLinePmrpt { get; set; }
        public int? ColumnWidthPmrpt { get; set; }
        public string ColumnTypePmrpt { get; set; }
        public string ColumnNumPmrpt { get; set; }
        public string ColumnNumAmountPmrpt { get; set; }
        public short? ColumnHiddenPmrpt { get; set; }
        public decimal? SysFkDataPmrpt { get; set; }
        public string TableNamePmrpt { get; set; }
        public string FieldNamePmrpt { get; set; }
        public string OperatorPmrpt { get; set; }
        public string AdditionalWherePmrpt { get; set; }
        public string CaptionPmrpt { get; set; }
    }
}

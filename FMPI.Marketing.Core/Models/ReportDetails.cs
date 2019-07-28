using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ReportDetails
    {
        public decimal SysPkRptDetl { get; set; }
        public decimal SysFkRptMstrRptDetl { get; set; }
        public decimal SysFkPmrptRptDetl { get; set; }
        public short? SysSeqRptDetl { get; set; }
        public int? UserSeqRptDetl { get; set; }
        public string RowGroupRptDetl { get; set; }
        public string Column01RptDetl { get; set; }
        public string Column02RptDetl { get; set; }
        public string Column03RptDetl { get; set; }
        public string Column04RptDetl { get; set; }
        public string Column05RptDetl { get; set; }
        public decimal? ColumnAmount01RptDetl { get; set; }
        public decimal? ColumnAmount02RptDetl { get; set; }
    }
}

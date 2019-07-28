using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderAdjustment
    {
        public decimal SysPkTransHadj { get; set; }
        public decimal? SysFkTransHTransHadj { get; set; }
        public decimal? SysFkUmTransHadj { get; set; }
        public string LastUpdatedByTransHadj { get; set; }
        public DateTime? LastUpdatedDateTransHadj { get; set; }
        public string UserPkTransHadj { get; set; }
        public string AccountDocumentNumTransHadj { get; set; }
        public DateTime? DateIssueTransHadj { get; set; }
        public string SupplierCodTransHadj { get; set; }
        public string SupplierNameTransHadj { get; set; }
        public double? TotalAmountTransHadj { get; set; }
    }
}

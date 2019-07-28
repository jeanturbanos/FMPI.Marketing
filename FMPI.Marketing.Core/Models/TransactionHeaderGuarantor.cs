using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderGuarantor
    {
        public decimal SysPkTransHguarantor { get; set; }
        public decimal SysFkTransHTransHguarantor { get; set; }
        public decimal SysFkAccountTransHguarantor { get; set; }
        public int? UserSeqTransHguarantor { get; set; }
        public short? LastUpdatedConcurrencyIdTransHguarantor { get; set; }
        public DateTime? LastUpdatedDateTransHguarantor { get; set; }
        public string LastUpdatedByTransHguarantor { get; set; }
        public string UserPkTransHguarantor { get; set; }
        public string MasterfileTypeAsOfIssueDateTransHguarantor { get; set; }
        public string AccountCodeTransHguarantor { get; set; }
        public string AccountNameTransHguarantor { get; set; }
        public string StatusAccountAsOfIssueDateTransHguarantor { get; set; }
        public string TypeAccountAsOfIssueDateTransHguarantor { get; set; }
        public decimal? CreditLineAsOfDateIssueTransHguarantor { get; set; }
        public decimal? TotalDueClrAsOfDateIssueTransH { get; set; }
        public decimal? TotalPayClrAsOfDateIssueTransH { get; set; }
        public decimal? TotalBalClrAsOfDateIssueTransH { get; set; }
        public decimal? TotalDueUnClrAsOfDateIssueTransH { get; set; }
        public decimal? TotalPayUnClrAsOfDateIssueTransH { get; set; }
        public decimal? TotalBalUnClrAsOfDateIssueTransH { get; set; }
        public decimal? TotalRemainingProcessedTransH { get; set; }
        public decimal? GuaranteedAmountTransHguarantor { get; set; }
        public string GuaranteedItemTransHguarantor { get; set; }
        public string ParticularsTransHguarantor { get; set; }
    }
}

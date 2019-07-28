using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionAccountableNum
    {
        public decimal SysPkTransAcctNum { get; set; }
        public short? SysSeqTransAcctNum { get; set; }
        public int? UserSeqTransAcctNum { get; set; }
        public string UserPkTransAcctNum { get; set; }
        public string BookNumTransAcctNum { get; set; }
        public string LastUpdatedByTransAcctNum { get; set; }
        public short? LastUpdatedConcurrencyIdTransAcctNum { get; set; }
        public DateTime? LastUpdatedDateTransAcctNum { get; set; }
        public string ModuleTransAcctNum { get; set; }
        public decimal? UserFkInvoiceTransAcctNum { get; set; }
        public DateTime? DateGeneratedTransAcctNum { get; set; }
        public DateTime? DateIssueTransH { get; set; }
        public DateTime? DateIssueTransChk { get; set; }
        public string ModuleTransHTransAcctNum { get; set; }
        public string StatusTransAcctNum { get; set; }
    }
}

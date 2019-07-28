using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderChecks
    {
        public decimal CbdTransChk { get; set; }
        public decimal SysPkTransChk { get; set; }
        public decimal SysFkCoaTransChk { get; set; }
        public decimal SysFkLdgrEntriesTransChk { get; set; }
        public decimal SysFkPmTransChk { get; set; }
        public decimal SysFkTransHTransChk { get; set; }
        public decimal SysFkUmarapTransChk { get; set; }
        public decimal SysFkUmbankTransChk { get; set; }
        public decimal SysFkAcctChkTransChk { get; set; }
        public short? SysSeqTransChk { get; set; }
        public int? UserSeqTransChk { get; set; }
        public string UserPkTransChk { get; set; }
        public string LastUpdatedByTransChk { get; set; }
        public short? LastUpdatedConcurrencyIdTransChk { get; set; }
        public DateTime? LastUpdatedDateTransChk { get; set; }
        public string ModuleTransChk { get; set; }
        public string ModuleTransTransChk { get; set; }
        public string BankBranchTransChk { get; set; }
        public DateTime? DateClearTransChk { get; set; }
        public DateTime? DateIssueTransChk { get; set; }
        public short? DaysTransChk { get; set; }
        public decimal? DepositCheckClrTransChk { get; set; }
        public decimal? DepositCheckUnClrTransChk { get; set; }
        public decimal? DisplayAmountTransChk { get; set; }
        public string PayeeTransChk { get; set; }
        public string StatusTransChk { get; set; }
        public string TypeTransChk { get; set; }
        public decimal? WithdrawalCheckClrTransChk { get; set; }
        public decimal? WithdrawalCheckUnClrTransChk { get; set; }
        public string SignatoryATransChk { get; set; }
        public string SignatoryBTransChk { get; set; }
        public short? IsCrossCheckTransChk { get; set; }
        public short? ForMailTransChk { get; set; }
        public short? IsCheckMailedTransChk { get; set; }
        public string MailRefNoTransChk { get; set; }
        public DateTime? DateMailedTransChk { get; set; }
        public DateTime? DateReleasedTransChk { get; set; }
        public short? IsCheckReleasedTransChk { get; set; }
        public short? IsCheckReceivedTransChk { get; set; }
        public DateTime? DateReceivedTransChk { get; set; }
        public short? IsCompanyNameHiddenInCheckTransChk { get; set; }
    }
}

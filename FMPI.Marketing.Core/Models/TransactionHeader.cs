using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeader
    {
        public TransactionHeader()
        {
            TransactionLedgerEntries = new HashSet<TransactionLedgerEntries>();
            TransactionLedgerInvty = new HashSet<TransactionLedgerInvty>();
        }

        public decimal CbdTransH { get; set; }
        public decimal SysPkTransH { get; set; }
        public decimal SysFkAccountTransH { get; set; }
        public decimal SysFkAccountDocumentAccountTransH { get; set; }
        public decimal SysFkAccountDocumentTransHTransH { get; set; }
        public decimal SysFkBatchTransHTransH { get; set; }
        public decimal SysFkCoaTransH { get; set; }
        public decimal SysFkTransHlinkTransH { get; set; }
        public decimal SysFkInChargeTransH { get; set; }
        public decimal SysFkInCharge2TransH { get; set; }
        public decimal SysFkInvtyTransH { get; set; }
        public short? SysSeqTransH { get; set; }
        public int? UserSeqTransH { get; set; }
        public string UserPkTransH { get; set; }
        public string UserFkBranchTransH { get; set; }
        public string UserFkAccountTransH { get; set; }
        public string UserPkseqTransH { get; set; }
        public string LastUpdatedByTransH { get; set; }
        public short? LastUpdatedConcurrencyIdTransH { get; set; }
        public DateTime? LastUpdatedDateTransH { get; set; }
        public short? LastPrintCountTransH { get; set; }
        public string LastPrintByTransH { get; set; }
        public string AccountBillingParticularsTransH { get; set; }
        public string AccountCodeTransH { get; set; }
        public string AccountCodeGovtTransH { get; set; }
        public string AccountContactPersonAndPositionTransH { get; set; }
        public string AccountDeliveryParticularsTransH { get; set; }
        public string AccountDocumentByTransH { get; set; }
        public string AccountDocumentNumTranH { get; set; }
        public string AccountNameTransH { get; set; }
        public string AccountPayeeNameTransH { get; set; }
        public string ApprovedByTransH { get; set; }
        public string AreaTransH { get; set; }
        public string CancelledByTransH { get; set; }
        public string CheckedByTransH { get; set; }
        public DateTime? DateAccountDocumentTranH { get; set; }
        public DateTime? DateAgingStartTransH { get; set; }
        public DateTime? DateAppliedTransH { get; set; }
        public DateTime? DateIssueTransH { get; set; }
        public DateTime? DateTimeIssueTransH { get; set; }
        public DateTime? DateLastBatchProcessedTransH { get; set; }
        public string DiscountTransH { get; set; }
        public string ForeignSignTransH { get; set; }
        public decimal? ForeignConversionRateTransH { get; set; }
        public string FootNoteTransH { get; set; }
        public string InChargedByTransH { get; set; }
        public string IsPrintOutReturnedTransH { get; set; }
        public string IsVariousAccountsTransH { get; set; }
        public string ModuleTransH { get; set; }
        public string ModuleJournalTransH { get; set; }
        public string ModuleMasterfileTransH { get; set; }
        public string ModuleSubTypeTransH { get; set; }
        public string ModuleTransTransH { get; set; }
        public string ModuleTypeTransH { get; set; }
        public string ModuleUserPkTransH { get; set; }
        public string ParticularsTransH { get; set; }
        public string PreparedByTransH { get; set; }
        public string PreparedByDutyShiftTransH { get; set; }
        public string PrintedByTransH { get; set; }
        public string PostedByTransH { get; set; }
        public string StatusAccountAsOfIssueDateTransH { get; set; }
        public int? SequencePkTransH { get; set; }
        public decimal? TotalAmountTransH { get; set; }
        public decimal? TotalAmountForeignTransH { get; set; }
        public decimal? TotalAmountAccountDocumentTransH { get; set; }
        public decimal? TotalEntriesTransH { get; set; }
        public string TypeAccountAsOfIssueDateTransH { get; set; }
        public string TypeMasterfileAsOfIssueDateTransH { get; set; }
        public string VoidedByTransH { get; set; }
        public string TypeTransH { get; set; }
        public string StatusTransH { get; set; }
        public string UserFkGenericClassTransH { get; set; }
        public string AdvanceOrderNumTransH { get; set; }
        public string AccountDocumenTelNumTranH { get; set; }
        public string StubNoTransH { get; set; }
        public DateTime? StubDateGeneratedTransH { get; set; }
        public string StubClassificationTransH { get; set; }
        public string StubSeriesTransH { get; set; }
        public short? ExcludeInSalesReportTransH { get; set; }
        public string SalesReportGroupTransH { get; set; }
        public string SalesReportOrderTransH { get; set; }
        public string VoidedTransH { get; set; }
        public string PostedTransH { get; set; }

        public virtual UniversalMaster2 SysFkAccountTransHNavigation { get; set; }
        public virtual ICollection<TransactionLedgerEntries> TransactionLedgerEntries { get; set; }
        public virtual ICollection<TransactionLedgerInvty> TransactionLedgerInvty { get; set; }
    }
}

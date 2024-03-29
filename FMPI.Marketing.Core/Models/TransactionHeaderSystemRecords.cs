﻿using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderSystemRecords
    {
        public decimal CbdTransH { get; set; }
        public decimal SysPkTransH { get; set; }
        public decimal SysFkAccountTransH { get; set; }
        public decimal SysFkAccountDocumentAccountTransH { get; set; }
        public decimal SysFkAccountDocumentTransHTransH { get; set; }
        public decimal SysFkBatchTransHTransH { get; set; }
        public decimal SysFkInChargeTransH { get; set; }
        public decimal SysFkSourceDocumentTransH { get; set; }
        public decimal SysFkLedgerTransHTransH { get; set; }
        public decimal SysFkJournalTransH { get; set; }
        public short? SysSeqTransH { get; set; }
        public string AccountDocumentByTransH { get; set; }
        public string ApprovedByTransH { get; set; }
        public string AreaTransH { get; set; }
        public string InChargedByTransH { get; set; }
        public string CancelledByTransH { get; set; }
        public string CheckedByTransH { get; set; }
        public string EnterprisePolicyTransH { get; set; }
        public string PreparedByTransH { get; set; }
        public string PostedByTransH { get; set; }
        public string VoidedByTransH { get; set; }
        public string UserPkTransH { get; set; }
        public string UserPkprefixTransH { get; set; }
        public string UserPkseqTransH { get; set; }
        public string UserPksuffixTransH { get; set; }
        public string UserPkgovtTransH { get; set; }
        public string UserPkjournalTransH { get; set; }
        public string UserPktypeTransH { get; set; }
        public int? UserSeqTransH { get; set; }
        public short? LastUpdatedConcurrencyIdTransH { get; set; }
        public DateTime? LastUpdatedDateTransH { get; set; }
        public string LastUpdatedByTransH { get; set; }
        public decimal? AccumulatedDueClrTransH { get; set; }
        public decimal? AccumulatedPayClrTransH { get; set; }
        public decimal? AccumulatedBalClrTransH { get; set; }
        public decimal? AccumulatedDueUnClrTransH { get; set; }
        public decimal? AccumulatedPayUnClrTransH { get; set; }
        public decimal? AccumulatedBalUnClrTransH { get; set; }
        public decimal? AccumulatedRemainingProcessedTransH { get; set; }
        public decimal? AccumulatedUsualDueTransH { get; set; }
        public string AccountDocumentNumTranH { get; set; }
        public int? AccountTransactionCountTranH { get; set; }
        public string AccountCodeTransH { get; set; }
        public string AccountCodeGovtTransH { get; set; }
        public string AccountNameTransH { get; set; }
        public string AccountContactPersonAndPositionTransH { get; set; }
        public short? AccountConfidentialityLevelTransH { get; set; }
        public decimal? AccountCreditLineAsOfDateIssueTransH { get; set; }
        public string AccountBillingParticularsTransH { get; set; }
        public string AccountDeliveryParticularsTransH { get; set; }
        public DateTime? DateAccountDocumentTranH { get; set; }
        public DateTime? DateAppliedTransH { get; set; }
        public DateTime? DateFirstDuePrincipalTransH { get; set; }
        public DateTime? DateFirstDueInterestTransH { get; set; }
        public DateTime? DateFullyPaidTransH { get; set; }
        public DateTime? DateIdealDueTransH { get; set; }
        public DateTime? DateAgingStartTransH { get; set; }
        public DateTime? DateIssueTransH { get; set; }
        public DateTime? DateLastBatchProcessedTransH { get; set; }
        public string FootNoteTransH { get; set; }
        public string HowPostedTransH { get; set; }
        public string HeaderDetailTransH { get; set; }
        public decimal? InterestDueClrTransH { get; set; }
        public decimal? InterestPayClrTransH { get; set; }
        public decimal? InterestDueUnClrTransH { get; set; }
        public decimal? InterestPayUnClrTransH { get; set; }
        public decimal? InterestRemainingProcessedTransH { get; set; }
        public decimal? InterestUsualDueTransH { get; set; }
        public string InterestDueEveryTransH { get; set; }
        public string InterestMethodTransH { get; set; }
        public string InterestPostingTransH { get; set; }
        public string InterestTermsInUseTransH { get; set; }
        public short? InterestTermsInstallmentsTransH { get; set; }
        public string InterestTermsDisplayedTransH { get; set; }
        public decimal? InterestMonthlyRateTransH { get; set; }
        public string IsTemporaryNoBilling { get; set; }
        public string IsPrintOutReturnedTransH { get; set; }
        public string IsVariousAccountsTransH { get; set; }
        public decimal? MiscDueClrTransH { get; set; }
        public decimal? MiscPayClrTransH { get; set; }
        public decimal? MiscDueUnClrTransH { get; set; }
        public decimal? MiscPayUnClrTransH { get; set; }
        public decimal? MiscRemainingProcessedTransH { get; set; }
        public decimal? MiscUsualDueTransH { get; set; }
        public string ModuleTransH { get; set; }
        public string ModuleLinkTransH { get; set; }
        public string ModuleTransTransH { get; set; }
        public string ModuleTypeTransH { get; set; }
        public string ModuleSubTypeTransH { get; set; }
        public string ModuleJournalTransH { get; set; }
        public string ModuleLedgerTransH { get; set; }
        public decimal? OtherAmountQtyTransH { get; set; }
        public decimal? OtherAmountPerUnitTransH { get; set; }
        public string ParticularsTransH { get; set; }
        public decimal? PenaltyDueClrTransH { get; set; }
        public decimal? PenaltyPayClrTransH { get; set; }
        public decimal? PenaltyDueUnClrTransH { get; set; }
        public decimal? PenaltyPayUnClrTransH { get; set; }
        public decimal? PenaltyRemainingProcessedTransH { get; set; }
        public decimal? PenaltyMonthlyRateTransH { get; set; }
        public decimal? PenaltyUsualDueTransH { get; set; }
        public decimal? PrincipalDueClrTransH { get; set; }
        public decimal? PrincipalPayClrTransH { get; set; }
        public decimal? PrincipalDueUnClrTransH { get; set; }
        public decimal? PrincipalPayUnClrTransH { get; set; }
        public decimal? PrincipalRemainingProcessedTransH { get; set; }
        public short? PrincipalTermsInstallmentsTransH { get; set; }
        public decimal? PrincipalUsualDueTransH { get; set; }
        public string PrincipalTermsInUseTransH { get; set; }
        public string PrincipalTermsDisplayedTransH { get; set; }
        public string PrincipalDueEveryTransH { get; set; }
        public decimal? PaymentPriorityTransH { get; set; }
        public string StatusAccountAsOfIssueDateTransH { get; set; }
        public string StatusTransactionTransH { get; set; }
        public string SourceDocumentModuleTransH { get; set; }
        public string SourceDocumentModuleTransTransH { get; set; }
        public string SourceDocumentModuleTypeTransH { get; set; }
        public string SourceDocumentModuleSubTypeTransH { get; set; }
        public string SourceDocumentModuleJournalTransH { get; set; }
        public string SourceDocumentModuleLedgerTransH { get; set; }
        public string SourceDocumentUserPkTransH { get; set; }
        public DateTime? SourceDocumentDateIssueTransH { get; set; }
        public string SourceDocumentAccountDocumentNumTranH { get; set; }
        public DateTime? SourceDocumentDateAccountDocumentTranH { get; set; }
        public decimal? TotalDueClrTransH { get; set; }
        public decimal? TotalPayClrTransH { get; set; }
        public decimal? TotalDueUnClrTransH { get; set; }
        public decimal? TotalPayUnClrTransH { get; set; }
        public decimal? TotalRemainingProcessedTransH { get; set; }
        public decimal? TotalUsualDueTransH { get; set; }
        public string TotalPastTransactionPaymentsTransH { get; set; }
        public decimal? TotalEntriesTransH { get; set; }
        public decimal? TotalAmountAccountDocumentTransH { get; set; }
        public string TypeTransactionTransH { get; set; }
        public string TypeMasterfileAsOfIssueDateTransH { get; set; }
        public string TypeAccountAsOfIssueDateTransH { get; set; }
        public string PrintedByTransH { get; set; }
        public string EdilinkTransH { get; set; }
        public decimal? SysFkEdiTransH { get; set; }
        public decimal? SysFkModuleTransH { get; set; }
        public decimal? AccumulatedUsualDuePrincipalTransH { get; set; }
        public decimal? AccumulatedUsualDueInterestTransH { get; set; }
        public decimal? AccumulatedUsualDuePenaltyTransH { get; set; }
        public decimal? AccumulatedUsualDueMiscTransH { get; set; }
        public string SourceDocumentUserPkgovtTransH { get; set; }
        public DateTime? DateNextDueInterestTransH { get; set; }
        public DateTime? DateNextDuePrincipalTransH { get; set; }
        public DateTime? DateNextDuePenaltyTransH { get; set; }
        public DateTime? DateNextDueMiscTransH { get; set; }
        public decimal? AccumulatedPrincipalRemainingProcessedTransH { get; set; }
        public decimal? AccumulatedInterestRemainingProcessedTransH { get; set; }
        public decimal? AccumulatedPenaltyRemainingProcessedTransH { get; set; }
        public decimal? AccumulatedMiscRemainingProcessedTransH { get; set; }
        public string ValidatePkTrasH { get; set; }
        public string SourceDocumentAccountDocumentByTransH { get; set; }
        public string SalesPurchTypeTransH { get; set; }
        public string SequencePkTransH { get; set; }
    }
}

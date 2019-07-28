using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class CoaMaster2
    {
        public CoaMaster2()
        {
            TransactionLedgerEntries = new HashSet<TransactionLedgerEntries>();
        }

        public string ProphetCoa { get; set; }
        public decimal CbdCoa { get; set; }
        public decimal SysPkCoa { get; set; }
        public decimal SysFkCoactrlAcctCoa { get; set; }
        public decimal SysFkInvtySlCoa { get; set; }
        public decimal SysFkUmslCoa { get; set; }
        public decimal SysFkSlaccountCoa { get; set; }
        public decimal SysFkSlinventoryCoa { get; set; }
        public decimal SysFkTypeCoa { get; set; }
        public string UserPkCoa { get; set; }
        public string UserPkSlaccountCoa { get; set; }
        public string UserPkSlinventoryCoa { get; set; }
        public string UserPktypeCoa { get; set; }
        public string UserFkPsbkCoa { get; set; }
        public string LastUpdatedByCoa { get; set; }
        public short? LastUpdatedConcurrencyIdCoa { get; set; }
        public DateTime? LastUpdatedDateCoa { get; set; }
        public byte? AcctTitleDefinitionCoa { get; set; }
        public byte? AcctTypeCoa { get; set; }
        public byte? AcctUsedAsCoa { get; set; }
        public int? AddIfSideCoa { get; set; }
        public string ApbcolHeaderCoa { get; set; }
        public byte? ApbcolNumCoa { get; set; }
        public string ApbcolNumSideCoa { get; set; }
        public byte? ArchiveCoa { get; set; }
        public byte? BalanceSheetAcctCoa { get; set; }
        public string BalanceSheetGroupCoa { get; set; }
        public short? BalanceSheetSortCoa { get; set; }
        public byte? CashFlowAcctCoa { get; set; }
        public string CashFlowGroupCoa { get; set; }
        public string CdbcolHeaderCoa { get; set; }
        public byte? CdbcolNumCoa { get; set; }
        public string CdbcolNumSideCoa { get; set; }
        public short? ClassCoa { get; set; }
        public string ClassDashCoa { get; set; }
        public string ClassFormatCoa { get; set; }
        public string ClassParticularsCoa { get; set; }
        public byte? ContraAccountCoa { get; set; }
        public short? ControllingAcctCoa { get; set; }
        public string ControllingDashCoa { get; set; }
        public string ControllingFormatCoa { get; set; }
        public string ControllingParticularsCoa { get; set; }
        public string CrbcolHeaderCoa { get; set; }
        public byte? CrbcolNumCoa { get; set; }
        public string CrbcolNumSideCoa { get; set; }
        public DateTime? DateBalFwdCoa { get; set; }
        public DateTime? DefinedDateCoa { get; set; }
        public string DescriptionCoa { get; set; }
        public short? FsgroupSortCoa { get; set; }
        public string EntryForCoa { get; set; }
        public short? HasCoaslCoa { get; set; }
        public short? HasInvtySlCoa { get; set; }
        public short? HasUmslCoa { get; set; }
        public byte? InActiveCoa { get; set; }
        public byte? IncomeStatementAcctCoa { get; set; }
        public string IncomeStatementGroupCoa { get; set; }
        public short? IncomeStatementSortCoa { get; set; }
        public short? IsControllingCoa { get; set; }
        public short? IsPassbookCoa { get; set; }
        public short? IsSubsidiaryCoa { get; set; }
        public short? IsSubClassCoa { get; set; }
        public short? IsTransNumRequiredCoa { get; set; }
        public string JbcolHeaderCoa { get; set; }
        public byte? JbcolNumCoa { get; set; }
        public string JbcolNumSideCoa { get; set; }
        public string JournalSummaryColHeaderCoa { get; set; }
        public string ModuleTransLedgerEntriesCoa { get; set; }
        public string MstrTypeDefaultCoa { get; set; }
        public short? MstrCbddefaultCoa { get; set; }
        public string MstrManualDefaultCoa { get; set; }
        public int? MstrSgndefaultCoa { get; set; }
        public string ParticularsCoa { get; set; }
        public string ParticularsSlCoa { get; set; }
        public short? PrimarySubClassAcctCoa { get; set; }
        public string PrimarySubClassDashCoa { get; set; }
        public string PrimarySubClassFormatCoa { get; set; }
        public string PrimarySubClassParticularsCoa { get; set; }
        public byte? ReportClassParticularsCoa { get; set; }
        public byte? ReportControllingParticularsCoa { get; set; }
        public byte? ReportIndependentParticularsCoa { get; set; }
        public string ReportParticularsCoa { get; set; }
        public byte? ReportSubClassParticularsCoa { get; set; }
        public byte? ReportSubsidiaryParticularsCoa { get; set; }
        public string ReportSummaryParticularsCoa { get; set; }
        public string SbcolHeaderCoa { get; set; }
        public byte? SbcolNumCoa { get; set; }
        public string SbcolNumSideCoa { get; set; }
        public short? SecondarySubClassAcctCoa { get; set; }
        public string SecondarySubClassDashCoa { get; set; }
        public string SecondarySubClassFormatCoa { get; set; }
        public string SecondarySubClassParticularsCoa { get; set; }
        public string SidePositiveCoa { get; set; }
        public short? SlcbdCoa { get; set; }
        public string SllinkToCoa { get; set; }
        public int? SllinkMethodCoa { get; set; }
        public string SlmanualCoa { get; set; }
        public string SlmoduleLedgerCoa { get; set; }
        public int? SlsgnCoa { get; set; }
        public string SltypeCoa { get; set; }
        public byte? SourcesUsesFundAcctCoa { get; set; }
        public string SourcesUsesFundGroupCoa { get; set; }
        public string StatusCoa { get; set; }
        public short? SubClassCoa { get; set; }
        public string SubClassDashCoa { get; set; }
        public string SubClassFormatCoa { get; set; }
        public string SubClassParticularsCoa { get; set; }
        public short? SubsidiaryAcctCoa { get; set; }
        public string SubsidiaryDashCoa { get; set; }
        public string SubsidiaryFormatCoa { get; set; }
        public string SubsidiaryParticularsCoa { get; set; }
        public byte? TbsidePostiveCoa { get; set; }
        public short? TertiarySubClassAcctCoa { get; set; }
        public string TertiarySubClassDashCoa { get; set; }
        public string TertiarySubClassFormatCoa { get; set; }
        public string TertiarySubClassParticularsCoa { get; set; }
        public string TitleCoa { get; set; }
        public string TitleSpeakCoa { get; set; }
        public string TransNumPrefixCoa { get; set; }
        public string TypeCoa { get; set; }
        public string SubTypeCoa { get; set; }
        public byte? VoidCoa { get; set; }
        public decimal? SysFkFixedAssetsCoa { get; set; }
        public decimal? SysFkDepreciationExpenseCoa { get; set; }
        public decimal? SysFkDepreciationAccumulatedCoa { get; set; }
        public short? IsFixedAssetsCoa { get; set; }
        public short? IsDepreciationAccumulatedCoa { get; set; }
        public short? IsDepreciationExpenseCoa { get; set; }
        public string UserFkBranchCoa { get; set; }
        public short? ExcludeFromPatronageCoa { get; set; }

        public virtual ICollection<TransactionLedgerEntries> TransactionLedgerEntries { get; set; }
    }
}

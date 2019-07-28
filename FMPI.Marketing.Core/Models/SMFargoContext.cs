using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FMPI.Marketing.Core.Models
{
    public partial class SMFargoContext : DbContext
    {
        public SMFargoContext()
        {
        }

        public SMFargoContext(DbContextOptions<SMFargoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ATableTemplate> ATableTemplate { get; set; }
        public virtual DbSet<AnyTableJunction> AnyTableJunction { get; set; }
        public virtual DbSet<ButtonMaster> ButtonMaster { get; set; }
        public virtual DbSet<CbdMaster2> CbdMaster2 { get; set; }
        public virtual DbSet<CoaMaster2> CoaMaster2 { get; set; }
        public virtual DbSet<CoaMaster2Budget> CoaMaster2Budget { get; set; }
        public virtual DbSet<CoaMaster2System> CoaMaster2System { get; set; }
        public virtual DbSet<CoatypeMaster> CoatypeMaster { get; set; }
        public virtual DbSet<CoatypeMasterSystem> CoatypeMasterSystem { get; set; }
        public virtual DbSet<CreditInvestigationHeader> CreditInvestigationHeader { get; set; }
        public virtual DbSet<CreditInvestigationProperties> CreditInvestigationProperties { get; set; }
        public virtual DbSet<DeleteLogMaster> DeleteLogMaster { get; set; }
        public virtual DbSet<DeletedRecords> DeletedRecords { get; set; }
        public virtual DbSet<ElectionBallotDetails> ElectionBallotDetails { get; set; }
        public virtual DbSet<ElectionBallotHeader> ElectionBallotHeader { get; set; }
        public virtual DbSet<FacilityJunction> FacilityJunction { get; set; }
        public virtual DbSet<FacilityMaster> FacilityMaster { get; set; }
        public virtual DbSet<FacilityPrices> FacilityPrices { get; set; }
        public virtual DbSet<FranchiseMaster> FranchiseMaster { get; set; }
        public virtual DbSet<FranchiseSocioEconomic> FranchiseSocioEconomic { get; set; }
        public virtual DbSet<GenericClassMaster> GenericClassMaster { get; set; }
        public virtual DbSet<GuestRegistrationCompanions> GuestRegistrationCompanions { get; set; }
        public virtual DbSet<GuestRegistrationFacilities> GuestRegistrationFacilities { get; set; }
        public virtual DbSet<GuestRegistrationFaclBlocking> GuestRegistrationFaclBlocking { get; set; }
        public virtual DbSet<GuestRegistrationHeader> GuestRegistrationHeader { get; set; }
        public virtual DbSet<GuestTransactions> GuestTransactions { get; set; }
        public virtual DbSet<HolidayMaster> HolidayMaster { get; set; }
        public virtual DbSet<InventoryMaster2> InventoryMaster2 { get; set; }
        public virtual DbSet<InventoryMaster2Components> InventoryMaster2Components { get; set; }
        public virtual DbSet<InventoryMaster2Facilities> InventoryMaster2Facilities { get; set; }
        public virtual DbSet<InventoryMaster2FacilitiesPrices> InventoryMaster2FacilitiesPrices { get; set; }
        public virtual DbSet<InventoryMaster2MoreInfo> InventoryMaster2MoreInfo { get; set; }
        public virtual DbSet<InventoryMaster2Prices> InventoryMaster2Prices { get; set; }
        public virtual DbSet<InventoryMaster2Suppliers> InventoryMaster2Suppliers { get; set; }
        public virtual DbSet<InventoryMaster2Units> InventoryMaster2Units { get; set; }
        public virtual DbSet<InventoryMasterFixedAssets> InventoryMasterFixedAssets { get; set; }
        public virtual DbSet<InventoryMasterJunction> InventoryMasterJunction { get; set; }
        public virtual DbSet<ModifiedRecordsHistory> ModifiedRecordsHistory { get; set; }
        public virtual DbSet<PabxLog> PabxLog { get; set; }
        public virtual DbSet<PolicyMaster> PolicyMaster { get; set; }
        public virtual DbSet<PolicyMasterCustomer> PolicyMasterCustomer { get; set; }
        public virtual DbSet<PolicyMasterCustomerSupplier> PolicyMasterCustomerSupplier { get; set; }
        public virtual DbSet<PolicyMasterDisbursement> PolicyMasterDisbursement { get; set; }
        public virtual DbSet<PolicyMasterElection> PolicyMasterElection { get; set; }
        public virtual DbSet<PolicyMasterElectionCandidates> PolicyMasterElectionCandidates { get; set; }
        public virtual DbSet<PolicyMasterEmployee> PolicyMasterEmployee { get; set; }
        public virtual DbSet<PolicyMasterHotel> PolicyMasterHotel { get; set; }
        public virtual DbSet<PolicyMasterInventory> PolicyMasterInventory { get; set; }
        public virtual DbSet<PolicyMasterInventoryPrices> PolicyMasterInventoryPrices { get; set; }
        public virtual DbSet<PolicyMasterLoan> PolicyMasterLoan { get; set; }
        public virtual DbSet<PolicyMasterLoanAmort> PolicyMasterLoanAmort { get; set; }
        public virtual DbSet<PolicyMasterPayrollAmount> PolicyMasterPayrollAmount { get; set; }
        public virtual DbSet<PolicyMasterPayrollDeduction> PolicyMasterPayrollDeduction { get; set; }
        public virtual DbSet<PolicyMasterPayrollHoliday> PolicyMasterPayrollHoliday { get; set; }
        public virtual DbSet<PolicyMasterPayrollMemo> PolicyMasterPayrollMemo { get; set; }
        public virtual DbSet<PolicyMasterPayrollSalaryRate> PolicyMasterPayrollSalaryRate { get; set; }
        public virtual DbSet<PolicyMasterPayrollStandard> PolicyMasterPayrollStandard { get; set; }
        public virtual DbSet<PolicyMasterPayrollTableSystem> PolicyMasterPayrollTableSystem { get; set; }
        public virtual DbSet<PolicyMasterPayrollTables> PolicyMasterPayrollTables { get; set; }
        public virtual DbSet<PolicyMasterReport> PolicyMasterReport { get; set; }
        public virtual DbSet<PolicyMasterSalaryRate> PolicyMasterSalaryRate { get; set; }
        public virtual DbSet<PolicyMasterSales> PolicyMasterSales { get; set; }
        public virtual DbSet<PolicyMasterSupplier> PolicyMasterSupplier { get; set; }
        public virtual DbSet<PolicyMasterWorkShift> PolicyMasterWorkShift { get; set; }
        public virtual DbSet<ReportDetails> ReportDetails { get; set; }
        public virtual DbSet<ReportMaster> ReportMaster { get; set; }
        public virtual DbSet<SecurityLog> SecurityLog { get; set; }
        public virtual DbSet<SecurityModule> SecurityModule { get; set; }
        public virtual DbSet<SecurityPermissions> SecurityPermissions { get; set; }
        public virtual DbSet<SecurityRoleCommandButton> SecurityRoleCommandButton { get; set; }
        public virtual DbSet<SecurityRoleMaster> SecurityRoleMaster { get; set; }
        public virtual DbSet<SecurityRoleMenu> SecurityRoleMenu { get; set; }
        public virtual DbSet<SecurityTemporaryPermissions> SecurityTemporaryPermissions { get; set; }
        public virtual DbSet<SecurityUser> SecurityUser { get; set; }
        public virtual DbSet<SystemValuesMaster> SystemValuesMaster { get; set; }
        public virtual DbSet<TransactionAccountableCheck> TransactionAccountableCheck { get; set; }
        public virtual DbSet<TransactionAccountableNum> TransactionAccountableNum { get; set; }
        public virtual DbSet<TransactionGlEntries> TransactionGlEntries { get; set; }
        public virtual DbSet<TransactionGlEntriesExtended> TransactionGlEntriesExtended { get; set; }
        public virtual DbSet<TransactionHeader> TransactionHeader { get; set; }
        public virtual DbSet<TransactionHeaderAdjustment> TransactionHeaderAdjustment { get; set; }
        public virtual DbSet<TransactionHeaderAmortization> TransactionHeaderAmortization { get; set; }
        public virtual DbSet<TransactionHeaderAmounts> TransactionHeaderAmounts { get; set; }
        public virtual DbSet<TransactionHeaderChecks> TransactionHeaderChecks { get; set; }
        public virtual DbSet<TransactionHeaderCopra> TransactionHeaderCopra { get; set; }
        public virtual DbSet<TransactionHeaderCxi> TransactionHeaderCxi { get; set; }
        public virtual DbSet<TransactionHeaderDailyInvty> TransactionHeaderDailyInvty { get; set; }
        public virtual DbSet<TransactionHeaderGuarantor> TransactionHeaderGuarantor { get; set; }
        public virtual DbSet<TransactionHeaderGuestFolio> TransactionHeaderGuestFolio { get; set; }
        public virtual DbSet<TransactionHeaderJobs> TransactionHeaderJobs { get; set; }
        public virtual DbSet<TransactionHeaderJunction> TransactionHeaderJunction { get; set; }
        public virtual DbSet<TransactionHeaderLoans2> TransactionHeaderLoans2 { get; set; }
        public virtual DbSet<TransactionHeaderLoans2Amort> TransactionHeaderLoans2Amort { get; set; }
        public virtual DbSet<TransactionHeaderProcessingHistory> TransactionHeaderProcessingHistory { get; set; }
        public virtual DbSet<TransactionHeaderSalesFuel> TransactionHeaderSalesFuel { get; set; }
        public virtual DbSet<TransactionHeaderSalesPurch> TransactionHeaderSalesPurch { get; set; }
        public virtual DbSet<TransactionHeaderSalesPurchOrder> TransactionHeaderSalesPurchOrder { get; set; }
        public virtual DbSet<TransactionHeaderShipping> TransactionHeaderShipping { get; set; }
        public virtual DbSet<TransactionHeaderStockTransfer> TransactionHeaderStockTransfer { get; set; }
        public virtual DbSet<TransactionHeaderSystemRecords> TransactionHeaderSystemRecords { get; set; }
        public virtual DbSet<TransactionHeaderTelephoneVoucher> TransactionHeaderTelephoneVoucher { get; set; }
        public virtual DbSet<TransactionHeaderWithdrawalSlip> TransactionHeaderWithdrawalSlip { get; set; }
        public virtual DbSet<TransactionLedgerAdjustments> TransactionLedgerAdjustments { get; set; }
        public virtual DbSet<TransactionLedgerAmounts> TransactionLedgerAmounts { get; set; }
        public virtual DbSet<TransactionLedgerCollectorList> TransactionLedgerCollectorList { get; set; }
        public virtual DbSet<TransactionLedgerCopraContracts> TransactionLedgerCopraContracts { get; set; }
        public virtual DbSet<TransactionLedgerEntries> TransactionLedgerEntries { get; set; }
        public virtual DbSet<TransactionLedgerFixedAssets> TransactionLedgerFixedAssets { get; set; }
        public virtual DbSet<TransactionLedgerInvty> TransactionLedgerInvty { get; set; }
        public virtual DbSet<TransactionLedgerInvtyJunction> TransactionLedgerInvtyJunction { get; set; }
        public virtual DbSet<TransactionLedgerInvtyLog> TransactionLedgerInvtyLog { get; set; }
        public virtual DbSet<TransactionLedgerInvtySalesPurchOrd> TransactionLedgerInvtySalesPurchOrd { get; set; }
        public virtual DbSet<TransactionLedgerInvtySerials> TransactionLedgerInvtySerials { get; set; }
        public virtual DbSet<TransactionLedgerWslipDetail> TransactionLedgerWslipDetail { get; set; }
        public virtual DbSet<TransactionPayrollAmount> TransactionPayrollAmount { get; set; }
        public virtual DbSet<TransactionPayrollDeduction> TransactionPayrollDeduction { get; set; }
        public virtual DbSet<TransactionPayrollDtr> TransactionPayrollDtr { get; set; }
        public virtual DbSet<TransactionPayrollMemoLog> TransactionPayrollMemoLog { get; set; }
        public virtual DbSet<TransactionPayrollPaySlip> TransactionPayrollPaySlip { get; set; }
        public virtual DbSet<TransactionPayrollTimeSheet> TransactionPayrollTimeSheet { get; set; }
        public virtual DbSet<TransactionSalesQuote> TransactionSalesQuote { get; set; }
        public virtual DbSet<TransactionSalesQuoteDtl> TransactionSalesQuoteDtl { get; set; }
        public virtual DbSet<UnitConversionDetails> UnitConversionDetails { get; set; }
        public virtual DbSet<UnitConversionMaster> UnitConversionMaster { get; set; }
        public virtual DbSet<UniversalMaster2> UniversalMaster2 { get; set; }
        public virtual DbSet<UniversalMasterBalances> UniversalMasterBalances { get; set; }
        public virtual DbSet<UniversalMasterBank> UniversalMasterBank { get; set; }
        public virtual DbSet<UniversalMasterBorrower> UniversalMasterBorrower { get; set; }
        public virtual DbSet<UniversalMasterBusinessFinancial> UniversalMasterBusinessFinancial { get; set; }
        public virtual DbSet<UniversalMasterCampaign> UniversalMasterCampaign { get; set; }
        public virtual DbSet<UniversalMasterCustomer> UniversalMasterCustomer { get; set; }
        public virtual DbSet<UniversalMasterDefaults> UniversalMasterDefaults { get; set; }
        public virtual DbSet<UniversalMasterEmployee> UniversalMasterEmployee { get; set; }
        public virtual DbSet<UniversalMasterHris> UniversalMasterHris { get; set; }
        public virtual DbSet<UniversalMasterJunction> UniversalMasterJunction { get; set; }
        public virtual DbSet<UniversalMasterMembersGrossIncome> UniversalMasterMembersGrossIncome { get; set; }
        public virtual DbSet<UniversalMasterPersonalInfo> UniversalMasterPersonalInfo { get; set; }
        public virtual DbSet<UniversalMasterSupplier> UniversalMasterSupplier { get; set; }
        public virtual DbSet<UniversalMasterVotes> UniversalMasterVotes { get; set; }
        public virtual DbSet<ZzzFormMaster> ZzzFormMaster { get; set; }
        public virtual DbSet<ZzzFormMasterSystem> ZzzFormMasterSystem { get; set; }
        public virtual DbSet<ZzzGlobalOptions> ZzzGlobalOptions { get; set; }
        public virtual DbSet<ZzzHelpMaster> ZzzHelpMaster { get; set; }
        public virtual DbSet<ZzzModuleMaster> ZzzModuleMaster { get; set; }
        public virtual DbSet<ZzzModuleTypeMaster> ZzzModuleTypeMaster { get; set; }
        public virtual DbSet<ZzzPcstationMaster> ZzzPcstationMaster { get; set; }
        public virtual DbSet<ZzzProcessingHistory> ZzzProcessingHistory { get; set; }
        public virtual DbSet<ZzzQueries> ZzzQueries { get; set; }
        public virtual DbSet<ZzzQuotesMaster> ZzzQuotesMaster { get; set; }
        public virtual DbSet<ZzzStoredProc> ZzzStoredProc { get; set; }
        public virtual DbSet<ZzzSupportRequest> ZzzSupportRequest { get; set; }
        public virtual DbSet<ZzzTrainMaster> ZzzTrainMaster { get; set; }

        // Unable to generate entity type for table 'dbo.Transaction_Header_SO_Closed'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Transaction_HeaderCopy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sales_DDCubeSample'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FargoApplication'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FargoInterchange'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AnyTable_Junction1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FargoSysbacPrice'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Transaction_Ledger_EntriesCopy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.FargoSYSBACMasterlist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Transaction_Ledger_InvtyCopy'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COA_Master21'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SalesPurchSet1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Transaction_Ledger_Invty_deletedfields'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SalesPurchSet2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zzzSystemSettings'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zzzSequencePK_Master'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.A Last Install'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.A Last Updated 10-30-04'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo._A Notes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zzzTable_Master'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zzzUserPK_Master'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zzzUserPK_Missing'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SMFargo;Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SMFargoDb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<ATableTemplate>(entity =>
            {
                entity.HasKey(e => e.SysPkTableCode);

                entity.ToTable("A Table_Template");

                entity.HasIndex(e => e.SysFkTableCodeParentTableCode)
                    .HasName("IX_A Table_Template_1");

                entity.HasIndex(e => e.SysFkTableCodeTableCode)
                    .HasName("IX_A Table_Template");

                entity.HasIndex(e => e.UserPkTableCode)
                    .HasName("IX_A Table_Template_2");

                entity.Property(e => e.SysPkTableCode)
                    .HasColumnName("SysPK_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdTableCode)
                    .HasColumnName("CBD_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByTableCode)
                    .HasColumnName("LastUpdatedBy_TableCode")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTableCode).HasColumnName("LastUpdatedConcurrencyID_TableCode");

                entity.Property(e => e.LastUpdatedDateTableCode)
                    .HasColumnName("LastUpdatedDate_TableCode")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleTableCode)
                    .HasColumnName("Module_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsTableCode)
                    .HasColumnName("Particulars_TableCode")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameTableCode)
                    .HasColumnName("PictureFileName_TableCode")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusTableCode)
                    .HasColumnName("Status_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTableCodeParentTableCode)
                    .HasColumnName("SysFK_TableCodeParent_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTableCodeTableCode)
                    .HasColumnName("SysFK_TableCode_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTableCode)
                    .HasColumnName("SysSeq_TableCode")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TypeTableCode)
                    .HasColumnName("Type_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTableCode)
                    .HasColumnName("UserPK_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTableCode).HasColumnName("UserSeq_TableCode");
            });

            modelBuilder.Entity<AnyTableJunction>(entity =>
            {
                entity.HasKey(e => e.SysPkAnyJunc);

                entity.ToTable("AnyTable_Junction");

                entity.Property(e => e.SysPkAnyJunc)
                    .HasColumnName("SysPK_AnyJunc")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DescriptionAnyJunc)
                    .HasColumnName("Description_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.ExpressionAnyJunc)
                    .HasColumnName("Expression_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByAnyJunc)
                    .HasColumnName("LastUpdatedBy_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdAnyJunc).HasColumnName("LastUpdatedConcurrencyID_AnyJunc");

                entity.Property(e => e.LastUpdatedDateAnyJunc)
                    .HasColumnName("LastUpdatedDate_AnyJunc")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleAnyJunc)
                    .HasColumnName("Module_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.ModuleTypeAnyJunc)
                    .HasColumnName("ModuleType_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.ParticularsAnyJunc)
                    .HasColumnName("Particulars_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.PreferenceNumAnyJunc).HasColumnName("PreferenceNum_AnyJunc");

                entity.Property(e => e.SyFk1InvtyAnyJunc)
                    .HasColumnName("SyFK1_Invty_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SyFk1InvtyPriceAnyJunc)
                    .HasColumnName("SyFK1_InvtyPrice_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk1AnyTableAnyJunc)
                    .HasColumnName("SysFK1_AnyTable_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk1CbdAnyJunc)
                    .HasColumnName("SysFK1_CBD_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk1CoaAnyJunc)
                    .HasColumnName("SysFK1_COA_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk1TransHAnyJunc)
                    .HasColumnName("SysFK1_TransH_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk1UmAnyJunc)
                    .HasColumnName("SysFK1_UM_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk2AnyTableAnyJunc)
                    .HasColumnName("SysFK2_AnyTable_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk2CbdAnyJunc)
                    .HasColumnName("SysFK2_CBD_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk2CoaAnyJunc)
                    .HasColumnName("SysFK2_COA_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk2InvtyAnyJunc)
                    .HasColumnName("SysFK2_Invty_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk2InvtyPriceAnyJunc)
                    .HasColumnName("SysFK2_InvtyPrice_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk2TransHAnyJunc)
                    .HasColumnName("SysFK2_TransH_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysFk2UmAnyJunc)
                    .HasColumnName("SysFK2_UM_AnyJunc")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqAnyJunc).HasColumnName("SysSeq_AnyJunc");

                entity.Property(e => e.TableCodeAnyJunc)
                    .HasColumnName("TableCode_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeAcctConcatenatedAnyJunc)
                    .HasColumnName("TypeAcctConcatenated_AnyJunc")
                    .HasMaxLength(255);

                entity.Property(e => e.UserPkAnyJunc)
                    .HasColumnName("UserPK_AnyJunc")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqAnyJunc).HasColumnName("UserSeq_AnyJunc");
            });

            modelBuilder.Entity<ButtonMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkBtnMstr);

                entity.ToTable("Button_Master");

                entity.Property(e => e.SysPkBtnMstr)
                    .HasColumnName("SysPK_BtnMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CaptionBtnMstr)
                    .HasColumnName("Caption_BtnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.Color2BtnMstr).HasColumnName("Color2_BtnMstr");

                entity.Property(e => e.ColorBtnMstr).HasColumnName("Color_BtnMstr");

                entity.Property(e => e.DescriptionBtnMstr)
                    .HasColumnName("Description_BtnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.FormControlNameBtnMstr)
                    .HasColumnName("FormControlName_BtnMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByBtnMstr)
                    .HasColumnName("LastUpdatedBy_BtnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdBtnMstr).HasColumnName("LastUpdatedConcurrencyID_BtnMstr");

                entity.Property(e => e.LastUpdatedDateBtnMstr)
                    .HasColumnName("LastUpdatedDate_BtnMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MenuCaptionBtnMstr)
                    .HasColumnName("MenuCaption_BtnMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleBtnMstr)
                    .HasColumnName("Module_BtnMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.PathFileNameBtnMstr)
                    .HasColumnName("PathFileName_BtnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameBtnMstr)
                    .HasColumnName("PictureFileName_BtnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.ToolTipTextBtnMstr)
                    .HasColumnName("ToolTipText_BtnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.UserPkBtnMstr)
                    .HasColumnName("UserPK_BtnMstr")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CbdMaster2>(entity =>
            {
                entity.HasKey(e => e.SysPkCbd);

                entity.ToTable("CBD_Master2");

                entity.HasIndex(e => e.UserPkCbd)
                    .HasName("IX_CBD_Master2");

                entity.Property(e => e.SysPkCbd)
                    .HasColumnName("SysPK_CBD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BranchCbd)
                    .HasColumnName("Branch_CBD")
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyCbd)
                    .HasColumnName("Company_CBD")
                    .HasMaxLength(50);

                entity.Property(e => e.DeptCbd)
                    .HasColumnName("Dept_CBD")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByCbd)
                    .HasColumnName("LastUpdatedBy_CBD")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCbd)
                    .HasColumnName("LastUpdatedConcurrencyID_CBD")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCbd)
                    .HasColumnName("LastUpdatedDate_CBD")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticularsCbd)
                    .HasColumnName("Particulars_CBD")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportAddressCbd)
                    .HasColumnName("ReportAddress_CBD")
                    .HasMaxLength(100);

                entity.Property(e => e.ReportAdvertisementCbd)
                    .HasColumnName("ReportAdvertisement_CBD")
                    .HasMaxLength(100);

                entity.Property(e => e.ReportCompanyNameCbd)
                    .HasColumnName("ReportCompanyName_CBD")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPkCbd)
                    .HasColumnName("UserPK_CBD")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktypeCbd)
                    .HasColumnName("UserPKType_CBD")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CoaMaster2>(entity =>
            {
                entity.HasKey(e => e.SysPkCoa);

                entity.ToTable("COA_Master2");

                entity.HasIndex(e => e.AddIfSideCoa)
                    .HasName("IX_COA_Master2_9");

                entity.HasIndex(e => e.BalanceSheetGroupCoa)
                    .HasName("IX_COA_Master2_10");

                entity.HasIndex(e => e.CashFlowGroupCoa)
                    .HasName("IX_COA_Master2_11");

                entity.HasIndex(e => e.CbdCoa)
                    .HasName("IX_COA_Master2");

                entity.HasIndex(e => e.ClassParticularsCoa)
                    .HasName("IX_COA_Master2_12");

                entity.HasIndex(e => e.IncomeStatementGroupCoa)
                    .HasName("IX_COA_Master2_13");

                entity.HasIndex(e => e.SidePositiveCoa)
                    .HasName("IX_COA_Master2_19");

                entity.HasIndex(e => e.SysFkCoactrlAcctCoa)
                    .HasName("IX_COA_Master2_1");

                entity.HasIndex(e => e.SysFkDepreciationAccumulatedCoa)
                    .HasName("IX_COA_Master2_17");

                entity.HasIndex(e => e.SysFkDepreciationExpenseCoa)
                    .HasName("IX_COA_Master2_16");

                entity.HasIndex(e => e.SysFkFixedAssetsCoa)
                    .HasName("IX_COA_Master2_15");

                entity.HasIndex(e => e.SysFkInvtySlCoa)
                    .HasName("IX_COA_Master2_2");

                entity.HasIndex(e => e.SysFkSlaccountCoa)
                    .HasName("IX_COA_Master2_4");

                entity.HasIndex(e => e.SysFkSlinventoryCoa)
                    .HasName("IX_COA_Master2_5");

                entity.HasIndex(e => e.SysFkTypeCoa)
                    .HasName("IX_COA_Master2_6");

                entity.HasIndex(e => e.SysFkUmslCoa)
                    .HasName("IX_COA_Master2_3");

                entity.HasIndex(e => e.TitleCoa)
                    .HasName("IX_COA_Master2_8");

                entity.HasIndex(e => e.TypeCoa)
                    .HasName("IX_COA_Master2_14");

                entity.HasIndex(e => e.UserFkBranchCoa)
                    .HasName("IX_COA_Master2_18");

                entity.HasIndex(e => e.UserPkCoa)
                    .HasName("IX_COA_Master2_7");

                entity.Property(e => e.SysPkCoa)
                    .HasColumnName("SysPK_COA")
                    .HasColumnType("money");

                entity.Property(e => e.AcctTitleDefinitionCoa).HasColumnName("AcctTitleDefinition_COA");

                entity.Property(e => e.AcctTypeCoa).HasColumnName("AcctType_COA");

                entity.Property(e => e.AcctUsedAsCoa).HasColumnName("AcctUsedAs_COA");

                entity.Property(e => e.AddIfSideCoa).HasColumnName("AddIfSide_COA");

                entity.Property(e => e.ApbcolHeaderCoa)
                    .HasColumnName("APBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ApbcolNumCoa).HasColumnName("APBColNum_COA");

                entity.Property(e => e.ApbcolNumSideCoa)
                    .HasColumnName("APBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ArchiveCoa).HasColumnName("Archive_COA");

                entity.Property(e => e.BalanceSheetAcctCoa).HasColumnName("BalanceSheetAcct_COA");

                entity.Property(e => e.BalanceSheetGroupCoa)
                    .HasColumnName("BalanceSheetGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceSheetSortCoa).HasColumnName("BalanceSheetSort_COA");

                entity.Property(e => e.CashFlowAcctCoa).HasColumnName("CashFlowAcct_COA");

                entity.Property(e => e.CashFlowGroupCoa)
                    .HasColumnName("CashFlowGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdCoa)
                    .HasColumnName("CBD_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CdbcolHeaderCoa)
                    .HasColumnName("CDBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.CdbcolNumCoa).HasColumnName("CDBColNum_COA");

                entity.Property(e => e.CdbcolNumSideCoa)
                    .HasColumnName("CDBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassCoa).HasColumnName("Class_COA");

                entity.Property(e => e.ClassDashCoa)
                    .HasColumnName("ClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.ClassFormatCoa)
                    .HasColumnName("ClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassParticularsCoa)
                    .HasColumnName("ClassParticulars_COA")
                    .HasMaxLength(40);

                entity.Property(e => e.ContraAccountCoa).HasColumnName("ContraAccount_COA");

                entity.Property(e => e.ControllingAcctCoa).HasColumnName("ControllingAcct_COA");

                entity.Property(e => e.ControllingDashCoa)
                    .HasColumnName("ControllingDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.ControllingFormatCoa)
                    .HasColumnName("ControllingFormat_COA")
                    .HasMaxLength(40);

                entity.Property(e => e.ControllingParticularsCoa)
                    .HasColumnName("ControllingParticulars_COA")
                    .HasMaxLength(40);

                entity.Property(e => e.CrbcolHeaderCoa)
                    .HasColumnName("CRBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.CrbcolNumCoa).HasColumnName("CRBColNum_COA");

                entity.Property(e => e.CrbcolNumSideCoa)
                    .HasColumnName("CRBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.DateBalFwdCoa)
                    .HasColumnName("DateBalFwd_COA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DefinedDateCoa)
                    .HasColumnName("DefinedDate_COA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DescriptionCoa)
                    .HasColumnName("Description_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.EntryForCoa)
                    .HasColumnName("EntryFor_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ExcludeFromPatronageCoa)
                    .HasColumnName("ExcludeFromPatronage_COA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FsgroupSortCoa).HasColumnName("FSGroupSort_COA");

                entity.Property(e => e.HasCoaslCoa).HasColumnName("HasCOASL_COA");

                entity.Property(e => e.HasInvtySlCoa).HasColumnName("HasInvtySL_COA");

                entity.Property(e => e.HasUmslCoa).HasColumnName("HasUMSL_COA");

                entity.Property(e => e.InActiveCoa).HasColumnName("InActive_COA");

                entity.Property(e => e.IncomeStatementAcctCoa).HasColumnName("IncomeStatementAcct_COA");

                entity.Property(e => e.IncomeStatementGroupCoa)
                    .HasColumnName("IncomeStatementGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.IncomeStatementSortCoa).HasColumnName("IncomeStatementSort_COA");

                entity.Property(e => e.IsControllingCoa).HasColumnName("IsControlling_COA");

                entity.Property(e => e.IsDepreciationAccumulatedCoa).HasColumnName("IsDepreciationAccumulated_COA");

                entity.Property(e => e.IsDepreciationExpenseCoa).HasColumnName("IsDepreciationExpense_COA");

                entity.Property(e => e.IsFixedAssetsCoa).HasColumnName("IsFixedAssets_COA");

                entity.Property(e => e.IsPassbookCoa).HasColumnName("IsPassbook_COA");

                entity.Property(e => e.IsSubClassCoa).HasColumnName("IsSubClass_COA");

                entity.Property(e => e.IsSubsidiaryCoa).HasColumnName("IsSubsidiary_COA");

                entity.Property(e => e.IsTransNumRequiredCoa).HasColumnName("IsTransNumRequired_COA");

                entity.Property(e => e.JbcolHeaderCoa)
                    .HasColumnName("JBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.JbcolNumCoa).HasColumnName("JBColNum_COA");

                entity.Property(e => e.JbcolNumSideCoa)
                    .HasColumnName("JBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.JournalSummaryColHeaderCoa)
                    .HasColumnName("JournalSummaryColHeader_COA")
                    .HasMaxLength(15);

                entity.Property(e => e.LastUpdatedByCoa)
                    .HasColumnName("LastUpdatedBy_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCoa)
                    .HasColumnName("LastUpdatedConcurrencyID_COA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCoa)
                    .HasColumnName("LastUpdatedDate_COA")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTransLedgerEntriesCoa)
                    .HasColumnName("ModuleTransLedgerEntries_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.MstrCbddefaultCoa).HasColumnName("MstrCBDDefault_COA");

                entity.Property(e => e.MstrManualDefaultCoa)
                    .HasColumnName("MstrManualDefault_COA")
                    .HasMaxLength(20);

                entity.Property(e => e.MstrSgndefaultCoa).HasColumnName("MstrSGNDefault_COA");

                entity.Property(e => e.MstrTypeDefaultCoa)
                    .HasColumnName("MstrTypeDefault_COA")
                    .HasMaxLength(5);

                entity.Property(e => e.ParticularsCoa)
                    .HasColumnName("Particulars_COA")
                    .HasMaxLength(100);

                entity.Property(e => e.ParticularsSlCoa)
                    .HasColumnName("ParticularsSL_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimarySubClassAcctCoa).HasColumnName("PrimarySubClassAcct_COA");

                entity.Property(e => e.PrimarySubClassDashCoa)
                    .HasColumnName("PrimarySubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.PrimarySubClassFormatCoa)
                    .HasColumnName("PrimarySubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimarySubClassParticularsCoa)
                    .HasColumnName("PrimarySubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ProphetCoa)
                    .HasColumnName("Prophet_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportClassParticularsCoa).HasColumnName("ReportClassParticulars_COA");

                entity.Property(e => e.ReportControllingParticularsCoa).HasColumnName("ReportControllingParticulars_COA");

                entity.Property(e => e.ReportIndependentParticularsCoa).HasColumnName("ReportIndependentParticulars_COA");

                entity.Property(e => e.ReportParticularsCoa)
                    .HasColumnName("ReportParticulars_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportSubClassParticularsCoa).HasColumnName("ReportSubClassParticulars_COA");

                entity.Property(e => e.ReportSubsidiaryParticularsCoa).HasColumnName("ReportSubsidiaryParticulars_COA");

                entity.Property(e => e.ReportSummaryParticularsCoa)
                    .HasColumnName("ReportSummaryParticulars_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.SbcolHeaderCoa)
                    .HasColumnName("SBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SbcolNumCoa).HasColumnName("SBColNum_COA");

                entity.Property(e => e.SbcolNumSideCoa)
                    .HasColumnName("SBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SecondarySubClassAcctCoa).HasColumnName("SecondarySubClassAcct_COA");

                entity.Property(e => e.SecondarySubClassDashCoa)
                    .HasColumnName("SecondarySubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.SecondarySubClassFormatCoa)
                    .HasColumnName("SecondarySubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SecondarySubClassParticularsCoa)
                    .HasColumnName("SecondarySubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SidePositiveCoa)
                    .HasColumnName("SidePositive_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SlcbdCoa).HasColumnName("SLCBD_COA");

                entity.Property(e => e.SllinkMethodCoa).HasColumnName("SLLinkMethod_COA");

                entity.Property(e => e.SllinkToCoa)
                    .HasColumnName("SLLinkTo_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SlmanualCoa)
                    .HasColumnName("SLManual_COA")
                    .HasMaxLength(10);

                entity.Property(e => e.SlmoduleLedgerCoa)
                    .HasColumnName("SLModuleLedger_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SlsgnCoa).HasColumnName("SLSGN_COA");

                entity.Property(e => e.SltypeCoa)
                    .HasColumnName("SLType_COA")
                    .HasMaxLength(20);

                entity.Property(e => e.SourcesUsesFundAcctCoa).HasColumnName("SourcesUsesFundAcct_COA");

                entity.Property(e => e.SourcesUsesFundGroupCoa)
                    .HasColumnName("SourcesUsesFundGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusCoa)
                    .HasColumnName("Status_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubClassCoa).HasColumnName("SubClass_COA");

                entity.Property(e => e.SubClassDashCoa)
                    .HasColumnName("SubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.SubClassFormatCoa)
                    .HasColumnName("SubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubClassParticularsCoa)
                    .HasColumnName("SubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubTypeCoa)
                    .HasColumnName("SubType_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubsidiaryAcctCoa).HasColumnName("SubsidiaryAcct_COA");

                entity.Property(e => e.SubsidiaryDashCoa)
                    .HasColumnName("SubsidiaryDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.SubsidiaryFormatCoa)
                    .HasColumnName("SubsidiaryFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubsidiaryParticularsCoa)
                    .HasColumnName("SubsidiaryParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoactrlAcctCoa)
                    .HasColumnName("SysFK_COACtrlAcct_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDepreciationAccumulatedCoa)
                    .HasColumnName("SysFK_DepreciationAccumulated_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDepreciationExpenseCoa)
                    .HasColumnName("SysFK_DepreciationExpense_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkFixedAssetsCoa)
                    .HasColumnName("SysFK_FixedAssets_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtySlCoa)
                    .HasColumnName("SysFK_InvtySL_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSlaccountCoa)
                    .HasColumnName("SysFK_SLAccount_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSlinventoryCoa)
                    .HasColumnName("SysFK_SLInventory_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTypeCoa)
                    .HasColumnName("SysFK_Type_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmslCoa)
                    .HasColumnName("SysFK_UMSL_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TbsidePostiveCoa).HasColumnName("TBSidePostive_COA");

                entity.Property(e => e.TertiarySubClassAcctCoa).HasColumnName("TertiarySubClassAcct_COA");

                entity.Property(e => e.TertiarySubClassDashCoa)
                    .HasColumnName("TertiarySubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.TertiarySubClassFormatCoa)
                    .HasColumnName("TertiarySubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.TertiarySubClassParticularsCoa)
                    .HasColumnName("TertiarySubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.TitleCoa)
                    .HasColumnName("Title_COA")
                    .HasMaxLength(100);

                entity.Property(e => e.TitleSpeakCoa)
                    .HasColumnName("TitleSpeak_COA")
                    .HasMaxLength(100);

                entity.Property(e => e.TransNumPrefixCoa)
                    .HasColumnName("TransNumPrefix_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeCoa)
                    .HasColumnName("Type_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkBranchCoa)
                    .HasColumnName("UserFK_Branch_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPsbkCoa)
                    .HasColumnName("UserFK_Psbk_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkCoa)
                    .HasColumnName("UserPK_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkSlaccountCoa)
                    .HasColumnName("UserPK_SLAccount_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkSlinventoryCoa)
                    .HasColumnName("UserPK_SLInventory_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktypeCoa)
                    .HasColumnName("UserPKType_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.VoidCoa).HasColumnName("Void_COA");
            });

            modelBuilder.Entity<CoaMaster2Budget>(entity =>
            {
                entity.HasKey(e => e.SysPkCoabdgt);

                entity.ToTable("COA_Master2_Budget");

                entity.Property(e => e.SysPkCoabdgt)
                    .HasColumnName("SysPK_COABdgt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountActualCoabdgt)
                    .HasColumnName("AmountActual_COABdgt")
                    .HasColumnType("money");

                entity.Property(e => e.AmountBudgetedCoabdgt)
                    .HasColumnName("AmountBudgeted_COABdgt")
                    .HasColumnType("money");

                entity.Property(e => e.DateFromCoabdgt)
                    .HasColumnName("DateFrom_COABdgt")
                    .HasMaxLength(50);

                entity.Property(e => e.DateToCoabdgt)
                    .HasColumnName("DateTo_COABdgt")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByCoabdgt)
                    .HasColumnName("LastUpdatedBy_COABdgt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCoabdgt)
                    .HasColumnName("LastUpdatedConcurrencyID_COABdgt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCoabdgt)
                    .HasColumnName("LastUpdatedDate_COABdgt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SysFkCoaCoabdgt)
                    .HasColumnName("SysFK_COA_COABdgt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqCoabdgt).HasColumnName("SysSeq_COABdgt");

                entity.Property(e => e.UserSeqCoabdgt).HasColumnName("UserSeq_COABdgt");
            });

            modelBuilder.Entity<CoaMaster2System>(entity =>
            {
                entity.HasKey(e => e.SysPkCoa);

                entity.ToTable("COA_Master2System");

                entity.Property(e => e.SysPkCoa)
                    .HasColumnName("SysPK_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AcctTitleDefinitionCoa).HasColumnName("AcctTitleDefinition_COA");

                entity.Property(e => e.AcctTypeCoa).HasColumnName("AcctType_COA");

                entity.Property(e => e.AcctUsedAsCoa).HasColumnName("AcctUsedAs_COA");

                entity.Property(e => e.AddIfSideCoa).HasColumnName("AddIfSide_COA");

                entity.Property(e => e.ApbcolHeaderCoa)
                    .HasColumnName("APBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ApbcolNumCoa).HasColumnName("APBColNum_COA");

                entity.Property(e => e.ApbcolNumSideCoa)
                    .HasColumnName("APBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ArchiveCoa).HasColumnName("Archive_COA");

                entity.Property(e => e.BalanceSheetAcctCoa).HasColumnName("BalanceSheetAcct_COA");

                entity.Property(e => e.BalanceSheetGroupCoa)
                    .HasColumnName("BalanceSheetGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceSheetSortCoa).HasColumnName("BalanceSheetSort_COA");

                entity.Property(e => e.CashFlowAcctCoa).HasColumnName("CashFlowAcct_COA");

                entity.Property(e => e.CashFlowGroupCoa)
                    .HasColumnName("CashFlowGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdCoa)
                    .HasColumnName("CBD_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CdbcolHeaderCoa)
                    .HasColumnName("CDBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.CdbcolNumCoa).HasColumnName("CDBColNum_COA");

                entity.Property(e => e.CdbcolNumSideCoa)
                    .HasColumnName("CDBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassCoa).HasColumnName("Class_COA");

                entity.Property(e => e.ClassDashCoa)
                    .HasColumnName("ClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.ClassFormatCoa)
                    .HasColumnName("ClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassParticularsCoa)
                    .HasColumnName("ClassParticulars_COA")
                    .HasMaxLength(40);

                entity.Property(e => e.ContraAccountCoa).HasColumnName("ContraAccount_COA");

                entity.Property(e => e.ControllingAcctCoa).HasColumnName("ControllingAcct_COA");

                entity.Property(e => e.ControllingDashCoa)
                    .HasColumnName("ControllingDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.ControllingFormatCoa)
                    .HasColumnName("ControllingFormat_COA")
                    .HasMaxLength(40);

                entity.Property(e => e.ControllingParticularsCoa)
                    .HasColumnName("ControllingParticulars_COA")
                    .HasMaxLength(40);

                entity.Property(e => e.CrbcolHeaderCoa)
                    .HasColumnName("CRBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.CrbcolNumCoa).HasColumnName("CRBColNum_COA");

                entity.Property(e => e.CrbcolNumSideCoa)
                    .HasColumnName("CRBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.DateBalFwdCoa)
                    .HasColumnName("DateBalFwd_COA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DefinedDateCoa)
                    .HasColumnName("DefinedDate_COA")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DescriptionCoa)
                    .HasColumnName("Description_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.EntryForCoa)
                    .HasColumnName("EntryFor_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.FsgroupSortCoa).HasColumnName("FSGroupSort_COA");

                entity.Property(e => e.HasCoaslCoa).HasColumnName("HasCOASL_COA");

                entity.Property(e => e.HasInvtySlCoa).HasColumnName("HasInvtySL_COA");

                entity.Property(e => e.HasUmslCoa).HasColumnName("HasUMSL_COA");

                entity.Property(e => e.InActiveCoa).HasColumnName("InActive_COA");

                entity.Property(e => e.IncomeStatementAcctCoa).HasColumnName("IncomeStatementAcct_COA");

                entity.Property(e => e.IncomeStatementGroupCoa)
                    .HasColumnName("IncomeStatementGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.IncomeStatementSortCoa).HasColumnName("IncomeStatementSort_COA");

                entity.Property(e => e.IsControllingCoa).HasColumnName("IsControlling_COA");

                entity.Property(e => e.IsPassbookCoa).HasColumnName("IsPassbook_COA");

                entity.Property(e => e.IsSubClassCoa).HasColumnName("IsSubClass_COA");

                entity.Property(e => e.IsSubsidiaryCoa).HasColumnName("IsSubsidiary_COA");

                entity.Property(e => e.IsTransNumRequiredCoa).HasColumnName("IsTransNumRequired_COA");

                entity.Property(e => e.JbcolHeaderCoa)
                    .HasColumnName("JBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.JbcolNumCoa).HasColumnName("JBColNum_COA");

                entity.Property(e => e.JbcolNumSideCoa)
                    .HasColumnName("JBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.JournalSummaryColHeaderCoa)
                    .HasColumnName("JournalSummaryColHeader_COA")
                    .HasMaxLength(15);

                entity.Property(e => e.LastUpdatedByCoa)
                    .HasColumnName("LastUpdatedBy_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCoa)
                    .HasColumnName("LastUpdatedConcurrencyID_COA")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCoa)
                    .HasColumnName("LastUpdatedDate_COA")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTransLedgerEntriesCoa)
                    .HasColumnName("ModuleTransLedgerEntries_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.MstrCbddefaultCoa).HasColumnName("MstrCBDDefault_COA");

                entity.Property(e => e.MstrManualDefaultCoa)
                    .HasColumnName("MstrManualDefault_COA")
                    .HasMaxLength(20);

                entity.Property(e => e.MstrSgndefaultCoa).HasColumnName("MstrSGNDefault_COA");

                entity.Property(e => e.MstrTypeDefaultCoa)
                    .HasColumnName("MstrTypeDefault_COA")
                    .HasMaxLength(5);

                entity.Property(e => e.ParticularsCoa)
                    .HasColumnName("Particulars_COA")
                    .HasMaxLength(100);

                entity.Property(e => e.ParticularsSlCoa)
                    .HasColumnName("ParticularsSL_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.PrimarySubClassAcctCoa).HasColumnName("PrimarySubClassAcct_COA");

                entity.Property(e => e.PrimarySubClassDashCoa)
                    .HasColumnName("PrimarySubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.PrimarySubClassFormatCoa)
                    .HasColumnName("PrimarySubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimarySubClassParticularsCoa)
                    .HasColumnName("PrimarySubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ProphetCoa)
                    .HasColumnName("Prophet_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.ReportClassParticularsCoa).HasColumnName("ReportClassParticulars_COA");

                entity.Property(e => e.ReportControllingParticularsCoa).HasColumnName("ReportControllingParticulars_COA");

                entity.Property(e => e.ReportIndependentParticularsCoa).HasColumnName("ReportIndependentParticulars_COA");

                entity.Property(e => e.ReportParticularsCoa)
                    .HasColumnName("ReportParticulars_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportSubClassParticularsCoa).HasColumnName("ReportSubClassParticulars_COA");

                entity.Property(e => e.ReportSubsidiaryParticularsCoa).HasColumnName("ReportSubsidiaryParticulars_COA");

                entity.Property(e => e.ReportSummaryParticularsCoa)
                    .HasColumnName("ReportSummaryParticulars_COA")
                    .HasMaxLength(255);

                entity.Property(e => e.SbcolHeaderCoa)
                    .HasColumnName("SBColHeader_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SbcolNumCoa).HasColumnName("SBColNum_COA");

                entity.Property(e => e.SbcolNumSideCoa)
                    .HasColumnName("SBColNumSide_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SecondarySubClassAcctCoa).HasColumnName("SecondarySubClassAcct_COA");

                entity.Property(e => e.SecondarySubClassDashCoa)
                    .HasColumnName("SecondarySubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.SecondarySubClassFormatCoa)
                    .HasColumnName("SecondarySubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SecondarySubClassParticularsCoa)
                    .HasColumnName("SecondarySubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SidePositiveCoa)
                    .HasColumnName("SidePositive_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SlcbdCoa).HasColumnName("SLCBD_COA");

                entity.Property(e => e.SllinkMethodCoa).HasColumnName("SLLinkMethod_COA");

                entity.Property(e => e.SllinkToCoa)
                    .HasColumnName("SLLinkTo_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SlmanualCoa)
                    .HasColumnName("SLManual_COA")
                    .HasMaxLength(10);

                entity.Property(e => e.SlmoduleLedgerCoa)
                    .HasColumnName("SLModuleLedger_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SlsgnCoa).HasColumnName("SLSGN_COA");

                entity.Property(e => e.SltypeCoa)
                    .HasColumnName("SLType_COA")
                    .HasMaxLength(20);

                entity.Property(e => e.SourcesUsesFundAcctCoa).HasColumnName("SourcesUsesFundAcct_COA");

                entity.Property(e => e.SourcesUsesFundGroupCoa)
                    .HasColumnName("SourcesUsesFundGroup_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusCoa)
                    .HasColumnName("Status_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubClassCoa).HasColumnName("SubClass_COA");

                entity.Property(e => e.SubClassDashCoa)
                    .HasColumnName("SubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.SubClassFormatCoa)
                    .HasColumnName("SubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubClassParticularsCoa)
                    .HasColumnName("SubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubsidiaryAcctCoa).HasColumnName("SubsidiaryAcct_COA");

                entity.Property(e => e.SubsidiaryDashCoa)
                    .HasColumnName("SubsidiaryDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.SubsidiaryFormatCoa)
                    .HasColumnName("SubsidiaryFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SubsidiaryParticularsCoa)
                    .HasColumnName("SubsidiaryParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoactrlAcctCoa)
                    .HasColumnName("SysFK_COACtrlAcct_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtySlCoa)
                    .HasColumnName("SysFK_InvtySL_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSlaccountCoa)
                    .HasColumnName("SysFK_SLAccount_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSlinventoryCoa)
                    .HasColumnName("SysFK_SLInventory_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTypeCoa)
                    .HasColumnName("SysFK_Type_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmslCoa)
                    .HasColumnName("SysFK_UMSL_COA")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TbsidePostiveCoa).HasColumnName("TBSidePostive_COA");

                entity.Property(e => e.TertiarySubClassAcctCoa).HasColumnName("TertiarySubClassAcct_COA");

                entity.Property(e => e.TertiarySubClassDashCoa)
                    .HasColumnName("TertiarySubClassDash_COA")
                    .HasMaxLength(1);

                entity.Property(e => e.TertiarySubClassFormatCoa)
                    .HasColumnName("TertiarySubClassFormat_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.TertiarySubClassParticularsCoa)
                    .HasColumnName("TertiarySubClassParticulars_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.TitleCoa)
                    .HasColumnName("Title_COA")
                    .HasMaxLength(100);

                entity.Property(e => e.TitleSpeakCoa)
                    .HasColumnName("TitleSpeak_COA")
                    .HasMaxLength(100);

                entity.Property(e => e.TransNumPrefixCoa)
                    .HasColumnName("TransNumPrefix_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeCoa)
                    .HasColumnName("Type_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPsbkCoa)
                    .HasColumnName("UserFK_Psbk_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkCoa)
                    .HasColumnName("UserPK_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkSlaccountCoa)
                    .HasColumnName("UserPK_SLAccount_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkSlinventoryCoa)
                    .HasColumnName("UserPK_SLInventory_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktypeCoa)
                    .HasColumnName("UserPKType_COA")
                    .HasMaxLength(50);

                entity.Property(e => e.VoidCoa).HasColumnName("Void_COA");
            });

            modelBuilder.Entity<CoatypeMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkCoaTm);

                entity.ToTable("COAType_Master");

                entity.HasIndex(e => e.AddIfSideCoaTm)
                    .HasName("IX_COAType_Master_8");

                entity.HasIndex(e => e.BalanceSheetReportOrderCoaTm)
                    .HasName("IX_COAType_Master_6");

                entity.HasIndex(e => e.ClassCoaTm)
                    .HasName("IX_COAType_Master_3");

                entity.HasIndex(e => e.ClassParticularsCoaTm)
                    .HasName("IX_COAType_Master_4");

                entity.HasIndex(e => e.IncomeStatementReportOrderCoaTm)
                    .HasName("IX_COAType_Master_7");

                entity.HasIndex(e => e.IsBalanceSheetCoaTm)
                    .HasName("IX_COAType_Master");

                entity.HasIndex(e => e.IsCashFlowCoaTm)
                    .HasName("IX_COAType_Master_5");

                entity.HasIndex(e => e.IsIncomeStatementCoaTm)
                    .HasName("IX_COAType_Master_1");

                entity.HasIndex(e => e.UserPkCoaTm)
                    .HasName("IX_COAType_Master_2");

                entity.Property(e => e.SysPkCoaTm)
                    .HasColumnName("SysPK_CoaTM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AddIfSideCoaTm).HasColumnName("AddIfSide_CoaTM");

                entity.Property(e => e.BalanceSheetGroup01CoaTm)
                    .HasColumnName("BalanceSheetGroup01_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceSheetGroup02CoaTm)
                    .HasColumnName("BalanceSheetGroup02_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceSheetReportOrderCoaTm).HasColumnName("BalanceSheetReportOrder_CoaTM");

                entity.Property(e => e.CashFlowReportOrderCoaTm).HasColumnName("CashFlowReportOrder_CoaTM");

                entity.Property(e => e.CashFlowTypeCoaTm)
                    .HasColumnName("CashFlowType_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdCoaTm)
                    .HasColumnName("CBD_CoaTM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ClassCoaTm).HasColumnName("Class_CoaTM");

                entity.Property(e => e.ClassParticularsCoaTm)
                    .HasColumnName("ClassParticulars_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.HasInvtySlCoaTm).HasColumnName("HasInvtySL_CoaTM");

                entity.Property(e => e.HasUmslCoaTm).HasColumnName("HasUMSL_CoaTM");

                entity.Property(e => e.IncomeStatementGroup01CoaTm)
                    .HasColumnName("IncomeStatementGroup01_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.IncomeStatementGroup02CoaTm)
                    .HasColumnName("IncomeStatementGroup02_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.IncomeStatementReportOrderCoaTm).HasColumnName("IncomeStatementReportOrder_CoaTM");

                entity.Property(e => e.IsBalanceSheetCoaTm).HasColumnName("IsBalanceSheet_CoaTM");

                entity.Property(e => e.IsCashFlowCoaTm).HasColumnName("IsCashFlow_CoaTM");

                entity.Property(e => e.IsIncomeStatementCoaTm).HasColumnName("IsIncomeStatement_CoaTM");

                entity.Property(e => e.LastUpdatedByCoaTm)
                    .HasColumnName("LastUpdatedBy_CoaTM")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCoaTm)
                    .HasColumnName("LastUpdatedConcurrencyID_CoaTM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCoaTm)
                    .HasColumnName("LastUpdatedDate_CoaTM")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleCoaTm)
                    .HasColumnName("Module_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.ProphetCoaTm)
                    .HasColumnName("Prophet_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.SidePositiveCoaTm)
                    .HasColumnName("SidePositive_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusCoaTm)
                    .HasColumnName("Status_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.SysSeqCoaTm).HasColumnName("SysSeq_CoaTM");

                entity.Property(e => e.UserPkCoaTm)
                    .HasColumnName("UserPK_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqCoaTm).HasColumnName("UserSeq_CoaTM");
            });

            modelBuilder.Entity<CoatypeMasterSystem>(entity =>
            {
                entity.HasKey(e => e.SysPkCoaTm);

                entity.ToTable("COAType_MasterSystem");

                entity.HasIndex(e => e.BalanceSheetReportOrderCoaTm)
                    .HasName("IX_COAType_MasterSystem_6");

                entity.HasIndex(e => e.ClassParticularsCoaTm)
                    .HasName("IX_COAType_MasterSystem_2");

                entity.HasIndex(e => e.IncomeStatementReportOrderCoaTm)
                    .HasName("IX_COAType_MasterSystem_7");

                entity.HasIndex(e => e.IsBalanceSheetCoaTm)
                    .HasName("IX_COAType_MasterSystem");

                entity.HasIndex(e => e.IsCashFlowCoaTm)
                    .HasName("IX_COAType_MasterSystem_4");

                entity.HasIndex(e => e.IsIncomeStatementCoaTm)
                    .HasName("IX_COAType_MasterSystem_1");

                entity.HasIndex(e => e.SidePositiveCoaTm)
                    .HasName("IX_COAType_MasterSystem_5");

                entity.HasIndex(e => e.UserPkCoaTm)
                    .HasName("IX_COAType_MasterSystem_3");

                entity.Property(e => e.SysPkCoaTm)
                    .HasColumnName("SysPK_CoaTM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AddIfSideCoaTm).HasColumnName("AddIfSide_CoaTM");

                entity.Property(e => e.BalanceSheetGroup01CoaTm)
                    .HasColumnName("BalanceSheetGroup01_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceSheetGroup02CoaTm)
                    .HasColumnName("BalanceSheetGroup02_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceSheetReportOrderCoaTm).HasColumnName("BalanceSheetReportOrder_CoaTM");

                entity.Property(e => e.CbdCoaTm)
                    .HasColumnName("CBD_CoaTM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ClassCoaTm).HasColumnName("Class_CoaTM");

                entity.Property(e => e.ClassParticularsCoaTm)
                    .HasColumnName("ClassParticulars_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.HasInvtySlCoaTm).HasColumnName("HasInvtySL_CoaTM");

                entity.Property(e => e.HasUmslCoaTm).HasColumnName("HasUMSL_CoaTM");

                entity.Property(e => e.IncomeStatementGroup01CoaTm)
                    .HasColumnName("IncomeStatementGroup01_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.IncomeStatementGroup02CoaTm)
                    .HasColumnName("IncomeStatementGroup02_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.IncomeStatementReportOrderCoaTm).HasColumnName("IncomeStatementReportOrder_CoaTM");

                entity.Property(e => e.IsBalanceSheetCoaTm).HasColumnName("IsBalanceSheet_CoaTM");

                entity.Property(e => e.IsCashFlowCoaTm).HasColumnName("IsCashFlow_CoaTM");

                entity.Property(e => e.IsIncomeStatementCoaTm).HasColumnName("IsIncomeStatement_CoaTM");

                entity.Property(e => e.LastUpdatedByCoaTm)
                    .HasColumnName("LastUpdatedBy_CoaTM")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCoaTm)
                    .HasColumnName("LastUpdatedConcurrencyID_CoaTM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCoaTm)
                    .HasColumnName("LastUpdatedDate_CoaTM")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleCoaTm)
                    .HasColumnName("Module_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.ProphetCoaTm)
                    .HasColumnName("Prophet_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.SidePositiveCoaTm)
                    .HasColumnName("SidePositive_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusCoaTm)
                    .HasColumnName("Status_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.SysSeqCoaTm).HasColumnName("SysSeq_CoaTM");

                entity.Property(e => e.UserPkCoaTm)
                    .HasColumnName("UserPK_CoaTM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqCoaTm).HasColumnName("UserSeq_CoaTM");
            });

            modelBuilder.Entity<CreditInvestigationHeader>(entity =>
            {
                entity.HasKey(e => e.SysPkCih);

                entity.ToTable("Credit_Investigation_Header");

                entity.Property(e => e.SysPkCih)
                    .HasColumnName("SysPK_CIH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AgeCih).HasColumnName("Age_CIH");

                entity.Property(e => e.BldgIsOwnedCih).HasColumnName("BldgIsOwned_CIH");

                entity.Property(e => e.BldgIsRentedCih).HasColumnName("BldgIsRented_CIH");

                entity.Property(e => e.BldgIsRentedHowMuchCih)
                    .HasColumnName("BldgIsRented_HowMuch_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.BusAddCih)
                    .HasColumnName("Bus_Add_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.BusInfoDailySalesAveCih)
                    .HasColumnName("BusInfo_DailySales_Ave_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.BusInfoDailySalesHighestCih)
                    .HasColumnName("BusInfo_DailySales_Highest_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.BusInfoDailySalesLowestCih)
                    .HasColumnName("BusInfo_DailySales_Lowest_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.BusInfoDescriptionofBusinessCih)
                    .HasColumnName("BusInfo_DescriptionofBusiness_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.BusInfoHowLongOnSaidBusinessCih)
                    .HasColumnName("BusInfo_HowLongOnSaidBusiness_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.BusInfoLicensesofBusinessCih)
                    .HasColumnName("BusInfo_LicensesofBusiness_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.BusInfoMerchandiseCih)
                    .HasColumnName("BusInfo_Merchandise_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.BusInfoValueOfStocksCih)
                    .HasColumnName("BusInfo_ValueOfStocks_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.CharacterOfSpousetCih)
                    .HasColumnName("CharacterOfSpouset_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.CharacterOfSubjectCih)
                    .HasColumnName("CharacterOfSubject_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditInvestigatorCih)
                    .HasColumnName("CreditInvestigator_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.DateCih)
                    .HasColumnName("Date_CIH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HouseIsOwnedCih).HasColumnName("HouseIsOwned_CIH");

                entity.Property(e => e.HouseIsRentedCih).HasColumnName("HouseIsRented_CIH");

                entity.Property(e => e.HouseIsRentedHowMuchCih)
                    .HasColumnName("HouseIsRented_HowMuch_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.IncomeOfSpouseCih)
                    .HasColumnName("IncomeOfSpouse_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByCih)
                    .HasColumnName("LastUpdatedBy_CIH")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCih)
                    .HasColumnName("LastUpdatedConcurrencyID_CIH")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCih)
                    .HasColumnName("LastUpdatedDate_CIH")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LivesWithCih)
                    .HasColumnName("LivesWith_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.LoanInfoFirstTimeLoanCih).HasColumnName("LoanInfo_FirstTimeLoan_CIH");

                entity.Property(e => e.LoanInfoHasToLoanCih)
                    .HasColumnName("LoanInfo_HasToLoan_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.LoanInfoHowLongOnSaidLoanCih)
                    .HasColumnName("LoanInfo_HowLongOnSaidLoan_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.LotBuildingIsOwnedCih).HasColumnName("LotBuildingIsOwned_CIH");

                entity.Property(e => e.LotBuildingIsRentedCih).HasColumnName("LotBuildingIsRented_CIH");

                entity.Property(e => e.LotBuildingIsRentedHowMuchCih)
                    .HasColumnName("LotBuildingIsRented_HowMuch_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.LotIsOwnedCih).HasColumnName("LotIsOwned_CIH");

                entity.Property(e => e.LotIsRentedCih).HasColumnName("LotIsRented_CIH");

                entity.Property(e => e.LotIsRentedHowMuchCih)
                    .HasColumnName("LotIsRented_HowMuch_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.ManagementRemarks)
                    .HasColumnName("Management_Remarks")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleCih)
                    .HasColumnName("Module_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfChildrenCih)
                    .HasColumnName("NoOfChildren_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfChildrenLivingWithSubjectCih)
                    .HasColumnName("NoOfChildren_LivingWithSubject_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfChildrenStudyingCih)
                    .HasColumnName("NoOfChildren_Studying_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfChildrenStudyingSchoolCih)
                    .HasColumnName("NoOfChildren_Studying_School_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.NoOfChildrenWorkingCih)
                    .HasColumnName("NoOfChildren_Working_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherIncomeCih)
                    .HasColumnName("OtherIncome_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureFileNameCih)
                    .HasColumnName("PictureFileName_CIH")
                    .HasMaxLength(255);

                entity.Property(e => e.RealPropertiesCih)
                    .HasColumnName("RealProperties_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.RecommendationCih)
                    .HasColumnName("Recommendation_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksCih)
                    .HasColumnName("Remarks_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.ResAddCih)
                    .HasColumnName("Res_Add_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.SignatureCih)
                    .HasColumnName("Signature_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusCih)
                    .HasColumnName("Status_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.SubjectsRelativeInGovtOffCih)
                    .HasColumnName("SubjectsRelativeInGovtOff_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.SubjectsRelativeInHighProfCih)
                    .HasColumnName("SubjectsRelativeInHighProf_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkUmCih)
                    .HasColumnName("SysFK_UM_CIH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbrwrCih)
                    .HasColumnName("SysFK_UMBrwr_CIH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqCih).HasColumnName("SysSeq_CIH");

                entity.Property(e => e.UserFkUmbrwrCih)
                    .HasColumnName("UserFK_UMBrwr_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkCih)
                    .HasColumnName("UserPK_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqCih).HasColumnName("UserSeq_CIH");

                entity.Property(e => e.WantsToLoanCih)
                    .HasColumnName("WantsToLoan_CIH")
                    .HasColumnType("money");

                entity.Property(e => e.WantsToLoanWillBeUsedCih)
                    .HasColumnName("WantsToLoan_WillBeUsed_CIH")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkOfSpouseCih)
                    .HasColumnName("WorkOfSpouse_CIH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CreditInvestigationProperties>(entity =>
            {
                entity.HasKey(e => e.SysPkCiprop);

                entity.ToTable("Credit_Investigation_Properties");

                entity.Property(e => e.SysPkCiprop)
                    .HasColumnName("SysPK_CIProp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateCiprop)
                    .HasColumnName("Date_CIProp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DescriptionCiprop)
                    .HasColumnName("Description_CIProp")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByCiprop)
                    .HasColumnName("LastUpdatedBy_CIProp")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCiprop)
                    .HasColumnName("LastUpdatedConcurrencyID_CIProp")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCiprop)
                    .HasColumnName("LastUpdatedDate_CIProp")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleCiprop)
                    .HasColumnName("Module_CIProp")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureFileNameCiprop)
                    .HasColumnName("PictureFileName_CIProp")
                    .HasMaxLength(255);

                entity.Property(e => e.PresentValueCiprop)
                    .HasColumnName("PresentValue_CIProp")
                    .HasColumnType("money");

                entity.Property(e => e.SerialNoCiprop)
                    .HasColumnName("SerialNo_CIProp")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCihCiprop)
                    .HasColumnName("SysFK_CIH_CIProp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqCiprop).HasColumnName("SysSeq_CIProp");

                entity.Property(e => e.UserSeqCiprop).HasColumnName("UserSeq_CIProp");
            });

            modelBuilder.Entity<DeleteLogMaster>(entity =>
            {
                entity.HasKey(e => e.RecordSysPk);

                entity.ToTable("DeleteLog_Master");

                entity.Property(e => e.RecordSysPk)
                    .HasColumnName("RecordSysPK")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateTimeDeleted).HasColumnType("smalldatetime");

                entity.Property(e => e.FormCaption).HasMaxLength(200);

                entity.Property(e => e.OneTimeDeletingRightsGrantedBy).HasMaxLength(50);

                entity.Property(e => e.RecordInfo).HasMaxLength(255);

                entity.Property(e => e.StationNum).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<DeletedRecords>(entity =>
            {
                entity.HasKey(e => e.SysPkDelRec);

                entity.ToTable("Deleted_Records");

                entity.Property(e => e.SysPkDelRec)
                    .HasColumnName("SysPK_DelRec")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateTimeDeleted).HasColumnType("smalldatetime");

                entity.Property(e => e.Field001).HasMaxLength(255);

                entity.Property(e => e.Field002).HasMaxLength(255);

                entity.Property(e => e.Field003).HasMaxLength(255);

                entity.Property(e => e.Field004).HasMaxLength(255);

                entity.Property(e => e.Field005).HasMaxLength(255);

                entity.Property(e => e.Field006).HasMaxLength(255);

                entity.Property(e => e.Field007).HasMaxLength(255);

                entity.Property(e => e.Field008).HasMaxLength(255);

                entity.Property(e => e.Field009).HasMaxLength(255);

                entity.Property(e => e.Field010).HasMaxLength(255);

                entity.Property(e => e.Field011).HasMaxLength(255);

                entity.Property(e => e.Field012).HasMaxLength(255);

                entity.Property(e => e.Field013).HasMaxLength(255);

                entity.Property(e => e.Field014).HasMaxLength(255);

                entity.Property(e => e.Field015).HasMaxLength(255);

                entity.Property(e => e.Field016).HasMaxLength(255);

                entity.Property(e => e.Field017).HasMaxLength(255);

                entity.Property(e => e.Field018).HasMaxLength(255);

                entity.Property(e => e.Field019).HasMaxLength(255);

                entity.Property(e => e.Field020).HasMaxLength(255);

                entity.Property(e => e.Field021).HasMaxLength(255);

                entity.Property(e => e.Field022).HasMaxLength(255);

                entity.Property(e => e.Field023).HasMaxLength(255);

                entity.Property(e => e.Field024).HasMaxLength(255);

                entity.Property(e => e.Field025).HasMaxLength(255);

                entity.Property(e => e.Field026).HasMaxLength(255);

                entity.Property(e => e.Field027).HasMaxLength(255);

                entity.Property(e => e.Field028).HasMaxLength(255);

                entity.Property(e => e.Field029).HasMaxLength(255);

                entity.Property(e => e.Field030).HasMaxLength(255);

                entity.Property(e => e.Field031).HasMaxLength(255);

                entity.Property(e => e.Field032).HasMaxLength(255);

                entity.Property(e => e.Field033).HasMaxLength(255);

                entity.Property(e => e.Field034).HasMaxLength(255);

                entity.Property(e => e.Field035).HasMaxLength(255);

                entity.Property(e => e.Field036).HasMaxLength(255);

                entity.Property(e => e.Field037).HasMaxLength(255);

                entity.Property(e => e.Field038).HasMaxLength(255);

                entity.Property(e => e.Field039).HasMaxLength(255);

                entity.Property(e => e.Field040).HasMaxLength(255);

                entity.Property(e => e.Field041).HasMaxLength(255);

                entity.Property(e => e.Field042).HasMaxLength(255);

                entity.Property(e => e.Field043).HasMaxLength(255);

                entity.Property(e => e.Field044).HasMaxLength(255);

                entity.Property(e => e.Field045).HasMaxLength(255);

                entity.Property(e => e.Field046).HasMaxLength(255);

                entity.Property(e => e.Field047).HasMaxLength(255);

                entity.Property(e => e.Field048).HasMaxLength(255);

                entity.Property(e => e.Field049).HasMaxLength(255);

                entity.Property(e => e.Field050).HasMaxLength(255);

                entity.Property(e => e.Field051).HasMaxLength(255);

                entity.Property(e => e.Field052).HasMaxLength(255);

                entity.Property(e => e.Field053).HasMaxLength(255);

                entity.Property(e => e.Field054).HasMaxLength(255);

                entity.Property(e => e.Field055).HasMaxLength(255);

                entity.Property(e => e.Field056).HasMaxLength(255);

                entity.Property(e => e.Field057).HasMaxLength(255);

                entity.Property(e => e.Field058).HasMaxLength(255);

                entity.Property(e => e.Field059).HasMaxLength(255);

                entity.Property(e => e.Field060).HasMaxLength(255);

                entity.Property(e => e.Field061).HasMaxLength(255);

                entity.Property(e => e.Field062).HasMaxLength(255);

                entity.Property(e => e.Field063).HasMaxLength(255);

                entity.Property(e => e.Field064).HasMaxLength(255);

                entity.Property(e => e.Field065).HasMaxLength(255);

                entity.Property(e => e.Field066).HasMaxLength(255);

                entity.Property(e => e.Field067).HasMaxLength(255);

                entity.Property(e => e.Field068).HasMaxLength(255);

                entity.Property(e => e.Field069).HasMaxLength(255);

                entity.Property(e => e.Field070).HasMaxLength(255);

                entity.Property(e => e.Field071).HasMaxLength(255);

                entity.Property(e => e.Field072).HasMaxLength(255);

                entity.Property(e => e.Field073).HasMaxLength(255);

                entity.Property(e => e.Field074).HasMaxLength(255);

                entity.Property(e => e.Field075).HasMaxLength(255);

                entity.Property(e => e.Field076).HasMaxLength(255);

                entity.Property(e => e.Field077).HasMaxLength(255);

                entity.Property(e => e.Field078).HasMaxLength(255);

                entity.Property(e => e.Field079).HasMaxLength(255);

                entity.Property(e => e.Field080).HasMaxLength(255);

                entity.Property(e => e.Field081).HasMaxLength(255);

                entity.Property(e => e.Field082).HasMaxLength(255);

                entity.Property(e => e.Field083).HasMaxLength(255);

                entity.Property(e => e.Field084).HasMaxLength(255);

                entity.Property(e => e.Field085).HasMaxLength(255);

                entity.Property(e => e.Field086).HasMaxLength(255);

                entity.Property(e => e.Field087).HasMaxLength(255);

                entity.Property(e => e.Field088).HasMaxLength(255);

                entity.Property(e => e.Field089).HasMaxLength(255);

                entity.Property(e => e.Field090).HasMaxLength(255);

                entity.Property(e => e.Field091).HasMaxLength(255);

                entity.Property(e => e.Field092).HasMaxLength(255);

                entity.Property(e => e.Field093).HasMaxLength(255);

                entity.Property(e => e.Field094).HasMaxLength(255);

                entity.Property(e => e.Field095).HasMaxLength(255);

                entity.Property(e => e.Field096).HasMaxLength(255);

                entity.Property(e => e.Field097).HasMaxLength(255);

                entity.Property(e => e.Field098).HasMaxLength(255);

                entity.Property(e => e.Field099).HasMaxLength(255);

                entity.Property(e => e.Field100).HasMaxLength(255);

                entity.Property(e => e.Field101).HasMaxLength(255);

                entity.Property(e => e.Field102).HasMaxLength(255);

                entity.Property(e => e.Field103).HasMaxLength(255);

                entity.Property(e => e.Field104).HasMaxLength(255);

                entity.Property(e => e.Field105).HasMaxLength(255);

                entity.Property(e => e.Field106).HasMaxLength(255);

                entity.Property(e => e.Field107).HasMaxLength(255);

                entity.Property(e => e.Field108).HasMaxLength(255);

                entity.Property(e => e.Field109).HasMaxLength(255);

                entity.Property(e => e.Field110).HasMaxLength(255);

                entity.Property(e => e.Field111).HasMaxLength(255);

                entity.Property(e => e.Field112).HasMaxLength(255);

                entity.Property(e => e.Field113).HasMaxLength(255);

                entity.Property(e => e.Field114).HasMaxLength(255);

                entity.Property(e => e.Field115).HasMaxLength(255);

                entity.Property(e => e.Field116).HasMaxLength(255);

                entity.Property(e => e.Field117).HasMaxLength(255);

                entity.Property(e => e.Field118).HasMaxLength(255);

                entity.Property(e => e.Field119).HasMaxLength(255);

                entity.Property(e => e.Field120).HasMaxLength(255);

                entity.Property(e => e.Field121).HasMaxLength(255);

                entity.Property(e => e.Field122).HasMaxLength(255);

                entity.Property(e => e.Field123).HasMaxLength(255);

                entity.Property(e => e.Field124).HasMaxLength(255);

                entity.Property(e => e.Field125).HasMaxLength(255);

                entity.Property(e => e.Field126).HasMaxLength(255);

                entity.Property(e => e.Field127).HasMaxLength(255);

                entity.Property(e => e.Field128).HasMaxLength(255);

                entity.Property(e => e.Field129).HasMaxLength(255);

                entity.Property(e => e.Field130).HasMaxLength(255);

                entity.Property(e => e.Field131).HasMaxLength(255);

                entity.Property(e => e.Field132).HasMaxLength(255);

                entity.Property(e => e.Field133).HasMaxLength(255);

                entity.Property(e => e.Field134).HasMaxLength(255);

                entity.Property(e => e.Field135).HasMaxLength(255);

                entity.Property(e => e.Field136).HasMaxLength(255);

                entity.Property(e => e.Field137).HasMaxLength(255);

                entity.Property(e => e.Field138).HasMaxLength(255);

                entity.Property(e => e.Field139).HasMaxLength(255);

                entity.Property(e => e.Field140).HasMaxLength(255);

                entity.Property(e => e.Field141).HasMaxLength(255);

                entity.Property(e => e.Field142).HasMaxLength(255);

                entity.Property(e => e.Field143).HasMaxLength(255);

                entity.Property(e => e.Field144).HasMaxLength(255);

                entity.Property(e => e.Field145).HasMaxLength(255);

                entity.Property(e => e.Field146).HasMaxLength(255);

                entity.Property(e => e.Field147).HasMaxLength(255);

                entity.Property(e => e.Field148).HasMaxLength(255);

                entity.Property(e => e.Field149).HasMaxLength(255);

                entity.Property(e => e.Field150).HasMaxLength(255);

                entity.Property(e => e.Field151).HasMaxLength(255);

                entity.Property(e => e.Field152).HasMaxLength(255);

                entity.Property(e => e.Field153).HasMaxLength(255);

                entity.Property(e => e.Field154).HasMaxLength(255);

                entity.Property(e => e.Field155).HasMaxLength(255);

                entity.Property(e => e.Field156).HasMaxLength(255);

                entity.Property(e => e.Field157).HasMaxLength(255);

                entity.Property(e => e.Field158).HasMaxLength(255);

                entity.Property(e => e.Field159).HasMaxLength(255);

                entity.Property(e => e.Field160).HasMaxLength(255);

                entity.Property(e => e.Field161).HasMaxLength(255);

                entity.Property(e => e.Field162).HasMaxLength(255);

                entity.Property(e => e.Field163).HasMaxLength(255);

                entity.Property(e => e.Field164).HasMaxLength(255);

                entity.Property(e => e.Field165).HasMaxLength(255);

                entity.Property(e => e.Field166).HasMaxLength(255);

                entity.Property(e => e.Field167).HasMaxLength(255);

                entity.Property(e => e.Field168).HasMaxLength(255);

                entity.Property(e => e.Field169).HasMaxLength(255);

                entity.Property(e => e.Field170).HasMaxLength(255);

                entity.Property(e => e.Field171).HasMaxLength(255);

                entity.Property(e => e.Field172).HasMaxLength(255);

                entity.Property(e => e.Field173).HasMaxLength(255);

                entity.Property(e => e.Field174).HasMaxLength(255);

                entity.Property(e => e.Field175).HasMaxLength(255);

                entity.Property(e => e.Field176).HasMaxLength(255);

                entity.Property(e => e.Field177).HasMaxLength(255);

                entity.Property(e => e.Field178).HasMaxLength(255);

                entity.Property(e => e.Field179).HasMaxLength(255);

                entity.Property(e => e.Field180).HasMaxLength(255);

                entity.Property(e => e.Field181).HasMaxLength(255);

                entity.Property(e => e.Field182).HasMaxLength(255);

                entity.Property(e => e.Field183).HasMaxLength(255);

                entity.Property(e => e.Field184).HasMaxLength(255);

                entity.Property(e => e.Field185).HasMaxLength(255);

                entity.Property(e => e.Field186).HasMaxLength(255);

                entity.Property(e => e.Field187).HasMaxLength(255);

                entity.Property(e => e.Field188).HasMaxLength(255);

                entity.Property(e => e.Field189).HasMaxLength(255);

                entity.Property(e => e.Field190).HasMaxLength(255);

                entity.Property(e => e.Field191).HasMaxLength(255);

                entity.Property(e => e.Field192).HasMaxLength(255);

                entity.Property(e => e.Field193).HasMaxLength(255);

                entity.Property(e => e.Field194).HasMaxLength(255);

                entity.Property(e => e.Field195).HasMaxLength(255);

                entity.Property(e => e.Field196).HasMaxLength(255);

                entity.Property(e => e.Field197).HasMaxLength(255);

                entity.Property(e => e.Field198).HasMaxLength(255);

                entity.Property(e => e.Field199).HasMaxLength(255);

                entity.Property(e => e.Field200).HasMaxLength(255);

                entity.Property(e => e.Field201).HasMaxLength(255);

                entity.Property(e => e.Field202).HasMaxLength(255);

                entity.Property(e => e.Field203).HasMaxLength(255);

                entity.Property(e => e.Field204).HasMaxLength(255);

                entity.Property(e => e.Field205).HasMaxLength(255);

                entity.Property(e => e.Field206).HasMaxLength(255);

                entity.Property(e => e.Field207).HasMaxLength(255);

                entity.Property(e => e.Field208).HasMaxLength(255);

                entity.Property(e => e.Field209).HasMaxLength(255);

                entity.Property(e => e.Field210).HasMaxLength(255);

                entity.Property(e => e.Field211).HasMaxLength(255);

                entity.Property(e => e.Field212).HasMaxLength(255);

                entity.Property(e => e.Field213).HasMaxLength(255);

                entity.Property(e => e.Field214).HasMaxLength(255);

                entity.Property(e => e.Field215).HasMaxLength(255);

                entity.Property(e => e.Field216).HasMaxLength(255);

                entity.Property(e => e.Field217).HasMaxLength(255);

                entity.Property(e => e.Field218).HasMaxLength(255);

                entity.Property(e => e.Field219).HasMaxLength(255);

                entity.Property(e => e.Field220).HasMaxLength(255);

                entity.Property(e => e.Field221).HasMaxLength(255);

                entity.Property(e => e.Field222).HasMaxLength(255);

                entity.Property(e => e.Field223).HasMaxLength(255);

                entity.Property(e => e.Field224).HasMaxLength(255);

                entity.Property(e => e.Field225).HasMaxLength(255);

                entity.Property(e => e.Field226).HasMaxLength(255);

                entity.Property(e => e.Field227).HasMaxLength(255);

                entity.Property(e => e.Field228).HasMaxLength(255);

                entity.Property(e => e.Field229).HasMaxLength(255);

                entity.Property(e => e.Field230).HasMaxLength(255);

                entity.Property(e => e.Field231).HasMaxLength(255);

                entity.Property(e => e.Field232).HasMaxLength(255);

                entity.Property(e => e.Field233).HasMaxLength(255);

                entity.Property(e => e.Field234).HasMaxLength(255);

                entity.Property(e => e.Field235).HasMaxLength(255);

                entity.Property(e => e.Field236).HasMaxLength(255);

                entity.Property(e => e.Field237).HasMaxLength(255);

                entity.Property(e => e.Field238).HasMaxLength(255);

                entity.Property(e => e.Field239).HasMaxLength(255);

                entity.Property(e => e.Field240).HasMaxLength(255);

                entity.Property(e => e.Field241).HasMaxLength(255);

                entity.Property(e => e.Field242).HasMaxLength(255);

                entity.Property(e => e.Field243).HasMaxLength(255);

                entity.Property(e => e.Field244).HasMaxLength(255);

                entity.Property(e => e.FormCaption).HasMaxLength(200);

                entity.Property(e => e.OneTimeDeletingRightsGrantedBy).HasMaxLength(50);

                entity.Property(e => e.RecordInfo).HasMaxLength(255);

                entity.Property(e => e.RecordSysPk)
                    .HasColumnName("RecordSysPK")
                    .HasColumnType("money");

                entity.Property(e => e.StationNum).HasMaxLength(50);

                entity.Property(e => e.StatusDelRec)
                    .HasColumnName("Status_DelRec")
                    .HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(200);
            });

            modelBuilder.Entity<ElectionBallotDetails>(entity =>
            {
                entity.HasKey(e => e.SysPkElecBaltDetl);

                entity.ToTable("Election_Ballot_Details");

                entity.Property(e => e.SysPkElecBaltDetl)
                    .HasColumnName("SysPK_ElecBaltDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByElecBaltDetl)
                    .HasColumnName("LastUpdatedBy_ElecBaltDetl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdElecBaltDetl)
                    .HasColumnName("LastUpdatedConcurrencyID_ElecBaltDetl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateElecBaltDetl)
                    .HasColumnName("LastUpdatedDate_ElecBaltDetl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PositionElecBaltDetl)
                    .HasColumnName("Position_ElecBaltDetl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkElecBaltHdrElecBaltDetl)
                    .HasColumnName("SysFK_ElecBaltHdr_ElecBaltDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmvoteForElecBaltDetl)
                    .HasColumnName("SysFK_UMVoteFor_ElecBaltDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmvotedByElecBaltDetl)
                    .HasColumnName("SysFK_UMVotedBy_ElecBaltDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqElecBaltDetl).HasColumnName("SysSeq_ElecBaltDetl");

                entity.Property(e => e.TypeElecBaltDetl)
                    .HasColumnName("Type_ElecBaltDetl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqElecBaltDetl).HasColumnName("UserSeq_ElecBaltDetl");
            });

            modelBuilder.Entity<ElectionBallotHeader>(entity =>
            {
                entity.HasKey(e => e.SysPkElecBaltHdr);

                entity.ToTable("Election_Ballot_Header");

                entity.Property(e => e.SysPkElecBaltHdr)
                    .HasColumnName("SysPK_ElecBaltHdr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByElecBaltHdr)
                    .HasColumnName("LastUpdatedBy_ElecBaltHdr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdElecBaltHdr)
                    .HasColumnName("LastUpdatedConcurrencyID_ElecBaltHdr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateElecBaltHdr)
                    .HasColumnName("LastUpdatedDate_ElecBaltHdr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleElecBaltHdr)
                    .HasColumnName("Module_ElecBaltHdr")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmElecBaltHdr)
                    .HasColumnName("SysFK_PM_ElecBaltHdr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqElecBaltHdr).HasColumnName("SysSeq_ElecBaltHdr");

                entity.Property(e => e.UserPkElecBaltHdr)
                    .HasColumnName("UserPK_ElecBaltHdr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqElecBaltHdr).HasColumnName("UserSeq_ElecBaltHdr");
            });

            modelBuilder.Entity<FacilityJunction>(entity =>
            {
                entity.HasKey(e => e.SysPkFaclJ);

                entity.ToTable("Facility_Junction");

                entity.Property(e => e.SysPkFaclJ)
                    .HasColumnName("SysPK_FaclJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByFaclJ)
                    .HasColumnName("LastUpdatedBy_FaclJ")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFaclJ)
                    .HasColumnName("LastUpdatedConcurrencyID_FaclJ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFaclJ)
                    .HasColumnName("LastUpdatedDate_FaclJ")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleFaclJ)
                    .HasColumnName("Module_FaclJ")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeFaclJ)
                    .HasColumnName("ModuleType_FaclJ")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkFacl01FaclJ)
                    .HasColumnName("SysFK_Facl01_FaclJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkFacl02FaclJ)
                    .HasColumnName("SysFK_Facl02_FaclJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkFacl03FaclJ)
                    .HasColumnName("SysFK_Facl03_FaclJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFaclJ).HasColumnName("SysSeq_FaclJ");

                entity.Property(e => e.UserSeqFaclJ).HasColumnName("UserSeq_FaclJ");
            });

            modelBuilder.Entity<FacilityMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkFacl);

                entity.ToTable("Facility_Master");

                entity.Property(e => e.SysPkFacl)
                    .HasColumnName("SysPK_Facl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccomodationFacl)
                    .HasColumnName("Accomodation_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.AmenitiesFacl)
                    .HasColumnName("Amenities_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.CapacityFacl)
                    .HasColumnName("Capacity_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryFacl)
                    .HasColumnName("Category_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdFacl)
                    .HasColumnName("CBD_Facl")
                    .HasColumnType("money");

                entity.Property(e => e.ClassificationFacl)
                    .HasColumnName("Classification_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionFacl)
                    .HasColumnName("Description_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.IsFacl)
                    .HasColumnName("Is_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByFacl)
                    .HasColumnName("LastUpdatedBy_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFacl)
                    .HasColumnName("LastUpdatedConcurrencyID_Facl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFacl)
                    .HasColumnName("LastUpdatedDate_Facl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationFacl)
                    .HasColumnName("Location_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleFacl)
                    .HasColumnName("Module_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeFacl)
                    .HasColumnName("ModuleType_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.NameFacl)
                    .HasColumnName("Name_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.PaxFacl)
                    .HasColumnName("Pax_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureFileNameFacl)
                    .HasColumnName("PictureFileName_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.RemarksFacl)
                    .HasColumnName("Remarks_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.SizeFacl)
                    .HasColumnName("Size_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusFacl)
                    .HasColumnName("Status_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.SubCategoryFacl)
                    .HasColumnName("SubCategory_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkFaclParentFacl)
                    .HasColumnName("SysFK_FaclParent_Facl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFacl).HasColumnName("SysSeq_Facl");

                entity.Property(e => e.TypeFacl)
                    .HasColumnName("Type_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFacl)
                    .HasColumnName("UserPK_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFacl).HasColumnName("UserSeq_Facl");
            });

            modelBuilder.Entity<FacilityPrices>(entity =>
            {
                entity.HasKey(e => e.SysPkFaclPrice);

                entity.ToTable("Facility_Prices");

                entity.Property(e => e.SysPkFaclPrice)
                    .HasColumnName("SysPK_FaclPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateEffectiveFaclPrice)
                    .HasColumnName("DateEffective_FaclPrice")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DiscountFaclPrice)
                    .HasColumnName("Discount_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.HoursFaclPrice)
                    .HasColumnName("Hours_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.IsFaclPrice)
                    .HasColumnName("Is_FaclPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByFaclPrice)
                    .HasColumnName("LastUpdatedBy_FaclPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFaclPrice)
                    .HasColumnName("LastUpdatedConcurrencyID_FaclPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFaclPrice)
                    .HasColumnName("LastUpdatedDate_FaclPrice")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleFaclPrice)
                    .HasColumnName("Module_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.PromoRemarksFaclPrice)
                    .HasColumnName("PromoRemarks_FaclPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.RegularPriceFaclPrice)
                    .HasColumnName("RegularPrice_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingPriceFaclPrice)
                    .HasColumnName("SellingPrice_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingPriceMinimumFaclPrice)
                    .HasColumnName("SellingPriceMinimum_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ServiceChargeFaclPrice)
                    .HasColumnName("ServiceCharge_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.StatusFaclPrice)
                    .HasColumnName("Status_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkFaclFaclPrice)
                    .HasColumnName("SysFK_Facl_FaclPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFaclPrice).HasColumnName("SysSeq_FaclPrice");

                entity.Property(e => e.TaxFaclPrice)
                    .HasColumnName("Tax_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.TypeFaclPrice)
                    .HasColumnName("Type_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFaclPrice)
                    .HasColumnName("UserPK_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFaclPrice).HasColumnName("UserSeq_FaclPrice");
            });

            modelBuilder.Entity<FranchiseMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkFrchMstr);

                entity.ToTable("Franchise_Master");

                entity.Property(e => e.SysPkFrchMstr)
                    .HasColumnName("SysPK_FrchMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AttachedDescription01FrchMstr)
                    .HasColumnName("AttachedDescription01_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.AttachedDescription02FrchMstr)
                    .HasColumnName("AttachedDescription02_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.AttachedDescription03FrchMstr)
                    .HasColumnName("AttachedDescription03_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.AttachedFileName01FrchMstr)
                    .HasColumnName("AttachedFileName01_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.AttachedFileName02FrchMstr)
                    .HasColumnName("AttachedFileName02_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.AttachedFileName03FrchMstr)
                    .HasColumnName("AttachedFileName03_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.BldgAreaInSqMtrFrchMstr)
                    .HasColumnName("BldgAreaInSqMtr_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.BldgDepthOfSiteFrchMstr)
                    .HasColumnName("BldgDepthOfSite_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.BldgEscalationFrchMstr)
                    .HasColumnName("BldgEscalation_FrchMstr")
                    .HasColumnType("money");

                entity.Property(e => e.BldgFrontageMeasureFrchMstr)
                    .HasColumnName("BldgFrontageMeasure_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.BldgLeaseAmountFrchMstr)
                    .HasColumnName("BldgLeaseAmount_FrchMstr")
                    .HasColumnType("money");

                entity.Property(e => e.BldgLessorNameFrchMstr)
                    .HasColumnName("BldgLessorName_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.BldgOccupiedFloorsFrchMstr)
                    .HasColumnName("BldgOccupiedFloors_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.BldgRemarksFrchMstr)
                    .HasColumnName("BldgRemarks_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.BldgRentalDepositFrchMstr)
                    .HasColumnName("BldgRentalDeposit_FrchMstr")
                    .HasColumnType("money");

                entity.Property(e => e.BldgTermsYearsFrchMstr)
                    .HasColumnName("BldgTermsYears_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.BldgTotalNumOfFloorsFrchMstr).HasColumnName("BldgTotalNumOfFloors_FrchMstr");

                entity.Property(e => e.BldgTypeFrchMstr)
                    .HasColumnName("BldgType_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdFrchMstr)
                    .HasColumnName("CBD_FrchMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateApprovedFrchMstr)
                    .HasColumnName("DateApproved_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateCommunityTaxCertificateFrchMstr)
                    .HasColumnName("DateCommunityTaxCertificate_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateContractofLeaseFrchMstr)
                    .HasColumnName("DateContractofLease_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFranchiseAgreementFrchMstr)
                    .HasColumnName("DateFranchiseAgreement_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateGrandOpenFrchMstr)
                    .HasColumnName("DateGrandOpen_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateLeaseAssignmentAgreementFrchMstr)
                    .HasColumnName("DateLeaseAssignmentAgreement_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateLetterOfIntentFrchMstr)
                    .HasColumnName("DateLetterOfIntent_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateLetterOfIntentToLeaseFrchMstr)
                    .HasColumnName("DateLetterOfIntentToLease_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateLocationMapFrchMstr)
                    .HasColumnName("DateLocationMap_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateMarketStudyFrchMstr)
                    .HasColumnName("DateMarketStudy_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateMarketVerificationFrchMstr)
                    .HasColumnName("DateMarketVerification_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateSoftOpenFrchMstr)
                    .HasColumnName("DateSoftOpen_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTaxDeclarationFrchMstr)
                    .HasColumnName("DateTaxDeclaration_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTransferCertificateOfTitleFrchMstr)
                    .HasColumnName("DateTransferCertificateOfTitle_FrchMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InclusiveDateFrchMstr)
                    .HasColumnName("InclusiveDate_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.IsRecommendedFrchMstr).HasColumnName("IsRecommended_FrchMstr");

                entity.Property(e => e.LastUpdatedByFrchMstr)
                    .HasColumnName("LastUpdatedBy_FrchMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFrchMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_FrchMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFrchMstr)
                    .HasColumnName("LastUpdatedDate_FrchMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MktChar01FrchMstr).HasColumnName("MktChar01_FrchMstr");

                entity.Property(e => e.MktChar02FrchMstr).HasColumnName("MktChar02_FrchMstr");

                entity.Property(e => e.MktChar03FrchMstr).HasColumnName("MktChar03_FrchMstr");

                entity.Property(e => e.MktChar04FrchMstr).HasColumnName("MktChar04_FrchMstr");

                entity.Property(e => e.MktChar05FrchMstr).HasColumnName("MktChar05_FrchMstr");

                entity.Property(e => e.MktChar06FrchMstr).HasColumnName("MktChar06_FrchMstr");

                entity.Property(e => e.MktChar07FrchMstr).HasColumnName("MktChar07_FrchMstr");

                entity.Property(e => e.MktChar08FrchMstr).HasColumnName("MktChar08_FrchMstr");

                entity.Property(e => e.MktChar09FrchMstr).HasColumnName("MktChar09_FrchMstr");

                entity.Property(e => e.MktChar10FrchMstr).HasColumnName("MktChar10_FrchMstr");

                entity.Property(e => e.MktChar11FrchMstr).HasColumnName("MktChar11_FrchMstr");

                entity.Property(e => e.MktChar12FrchMstr).HasColumnName("MktChar12_FrchMstr");

                entity.Property(e => e.MktCharOthersFrchMstr)
                    .HasColumnName("MktCharOthers_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.ModuleFrchMstr)
                    .HasColumnName("Module_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.NameOfFrchMstr)
                    .HasColumnName("NameOf_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsAccessiblityFrchMstr)
                    .HasColumnName("ParticularsAccessiblity_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.ParticularsFrchMstr)
                    .HasColumnName("Particulars_FrchMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.ParticularsSketchFrchMstr)
                    .HasColumnName("ParticularsSketch_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.PictureSketchPlanFrchMstr)
                    .HasColumnName("PictureSketchPlan_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.PictureVicinityMapFrchMstr)
                    .HasColumnName("PictureVicinityMap_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.SiteAdvantageFrchMstr)
                    .HasColumnName("SiteAdvantage_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.SiteAdvantageRecommendedFrchMstr)
                    .HasColumnName("SiteAdvantageRecommended_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.SiteDisAdvantageFrchMstr)
                    .HasColumnName("SiteDisAdvantage_FrchMstr")
                    .HasColumnType("text");

                entity.Property(e => e.StatusApprovalFrchMstr)
                    .HasColumnName("StatusApproval_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusFrchMstr)
                    .HasColumnName("Status_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusOperationFrchMstr)
                    .HasColumnName("StatusOperation_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkUmfranchiseeFrchMstr)
                    .HasColumnName("SysFK_UMFranchisee_FrchMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFrchMstr).HasColumnName("SysSeq_FrchMstr");

                entity.Property(e => e.TypeBranchFrchMstr)
                    .HasColumnName("TypeBranch_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeFrchMstr)
                    .HasColumnName("Type_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkAreaFrchMstr)
                    .HasColumnName("UserFK_Area_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkBranchFrchMstr)
                    .HasColumnName("UserFK_Branch_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkRegionFrchMstr)
                    .HasColumnName("UserFK_Region_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFrchMstr)
                    .HasColumnName("UserPK_FrchMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFrchMstr).HasColumnName("UserSeq_FrchMstr");
            });

            modelBuilder.Entity<FranchiseSocioEconomic>(entity =>
            {
                entity.HasKey(e => e.SysPkFrchSeco);

                entity.ToTable("Franchise_SocioEconomic");

                entity.Property(e => e.SysPkFrchSeco)
                    .HasColumnName("SysPK_FrchSEco")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AreaFrchSeco)
                    .HasColumnName("Area_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.AvgIncomeFrchSeco)
                    .HasColumnName("AvgIncome_FrchSEco")
                    .HasColumnType("money");

                entity.Property(e => e.DistanceKmFrchSeco).HasColumnName("DistanceKm_FrchSEco");

                entity.Property(e => e.HouseholdFrchSeco).HasColumnName("Household_FrchSEco");

                entity.Property(e => e.LastUpdatedByFrchSeco)
                    .HasColumnName("LastUpdatedBy_FrchSEco")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFrchSeco)
                    .HasColumnName("LastUpdatedConcurrencyID_FrchSEco")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFrchSeco)
                    .HasColumnName("LastUpdatedDate_FrchSEco")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleFrchSeco)
                    .HasColumnName("Module_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.NameFrchSeco)
                    .HasColumnName("Name_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsFrchSeco)
                    .HasColumnName("Particulars_FrchSEco")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameFrchSeco)
                    .HasColumnName("PictureFileName_FrchSEco")
                    .HasMaxLength(255);

                entity.Property(e => e.PopulationFrchSeco)
                    .HasColumnName("Population_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductFrchSeco)
                    .HasColumnName("Product_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusFrchSeco)
                    .HasColumnName("Status_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkFrchMstrFrchSeco)
                    .HasColumnName("SysFK_FrchMstr_FrchSEco")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFrchSeco).HasColumnName("SysSeq_FrchSEco");

                entity.Property(e => e.TypeFrchSeco)
                    .HasColumnName("Type_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFrchSeco)
                    .HasColumnName("UserPK_FrchSEco")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFrchSeco).HasColumnName("UserSeq_FrchSEco");

                entity.Property(e => e.YearFrchSeco)
                    .HasColumnName("Year_FrchSEco")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GenericClassMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkGenClass);

                entity.ToTable("GenericClass_Master");

                entity.Property(e => e.SysPkGenClass)
                    .HasColumnName("SysPK_GenClass")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByGenClass)
                    .HasColumnName("LastUpdatedBy_GenClass")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGenClass)
                    .HasColumnName("LastUpdatedConcurrencyID_GenClass")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGenClass)
                    .HasColumnName("LastUpdatedDate_GenClass")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LevelGenClass).HasColumnName("Level_GenClass");

                entity.Property(e => e.ParticularsGenClass)
                    .HasColumnName("Particulars_GenClass")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusGenClass)
                    .HasColumnName("Status_GenClass")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkGenClassGenClass)
                    .HasColumnName("SysFK_GenClass_GenClass")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TypeGenClass)
                    .HasColumnName("Type_GenClass")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkGenClass)
                    .HasColumnName("UserPK_GenClass")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GuestRegistrationCompanions>(entity =>
            {
                entity.HasKey(e => e.SysPkGcomp);

                entity.ToTable("GuestRegistration_Companions");

                entity.Property(e => e.SysPkGcomp)
                    .HasColumnName("SysPK_GComp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CountryGcomp)
                    .HasColumnName("Country_GComp")
                    .HasMaxLength(50);

                entity.Property(e => e.IsGcomp)
                    .HasColumnName("Is_GComp")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByGcomp)
                    .HasColumnName("LastUpdatedBy_GComp")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGcomp)
                    .HasColumnName("LastUpdatedConcurrencyID_GComp")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGcomp)
                    .HasColumnName("LastUpdatedDate_GComp")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleGcomp)
                    .HasColumnName("Module_GComp")
                    .HasMaxLength(50);

                entity.Property(e => e.NameGcomp)
                    .HasColumnName("Name_GComp")
                    .HasMaxLength(50);

                entity.Property(e => e.NationalityGcomp)
                    .HasColumnName("Nationality_GComp")
                    .HasMaxLength(50);

                entity.Property(e => e.PassportRemarksGcomp)
                    .HasColumnName("PassportRemarks_GComp")
                    .HasMaxLength(255);

                entity.Property(e => e.PaxGcomp).HasColumnName("PAX_GComp");

                entity.Property(e => e.PictureFileNameGcomp)
                    .HasColumnName("PictureFileName_GComp")
                    .HasMaxLength(255);

                entity.Property(e => e.RemarksGcomp)
                    .HasColumnName("Remarks_GComp")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkFaclGcomp)
                    .HasColumnName("SysFK_Facl_GComp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGregGcomp)
                    .HasColumnName("SysFK_Greg_GComp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyGcomp)
                    .HasColumnName("SysFK_Invty_GComp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqGcomp).HasColumnName("SysSeq_GComp");

                entity.Property(e => e.UserFkFaclGcomp)
                    .HasColumnName("UserFK_Facl_GComp")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkGcomp)
                    .HasColumnName("UserPK_GComp")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqGcomp).HasColumnName("UserSeq_GComp");
            });

            modelBuilder.Entity<GuestRegistrationFacilities>(entity =>
            {
                entity.HasKey(e => e.SysPkGfacl);

                entity.ToTable("GuestRegistration_Facilities");

                entity.Property(e => e.SysPkGfacl)
                    .HasColumnName("SysPK_GFacl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CheckInByGfacl)
                    .HasColumnName("CheckInBy_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckInDutyShiftGfacl)
                    .HasColumnName("CheckInDutyShift_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckOutByGfacl)
                    .HasColumnName("CheckOutBy_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckOutDutyShiftGfacl)
                    .HasColumnName("CheckOutDutyShift_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckOutHousekeepingByGfacl)
                    .HasColumnName("CheckOutHousekeepingBy_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckOutSecurityGuardByGfacl)
                    .HasColumnName("CheckOutSecurityGuardBy_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfirmedOnByGfacl)
                    .HasColumnName("ConfirmedOnBy_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.DateCheckInGfacl)
                    .HasColumnName("DateCheckIn_GFacl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateCheckOutGfacl)
                    .HasColumnName("DateCheckOut_GFacl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateReservedGfacl)
                    .HasColumnName("DateReserved_GFacl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.FaclAmountGfacl)
                    .HasColumnName("FaclAmount_GFacl")
                    .HasColumnType("money");

                entity.Property(e => e.FaclAmountUnitGfacl)
                    .HasColumnName("FaclAmountUnit_GFacl")
                    .HasColumnType("money");

                entity.Property(e => e.FaclParticularsGfacl)
                    .HasColumnName("FaclParticulars_GFacl")
                    .HasMaxLength(255);

                entity.Property(e => e.HoursStayingGfacl).HasColumnName("HoursStaying_GFacl");

                entity.Property(e => e.InstructionGfacl)
                    .HasColumnName("Instruction_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.IsGfacl)
                    .HasColumnName("Is_GFacl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByGfacl)
                    .HasColumnName("LastUpdatedBy_GFacl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGfacl)
                    .HasColumnName("LastUpdatedConcurrencyID_GFacl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGfacl)
                    .HasColumnName("LastUpdatedDate_GFacl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleGfacl)
                    .HasColumnName("Module_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleSubTypeGfacl)
                    .HasColumnName("ModuleSubType_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeGfacl)
                    .HasColumnName("ModuleType_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.NightsStayingGfacl).HasColumnName("NightsStaying_GFacl");

                entity.Property(e => e.OtherStatusByGfacl)
                    .HasColumnName("OtherStatusBy_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherStatusDutyShiftGfacl)
                    .HasColumnName("OtherStatusDutyShift_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.PaxGfacl).HasColumnName("PAX_GFacl");

                entity.Property(e => e.PromoRemarksGfacl)
                    .HasColumnName("PromoRemarks_GFacl")
                    .HasMaxLength(255);

                entity.Property(e => e.QtyOutGfacl)
                    .HasColumnName("QtyOut_GFacl")
                    .HasColumnType("money");

                entity.Property(e => e.RemarksGfacl)
                    .HasColumnName("Remarks_GFacl")
                    .HasMaxLength(255);

                entity.Property(e => e.ReservedDutyByGfacl)
                    .HasColumnName("ReservedDutyBy_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.ReservedDutyShiftGfacl)
                    .HasColumnName("ReservedDutyShift_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.SetupGfacl)
                    .HasColumnName("Setup_GFacl")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusGfacl)
                    .HasColumnName("Status_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusReasonGfacl)
                    .HasColumnName("StatusReason_GFacl")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusRegistrationGfacl)
                    .HasColumnName("StatusRegistration_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusReservationGfacl)
                    .HasColumnName("StatusReservation_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkFaclGfacl)
                    .HasColumnName("SysFK_Facl_GFacl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGregGfacl)
                    .HasColumnName("SysFK_GReg_GFacl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyGfacl)
                    .HasColumnName("SysFK_Invty_GFacl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqGfacl).HasColumnName("SysSeq_GFacl");

                entity.Property(e => e.TimeCheckInGfacl)
                    .HasColumnName("TimeCheckIn_GFacl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeCheckOutGfacl)
                    .HasColumnName("TimeCheckOut_GFacl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeReservedGfacl)
                    .HasColumnName("TimeReserved_GFacl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TypeRegistrationGfacl)
                    .HasColumnName("TypeRegistration_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeReservationGfacl)
                    .HasColumnName("TypeReservation_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkFaclGfacl)
                    .HasColumnName("UserFK_Facl_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkFaclPricesGfacl)
                    .HasColumnName("UserFK_FaclPrices_GFacl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqGfacl).HasColumnName("UserSeq_GFacl");
            });

            modelBuilder.Entity<GuestRegistrationFaclBlocking>(entity =>
            {
                entity.HasKey(e => e.SysPkGfaclB);

                entity.ToTable("GuestRegistration_FaclBlocking");

                entity.Property(e => e.SysPkGfaclB)
                    .HasColumnName("SysPK_GFaclB")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateBlockedGfaclB)
                    .HasColumnName("DateBlocked_GFaclB")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DayCountGfaclB).HasColumnName("DayCount_GFaclB");

                entity.Property(e => e.HourBlockedEndGfaclB)
                    .HasColumnName("HourBlockedEnd_GFaclB")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HourBlockedStartGfaclB)
                    .HasColumnName("HourBlockedStart_GFaclB")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HourBlockedTotalGfaclB)
                    .HasColumnName("HourBlockedTotal_GFaclB")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByGfaclB)
                    .HasColumnName("LastUpdatedBy_GFaclB")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGfaclB)
                    .HasColumnName("LastUpdatedConcurrencyID_GFaclB")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGfaclB)
                    .HasColumnName("LastUpdatedDate_GFaclB")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SysFkFaclGfaclB)
                    .HasColumnName("SysFK_Facl_GFaclB")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGfaclGfaclB)
                    .HasColumnName("SysFK_GFacl_GFaclB")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGregGfaclB)
                    .HasColumnName("SysFK_GReg_GFaclB")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqGfaclB).HasColumnName("SysSeq_GFaclB");
            });

            modelBuilder.Entity<GuestRegistrationHeader>(entity =>
            {
                entity.HasKey(e => e.SysPkGreg);

                entity.ToTable("GuestRegistration_Header");

                entity.Property(e => e.SysPkGreg)
                    .HasColumnName("SysPK_GReg")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Address2Greg)
                    .HasColumnName("Address2_GReg")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressGreg)
                    .HasColumnName("Address_GReg")
                    .HasMaxLength(255);

                entity.Property(e => e.BookingNameGreg)
                    .HasColumnName("BookingName_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdGreg)
                    .HasColumnName("CBD_GReg")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ClassificationGreg)
                    .HasColumnName("Classification_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfidentialGreg).HasColumnName("Confidential_GReg");

                entity.Property(e => e.DateIssueGreg)
                    .HasColumnName("DateIssue_GReg")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultCreditCardBankGreg)
                    .HasColumnName("DefaultCreditCardBank_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultCreditCardNumGreg)
                    .HasColumnName("DefaultCreditCardNum_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.DefaultCreditCardTypeGreg)
                    .HasColumnName("DefaultCreditCardType_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.DepositGreg)
                    .HasColumnName("Deposit_GReg")
                    .HasColumnType("money");

                entity.Property(e => e.DepositReceiptNumGreg)
                    .HasColumnName("DepositReceiptNum_Greg")
                    .HasMaxLength(50);

                entity.Property(e => e.FieldsBelowAreforRadonly)
                    .HasColumnName("fieldsBelowAreforRADOnly")
                    .HasMaxLength(50);

                entity.Property(e => e.InstructionGreg)
                    .HasColumnName("Instruction_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.IsConfidentialGreg).HasColumnName("IsConfidential_GReg");

                entity.Property(e => e.IsGreg)
                    .HasColumnName("Is_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.IsMealRequiredGreg).HasColumnName("IsMealRequired_GReg");

                entity.Property(e => e.IsMultipleRoomGreg).HasColumnName("IsMultipleRoom_GReg");

                entity.Property(e => e.LastUpdatedByGreg)
                    .HasColumnName("LastUpdatedBy_GReg")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGreg)
                    .HasColumnName("LastUpdatedConcurrencyID_GReg")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGreg)
                    .HasColumnName("LastUpdatedDate_GReg")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleGreg)
                    .HasColumnName("Module_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeGreg)
                    .HasColumnName("ModuleType_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.MultipleRoomGreg).HasColumnName("MultipleRoom_GReg");

                entity.Property(e => e.PaymentModeGreg)
                    .HasColumnName("PaymentMode_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.PreferenceRemarksGreg)
                    .HasColumnName("PreferenceRemarks_GReg")
                    .HasMaxLength(255);

                entity.Property(e => e.PromoRemarksGreg)
                    .HasColumnName("PromoRemarks_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksGreg)
                    .HasColumnName("Remarks_GReg")
                    .HasMaxLength(255);

                entity.Property(e => e.SequencePkGreg).HasColumnName("SequencePK_GReg");

                entity.Property(e => e.SourceGreg)
                    .HasColumnName("Source_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAgentGreg)
                    .HasColumnName("SysFK_Agent_GReg")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkChargeToAcctGreg)
                    .HasColumnName("SysFK_ChargeToAcct_GReg")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGregGreg)
                    .HasColumnName("SysFK_GReg_GReg")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TelNum2Greg)
                    .HasColumnName("TelNum2_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.TelNumGreg)
                    .HasColumnName("TelNum_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalFaclAmountGreg)
                    .HasColumnName("TotalFaclAmount_GReg")
                    .HasColumnType("money");

                entity.Property(e => e.TotalFaclAmountUnitGreg)
                    .HasColumnName("TotalFaclAmountUnit_GReg")
                    .HasColumnType("money");

                entity.Property(e => e.TransporationsDetailsGreg)
                    .HasColumnName("TransporationsDetails_GReg")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeGuestGreg)
                    .HasColumnName("TypeGuest_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkGreg)
                    .HasColumnName("UserPK_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkreservationGreg)
                    .HasColumnName("UserPKReservation_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.VoyageArrivalRemarksGreg)
                    .HasColumnName("VoyageArrivalRemarks_GReg")
                    .HasMaxLength(50);

                entity.Property(e => e.VoyageDepartureRemarksGreg)
                    .HasColumnName("VoyageDepartureRemarks_GReg")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GuestTransactions>(entity =>
            {
                entity.HasKey(e => e.SysPkGtrans);

                entity.ToTable("Guest_Transactions");

                entity.Property(e => e.SysPkGtrans)
                    .HasColumnName("SysPK_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountBalanceGtrans)
                    .HasColumnName("AmountBalance_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountChargesGtrans)
                    .HasColumnName("AmountCharges_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountChargesTransferGtrans)
                    .HasColumnName("AmountChargesTransfer_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountCommissionGtrans)
                    .HasColumnName("AmountCommission_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountCommissionRateGtrans)
                    .HasColumnName("AmountCommissionRate_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.AmountPaymentsGtrans)
                    .HasColumnName("AmountPayments_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPaymentsPdcGtrans)
                    .HasColumnName("AmountPaymentsPDC_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountRefundsGtrans)
                    .HasColumnName("AmountRefunds_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountRushGtrans)
                    .HasColumnName("AmountRush_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountServiceChargeGtrans)
                    .HasColumnName("AmountServiceCharge_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountTaxGtrans)
                    .HasColumnName("AmountTax_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountTaxRateGtrans)
                    .HasColumnName("AmountTaxRate_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.AmountTotalCreditGtrans)
                    .HasColumnName("AmountTotalCredit_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountTotalDebitGtrans)
                    .HasColumnName("AmountTotalDebit_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.ByCashierGtrans)
                    .HasColumnName("ByCashier_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ByFrontOfficeGtrans)
                    .HasColumnName("ByFrontOffice_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ByHousekeepingGtrans)
                    .HasColumnName("ByHousekeeping_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ByWaiterGtrans)
                    .HasColumnName("ByWaiter_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdGtrans)
                    .HasColumnName("CBD_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardCheckBankGtrans)
                    .HasColumnName("CreditCardCheckBank_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardCheckNumGtrans)
                    .HasColumnName("CreditCardCheckNum_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardCheckTypeGtrans)
                    .HasColumnName("CreditCardCheckType_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.DateActualGtrans)
                    .HasColumnName("DateActual_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueGtrans)
                    .HasColumnName("DateIssue_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeCutOffGtrans)
                    .HasColumnName("DateTimeCutOff_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeEndGtrans)
                    .HasColumnName("DateTimeEnd_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeStartGtrans)
                    .HasColumnName("DateTimeStart_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DiscountedUnitPriceInGtrans)
                    .HasColumnName("DiscountedUnitPriceIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DiscountedUnitPriceOutGtrans)
                    .HasColumnName("DiscountedUnitPriceOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayDiscountGtrans)
                    .HasColumnName("DisplayDiscount_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayQtyAdditionalGtrans)
                    .HasColumnName("DisplayQtyAdditional_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyBeginGtrans)
                    .HasColumnName("DisplayQtyBegin_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyDamagedGtrans)
                    .HasColumnName("DisplayQtyDamaged_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyEndGtrans)
                    .HasColumnName("DisplayQtyEnd_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyInGtrans)
                    .HasColumnName("DisplayQtyIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyOutGtrans)
                    .HasColumnName("DisplayQtyOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalInGtrans)
                    .HasColumnName("DisplaySubTotalIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalOutGtrans)
                    .HasColumnName("DisplaySubTotalOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitMeasureGtrans)
                    .HasColumnName("DisplayUnitMeasure_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitPriceInGtrans)
                    .HasColumnName("DisplayUnitPriceIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitPriceOutGtrans)
                    .HasColumnName("DisplayUnitPriceOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.IsGtrans)
                    .HasColumnName("Is_GTrans")
                    .HasMaxLength(255);

                entity.Property(e => e.IsRushedGtrans).HasColumnName("IsRushed_GTrans");

                entity.Property(e => e.IsServiceChargedGtrans).HasColumnName("IsServiceCharged_GTrans");

                entity.Property(e => e.LastUpdatedByGtrans)
                    .HasColumnName("LastUpdatedBy_GTrans")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGtrans)
                    .HasColumnName("LastUpdatedConcurrencyID_GTrans")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGtrans)
                    .HasColumnName("LastUpdatedDate_GTrans")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleGtrans)
                    .HasColumnName("Module_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleLedgerGtrans)
                    .HasColumnName("ModuleLedger_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleSubTypeGtrans)
                    .HasColumnName("ModuleSubType_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeGtrans)
                    .HasColumnName("ModuleType_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentForGtrans)
                    .HasColumnName("PaymentFor_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentModeGtrans)
                    .HasColumnName("PaymentMode_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDocAmountGtrans)
                    .HasColumnName("ReferenceDocAmount_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceDocByGtrans)
                    .HasColumnName("ReferenceDocBy_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDocDateGtrans)
                    .HasColumnName("ReferenceDocDate_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReferenceDocNumGtrans)
                    .HasColumnName("ReferenceDocNum_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksGtrans)
                    .HasColumnName("Remarks_GTrans")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusGtrans)
                    .HasColumnName("Status_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAccountGtrans)
                    .HasColumnName("SysFK_Account_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkAgentGtrans)
                    .HasColumnName("SysFK_Agent_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkFaclGtrans)
                    .HasColumnName("SysFK_Facl_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkGcompGtrans)
                    .HasColumnName("SysFK_GComp_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkGfaclGtrans)
                    .HasColumnName("SysFK_GFacl_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkGregGtrans)
                    .HasColumnName("SysFK_GReg_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkGtransParentGtrans)
                    .HasColumnName("SysFK_GTransParent_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLedgerTransHGtrans)
                    .HasColumnName("SysFK_LedgerTransH_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkSourceDocumentGtrans)
                    .HasColumnName("SysFK_SourceDocument_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqGtrans).HasColumnName("SysSeq_GTrans");

                entity.Property(e => e.TelNumGtrans)
                    .HasColumnName("TelNum_GTrans")
                    .HasMaxLength(100);

                entity.Property(e => e.TimeActualGtrans)
                    .HasColumnName("TimeActual_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeGtrans)
                    .HasColumnName("Type_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkFaclPriceGtrans)
                    .HasColumnName("UserFK_FaclPrice_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPaymentModeGtrans)
                    .HasColumnName("UserFK_PaymentMode_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkGtrans)
                    .HasColumnName("UserPK_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqGtrans).HasColumnName("UserSeq_GTrans");
            });

            modelBuilder.Entity<HolidayMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkHdayM);

                entity.ToTable("Holiday_Master");

                entity.Property(e => e.SysPkHdayM)
                    .HasColumnName("SysPK_HdayM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdHdayM)
                    .HasColumnName("CBD_HdayM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DayHdayM).HasColumnName("Day_HdayM");

                entity.Property(e => e.DescriptionHdayM)
                    .HasColumnName("Description_HdayM")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByHdayM)
                    .HasColumnName("LastUpdatedBy_HdayM")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdHdayM)
                    .HasColumnName("LastUpdatedConcurrencyID_HdayM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateHdayM)
                    .HasColumnName("LastUpdatedDate_HdayM")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleHdayM)
                    .HasColumnName("Module_HdayM")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthHdayM).HasColumnName("Month_HdayM");

                entity.Property(e => e.SysFkHdayMHdayM)
                    .HasColumnName("SysFK_HdayM_HdayM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqHdayM).HasColumnName("SysSeq_HdayM");

                entity.Property(e => e.TypeHdayM)
                    .HasColumnName("Type_HdayM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkHdayM)
                    .HasColumnName("UserPK_HdayM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqHdayM).HasColumnName("UserSeq_HdayM");

                entity.Property(e => e.WeekDayHdayM)
                    .HasColumnName("WeekDay_HDayM")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<InventoryMaster2>(entity =>
            {
                entity.HasKey(e => e.SysPkInvty);

                entity.ToTable("Inventory_Master2");

                entity.HasIndex(e => e.DescriptionInvty)
                    .HasName("IX_Inventory_Master2_1");

                entity.HasIndex(e => e.ModuleInvty)
                    .HasName("IXModule_Inventory_Master2_2");

                entity.HasIndex(e => e.UserPkInvty)
                    .HasName("IX_Inventory_Master2");

                entity.Property(e => e.SysPkInvty)
                    .HasColumnName("SysPK_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ArefInvty)
                    .HasColumnName("ARef_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.AverageDailyMovementInvty).HasColumnName("AverageDailyMovement_Invty");

                entity.Property(e => e.AvgCostInvty)
                    .HasColumnName("AvgCost_invty")
                    .HasColumnType("money");

                entity.Property(e => e.BarCodeInvty)
                    .HasColumnName("BarCode_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.BaseUnitOfMeasureInvty)
                    .HasColumnName("BaseUnitOfMeasure_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.BaseUnitQtyInvty)
                    .HasColumnName("BaseUnitQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyLogInvty)
                    .HasColumnName("BaseUnitQtyLog_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.BrandInvty)
                    .HasColumnName("Brand_Invty")
                    .HasMaxLength(254);

                entity.Property(e => e.CategoryInvty)
                    .HasColumnName("Category_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdInvty)
                    .HasColumnName("CBD_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CcodeInvty)
                    .HasColumnName("CCode_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.ClassificationInvty)
                    .HasColumnName("Classification_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.ColorInvty)
                    .HasColumnName("Color_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.CurrentCostInvty)
                    .HasColumnName("CurrentCost_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.DescriptionInvty)
                    .HasColumnName("Description_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionShortInvty)
                    .HasColumnName("DescriptionShort_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionSpeakInvty)
                    .HasColumnName("DescriptionSpeak_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.DescriptionSupplierInvty)
                    .HasColumnName("DescriptionSupplier_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.EnglishDimensionsInvty)
                    .HasColumnName("EnglishDimensions_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.FlagInvty)
                    .HasColumnName("Flag_Invty")
                    .HasMaxLength(12);

                entity.Property(e => e.FormatInvty)
                    .HasColumnName("Format_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.GroupInvty)
                    .HasColumnName("Group_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.GroupPriceInvty)
                    .HasColumnName("GroupPrice_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.HasInvtySlInvty).HasColumnName("HasInvtySL_Invty");

                entity.Property(e => e.HtmlscriptInvty)
                    .HasColumnName("HTMLScript_Invty")
                    .HasColumnType("ntext");

                entity.Property(e => e.IsNonVatInvty).HasColumnName("IsNonVAT_Invty");

                entity.Property(e => e.IsPurchasedOnConsignmentInvty).HasColumnName("IsPurchasedOnConsignment_Invty");

                entity.Property(e => e.LastUpdatedByInvty)
                    .HasColumnName("LastUpdatedBy_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdInvty)
                    .HasColumnName("LastUpdatedConcurrencyID_Invty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateInvty)
                    .HasColumnName("LastUpdatedDate_Invty")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LatestArrivePriceAsOfInvty)
                    .HasColumnName("LatestArrivePriceAsOf_Invty")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LatestArrivePriceForeignInvty)
                    .HasColumnName("LatestArrivePriceForeign_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.LatestArrivePriceInvty)
                    .HasColumnName("LatestArrivePrice_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.LatestArriveQtyInvty)
                    .HasColumnName("LatestArriveQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.LatestPopriceAsOfInvty)
                    .HasColumnName("LatestPOPriceAsOf_Invty")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LatestPopriceForeignInvty)
                    .HasColumnName("LatestPOPriceForeign_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.LatestPopriceInvty)
                    .HasColumnName("LatestPOPrice_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.LatestPoqtyInvty)
                    .HasColumnName("LatestPOQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.LeadDaysInvty).HasColumnName("LeadDays_Invty");

                entity.Property(e => e.MadeInInvty)
                    .HasColumnName("MadeIn_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.MaximumSalesConsignmentQtyInvty)
                    .HasColumnName("MaximumSalesConsignmentQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.MaximumStockQtyInvty)
                    .HasColumnName("MaximumStockQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.MetricDimensionsInvty)
                    .HasColumnName("MetricDimensions_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.ModelInvty)
                    .HasColumnName("Model_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleInvty)
                    .HasColumnName("Module_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUserPkInvty)
                    .HasColumnName("ModuleUserPK_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.NextSubGroupInvty)
                    .HasColumnName("NextSubGroup_invty")
                    .HasMaxLength(50);

                entity.Property(e => e.OnOrderedQtyInvty)
                    .HasColumnName("OnOrderedQty_invty")
                    .HasColumnType("money");

                entity.Property(e => e.OrderqtyInvty)
                    .HasColumnName("Orderqty_invty")
                    .HasColumnType("money");

                entity.Property(e => e.ParticularsInvty)
                    .HasColumnName("Particulars_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.PatronageRefundInvty)
                    .HasColumnName("PatronageRefund_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.PhasedOutInvty)
                    .HasColumnName("PhasedOut_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureFileNameInvty)
                    .HasColumnName("PictureFileName_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchConsignQtyInvty)
                    .HasColumnName("PurchConsignQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.PurchQtyInvty)
                    .HasColumnName("PurchQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.PurchaseUnitBaseMultiplierInvty)
                    .HasColumnName("PurchaseUnitBaseMultiplier_invty")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.PurchaseUnitOfMeasureInvty)
                    .HasColumnName("PurchaseUnitOfMeasure_invty")
                    .HasMaxLength(50);

                entity.Property(e => e.RankInPurchaseAmountInvty).HasColumnName("RankInPurchaseAmount_Invty");

                entity.Property(e => e.RankInQtyInvty).HasColumnName("RankInQty_Invty");

                entity.Property(e => e.RankInSalesAmountInvty).HasColumnName("RankInSalesAmount_Invty");

                entity.Property(e => e.RankInvty)
                    .HasColumnName("Rank_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.RankParticularsInvty)
                    .HasColumnName("RankParticulars_Invty")
                    .HasMaxLength(100);

                entity.Property(e => e.ReorderLevelInvty)
                    .HasColumnName("ReorderLevel_invty")
                    .HasColumnType("money");

                entity.Property(e => e.RestockingQtyInvty)
                    .HasColumnName("RestockingQty_invty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesConsignQtyInvty)
                    .HasColumnName("SalesConsignQty_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.ShapeInvty)
                    .HasColumnName("Shape_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.ShortageFromRestockingQtyInvty).HasColumnName("ShortageFromRestockingQty_Invty");

                entity.Property(e => e.SizeInvty)
                    .HasColumnName("Size_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecificationInvty)
                    .HasColumnName("Specification_Invty")
                    .HasColumnType("ntext");

                entity.Property(e => e.SpeedInvty)
                    .HasColumnName("Speed_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusInvty)
                    .HasColumnName("Status_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.StyleInvty)
                    .HasColumnName("Style_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.SubCategoryInvty)
                    .HasColumnName("SubCategory_invty")
                    .HasMaxLength(50);

                entity.Property(e => e.SubGroupInvty)
                    .HasColumnName("SubGroup_invty")
                    .HasMaxLength(8);

                entity.Property(e => e.SysFkBatchInvtyInvty)
                    .HasColumnName("SysFK_BatchInvty_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaapInvty)
                    .HasColumnName("SysFK_COAAP_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaappnInvty)
                    .HasColumnName("SysFK_COAAPPN_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoaarInvty)
                    .HasColumnName("SysFK_COAAR_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoabranchPurchaseInvty)
                    .HasColumnName("SysFK_COABranchPurchase_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacompliPurchaseInvty)
                    .HasColumnName("SysFK_COACompliPurchase_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacompliSalesInvty)
                    .HasColumnName("SysFK_COACompliSales_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacostOfGoodsInvty)
                    .HasColumnName("SysFK_COACostOfGoods_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryInvty)
                    .HasColumnName("SysFK_COAInventory_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryPcsgnInvty)
                    .HasColumnName("SysFK_COAInventoryPCsgn_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryPscsgnInvty)
                    .HasColumnName("SysFK_COAInventoryPSCsgn_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryScsgnInvty)
                    .HasColumnName("SysFK_COAInventorySCsgn_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapcsgnInvty)
                    .HasColumnName("SysFK_COAPCsgn_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapolicyInvty)
                    .HasColumnName("SysFK_COAPolicy_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapurchaseDiscountInvty)
                    .HasColumnName("SysFK_COAPurchaseDiscount_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapurchaseInvty)
                    .HasColumnName("SysFK_COAPurchase_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoareturnPurchaseInvty)
                    .HasColumnName("SysFK_COAReturnPurchase_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoareturnSalesInvty)
                    .HasColumnName("SysFK_COAReturnSales_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesDiscountInvty)
                    .HasColumnName("SysFK_COASalesDiscount_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesInvty)
                    .HasColumnName("SysFK_COASales_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoascsgnInvty)
                    .HasColumnName("SysFK_COASCsgn_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDefaultDeptInvty)
                    .HasColumnName("SysFK_DefaultDept_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDefaultReceiveUnitMeasureInvty)
                    .HasColumnName("SysFK_DefaultReceiveUnitMeasure_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDefaultReleaseUnitMeasureInvty)
                    .HasColumnName("SysFK_DefaultReleaseUnitMeasure_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDefaultWrseInvty)
                    .HasColumnName("SysFK_DefaultWrse_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLastPurchaseInvty)
                    .HasColumnName("SysFK_LastPurchase_invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLastSalesInvty)
                    .HasColumnName("SysFK_LastSales_invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPreferredSupplierInvty)
                    .HasColumnName("SysFK_PreferredSupplier_invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHInvty)
                    .HasColumnName("SysFK_TransH_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmareaDefaultInvty)
                    .HasColumnName("SysFK_UMAreaDefault_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmsupplierDefaultInvty)
                    .HasColumnName("SysFK_UMSupplierDefault_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmwarehouseDefaultInvty)
                    .HasColumnName("SysFK_UMWarehouseDefault_Invty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TypeInvty)
                    .HasColumnName("Type_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UpcskuInvty)
                    .HasColumnName("UPCSKU_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkBatchInvtyInvty)
                    .HasColumnName("UserFK_BatchInvty_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkBranchInvty)
                    .HasColumnName("UserFK_Branch_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkDefaultDeptInvty)
                    .HasColumnName("UserFK_DefaultDept_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkDefaultWrseInvty)
                    .HasColumnName("UserFK_DefaultWrse_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkInvty)
                    .HasColumnName("UserPK_Invty")
                    .HasMaxLength(255);

                entity.Property(e => e.UserPkalternativeInvty)
                    .HasColumnName("UserPKAlternative_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkseqInvty)
                    .HasColumnName("UserPKSeq_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktimeStampInvty)
                    .HasColumnName("UserPKTimeStamp_Invty")
                    .HasColumnType("money");

                entity.Property(e => e.UserPktypeInvty)
                    .HasColumnName("UserPKType_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqInvty).HasColumnName("UserSeq_Invty");

                entity.Property(e => e.WhyNegativeQtyRemainingInvty)
                    .HasColumnName("WhyNegativeQtyRemaining_Invty")
                    .HasMaxLength(50);

                entity.Property(e => e.YtdasOfInvty)
                    .HasColumnName("YTDAsOf_invty")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.YtdbaseQtyBalInvty)
                    .HasColumnName("YTDBaseQtyBal_invty")
                    .HasColumnType("money");

                entity.Property(e => e.YtdbaseQtyInInvty)
                    .HasColumnName("YTDBaseQtyIn_invty")
                    .HasColumnType("money");

                entity.Property(e => e.YtdbaseQtyOutInvty)
                    .HasColumnName("YTDBaseQtyOut_invty")
                    .HasColumnType("money");

                entity.Property(e => e.YtdpurchasesInvty)
                    .HasColumnName("YTDPurchases_invty")
                    .HasColumnType("money");

                entity.Property(e => e.YtdsalesInvty)
                    .HasColumnName("YTDSales_invty")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<InventoryMaster2Components>(entity =>
            {
                entity.HasKey(e => e.SysPkInvtyCmpnt);

                entity.ToTable("Inventory_Master2_Components");

                entity.Property(e => e.SysPkInvtyCmpnt)
                    .HasColumnName("SysPK_InvtyCmpnt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ComponentQtyInvtyCmpnt)
                    .HasColumnName("ComponentQty_InvtyCmpnt")
                    .HasMaxLength(50);

                entity.Property(e => e.ComponentSubTotalInvtyCmpnt)
                    .HasColumnName("ComponentSubTotal_InvtyCmpnt")
                    .HasMaxLength(50);

                entity.Property(e => e.ComponentUnitBaseMultiplierInvtyCmpnt)
                    .HasColumnName("ComponentUnitBaseMultiplier_InvtyCmpnt")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.ComponentUnitPriceInvtyCmpnt)
                    .HasColumnName("ComponentUnitPrice_InvtyCmpnt")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByInvtyCmpnt)
                    .HasColumnName("LastUpdatedBy_InvtyCmpnt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdInvtyCmpnt)
                    .HasColumnName("LastUpdatedConcurrencyID_InvtyCmpnt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateInvtyCmpnt)
                    .HasColumnName("LastUpdatedDate_InvtyCmpnt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleInvtyCmpnt)
                    .HasColumnName("Module_InvtyCmpnt")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkComponentInvtyInvtyCmpnt)
                    .HasColumnName("SysFK_ComponentInvty_InvtyCmpnt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyInvtyCmpnt)
                    .HasColumnName("SysFK_Invty_InvtyCmpnt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyUnitMsrInvtyCmpnt)
                    .HasColumnName("SysFK_InvtyUnitMsr_InvtyCmpnt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserFkInvtyUnitMsrInvtyCmpnt)
                    .HasColumnName("UserFK_InvtyUnitMsr_InvtyCmpnt")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqInvtyCmpnt).HasColumnName("UserSeq_InvtyCmpnt");
            });

            modelBuilder.Entity<InventoryMaster2Facilities>(entity =>
            {
                entity.HasKey(e => e.SysPkFacl);

                entity.ToTable("Inventory_Master2_Facilities");

                entity.Property(e => e.SysPkFacl)
                    .HasColumnName("SysPK_Facl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccomodationFacl)
                    .HasColumnName("Accomodation_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.AmenitiesFacl)
                    .HasColumnName("Amenities_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.CapacityFacl)
                    .HasColumnName("Capacity_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryFacl)
                    .HasColumnName("Category_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassificationFacl)
                    .HasColumnName("Classification_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionFacl)
                    .HasColumnName("Description_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.IsFacl)
                    .HasColumnName("Is_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByFacl)
                    .HasColumnName("LastUpdatedBy_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFacl)
                    .HasColumnName("LastUpdatedConcurrencyID_Facl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFacl)
                    .HasColumnName("LastUpdatedDate_Facl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationFacl)
                    .HasColumnName("Location_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleFacl)
                    .HasColumnName("Module_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeFacl)
                    .HasColumnName("ModuleType_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.NameFacl)
                    .HasColumnName("Name_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.PaxFacl)
                    .HasColumnName("Pax_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureFileNameFacl)
                    .HasColumnName("PictureFileName_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.RemarksFacl)
                    .HasColumnName("Remarks_Facl")
                    .HasMaxLength(255);

                entity.Property(e => e.SizeFacl)
                    .HasColumnName("Size_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusFacl)
                    .HasColumnName("Status_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.SubCategoryFacl)
                    .HasColumnName("SubCategory_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkFaclParentFacl)
                    .HasColumnName("SysFK_FaclParent_Facl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyFacl)
                    .HasColumnName("SysFK_Invty_Facl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFacl).HasColumnName("SysSeq_Facl");

                entity.Property(e => e.TypeFacl)
                    .HasColumnName("Type_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkalternativeFacl)
                    .HasColumnName("UserPKAlternative_Facl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFacl).HasColumnName("UserSeq_Facl");
            });

            modelBuilder.Entity<InventoryMaster2FacilitiesPrices>(entity =>
            {
                entity.HasKey(e => e.SysPkFaclPrice);

                entity.ToTable("Inventory_Master2_Facilities_Prices");

                entity.Property(e => e.SysPkFaclPrice)
                    .HasColumnName("SysPK_FaclPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateEffectiveFaclPrice)
                    .HasColumnName("DateEffective_FaclPrice")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DiscountFaclPrice)
                    .HasColumnName("Discount_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.HoursFaclPrice)
                    .HasColumnName("Hours_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.IsFaclPrice)
                    .HasColumnName("Is_FaclPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByFaclPrice)
                    .HasColumnName("LastUpdatedBy_FaclPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFaclPrice)
                    .HasColumnName("LastUpdatedConcurrencyID_FaclPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFaclPrice)
                    .HasColumnName("LastUpdatedDate_FaclPrice")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleFaclPrice)
                    .HasColumnName("Module_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.PromoRemarksFaclPrice)
                    .HasColumnName("PromoRemarks_FaclPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.RegularPriceFaclPrice)
                    .HasColumnName("RegularPrice_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingPriceFaclPrice)
                    .HasColumnName("SellingPrice_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingPriceMinimumFaclPrice)
                    .HasColumnName("SellingPriceMinimum_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ServiceChargeFaclPrice)
                    .HasColumnName("ServiceCharge_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.StatusFaclPrice)
                    .HasColumnName("Status_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkFaclFaclPrice)
                    .HasColumnName("SysFK_Facl_FaclPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyInvtyPrice)
                    .HasColumnName("SysFK_Invty_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFaclPrice).HasColumnName("SysSeq_FaclPrice");

                entity.Property(e => e.TaxFaclPrice)
                    .HasColumnName("Tax_FaclPrice")
                    .HasColumnType("money");

                entity.Property(e => e.TypeFaclPrice)
                    .HasColumnName("Type_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFaclPrice)
                    .HasColumnName("UserPK_FaclPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFaclPrice).HasColumnName("UserSeq_FaclPrice");
            });

            modelBuilder.Entity<InventoryMaster2MoreInfo>(entity =>
            {
                entity.HasKey(e => e.SysPkInvtyNfo);

                entity.ToTable("Inventory_Master2_MoreInfo");

                entity.HasIndex(e => e.Info1InvtyNfo)
                    .HasName("IXInfo1_Inventory_Master2_MoreInfo");

                entity.HasIndex(e => e.Info2InvtyNfo)
                    .HasName("IXInfo2_Inventory_Master2_MoreInfo");

                entity.HasIndex(e => e.Info3InvtyNfo)
                    .HasName("IXInfo3_Inventory_Master2_MoreInfo");

                entity.HasIndex(e => e.ModuleInvtyNfo)
                    .HasName("IXModule_Inventory_Master2_MoreInfo");

                entity.Property(e => e.SysPkInvtyNfo)
                    .HasColumnName("SysPK_InvtyNfo")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Info1InvtyNfo)
                    .HasColumnName("Info1_InvtyNfo")
                    .HasMaxLength(255);

                entity.Property(e => e.Info2InvtyNfo)
                    .HasColumnName("Info2_InvtyNfo")
                    .HasMaxLength(255);

                entity.Property(e => e.Info3InvtyNfo)
                    .HasColumnName("Info3_InvtyNfo")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByInvtyNfo)
                    .HasColumnName("LastUpdatedBy_InvtyNfo")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdInvtyNfo)
                    .HasColumnName("LastUpdatedConcurrencyID_InvtyNfo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateInvtyNfo)
                    .HasColumnName("LastUpdatedDate_InvtyNfo")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleInvtyNfo)
                    .HasColumnName("Module_InvtyNfo")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkInvtyInvtyNfo)
                    .HasColumnName("SysFK_Invty_InvtyNfo")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqInvtyNfo).HasColumnName("SysSeq_InvtyNfo");

                entity.Property(e => e.UserSeqInvtyNfo).HasColumnName("UserSeq_InvtyNfo");
            });

            modelBuilder.Entity<InventoryMaster2Prices>(entity =>
            {
                entity.HasKey(e => e.SysPkInvtyPrice);

                entity.ToTable("Inventory_Master2_Prices");

                entity.HasIndex(e => e.CurrentPriceInvtyPrice)
                    .HasName("IXIsCurrent_Inventory_Master2_Prices");

                entity.HasIndex(e => e.SysFkInvtyInvtyPrice)
                    .HasName("IXSysFK_Inventory_Master2_Prices");

                entity.Property(e => e.SysPkInvtyPrice)
                    .HasColumnName("SysPK_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CommissionAmountInvtyPrice)
                    .HasColumnName("CommissionAmount_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CommissionRateInvtyPrice)
                    .HasColumnName("CommissionRate_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.CostCodeInvtyPrice)
                    .HasColumnName("CostCode_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.CostPriceChangeInvtyPrice)
                    .HasColumnName("CostPriceChange_InvtyPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CostPriceInvtyPrice)
                    .HasColumnName("CostPrice_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CurrentPriceInvtyPrice).HasColumnName("CurrentPrice_InvtyPrice");

                entity.Property(e => e.DateEffectivityInvtyPrice)
                    .HasColumnName("DateEffectivity_InvtyPrice")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsConsignedOnPurchaseInvtyPrice).HasColumnName("IsConsignedOnPurchase_InvtyPrice");

                entity.Property(e => e.IsDefaultInvtyPrice).HasColumnName("IsDefault_InvtyPrice");

                entity.Property(e => e.LastUpdatedByInvtyPrice)
                    .HasColumnName("LastUpdatedBy_InvtyPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdInvtyPrice)
                    .HasColumnName("LastUpdatedConcurrencyID_InvtyPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateInvtyPrice)
                    .HasColumnName("LastUpdatedDate_InvtyPrice")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarkUpPlusLessAInvtyPrice)
                    .HasColumnName("MarkUpPlusLessA_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessBInvtyPrice)
                    .HasColumnName("MarkUpPlusLessB_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessCInvtyPrice)
                    .HasColumnName("MarkUpPlusLessC_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessDInvtyPrice)
                    .HasColumnName("MarkUpPlusLessD_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessEInvtyPrice)
                    .HasColumnName("MarkUpPlusLessE_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPriceInvtyPrice)
                    .HasColumnName("MarketPrice_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MarketPriceLessPercentInvtyPrice)
                    .HasColumnName("MarketPriceLessPercent_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MarketPricePlusLessAInvtyPrice)
                    .HasColumnName("MarketPricePlusLessA_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessBInvtyPrice)
                    .HasColumnName("MarketPricePlusLessB_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessCInvtyPrice)
                    .HasColumnName("MarketPricePlusLessC_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessDInvtyPrice)
                    .HasColumnName("MarketPricePlusLessD_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessEInvtyPrice)
                    .HasColumnName("MarketPricePlusLessE_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPriceReceiveUnitInvtyPrice)
                    .HasColumnName("MarketPriceReceiveUnit_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MarkupPricePlusPercentInvtyPrice)
                    .HasColumnName("MarkupPricePlusPercent_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleTransHdrInvtyPrice)
                    .HasColumnName("ModuleTransHdr_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MultiplierFromBaseUnitOfMeasureInvtyPrice)
                    .HasColumnName("MultiplierFromBaseUnitOfMeasure_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.NameSuplInvtyPrice)
                    .HasColumnName("NameSupl_InvtyPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.PreviousCostInvtyPrice)
                    .HasColumnName("PreviousCost_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PreviousPriceInvtyPrice)
                    .HasColumnName("PreviousPrice_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PriceChangeInvtyPrice)
                    .HasColumnName("PriceChange_InvtyPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PriceUpdatedInvtyPrice)
                    .HasColumnName("PriceUpdated_InvtyPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SellPriceChangeInvtyPrice)
                    .HasColumnName("SellPriceChange_InvtyPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SellingPriceDefaultInvtyPrice)
                    .HasColumnName("SellingPriceDefault_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingPriceMinimumInvtyPrice)
                    .HasColumnName("SellingPriceMinimum_InvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingUnitBaseMultiplierInvtyPrice)
                    .HasColumnName("SellingUnitBaseMultiplier_InvtyPrice")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.SellingUnitOfMeasureInvtyPrice)
                    .HasColumnName("SellingUnitOfMeasure_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.SyncStatusInvtyPrice)
                    .HasColumnName("SyncStatus_InvtyPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyInvtyPrice)
                    .HasColumnName("SysFK_Invty_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyUnitMsrInvtyPrice)
                    .HasColumnName("SysFK_InvtyUnitMsr_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPolicyPrcInvtyPrice)
                    .HasColumnName("SysFK_PolicyPrc_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSuplInvtyPrice)
                    .HasColumnName("SysFK_Supl_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysPktransHdrInvtyPrice)
                    .HasColumnName("SysPKTransHdr_InvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqInvtyPrice).HasColumnName("SysSeq_InvtyPrice");

                entity.Property(e => e.UserFkInvtyUnitMsrInvtyPrice)
                    .HasColumnName("UserFK_InvtyUnitMsr_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPolicyPrcInvtyPrice)
                    .HasColumnName("UserFK_PolicyPrc_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkSuplInvtyPrice)
                    .HasColumnName("UserFK_Supl_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkInvtyPrice)
                    .HasColumnName("UserPK_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktransHdrInvtyPrice)
                    .HasColumnName("UserPKTransHdr_InvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqInvtyPrice).HasColumnName("UserSeq_InvtyPrice");
            });

            modelBuilder.Entity<InventoryMaster2Suppliers>(entity =>
            {
                entity.HasKey(e => e.SysPkInvtySupl);

                entity.ToTable("Inventory_Master2_Suppliers");

                entity.Property(e => e.SysPkInvtySupl)
                    .HasColumnName("SysPK_InvtySupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateLatestReceivedInvtySupl)
                    .HasColumnName("DateLatestReceived_InvtySupl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DiscountInvtySupl)
                    .HasColumnName("Discount_InvtySupl")
                    .HasMaxLength(50);

                entity.Property(e => e.IsPreferredInvtySupl).HasColumnName("IsPreferred_InvtySupl");

                entity.Property(e => e.LastUpdatedByInvtySupl)
                    .HasColumnName("LastUpdatedBy_InvtySupl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdInvtySupl)
                    .HasColumnName("LastUpdatedConcurrencyID_InvtySupl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateInvtySupl)
                    .HasColumnName("LastUpdatedDate_InvtySupl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarketPriceForeignInvtySupl)
                    .HasColumnName("MarketPriceForeign_InvtySupl")
                    .HasColumnType("money");

                entity.Property(e => e.MarketPriceLocalInvtySupl)
                    .HasColumnName("MarketPriceLocal_InvtySupl")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleInvtySupl)
                    .HasColumnName("Module_InvtySupl")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchasePriceAverageForeignInvtySupl)
                    .HasColumnName("PurchasePriceAverageForeign_InvtySupl")
                    .HasColumnType("money");

                entity.Property(e => e.PurchasePriceAverageLocalInvtySupl)
                    .HasColumnName("PurchasePriceAverageLocal_InvtySupl")
                    .HasColumnType("money");

                entity.Property(e => e.PurchasePriceLatestForeignInvtySupl)
                    .HasColumnName("PurchasePriceLatestForeign_InvtySupl")
                    .HasColumnType("money");

                entity.Property(e => e.PurchasePriceLatestLocalInvtySupl)
                    .HasColumnName("PurchasePriceLatestLocal_InvtySupl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkInvtyInvtySupl)
                    .HasColumnName("SysFK_Invty_InvtySupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmInvtySupl)
                    .HasColumnName("SysFK_UM_InvtySupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqInvtySupl).HasColumnName("SysSeq_InvtySupl");

                entity.Property(e => e.UserSeqInvtySupl).HasColumnName("UserSeq_InvtySupl");
            });

            modelBuilder.Entity<InventoryMaster2Units>(entity =>
            {
                entity.HasKey(e => e.SysPkInvtyUnit);

                entity.ToTable("Inventory_Master2_Units");

                entity.Property(e => e.SysPkInvtyUnit)
                    .HasColumnName("SysPK_InvtyUnit")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByInvtyUnit)
                    .HasColumnName("LastUpdatedBy_InvtyUnit")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdInvtyUnit)
                    .HasColumnName("LastUpdatedConcurrencyID_InvtyUnit")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateInvtyUnit)
                    .HasColumnName("LastUpdatedDate_InvtyUnit")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SysFkInvtyInvtyUnit)
                    .HasColumnName("SysFK_Invty_InvtyUnit")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqInvtyUnit).HasColumnName("SysSeq_InvtyUnit");

                entity.Property(e => e.UnitBaseMultiplierInvtyUnit)
                    .HasColumnName("UnitBaseMultiplier_InvtyUnit")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkInvtyUnit)
                    .HasColumnName("UserPK_InvtyUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqInvtyUnit).HasColumnName("UserSeq_InvtyUnit");
            });

            modelBuilder.Entity<InventoryMasterFixedAssets>(entity =>
            {
                entity.HasKey(e => e.SysPkFixAst);

                entity.ToTable("Inventory_Master_Fixed_Assets");

                entity.Property(e => e.SysPkFixAst)
                    .HasColumnName("SysPK_FixAst")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AquisitionAmountForeignInvtyFixAst)
                    .HasColumnName("AquisitionAmountForeign_InvtyFixAst")
                    .HasColumnType("money");

                entity.Property(e => e.AquisitionAmountLocalInvtyFixAst)
                    .HasColumnName("AquisitionAmountLocal_InvtyFixAst")
                    .HasColumnType("money");

                entity.Property(e => e.AquisitionDateInvtyFixAst)
                    .HasColumnName("AquisitionDate_InvtyFixAst")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CbdFixAst)
                    .HasColumnName("CBD_FixAst")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByFixAst)
                    .HasColumnName("LastUpdatedBy_FixAst")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFixAst)
                    .HasColumnName("LastUpdatedConcurrencyID_FixAst")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFixAst)
                    .HasColumnName("LastUpdatedDate_FixAst")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LifeSpanInvtyFixAst)
                    .HasColumnName("LifeSpan_InvtyFixAst")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleFixAst)
                    .HasColumnName("Module_FixAst")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthlyUsualDepreciationInvtyFixAst)
                    .HasColumnName("MonthlyUsualDepreciation_InvtyFixAst")
                    .HasColumnType("money");

                entity.Property(e => e.ParticularsFixAst)
                    .HasColumnName("Particulars_FixAst")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameFixAst)
                    .HasColumnName("PictureFileName_FixAst")
                    .HasMaxLength(255);

                entity.Property(e => e.ResaleValueInvtyFixAst)
                    .HasColumnName("ResaleValue_InvtyFixAst")
                    .HasColumnType("money");

                entity.Property(e => e.SerialNumberInvtyFixAst)
                    .HasColumnName("SerialNumber_InvtyFixAst")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusFixAst)
                    .HasColumnName("Status_FixAst")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkInvtyFixAst)
                    .HasColumnName("SysFK_Invty_FixAst")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmFixAst)
                    .HasColumnName("SysFK_UM_FixAst")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFixAst).HasColumnName("SysSeq_FixAst");

                entity.Property(e => e.TypeFixAst)
                    .HasColumnName("Type_FixAst")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFixAst)
                    .HasColumnName("UserPK_FixAst")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFixAst).HasColumnName("UserSeq_FixAst");
            });

            modelBuilder.Entity<InventoryMasterJunction>(entity =>
            {
                entity.HasKey(e => e.SysPkInvtyJ);

                entity.ToTable("Inventory_Master_Junction");

                entity.Property(e => e.SysPkInvtyJ)
                    .HasColumnName("SysPK_InvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByInvtyJ)
                    .HasColumnName("LastUpdatedBy_InvtyJ")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdInvtyJ)
                    .HasColumnName("LastUpdatedConcurrencyID_InvtyJ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateInvtyJ)
                    .HasColumnName("LastUpdatedDate_InvtyJ")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleInvtyJ)
                    .HasColumnName("Module_InvtyJ")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeInvtyJ)
                    .HasColumnName("ModuleType_InvtyJ")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksInvtyJ)
                    .HasColumnName("Remarks_InvtyJ")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkInvty01InvtyJ)
                    .HasColumnName("SysFK_Invty01_InvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvty02InvtyJ)
                    .HasColumnName("SysFK_Invty02_InvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvty03InvtyJ)
                    .HasColumnName("SysFK_Invty03_InvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmInvtyJ)
                    .HasColumnName("SysFK_UM_InvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqInvtyJ).HasColumnName("SysSeq_InvtyJ");

                entity.Property(e => e.UserSeqInvtyJ).HasColumnName("UserSeq_InvtyJ");
            });

            modelBuilder.Entity<ModifiedRecordsHistory>(entity =>
            {
                entity.HasKey(e => e.SysPkModHist);

                entity.ToTable("Modified_Records_History");

                entity.Property(e => e.SysPkModHist)
                    .HasColumnName("SysPK_ModHist")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByModHist)
                    .HasColumnName("LastUpdatedBy_ModHist")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdModHist)
                    .HasColumnName("LastUpdatedConcurrencyID_ModHist")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateModHist)
                    .HasColumnName("LastUpdatedDate_ModHist")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ObjectCaptionModHist)
                    .HasColumnName("ObjectCaption_ModHist")
                    .HasMaxLength(100);

                entity.Property(e => e.SysFkRecordModHist)
                    .HasColumnName("SysFK_Record_ModHist")
                    .HasMaxLength(50);

                entity.Property(e => e.TableNameModHist)
                    .HasColumnName("Table_Name_ModHist")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PabxLog>(entity =>
            {
                entity.HasKey(e => e.SysPkPabxlog);

                entity.ToTable("PABX_Log");

                entity.Property(e => e.SysPkPabxlog)
                    .HasColumnName("SysPK_PABXLog")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccCodePabxlog)
                    .HasColumnName("AccCode_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.CdPabxlog)
                    .HasColumnName("CD_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.ChargesPabxlog)
                    .HasColumnName("Charges_PABXLog")
                    .HasColumnType("money");

                entity.Property(e => e.DatePabxlog)
                    .HasColumnName("Date_PABXLog")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DialedNumPabxlog)
                    .HasColumnName("DialedNum_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.DurationPabxlog)
                    .HasColumnName("Duration_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.ExtensionNumPabxlog)
                    .HasColumnName("ExtensionNum_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByPabxlog)
                    .HasColumnName("LastUpdatedBy_PABXLog")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPabxlog)
                    .HasColumnName("LastUpdatedConcurrencyID_PABXLog")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePabxlog)
                    .HasColumnName("LastUpdatedDate_PABXLog")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LineNumPabxlog)
                    .HasColumnName("LineNum_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.PostedToFolioPabxlog).HasColumnName("PostedToFolio_PABXLog");

                entity.Property(e => e.RingPabxlog)
                    .HasColumnName("Ring_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.SysSeqPabxlog).HasColumnName("SysSeq_PABXLog");

                entity.Property(e => e.TimePabxlog)
                    .HasColumnName("Time_PABXLog")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserPkPabxlog)
                    .HasColumnName("UserPK_PABXLog")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPabxlog).HasColumnName("UserSeq_PABXLog");
            });

            modelBuilder.Entity<PolicyMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkPm);

                entity.ToTable("Policy_Master");

                entity.Property(e => e.SysPkPm)
                    .HasColumnName("SysPK_PM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdPm)
                    .HasColumnName("CBD_PM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateDefinedPm)
                    .HasColumnName("DateDefined_PM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateEffectivePm)
                    .HasColumnName("DateEffective_PM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DescriptionPm)
                    .HasColumnName("Description_PM")
                    .HasMaxLength(255);

                entity.Property(e => e.IsDefaultPm).HasColumnName("IsDefault_PM");

                entity.Property(e => e.LastUpdatedByPm)
                    .HasColumnName("LastUpdatedBy_PM")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPm)
                    .HasColumnName("LastUpdatedConcurrencyID_PM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePm)
                    .HasColumnName("LastUpdatedDate_PM")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePm)
                    .HasColumnName("Module_PM")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsPm)
                    .HasColumnName("Particulars_PM")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNamePm)
                    .HasColumnName("PictureFileName_PM")
                    .HasMaxLength(255);

                entity.Property(e => e.SequencePkPm).HasColumnName("SequencePK_PM");

                entity.Property(e => e.StatusPm)
                    .HasColumnName("Status_PM")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmparentPm)
                    .HasColumnName("SysFK_PMParent_PM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPm).HasColumnName("SysSeq_PM");

                entity.Property(e => e.TypePm)
                    .HasColumnName("Type_PM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPm)
                    .HasColumnName("UserPK_PM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPm).HasColumnName("UserSeq_PM");
            });

            modelBuilder.Entity<PolicyMasterCustomer>(entity =>
            {
                entity.HasKey(e => e.SysPkPmcust);

                entity.ToTable("Policy_Master_Customer");

                entity.Property(e => e.SysPkPmcust)
                    .HasColumnName("SysPK_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CreditLimitRuleUsedPmcust)
                    .HasColumnName("CreditLimitRuleUsed_PMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDefaultPmcust).HasColumnName("IsDefault_PMCust");

                entity.Property(e => e.LastUpdatedByPmcust)
                    .HasColumnName("LastUpdatedBy_PMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmcust)
                    .HasColumnName("LastUpdatedConcurrencyID_PMCust")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmcust)
                    .HasColumnName("LastUpdatedDate_PMCust")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmcust)
                    .HasColumnName("Module_PMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPmcust)
                    .HasColumnName("Status_PMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaarPmcust)
                    .HasColumnName("SysFK_COAAR_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoabadDebtsPmcust)
                    .HasColumnName("SysFK_COABadDebts_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacashPmcust)
                    .HasColumnName("SysFK_COACash_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainputTaxPmcust)
                    .HasColumnName("SysFK_COAInputTax_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaoutputTaxPmcust)
                    .HasColumnName("SysFK_COAOutputTax_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesPmcust)
                    .HasColumnName("SysFK_COASales_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesReturnPmcust)
                    .HasColumnName("SysFK_COASalesReturn_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPmcust)
                    .HasColumnName("SysFK_PM_PMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmcust).HasColumnName("SysSeq_PMCust");

                entity.Property(e => e.TypePmcust)
                    .HasColumnName("Type_PMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmcust)
                    .HasColumnName("UserPK_PMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmcust).HasColumnName("UserSeq_PMCust");
            });

            modelBuilder.Entity<PolicyMasterCustomerSupplier>(entity =>
            {
                entity.HasKey(e => e.SysPkPmccustSupl);

                entity.ToTable("Policy_Master_CustomerSupplier");

                entity.Property(e => e.SysPkPmccustSupl)
                    .HasColumnName("SysPK_PMCCustSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByPmccustSupl)
                    .HasColumnName("LastUpdatedBy_PMCCustSupl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmccustSupl)
                    .HasColumnName("LastUpdatedConcurrencyID_PMCCustSupl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmccustSupl)
                    .HasColumnName("LastUpdatedDate_PMCCustSupl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmccustSupl)
                    .HasColumnName("Module_PMCCustSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPmccustSupl)
                    .HasColumnName("Status_PMCCustSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmccustSupl)
                    .HasColumnName("SysFK_PM_PMCCustSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmccustSupl).HasColumnName("SysSeq_PMCCustSupl");

                entity.Property(e => e.TypePmccustSupl)
                    .HasColumnName("Type_PMCCustSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmccustSupl)
                    .HasColumnName("UserPK_PMCCustSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmccustSupl).HasColumnName("UserSeq_PMCCustSupl");
            });

            modelBuilder.Entity<PolicyMasterDisbursement>(entity =>
            {
                entity.HasKey(e => e.SysPkPmdis);

                entity.ToTable("Policy_Master_Disbursement");

                entity.Property(e => e.SysPkPmdis)
                    .HasColumnName("SysPK_PMDis")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ApprovedByHidePmdis).HasColumnName("ApprovedByHide_PMDis");

                entity.Property(e => e.CheckedByHidePmdis).HasColumnName("CheckedByHide_PMDis");

                entity.Property(e => e.IsDefaultPmdis).HasColumnName("IsDefault_PMDis");

                entity.Property(e => e.IsIndependentPmdis).HasColumnName("IsIndependent_PMDis");

                entity.Property(e => e.LastUpdatedByPmdis)
                    .HasColumnName("LastUpdatedBy_PMDis")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmdis)
                    .HasColumnName("LastUpdatedConcurrencyID_PMDis")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmdis)
                    .HasColumnName("LastUpdatedDate_PMDis")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmdis)
                    .HasColumnName("Module_PMDis")
                    .HasMaxLength(50);

                entity.Property(e => e.NameShowAtReceivedByPmdis).HasColumnName("NameShowAtReceivedBy_PMDis");

                entity.Property(e => e.StatusPmdis)
                    .HasColumnName("Status_PMDis")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmdis)
                    .HasColumnName("SysFK_PM_PMDis")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankPmdis)
                    .HasColumnName("SysFK_UMBank_PMDis")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmdis).HasColumnName("SysSeq_PMDis");

                entity.Property(e => e.TypePmdis)
                    .HasColumnName("Type_PMDis")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkUmbankPmdis)
                    .HasColumnName("UserFK_UMBank_PMDis")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmdis)
                    .HasColumnName("UserPK_PMDis")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmdis).HasColumnName("UserSeq_PMDis");
            });

            modelBuilder.Entity<PolicyMasterElection>(entity =>
            {
                entity.HasKey(e => e.SysPkPmelec);

                entity.ToTable("Policy_Master_Election");

                entity.Property(e => e.SysPkPmelec)
                    .HasColumnName("SysPK_PMElec")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BoyCottPmelec).HasColumnName("BoyCott_PMElec");

                entity.Property(e => e.IsMemberMultiPositionPmelec).HasColumnName("IsMemberMultiPosition_PMElec");

                entity.Property(e => e.LastUpdatedByPmelec)
                    .HasColumnName("LastUpdatedBy_PMElec")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmelec)
                    .HasColumnName("LastUpdatedConcurrencyID_PMElec")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmelec)
                    .HasColumnName("LastUpdatedDate_PMElec")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmelec)
                    .HasColumnName("Module_PMElec")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmelec)
                    .HasColumnName("SysFK_PM_PMElec")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmelec).HasColumnName("SysSeq_PMElec");

                entity.Property(e => e.UserSeqPmelec).HasColumnName("UserSeq_PMElec");
            });

            modelBuilder.Entity<PolicyMasterElectionCandidates>(entity =>
            {
                entity.HasKey(e => e.SysPkPmelecCand);

                entity.ToTable("Policy_Master_Election_Candidates");

                entity.Property(e => e.SysPkPmelecCand)
                    .HasColumnName("SysPK_PMElecCand")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BallotColumnPmelecCand)
                    .HasColumnName("BallotColumn_PMElecCand")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByPmelecCand)
                    .HasColumnName("LastUpdatedBy_PMElecCand")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmelecCand)
                    .HasColumnName("LastUpdatedConcurrencyID_PMElecCand")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmelecCand)
                    .HasColumnName("LastUpdatedDate_PMElecCand")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmelecCand)
                    .HasColumnName("Module_PMElecCand")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsPmelecCand)
                    .HasColumnName("Particulars_PMElecCand")
                    .HasMaxLength(255);

                entity.Property(e => e.PositionPmelecCand)
                    .HasColumnName("Position_PMElecCand")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPmelecCand)
                    .HasColumnName("Status_PMElecCand")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmelecCand)
                    .HasColumnName("SysFK_PM_PMElecCand")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmPmelecCand)
                    .HasColumnName("SysFK_UM_PMElecCand")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmelecCand).HasColumnName("SysSeq_PMElecCand");

                entity.Property(e => e.TypePmelecCand)
                    .HasColumnName("Type_PMElecCand")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmelecCand).HasColumnName("UserSeq_PMElecCand");
            });

            modelBuilder.Entity<PolicyMasterEmployee>(entity =>
            {
                entity.HasKey(e => e.SysPkPmempl);

                entity.ToTable("Policy_Master_Employee");

                entity.Property(e => e.SysPkPmempl)
                    .HasColumnName("SysPK_PMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByPmempl)
                    .HasColumnName("LastUpdatedBy_PMEmpl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmempl)
                    .HasColumnName("LastUpdatedConcurrencyID_PMEmpl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmempl)
                    .HasColumnName("LastUpdatedDate_PMEmpl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmempl)
                    .HasColumnName("Module_PMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmempl)
                    .HasColumnName("SysFK_PM_PMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmempl).HasColumnName("SysSeq_PMEmpl");

                entity.Property(e => e.UserPkPmempl)
                    .HasColumnName("UserPK_PMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmempl).HasColumnName("UserSeq_PMEmpl");
            });

            modelBuilder.Entity<PolicyMasterHotel>(entity =>
            {
                entity.HasKey(e => e.SysPkPmhotel);

                entity.ToTable("Policy_Master_Hotel");

                entity.Property(e => e.SysPkPmhotel)
                    .HasColumnName("SysPK_PMHotel")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsDefaultPmhotel).HasColumnName("IsDefault_PMHotel");

                entity.Property(e => e.LastUpdatedByPmhotel)
                    .HasColumnName("LastUpdatedBy_PMHotel")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmhotel)
                    .HasColumnName("LastUpdatedConcurrencyID_PMHotel")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmhotel)
                    .HasColumnName("LastUpdatedDate_PMHotel")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmhotel)
                    .HasColumnName("Module_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPmhotel)
                    .HasColumnName("Status_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmhotel)
                    .HasColumnName("SysFK_PM_PMHotel")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmhotel).HasColumnName("SysSeq_PMHotel");

                entity.Property(e => e.TimeAccountingCutOffPmhotel)
                    .HasColumnName("TimeAccountingCutOff_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeCheckOutExtensionPmhotel)
                    .HasColumnName("TimeCheckOutExtension_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeCheckOutPmhotel)
                    .HasColumnName("TimeCheckOut_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeEarlyCheckInPmhotel)
                    .HasColumnName("TimeEarlyCheckIn_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeHalfRateEndPmhotel)
                    .HasColumnName("TimeHalfRateEnd_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeHalfRateStartPmhotel)
                    .HasColumnName("TimeHalfRateStart_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.TypePmhotel)
                    .HasColumnName("Type_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmhotel)
                    .HasColumnName("UserPK_PMHotel")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmhotel).HasColumnName("UserSeq_PMHotel");
            });

            modelBuilder.Entity<PolicyMasterInventory>(entity =>
            {
                entity.HasKey(e => e.SysPkPminvty);

                entity.ToTable("Policy_Master_Inventory");

                entity.Property(e => e.SysPkPminvty)
                    .HasColumnName("SysPK_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BaseUnitOfMeasurePminvty)
                    .HasColumnName("BaseUnitOfMeasure_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryPminvty)
                    .HasColumnName("Category_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassificationPminvty)
                    .HasColumnName("Classification_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDefaultPminvty).HasColumnName("IsDefault_PMInvty");

                entity.Property(e => e.LastUpdatedByPminvty)
                    .HasColumnName("LastUpdatedBy_PMInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPminvty)
                    .HasColumnName("LastUpdatedConcurrencyID_PMInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePminvty)
                    .HasColumnName("LastUpdatedDate_PMInvty")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePminvty)
                    .HasColumnName("Module_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.MultiplierFromBaseUnitOfMeasurePminvty)
                    .HasColumnName("MultiplierFromBaseUnitOfMeasure_PMInvty")
                    .HasColumnType("money");

                entity.Property(e => e.PurchaseUnitBaseMultiplierPminvty)
                    .HasColumnName("PurchaseUnitBaseMultiplier_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseUnitOfMeasurePminvty)
                    .HasColumnName("PurchaseUnitOfMeasure_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.ReorderLevelPminvty)
                    .HasColumnName("ReorderLevel_PMInvty")
                    .HasColumnType("money");

                entity.Property(e => e.RestockingQtyPminvty)
                    .HasColumnName("RestockingQty_PMInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SubCategoryPminvty)
                    .HasColumnName("SubCategory_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaapPminvty)
                    .HasColumnName("SysFK_COAAP_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaappnPminvty)
                    .HasColumnName("SysFK_COAAPPN_PMInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoaarPminvty)
                    .HasColumnName("SysFK_COAAR_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacompliPurchasePminvty)
                    .HasColumnName("SysFK_COACompliPurchase_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacompliSalesPminvty)
                    .HasColumnName("SysFK_COACompliSales_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacostOfGoodsPminvty)
                    .HasColumnName("SysFK_COACostOfGoods_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryPcsgnPminvty)
                    .HasColumnName("SysFK_COAInventoryPCsgn_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryPminvty)
                    .HasColumnName("SysFK_COAInventory_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryPscsgnPminvty)
                    .HasColumnName("SysFK_COAInventoryPSCsgn_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainventoryScsgnPminvty)
                    .HasColumnName("SysFK_COAInventorySCsgn_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapcsgnPminvty)
                    .HasColumnName("SysFK_COAPCsgn_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapurchaseDiscountPminvty)
                    .HasColumnName("SysFK_COAPurchaseDiscount_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapurchasePminvty)
                    .HasColumnName("SysFK_COAPurchase_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoareturnPurchasePminvty)
                    .HasColumnName("SysFK_COAReturnPurchase_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoareturnSalesPminvty)
                    .HasColumnName("SysFK_COAReturnSales_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesDiscountPminvty)
                    .HasColumnName("SysFK_COASalesDiscount_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesPminvty)
                    .HasColumnName("SysFK_COASales_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoascsgnPminvty)
                    .HasColumnName("SysFK_COASCsgn_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPminvty)
                    .HasColumnName("SysFK_PM_PMInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPminvty).HasColumnName("SysSeq_PMInvty");

                entity.Property(e => e.TypePminvty)
                    .HasColumnName("Type_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPminvty)
                    .HasColumnName("UserPK_PMInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPminvty).HasColumnName("UserSeq_PMInvty");
            });

            modelBuilder.Entity<PolicyMasterInventoryPrices>(entity =>
            {
                entity.HasKey(e => e.SysPkPminvtyPrice);

                entity.ToTable("Policy_Master_Inventory_Prices");

                entity.Property(e => e.SysPkPminvtyPrice)
                    .HasColumnName("SysPK_PMInvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BaseUnitOfMeasurePminvtyPrice)
                    .HasColumnName("BaseUnitOfMeasure_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.CategoryPminvtyPrice)
                    .HasColumnName("Category_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassificationPminvtyPrice)
                    .HasColumnName("Classification_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.CommissionAmountPminvtyPrice)
                    .HasColumnName("CommissionAmount_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CommissionRatePminvtyPrice)
                    .HasColumnName("CommissionRate_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.CostCodePminvtyPrice)
                    .HasColumnName("CostCode_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.CostPricePminvtyPrice)
                    .HasColumnName("CostPrice_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.CurrentPricePminvtyPrice).HasColumnName("CurrentPrice_PMInvtyPrice");

                entity.Property(e => e.DateEffectivityPminvtyPrice)
                    .HasColumnName("DateEffectivity_PMInvtyPrice")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsConsignedOnPurchasePminvtyPrice).HasColumnName("IsConsignedOnPurchase_PMInvtyPrice");

                entity.Property(e => e.LastUpdatedByPminvtyPrice)
                    .HasColumnName("LastUpdatedBy_PMInvtyPrice")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPminvtyPrice)
                    .HasColumnName("LastUpdatedConcurrencyID_PMInvtyPrice")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePminvtyPrice)
                    .HasColumnName("LastUpdatedDate_PMInvtyPrice")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarkUpPlusLessAPminvtyPrice)
                    .HasColumnName("MarkUpPlusLessA_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessBPminvtyPrice)
                    .HasColumnName("MarkUpPlusLessB_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessCPminvtyPrice)
                    .HasColumnName("MarkUpPlusLessC_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessDPminvtyPrice)
                    .HasColumnName("MarkUpPlusLessD_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarkUpPlusLessEPminvtyPrice)
                    .HasColumnName("MarkUpPlusLessE_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPriceLessPercentPminvtyPrice)
                    .HasColumnName("MarketPriceLessPercent_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MarketPricePlusLessAPminvtyPrice)
                    .HasColumnName("MarketPricePlusLessA_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessBPminvtyPrice)
                    .HasColumnName("MarketPricePlusLessB_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessCPminvtyPrice)
                    .HasColumnName("MarketPricePlusLessC_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessDPminvtyPrice)
                    .HasColumnName("MarketPricePlusLessD_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePlusLessEPminvtyPrice)
                    .HasColumnName("MarketPricePlusLessE_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MarketPricePminvtyPrice)
                    .HasColumnName("MarketPrice_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.MarkupPricePlusPercentPminvtyPrice)
                    .HasColumnName("MarkupPricePlusPercent_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.ModulePminvtyPrice)
                    .HasColumnName("Module_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.MultiplierFromBaseUnitOfMeasurePminvtyPrice)
                    .HasColumnName("MultiplierFromBaseUnitOfMeasure_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.PurchaseUnitBaseMultiplierPminvtyPrice)
                    .HasColumnName("PurchaseUnitBaseMultiplier_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseUnitOfMeasurePminvtyPrice)
                    .HasColumnName("PurchaseUnitOfMeasure_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.SellingPriceDefaultPminvtyPrice)
                    .HasColumnName("SellingPriceDefault_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingPriceDiscountPminvtyPrice)
                    .HasColumnName("SellingPriceDiscount_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingPriceMinimumPminvtyPrice)
                    .HasColumnName("SellingPriceMinimum_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.SellingUnitBaseMultiplierPminvtyPrice)
                    .HasColumnName("SellingUnitBaseMultiplier_PMInvtyPrice")
                    .HasColumnType("numeric(18, 6)");

                entity.Property(e => e.SellingUnitOfMeasurePminvtyPrice)
                    .HasColumnName("SellingUnitOfMeasure_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPminvtyPrice)
                    .HasColumnName("Status_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.SubCategoryPminvtyPrice)
                    .HasColumnName("SubCategory_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkInvtyPminvtyPrice)
                    .HasColumnName("SysFK_Invty_PMInvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPminvtyPrice)
                    .HasColumnName("SysFK_PM_PMInvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPminvtyPminvtyPrice)
                    .HasColumnName("SysFK_PMInvty_PMInvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPolicyPrcPminvtyPrice)
                    .HasColumnName("SysFK_PolicyPrc_PMInvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSuplPminvtyPrice)
                    .HasColumnName("SysFK_Supl_PMInvtyPrice")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPminvtyPrice).HasColumnName("SysSeq_PMInvtyPrice");

                entity.Property(e => e.TypePminvtyPrice)
                    .HasColumnName("Type_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPolicyPrcPminvtyPrice)
                    .HasColumnName("UserFK_PolicyPrc_PMInvtyPrice")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkPminvtyPrice)
                    .HasColumnName("UserPK_PMInvtyPrice")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPminvtyPrice).HasColumnName("UserSeq_PMInvtyPrice");
            });

            modelBuilder.Entity<PolicyMasterLoan>(entity =>
            {
                entity.HasKey(e => e.SysPkPmloan);

                entity.ToTable("Policy_Master_Loan");

                entity.Property(e => e.SysPkPmloan)
                    .HasColumnName("SysPK_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmortizeComputationMethodPmloan)
                    .HasColumnName("AmortizeComputationMethod_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CashReleasedPmloan)
                    .HasColumnName("CashReleased_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.EnterprisePmloan)
                    .HasColumnName("Enterprise_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.HandlingFeePmloan)
                    .HasColumnName("HandlingFee_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.IncludeHolidaysInAmortizationPmloan).HasColumnName("IncludeHolidaysInAmortization_PMLoan");

                entity.Property(e => e.IncludeSundaysInAmortizationPmloan).HasColumnName("IncludeSundaysInAmortization_PMLoan");

                entity.Property(e => e.InsuranceFeePmloan)
                    .HasColumnName("InsuranceFee_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestAdvancePaymentPmloan)
                    .HasColumnName("InterestAdvancePayment_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestComputationMethodPmloan)
                    .HasColumnName("InterestComputationMethod_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestDueDailyPmloan)
                    .HasColumnName("InterestDueDaily_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestDueMonthlyPmloan)
                    .HasColumnName("InterestDueMonthly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestDueWeeklyPmloan)
                    .HasColumnName("InterestDueWeekly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestIncomePmloan)
                    .HasColumnName("InterestIncome_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestPaymentFrequencyPmloan)
                    .HasColumnName("InterestPaymentFrequency_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestRateAnnualPmloan)
                    .HasColumnName("InterestRateAnnual_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRateDailyPmloan)
                    .HasColumnName("InterestRateDaily_PMLoan")
                    .HasColumnType("numeric(18, 8)");

                entity.Property(e => e.InterestRateEntireTermPmloan)
                    .HasColumnName("InterestRateEntireTerm_PMLoan")
                    .HasColumnType("numeric(18, 8)");

                entity.Property(e => e.InterestRateMonthlyPmloan)
                    .HasColumnName("InterestRateMonthly_PMLoan")
                    .HasColumnType("numeric(18, 8)");

                entity.Property(e => e.InterestRatePastDueAnnualPmloan)
                    .HasColumnName("InterestRatePastDueAnnual_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRatePastDueDailyPmloan)
                    .HasColumnName("InterestRatePastDueDaily_PMLoan")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InterestRatePastDueMonthlyPmloan)
                    .HasColumnName("InterestRatePastDueMonthly_PMLoan")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InterestRatePastDueWeeklyPmloan)
                    .HasColumnName("InterestRatePastDueWeekly_PMLoan")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.InterestRateSimpleAnnualPmloan)
                    .HasColumnName("InterestRateSimpleAnnual_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRateWeeklyPmloan)
                    .HasColumnName("InterestRateWeekly_PMLoan")
                    .HasColumnType("numeric(18, 8)");

                entity.Property(e => e.InterestTotalPmloan)
                    .HasColumnName("InterestTotal_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPmloan)
                    .HasColumnName("LastUpdatedBy_PMLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmloan)
                    .HasColumnName("LastUpdatedConcurrencyID_PMLoan")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmloan)
                    .HasColumnName("LastUpdatedDate_PMLoan")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoanReceivablePmloan)
                    .HasColumnName("LoanReceivable_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MiscExpensePmloan)
                    .HasColumnName("MiscExpense_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.ModulePmloan)
                    .HasColumnName("Module_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.NotarialFeePmloan)
                    .HasColumnName("NotarialFee_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyDueDailyPmloan)
                    .HasColumnName("PenaltyDueDaily_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyDueMonthlyPmloan)
                    .HasColumnName("PenaltyDueMonthly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyDueWeeklyPmloan)
                    .HasColumnName("PenaltyDueWeekly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyRateDailyPmloan)
                    .HasColumnName("PenaltyRateDaily_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyRateMonthlyPmloan)
                    .HasColumnName("PenaltyRateMonthly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyRateWeeklyPmloan)
                    .HasColumnName("PenaltyRateWeekly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDueDailyPmloan)
                    .HasColumnName("PrincipalDueDaily_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDueMonthlyPmloan)
                    .HasColumnName("PrincipalDueMonthly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDueWeeklyPmloan)
                    .HasColumnName("PrincipalDueWeekly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalPaymentFrequencyPmloan)
                    .HasColumnName("PrincipalPaymentFrequency_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalTotalPmloan)
                    .HasColumnName("PrincipalTotal_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsRetainedPmloan)
                    .HasColumnName("SavingsRetained_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsRetainedRatePmloan)
                    .HasColumnName("SavingsRetainedRate_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.ShareCapitalRetainedPmloan)
                    .HasColumnName("ShareCapitalRetained_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.ShareCapitalRetainedRatePmloan)
                    .HasColumnName("ShareCapitalRetainedRate_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoacashInBankPmloan)
                    .HasColumnName("SysFK_COACashInBank_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainsurancePmloan)
                    .HasColumnName("SysFK_COAInsurance_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainterestIncomePmloan)
                    .HasColumnName("SysFK_COAInterestIncome_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainterestReceivablePmloan)
                    .HasColumnName("SysFK_COAInterestReceivable_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaloanArbadDebtPmloan)
                    .HasColumnName("SysFK_COALoanARBadDebt_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaloanArcurrentPmloan)
                    .HasColumnName("SysFK_COALoanARCurrent_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaloanArpastDuePmloan)
                    .HasColumnName("SysFK_COALoanARPastDue_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoamiscExpnsPmloan)
                    .HasColumnName("SysFK_COAMiscExpns_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoanotarialPmloan)
                    .HasColumnName("SysFK_COANotarial_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaprocessingFeePmloan)
                    .HasColumnName("SysFK_COAProcessingFee_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasavingsPmloan)
                    .HasColumnName("SysFK_COASavings_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoashareCapitalPmloan)
                    .HasColumnName("SysFK_COAShareCapital_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPmloan)
                    .HasColumnName("SysFK_PM_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmloanParentPmloan)
                    .HasColumnName("SysFK_PMLoanParent_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankPmloan)
                    .HasColumnName("SysFK_UMBank_PMLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmloan).HasColumnName("SysSeq_PMLoan");

                entity.Property(e => e.TermsPrincipalDaysPmloan).HasColumnName("TermsPrincipalDays_PMLoan");

                entity.Property(e => e.TermsPrincipalDueEveryPmloan)
                    .HasColumnName("TermsPrincipalDueEvery_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.TermsPrincipalMonthsPmloan).HasColumnName("TermsPrincipalMonths_PMLoan");

                entity.Property(e => e.TermsPrincipalWeeksPmloan).HasColumnName("TermsPrincipalWeeks_PMLoan");

                entity.Property(e => e.TermsPrincipalYearsPmloan).HasColumnName("TermsPrincipalYears_PMLoan");

                entity.Property(e => e.TotalChargesPmloan)
                    .HasColumnName("TotalCharges_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDeductionsPmloan)
                    .HasColumnName("TotalDeductions_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueDailyPmloan)
                    .HasColumnName("TotalDueDaily_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueMonthlyPmloan)
                    .HasColumnName("TotalDueMonthly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueWeeklyPmloan)
                    .HasColumnName("TotalDueWeekly_PMLoan")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkalternativePmloan)
                    .HasColumnName("UserPKAlternative_PMLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmloan).HasColumnName("UserSeq_PMLoan");
            });

            modelBuilder.Entity<PolicyMasterLoanAmort>(entity =>
            {
                entity.HasKey(e => e.SysPkPmloanAmrt);

                entity.ToTable("Policy_Master_LoanAmort");

                entity.Property(e => e.SysPkPmloanAmrt)
                    .HasColumnName("SysPK_PMLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DayNumPmloanAmrt).HasColumnName("DayNum_PMLoanAmrt");

                entity.Property(e => e.InterestDueClrPmloanAmrt)
                    .HasColumnName("InterestDueClr_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRunBalPmloanAmrt)
                    .HasColumnName("InterestRunBal_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPmloanAmrt)
                    .HasColumnName("LastUpdatedBy_PMLoanAmrt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmloanAmrt)
                    .HasColumnName("LastUpdatedConcurrencyID_PMLoanAmrt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmloanAmrt)
                    .HasColumnName("LastUpdatedDate_PMLoanAmrt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MiscDueClrPmloanAmrt)
                    .HasColumnName("MiscDueClr_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.MiscRunBalPmloanAmrt)
                    .HasColumnName("MiscRunBal_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.ModulePmloanAmrt)
                    .HasColumnName("Module_PMLoanAmrt")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalDueClrPmloanAmrt)
                    .HasColumnName("PrincipalDueClr_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalRunBalPmloanAmrt)
                    .HasColumnName("PrincipalRunBal_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDaysCountPmloanAmrt)
                    .HasColumnName("SavingsDaysCount_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDueClrPmloanAmrt)
                    .HasColumnName("SavingsDueClr_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDuePerDayPmloanAmrt)
                    .HasColumnName("SavingsDuePerDay_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkPmPmloanAmrt)
                    .HasColumnName("SysFK_PM_PMLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmloanAmrtParentPmloanAmrt)
                    .HasColumnName("SysFK_PMLoanAmrtParent_PMLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmloanPmloanAmrt)
                    .HasColumnName("SysFK_PMLoan_PMLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmloanAmrt).HasColumnName("SysSeq_PMLoanAmrt");

                entity.Property(e => e.TotalDueClrPmloanAmrt)
                    .HasColumnName("TotalDueClr_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.TotalRunBalPmloanAmrt)
                    .HasColumnName("TotalRunBal_PMLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.UserSeqPmloanAmrt).HasColumnName("UserSeq_PMLoanAmrt");
            });

            modelBuilder.Entity<PolicyMasterPayrollAmount>(entity =>
            {
                entity.HasKey(e => e.SysPkPmpayrlAmt);

                entity.ToTable("Policy_Master_Payroll_Amount");

                entity.Property(e => e.SysPkPmpayrlAmt)
                    .HasColumnName("SysPK_PMPayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AdditionPmpayrlAmt)
                    .HasColumnName("Addition_PMPayrlAmt")
                    .HasColumnType("money");

                entity.Property(e => e.ComputeMethodPmpayrlAmt)
                    .HasColumnName("ComputeMethod_PMPayrlAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.DeductionPmpayrlAmt)
                    .HasColumnName("Deduction_PMPayrlAmt")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPmpayrlAmt)
                    .HasColumnName("LastUpdatedBy_PMPayrlAmt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmpayrlAmt)
                    .HasColumnName("LastUpdatedConcurrencyID_PMPayrlAmt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmpayrlAmt)
                    .HasColumnName("LastUpdatedDate_PMPayrlAmt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmpayrlAmt)
                    .HasColumnName("Module_PMPayrlAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.RatePmpayrlAmt)
                    .HasColumnName("Rate_PMPayrlAmt")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoaPmpayrlAmt)
                    .HasColumnName("SysFK_COA_PMPayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPmpayrlAmt)
                    .HasColumnName("SysFK_PM_PMPayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmpayrlAmt).HasColumnName("SysSeq_PMPayrlAmt");

                entity.Property(e => e.UserPkPmpayrlAmt)
                    .HasColumnName("UserPK_PMPayrlAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmpayrlAmt).HasColumnName("UserSeq_PMPayrlAmt");
            });

            modelBuilder.Entity<PolicyMasterPayrollDeduction>(entity =>
            {
                entity.HasKey(e => e.SysPkPmpyrlDeduct)
                    .HasName("PK_Policy_Master_PayrollDeduction");

                entity.ToTable("Policy_Master_Payroll_Deduction");

                entity.Property(e => e.SysPkPmpyrlDeduct)
                    .HasColumnName("SysPK_PMPyrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPmpyrlDeduct)
                    .HasColumnName("Amount_PMPyrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.CategoryPmpyrlDeduct)
                    .HasColumnName("Category_PMPyrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassificationPmpyrlDeduct)
                    .HasColumnName("Classification_PMPyrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByPmpyrlDeduct)
                    .HasColumnName("LastUpdatedBy_PMPyrlDeduct")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmpyrlDeduct).HasColumnName("LastUpdatedConcurrencyID_PMPyrlDeduct");

                entity.Property(e => e.LastUpdatedDatePmpyrlDeduct)
                    .HasColumnName("LastUpdatedDate_PMPyrlDeduct")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModulePmpyrlDeduct)
                    .HasColumnName("Module_PMPyrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPmpyrlDeduct)
                    .HasColumnName("Status_PMPyrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaPmpyrlDeduct)
                    .HasColumnName("SysFK_COA_PMPyrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkPmPmpyrlDeduct)
                    .HasColumnName("SysFK_PM_PMPyrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqPmpyrlDeduct).HasColumnName("SysSeq_PMPyrlDeduct");

                entity.Property(e => e.TypePmpyrlDeduct)
                    .HasColumnName("Type_PMPyrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmpyrlDeduct)
                    .HasColumnName("UserPK_PMPyrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmpyrlDeduct).HasColumnName("UserSeq_PMPyrlDeduct");
            });

            modelBuilder.Entity<PolicyMasterPayrollHoliday>(entity =>
            {
                entity.HasKey(e => e.SysPkPmholiday)
                    .HasName("PK_Policy_Master_PayrollHoliday");

                entity.ToTable("Policy_Master_Payroll_Holiday");

                entity.Property(e => e.SysPkPmholiday)
                    .HasColumnName("SysPK_PMHoliday")
                    .HasColumnType("money");

                entity.Property(e => e.DateOfHolidayPmholiday)
                    .HasColumnName("DateOfHoliday_PMHoliday")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DescriptionPmholiday)
                    .HasColumnName("Description_PMHoliday")
                    .HasMaxLength(100);

                entity.Property(e => e.LastUpdatedByPmholiday)
                    .HasColumnName("LastUpdatedBy_PMHoliday")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmholiday).HasColumnName("LastUpdatedConcurrencyID_PMHoliday");

                entity.Property(e => e.LastUpdatedDatePmholiday)
                    .HasColumnName("LastUpdatedDate_PMHoliday")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModulePmholiday)
                    .HasColumnName("Module_PMHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmholiday)
                    .HasColumnName("SysFK_PM_PMHoliday")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmholiday).HasColumnName("SysSeq_PMHoliday");

                entity.Property(e => e.TypePmholiday)
                    .HasColumnName("Type_PMHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmholiday)
                    .HasColumnName("UserPK_PMHoliday")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmholiday).HasColumnName("UserSeq_PMHoliday");
            });

            modelBuilder.Entity<PolicyMasterPayrollMemo>(entity =>
            {
                entity.HasKey(e => e.SysPkPmmemo);

                entity.ToTable("Policy_Master_Payroll_Memo");

                entity.Property(e => e.SysPkPmmemo)
                    .HasColumnName("SysPK_PMMemo")
                    .HasColumnType("money");

                entity.Property(e => e.CategoryPmmemo)
                    .HasColumnName("Category_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.ClassificationPmmemo)
                    .HasColumnName("Classification_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.DaysSuspensionPmmemo)
                    .HasColumnName("DaysSuspension_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.DeductionRatePmmemo)
                    .HasColumnName("DeductionRate_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByPmmemo)
                    .HasColumnName("LastUpdatedBy_PMMemo")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmmemo).HasColumnName("LastUpdatedConcurrencyID_PMMemo");

                entity.Property(e => e.LastUpdatedDatePmmemo)
                    .HasColumnName("LastUpdatedDate_PMMemo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModulePmmemo)
                    .HasColumnName("Module_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.OffensePmmemo)
                    .HasColumnName("Offense_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.RegulationPmmemo)
                    .HasColumnName("Regulation_PMMemo")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusPmmemo)
                    .HasColumnName("Status_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.SubCategoryPmmemo)
                    .HasColumnName("SubCategory_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.SubClassificationPmmemo)
                    .HasColumnName("SubClassification_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmmemo)
                    .HasColumnName("SysFK_PM_PMMemo")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqPmmemo).HasColumnName("SysSeq_PMMemo");

                entity.Property(e => e.UserPkPmmemo)
                    .HasColumnName("UserPK_PMMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmmemo).HasColumnName("UserSeq_PMMemo");
            });

            modelBuilder.Entity<PolicyMasterPayrollSalaryRate>(entity =>
            {
                entity.HasKey(e => e.SysPkPmslryRte);

                entity.ToTable("Policy_Master_Payroll_SalaryRate");

                entity.Property(e => e.SysPkPmslryRte)
                    .HasColumnName("SysPK_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Deduction1TagPmslryRte)
                    .HasColumnName("Deduction1Tag_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.Deduction2TagPmslryRte)
                    .HasColumnName("Deduction2Tag_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.Deduction3TagPmslryRte)
                    .HasColumnName("Deduction3Tag_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.Deduction4TagPmslryRte)
                    .HasColumnName("Deduction4Tag_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.HoursPerDayPmslryRte)
                    .HasColumnName("HoursPerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.IsDefaultPmslryRte).HasColumnName("IsDefault_PMSlryRte");

                entity.Property(e => e.LastUpdatedByPmslryRte)
                    .HasColumnName("LastUpdatedBy_PMSlryRte")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmslryRte)
                    .HasColumnName("LastUpdatedConcurrencyID_PMSlryRte")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmslryRte)
                    .HasColumnName("LastUpdatedDate_PMSlryRte")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmslryRte)
                    .HasColumnName("Module_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.RateHolidayAmountPerDayPmslryRte)
                    .HasColumnName("RateHolidayAmountPerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateHolidayAmountPerHourPmslryRte)
                    .HasColumnName("RateHolidayAmountPerHour_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateHolidayPercentagePerDayPmslryRte)
                    .HasColumnName("RateHolidayPercentagePerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateHolidayPercentagePerHourPmslryRte)
                    .HasColumnName("RateHolidayPercentagePerHour_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateMethodPmslryRte)
                    .HasColumnName("RateMethod_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.RateOvertimeAmountPerDayPmslryRte)
                    .HasColumnName("RateOvertimeAmountPerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateOvertimeAmountPerHourPmslryRte)
                    .HasColumnName("RateOvertimeAmountPerHour_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateOvertimePercentagePerDayPmslryRte)
                    .HasColumnName("RateOvertimePercentagePerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateOvertimePercentagePerHourPmslryRte)
                    .HasColumnName("RateOvertimePercentagePerHour_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RatePerPiecePmslryRte)
                    .HasColumnName("RatePerPiece_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateRegularAmountPerDayPmslryRte)
                    .HasColumnName("RateRegularAmountPerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateRegularAmountPerHourPmslryRte)
                    .HasColumnName("RateRegularAmountPerHour_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateRegularAmountPerMonthPmslryRte)
                    .HasColumnName("RateRegularAmountPerMonth_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.StatusPmslryRte)
                    .HasColumnName("Status_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoacashAdvancePmslryRte)
                    .HasColumnName("SysFK_COACashAdvance_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoadeduction1PmslryRte)
                    .HasColumnName("SysFK_COADeduction1_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoadeduction2PmslryRte)
                    .HasColumnName("SysFK_COADeduction2_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoadeduction3PmslryRte)
                    .HasColumnName("SysFK_COADeduction3_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoadeduction4PmslryRte)
                    .HasColumnName("SysFK_COADeduction4_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaincometaxPmslryRte)
                    .HasColumnName("SysFK_COAIncometax_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapagibigContEePmslryRte)
                    .HasColumnName("SysFK_COAPagibigContEE_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapagibigContErPmslryRte)
                    .HasColumnName("SysFK_COAPagibigContER_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapagibigLoanPmslryRte)
                    .HasColumnName("SysFK_COAPagibigLoan_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapayrollExpensePmslryRte)
                    .HasColumnName("SysFK_COAPayrollExpense_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaphilhealthContPmslryRte)
                    .HasColumnName("SysFK_COAPhilhealthCont_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoashortDeductionPmslryRte)
                    .HasColumnName("SysFK_COAShortDeduction_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoassscontEePmslryRte)
                    .HasColumnName("SysFK_COASSSContEE_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoassscontErPmslryRte)
                    .HasColumnName("SysFK_COASSSContER_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasssloanPmslryRte)
                    .HasColumnName("SysFK_COASSSLoan_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPmslryRte)
                    .HasColumnName("SysFK_PM_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmdeductPmslryRte)
                    .HasColumnName("SysFK_PMDeduct_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmslryRte).HasColumnName("SysSeq_PMSlryRte");

                entity.Property(e => e.TypePmslryRte)
                    .HasColumnName("Type_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmslryRte)
                    .HasColumnName("UserPK_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmslryRte).HasColumnName("UserSeq_PMSlryRte");
            });

            modelBuilder.Entity<PolicyMasterPayrollStandard>(entity =>
            {
                entity.HasKey(e => e.SysPkPmpyrlStndrd);

                entity.ToTable("Policy_Master_Payroll_Standard");

                entity.Property(e => e.SysPkPmpyrlStndrd)
                    .HasColumnName("SysPK_PMPyrlStndrd")
                    .HasColumnType("money");

                entity.Property(e => e.BreakInPmpyrlStndrd)
                    .HasColumnName("BreakIn_PMPyrlStndrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BreakOutPmpyrlStndrd)
                    .HasColumnName("BreakOut_PMPyrlStndrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdateDatePmpyrlStndrd)
                    .HasColumnName("LastUpdateDate_PMPyrlStndrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByPmpyrlStndrd)
                    .HasColumnName("LastUpdatedBy_PMPyrlStndrd")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmpyrlStndrd).HasColumnName("LastUpdatedConcurrencyID_PMPyrlStndrd");

                entity.Property(e => e.ModulePmpyrlStndrd)
                    .HasColumnName("Module_PMPyrlStndrd")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmpyrlStndrd)
                    .HasColumnName("SysFK_PM_PMPyrlStndrd")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqPmpyrlStndrd).HasColumnName("SysSeq_PMPyrlStndrd");

                entity.Property(e => e.TimeInPmpyrlStndrd)
                    .HasColumnName("TimeIn_PMPyrlStndrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TimeOutPmpyrlStndrd)
                    .HasColumnName("TimeOut_PMPyrlStndrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserPkPmpyrlStndrd)
                    .HasColumnName("UserPK_PMPyrlStndrd")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmpyrlStndrd).HasColumnName("UserSeq_PMPyrlStndrd");
            });

            modelBuilder.Entity<PolicyMasterPayrollTableSystem>(entity =>
            {
                entity.HasKey(e => e.SysPkPmpayTbl)
                    .HasName("PK__Policy_Master_Pa__605321AB");

                entity.ToTable("Policy_Master_Payroll_TableSystem");

                entity.Property(e => e.SysPkPmpayTbl)
                    .HasColumnName("SysPK_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.BracketEndPmpayTbl)
                    .HasColumnName("BracketEnd_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.BracketStartPmpayTbl)
                    .HasColumnName("BracketStart_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.ContributionEcPmpayTbl)
                    .HasColumnName("ContributionEC_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.ContributionEePmpayTbl)
                    .HasColumnName("ContributionEE_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.ContributionErPmpayTbl)
                    .HasColumnName("ContributionER_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.DescriptionPmpayTbl)
                    .HasColumnName("Description_PMPayTbl")
                    .HasMaxLength(50);

                entity.Property(e => e.First8Pmpaytbl)
                    .HasColumnName("First8_PMPaytbl")
                    .HasColumnType("money");

                entity.Property(e => e.IncomeDeclaredPmpayTbl)
                    .HasColumnName("IncomeDeclared_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.IncomeTaxRatePmpayTbl)
                    .HasColumnName("IncomeTaxRate_PMPayTbl")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByPmpayTbl)
                    .HasColumnName("LastUpdatedBy_PMPayTbl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmpayTbl).HasColumnName("LastUpdatedConcurrencyID_PMPayTbl");

                entity.Property(e => e.LastUpdatedDatePmpayTbl)
                    .HasColumnName("LastUpdatedDate_PMPayTbl")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModulePmpayTbl)
                    .HasColumnName("Module_PMPayTbl")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthlyPayEePmpayTbl)
                    .HasColumnName("MonthlyPayEE_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.MonthlyPayErPmpayTbl)
                    .HasColumnName("MonthlyPayER_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoacontriEePmpayTbl)
                    .HasColumnName("SysFK_COAContriEE_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoacontriErPmpayTbl)
                    .HasColumnName("SysFK_COAContriER_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoaincomeTaxPmpayTbl)
                    .HasColumnName("SysFK_COAIncomeTax_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoapayrollExpensePmpayTbl)
                    .HasColumnName("SysFK_COAPayrollExpense_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkPmPmpayTbl)
                    .HasColumnName("SysFK_PM_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqPmpayTbl).HasColumnName("SysSeq_PMPayTbl");

                entity.Property(e => e.TypePmpayTbl)
                    .HasColumnName("Type_PMPayTbl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmpayTbl)
                    .HasColumnName("UserPK_PMPayTbl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmpayTbl).HasColumnName("UserSeq_PMPayTbl");
            });

            modelBuilder.Entity<PolicyMasterPayrollTables>(entity =>
            {
                entity.HasKey(e => e.SysPkPmpayTbl);

                entity.ToTable("Policy_Master_Payroll_Tables");

                entity.Property(e => e.SysPkPmpayTbl)
                    .HasColumnName("SysPK_PMPayTbl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BracketEndPmpayTbl)
                    .HasColumnName("BracketEnd_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.BracketStartPmpayTbl)
                    .HasColumnName("BracketStart_PMPayTbl")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPmpayTbl)
                    .HasColumnName("LastUpdatedBy_PMPayTbl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmpayTbl)
                    .HasColumnName("LastUpdatedConcurrencyID_PMPayTbl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmpayTbl)
                    .HasColumnName("LastUpdatedDate_PMPayTbl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmpayTbl)
                    .HasColumnName("Module_PMPayTbl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoapayrollExpensePmpayTbl)
                    .HasColumnName("SysFK_COAPayrollExpense_PMPayTbl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPmpayTbl)
                    .HasColumnName("SysFK_PM_PMPayTbl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmpayTbl).HasColumnName("SysSeq_PMPayTbl");

                entity.Property(e => e.UserPkPmpayTbl)
                    .HasColumnName("UserPK_PMPayTbl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmpayTbl).HasColumnName("UserSeq_PMPayTbl");
            });

            modelBuilder.Entity<PolicyMasterReport>(entity =>
            {
                entity.HasKey(e => e.SysPkPmrpt);

                entity.ToTable("Policy_Master_Report");

                entity.Property(e => e.SysPkPmrpt)
                    .HasColumnName("SysPK_PMRpt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AdditionalWherePmrpt)
                    .HasColumnName("AdditionalWhere_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.CaptionPmrpt)
                    .HasColumnName("Caption_PMRpt")
                    .HasMaxLength(255);

                entity.Property(e => e.ColumnHiddenPmrpt).HasColumnName("ColumnHidden_PMRpt");

                entity.Property(e => e.ColumnNumAmountPmrpt)
                    .HasColumnName("ColumnNumAmount_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.ColumnNumPmrpt)
                    .HasColumnName("ColumnNum_PMRpt")
                    .HasMaxLength(255);

                entity.Property(e => e.ColumnTypePmrpt)
                    .HasColumnName("ColumnType_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.ColumnWidthPmrpt).HasColumnName("ColumnWidth_PMRpt");

                entity.Property(e => e.FieldNamePmrpt)
                    .HasColumnName("FieldName_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.FontBoldPmrpt).HasColumnName("FontBold_PMRpt");

                entity.Property(e => e.FontItalicPmrpt).HasColumnName("FontItalic_PMRpt");

                entity.Property(e => e.FontNamePmrpt)
                    .HasColumnName("FontName_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.FontUnderlinePmrpt).HasColumnName("FontUnderline_PMRpt");

                entity.Property(e => e.HasBottomLinePmrpt).HasColumnName("HasBottomLine_PMRpt");

                entity.Property(e => e.HasLeftLinePmrpt).HasColumnName("HasLeftLine_PMRpt");

                entity.Property(e => e.HasRightLinePmrpt).HasColumnName("HasRightLine_PMRpt");

                entity.Property(e => e.HasTopLinePmrpt).HasColumnName("HasTopLine_PMRpt");

                entity.Property(e => e.LastUpdatedByPmrpt)
                    .HasColumnName("LastUpdatedBy_PMRpt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmrpt)
                    .HasColumnName("LastUpdatedConcurrencyID_PMRpt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmrpt)
                    .HasColumnName("LastUpdatedDate_PMRpt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OperatorPmrpt)
                    .HasColumnName("Operator_PMRpt")
                    .HasColumnType("ntext");

                entity.Property(e => e.RowGroupPmrpt)
                    .HasColumnName("RowGroup_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.RowGroupSubTotalPmrpt)
                    .HasColumnName("RowGroupSubTotal_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.RowHiddenPmrpt).HasColumnName("RowHidden_PMRpt");

                entity.Property(e => e.RowNumPmrpt).HasColumnName("RowNum_PMRpt");

                entity.Property(e => e.SysFkDataPmrpt)
                    .HasColumnName("SysFK_Data_PMRpt")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkPmPmrpt)
                    .HasColumnName("SysFK_PM_PMRpt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmrpt).HasColumnName("SysSeq_PMRpt");

                entity.Property(e => e.TableNamePmrpt)
                    .HasColumnName("TableName_PMRpt")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmrpt).HasColumnName("UserSeq_PMRpt");
            });

            modelBuilder.Entity<PolicyMasterSalaryRate>(entity =>
            {
                entity.HasKey(e => e.SysPkPmslryRte);

                entity.ToTable("Policy_Master_SalaryRate");

                entity.Property(e => e.SysPkPmslryRte)
                    .HasColumnName("SysPK_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.HoursPerDayPmslryRte)
                    .HasColumnName("HoursPerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPmslryRte)
                    .HasColumnName("LastUpdatedBy_PMSlryRte")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmslryRte).HasColumnName("LastUpdatedConcurrencyID_PMSlryRte");

                entity.Property(e => e.LastUpdatedDatePmslryRte)
                    .HasColumnName("LastUpdatedDate_PMSlryRte")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.MaximumCaperWeekPmslryRte)
                    .HasColumnName("MaximumCAPerWeek_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.ModulePmslryRte)
                    .HasColumnName("Module_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.RateLegalHolidayPercentagePmslryRte)
                    .HasColumnName("RateLegalHolidayPercentage_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateOtpercentagePmslryRte)
                    .HasColumnName("RateOTPercentage_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RatePerDayPmslryRte)
                    .HasColumnName("RatePerDay_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RatePerHourPmslryRte)
                    .HasColumnName("RatePerHour_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RatePerMonthPmslryRte)
                    .HasColumnName("RatePerMonth_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.RateSpecialHolidayPercentagePmslryRte)
                    .HasColumnName("RateSpecialHolidayPercentage_PMSlryRte")
                    .HasColumnType("money");

                entity.Property(e => e.StatusPmslryRte)
                    .HasColumnName("Status_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmslryRte)
                    .HasColumnName("SysFK_PM_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmtblSysPagibigPmslryRte)
                    .HasColumnName("SysFK_PMTblSysPagibig_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmtblSysPhilhealthPmslryRte)
                    .HasColumnName("SysFK_PMTblSysPHILHEALTH_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmtblSysSssPmslryRte)
                    .HasColumnName("SysFK_PMTblSysSSS_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmtblSysWtaxPmslryRte)
                    .HasColumnName("SysFK_PMTblSysWTax_PMSlryRte")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmslryRte).HasColumnName("SysSeq_PMSlryRte");

                entity.Property(e => e.TypePmslryRte)
                    .HasColumnName("Type_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmslryRte)
                    .HasColumnName("UserPK_PMSlryRte")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmslryRte).HasColumnName("UserSeq_PMSlryRte");
            });

            modelBuilder.Entity<PolicyMasterSales>(entity =>
            {
                entity.HasKey(e => e.SysPkPmsal);

                entity.ToTable("Policy_Master_Sales");

                entity.Property(e => e.SysPkPmsal)
                    .HasColumnName("SysPK_PMSal")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsDefaultPmsal).HasColumnName("IsDefault_PMSal");

                entity.Property(e => e.IsIndependentPmsal).HasColumnName("IsIndependent_PMSal");

                entity.Property(e => e.LastUpdatedByPmsal)
                    .HasColumnName("LastUpdatedBy_PMSal")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmsal)
                    .HasColumnName("LastUpdatedConcurrencyID_PMSal")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmsal)
                    .HasColumnName("LastUpdatedDate_PMSal")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmsal)
                    .HasColumnName("Module_PMSal")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPmsal)
                    .HasColumnName("Status_PMSal")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmsal)
                    .HasColumnName("SysFK_PM_PMSal")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankPmsal)
                    .HasColumnName("SysFK_UMBank_PMSal")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmsal).HasColumnName("SysSeq_PMSal");

                entity.Property(e => e.TypePmsal)
                    .HasColumnName("Type_PMSal")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkUmbankPmsal)
                    .HasColumnName("UserFK_UMBank_PMSal")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmsal)
                    .HasColumnName("UserPK_PMSal")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmsal).HasColumnName("UserSeq_PMSal");
            });

            modelBuilder.Entity<PolicyMasterSupplier>(entity =>
            {
                entity.HasKey(e => e.SysPkPmsupl);

                entity.ToTable("Policy_Master_Supplier");

                entity.Property(e => e.SysPkPmsupl)
                    .HasColumnName("SysPK_PMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsDefaultPmsupl).HasColumnName("IsDefault_PMSupl");

                entity.Property(e => e.LastUpdatedByPmsupl)
                    .HasColumnName("LastUpdatedBy_PMSupl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmsupl)
                    .HasColumnName("LastUpdatedConcurrencyID_PMSupl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmsupl)
                    .HasColumnName("LastUpdatedDate_PMSupl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmsupl)
                    .HasColumnName("Module_PMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPmsupl)
                    .HasColumnName("Status_PMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaapPmsupl)
                    .HasColumnName("SysFK_COAAP_PMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainputTaxPmsupl)
                    .HasColumnName("SysFK_COAInputTax_PMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaoutputTaxPmsupl)
                    .HasColumnName("SysFK_COAOutputTax_PMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmPmsupl)
                    .HasColumnName("SysFK_PM_PMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmsupl).HasColumnName("SysSeq_PMSupl");

                entity.Property(e => e.TypePmsupl)
                    .HasColumnName("Type_PMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmsupl)
                    .HasColumnName("UserPK_PMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmsupl).HasColumnName("UserSeq_PMSupl");
            });

            modelBuilder.Entity<PolicyMasterWorkShift>(entity =>
            {
                entity.HasKey(e => e.SysPkPmwrkShft);

                entity.ToTable("Policy_Master_WorkShift");

                entity.Property(e => e.SysPkPmwrkShft)
                    .HasColumnName("SysPK_PMWrkShft")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsDefaultPmwrkShft).HasColumnName("IsDefault_PMWrkShft");

                entity.Property(e => e.LastUpdatedByPmwrkShft)
                    .HasColumnName("LastUpdatedBy_PMWrkShft")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPmwrkShft)
                    .HasColumnName("LastUpdatedConcurrencyID_PMWrkShft")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePmwrkShft)
                    .HasColumnName("LastUpdatedDate_PMWrkShft")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePmwrkShft)
                    .HasColumnName("Module_PMWrkShft")
                    .HasMaxLength(50);

                entity.Property(e => e.PassesMidnightPmwrkShft).HasColumnName("PassesMidnight_PMWrkShft");

                entity.Property(e => e.StatusPmwrkShft)
                    .HasColumnName("Status_PMWrkShft")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmPmwrkShft)
                    .HasColumnName("SysFK_PM_PMWrkShft")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPmwrkShft).HasColumnName("SysSeq_PMWrkShft");

                entity.Property(e => e.TimeEndPmwrkShft)
                    .HasColumnName("TimeEnd_PMWrkShft")
                    .HasMaxLength(50);

                entity.Property(e => e.TimeStartPmwrkShft)
                    .HasColumnName("TimeStart_PMWrkShft")
                    .HasMaxLength(50);

                entity.Property(e => e.TypePmwrkShft)
                    .HasColumnName("Type_PMWrkShft")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPmwrkShft)
                    .HasColumnName("UserPK_PMWrkShft")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPmwrkShft).HasColumnName("UserSeq_PMWrkShft");
            });

            modelBuilder.Entity<ReportDetails>(entity =>
            {
                entity.HasKey(e => e.SysPkRptDetl);

                entity.ToTable("Report_Details");

                entity.Property(e => e.SysPkRptDetl)
                    .HasColumnName("SysPK_RptDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Column01RptDetl)
                    .HasColumnName("Column01_RptDetl")
                    .HasMaxLength(255);

                entity.Property(e => e.Column02RptDetl)
                    .HasColumnName("Column02_RptDetl")
                    .HasMaxLength(255);

                entity.Property(e => e.Column03RptDetl)
                    .HasColumnName("Column03_RptDetl")
                    .HasMaxLength(255);

                entity.Property(e => e.Column04RptDetl)
                    .HasColumnName("Column04_RptDetl")
                    .HasMaxLength(255);

                entity.Property(e => e.Column05RptDetl)
                    .HasColumnName("Column05_RptDetl")
                    .HasMaxLength(255);

                entity.Property(e => e.ColumnAmount01RptDetl)
                    .HasColumnName("ColumnAmount01_RptDetl")
                    .HasColumnType("money");

                entity.Property(e => e.ColumnAmount02RptDetl)
                    .HasColumnName("ColumnAmount02_RptDetl")
                    .HasColumnType("money");

                entity.Property(e => e.RowGroupRptDetl)
                    .HasColumnName("RowGroup_RptDetl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmrptRptDetl)
                    .HasColumnName("SysFK_PMRpt_RptDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkRptMstrRptDetl)
                    .HasColumnName("SysFK_RptMstr_RptDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqRptDetl).HasColumnName("SysSeq_RptDetl");

                entity.Property(e => e.UserSeqRptDetl).HasColumnName("UserSeq_RptDetl");
            });

            modelBuilder.Entity<ReportMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkRptMstr);

                entity.ToTable("Report_Master");

                entity.Property(e => e.SysPkRptMstr)
                    .HasColumnName("SysPK_RptMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdRptMstr)
                    .HasColumnName("CBD_RptMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CriteriaAppliedRptMstr)
                    .HasColumnName("CriteriaApplied_RptMstr")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastUpdatedByRptMstr)
                    .HasColumnName("LastUpdatedBy_RptMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdRptMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_RptMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateRptMstr)
                    .HasColumnName("LastUpdatedDate_RptMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleRptMstr)
                    .HasColumnName("Module_RptMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsRptMstr)
                    .HasColumnName("Particulars_RptMstr")
                    .HasColumnType("ntext");

                entity.Property(e => e.SysFkPmRptMstr)
                    .HasColumnName("SysFK_PM_RptMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqRptMstr).HasColumnName("SysSeq_RptMstr");

                entity.Property(e => e.TitleRptMstr)
                    .HasColumnName("Title_RptMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.UserPkRptMstr)
                    .HasColumnName("UserPK_RptMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqRptMstr).HasColumnName("UserSeq_RptMstr");
            });

            modelBuilder.Entity<SecurityLog>(entity =>
            {
                entity.HasKey(e => e.SysPkSecurityLog);

                entity.ToTable("Security_Log");

                entity.Property(e => e.SysPkSecurityLog)
                    .HasColumnName("SysPK_SecurityLog")
                    .HasColumnType("money");

                entity.Property(e => e.ActionSecurityLog)
                    .HasColumnName("Action_SecurityLog")
                    .HasMaxLength(10);

                entity.Property(e => e.ComputerNameSecurityLog)
                    .HasColumnName("ComputerName_SecurityLog")
                    .HasMaxLength(15);

                entity.Property(e => e.DateSecurityLog)
                    .HasColumnName("Date_SecurityLog")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeSecurityLog)
                    .HasColumnName("DateTime_SecurityLog")
                    .HasColumnType("datetime");

                entity.Property(e => e.FormNameSecurityLog)
                    .HasColumnName("FormName_SecurityLog")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedBySecurityLog)
                    .HasColumnName("LastUpdatedBy_SecurityLog")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdSecurityLog).HasColumnName("LastUpdatedConcurrencyID_SecurityLog");

                entity.Property(e => e.LastUpdatedDateSecurityLog)
                    .HasColumnName("LastUpdatedDate_SecurityLog")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleSecurityLog)
                    .HasColumnName("Module_SecurityLog")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsSecurityLog)
                    .HasColumnName("Particulars_SecurityLog")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHSecurityLog)
                    .HasColumnName("SysFK_TransH_SecurityLog")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUserSecurityLog)
                    .HasColumnName("SysFK_User_SecurityLog")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqSecurityLog).HasColumnName("SysSeq_SecurityLog");

                entity.Property(e => e.UserPkSecurityLog)
                    .HasColumnName("UserPK_SecurityLog")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSecurityLog)
                    .HasColumnName("User_SecurityLog")
                    .HasMaxLength(10);

                entity.Property(e => e.UserSeqSecurityLog).HasColumnName("UserSeq_SecurityLog");
            });

            modelBuilder.Entity<SecurityModule>(entity =>
            {
                entity.HasKey(e => e.SysPkScrtyMod);

                entity.ToTable("Security_Module");

                entity.HasIndex(e => e.ModuleCaptionScrtyMod)
                    .HasName("IX_Security_Module_3");

                entity.HasIndex(e => e.ModuleScrtyMod)
                    .HasName("IX_Security_Module_1");

                entity.HasIndex(e => e.ModuleTypeScrtyMod)
                    .HasName("IX_Security_Module_2");

                entity.HasIndex(e => e.RightsScrtyMod)
                    .HasName("IX_Security_Module_4");

                entity.HasIndex(e => e.SysFkRoleScrtyMod)
                    .HasName("IX_Security_Module");

                entity.Property(e => e.SysPkScrtyMod)
                    .HasColumnName("SysPK_ScrtyMod")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByScrtyMod)
                    .HasColumnName("LastUpdatedBy_ScrtyMod")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdScrtyMod)
                    .HasColumnName("LastUpdatedConcurrencyID_ScrtyMod")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateScrtyMod)
                    .HasColumnName("LastUpdatedDate_ScrtyMod")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleCaptionScrtyMod)
                    .HasColumnName("ModuleCaption_ScrtyMod")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleScrtyMod)
                    .HasColumnName("Module_ScrtyMod")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeScrtyMod)
                    .HasColumnName("ModuleType_ScrtyMod")
                    .HasMaxLength(50);

                entity.Property(e => e.RightsScrtyMod)
                    .HasColumnName("Rights_ScrtyMod")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkRoleScrtyMod)
                    .HasColumnName("SysFK_Role_ScrtyMod")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqScrtyMod)
                    .HasColumnName("SysSeq_ScrtyMod")
                    .HasColumnType("money");

                entity.Property(e => e.UserSeqScrtyMod).HasColumnName("UserSeq_ScrtyMod");
            });

            modelBuilder.Entity<SecurityPermissions>(entity =>
            {
                entity.HasKey(e => e.SysPkScrtyPrm);

                entity.ToTable("Security_Permissions");

                entity.HasIndex(e => e.ControlCaptionScrtyPrm)
                    .HasName("IX_Security_Permissions_3");

                entity.HasIndex(e => e.FormCaptionScrtyPrm)
                    .HasName("IX_Security_Permissions_2");

                entity.HasIndex(e => e.ModuleScrtyPrm)
                    .HasName("IX_Security_Permissions_1");

                entity.HasIndex(e => e.RightsScrtyPrm)
                    .HasName("IX_Security_Permissions_4");

                entity.HasIndex(e => e.SysFkRoleScrtyPrm)
                    .HasName("IX_Security_Permissions");

                entity.Property(e => e.SysPkScrtyPrm)
                    .HasColumnName("SysPK_ScrtyPrm")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ControlCaptionScrtyPrm)
                    .HasColumnName("ControlCaption_ScrtyPrm")
                    .HasMaxLength(255);

                entity.Property(e => e.FormCaptionScrtyPrm)
                    .HasColumnName("FormCaption_ScrtyPrm")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByScrtyPrm)
                    .HasColumnName("LastUpdatedBy_ScrtyPrm")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdScrtyPrm)
                    .HasColumnName("LastUpdatedConcurrencyID_ScrtyPrm")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateScrtyPrm)
                    .HasColumnName("LastUpdatedDate_ScrtyPrm")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleScrtyPrm)
                    .HasColumnName("Module_ScrtyPrm")
                    .HasMaxLength(50);

                entity.Property(e => e.RightsScrtyPrm)
                    .HasColumnName("Rights_ScrtyPrm")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkRoleScrtyPrm)
                    .HasColumnName("SysFK_Role_ScrtyPrm")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqScrtyPrm)
                    .HasColumnName("SysSeq_ScrtyPrm")
                    .HasColumnType("money");

                entity.Property(e => e.UserSeqScrtyPrm).HasColumnName("UserSeq_ScrtyPrm");
            });

            modelBuilder.Entity<SecurityRoleCommandButton>(entity =>
            {
                entity.HasKey(e => e.SysPkScrtyRoleCmd);

                entity.ToTable("Security_Role_CommandButton");

                entity.HasIndex(e => e.CaptionScrtyRoleCmd)
                    .HasName("IX_Security_Role_CommandButton_3");

                entity.HasIndex(e => e.DisplayedCaptionScrtyRoleCmd)
                    .HasName("IX_Security_Role_CommandButton_4");

                entity.HasIndex(e => e.MainMenuScrtyRoleCmd)
                    .HasName("IX_Security_Role_CommandButton_2");

                entity.HasIndex(e => e.ModuleScrtyRoleCmd)
                    .HasName("IX_Security_Role_CommandButton_6");

                entity.HasIndex(e => e.SysFkScrtyRoleMstrScrtyRoleCmd)
                    .HasName("IX_Security_Role_CommandButton");

                entity.HasIndex(e => e.SysFkUmScrtyRoleCmd)
                    .HasName("IX_Security_Role_CommandButton_1");

                entity.HasIndex(e => e.TrimmedCaptionScrtyRoleCmd)
                    .HasName("IX_Security_Role_CommandButton_5");

                entity.Property(e => e.SysPkScrtyRoleCmd)
                    .HasColumnName("SysPK_ScrtyRoleCmd")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BackColorScrtyRoleCmd).HasColumnName("BackColor_ScrtyRoleCmd");

                entity.Property(e => e.CaptionScrtyRoleCmd)
                    .HasColumnName("Caption_ScrtyRoleCmd")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayedCaptionScrtyRoleCmd)
                    .HasColumnName("DisplayedCaption_ScrtyRoleCmd")
                    .HasMaxLength(100);

                entity.Property(e => e.ForeColorScrtyRoleCmd).HasColumnName("ForeColor_ScrtyRoleCmd");

                entity.Property(e => e.LastUpdatedByScrtyRoleCmd)
                    .HasColumnName("LastUpdatedBy_ScrtyRoleCmd")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdScrtyRoleCmd)
                    .HasColumnName("LastUpdatedConcurrencyID_ScrtyRoleCmd")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateScrtyRoleCmd)
                    .HasColumnName("LastUpdatedDate_ScrtyRoleCmd")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MainMenuScrtyRoleCmd)
                    .HasColumnName("MainMenu_ScrtyRoleCmd")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleScrtyRoleCmd)
                    .HasColumnName("Module_ScrtyRoleCmd")
                    .HasMaxLength(100);

                entity.Property(e => e.PictureFileNameScrtyRoleCmd)
                    .HasColumnName("PictureFileName_ScrtyRoleCmd")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkScrtyRoleMstrScrtyRoleCmd)
                    .HasColumnName("SysFK_ScrtyRoleMstr_ScrtyRoleCmd")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmScrtyRoleCmd)
                    .HasColumnName("SysFK_UM_ScrtyRoleCmd")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqScrtyRoleCmd)
                    .HasColumnName("SysSeq_ScrtyRoleCmd")
                    .HasColumnType("money");

                entity.Property(e => e.ToolTipTextScrtyRoleCmd)
                    .HasColumnName("ToolTipText_ScrtyRoleCmd")
                    .HasColumnType("ntext");

                entity.Property(e => e.TrimmedCaptionScrtyRoleCmd)
                    .HasColumnName("TrimmedCaption_ScrtyRoleCmd")
                    .HasMaxLength(100);

                entity.Property(e => e.UserSeqScrtyRoleCmd).HasColumnName("UserSeq_ScrtyRoleCmd");
            });

            modelBuilder.Entity<SecurityRoleMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkScrtyRoleMstr);

                entity.ToTable("Security_Role_Master");

                entity.HasIndex(e => e.UserPkScrtyRoleMstr)
                    .HasName("IX_Security_Role_Master");

                entity.Property(e => e.SysPkScrtyRoleMstr)
                    .HasColumnName("SysPK_ScrtyRoleMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdScrtyRoleMstr)
                    .HasColumnName("CBD_ScrtyRoleMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateEffectivityScrtyRoleMstr)
                    .HasColumnName("DateEffectivity_ScrtyRoleMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByScrtyRoleMstr)
                    .HasColumnName("LastUpdatedBy_ScrtyRoleMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdScrtyRoleMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_ScrtyRoleMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateScrtyRoleMstr)
                    .HasColumnName("LastUpdatedDate_ScrtyRoleMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticularsScrtyRoleMstr)
                    .HasColumnName("Particulars_ScrtyRoleMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.SysSeqScrtyRoleMstr)
                    .HasColumnName("SysSeq_ScrtyRoleMstr")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkScrtyRoleMstr)
                    .HasColumnName("UserPK_ScrtyRoleMstr")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SecurityRoleMenu>(entity =>
            {
                entity.HasKey(e => e.SysPkScrtyRoleMnu);

                entity.ToTable("Security_Role_Menu");

                entity.HasIndex(e => e.CaptionScrtyRoleMnu)
                    .HasName("IX_Security_Role_Menu_1");

                entity.HasIndex(e => e.DisplayedCaptionScrtyRoleMnu)
                    .HasName("IX_Security_Role_Menu_6");

                entity.HasIndex(e => e.MainMenuScrtyRoleMnu)
                    .HasName("IX_Security_Role_Menu_3");

                entity.HasIndex(e => e.ModuleScrtyRoleMnu)
                    .HasName("IX_Security_Role_Menu_2");

                entity.HasIndex(e => e.SubMenuScrtyRoleMnu)
                    .HasName("IX_Security_Role_Menu_4");

                entity.HasIndex(e => e.SysFkScrtyRoleMstrScrtyRoleMnu)
                    .HasName("IX_Security_Role_Menu");

                entity.HasIndex(e => e.TrimmedCaptionScrtyRoleMnu)
                    .HasName("IX_Security_Role_Menu_5");

                entity.Property(e => e.SysPkScrtyRoleMnu)
                    .HasColumnName("SysPK_ScrtyRoleMnu")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CaptionScrtyRoleMnu)
                    .HasColumnName("Caption_ScrtyRoleMnu")
                    .HasMaxLength(100);

                entity.Property(e => e.DisplayedCaptionScrtyRoleMnu)
                    .HasColumnName("DisplayedCaption_ScrtyRoleMnu")
                    .HasMaxLength(100);

                entity.Property(e => e.LastUpdatedByScrtyRoleMnu)
                    .HasColumnName("LastUpdatedBy_ScrtyRoleMnu")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdScrtyRoleMnu)
                    .HasColumnName("LastUpdatedConcurrencyID_ScrtyRoleMnu")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateScrtyRoleMnu)
                    .HasColumnName("LastUpdatedDate_ScrtyRoleMnu")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MainMenuScrtyRoleMnu)
                    .HasColumnName("MainMenu_ScrtyRoleMnu")
                    .HasMaxLength(100);

                entity.Property(e => e.ModuleScrtyRoleMnu)
                    .HasColumnName("Module_ScrtyRoleMnu")
                    .HasMaxLength(100);

                entity.Property(e => e.SubMenuScrtyRoleMnu)
                    .HasColumnName("SubMenu_ScrtyRoleMnu")
                    .HasMaxLength(100);

                entity.Property(e => e.SysFkScrtyRoleMstrScrtyRoleMnu)
                    .HasColumnName("SysFK_ScrtyRoleMstr_ScrtyRoleMnu")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqScrtyRoleMnu)
                    .HasColumnName("SysSeq_ScrtyRoleMnu")
                    .HasColumnType("money");

                entity.Property(e => e.TrimmedCaptionScrtyRoleMnu)
                    .HasColumnName("TrimmedCaption_ScrtyRoleMnu")
                    .HasMaxLength(100);

                entity.Property(e => e.UserSeqScrtyRoleMnu).HasColumnName("UserSeq_ScrtyRoleMnu");
            });

            modelBuilder.Entity<SecurityTemporaryPermissions>(entity =>
            {
                entity.HasKey(e => e.SysPkScrtyTmprm);

                entity.ToTable("Security_TemporaryPermissions");

                entity.HasIndex(e => e.ModuleCaptionScrtyTmprm)
                    .HasName("IX_Security_TemporaryPermissions_4");

                entity.HasIndex(e => e.ModuleScrtyTmprm)
                    .HasName("IX_Security_TemporaryPermissions_2");

                entity.HasIndex(e => e.ModuleTypeScrtyTmprm)
                    .HasName("IX_Security_TemporaryPermissions_3");

                entity.HasIndex(e => e.SysFkRoleScrtyTmprm)
                    .HasName("IX_Security_TemporaryPermissions");

                entity.HasIndex(e => e.SysFkUserScrtyTmprm)
                    .HasName("IX_Security_TemporaryPermissions_1");

                entity.HasIndex(e => e.UserPkusersScrtyTmprm)
                    .HasName("IX_Security_TemporaryPermissions_5");

                entity.Property(e => e.SysPkScrtyTmprm)
                    .HasColumnName("SysPK_ScrtyTmprm")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ActiveScrtyTmprm)
                    .HasColumnName("Active_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.DateActiveActiveScrtyTmprm)
                    .HasColumnName("DateActiveActive_ScrtyTmprm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateInActiveScrtyTmprm)
                    .HasColumnName("DateInActive_ScrtyTmprm")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DurationScrtyTmprm)
                    .HasColumnName("Duration_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByScrtyTmprm)
                    .HasColumnName("LastUpdatedBy_ScrtyTmprm")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdScrtyTmprm)
                    .HasColumnName("LastUpdatedConcurrencyID_ScrtyTmprm")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateScrtyTmprm)
                    .HasColumnName("LastUpdatedDate_ScrtyTmprm")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleCaptionScrtyTmprm)
                    .HasColumnName("ModuleCaption_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleScrtyTmprm)
                    .HasColumnName("Module_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeScrtyTmprm)
                    .HasColumnName("ModuleType_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.PermissionScrtyTmprm)
                    .HasColumnName("Permission_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.RightsScrtyTmprm)
                    .HasColumnName("Rights_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkRoleScrtyTmprm)
                    .HasColumnName("SysFK_Role_ScrtyTmprm")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUserScrtyTmprm)
                    .HasColumnName("SysFK_User_ScrtyTmprm")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqScrtyTmprm)
                    .HasColumnName("SysSeq_ScrtyTmprm")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkusersScrtyTmprm)
                    .HasColumnName("UserPKUsers_ScrtyTmprm")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqScrtyTmprm).HasColumnName("UserSeq_ScrtyTmprm");
            });

            modelBuilder.Entity<SecurityUser>(entity =>
            {
                entity.HasKey(e => e.SysPkScrtyUser);

                entity.ToTable("Security_User");

                entity.HasIndex(e => e.EditOnceModuleCaptionScrtyUser)
                    .HasName("IX_Security_User_2");

                entity.HasIndex(e => e.SysFkRoleScrtyUser)
                    .HasName("IX_Security_User");

                entity.HasIndex(e => e.SysFkUserScrtyUser)
                    .HasName("IX_Security_User_1");

                entity.HasIndex(e => e.UserFkUsersScrtyUser)
                    .HasName("IX_Security_User_3");

                entity.HasIndex(e => e.UserNameScrtyUser)
                    .HasName("IX_Security_User_4");

                entity.HasIndex(e => e.UserPkusersScrtyUser)
                    .HasName("IX_Security_User_5");

                entity.Property(e => e.SysPkScrtyUser)
                    .HasColumnName("SysPK_ScrtyUser")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EditOnceModuleCaptionScrtyUser)
                    .HasColumnName("EditOnceModuleCaption_ScrtyUser")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByScrtyUser)
                    .HasColumnName("LastUpdatedBy_ScrtyUser")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdScrtyUser)
                    .HasColumnName("LastUpdatedConcurrencyID_ScrtyUser")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateScrtyUser)
                    .HasColumnName("LastUpdatedDate_ScrtyUser")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SysFkRoleScrtyUser)
                    .HasColumnName("SysFK_Role_ScrtyUser")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUserScrtyUser)
                    .HasColumnName("SysFK_User_ScrtyUser")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqScrtyUser)
                    .HasColumnName("SysSeq_ScrtyUser")
                    .HasColumnType("money");

                entity.Property(e => e.UserFkUsersScrtyUser)
                    .HasColumnName("UserFK_Users_ScrtyUser")
                    .HasMaxLength(50);

                entity.Property(e => e.UserNameScrtyUser)
                    .HasColumnName("UserName_ScrtyUser")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPkusersScrtyUser)
                    .HasColumnName("UserPKUsers_ScrtyUser")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqScrtyUser).HasColumnName("UserSeq_ScrtyUser");
            });

            modelBuilder.Entity<SystemValuesMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkSysValMstr);

                entity.ToTable("System_Values_Master");

                entity.Property(e => e.SysPkSysValMstr)
                    .HasColumnName("SysPK_SysValMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdSysValMstr)
                    .HasColumnName("CBD_SysValMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DescriptionSysValMstr)
                    .HasColumnName("Description_SysValMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedBySysValMstr)
                    .HasColumnName("LastUpdatedBy_SysValMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdSysValMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_SysValMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateSysValMstr)
                    .HasColumnName("LastUpdatedDate_SysValMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleSysValMstr)
                    .HasColumnName("Module_SysValMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkSysValMstrParentSysValMstr)
                    .HasColumnName("SysFK_SysValMstrParent_SysValMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqSysValMstr).HasColumnName("SysSeq_SysValMstr");

                entity.Property(e => e.UserPkSysValMstr)
                    .HasColumnName("UserPK_SysValMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqSysValMstr).HasColumnName("UserSeq_SysValMstr");
            });

            modelBuilder.Entity<TransactionAccountableCheck>(entity =>
            {
                entity.HasKey(e => e.SysPkAcctCheck);

                entity.ToTable("Transaction_AccountableCheck");

                entity.Property(e => e.SysPkAcctCheck)
                    .HasColumnName("SysPK_AcctCheck")
                    .HasColumnType("money");

                entity.Property(e => e.BookNumAcctCheck)
                    .HasColumnName("BookNum_AcctCheck")
                    .HasMaxLength(50);

                entity.Property(e => e.DateDueAcctCheck)
                    .HasColumnName("DateDue_AcctCheck")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateGeneratedAcctCheck)
                    .HasColumnName("DateGenerated_AcctCheck")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueAcctCheck)
                    .HasColumnName("DateIssue_AcctCheck")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByAcctCheck)
                    .HasColumnName("LastUpdatedBy_AcctCheck")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedConcurrencyIdAcctCheck).HasColumnName("LastUpdatedConcurrencyID_AcctCheck");

                entity.Property(e => e.LastUpdatedDateAcctCheck)
                    .HasColumnName("LastUpdatedDate_AcctCheck")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleAcctCheck)
                    .HasColumnName("Module_AcctCheck")
                    .HasMaxLength(50);

                entity.Property(e => e.SeriesAcctCheck)
                    .HasColumnName("Series_AcctCheck")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusAcctCheck)
                    .HasColumnName("Status_AcctCheck")
                    .HasMaxLength(10);

                entity.Property(e => e.SysFkTransHAcctCheck)
                    .HasColumnName("SysFK_TransH_AcctCheck")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqAcctCheck).HasColumnName("SysSeq_AcctCheck");

                entity.Property(e => e.UserPkAcctCheck)
                    .HasColumnName("UserPK_AcctCheck")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqAcctCheck).HasColumnName("UserSeq_AcctCheck");
            });

            modelBuilder.Entity<TransactionAccountableNum>(entity =>
            {
                entity.HasKey(e => e.SysPkTransAcctNum);

                entity.ToTable("Transaction_AccountableNum");

                entity.Property(e => e.SysPkTransAcctNum)
                    .HasColumnName("SysPK_TransAcctNum")
                    .HasColumnType("money");

                entity.Property(e => e.BookNumTransAcctNum)
                    .HasColumnName("BookNum_TransAcctNum")
                    .HasMaxLength(50);

                entity.Property(e => e.DateGeneratedTransAcctNum)
                    .HasColumnName("DateGenerated_TransAcctNum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueTransChk)
                    .HasColumnName("DateIssue_TransChk")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueTransH)
                    .HasColumnName("DateIssue_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByTransAcctNum)
                    .HasColumnName("LastUpdatedBy_TransAcctNum")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransAcctNum).HasColumnName("LastUpdatedConcurrencyID_TransAcctNum");

                entity.Property(e => e.LastUpdatedDateTransAcctNum)
                    .HasColumnName("LastUpdatedDate_TransAcctNum")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleTransAcctNum)
                    .HasColumnName("Module_TransAcctNum")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransHTransAcctNum)
                    .HasColumnName("Module_TransH_TransAcctNum")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusTransAcctNum)
                    .HasColumnName("Status_TransAcctNum")
                    .HasMaxLength(50);

                entity.Property(e => e.SysSeqTransAcctNum).HasColumnName("SysSeq_TransAcctNum");

                entity.Property(e => e.UserFkInvoiceTransAcctNum)
                    .HasColumnName("UserFK_Invoice_TransAcctNum")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkTransAcctNum)
                    .HasColumnName("UserPK_TransAcctNum")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransAcctNum).HasColumnName("UserSeq_TransAcctNum");
            });

            modelBuilder.Entity<TransactionGlEntries>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrEntries);

                entity.ToTable("Transaction_GL_Entries");

                entity.Property(e => e.SysPkLdgrEntries)
                    .HasColumnName("SysPK_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CramountLdgrEntries)
                    .HasColumnName("CRAmount_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.DramountLdgrEntries)
                    .HasColumnName("DRAmount_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByLdgrEntries)
                    .HasColumnName("LastUpdatedBy_LdgrEntries")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrEntries)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrEntries")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrEntries)
                    .HasColumnName("LastUpdatedDate_LdgrEntries")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleLdgrEntries)
                    .HasColumnName("Module_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaLdgrEntries)
                    .HasColumnName("SysFK_COA_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyLdgrEntries)
                    .HasColumnName("SysFK_Invty_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntriesSlLdgrEntries)
                    .HasColumnName("SysFK_LdgrEntriesSL_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHLdgrEntries)
                    .HasColumnName("SysFK_TransH_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHslLdgrEntries)
                    .HasColumnName("SysFK_TransHSL_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmLdgrEntries)
                    .HasColumnName("SysFK_UM_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqLdgrEntries).HasColumnName("SysSeq_LdgrEntries");

                entity.Property(e => e.UserFkGenericClassLdgrEntries)
                    .HasColumnName("UserFK_GenericClass_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkUmdeptLdgrEntries)
                    .HasColumnName("UserFK_UMDept_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrEntries).HasColumnName("UserSeq_LdgrEntries");
            });

            modelBuilder.Entity<TransactionGlEntriesExtended>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrEntriesX);

                entity.ToTable("Transaction_GL_Entries_Extended");

                entity.Property(e => e.SysPkLdgrEntriesX)
                    .HasColumnName("SysPK_LdgrEntriesX")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountDueLdgrEntriesX)
                    .HasColumnName("AmountDue_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPayClrLdgrEntriesX)
                    .HasColumnName("AmountPayClr_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPayPdcLdgrEntriesX)
                    .HasColumnName("AmountPayPDC_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.ArrearsDueLdgrEntriesX)
                    .HasColumnName("ArrearsDue_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.BalanceClrLdgrEntriesX)
                    .HasColumnName("BalanceClr_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.BalancePdcLdgrEntriesX)
                    .HasColumnName("BalancePDC_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.CramountPdcLdgrEntriesX)
                    .HasColumnName("CRAmountPDC_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.CrbaseUnitQtyLdgrEntriesX)
                    .HasColumnName("CRBaseUnitQty_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.DateDueLdgrEntriesX)
                    .HasColumnName("DateDue_LdgrEntriesX")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DramountLdgrEntriesX)
                    .HasColumnName("DRAmount_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.DramountPdcLdgrEntriesX)
                    .HasColumnName("DRAmountPDC_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.DrbaseUnitQtyLdgrEntriesX)
                    .HasColumnName("DRBaseUnitQty_LdgrEntriesX")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleTransLdgrEntriesX)
                    .HasColumnName("ModuleTrans_LdgrEntriesX")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsLdgrEntriesX)
                    .HasColumnName("Particulars_LdgrEntriesX")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusLdgrEntriesX)
                    .HasColumnName("Status_LdgrEntriesX")
                    .HasMaxLength(50);

                entity.Property(e => e.UsualDueLdgrEntriesX)
                    .HasColumnName("UsualDue_LdgrEntriesX")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TransactionHeader>(entity =>
            {
                entity.HasKey(e => e.SysPkTransH);

                entity.ToTable("Transaction_Header");

                entity.HasIndex(e => e.AccountNameTransH)
                    .HasName("IX_Transaction_Header_2");

                entity.HasIndex(e => e.CbdTransH)
                    .HasName("IX_Transaction_Header_9");

                entity.HasIndex(e => e.DateIssueTransH)
                    .HasName("IX_Transaction_Header_1");

                entity.HasIndex(e => e.ModuleTransH)
                    .HasName("IX_Transaction_Header_3");

                entity.HasIndex(e => e.ModuleTypeTransH)
                    .HasName("IX_Transaction_Header_4");

                entity.HasIndex(e => e.SysFkAccountTransH)
                    .HasName("IX_Transaction_Header_8");

                entity.HasIndex(e => e.SysFkCoaTransH)
                    .HasName("IX_Transaction_Header_5");

                entity.HasIndex(e => e.SysFkInChargeTransH)
                    .HasName("IX_Transaction_Header_6");

                entity.HasIndex(e => e.SysFkInvtyTransH)
                    .HasName("IX_Transaction_Header_7");

                entity.HasIndex(e => e.UserPkTransH)
                    .HasName("IX_Transaction_Header");

                entity.Property(e => e.SysPkTransH)
                    .HasColumnName("SysPK_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccountBillingParticularsTransH)
                    .HasColumnName("AccountBillingParticulars_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountCodeGovtTransH)
                    .HasColumnName("AccountCodeGovt_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountCodeTransH)
                    .HasColumnName("AccountCode_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountContactPersonAndPositionTransH)
                    .HasColumnName("AccountContactPersonAndPosition_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountDeliveryParticularsTransH)
                    .HasColumnName("AccountDeliveryParticulars_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountDocumenTelNumTranH)
                    .HasColumnName("AccountDocumenTelNum_TranH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountDocumentByTransH)
                    .HasColumnName("AccountDocumentBy_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountDocumentNumTranH)
                    .HasColumnName("AccountDocumentNum_TranH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountNameTransH)
                    .HasColumnName("AccountName_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountPayeeNameTransH)
                    .HasColumnName("AccountPayeeName_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.AdvanceOrderNumTransH)
                    .HasColumnName("AdvanceOrderNum_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ApprovedByTransH)
                    .HasColumnName("ApprovedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaTransH)
                    .HasColumnName("Area_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.CancelledByTransH)
                    .HasColumnName("CancelledBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdTransH)
                    .HasColumnName("CBD_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CheckedByTransH)
                    .HasColumnName("CheckedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.DateAccountDocumentTranH)
                    .HasColumnName("DateAccountDocument_TranH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateAgingStartTransH)
                    .HasColumnName("DateAgingStart_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateAppliedTransH)
                    .HasColumnName("DateApplied_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueTransH)
                    .HasColumnName("DateIssue_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateLastBatchProcessedTransH)
                    .HasColumnName("DateLastBatchProcessed_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeIssueTransH)
                    .HasColumnName("DateTimeIssue_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DiscountTransH)
                    .HasColumnName("Discount_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ExcludeInSalesReportTransH)
                    .HasColumnName("ExcludeInSalesReport_TransH")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FootNoteTransH)
                    .HasColumnName("FootNote_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.ForeignConversionRateTransH)
                    .HasColumnName("ForeignConversionRate_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.ForeignSignTransH)
                    .HasColumnName("ForeignSign_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargedByTransH)
                    .HasColumnName("InChargedBy_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.IsPrintOutReturnedTransH)
                    .HasColumnName("IsPrintOutReturned_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.IsVariousAccountsTransH)
                    .HasColumnName("IsVariousAccounts_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.LastPrintByTransH)
                    .HasColumnName("LastPrintBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.LastPrintCountTransH).HasColumnName("LastPrintCount_TransH");

                entity.Property(e => e.LastUpdatedByTransH)
                    .HasColumnName("LastUpdatedBy_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransH)
                    .HasColumnName("LastUpdatedConcurrencyID_TransH")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransH)
                    .HasColumnName("LastUpdatedDate_TransH")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleJournalTransH)
                    .HasColumnName("ModuleJournal_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleMasterfileTransH)
                    .HasColumnName("ModuleMasterfile_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleSubTypeTransH)
                    .HasColumnName("ModuleSubType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransH)
                    .HasColumnName("Module_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransTransH)
                    .HasColumnName("ModuleTrans_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeTransH)
                    .HasColumnName("ModuleType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUserPkTransH)
                    .HasColumnName("ModuleUserPK_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsTransH)
                    .HasColumnName("Particulars_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.PostedByTransH)
                    .HasColumnName("PostedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PostedTransH)
                    .HasColumnName("Posted_TransH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedByDutyShiftTransH)
                    .HasColumnName("PreparedByDutyShift_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PreparedByTransH)
                    .HasColumnName("PreparedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PrintedByTransH)
                    .HasColumnName("PrintedBy_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesReportGroupTransH)
                    .HasColumnName("SalesReportGroup_TransH")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesReportOrderTransH)
                    .HasColumnName("SalesReportOrder_TransH")
                    .HasMaxLength(10);

                entity.Property(e => e.SequencePkTransH).HasColumnName("SequencePK_TransH");

                entity.Property(e => e.StatusAccountAsOfIssueDateTransH)
                    .HasColumnName("StatusAccountAsOfIssueDate_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusTransH)
                    .HasColumnName("Status_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.StubClassificationTransH)
                    .HasColumnName("StubClassification_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.StubDateGeneratedTransH)
                    .HasColumnName("StubDateGenerated_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.StubNoTransH)
                    .HasColumnName("StubNo_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.StubSeriesTransH)
                    .HasColumnName("StubSeries_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAccountDocumentAccountTransH)
                    .HasColumnName("SysFK_AccountDocumentAccount_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkAccountDocumentTransHTransH)
                    .HasColumnName("SysFK_AccountDocumentTransH_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkAccountTransH)
                    .HasColumnName("SysFK_Account_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkBatchTransHTransH)
                    .HasColumnName("SysFK_BatchTransH_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaTransH)
                    .HasColumnName("SysFK_COA_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInCharge2TransH)
                    .HasColumnName("SysFK_InCharge2_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInChargeTransH)
                    .HasColumnName("SysFK_InCharge_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyTransH)
                    .HasColumnName("SysFK_Invty_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHlinkTransH)
                    .HasColumnName("SysFK_TransHLink_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransH).HasColumnName("SysSeq_TransH");

                entity.Property(e => e.TotalAmountAccountDocumentTransH)
                    .HasColumnName("TotalAmountAccountDocument_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalAmountForeignTransH)
                    .HasColumnName("TotalAmountForeign_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalAmountTransH)
                    .HasColumnName("TotalAmount_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalEntriesTransH)
                    .HasColumnName("TotalEntries_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TypeAccountAsOfIssueDateTransH)
                    .HasColumnName("TypeAccountAsOfIssueDate_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeMasterfileAsOfIssueDateTransH)
                    .HasColumnName("TypeMasterfileAsOfIssueDate_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeTransH)
                    .HasColumnName("Type_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkAccountTransH)
                    .HasColumnName("UserFK_Account_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkBranchTransH)
                    .HasColumnName("UserFK_Branch_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkGenericClassTransH)
                    .HasColumnName("UserFK_GenericClass_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTransH)
                    .HasColumnName("UserPK_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkseqTransH)
                    .HasColumnName("UserPKSeq_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransH).HasColumnName("UserSeq_TransH");

                entity.Property(e => e.VoidedByTransH)
                    .HasColumnName("VoidedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.VoidedTransH)
                    .HasColumnName("Voided_TransH")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.SysFkAccountTransHNavigation)
                    .WithMany(p => p.TransactionHeader)
                    .HasForeignKey(d => d.SysFkAccountTransH)
                    .HasConstraintName("FK_Transaction_Header_Universal_Master2");
            });

            modelBuilder.Entity<TransactionHeaderAdjustment>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHadj);

                entity.ToTable("Transaction_Header_Adjustment");

                entity.Property(e => e.SysPkTransHadj)
                    .HasColumnName("SysPK_TransHAdj")
                    .HasColumnType("money");

                entity.Property(e => e.AccountDocumentNumTransHadj)
                    .HasColumnName("AccountDocumentNum_TransHAdj")
                    .HasMaxLength(10);

                entity.Property(e => e.DateIssueTransHadj)
                    .HasColumnName("DateIssue_TransHAdj")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByTransHadj)
                    .HasColumnName("LastUpdatedBy_TransHAdj")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedDateTransHadj)
                    .HasColumnName("LastUpdatedDate_TransHAdj")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SupplierCodTransHadj)
                    .HasColumnName("SupplierCod_TransHAdj")
                    .HasMaxLength(50);

                entity.Property(e => e.SupplierNameTransHadj)
                    .HasColumnName("SupplierName_TransHAdj")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHTransHadj)
                    .HasColumnName("SysFK_TransH_TransHAdj")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUmTransHadj)
                    .HasColumnName("SysFK_UM_TransHAdj")
                    .HasColumnType("money");

                entity.Property(e => e.TotalAmountTransHadj).HasColumnName("TotalAmount_TransHAdj");

                entity.Property(e => e.UserPkTransHadj)
                    .HasColumnName("UserPK_TransHAdj")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<TransactionHeaderAmortization>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHamort);

                entity.ToTable("Transaction_Header_Amortization");

                entity.Property(e => e.SysPkTransHamort)
                    .HasColumnName("SysPK_TransHAmort")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateDueTransHamort)
                    .HasColumnName("DateDue_TransHAmort")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HeaderDetailTransHamort)
                    .HasColumnName("HeaderDetail_TransHAmort")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestDueClrTransHamort)
                    .HasColumnName("InterestDueClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.InterestDueUnClrTransHamort)
                    .HasColumnName("InterestDueUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.InterestPayClrTransHamort)
                    .HasColumnName("InterestPayClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.InterestPayUnClrTransHamort)
                    .HasColumnName("InterestPayUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRemainingProcessedTransHamort)
                    .HasColumnName("InterestRemainingProcessed_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.InterestUsualDueTransHamort)
                    .HasColumnName("InterestUsualDue_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByTransHamort)
                    .HasColumnName("LastUpdatedBy_TransHAmort")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHamort)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHAmort")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHamort)
                    .HasColumnName("LastUpdatedDate_TransHAmort")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MiscDueClrTransHamort)
                    .HasColumnName("MiscDueClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.MiscDueUnClrTransHamort)
                    .HasColumnName("MiscDueUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.MiscPayClrTransHamort)
                    .HasColumnName("MiscPayClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.MiscPayUnClrTransHamort)
                    .HasColumnName("MiscPayUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.MiscRemainingProcessedTransHamort)
                    .HasColumnName("MiscRemainingProcessed_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.MiscUsualDueTransHamort)
                    .HasColumnName("MiscUsualDue_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyDueClrTransHamort)
                    .HasColumnName("PenaltyDueClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyDueUnClrTransHamort)
                    .HasColumnName("PenaltyDueUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyPayClrTransHamort)
                    .HasColumnName("PenaltyPayClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyPayUnClrTransHamort)
                    .HasColumnName("PenaltyPayUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyRemainingProcessedTransHamort)
                    .HasColumnName("PenaltyRemainingProcessed_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyUsualDueTransHamort)
                    .HasColumnName("PenaltyUsualDue_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDueClrTransHamort)
                    .HasColumnName("PrincipalDueClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDueUnClrTransHamort)
                    .HasColumnName("PrincipalDueUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalPayClrTransHamort)
                    .HasColumnName("PrincipalPayClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalPayUnClrTransHamort)
                    .HasColumnName("PrincipalPayUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalRemainingProcessedTransHamort)
                    .HasColumnName("PrincipalRemainingProcessed_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalUsualDueTransHamort)
                    .HasColumnName("PrincipalUsualDue_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDaysCountTransHamort)
                    .HasColumnName("SavingsDaysCount_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDueClrTransHamort)
                    .HasColumnName("SavingsDueClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDuePerDayTransHamort)
                    .HasColumnName("SavingsDuePerDay_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.StatusTransactionTransHamort)
                    .HasColumnName("StatusTransaction_TransHAmort")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHTransHamort)
                    .HasColumnName("SysFK_TransH_TransHAmort")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransHamort).HasColumnName("SysSeq_TransHAmort");

                entity.Property(e => e.TotalDueClrTransHamort)
                    .HasColumnName("TotalDueClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueUnClrTransHamort)
                    .HasColumnName("TotalDueUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPayClrTransHamort)
                    .HasColumnName("TotalPayClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPayUnClrTransHamort)
                    .HasColumnName("TotalPayUnClr_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.TotalRemainingProcessedTransHamort)
                    .HasColumnName("TotalRemainingProcessed_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.TotalUsualDueTransHamort)
                    .HasColumnName("TotalUsualDue_TransHAmort")
                    .HasColumnType("money");

                entity.Property(e => e.TypeTransactionTransHamort)
                    .HasColumnName("TypeTransaction_TransHAmort")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTransHamort)
                    .HasColumnName("UserPK_TransHAmort")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktypeTransHamort)
                    .HasColumnName("UserPKType_TransHAmort")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransHamort).HasColumnName("UserSeq_TransHAmort");
            });

            modelBuilder.Entity<TransactionHeaderAmounts>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHamt);

                entity.ToTable("Transaction_Header_Amounts");

                entity.Property(e => e.SysPkTransHamt)
                    .HasColumnName("SysPK_TransHAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountForTransHamt)
                    .HasColumnName("AmountFor_TransHAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.AmountTransHamt)
                    .HasColumnName("Amount_TransHAmt")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByTransHamt)
                    .HasColumnName("LastUpdatedBy_TransHAmt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHamt)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHAmt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHamt)
                    .HasColumnName("LastUpdatedDate_TransHAmt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTransHamt)
                    .HasColumnName("Module_TransHAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeTransHamt)
                    .HasColumnName("ModuleType_TransHAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsTransHamt)
                    .HasColumnName("Particulars_TransHAmt")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkInvtyTransHamt)
                    .HasColumnName("SysFK_Invty_TransHAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHTransHamt)
                    .HasColumnName("SysFK_TransH_TransHAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHsourceDocTransHamt)
                    .HasColumnName("SysFK_TransHSourceDoc_TransHAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransHamt)
                    .HasColumnName("SysSeq_TransHAmt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserSeqTransHamt)
                    .HasColumnName("UserSeq_TransHAmt")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TransactionHeaderChecks>(entity =>
            {
                entity.HasKey(e => e.SysPkTransChk);

                entity.ToTable("Transaction_Header_Checks");

                entity.HasIndex(e => e.CbdTransChk)
                    .HasName("IX_Transaction_Header_Checks");

                entity.HasIndex(e => e.ModuleTransChk)
                    .HasName("IX_Transaction_Header_Checks_1");

                entity.HasIndex(e => e.ModuleTransTransChk)
                    .HasName("IX_Transaction_Header_Checks_2");

                entity.Property(e => e.SysPkTransChk)
                    .HasColumnName("SysPK_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BankBranchTransChk)
                    .HasColumnName("BankBranch_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdTransChk)
                    .HasColumnName("CBD_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateClearTransChk)
                    .HasColumnName("DateClear_TransChk")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueTransChk)
                    .HasColumnName("DateIssue_TransChk")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateMailedTransChk)
                    .HasColumnName("DateMailed_TransChk")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateReceivedTransChk)
                    .HasColumnName("DateReceived_TransChk")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateReleasedTransChk)
                    .HasColumnName("DateReleased_TransChk")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DaysTransChk).HasColumnName("Days_TransChk");

                entity.Property(e => e.DepositCheckClrTransChk)
                    .HasColumnName("DepositCheckClr_TransChk")
                    .HasColumnType("money");

                entity.Property(e => e.DepositCheckUnClrTransChk)
                    .HasColumnName("DepositCheckUnClr_TransChk")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayAmountTransChk)
                    .HasColumnName("DisplayAmount_TransChk")
                    .HasColumnType("money");

                entity.Property(e => e.ForMailTransChk).HasColumnName("ForMail_TransChk");

                entity.Property(e => e.IsCheckMailedTransChk)
                    .HasColumnName("IsCheckMailed_TransChk")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsCheckReceivedTransChk)
                    .HasColumnName("IsCheckReceived_TransChk")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsCheckReleasedTransChk)
                    .HasColumnName("IsCheckReleased_TransChk")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsCompanyNameHiddenInCheckTransChk).HasColumnName("IsCompanyNameHiddenInCheck_TransChk");

                entity.Property(e => e.IsCrossCheckTransChk).HasColumnName("IsCrossCheck_TransChk");

                entity.Property(e => e.LastUpdatedByTransChk)
                    .HasColumnName("LastUpdatedBy_TransChk")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransChk)
                    .HasColumnName("LastUpdatedConcurrencyID_TransChk")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransChk)
                    .HasColumnName("LastUpdatedDate_TransChk")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MailRefNoTransChk)
                    .HasColumnName("MailRefNo_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransChk)
                    .HasColumnName("Module_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransTransChk)
                    .HasColumnName("ModuleTrans_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.PayeeTransChk)
                    .HasColumnName("Payee_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.SignatoryATransChk)
                    .HasColumnName("SignatoryA_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.SignatoryBTransChk)
                    .HasColumnName("SignatoryB_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusTransChk)
                    .HasColumnName("Status_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAcctChkTransChk)
                    .HasColumnName("SysFK_AcctChk_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaTransChk)
                    .HasColumnName("SysFK_COA_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntriesTransChk)
                    .HasColumnName("SysFK_LdgrEntries_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmTransChk)
                    .HasColumnName("SysFK_PM_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHTransChk)
                    .HasColumnName("SysFK_TransH_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmarapTransChk)
                    .HasColumnName("SysFK_UMARAP_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankTransChk)
                    .HasColumnName("SysFK_UMBank_TransChk")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransChk)
                    .HasColumnName("SysSeq_TransChk")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TypeTransChk)
                    .HasColumnName("Type_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTransChk)
                    .HasColumnName("UserPK_TransChk")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransChk)
                    .HasColumnName("UserSeq_TransChk")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.WithdrawalCheckClrTransChk)
                    .HasColumnName("WithdrawalCheckClr_TransChk")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalCheckUnClrTransChk)
                    .HasColumnName("WithdrawalCheckUnClr_TransChk")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TransactionHeaderCopra>(entity =>
            {
                entity.HasKey(e => e.SysFkTransHTransHcopra);

                entity.ToTable("Transaction_Header_Copra");

                entity.Property(e => e.SysFkTransHTransHcopra)
                    .HasColumnName("SysFK_TransH_TransHCopra")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AdjustmentAmountTransHcopra)
                    .HasColumnName("AdjustmentAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.AdjustmentAverageTransHcopra)
                    .HasColumnName("AdjustmentAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.AdjustmentKiloTransHcopra)
                    .HasColumnName("AdjustmentKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.CancelledContractAmountTransHcopra)
                    .HasColumnName("CancelledContractAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.CancelledContractAverageTransHcopra)
                    .HasColumnName("CancelledContractAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.CancelledContractKiloTransHcopra)
                    .HasColumnName("CancelledContractKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.CbdTransHcopra)
                    .HasColumnName("CBD_TransHCopra")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractBalanceEndAmountTransHcopra)
                    .HasColumnName("ContractBalanceEndAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractBalanceEndAverageTransHcopra)
                    .HasColumnName("ContractBalanceEndAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractBalanceEndKiloTransHcopra)
                    .HasColumnName("ContractBalanceEndKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractBeginnigAmountTransHcopra)
                    .HasColumnName("ContractBeginnigAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractBeginnigAverageTransHcopra)
                    .HasColumnName("ContractBeginnigAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractBeginnigKiloTransHcopra)
                    .HasColumnName("ContractBeginnigKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractClosedAmountTransHcopra)
                    .HasColumnName("ContractClosedAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractClosedAverageTransHcopra)
                    .HasColumnName("ContractClosedAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractClosedKiloTransHcopra)
                    .HasColumnName("ContractClosedKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractDeliveryAmountTransHcopra)
                    .HasColumnName("ContractDeliveryAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractDeliveryAverageTransHcopra)
                    .HasColumnName("ContractDeliveryAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ContractDeliveryKiloTransHcopra)
                    .HasColumnName("ContractDeliveryKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.DepositsAmountTransHcopra)
                    .HasColumnName("DepositsAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.DepositsAverageTransHcopra)
                    .HasColumnName("DepositsAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.DepositsKiloTransHcopra)
                    .HasColumnName("DepositsKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.InvtyBeginAmountTransHcopra)
                    .HasColumnName("InvtyBeginAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.InvtyBeginAverageTransHcopra)
                    .HasColumnName("InvtyBeginAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.InvtyBeginKiloTransHcopra)
                    .HasColumnName("InvtyBeginKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.InvtyEndAmountTransHcopra)
                    .HasColumnName("InvtyEndAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.InvtyEndAverageTransHcopra)
                    .HasColumnName("InvtyEndAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.InvtyEndKiloTransHcopra)
                    .HasColumnName("InvtyEndKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByTransHcopra)
                    .HasColumnName("LastUpdatedBy_TransHCopra")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHcopra)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHCopra")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHcopra)
                    .HasColumnName("LastUpdatedDate_TransHCopra")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTransHcopra)
                    .HasColumnName("Module_TransHCopra")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipmentToAmountTransHcopra)
                    .HasColumnName("ShipmentToAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ShipmentToAverageTransHcopra)
                    .HasColumnName("ShipmentToAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.ShipmentToKiloTransHcopra)
                    .HasColumnName("ShipmentToKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.SpotDeliveryAmountTransHcopra)
                    .HasColumnName("SpotDeliveryAmount_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.SpotDeliveryAverageTransHcopra)
                    .HasColumnName("SpotDeliveryAverage_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.SpotDeliveryKiloTransHcopra)
                    .HasColumnName("SpotDeliveryKilo_TransHCopra")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkTransHpreviousTransHcopra)
                    .HasColumnName("SysFK_TransHPrevious_TransHCopra")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmwarehouseTransHcopra)
                    .HasColumnName("SysFK_UMWarehouse_TransHCopra")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysPkTransHcopra)
                    .HasColumnName("SysPK_TransHCopra")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransHcopra).HasColumnName("SysSeq_TransHCopra");

                entity.Property(e => e.UserFkTransHpreviousTransHcopra)
                    .HasColumnName("UserFK_TransHPrevious_TransHCopra")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkUmwarehouseTransHcopra)
                    .HasColumnName("UserFK_UMWarehouse_TransHCopra")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTransHcopra)
                    .HasColumnName("UserPK_TransHCopra")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransHcopra).HasColumnName("UserSeq_TransHCopra");
            });

            modelBuilder.Entity<TransactionHeaderCxi>(entity =>
            {
                entity.HasKey(e => e.SysPkCxi);

                entity.ToTable("Transaction_Header_CXI");

                entity.Property(e => e.SysPkCxi)
                    .HasColumnName("SysPK_CXI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AdditionalInfoDocsProducedCertAunthCxi)
                    .HasColumnName("AdditionalInfoDocsProducedCertAunth_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.AgainstOrderCxi)
                    .HasColumnName("AgainstOrder_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.BankNameCxi)
                    .HasColumnName("BankName_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.ConsignedToAddressCxi)
                    .HasColumnName("ConsignedToAddress_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.ConsignedToNameCxi)
                    .HasColumnName("ConsignedToName_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.ConsignedToSysFkCxi)
                    .HasColumnName("ConsignedToSysFK_CXI")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignedToTinCxi)
                    .HasColumnName("ConsignedToTIN_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.ConsignedToUserFkCxi)
                    .HasColumnName("ConsignedToUserFK_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryOfDestinationCxi)
                    .HasColumnName("CountryOfDestination_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCxi)
                    .HasColumnName("Currency_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomsProcedureCodeCxi)
                    .HasColumnName("CustomsProcedureCode_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.DateOfDepartureCxi)
                    .HasColumnName("DateOfDeparture_CXI")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateOfLoadingCxi)
                    .HasColumnName("DateOfLoading_CXI")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DirectShipmentForTranshipmentByCxi)
                    .HasColumnName("DirectShipmentForTranshipmentBy_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.ExportDeclarationNumCxi)
                    .HasColumnName("ExportDeclarationNum_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.FobvalueOfImportedRawMaterialsCxi)
                    .HasColumnName("FOBValueOfImportedRawMaterials_CXI")
                    .HasColumnType("money");

                entity.Property(e => e.ForexCxi).HasColumnName("Forex_CXI");

                entity.Property(e => e.GrossWeightCxi)
                    .HasColumnName("GrossWeight_CXI")
                    .HasColumnType("money");

                entity.Property(e => e.HarmonizedSystemsCodeCxi)
                    .HasColumnName("HarmonizedSystemsCode_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.ItemFobpriceCxi)
                    .HasColumnName("ItemFOBPrice_CXI")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByCxi)
                    .HasColumnName("LastUpdatedBy_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCxi)
                    .HasColumnName("LastUpdatedConcurrencyID_CXI")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCxi)
                    .HasColumnName("LastUpdatedDate_CXI")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocalCarrierCxi)
                    .HasColumnName("LocalCarrier_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.MarksAndNumContainersDescriptionOfGoodsCxi)
                    .HasColumnName("MarksAndNumContainersDescriptionOfGoods_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.ModeOfPaymentCxi)
                    .HasColumnName("ModeOfPayment_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.NetWeightCxi)
                    .HasColumnName("NetWeight_CXI")
                    .HasColumnType("money");

                entity.Property(e => e.NumOfItemsTariffLinesCxi)
                    .HasColumnName("NumOfItemsTariffLines_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.PackingListDateIssueCxi)
                    .HasColumnName("PackingListDateIssue_CXI")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PackingListUserFkCxi)
                    .HasColumnName("PackingListUserFK_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.PageCxi)
                    .HasColumnName("Page_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.PortOfDepartureCxi)
                    .HasColumnName("PortOfDeparture_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.PortOfLoadingCxi)
                    .HasColumnName("PortOfLoading_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.PreviousImportDocumentNumCxi)
                    .HasColumnName("PreviousImportDocumentNum_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvinceOfOriginCxi)
                    .HasColumnName("ProvinceOfOrigin_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.ShippedFromCxi)
                    .HasColumnName("ShippedFrom_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.ShippedToCxi)
                    .HasColumnName("ShippedTo_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.ShippedViaNameCxi)
                    .HasColumnName("ShippedViaName_CXI")
                    .HasMaxLength(255);

                entity.Property(e => e.ShippedViaSysFkCxi)
                    .HasColumnName("ShippedViaSysFK_CXI")
                    .HasColumnType("money");

                entity.Property(e => e.ShippedViaUserFkCxi)
                    .HasColumnName("ShippedViaUserFK_CXI")
                    .HasMaxLength(100);

                entity.Property(e => e.ShippingDateCxi)
                    .HasColumnName("ShippingDate_CXI")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShippingMarksCxi)
                    .HasColumnName("ShippingMarks_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.SupplementaryUnitsCxi)
                    .HasColumnName("SupplementaryUnits_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHCxi)
                    .HasColumnName("SysFK_TransH_CXI")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalPackagesCxi)
                    .HasColumnName("TotalPackages_CXI")
                    .HasMaxLength(50);

                entity.Property(e => e.VesselAircraftCxi)
                    .HasColumnName("VesselAircraft_CXI")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TransactionHeaderDailyInvty>(entity =>
            {
                entity.HasKey(e => e.SysPkDlyInvty);

                entity.ToTable("Transaction_Header_DailyInvty");

                entity.Property(e => e.SysPkDlyInvty)
                    .HasColumnName("SysPK_DlyInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CashActualBreakdownBillsDlyInvty)
                    .HasColumnName("CashActualBreakdownBills_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashActualBreakdownChecksDetailsDlyInvty)
                    .HasColumnName("CashActualBreakdownChecksDetails_DlyInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.CashActualBreakdownChecksDlyInvty)
                    .HasColumnName("CashActualBreakdownChecks_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashActualBreakdownCoinsDlyInvty)
                    .HasColumnName("CashActualBreakdownCoins_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashActualDlyInvty)
                    .HasColumnName("CashActual_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashBeginDlyInvty)
                    .HasColumnName("CashBegin_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashEndDlyInvty)
                    .HasColumnName("CashEnd_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashExpectedDlyInvty)
                    .HasColumnName("CashExpected_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashOutDlyInvty)
                    .HasColumnName("CashOut_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardDlyInvty)
                    .HasColumnName("CreditCard_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DownPaymentsDlyInvty)
                    .HasColumnName("DownPayments_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesFuelDlyInvty)
                    .HasColumnName("ExpensesFuel_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesItemDlyInvty)
                    .HasColumnName("ExpensesItem_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesTotalDlyInvty)
                    .HasColumnName("ExpensesTotal_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByDlyInvty)
                    .HasColumnName("LastUpdatedBy_DlyInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdDlyInvty)
                    .HasColumnName("LastUpdatedConcurrencyID_DlyInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCxi)
                    .HasColumnName("LastUpdatedDate_CXI")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesArtotalDlyInvty)
                    .HasColumnName("SalesARTotal_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesCashTotalDlyInvty)
                    .HasColumnName("SalesCashTotal_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesFuelArDlyInvty)
                    .HasColumnName("SalesFuelAR_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesFuelCashDlyInvty)
                    .HasColumnName("SalesFuelCash_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesFuelTotalDlyInvty)
                    .HasColumnName("SalesFuelTotal_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesGrandTotalDlyInvty)
                    .HasColumnName("SalesGrandTotal_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesItemArDlyInvty)
                    .HasColumnName("SalesItemAR_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesItemCashDlyInvty)
                    .HasColumnName("SalesItemCash_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesItemTotalDlyInvty)
                    .HasColumnName("SalesItemTotal_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ServicesCashDlyInvty)
                    .HasColumnName("ServicesCash_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ShortExcessDlyInvty)
                    .HasColumnName("ShortExcess_DlyInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkTransHDlyInvty)
                    .HasColumnName("SysFK_TransH_DlyInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TransactionHeaderGuarantor>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHguarantor);

                entity.ToTable("Transaction_Header_Guarantor");

                entity.Property(e => e.SysPkTransHguarantor)
                    .HasColumnName("SysPK_TransHGuarantor")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccountCodeTransHguarantor)
                    .HasColumnName("AccountCode_TransHGuarantor")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountNameTransHguarantor)
                    .HasColumnName("AccountName_TransHGuarantor")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditLineAsOfDateIssueTransHguarantor)
                    .HasColumnName("CreditLineAsOfDateIssue_TransHGuarantor")
                    .HasColumnType("money");

                entity.Property(e => e.GuaranteedAmountTransHguarantor)
                    .HasColumnName("GuaranteedAmount_TransHGuarantor")
                    .HasColumnType("money");

                entity.Property(e => e.GuaranteedItemTransHguarantor)
                    .HasColumnName("GuaranteedItem_TransHGuarantor")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByTransHguarantor)
                    .HasColumnName("LastUpdatedBy_TransHGuarantor")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHguarantor)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHGuarantor")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHguarantor)
                    .HasColumnName("LastUpdatedDate_TransHGuarantor")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MasterfileTypeAsOfIssueDateTransHguarantor)
                    .HasColumnName("MasterfileTypeAsOfIssueDate_TransHGuarantor")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsTransHguarantor)
                    .HasColumnName("Particulars_TransHGuarantor")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusAccountAsOfIssueDateTransHguarantor)
                    .HasColumnName("StatusAccountAsOfIssueDate_TransHGuarantor")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAccountTransHguarantor)
                    .HasColumnName("SysFK_Account_TransHGuarantor")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHTransHguarantor)
                    .HasColumnName("SysFK_TransH_TransHGuarantor")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalBalClrAsOfDateIssueTransH)
                    .HasColumnName("TotalBalClrAsOfDateIssue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalBalUnClrAsOfDateIssueTransH)
                    .HasColumnName("TotalBalUnClrAsOfDateIssue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueClrAsOfDateIssueTransH)
                    .HasColumnName("TotalDueClrAsOfDateIssue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueUnClrAsOfDateIssueTransH)
                    .HasColumnName("TotalDueUnClrAsOfDateIssue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPayClrAsOfDateIssueTransH)
                    .HasColumnName("TotalPayClrAsOfDateIssue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPayUnClrAsOfDateIssueTransH)
                    .HasColumnName("TotalPayUnClrAsOfDateIssue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalRemainingProcessedTransH)
                    .HasColumnName("TotalRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TypeAccountAsOfIssueDateTransHguarantor)
                    .HasColumnName("TypeAccountAsOfIssueDate_TransHGuarantor")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTransHguarantor)
                    .HasColumnName("UserPK_TransHGuarantor")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransHguarantor).HasColumnName("UserSeq_TransHGuarantor");
            });

            modelBuilder.Entity<TransactionHeaderGuestFolio>(entity =>
            {
                entity.HasKey(e => e.SysPkGtrans);

                entity.ToTable("Transaction_Header_GuestFolio");

                entity.Property(e => e.SysPkGtrans)
                    .HasColumnName("SysPK_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountBalanceGtrans)
                    .HasColumnName("AmountBalance_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountChargesGtrans)
                    .HasColumnName("AmountCharges_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountChargesTransferGtrans)
                    .HasColumnName("AmountChargesTransfer_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountCommissionGtrans)
                    .HasColumnName("AmountCommission_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountCommissionRateGtrans)
                    .HasColumnName("AmountCommissionRate_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.AmountPaymentsGtrans)
                    .HasColumnName("AmountPayments_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPaymentsPdcGtrans)
                    .HasColumnName("AmountPaymentsPDC_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountRefundsGtrans)
                    .HasColumnName("AmountRefunds_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountRushGtrans)
                    .HasColumnName("AmountRush_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountServiceChargeGtrans)
                    .HasColumnName("AmountServiceCharge_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountTaxGtrans)
                    .HasColumnName("AmountTax_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountTaxRateGtrans)
                    .HasColumnName("AmountTaxRate_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.AmountTotalCreditGtrans)
                    .HasColumnName("AmountTotalCredit_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.AmountTotalDebitGtrans)
                    .HasColumnName("AmountTotalDebit_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.ByCashierGtrans)
                    .HasColumnName("ByCashier_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ByFrontOfficeGtrans)
                    .HasColumnName("ByFrontOffice_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ByHousekeepingGtrans)
                    .HasColumnName("ByHousekeeping_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ByWaiterGtrans)
                    .HasColumnName("ByWaiter_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardCheckBankGtrans)
                    .HasColumnName("CreditCardCheckBank_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardCheckNumGtrans)
                    .HasColumnName("CreditCardCheckNum_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardCheckTypeGtrans)
                    .HasColumnName("CreditCardCheckType_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.DateIssueGtrans)
                    .HasColumnName("DateIssue_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeCutOffGtrans)
                    .HasColumnName("DateTimeCutOff_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeEndGtrans)
                    .HasColumnName("DateTimeEnd_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeStartGtrans)
                    .HasColumnName("DateTimeStart_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DiscountedUnitPriceInGtrans)
                    .HasColumnName("DiscountedUnitPriceIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DiscountedUnitPriceOutGtrans)
                    .HasColumnName("DiscountedUnitPriceOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayDiscountGtrans)
                    .HasColumnName("DisplayDiscount_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayQtyAdditionalGtrans)
                    .HasColumnName("DisplayQtyAdditional_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyBeginGtrans)
                    .HasColumnName("DisplayQtyBegin_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyDamagedGtrans)
                    .HasColumnName("DisplayQtyDamaged_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyEndGtrans)
                    .HasColumnName("DisplayQtyEnd_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyInGtrans)
                    .HasColumnName("DisplayQtyIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyOutGtrans)
                    .HasColumnName("DisplayQtyOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalInGtrans)
                    .HasColumnName("DisplaySubTotalIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalOutGtrans)
                    .HasColumnName("DisplaySubTotalOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitMeasureGtrans)
                    .HasColumnName("DisplayUnitMeasure_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitPriceInGtrans)
                    .HasColumnName("DisplayUnitPriceIn_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitPriceOutGtrans)
                    .HasColumnName("DisplayUnitPriceOut_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.IsGtrans)
                    .HasColumnName("Is_GTrans")
                    .HasMaxLength(255);

                entity.Property(e => e.IsRushedGtrans).HasColumnName("IsRushed_GTrans");

                entity.Property(e => e.IsServiceChargedGtrans).HasColumnName("IsServiceCharged_GTrans");

                entity.Property(e => e.LastUpdatedByGtrans)
                    .HasColumnName("LastUpdatedBy_GTrans")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGtrans)
                    .HasColumnName("LastUpdatedConcurrencyID_GTrans")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGtrans)
                    .HasColumnName("LastUpdatedDate_GTrans")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleGtrans)
                    .HasColumnName("Module_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleSubTypeGtrans)
                    .HasColumnName("ModuleSubType_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeGtrans)
                    .HasColumnName("ModuleType_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentForGtrans)
                    .HasColumnName("PaymentFor_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.PaymentModeGtrans)
                    .HasColumnName("PaymentMode_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDocAmountGtrans)
                    .HasColumnName("ReferenceDocAmount_GTrans")
                    .HasColumnType("money");

                entity.Property(e => e.ReferenceDocByGtrans)
                    .HasColumnName("ReferenceDocBy_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.ReferenceDocDateGtrans)
                    .HasColumnName("ReferenceDocDate_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ReferenceDocNumGtrans)
                    .HasColumnName("ReferenceDocNum_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAgentGtrans)
                    .HasColumnName("SysFK_Agent_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkFaclGtrans)
                    .HasColumnName("SysFK_Facl_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGcompGtrans)
                    .HasColumnName("SysFK_GComp_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGfaclGtrans)
                    .HasColumnName("SysFK_GFacl_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGregGtrans)
                    .HasColumnName("SysFK_GReg_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkGtransParentGtrans)
                    .HasColumnName("SysFK_GTransParent_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyGtrans)
                    .HasColumnName("SysFK_Invty_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLedgerTransHGtrans)
                    .HasColumnName("SysFK_LedgerTransH_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSourceDocumentGtrans)
                    .HasColumnName("SysFK_SourceDocument_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHGtrans)
                    .HasColumnName("SysFK_TransH_GTrans")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqGtrans).HasColumnName("SysSeq_GTrans");

                entity.Property(e => e.TimeIssueGtrans)
                    .HasColumnName("TimeIssue_GTrans")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserFkFaclPriceGtrans)
                    .HasColumnName("UserFK_FaclPrice_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPaymentModeGtrans)
                    .HasColumnName("UserFK_PaymentMode_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkGtrans)
                    .HasColumnName("UserPK_GTrans")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqGtrans).HasColumnName("UserSeq_GTrans");
            });

            modelBuilder.Entity<TransactionHeaderJobs>(entity =>
            {
                entity.HasKey(e => e.SysPkJobTransH);

                entity.ToTable("Transaction_Header_Jobs");

                entity.Property(e => e.SysPkJobTransH)
                    .HasColumnName("SysPK_JobTransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByJobTransH)
                    .HasColumnName("LastUpdatedBy_JobTransH")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdJobTransH)
                    .HasColumnName("LastUpdatedConcurrencyID_JobTransH")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateJobTransH)
                    .HasColumnName("LastUpdatedDate_JobTransH")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleJobTransH)
                    .HasColumnName("Module_JobTransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsJobTransH)
                    .HasColumnName("Particulars_JobTransH")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameJobTransH)
                    .HasColumnName("PictureFileName_JobTransH")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusJobTransH)
                    .HasColumnName("Status_JobTransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHJobTransH)
                    .HasColumnName("SysFK_TransH_JobTransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TypeJobTransH)
                    .HasColumnName("Type_JobTransH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionHeaderJunction>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHj);

                entity.ToTable("Transaction_Header_Junction");

                entity.Property(e => e.SysPkTransHj)
                    .HasColumnName("SysPK_TransHJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByTransHj)
                    .HasColumnName("LastUpdatedBy_TransHJ")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHj)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHJ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHj)
                    .HasColumnName("LastUpdatedDate_TransHJ")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTransHj)
                    .HasColumnName("Module_TransHJ")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeTransHj)
                    .HasColumnName("ModuleType_TransHJ")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksTransHj)
                    .HasColumnName("Remarks_TransHJ")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkTransH01TransHj)
                    .HasColumnName("SysFK_TransH01_TransHJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransH02TransHj)
                    .HasColumnName("SysFK_TransH02_TransHJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransH03TransHj)
                    .HasColumnName("SysFK_TransH03_TransHJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransHj).HasColumnName("SysSeq_TransHJ");

                entity.Property(e => e.UserSeqTransHj).HasColumnName("UserSeq_TransHJ");
            });

            modelBuilder.Entity<TransactionHeaderLoans2>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHloan);

                entity.ToTable("Transaction_Header_Loans2");

                entity.Property(e => e.SysPkTransHloan)
                    .HasColumnName("SysPK_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AllowDebitOffsetTransHloan).HasColumnName("AllowDebitOffset_TransHLoan");

                entity.Property(e => e.AreaTransHloan)
                    .HasColumnName("Area_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.ArrearsAmountTransHloan)
                    .HasColumnName("ArrearsAmount_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.ArrearsAsOfTransHloan)
                    .HasColumnName("ArrearsAsOf_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BorrowerBirthdateTransHloan)
                    .HasColumnName("BorrowerBirthdate_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BorrowerBusinessAddressTransHloan)
                    .HasColumnName("BorrowerBusinessAddress_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.BorrowerCtcdateIssueTransHloan)
                    .HasColumnName("BorrowerCTCDateIssue_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BorrowerCtcnumTransHloan)
                    .HasColumnName("BorrowerCTCNum_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.BorrowerCtcplaceIssueTransHloan)
                    .HasColumnName("BorrowerCTCPlaceIssue_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.BorrowerPostalAddressTransHloan)
                    .HasColumnName("BorrowerPostalAddress_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.BorrowerSpadescriptionTransHloan)
                    .HasColumnName("BorrowerSPADescription_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.CardApperPcTransHloan)
                    .HasColumnName("CardAPPerPc_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CardCommissionAmountTransHloan)
                    .HasColumnName("CardCommissionAmount_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CardCommissionRateTransHloan)
                    .HasColumnName("CardCommissionRate_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CardCostPerPcTransHloan)
                    .HasColumnName("CardCostPerPc_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CardFaceValuePerPcTransHloan)
                    .HasColumnName("CardFaceValuePerPc_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CardIncomePerPcTransHloan)
                    .HasColumnName("CardIncomePerPc_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CardQtyTransHloan)
                    .HasColumnName("CardQty_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CardSellingPerPcTransHloan)
                    .HasColumnName("CardSellingPerPc_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CashReleasedTansHloan)
                    .HasColumnName("CashReleased_TansHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CheckDateTransHloan)
                    .HasColumnName("CheckDate_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CheckNumTransHloan)
                    .HasColumnName("CheckNum_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker1AddressPostalTransHloan)
                    .HasColumnName("CoMaker1AddressPostal_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.CoMaker1AmountCreditLineTransHloan)
                    .HasColumnName("CoMaker1AmountCreditLine_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CoMaker1AmountCurrentArTransHloan)
                    .HasColumnName("CoMaker1AmountCurrentAR_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CoMaker1AmountGuaranteedTransHloan)
                    .HasColumnName("CoMaker1AmountGuaranteed_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CoMaker1BirthDateTransHloan)
                    .HasColumnName("CoMaker1BirthDate_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CoMaker1CtcdateIssueTransHloan)
                    .HasColumnName("CoMaker1CTCDateIssue_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CoMaker1CtcnumTransHloan)
                    .HasColumnName("CoMaker1CTCNum_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker1CtcplaceIssueTransHloan)
                    .HasColumnName("CoMaker1CTCPlaceIssue_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker1NameTransHloan)
                    .HasColumnName("CoMaker1Name_TransHLoan")
                    .HasMaxLength(100);

                entity.Property(e => e.CoMaker1RelationshipTransHloan)
                    .HasColumnName("CoMaker1Relationship_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker1TinTransHloan)
                    .HasColumnName("CoMaker1TIN_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker2AddressPostalTransHloan)
                    .HasColumnName("CoMaker2AddressPostal_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.CoMaker2AmountCreditLineTransHloan)
                    .HasColumnName("CoMaker2AmountCreditLine_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CoMaker2AmountCurrentArTransHloan)
                    .HasColumnName("CoMaker2AmountCurrentAR_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CoMaker2AmountGuaranteedTransHloan)
                    .HasColumnName("CoMaker2AmountGuaranteed_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.CoMaker2BirthDateTransHloan)
                    .HasColumnName("CoMaker2BirthDate_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CoMaker2CtcdateIssueTransHloan)
                    .HasColumnName("CoMaker2CTCDateIssue_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CoMaker2CtcnumTransHloan)
                    .HasColumnName("CoMaker2CTCNum_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker2CtcplaceIssueTransHloan)
                    .HasColumnName("CoMaker2CTCPlaceIssue_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker2NameTransHloan)
                    .HasColumnName("CoMaker2Name_TransHLoan")
                    .HasMaxLength(100);

                entity.Property(e => e.CoMaker2RelationshipTransHloan)
                    .HasColumnName("CoMaker2Relationship_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.CoMaker2TinTransHloan)
                    .HasColumnName("CoMaker2TIN_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.DailySavingsTransHloan)
                    .HasColumnName("DailySavings_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.DateDueTransHloan)
                    .HasColumnName("DateDue_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFirstPaymentOnTransHloan)
                    .HasColumnName("DateFirstPaymentOn_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EnterpriseTransHloan)
                    .HasColumnName("Enterprise_TransHLoan")
                    .HasMaxLength(100);

                entity.Property(e => e.GracePeriodInDaysPastDueBeforePenaltyChargesTransHloan).HasColumnName("GracePeriodInDaysPastDueBeforePenaltyCharges_TransHLoan");

                entity.Property(e => e.HandlingFeeTransHloan)
                    .HasColumnName("HandlingFee_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InsuranceFeeTransHloan)
                    .HasColumnName("InsuranceFee_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestAdvancePaymentsTransHloan)
                    .HasColumnName("InterestAdvancePayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestComputationMethodTransHloan)
                    .HasColumnName("InterestComputationMethod_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestCurrentLoanTransHloan)
                    .HasColumnName("InterestCurrentLoan_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestDeductForAccountOfTransHloan)
                    .HasColumnName("InterestDeductForAccountOf_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestPaymentFrequencyTransHloan)
                    .HasColumnName("InterestPaymentFrequency_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestPreviousLoanPaymentsTransHloan)
                    .HasColumnName("InterestPreviousLoanPayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRateEntireTermTransHloan)
                    .HasColumnName("InterestRateEntireTerm_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRateMonthlyTransHloan)
                    .HasColumnName("InterestRateMonthly_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRateSimpleAnnualRateTransHloan)
                    .HasColumnName("InterestRateSimpleAnnualRate_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestUsualDueDailyTransHloan)
                    .HasColumnName("InterestUsualDueDaily_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestUsualDueMonthlyTransHloan)
                    .HasColumnName("InterestUsualDueMonthly_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.InterestUsualDueWeeklyTransHloan)
                    .HasColumnName("InterestUsualDueWeekly_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByTransHloan)
                    .HasColumnName("LastUpdatedBy_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHloan)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHLoan")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHloan)
                    .HasColumnName("LastUpdatedDate_TransHLoan")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoanCountTransHloan).HasColumnName("LoanCount_TransHLoan");

                entity.Property(e => e.LoanReceivableAdvancePaymentsTransHloan)
                    .HasColumnName("LoanReceivableAdvancePayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.LoanReceivableCurrentLoanTransHloan)
                    .HasColumnName("LoanReceivableCurrentLoan_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.LoanReceivablePreviousLoanPaymentsTransHloan)
                    .HasColumnName("LoanReceivablePreviousLoanPayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MembershipFeeTransHloan)
                    .HasColumnName("MembershipFee_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MiscExpensesTransHloan)
                    .HasColumnName("MiscExpenses_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MoafeeTransHloan)
                    .HasColumnName("MOAFee_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleTransHloan)
                    .HasColumnName("Module_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeTransHloan)
                    .HasColumnName("ModuleType_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.MortgageAmountTransHloan)
                    .HasColumnName("MortgageAmount_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.MortgageByVirtueOfTransHloan)
                    .HasColumnName("MortgageByVirtueOf_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.MortgageItemDescriptionTransHloan)
                    .HasColumnName("MortgageItemDescription_TransHLoan")
                    .HasColumnType("ntext");

                entity.Property(e => e.MortgageItemPictureFileNameTransHloan)
                    .HasColumnName("MortgageItemPictureFileName_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.NotarialFeeTransHloan)
                    .HasColumnName("NotarialFee_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.NumOfTimesReloanTransHloan).HasColumnName("NumOfTimesReloan_TransHLoan");

                entity.Property(e => e.OtherChargesTransHloan)
                    .HasColumnName("OtherCharges_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalAdvancePaymentsTransHloan)
                    .HasColumnName("PrincipalAdvancePayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalAuthorityBirthdateTransHloan)
                    .HasColumnName("PrincipalAuthorityBirthdate_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalAuthorityCtcdateIssueTransHloan)
                    .HasColumnName("PrincipalAuthorityCTCDateIssue_TransHLoan")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PrincipalAuthorityCtcnumTransHloan)
                    .HasColumnName("PrincipalAuthorityCTCNum_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalAuthorityCtcplaceIssueTransHloan)
                    .HasColumnName("PrincipalAuthorityCTCPlaceIssue_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalAuthorityNameTransHloan)
                    .HasColumnName("PrincipalAuthorityName_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalAuthorityPostalAddressTransHloan)
                    .HasColumnName("PrincipalAuthorityPostalAddress_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalAuthorityRelationshipTransHloan)
                    .HasColumnName("PrincipalAuthorityRelationship_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalAuthoritySpadescriptionTransHloan)
                    .HasColumnName("PrincipalAuthoritySPADescription_TransHLoan")
                    .HasMaxLength(255);

                entity.Property(e => e.PrincipalAuthorityTinTransHloan)
                    .HasColumnName("PrincipalAuthorityTIN_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalCurrentLoanTransHloan)
                    .HasColumnName("PrincipalCurrentLoan_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDeductForAccountOfTransHloan)
                    .HasColumnName("PrincipalDeductForAccountOf_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalPaymentFrequencyTransHloan)
                    .HasColumnName("PrincipalPaymentFrequency_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalPreviousLoanPaymentsTransHloan)
                    .HasColumnName("PrincipalPreviousLoanPayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalUsualDueDailyTransHloan)
                    .HasColumnName("PrincipalUsualDueDaily_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalUsualDueMonthlyTransHloan)
                    .HasColumnName("PrincipalUsualDueMonthly_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalUsualDueWeeklyTransHloan)
                    .HasColumnName("PrincipalUsualDueWeekly_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsAsOfAppliedDateTransHloan)
                    .HasColumnName("SavingsAsOfAppliedDate_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsRetainedRateTransHloan)
                    .HasColumnName("SavingsRetainedRate_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.SavingsRetainedTransHloan)
                    .HasColumnName("SavingsRetained_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.ShareCapitalAsOfAppliedDateTransHloan)
                    .HasColumnName("ShareCapitalAsOfAppliedDate_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.ShareCapitalRefundTransHloan)
                    .HasColumnName("ShareCapitalRefund_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.ShareCapitalRetainedRateTransHloan)
                    .HasColumnName("ShareCapitalRetainedRate_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.ShareCapitalRetainedTransHloan)
                    .HasColumnName("ShareCapitalRetained_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkBankTransHloan)
                    .HasColumnName("SysFK_Bank_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoMaker1TransHloan)
                    .HasColumnName("SysFK_CoMaker1_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoMaker2TransHloan)
                    .HasColumnName("SysFK_CoMaker2_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntryInterestDeductForAccountOfTransHloan)
                    .HasColumnName("SysFK_LdgrEntryInterestDeductForAccountOf_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntryInterestLoanPaymentsTransHloan)
                    .HasColumnName("SysFK_LdgrEntryInterestLoanPayments_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntryPrincipalDeductForAccountOfTransHloan)
                    .HasColumnName("SysFK_LdgrEntryPrincipalDeductForAccountOf_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntryPrincipalLoanPaymentsTransHloan)
                    .HasColumnName("SysFK_LdgrEntryPrincipalLoanPayments_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntrySlprincipalLoanPaymentsTransHloan)
                    .HasColumnName("SysFK_LdgrEntrySLPrincipalLoanPayments_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmTransHloan)
                    .HasColumnName("SysFK_PM_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmloanTransHloan)
                    .HasColumnName("SysFK_PMLoan_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPrincipalAuthorityTransHloan)
                    .HasColumnName("SysFK_PrincipalAuthority_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHTransHloan)
                    .HasColumnName("SysFK_TransH_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUminsuranceTransHloan)
                    .HasColumnName("SysFK_UMInsurance_TransHLoan")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransHloan).HasColumnName("SysSeq_TransHLoan");

                entity.Property(e => e.TermsInDaysTransHloan).HasColumnName("TermsInDays_TransHLoan");

                entity.Property(e => e.TermsInMonthsTransHloan).HasColumnName("TermsInMonths_TransHLoan");

                entity.Property(e => e.TermsInYearsTransHloan).HasColumnName("TermsInYears_TransHLoan");

                entity.Property(e => e.TotalAdvancePaymentsTransHloan)
                    .HasColumnName("TotalAdvancePayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDeductForAccountOfTransHloan)
                    .HasColumnName("TotalDeductForAccountOf_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDeductionsTransHloan)
                    .HasColumnName("TotalDeductions_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalFinanceChargesTransHloan)
                    .HasColumnName("TotalFinanceCharges_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOffsetAmountTransHloan)
                    .HasColumnName("TotalOffsetAmount_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOffsetDramountTransHloan)
                    .HasColumnName("TotalOffsetDRAmount_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPreviousLoanPaymentsTransHloan)
                    .HasColumnName("TotalPreviousLoanPayments_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalUsualDueDailyTransHloan)
                    .HasColumnName("TotalUsualDueDaily_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalUsualDueMonthlyTransHloan)
                    .HasColumnName("TotalUsualDueMonthly_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.TotalUsualDueWeeklyTransHloan)
                    .HasColumnName("TotalUsualDueWeekly_TransHLoan")
                    .HasColumnType("money");

                entity.Property(e => e.UserFkBankTransHloan)
                    .HasColumnName("UserFK_Bank_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkCoMaker1TransHloan)
                    .HasColumnName("UserFK_CoMaker1_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkCoMaker2TransHloan)
                    .HasColumnName("UserFK_CoMaker2_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPmTransHloan)
                    .HasColumnName("UserFK_PM_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPmloanTransHloan)
                    .HasColumnName("UserFK_PMLoan_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkPrincipalAuthorityTransHloan)
                    .HasColumnName("UserFK_PrincipalAuthority_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkTransHdeductForAccountOfTransHloan)
                    .HasColumnName("UserFK_TransHDeductForAccountOf_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkTransHpreviousLoanPaymentsTransHloan)
                    .HasColumnName("UserFK_TransHPreviousLoanPayments_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkUminsuranceTransHloan)
                    .HasColumnName("UserFK_UMInsurance_TransHLoan")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkAlternative)
                    .HasColumnName("UserPK_Alternative")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransHloan).HasColumnName("UserSeq_TransHLoan");
            });

            modelBuilder.Entity<TransactionHeaderLoans2Amort>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHloanAmrt);

                entity.ToTable("Transaction_Header_Loans2Amort");

                entity.Property(e => e.SysPkTransHloanAmrt)
                    .HasColumnName("SysPK_TransHLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateDueTransHloanAmrt)
                    .HasColumnName("DateDue_TransHLoanAmrt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DayNumTransHloanAmrt).HasColumnName("DayNum_TransHLoanAmrt");

                entity.Property(e => e.InterestDueClrTransHloanAmrt)
                    .HasColumnName("InterestDueClr_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.InterestRunBalTransHloanAmrt)
                    .HasColumnName("InterestRunBal_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.IsHolidayTransHloanAmrt).HasColumnName("IsHoliday_TransHLoanAmrt");

                entity.Property(e => e.LastUpdatedByTransHloanAmrt)
                    .HasColumnName("LastUpdatedBy_TransHLoanAmrt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHloanAmrt)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHLoanAmrt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHloanAmrt)
                    .HasColumnName("LastUpdatedDate_TransHLoanAmrt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MiscDueClrTransHloanAmrt)
                    .HasColumnName("MiscDueClr_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.MiscRunBalTransHloanAmrt)
                    .HasColumnName("MiscRunBal_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleTransHloanAmrt)
                    .HasColumnName("Module_TransHLoanAmrt")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalDueClrTransHloanAmrt)
                    .HasColumnName("PrincipalDueClr_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalRunBalTransHloanAmrt)
                    .HasColumnName("PrincipalRunBal_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDaysCountTransHloanAmrt)
                    .HasColumnName("SavingsDaysCount_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDueClrTransHloanAmrt)
                    .HasColumnName("SavingsDueClr_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SavingsDuePerDayTransHloanAmrt)
                    .HasColumnName("SavingsDuePerDay_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkTransHTransHloanAmrt)
                    .HasColumnName("SysFK_TransH_TransHLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHloanAmrtParentTransHloanAmrt)
                    .HasColumnName("SysFK_TransHLoanAmrtParent_TransHLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHloanTransHloanAmrt)
                    .HasColumnName("SysFK_TransHLoan_TransHLoanAmrt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransHloanAmrt).HasColumnName("SysSeq_TransHLoanAmrt");

                entity.Property(e => e.TotalDueClrTransHloanAmrt)
                    .HasColumnName("TotalDueClr_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.TotalRunBalTransHloanAmrt)
                    .HasColumnName("TotalRunBal_TransHLoanAmrt")
                    .HasColumnType("money");

                entity.Property(e => e.UserSeqTransHloanAmrt).HasColumnName("UserSeq_TransHLoanAmrt");

                entity.Property(e => e.WeekdayTransHloanAmrt)
                    .HasColumnName("Weekday_TransHLoanAmrt")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TransactionHeaderProcessingHistory>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHprocHist);

                entity.ToTable("Transaction_Header_ProcessingHistory");

                entity.Property(e => e.SysPkTransHprocHist)
                    .HasColumnName("SysPK_TransHProcHist")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastExportedByTransHprocHist)
                    .HasColumnName("LastExportedBy_TransHProcHist")
                    .HasMaxLength(255);

                entity.Property(e => e.LastExportedDateTransHprocHist)
                    .HasColumnName("LastExportedDate_TransHProcHist")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastImportedByTransHprocHist)
                    .HasColumnName("LastImportedBy_TransHProcHist")
                    .HasMaxLength(255);

                entity.Property(e => e.LastImportedDateTransHprocHist)
                    .HasColumnName("LastImportedDate_TransHProcHist")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SysFkTransHTransHprocHist)
                    .HasColumnName("SysFK_TransH_TransHProcHist")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TransactionHeaderSalesFuel>(entity =>
            {
                entity.HasKey(e => e.SysPkSfuel);

                entity.ToTable("Transaction_Header_SalesFuel");

                entity.Property(e => e.SysPkSfuel)
                    .HasColumnName("SysPK_SFuel")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CashActualBreakdownBillsSfuel)
                    .HasColumnName("CashActualBreakdownBills_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CashActualBreakdownChecksDetailsSfuel)
                    .HasColumnName("CashActualBreakdownChecksDetails_SFuel")
                    .HasColumnType("ntext");

                entity.Property(e => e.CashActualBreakdownChecksSfuel)
                    .HasColumnName("CashActualBreakdownChecks_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CashActualBreakdownCoinsSfuel)
                    .HasColumnName("CashActualBreakdownCoins_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CashActualSfuel)
                    .HasColumnName("CashActual_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CashBeginSfuel)
                    .HasColumnName("CashBegin_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CashEndSfuel)
                    .HasColumnName("CashEnd_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CashExpectedSfuel)
                    .HasColumnName("CashExpected_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CashOutSfuel)
                    .HasColumnName("CashOut_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CollectionsSfuel)
                    .HasColumnName("Collections_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardSfuel)
                    .HasColumnName("CreditCard_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.DownPaymentsSfuel)
                    .HasColumnName("DownPayments_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesFuelSfuel)
                    .HasColumnName("ExpensesFuel_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesItemSfuel)
                    .HasColumnName("ExpensesItem_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesTotalSfuel)
                    .HasColumnName("ExpensesTotal_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedBySfuel)
                    .HasColumnName("LastUpdatedBy_SFuel")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdSfuel)
                    .HasColumnName("LastUpdatedConcurrencyID_SFuel")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateSfuel)
                    .HasColumnName("LastUpdatedDate_SFuel")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SalesArtotalSfuel)
                    .HasColumnName("SalesARTotal_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesCashInvcTotalSfuel)
                    .HasColumnName("SalesCashInvcTotal_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesCashTotalSfuel)
                    .HasColumnName("SalesCashTotal_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesFuelArSfuel)
                    .HasColumnName("SalesFuelAR_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesFuelCashInvcSfuel)
                    .HasColumnName("SalesFuelCashInvc_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesFuelCashSfuel)
                    .HasColumnName("SalesFuelCash_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesFuelTotalSfuel)
                    .HasColumnName("SalesFuelTotal_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesGrandTotalSfuel)
                    .HasColumnName("SalesGrandTotal_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesItemArSfuel)
                    .HasColumnName("SalesItemAR_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesItemCashInvcSfuel)
                    .HasColumnName("SalesItemCashInvc_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesItemCashSfuel)
                    .HasColumnName("SalesItemCash_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SalesItemTotalSfuel)
                    .HasColumnName("SalesItemTotal_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.ServicesCashSfuel)
                    .HasColumnName("ServicesCash_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.ShortExcessSfuel)
                    .HasColumnName("ShortExcess_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.StockTransferFuelReceiveSfuel)
                    .HasColumnName("StockTransferFuelReceive_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.StockTransferFuelReleaseSfuel)
                    .HasColumnName("StockTransferFuelRelease_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.StockTransferItemReceiveSfuel)
                    .HasColumnName("StockTransferItemReceive_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.StockTransferItemReleaseSfuel)
                    .HasColumnName("StockTransferItemRelease_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.StockTransferTotalReceiveSfuel)
                    .HasColumnName("StockTransferTotalReceive_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.StockTransferTotalReleaseSfuel)
                    .HasColumnName("StockTransferTotalRelease_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkPrevControlSfuel)
                    .HasColumnName("SysFK_PrevControl_SFuel")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHSfuel)
                    .HasColumnName("SysFK_TransH_SFuel")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalHoseSfuel)
                    .HasColumnName("TotalHose_SFuel")
                    .HasColumnType("money");

                entity.Property(e => e.TotalSalesSfuel)
                    .HasColumnName("TotalSales_SFuel")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TransactionHeaderSalesPurch>(entity =>
            {
                entity.HasKey(e => e.SysPkSalePurch);

                entity.ToTable("Transaction_Header_SalesPurch");

                entity.Property(e => e.SysPkSalePurch)
                    .HasColumnName("SysPK_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountCoaSalePurch)
                    .HasColumnName("AmountCOA_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.AmountCoaforeignSalePurch)
                    .HasColumnName("AmountCOAForeign_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.AramountSalePurch)
                    .HasColumnName("ARAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.BondAmountSalePurch)
                    .HasColumnName("BondAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.CashPaymentAmountSalePurch)
                    .HasColumnName("CashPaymentAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.CashRefundAmountSalePurch)
                    .HasColumnName("CashRefundAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.CheckAmountClrSalePurch)
                    .HasColumnName("CheckAmountClr_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.CheckAmountPdcSalePurch)
                    .HasColumnName("CheckAmountPDC_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.CheckAmountSalePurch)
                    .HasColumnName("CheckAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.CheckBankBranchSalePurch)
                    .HasColumnName("CheckBankBranch_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckDateSalePurch)
                    .HasColumnName("CheckDate_SalePurch")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CheckNumSalePurch)
                    .HasColumnName("CheckNum_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckStatusSalePurch)
                    .HasColumnName("CheckStatus_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardBankSalePurch)
                    .HasColumnName("CreditCardBank_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardCustomerAmountSalePurch)
                    .HasColumnName("CreditCardCustomerAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardExpiryDateSalePurch)
                    .HasColumnName("CreditCardExpiryDate_SalePurch")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CreditCardNumSalePurch)
                    .HasColumnName("CreditCardNum_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardTypeSalePurch)
                    .HasColumnName("CreditCardType_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardVerificationNumSalePurch)
                    .HasColumnName("CreditCardVerificationNum_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditLineSalePurch)
                    .HasColumnName("CreditLine_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.DateDeliverOnSalePurch)
                    .HasColumnName("DateDeliverOn_SalePurch")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateDueSalePurch)
                    .HasColumnName("DateDue_SalePurch")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFirstDueSalePurch)
                    .HasColumnName("DateFirstDue_SalePurch")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DaysPastDueSalePurch).HasColumnName("DaysPastDue_SalePurch");

                entity.Property(e => e.DeliveryAddressSalePurch)
                    .HasColumnName("DeliveryAddress_SalePurch")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryInstructionSalePurch)
                    .HasColumnName("DeliveryInstruction_SalePurch")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryVesselSalePurch)
                    .HasColumnName("DeliveryVessel_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryViaSalePurch)
                    .HasColumnName("DeliveryVia_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountPercentSalePurch)
                    .HasColumnName("DiscountPercent_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.DuePerInstallmentSalePurch)
                    .HasColumnName("DuePerInstallment_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.ForeignConversionRateSalePurch)
                    .HasColumnName("ForeignConversionRate_SalePurch")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ForeignSignSalePurch)
                    .HasColumnName("ForeignSign_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.FreightChargeSalePurch)
                    .HasColumnName("FreightCharge_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.HasOtherChargesSalePurch).HasColumnName("HasOtherCharges_SalePurch");

                entity.Property(e => e.HasOtherPaymentsSalePurch).HasColumnName("HasOtherPayments_SalePurch");

                entity.Property(e => e.InvoiceReturnedSalePurch).HasColumnName("InvoiceReturned_SalePurch");

                entity.Property(e => e.IsSalePurch)
                    .HasColumnName("Is_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedBySalePurch)
                    .HasColumnName("LastUpdatedBy_SalePurch")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdSalePurch)
                    .HasColumnName("LastUpdatedConcurrencyID_SalePurch")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateSalePurch)
                    .HasColumnName("LastUpdatedDate_SalePurch")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MemoAmountSalePurch)
                    .HasColumnName("MemoAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.MiscAmountSalePurch)
                    .HasColumnName("MiscAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleSalePurch)
                    .HasColumnName("Module_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.NonSalesTotalSalePurch)
                    .HasColumnName("NonSalesTotal_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.NumOfInstallmentSalePurch)
                    .HasColumnName("NumOfInstallment_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.OutstandingDueSalePurch)
                    .HasColumnName("OutstandingDue_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.PaymentTypeSalePurch)
                    .HasColumnName("PaymentType_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseDiscountPercentSalePurch)
                    .HasColumnName("PurchaseDiscountPercent_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaseDiscountSalePurch)
                    .HasColumnName("PurchaseDiscount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.PurchaseGrossForeignAmountSalePurch)
                    .HasColumnName("PurchaseGrossForeignAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.PurchaseGrossLocalAmountSalePurch)
                    .HasColumnName("PurchaseGrossLocalAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.PurchaseNetForeignAmountSalePurch)
                    .HasColumnName("PurchaseNetForeignAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.PurchaseNetLocalAmountSalePurch)
                    .HasColumnName("PurchaseNetLocalAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.ReturnTypeSalePurch)
                    .HasColumnName("ReturnType_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.ReturnTypeSalesPurch)
                    .HasColumnName("ReturnType_SalesPurch")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesDiscountPercentSalePurch)
                    .HasColumnName("SalesDiscountPercent_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesDiscountSalePurch)
                    .HasColumnName("SalesDiscount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.SalesGrossForeignAmountSalePurch)
                    .HasColumnName("SalesGrossForeignAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.SalesGrossLocalAmountSalePurch)
                    .HasColumnName("SalesGrossLocalAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.SalesNetForeignAmountSalePurch)
                    .HasColumnName("SalesNetForeignAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.SalesNetLocalAmountSalePurch)
                    .HasColumnName("SalesNetLocalAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.SalesPurchTypeSalePurch)
                    .HasColumnName("SalesPurchType_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesReturnTypeSalePurch)
                    .HasColumnName("SalesReturnType_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDueSalePurch)
                    .HasColumnName("StatusDue_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAdvanceOrderSalesPurch)
                    .HasColumnName("SysFK_AdvanceOrder_SalesPurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaapSalePurch)
                    .HasColumnName("SysFK_COAAP_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaarSalePurch)
                    .HasColumnName("SysFK_COAAR_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacashPaymentSalePurch)
                    .HasColumnName("SysFK_COACashPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacheckPaymentSalePurch)
                    .HasColumnName("SysFK_COACheckPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacrCardPaymentSalePurch)
                    .HasColumnName("SysFK_COACrCardPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoamemoPaymentSalePurch)
                    .HasColumnName("SysFK_COAMemoPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntryMemoPaymentSalePurch)
                    .HasColumnName("SysFK_LdgrEntryMemoPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSalePurchParentSalePurch)
                    .HasColumnName("SysFK_SalePurchParent_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransH2SalePurch)
                    .HasColumnName("SysFK_TransH2_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHSalePurch)
                    .HasColumnName("SysFK_TransH_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHmemoSalePurch)
                    .HasColumnName("SysFK_TransHMemo_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankCashPaymentSalePurch)
                    .HasColumnName("SysFK_UMBankCashPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankCheckPaymentSalePurch)
                    .HasColumnName("SysFK_UMBankCheckPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankCrCardPaymentSalePurch)
                    .HasColumnName("SysFK_UMBankCrCardPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmmemoPaymentSalePurch)
                    .HasColumnName("SysFK_UMMemoPayment_SalePurch")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqSalePurch).HasColumnName("SysSeq_SalePurch");

                entity.Property(e => e.TaxLocalAmountSalePurch)
                    .HasColumnName("TaxLocalAmount_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.TaxLocalRateSalePurch)
                    .HasColumnName("TaxLocalRate_SalePurch")
                    .HasColumnType("money");

                entity.Property(e => e.TermsInDaysSalePurch).HasColumnName("TermsInDays_SalePurch");

                entity.Property(e => e.TermsInMonthsSalePurch).HasColumnName("TermsInMonths_SalePurch");

                entity.Property(e => e.TermsInYearsSalePurch).HasColumnName("TermsInYears_SalePurch");

                entity.Property(e => e.UserFkInvoicesSalePurch)
                    .HasColumnName("UserFK_Invoices_SalePurch")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqSalePurch).HasColumnName("UserSeq_SalePurch");
            });

            modelBuilder.Entity<TransactionHeaderSalesPurchOrder>(entity =>
            {
                entity.HasKey(e => e.SysPkSalePurchOrd);

                entity.ToTable("Transaction_Header_SalesPurchOrder");

                entity.Property(e => e.SysPkSalePurchOrd)
                    .HasColumnName("SysPK_SalePurchOrd")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateDeliverOnSalePurchOrd)
                    .HasColumnName("DateDeliverOn_SalePurchOrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateDueSalePurchOrd)
                    .HasColumnName("DateDue_SalePurchOrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFirstDueSalePurchOrd)
                    .HasColumnName("DateFirstDue_SalePurchOrd")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DaysPastDueSalePurchOrd).HasColumnName("DaysPastDue_SalePurchOrd");

                entity.Property(e => e.DeliveryAddressSalePurchOrd)
                    .HasColumnName("DeliveryAddress_SalePurchOrd")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryInstructionSalePurchOrd)
                    .HasColumnName("DeliveryInstruction_SalePurchOrd")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryVesselSalePurchOrd)
                    .HasColumnName("DeliveryVessel_SalePurchOrd")
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryViaSalePurchOrd)
                    .HasColumnName("DeliveryVia_SalePurchOrd")
                    .HasMaxLength(50);

                entity.Property(e => e.ForeignConversionRateSalePurchOrd)
                    .HasColumnName("ForeignConversionRate_SalePurchOrd")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ForeignSignSalePurchOrd)
                    .HasColumnName("ForeignSign_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.FreightChargeSalePurchOrd)
                    .HasColumnName("FreightCharge_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.HasOtherPaymentsSalePurchOrd).HasColumnName("HasOtherPayments_SalePurchOrd");

                entity.Property(e => e.InvoiceReturnedSalePurchOrd).HasColumnName("InvoiceReturned_SalePurchOrd");

                entity.Property(e => e.IsSalePurchOrd)
                    .HasColumnName("Is_SalePurchOrd")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedBySalePurchOrd)
                    .HasColumnName("LastUpdatedBy_SalePurchOrd")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdSalePurchOrd)
                    .HasColumnName("LastUpdatedConcurrencyID_SalePurchOrd")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateSalePurchOrd)
                    .HasColumnName("LastUpdatedDate_SalePurchOrd")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleSalePurchOrd)
                    .HasColumnName("Module_SalePurchOrd")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesDiscountSalePurchOrd)
                    .HasColumnName("SalesDiscount_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.SalesGrossForeignAmountSalePurchOrd)
                    .HasColumnName("SalesGrossForeignAmount_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.SalesGrossLocalAmountSalePurchOrd)
                    .HasColumnName("SalesGrossLocalAmount_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.SalesNetForeignAmountSalePurchOrd)
                    .HasColumnName("SalesNetForeignAmount_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.SalesNetLocalAmountSalePurchOrd)
                    .HasColumnName("SalesNetLocalAmount_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.SalesPurchTypeSalePurchOrd)
                    .HasColumnName("SalesPurchType_SalePurchOrd")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDueSalePurchOrd)
                    .HasColumnName("StatusDue_SalePurchOrd")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHSalePurchOrd)
                    .HasColumnName("SysFK_TransH_SalePurchOrd")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqSalePurchOrd).HasColumnName("SysSeq_SalePurchOrd");

                entity.Property(e => e.TaxLocalAmountSalePurchOrd)
                    .HasColumnName("TaxLocalAmount_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.TaxLocalRateSalePurchOrd)
                    .HasColumnName("TaxLocalRate_SalePurchOrd")
                    .HasColumnType("money");

                entity.Property(e => e.UserFkInvoicesSalePurchOrd)
                    .HasColumnName("UserFK_Invoices_SalePurchOrd")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqSalePurchOrd).HasColumnName("UserSeq_SalePurchOrd");
            });

            modelBuilder.Entity<TransactionHeaderShipping>(entity =>
            {
                entity.HasKey(e => e.SysPkTransHship);

                entity.ToTable("Transaction_Header_Shipping");

                entity.Property(e => e.SysPkTransHship)
                    .HasColumnName("SysPK_TransHShip")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BillofLadingAmountTransHship)
                    .HasColumnName("BillofLadingAmount_TransHShip")
                    .HasColumnType("money");

                entity.Property(e => e.BillofLadingNumTransHship)
                    .HasColumnName("BillofLadingNum_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.ContainerNumTransHship)
                    .HasColumnName("ContainerNum_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.ContainerSealNumTransHship)
                    .HasColumnName("ContainerSealNum_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.DateShippedTransHship)
                    .HasColumnName("DateShipped_TransHShip")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ExportNumTransHship)
                    .HasColumnName("ExportNum_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.FrieghtAmountTransHship)
                    .HasColumnName("FrieghtAmount_TransHShip")
                    .HasColumnType("money");

                entity.Property(e => e.HandlingAmountTransHship)
                    .HasColumnName("HandlingAmount_TransHShip")
                    .HasColumnType("money");

                entity.Property(e => e.ImportNumTransHship)
                    .HasColumnName("ImportNum_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.InsuranceAmountTransHship)
                    .HasColumnName("InsuranceAmount_TransHShip")
                    .HasColumnType("money");

                entity.Property(e => e.InsuranceNumTransHship)
                    .HasColumnName("InsuranceNum_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByTransHship)
                    .HasColumnName("LastUpdatedBy_TransHShip")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransHship)
                    .HasColumnName("LastUpdatedConcurrencyID_TransHShip")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransHship)
                    .HasColumnName("LastUpdatedDate_TransHShip")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShipNameTransHship)
                    .HasColumnName("ShipName_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipmentInChargeByTransHship)
                    .HasColumnName("ShipmentInChargeBy_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.ShippingChargedTransHship)
                    .HasColumnName("ShippingCharged_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkShipperTransHship)
                    .HasColumnName("SysFK_Shipper_TransHShip")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkVesselTransHship)
                    .HasColumnName("SysFK_Vessel_TransHShip")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserPkShipperTransHship)
                    .HasColumnName("UserPK_Shipper_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkVesselTransHship)
                    .HasColumnName("UserPK_Vessel_TransHShip")
                    .HasMaxLength(50);

                entity.Property(e => e.VesselNameTransHship)
                    .HasColumnName("VesselName_TransHShip")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionHeaderStockTransfer>(entity =>
            {
                entity.HasKey(e => e.SysPkStkXfer);

                entity.ToTable("Transaction_Header_StockTransfer");

                entity.Property(e => e.SysPkStkXfer)
                    .HasColumnName("SysPK_StkXfer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccountBillingParticularsStkXfer)
                    .HasColumnName("AccountBillingParticulars_StkXfer")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountContactPersonAndPositionStkXfer)
                    .HasColumnName("AccountContactPersonAndPosition_StkXfer")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountNameStkXfer)
                    .HasColumnName("AccountName_StkXfer")
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovedByStkXfer)
                    .HasColumnName("ApprovedBy_StkXfer")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaStkXfer)
                    .HasColumnName("Area_StkXfer")
                    .HasMaxLength(100);

                entity.Property(e => e.CheckedByStkXfer)
                    .HasColumnName("CheckedBy_StkXFer")
                    .HasMaxLength(50);

                entity.Property(e => e.DateDeliverOnStkXfer)
                    .HasColumnName("DateDeliverOn_StkXfer")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryAddressStkXfer)
                    .HasColumnName("DeliveryAddress_StkXfer")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryInstructionStkXfer)
                    .HasColumnName("DeliveryInstruction_StkXfer")
                    .HasMaxLength(255);

                entity.Property(e => e.DeliveryVesselStkXfer)
                    .HasColumnName("DeliveryVessel_StkXfer")
                    .HasMaxLength(50);

                entity.Property(e => e.DeliveryViaStkXfer)
                    .HasColumnName("DeliveryVia_StkXfer")
                    .HasMaxLength(50);

                entity.Property(e => e.FreightChargeStkXfer)
                    .HasColumnName("FreightCharge_StkXfer")
                    .HasColumnType("money");

                entity.Property(e => e.InChargedByStkXfer)
                    .HasColumnName("InChargedBy_StkXfer")
                    .HasMaxLength(100);

                entity.Property(e => e.LastUpdatedByStkXfer)
                    .HasColumnName("LastUpdatedBy_StkXfer")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdStkXfer)
                    .HasColumnName("LastUpdatedConcurrencyID_StkXfer")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateStkXfer)
                    .HasColumnName("LastUpdatedDate_StkXfer")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleStkXfer)
                    .HasColumnName("Module_StkXfer")
                    .HasMaxLength(50);

                entity.Property(e => e.PreparedByDutyShiftStkXfer)
                    .HasColumnName("PreparedByDutyShift_StkXfer")
                    .HasMaxLength(50);

                entity.Property(e => e.PreparedByStkXfer)
                    .HasColumnName("PreparedBy_StkXfer")
                    .HasMaxLength(50);

                entity.Property(e => e.StockReceivedStkXfer).HasColumnName("StockReceived_StkXfer");

                entity.Property(e => e.SysFkAccountStkXfer)
                    .HasColumnName("SysFK_Account_StkXfer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInChargeStkXfer)
                    .HasColumnName("SysFK_InCharge_StkXfer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHStkXfer)
                    .HasColumnName("SysFK_TransH_StkXfer")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqStkXfer).HasColumnName("SysSeq_StkXfer");

                entity.Property(e => e.UserSeqStkXfer).HasColumnName("UserSeq_StkXfer");
            });

            modelBuilder.Entity<TransactionHeaderSystemRecords>(entity =>
            {
                entity.HasKey(e => e.SysPkTransH);

                entity.ToTable("Transaction_Header_SystemRecords");

                entity.Property(e => e.SysPkTransH)
                    .HasColumnName("SysPK_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccountBillingParticularsTransH)
                    .HasColumnName("AccountBillingParticulars_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountCodeGovtTransH)
                    .HasColumnName("AccountCodeGovt_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountCodeTransH)
                    .HasColumnName("AccountCode_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountConfidentialityLevelTransH).HasColumnName("AccountConfidentialityLevel_TransH");

                entity.Property(e => e.AccountContactPersonAndPositionTransH)
                    .HasColumnName("AccountContactPersonAndPosition_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountCreditLineAsOfDateIssueTransH)
                    .HasColumnName("AccountCreditLineAsOfDateIssue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccountDeliveryParticularsTransH)
                    .HasColumnName("AccountDeliveryParticulars_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.AccountDocumentByTransH)
                    .HasColumnName("AccountDocumentBy_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountDocumentNumTranH)
                    .HasColumnName("AccountDocumentNum_TranH")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountNameTransH)
                    .HasColumnName("AccountName_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.AccountTransactionCountTranH).HasColumnName("AccountTransactionCount_TranH");

                entity.Property(e => e.AccumulatedBalClrTransH)
                    .HasColumnName("AccumulatedBalClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedBalUnClrTransH)
                    .HasColumnName("AccumulatedBalUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedDueClrTransH)
                    .HasColumnName("AccumulatedDueClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedDueUnClrTransH)
                    .HasColumnName("AccumulatedDueUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedInterestRemainingProcessedTransH)
                    .HasColumnName("AccumulatedInterestRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedMiscRemainingProcessedTransH)
                    .HasColumnName("AccumulatedMiscRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedPayClrTransH)
                    .HasColumnName("AccumulatedPayClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedPayUnClrTransH)
                    .HasColumnName("AccumulatedPayUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedPenaltyRemainingProcessedTransH)
                    .HasColumnName("AccumulatedPenaltyRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedPrincipalRemainingProcessedTransH)
                    .HasColumnName("AccumulatedPrincipalRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedRemainingProcessedTransH)
                    .HasColumnName("AccumulatedRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedUsualDueInterestTransH)
                    .HasColumnName("AccumulatedUsualDueInterest_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedUsualDueMiscTransH)
                    .HasColumnName("AccumulatedUsualDueMisc_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedUsualDuePenaltyTransH)
                    .HasColumnName("AccumulatedUsualDuePenalty_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedUsualDuePrincipalTransH)
                    .HasColumnName("AccumulatedUsualDuePrincipal_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.AccumulatedUsualDueTransH)
                    .HasColumnName("AccumulatedUsualDue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.ApprovedByTransH)
                    .HasColumnName("ApprovedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaTransH)
                    .HasColumnName("Area_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.CancelledByTransH)
                    .HasColumnName("CancelledBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdTransH)
                    .HasColumnName("CBD_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CheckedByTransH)
                    .HasColumnName("CheckedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.DateAccountDocumentTranH)
                    .HasColumnName("DateAccountDocument_TranH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateAgingStartTransH)
                    .HasColumnName("DateAgingStart_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateAppliedTransH)
                    .HasColumnName("DateApplied_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFirstDueInterestTransH)
                    .HasColumnName("DateFirstDueInterest_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFirstDuePrincipalTransH)
                    .HasColumnName("DateFirstDuePrincipal_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFullyPaidTransH)
                    .HasColumnName("DateFullyPaid_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIdealDueTransH)
                    .HasColumnName("DateIdealDue_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueTransH)
                    .HasColumnName("DateIssue_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateLastBatchProcessedTransH)
                    .HasColumnName("DateLastBatchProcessed_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateNextDueInterestTransH)
                    .HasColumnName("DateNextDueInterest_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateNextDueMiscTransH)
                    .HasColumnName("DateNextDueMisc_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateNextDuePenaltyTransH)
                    .HasColumnName("DateNextDuePenalty_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateNextDuePrincipalTransH)
                    .HasColumnName("DateNextDuePrincipal_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.EdilinkTransH)
                    .HasColumnName("EDILink_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.EnterprisePolicyTransH)
                    .HasColumnName("EnterprisePolicy_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.FootNoteTransH)
                    .HasColumnName("FootNote_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.HeaderDetailTransH)
                    .HasColumnName("HeaderDetail_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.HowPostedTransH)
                    .HasColumnName("HowPosted_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.InChargedByTransH)
                    .HasColumnName("InChargedBy_TransH")
                    .HasMaxLength(100);

                entity.Property(e => e.InterestDueClrTransH)
                    .HasColumnName("InterestDueClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.InterestDueEveryTransH)
                    .HasColumnName("InterestDueEvery_TransH")
                    .HasMaxLength(20);

                entity.Property(e => e.InterestDueUnClrTransH)
                    .HasColumnName("InterestDueUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.InterestMethodTransH)
                    .HasColumnName("InterestMethod_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestMonthlyRateTransH)
                    .HasColumnName("InterestMonthlyRate_TransH")
                    .HasColumnType("numeric(18, 8)");

                entity.Property(e => e.InterestPayClrTransH)
                    .HasColumnName("InterestPayClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.InterestPayUnClrTransH)
                    .HasColumnName("InterestPayUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.InterestPostingTransH)
                    .HasColumnName("InterestPosting_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestRemainingProcessedTransH)
                    .HasColumnName("InterestRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.InterestTermsDisplayedTransH)
                    .HasColumnName("InterestTermsDisplayed_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestTermsInUseTransH)
                    .HasColumnName("InterestTermsInUse_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.InterestTermsInstallmentsTransH).HasColumnName("InterestTermsInstallments_TransH");

                entity.Property(e => e.InterestUsualDueTransH)
                    .HasColumnName("InterestUsualDue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.IsPrintOutReturnedTransH)
                    .HasColumnName("IsPrintOutReturned_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.IsTemporaryNoBilling).HasMaxLength(50);

                entity.Property(e => e.IsVariousAccountsTransH)
                    .HasColumnName("IsVariousAccounts_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByTransH)
                    .HasColumnName("LastUpdatedBy_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTransH)
                    .HasColumnName("LastUpdatedConcurrencyID_TransH")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTransH)
                    .HasColumnName("LastUpdatedDate_TransH")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MiscDueClrTransH)
                    .HasColumnName("MiscDueClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.MiscDueUnClrTransH)
                    .HasColumnName("MiscDueUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.MiscPayClrTransH)
                    .HasColumnName("MiscPayClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.MiscPayUnClrTransH)
                    .HasColumnName("MiscPayUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.MiscRemainingProcessedTransH)
                    .HasColumnName("MiscRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.MiscUsualDueTransH)
                    .HasColumnName("MiscUsualDue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleJournalTransH)
                    .HasColumnName("ModuleJournal_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleLedgerTransH)
                    .HasColumnName("ModuleLedger_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleLinkTransH)
                    .HasColumnName("ModuleLink_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleSubTypeTransH)
                    .HasColumnName("ModuleSubType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransH)
                    .HasColumnName("Module_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransTransH)
                    .HasColumnName("ModuleTrans_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeTransH)
                    .HasColumnName("ModuleType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.OtherAmountPerUnitTransH)
                    .HasColumnName("OtherAmountPerUnit_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.OtherAmountQtyTransH)
                    .HasColumnName("OtherAmountQty_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.ParticularsTransH)
                    .HasColumnName("Particulars_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentPriorityTransH)
                    .HasColumnName("PaymentPriority_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyDueClrTransH)
                    .HasColumnName("PenaltyDueClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyDueUnClrTransH)
                    .HasColumnName("PenaltyDueUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyMonthlyRateTransH)
                    .HasColumnName("PenaltyMonthlyRate_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyPayClrTransH)
                    .HasColumnName("PenaltyPayClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyPayUnClrTransH)
                    .HasColumnName("PenaltyPayUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyRemainingProcessedTransH)
                    .HasColumnName("PenaltyRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyUsualDueTransH)
                    .HasColumnName("PenaltyUsualDue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PostedByTransH)
                    .HasColumnName("PostedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PreparedByTransH)
                    .HasColumnName("PreparedBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalDueClrTransH)
                    .HasColumnName("PrincipalDueClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDueEveryTransH)
                    .HasColumnName("PrincipalDueEvery_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalDueUnClrTransH)
                    .HasColumnName("PrincipalDueUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalPayClrTransH)
                    .HasColumnName("PrincipalPayClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalPayUnClrTransH)
                    .HasColumnName("PrincipalPayUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalRemainingProcessedTransH)
                    .HasColumnName("PrincipalRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalTermsDisplayedTransH)
                    .HasColumnName("PrincipalTermsDisplayed_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalTermsInUseTransH)
                    .HasColumnName("PrincipalTermsInUse_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.PrincipalTermsInstallmentsTransH).HasColumnName("PrincipalTermsInstallments_TransH");

                entity.Property(e => e.PrincipalUsualDueTransH)
                    .HasColumnName("PrincipalUsualDue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.PrintedByTransH)
                    .HasColumnName("PrintedBy_TransH")
                    .HasMaxLength(255);

                entity.Property(e => e.SalesPurchTypeTransH)
                    .HasColumnName("SalesPurchType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SequencePkTransH)
                    .HasColumnName("SequencePK_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentAccountDocumentByTransH)
                    .HasColumnName("SourceDocumentAccountDocumentBy_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentAccountDocumentNumTranH)
                    .HasColumnName("SourceDocumentAccountDocumentNum_TranH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentDateAccountDocumentTranH)
                    .HasColumnName("SourceDocumentDateAccountDocument_TranH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SourceDocumentDateIssueTransH)
                    .HasColumnName("SourceDocumentDateIssue_TransH")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SourceDocumentModuleJournalTransH)
                    .HasColumnName("SourceDocumentModuleJournal_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentModuleLedgerTransH)
                    .HasColumnName("SourceDocumentModuleLedger_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentModuleSubTypeTransH)
                    .HasColumnName("SourceDocumentModuleSubType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentModuleTransH)
                    .HasColumnName("SourceDocumentModule_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentModuleTransTransH)
                    .HasColumnName("SourceDocumentModuleTrans_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentModuleTypeTransH)
                    .HasColumnName("SourceDocumentModuleType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentUserPkTransH)
                    .HasColumnName("SourceDocumentUserPK_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SourceDocumentUserPkgovtTransH)
                    .HasColumnName("SourceDocumentUserPKGovt_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusAccountAsOfIssueDateTransH)
                    .HasColumnName("StatusAccountAsOfIssueDate_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusTransactionTransH)
                    .HasColumnName("StatusTransaction_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkAccountDocumentAccountTransH)
                    .HasColumnName("SysFK_AccountDocumentAccount_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkAccountDocumentTransHTransH)
                    .HasColumnName("SysFK_AccountDocumentTransH_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkAccountTransH)
                    .HasColumnName("SysFK_Account_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkBatchTransHTransH)
                    .HasColumnName("SysFK_BatchTransH_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkEdiTransH)
                    .HasColumnName("SysFK_EDI_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkInChargeTransH)
                    .HasColumnName("SysFK_InCharge_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkJournalTransH)
                    .HasColumnName("SysFK_Journal_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLedgerTransHTransH)
                    .HasColumnName("SysFK_LedgerTransH_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkModuleTransH)
                    .HasColumnName("SysFK_Module_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkSourceDocumentTransH)
                    .HasColumnName("SysFK_SourceDocument_TransH")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTransH).HasColumnName("SysSeq_TransH");

                entity.Property(e => e.TotalAmountAccountDocumentTransH)
                    .HasColumnName("TotalAmountAccountDocument_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueClrTransH)
                    .HasColumnName("TotalDueClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDueUnClrTransH)
                    .HasColumnName("TotalDueUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalEntriesTransH)
                    .HasColumnName("TotalEntries_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPastTransactionPaymentsTransH)
                    .HasColumnName("TotalPastTransactionPayments_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalPayClrTransH)
                    .HasColumnName("TotalPayClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPayUnClrTransH)
                    .HasColumnName("TotalPayUnClr_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalRemainingProcessedTransH)
                    .HasColumnName("TotalRemainingProcessed_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TotalUsualDueTransH)
                    .HasColumnName("TotalUsualDue_TransH")
                    .HasColumnType("money");

                entity.Property(e => e.TypeAccountAsOfIssueDateTransH)
                    .HasColumnName("TypeAccountAsOfIssueDate_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeMasterfileAsOfIssueDateTransH)
                    .HasColumnName("TypeMasterfileAsOfIssueDate_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeTransactionTransH)
                    .HasColumnName("TypeTransaction_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTransH)
                    .HasColumnName("UserPK_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkgovtTransH)
                    .HasColumnName("UserPKGovt_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkjournalTransH)
                    .HasColumnName("UserPKJournal_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkprefixTransH)
                    .HasColumnName("UserPKPrefix_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkseqTransH)
                    .HasColumnName("UserPKSeq_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPksuffixTransH)
                    .HasColumnName("UserPKSuffix_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktypeTransH)
                    .HasColumnName("UserPKType_TransH")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTransH).HasColumnName("UserSeq_TransH");

                entity.Property(e => e.ValidatePkTrasH)
                    .HasColumnName("ValidatePK_TrasH")
                    .HasMaxLength(50);

                entity.Property(e => e.VoidedByTransH)
                    .HasColumnName("VoidedBy_TransH")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionHeaderTelephoneVoucher>(entity =>
            {
                entity.HasKey(e => e.SysPkTelVchr);

                entity.ToTable("Transaction_Header_TelephoneVoucher");

                entity.Property(e => e.SysPkTelVchr)
                    .HasColumnName("SysPK_TelVCHR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccountDocumentAddressTelVchr)
                    .HasColumnName("AccountDocumentAddress_TelVCHR")
                    .HasMaxLength(50);

                entity.Property(e => e.AccountDocumentNameTelVchr)
                    .HasColumnName("AccountDocumentName_TelVCHR")
                    .HasMaxLength(50);

                entity.Property(e => e.GovtTaxRateTelVchr)
                    .HasColumnName("GovtTaxRate_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.GovtTaxTelVchr)
                    .HasColumnName("GovtTax_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.HandlingFeeRateTelVchr)
                    .HasColumnName("HandlingFeeRate_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.HandlingFeeTelVchr)
                    .HasColumnName("HandlingFee_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByTelVchr)
                    .HasColumnName("LastUpdatedBy_TelVCHR")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTelVchr)
                    .HasColumnName("LastUpdatedConcurrencyID_TelVCHR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTelVchr)
                    .HasColumnName("LastUpdatedDate_TelVCHR")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTelVchr)
                    .HasColumnName("Module_TelVCHR")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsTelVchr)
                    .HasColumnName("Particulars_TelVCHR")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameTelVchr)
                    .HasColumnName("PictureFileName_TelVCHR")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusTelVchr)
                    .HasColumnName("Status_TelVCHR")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaarTelVchr)
                    .HasColumnName("SysFK_COAAR_TelVCHR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransH2TelVchr)
                    .HasColumnName("SysFK_TransH2_TelVCHR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHTelVchr)
                    .HasColumnName("SysFK_TransH_TelVCHR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTelVchr).HasColumnName("SysSeq_TelVCHR");

                entity.Property(e => e.TimeTelVchr)
                    .HasColumnName("Time_TelVCHR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.TotalBalanceTelVchr)
                    .HasColumnName("TotalBalance_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.TotalChargesTelVchr)
                    .HasColumnName("TotalCharges_TelVchr")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDetailsChargesTelVchr)
                    .HasColumnName("TotalDetailsCharges_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDetailsQtyTelVchr)
                    .HasColumnName("TotalDetailsQty_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.TotalPaymentsTelVchr)
                    .HasColumnName("TotalPayments_TelVCHR")
                    .HasColumnType("money");

                entity.Property(e => e.TrunkLineNumTelVchr)
                    .HasColumnName("TrunkLineNum_TelVCHR")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeTelVchr)
                    .HasColumnName("Type_TelVCHR")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTelVchr)
                    .HasColumnName("UserPK_TelVCHR")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTelVchr).HasColumnName("UserSeq_TelVCHR");

                entity.Property(e => e.WaiterByTelVchr)
                    .HasColumnName("WaiterBy_TelVCHR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionHeaderWithdrawalSlip>(entity =>
            {
                entity.HasKey(e => e.SysPkWslip);

                entity.ToTable("Transaction_Header_WithdrawalSlip");

                entity.Property(e => e.SysPkWslip)
                    .HasColumnName("SysPK_WSlip")
                    .HasColumnType("money");

                entity.Property(e => e.AccountNameWslip)
                    .HasColumnName("AccountName_WSlip")
                    .HasMaxLength(100);

                entity.Property(e => e.BookNumWslip)
                    .HasColumnName("BookNum_WSlip")
                    .HasMaxLength(50);

                entity.Property(e => e.DateGeneratedWslip)
                    .HasColumnName("DateGenerated_WSlip")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateIssueWslip)
                    .HasColumnName("DateIssue_WSlip")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateReleaseWslip)
                    .HasColumnName("DateRelease_WSlip")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsServedWslip).HasColumnName("IsServed_WSlip");

                entity.Property(e => e.LastUpdatedByWslip)
                    .HasColumnName("LastUpdatedBy_WSlip")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsWslip)
                    .HasColumnName("Particulars_WSlip")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkGenerateSeqWslip)
                    .HasColumnName("SysFK_GenerateSeq_WSlip")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkWslip)
                    .HasColumnName("UserPK_WSlip")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionLedgerAdjustments>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrAdjustment);

                entity.ToTable("Transaction_Ledger_Adjustments");

                entity.Property(e => e.SysPkLdgrAdjustment)
                    .HasColumnName("SysPK_LdgrAdjustment")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyInLdgrAdjustment)
                    .HasColumnName("DisplayQtyIn_LdgrAdjustment")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalInLdgrAdjustment)
                    .HasColumnName("DisplaySubTotalIn_LdgrAdjustment")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitOfMeasureLdgrAdjustment)
                    .HasColumnName("DisplayUnitOfMeasure_LdgrAdjustment")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayUnitPriceLdgrAdjustment)
                    .HasColumnName("DisplayUnitPrice_LdgrAdjustment")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByLdgrAdjustment)
                    .HasColumnName("LastUpdatedBy_LdgrAdjustment")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrAdjustment).HasColumnName("LastUpdatedConcurrencyID_LdgrAdjustment");

                entity.Property(e => e.LastUpdatedDateLdgrAdjustment)
                    .HasColumnName("LastUpdatedDate_LdgrAdjustment")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleLdgrAdjustment)
                    .HasColumnName("Module_LdgrAdjustment")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsLdgrAdjustment)
                    .HasColumnName("Particulars_LdgrAdjustment")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkInvtyLdgrAdjustment)
                    .HasColumnName("SysFK_Invty_LdgrAdjustment")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrInvtySlLdgrAdjustment)
                    .HasColumnName("SysFK_LdgrInvtySL_LdgrAdjustment")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHLdgrAdjustment)
                    .HasColumnName("SysFK_TransH_LdgrAdjustment")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqLdgrAdjustment).HasColumnName("SysSeq_LdgrAdjustment");

                entity.Property(e => e.UserFkInvtyLdgrAdjustment)
                    .HasColumnName("UserFK_Invty_LdgrAdjustment")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrAdjustment).HasColumnName("UserSeq_LdgrAdjustment");
            });

            modelBuilder.Entity<TransactionLedgerAmounts>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrAmt);

                entity.ToTable("Transaction_Ledger_Amounts");

                entity.Property(e => e.SysPkLdgrAmt)
                    .HasColumnName("SysPK_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountArrearsLdgrAmt)
                    .HasColumnName("AmountArrears_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.AmountDueClrLdgrAmt)
                    .HasColumnName("AmountDueClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.AmountDueUnClrLdgrAmt)
                    .HasColumnName("AmountDueUnClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPaidClrLdgrAmt)
                    .HasColumnName("AmountPaidClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPaidUnClrLdgrAmt)
                    .HasColumnName("AmountPaidUnClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.AmountRunBalClrLdgrAmt)
                    .HasColumnName("AmountRunBalClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.AmountRunBalUnClrLdgrAmt)
                    .HasColumnName("AmountRunBalUnClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.CheckBankBranchLdgrAmt)
                    .HasColumnName("CheckBankBranch_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckDateLdgrAmt)
                    .HasColumnName("CheckDate_LdgrAmt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CheckNumLdgrAmt)
                    .HasColumnName("CheckNum_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.CheckStatusLdgrAmt)
                    .HasColumnName("CheckStatus_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditCardBankPaymentsLdgrAmt)
                    .HasColumnName("CreditCardBankPayments_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardCustomerPaymentsLdgrAmt)
                    .HasColumnName("CreditCardCustomerPayments_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.CreditCardVerificationNumLdgrAmt)
                    .HasColumnName("CreditCardVerificationNum_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.DateDueLdgrAmt)
                    .HasColumnName("DateDue_LdgrAmt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateFullyPaidLdgrAmt)
                    .HasColumnName("DateFullyPaid_LdgrAmt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DatePaidLdgrAmt)
                    .HasColumnName("DatePaid_LdgrAmt")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DepositAdjustLdgrAmt)
                    .HasColumnName("DepositAdjust_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositCashLdgrAmt)
                    .HasColumnName("DepositCash_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositCheckClrLdgrAmt)
                    .HasColumnName("DepositCheckClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositCheckUnClrLdgrAmt)
                    .HasColumnName("DepositCheckUnClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositInterestLdgrAmt)
                    .HasColumnName("DepositInterest_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositInvestmentsLdgrAmt)
                    .HasColumnName("DepositInvestments_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositSavingsLdgrAmt)
                    .HasColumnName("DepositSavings_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositShareCapitalLdgrAmt)
                    .HasColumnName("DepositShareCapital_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositTimeLdgrAmt)
                    .HasColumnName("DepositTime_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DepositTotalLdgrAmt)
                    .HasColumnName("DepositTotal_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayAmountAdjustLdgrAmt)
                    .HasColumnName("DisplayAmountAdjust_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayAmountClrLdgrAmt)
                    .HasColumnName("DisplayAmountClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayAmountForLdgrAmt)
                    .HasColumnName("DisplayAmountFor_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayAmountLdgrAmt)
                    .HasColumnName("DisplayAmount_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayAmountRateLdgrAmt)
                    .HasColumnName("DisplayAmountRate_LdgrAmt")
                    .HasColumnType("numeric(18, 8)");

                entity.Property(e => e.DisplayAmountUnClrLdgrAmt)
                    .HasColumnName("DisplayAmountUnClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.InterestDueLdgrAmt)
                    .HasColumnName("InterestDue_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.InterestPayLdgrAmt)
                    .HasColumnName("InterestPay_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.IsPrintedLdgrAmt).HasColumnName("IsPrinted_LdgrAmt");

                entity.Property(e => e.LastUpdatedByLdgrAmt)
                    .HasColumnName("LastUpdatedBy_LdgrAmt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrAmt)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrAmt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrAmt)
                    .HasColumnName("LastUpdatedDate_LdgrAmt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MiscDueLdgrAmt)
                    .HasColumnName("MiscDue_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.MiscPayLdgrAmt)
                    .HasColumnName("MiscPay_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleLdgrAmt)
                    .HasColumnName("Module_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleLedgerLdgrAmt)
                    .HasColumnName("ModuleLedger_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTypeLdgrAmt)
                    .HasColumnName("ModuleType_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsLdgrAmt)
                    .HasColumnName("Particulars_LdgrAmt")
                    .HasMaxLength(255);

                entity.Property(e => e.PenaltyDueLdgrAmt)
                    .HasColumnName("PenaltyDue_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.PenaltyPayLdgrAmt)
                    .HasColumnName("PenaltyPay_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalDueLdgrAmt)
                    .HasColumnName("PrincipalDue_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.PrincipalPayLdgrAmt)
                    .HasColumnName("PrincipalPay_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.StatusPaymentLdgrAmt)
                    .HasColumnName("StatusPayment_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaLdgrAmt)
                    .HasColumnName("SysFK_COA_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyLdgrAmt)
                    .HasColumnName("SysFK_Invty_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrAmtParentLdgrAmt)
                    .HasColumnName("SysFK_LdgrAmtParent_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrAmtSourceDocLdgrAmt)
                    .HasColumnName("SysFK_LdgrAmtSourceDoc_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHLdgrAmt)
                    .HasColumnName("SysFK_TransH_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHsourceDocLdgrAmt)
                    .HasColumnName("SysFK_TransHSourceDoc_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmLdgrAmt)
                    .HasColumnName("SysFK_UM_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmagentColctrLdgrAmt)
                    .HasColumnName("SysFK_UMAgentColctr_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmarapLdgrAmt)
                    .HasColumnName("SysFK_UMARAP_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankLdgrAmt)
                    .HasColumnName("SysFK_UMBank_LdgrAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqLdgrAmt).HasColumnName("SysSeq_LdgrAmt");

                entity.Property(e => e.TypePaymentLdgrAmt)
                    .HasColumnName("TypePayment_LdgrAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrAmt).HasColumnName("UserSeq_LdgrAmt");

                entity.Property(e => e.WithdrawalAdjustLdgrAmt)
                    .HasColumnName("WithdrawalAdjust_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalCashLdgrAmt)
                    .HasColumnName("WithdrawalCash_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalChargesLdgrAmt)
                    .HasColumnName("WithdrawalCharges_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalCheckClrLdgrAmt)
                    .HasColumnName("WithdrawalCheckClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalCheckUnClrLdgrAmt)
                    .HasColumnName("WithdrawalCheckUnClr_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalInvestmentsLdgrAmt)
                    .HasColumnName("WithdrawalInvestments_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalSavingsLdgrAmt)
                    .HasColumnName("WithdrawalSavings_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalShareCapitalLdgrAmt)
                    .HasColumnName("WithdrawalShareCapital_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalTimeLdgrAmt)
                    .HasColumnName("WithdrawalTime_LdgrAmt")
                    .HasColumnType("money");

                entity.Property(e => e.WithdrawalTotalLdgrAmt)
                    .HasColumnName("WithdrawalTotal_LdgrAmt")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TransactionLedgerCollectorList>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrColList);

                entity.ToTable("Transaction_Ledger_CollectorList");

                entity.Property(e => e.SysPkLdgrColList)
                    .HasColumnName("SysPK_LdgrColList")
                    .HasColumnType("money");

                entity.Property(e => e.AmountLdgrColList)
                    .HasColumnName("Amount_LdgrColList")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPaidLdgrColList)
                    .HasColumnName("AmountPaid_LdgrColList")
                    .HasColumnType("money");

                entity.Property(e => e.ForCollectionLdgrColList).HasColumnName("ForCollection_LdgrColList");

                entity.Property(e => e.IsIncludePrintLdgrColList).HasColumnName("IsIncludePrint_LdgrColList");

                entity.Property(e => e.IsReturnedLdgrColList).HasColumnName("IsReturned_LdgrColList");

                entity.Property(e => e.LastUpdatedByLdgrColList)
                    .HasColumnName("LastUpdatedBy_LdgrColList")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrColList).HasColumnName("LastUpdatedConcurrencyID_LdgrColList");

                entity.Property(e => e.LastUpdatedDateLdgrColList)
                    .HasColumnName("LastUpdatedDate_LdgrColList")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleLdgrColList)
                    .HasColumnName("Module_LdgrColList")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsLdgrColList)
                    .HasColumnName("Particulars_LdgrColList")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusLdgrColList)
                    .HasColumnName("Status_LdgrColList")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHLdgrColList)
                    .HasColumnName("SysFK_TransH_LdgrColList")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUmLdgrColList)
                    .HasColumnName("SysFK_UM_LdgrColList")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqLdgrColList).HasColumnName("SysSeq_LdgrColList");

                entity.Property(e => e.UserPkLdgrColList)
                    .HasColumnName("UserPK_LdgrColList")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrColList).HasColumnName("UserSeq_LdgrColList");

                entity.Property(e => e.WithSoaLdgrColList).HasColumnName("WithSOA_LdgrColList");
            });

            modelBuilder.Entity<TransactionLedgerCopraContracts>(entity =>
            {
                entity.HasKey(e => e.SysPkCpraCtrct);

                entity.ToTable("Transaction_Ledger_CopraContracts");

                entity.Property(e => e.SysPkCpraCtrct)
                    .HasColumnName("SysPK_CpraCtrct")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AdjustmentQtyCpraCtrct)
                    .HasColumnName("AdjustmentQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.AdjustmentSubTotalCpraCtrct)
                    .HasColumnName("AdjustmentSubTotal_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.AmountCpraCtrct)
                    .HasColumnName("Amount_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.BalanceQtyCpraCtrct)
                    .HasColumnName("BalanceQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.BalanceQtyFwdCpraCtrct)
                    .HasColumnName("BalanceQtyFwd_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.BalanceSubTotalCpraCtrct)
                    .HasColumnName("BalanceSubTotal_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.BalanceSubTotalFwdCpraCtrct)
                    .HasColumnName("BalanceSubTotalFwd_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.CancelContractAmountCpraCtrct)
                    .HasColumnName("CancelContractAmount_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.CancelContractQtyCpraCtrct)
                    .HasColumnName("CancelContractQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.CbdCpraCtrct)
                    .HasColumnName("CBD_CpraCtrct")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CleanOutKilosCpraCtrct)
                    .HasColumnName("CleanOutKilos_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.ContractAmountCpraCtrct)
                    .HasColumnName("ContractAmount_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.ContractQtyCpraCtrct)
                    .HasColumnName("ContractQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DateContractedCpraCtrct)
                    .HasColumnName("DateContracted_CpraCtrct")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeliverContractAmountCpraCtrct)
                    .HasColumnName("DeliverContractAmount_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DeliverContractQtyCpraCtrct)
                    .HasColumnName("DeliverContractQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DepositAmountCpraCtrct)
                    .HasColumnName("DepositAmount_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DepositQtyCpraCtrct)
                    .HasColumnName("DepositQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayContractedAmountCpraCtrct)
                    .HasColumnName("DisplayContractedAmount_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayContractedQtyCpraCtrct)
                    .HasColumnName("DisplayContractedQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyInCpraCtrct)
                    .HasColumnName("DisplayQtyIn_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalCpraCtrct)
                    .HasColumnName("DisplaySubTotal_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitOfMeasureCpraCtrct)
                    .HasColumnName("DisplayUnitOfMeasure_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.ExpiryDateCpraCtrct)
                    .HasColumnName("ExpiryDate_CpraCtrct")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.GainLossCpraCtrct)
                    .HasColumnName("GainLoss_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.GrossWeightCpraCtrct)
                    .HasColumnName("GrossWeight_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByCpraCtrct)
                    .HasColumnName("LastUpdatedBy_CpraCtrct")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdCpraCtrct)
                    .HasColumnName("LastUpdatedConcurrencyID_CpraCtrct")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateCpraCtrct)
                    .HasColumnName("LastUpdatedDate_CpraCtrct")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleCpraCtrct)
                    .HasColumnName("Module_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.MoistureCpraCtrct)
                    .HasColumnName("Moisture_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.NameCpraCtrct)
                    .HasColumnName("Name_CpraCtrct")
                    .HasMaxLength(100);

                entity.Property(e => e.NetKilosCpraCtrct)
                    .HasColumnName("NetKilos_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.NetWeightCpraCtrct)
                    .HasColumnName("NetWeight_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.NewContractAmountCpraCtrct)
                    .HasColumnName("NewContractAmount_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.NewContractQtyCpraCtrct)
                    .HasColumnName("NewContractQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.NumberofSackCpraCtrct)
                    .HasColumnName("NumberofSack_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsCpraCtrct)
                    .HasColumnName("Particulars_CpraCtrct")
                    .HasMaxLength(255);

                entity.Property(e => e.PercentageCpraCtrct)
                    .HasColumnName("Percentage_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.PriceCpraCtrct)
                    .HasColumnName("Price_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.PricePerKiloCpraCtrct)
                    .HasColumnName("PricePerKilo_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.ShipOutOilMillKilosCpraCtrct)
                    .HasColumnName("ShipOutOilMillKilos_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.ShipOutOriginKilosCpraCtrct)
                    .HasColumnName("ShipOutOriginKilos_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.SpotDlvrAmountCpraCtrct)
                    .HasColumnName("SpotDlvrAmount_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.SpotDlvrQtyCpraCtrct)
                    .HasColumnName("SpotDlvrQty_CpraCtrct")
                    .HasColumnType("money");

                entity.Property(e => e.StatusCpraCtrct)
                    .HasColumnName("Status_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCpraCtrctParentCpraCtrct)
                    .HasColumnName("SysFK_CpraCtrctParent_CpraCtrct")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHCpraCtrct)
                    .HasColumnName("SysFK_TransH_CpraCtrct")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkVesselCpraCtrct)
                    .HasColumnName("SysFK_Vessel_CpraCtrct")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkWarehouseCpraCtrct)
                    .HasColumnName("SysFK_Warehouse_CpraCtrct")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqCpraCtrct).HasColumnName("SysSeq_CpraCtrct");

                entity.Property(e => e.TareSackCpraCtrct)
                    .HasColumnName("TareSack_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeCpraCtrct)
                    .HasColumnName("Type_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkVesselCpraCtrct)
                    .HasColumnName("UserFK_Vessel_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkWarehouseCpraCtrct)
                    .HasColumnName("UserFK_Warehouse_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkCpraCtrct)
                    .HasColumnName("UserPK_CpraCtrct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqCpraCtrct).HasColumnName("UserSeq_CpraCtrct");
            });

            modelBuilder.Entity<TransactionLedgerEntries>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrEntries);

                entity.ToTable("Transaction_Ledger_Entries");

                entity.HasIndex(e => e.DateDueLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_8");

                entity.HasIndex(e => e.ModuleLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_6");

                entity.HasIndex(e => e.ModuleTransLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_7");

                entity.HasIndex(e => e.StatusLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_9");

                entity.HasIndex(e => e.SysFkCoaLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries");

                entity.HasIndex(e => e.SysFkInvtyLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_1");

                entity.HasIndex(e => e.SysFkLdgrEntriesSlLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_2");

                entity.HasIndex(e => e.SysFkTransHLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_3");

                entity.HasIndex(e => e.SysFkTransHslLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_4");

                entity.HasIndex(e => e.SysFkUmLdgrEntries)
                    .HasName("IX_Transaction_Ledger_Entries_5");

                entity.Property(e => e.SysPkLdgrEntries)
                    .HasColumnName("SysPK_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AmountDueLdgrEntries)
                    .HasColumnName("AmountDue_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPayClrLdgrEntries)
                    .HasColumnName("AmountPayClr_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPayPdcLdgrEntries)
                    .HasColumnName("AmountPayPDC_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.AreaLdgrEntries)
                    .HasColumnName("Area_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.ArrearsDueLdgrEntries)
                    .HasColumnName("ArrearsDue_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.BalanceClrLdgrEntries)
                    .HasColumnName("BalanceClr_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.BalancePdcLdgrEntries)
                    .HasColumnName("BalancePDC_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.CramountLdgrEntries)
                    .HasColumnName("CRAmount_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.CramountPdcLdgrEntries)
                    .HasColumnName("CRAmountPDC_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.CrbaseUnitQtyLdgrEntries)
                    .HasColumnName("CRBaseUnitQty_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.CrforeignAmountLdgrEntries)
                    .HasColumnName("CRForeignAmount_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.DateDueLdgrEntries)
                    .HasColumnName("DateDue_LdgrEntries")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeptLdgrEntries)
                    .HasColumnName("Dept_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.DramountLdgrEntries)
                    .HasColumnName("DRAmount_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.DramountPdcLdgrEntries)
                    .HasColumnName("DRAmountPDC_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.DrbaseUnitQtyLdgrEntries)
                    .HasColumnName("DRBaseUnitQty_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.DrforeignAmountLdgrEntries)
                    .HasColumnName("DRForeignAmount_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.ForeignConversionRateLdgrEntries)
                    .HasColumnName("ForeignConversionRate_LdgrEntries")
                    .HasColumnType("money");

                entity.Property(e => e.ForeignSignLdgrEntries)
                    .HasColumnName("ForeignSign_LdgrEntries")
                    .HasMaxLength(10);

                entity.Property(e => e.LastUpdatedByLdgrEntries)
                    .HasColumnName("LastUpdatedBy_LdgrEntries")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrEntries)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrEntries")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrEntries)
                    .HasColumnName("LastUpdatedDate_LdgrEntries")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleLdgrEntries)
                    .HasColumnName("Module_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleTransLdgrEntries)
                    .HasColumnName("ModuleTrans_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsLdgrEntries)
                    .HasColumnName("Particulars_LdgrEntries")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusLdgrEntries)
                    .HasColumnName("Status_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaLdgrEntries)
                    .HasColumnName("SysFK_COA_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyLdgrEntries)
                    .HasColumnName("SysFK_Invty_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrEntriesSlLdgrEntries)
                    .HasColumnName("SysFK_LdgrEntriesSL_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHLdgrEntries)
                    .HasColumnName("SysFK_TransH_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHslLdgrEntries)
                    .HasColumnName("SysFK_TransHSL_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmLdgrEntries)
                    .HasColumnName("SysFK_UM_LdgrEntries")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqLdgrEntries).HasColumnName("SysSeq_LdgrEntries");

                entity.Property(e => e.TypeLdgrEntries)
                    .HasColumnName("Type_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkGenericClassLdgrEntries)
                    .HasColumnName("UserFK_GenericClass_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkLdgrEntries)
                    .HasColumnName("UserPK_LdgrEntries")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrEntries).HasColumnName("UserSeq_LdgrEntries");

                entity.Property(e => e.UsualDueLdgrEntries)
                    .HasColumnName("UsualDue_LdgrEntries")
                    .HasColumnType("money");

                entity.HasOne(d => d.SysFkCoaLdgrEntriesNavigation)
                    .WithMany(p => p.TransactionLedgerEntries)
                    .HasForeignKey(d => d.SysFkCoaLdgrEntries)
                    .HasConstraintName("FK_Transaction_Ledger_Entries_COA_Master2");

                entity.HasOne(d => d.SysFkTransHLdgrEntriesNavigation)
                    .WithMany(p => p.TransactionLedgerEntries)
                    .HasForeignKey(d => d.SysFkTransHLdgrEntries)
                    .HasConstraintName("FK_Transaction_Ledger_Entries_Transaction_Header");
            });

            modelBuilder.Entity<TransactionLedgerFixedAssets>(entity =>
            {
                entity.HasKey(e => e.SysPkFixdAset);

                entity.ToTable("Transaction_Ledger_FixedAssets");

                entity.Property(e => e.SysPkFixdAset)
                    .HasColumnName("SysPK_FixdAset")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByFixdAset)
                    .HasColumnName("LastUpdatedBy_FixdAset")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFixdAset)
                    .HasColumnName("LastUpdatedConcurrencyID_FixdAset")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFixdAset)
                    .HasColumnName("LastUpdatedDate_FixdAset")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleFixdAset)
                    .HasColumnName("Module_FixdAset")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsFixdAset)
                    .HasColumnName("Particulars_FixdAset")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameTableCode)
                    .HasColumnName("PictureFileName_TableCode")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusFixdAset)
                    .HasColumnName("Status_FixdAset")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHFixdAset)
                    .HasColumnName("SysFK_TransH_FixdAset")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqFixdAset).HasColumnName("SysSeq_FixdAset");

                entity.Property(e => e.TypeFixdAset)
                    .HasColumnName("Type_FixdAset")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqFixdAset).HasColumnName("UserSeq_FixdAset");
            });

            modelBuilder.Entity<TransactionLedgerInvty>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrInvty);

                entity.ToTable("Transaction_Ledger_Invty");

                entity.HasIndex(e => e.ModuleLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty_7");

                entity.HasIndex(e => e.SysFkCustomerLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty_2");

                entity.HasIndex(e => e.SysFkInvtyBatchLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty_5");

                entity.HasIndex(e => e.SysFkInvtyLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty_3");

                entity.HasIndex(e => e.SysFkLdgrInvtySysPkLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty_4");

                entity.HasIndex(e => e.SysFkSupplierLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty_6");

                entity.HasIndex(e => e.SysFkTransHLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty");

                entity.HasIndex(e => e.SysFkTransHslLdgrInvty)
                    .HasName("IX_Transaction_Ledger_Invty_1");

                entity.Property(e => e.SysPkLdgrInvty)
                    .HasColumnName("SysPK_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BaseUnitOfMeasureLdgrInvty)
                    .HasColumnName("BaseUnitOfMeasure_LdgrInvty")
                    .HasMaxLength(8);

                entity.Property(e => e.BaseUnitQtyAdjustLdgrInvty)
                    .HasColumnName("BaseUnitQtyAdjust_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BaseUnitQtyInLdgrInvty)
                    .HasColumnName("BaseUnitQtyIn_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BaseUnitQtyMultiplierLdgrInvty)
                    .HasColumnName("BaseUnitQtyMultiplier_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BaseUnitQtyOutLdgrInvty)
                    .HasColumnName("BaseUnitQtyOut_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BaseUnitQtyReceivedBalanceLdgrInvty)
                    .HasColumnName("BaseUnitQtyReceivedBalance_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CommissionAmountLdgrInvty)
                    .HasColumnName("CommissionAmount_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CommissionRateLdgrInvty)
                    .HasColumnName("CommissionRate_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.ConsignDisplayedBeginningConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDisplayedBeginningConsignedQty_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsignDisplayedConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDisplayedConsignedQty_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsignDisplayedDeclaredSoldLdgrInvty)
                    .HasColumnName("ConsignDisplayedDeclaredSold_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsignDisplayedEndConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDisplayedEndConsignedQty_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsignDisplayedSoldLdgrInvty)
                    .HasColumnName("ConsignDisplayedSold_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ConsignSalesQtyAdjustLdgrInvty)
                    .HasColumnName("ConsignSalesQtyAdjust_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DiscountedUnitPurchaseLdgrInvty)
                    .HasColumnName("DiscountedUnitPurchase_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DiscountedUnitSellingLdgrInvty)
                    .HasColumnName("DiscountedUnitSelling_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayCostCodeLdgrInvty)
                    .HasColumnName("DisplayCostCode_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayDescriptionLdgrInvty)
                    .HasColumnName("DisplayDescription_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayDiscountingLdgrInvty)
                    .HasColumnName("DisplayDiscounting_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayForeignConversionRateLdgInvty)
                    .HasColumnName("DisplayForeignConversionRate_LdgInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayForeignSignLdgrInvty)
                    .HasColumnName("DisplayForeignSign_LdgrInvty")
                    .HasMaxLength(10);

                entity.Property(e => e.DisplayForeignUnitPurchaseLdgrInvty)
                    .HasColumnName("DisplayForeignUnitPurchase_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayForeignUnitSellingLdgrInvty)
                    .HasColumnName("DisplayForeignUnitSelling_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayQtyInLdgrInvty)
                    .HasColumnName("DisplayQtyIn_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayQtyOutLdgrInvty)
                    .HasColumnName("DisplayQtyOut_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayQtyServedLdgrInvty)
                    .HasColumnName("DisplayQtyServed_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplaySubTotalAdjustLdgrInvty)
                    .HasColumnName("DisplaySubTotalAdjust_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplaySubTotalInLdgrInvty)
                    .HasColumnName("DisplaySubTotalIn_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplaySubTotalOutLdgrInvty)
                    .HasColumnName("DisplaySubTotalOut_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayUnitOfMeasureLdgrInvty)
                    .HasColumnName("DisplayUnitOfMeasure_LdgrInvty")
                    .HasMaxLength(8);

                entity.Property(e => e.DisplayUnitPurchaseLdgrInvty)
                    .HasColumnName("DisplayUnitPurchase_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayUnitSellingLdgrInvty)
                    .HasColumnName("DisplayUnitSelling_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ForeignDiscountedUnitPurchaseLdgrInvty)
                    .HasColumnName("ForeignDiscountedUnitPurchase_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ForeignDiscountedUnitSellingLdgrInvty)
                    .HasColumnName("ForeignDiscountedUnitSelling_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ForeignSubTotalInLdgrInvty)
                    .HasColumnName("ForeignSubTotalIn_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ForeignSubTotalOutLdgrInvty)
                    .HasColumnName("ForeignSubTotalOut_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FormulaUsedInSubTotalLdgrInvty)
                    .HasColumnName("FormulaUsedInSubTotal_LdgrInvty")
                    .HasMaxLength(10);

                entity.Property(e => e.IsPostedToConsignRrLdgrInvty)
                    .HasColumnName("IsPostedToConsignRR_LdgrInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPostedToConsignSalesLdgrInvty)
                    .HasColumnName("IsPostedToConsignSales_LdgrInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsPrintingDisabledLdgrInvty)
                    .HasColumnName("IsPrintingDisabled_LdgrInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByLdgrInvty)
                    .HasColumnName("LastUpdatedBy_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrInvty)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrInvty)
                    .HasColumnName("LastUpdatedDate_LdgrInvty")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManualComputedSubTotalLdgrInvty)
                    .HasColumnName("ManualComputedSubTotal_LdgrInvty")
                    .HasMaxLength(10);

                entity.Property(e => e.ModuleLdgrInvty)
                    .HasColumnName("Module_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsLdgrInvty)
                    .HasColumnName("Particulars_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchConsignQtyCreditLdgrInvty)
                    .HasColumnName("PurchConsignQtyCredit_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PurchConsignQtyDebitLdgrInvty)
                    .HasColumnName("PurchConsignQtyDebit_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PurchQtyCreditLdgrInvty)
                    .HasColumnName("PurchQtyCredit_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.PurchQtyDebitLdgrInvty)
                    .HasColumnName("PurchQtyDebit_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SalesConsignQtyCreditLdgrInvty)
                    .HasColumnName("SalesConsignQtyCredit_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SalesConsignQtyDebitLdgrInvty)
                    .HasColumnName("SalesConsignQtyDebit_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StoreQtyAdjustLdgrInvty)
                    .HasColumnName("StoreQtyAdjust_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StoreQtyInLdgrInvty)
                    .HasColumnName("StoreQtyIn_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.StoreQtyOutLdgrInvty)
                    .HasColumnName("StoreQtyOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCustomerLdgrInvty)
                    .HasColumnName("SysFK_Customer_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyBatchLdgrInvty)
                    .HasColumnName("SysFK_InvtyBatch_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyLdgrInvty)
                    .HasColumnName("SysFK_Invty_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyPriceLdgrInvty)
                    .HasColumnName("SysFK_InvtyPrice_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrInvtySysPkLdgrInvty)
                    .HasColumnName("SysFK_LdgrInvtySysPK_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSupplierLdgrInvty)
                    .HasColumnName("SysFK_Supplier_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHLdgrInvty)
                    .HasColumnName("SysFK_TransH_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHslLdgrInvty)
                    .HasColumnName("SysFK_TransHSL_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqLdgrInvty)
                    .HasColumnName("SysSeq_LdgrInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TransactionStatusLdgrInvty)
                    .HasColumnName("TransactionStatus_LdgrInvty")
                    .HasMaxLength(40);

                entity.Property(e => e.TransactionTypeLdgrInvty)
                    .HasColumnName("TransactionType_LdgrInvty")
                    .HasMaxLength(20);

                entity.Property(e => e.UnitNetCostLdgrInvty)
                    .HasColumnName("UnitNetCost_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserFkAreaLdgrInvty)
                    .HasColumnName("UserFK_Area_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkBranchLdgrInvty)
                    .HasColumnName("UserFK_Branch_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkInvtyBatchLdgrInvty)
                    .HasColumnName("UserFK_InvtyBatch_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkInvtyLdgrInvty)
                    .HasColumnName("UserFK_Invty_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkInvtyPriceLdgrInvty)
                    .HasColumnName("UserFK_InvtyPrice_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkWrseLdgrInvty)
                    .HasColumnName("UserFK_Wrse_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrInvty)
                    .HasColumnName("UserSeq_LdgrInvty")
                    .HasDefaultValueSql("(0)");

                entity.HasOne(d => d.SysFkInvtyLdgrInvtyNavigation)
                    .WithMany(p => p.TransactionLedgerInvty)
                    .HasForeignKey(d => d.SysFkInvtyLdgrInvty)
                    .HasConstraintName("FK_Transaction_Ledger_Invty_Inventory_Master2");

                entity.HasOne(d => d.SysFkTransHLdgrInvtyNavigation)
                    .WithMany(p => p.TransactionLedgerInvty)
                    .HasForeignKey(d => d.SysFkTransHLdgrInvty)
                    .HasConstraintName("FK_Transaction_Ledger_Invty_Transaction_Header");
            });

            modelBuilder.Entity<TransactionLedgerInvtyJunction>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrInvtyJ);

                entity.ToTable("Transaction_Ledger_Invty_Junction");

                entity.Property(e => e.SysPkLdgrInvtyJ)
                    .HasColumnName("SysPK_LdgrInvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByLdgrInvtyJ)
                    .HasColumnName("LastUpdatedBy_LdgrInvtyJ")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrInvtyJ)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrInvtyJ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrInvtyJ)
                    .HasColumnName("LastUpdatedDate_LdgrInvtyJ")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SysFkPostedFromLdgrInvtyJ)
                    .HasColumnName("SysFK_PostedFrom_LdgrInvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPostedToLdgrInvtyJ)
                    .HasColumnName("SysFK_PostedTo_LdgrInvtyJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TransactionLedgerInvtyLog>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrInvty);

                entity.ToTable("Transaction_Ledger_InvtyLog");

                entity.Property(e => e.SysPkLdgrInvty)
                    .HasColumnName("SysPK_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AdditionalQtyLdgrInvty)
                    .HasColumnName("AdditionalQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ArqtyLdgrInvty)
                    .HasColumnName("ARQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ArsubTotalLdgrInvty)
                    .HasColumnName("ARSubTotal_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BarcodeLdgrInvty)
                    .HasColumnName("Barcode_LdgrInvty")
                    .HasMaxLength(25);

                entity.Property(e => e.BaseUnitAccumulatedQtyBalanceLdgrInvty)
                    .HasColumnName("BaseUnitAccumulatedQtyBalance_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitAccumulatedQtyInLdgrInvty)
                    .HasColumnName("BaseUnitAccumulatedQtyIn_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitAccumulatedQtyOutLdgrInvty)
                    .HasColumnName("BaseUnitAccumulatedQtyOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitOfMeasureLdgrInvty)
                    .HasColumnName("BaseUnitOfMeasure_LdgrInvty")
                    .HasMaxLength(8);

                entity.Property(e => e.BaseUnitQtyAdjustLdgrInvty)
                    .HasColumnName("BaseUnitQtyAdjust_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyInLdgrInvty)
                    .HasColumnName("BaseUnitQtyIn_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyLogLdgrInvty)
                    .HasColumnName("BaseUnitQtyLog_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyMultiplierLdgrInvty)
                    .HasColumnName("BaseUnitQtyMultiplier_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyOutLdgrInvty)
                    .HasColumnName("BaseUnitQtyOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyRunBalPerInvtyLdgrInvty)
                    .HasColumnName("BaseUnitQtyRunBalPerInvty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyRunBalPerWarehouseLdgrInvty)
                    .HasColumnName("BaseUnitQtyRunBalPerWarehouse_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashQtyLdgrInvty)
                    .HasColumnName("CashQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CashSubTotalLdgrInvty)
                    .HasColumnName("CashSubTotal_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CheckedByLdgrInvty)
                    .HasColumnName("CheckedBy_LdgrInvty")
                    .HasMaxLength(100);

                entity.Property(e => e.ClosingQtyLdgrInvty)
                    .HasColumnName("ClosingQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CommissionAmountLdgrInvty)
                    .HasColumnName("CommissionAmount_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.CommissionRateLdgrInvty)
                    .HasColumnName("CommissionRate_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.ComputedQtyOutLdgrInvty)
                    .HasColumnName("ComputedQtyOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ComputedSubTotalOutLdgrInvty)
                    .HasColumnName("ComputedSubTotalOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignActualBeginningConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignActualBeginningConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignActualConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignActualConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDiscrepancyBeginningConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDiscrepancyBeginningConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDiscrepancyConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDiscrepancyConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedActualSoldLdgrInvty)
                    .HasColumnName("ConsignDisplayedActualSold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedAdditionalConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDisplayedAdditionalConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedBeginningConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDisplayedBeginningConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDisplayedConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedDeclaredSoldLdgrInvty)
                    .HasColumnName("ConsignDisplayedDeclaredSold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedEndConsignedQtyLdgrInvty)
                    .HasColumnName("ConsignDisplayedEndConsignedQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedOutstandingLdgrInvty)
                    .HasColumnName("ConsignDisplayedOutstanding_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedReturnedLdgrInvty)
                    .HasColumnName("ConsignDisplayedReturned_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignDisplayedSoldLdgrInvty)
                    .HasColumnName("ConsignDisplayedSold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignFromSupplierLdgrInvty)
                    .HasColumnName("ConsignFromSupplier_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignFromSupplierReturnedLdgrInvty)
                    .HasColumnName("ConsignFromSupplierReturned_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignFromSupplierSoldLdgrInvty)
                    .HasColumnName("ConsignFromSupplierSold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignPhysicalCountQtyLdgrInvty)
                    .HasColumnName("ConsignPhysicalCountQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrqtyAdjustLdgrInvty)
                    .HasColumnName("ConsignRRQtyAdjust_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrqtyInLdgrInvty)
                    .HasColumnName("ConsignRRQtyIn_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrqtyOutLdgrInvty)
                    .HasColumnName("ConsignRRQtyOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrqtySoldLdgrInvty)
                    .HasColumnName("ConsignRRQtySold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrsubTotalAdjustLdgrInvty)
                    .HasColumnName("ConsignRRSubTotalAdjust_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrsubTotalInLdgrInvty)
                    .HasColumnName("ConsignRRSubTotalIn_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrsubTotalOutLdgrInvty)
                    .HasColumnName("ConsignRRSubTotalOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignRrsubTotalSoldLdgrInvty)
                    .HasColumnName("ConsignRRSubTotalSold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesQtyAdjustLdgrInvty)
                    .HasColumnName("ConsignSalesQtyAdjust_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesQtyInLdgrInvty)
                    .HasColumnName("ConsignSalesQtyIn_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesQtyOutLdgrInvty)
                    .HasColumnName("ConsignSalesQtyOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesQtySoldLdgrInvty)
                    .HasColumnName("ConsignSalesQtySold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesSubTotalAdjustLdgrInvty)
                    .HasColumnName("ConsignSalesSubTotalAdjust_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesSubTotalInLdgrInvty)
                    .HasColumnName("ConsignSalesSubTotalIn_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesSubTotalOutLdgrInvty)
                    .HasColumnName("ConsignSalesSubTotalOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignSalesSubTotalSoldLdgrInvty)
                    .HasColumnName("ConsignSalesSubTotalSold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignToCustomerLdgrInvty)
                    .HasColumnName("ConsignToCustomer_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignToCustomerReturnedLdgrInvty)
                    .HasColumnName("ConsignToCustomerReturned_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ConsignToCustomerSoldLdgrInvty)
                    .HasColumnName("ConsignToCustomerSold_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DateTimeFristReleasedLdgrInvty)
                    .HasColumnName("DateTimeFristReleased_LdgrInvty")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeLastReceivedLdgrInvty)
                    .HasColumnName("DateTimeLastReceived_LdgrInvty")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DeptUserFkLdgrInvty)
                    .HasColumnName("DeptUserFK_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountedUnitPurchaseLdgrInvty)
                    .HasColumnName("DiscountedUnitPurchase_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DiscountedUnitSellingLdgrInvty)
                    .HasColumnName("DiscountedUnitSelling_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayDescriptionLdgrInvty)
                    .HasColumnName("DisplayDescription_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayDiscountingLdgrInvty)
                    .HasColumnName("DisplayDiscounting_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayForeignConversionRateLdgInvty)
                    .HasColumnName("DisplayForeignConversionRate_LdgInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayForeignSignLdgrInvty)
                    .HasColumnName("DisplayForeignSign_LdgrInvty")
                    .HasMaxLength(2);

                entity.Property(e => e.DisplayForeignUnitPurchaseLdgrInvty)
                    .HasColumnName("DisplayForeignUnitPurchase_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayForeignUnitSellingLdgrInvty)
                    .HasColumnName("DisplayForeignUnitSelling_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyAdjustLdgrInvty)
                    .HasColumnName("DisplayQtyAdjust_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayQtyInLdgrInvty)
                    .HasColumnName("DisplayQtyIn_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayQtyOutLdgrInvty)
                    .HasColumnName("DisplayQtyOut_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayQtyServedLdgrInvty)
                    .HasColumnName("DisplayQtyServed_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalAdjustLdgrInvty)
                    .HasColumnName("DisplaySubTotalAdjust_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalInLdgrInvty)
                    .HasColumnName("DisplaySubTotalIn_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplaySubTotalOutLdgrInvty)
                    .HasColumnName("DisplaySubTotalOut_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayUnitOfMeasureLdgrInvty)
                    .HasColumnName("DisplayUnitOfMeasure_LdgrInvty")
                    .HasMaxLength(8);

                entity.Property(e => e.DisplayUnitPurchaseLdgrInvty)
                    .HasColumnName("DisplayUnitPurchase_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitSellingLdgrInvty)
                    .HasColumnName("DisplayUnitSelling_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesQtyLdgrInvty)
                    .HasColumnName("ExpensesQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ExpensesSubTotalLdgrInvty)
                    .HasColumnName("ExpensesSubTotal_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ForeignDiscountedUnitSellingLdgrInvty)
                    .HasColumnName("ForeignDiscountedUnitSelling_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ForeignSubTotalOutLdgrInvty)
                    .HasColumnName("ForeignSubTotalOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.FormulaUsedInSubTotalLdgrInvty)
                    .HasColumnName("FormulaUsedInSubTotal_LdgrInvty")
                    .HasMaxLength(10);

                entity.Property(e => e.InChargeByLdgrInvty)
                    .HasColumnName("InChargeBy_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.InventoryFlagLdgrInvty)
                    .HasColumnName("InventoryFlag_LdgrInvty")
                    .HasMaxLength(12);

                entity.Property(e => e.InventoryModuleLdgrInvty)
                    .HasColumnName("InventoryModule_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.IsConsignedOnPurchaseLdgrInvty).HasColumnName("IsConsignedOnPurchase_LdgrInvty");

                entity.Property(e => e.IsPendingLdgrInvty).HasColumnName("IsPending_LdgrInvty");

                entity.Property(e => e.IsPostedToConsignRrLdgrInvty).HasColumnName("IsPostedToConsignRR_LdgrInvty");

                entity.Property(e => e.IsPostedToConsignSalesLdgrInvty).HasColumnName("IsPostedToConsignSales_LdgrInvty");

                entity.Property(e => e.LastUpdatedByLdgrInvty)
                    .HasColumnName("LastUpdatedBy_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrInvty)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrInvty")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrInvty)
                    .HasColumnName("LastUpdatedDate_LdgrInvty")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManualComputedSubTotalLdgrInvty)
                    .HasColumnName("ManualComputedSubTotal_LdgrInvty")
                    .HasMaxLength(10);

                entity.Property(e => e.ModuleLdgrInvty)
                    .HasColumnName("Module_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.OpeningQtyLdgrInvty)
                    .HasColumnName("OpeningQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.OrderedBaseQtyLdgrInvty)
                    .HasColumnName("OrderedBaseQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.OrderedDisplayQtyLdgrInvty)
                    .HasColumnName("OrderedDisplayQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.ParticularsLdgrInvty)
                    .HasColumnName("Particulars_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchConsignQtyCreditLdgrInvty)
                    .HasColumnName("PurchConsignQtyCredit_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.PurchConsignQtyDebitLdgrInvty)
                    .HasColumnName("PurchConsignQtyDebit_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.RequestedBaseQtyLdgrInvty)
                    .HasColumnName("RequestedBaseQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.RequestedDisplayQtyLdgrInvty)
                    .HasColumnName("RequestedDisplayQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesConsignQtyCreditLdgrInvty)
                    .HasColumnName("SalesConsignQtyCredit_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SalesConsignQtyDebitLdgrInvty)
                    .HasColumnName("SalesConsignQtyDebit_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SectionUserFkLdgrInvty)
                    .HasColumnName("SectionUserFK_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.SerialsLdgrInvty)
                    .HasColumnName("Serials_LdgrInvty")
                    .HasMaxLength(255);

                entity.Property(e => e.StockOutQtyLdgrInvty)
                    .HasColumnName("StockOutQty_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.StockOutSubTotalLdgrInvty)
                    .HasColumnName("StockOutSubTotal_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.StoreQtyAdjustLdgrInvty)
                    .HasColumnName("StoreQtyAdjust_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.StoreQtyInLdgrInvty)
                    .HasColumnName("StoreQtyIn_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.StoreQtyOutLdgrInvty)
                    .HasColumnName("StoreQtyOut_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCustomerLdgrInvty)
                    .HasColumnName("SysFK_Customer_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDeptLdgrInvty)
                    .HasColumnName("SysFK_Dept_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyBatchLdgrInvty)
                    .HasColumnName("SysFK_InvtyBatch_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyLdgrInvty)
                    .HasColumnName("SysFK_Invty_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyPriceLdgrInvty)
                    .HasColumnName("SysFK_InvtyPrice_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyUnitMsrLdgrInvty)
                    .HasColumnName("SysFK_InvtyUnitMsr_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrInvtySysPkLdgrInvty)
                    .HasColumnName("SysFK_LdgrInvtySysPK_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkLedgerLdgrInvty)
                    .HasColumnName("SysFK_Ledger_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSectionLdgrInvty)
                    .HasColumnName("SysFK_Section_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSourceDocumentLdgrInvty)
                    .HasColumnName("SysFK_SourceDocument_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSupplierLdgrInvty)
                    .HasColumnName("SysFK_Supplier_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHLdgrInvty)
                    .HasColumnName("SysFK_TransH_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkWarehouseLdgrInvty)
                    .HasColumnName("SysFK_Warehouse_LdgrInvty")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqLdgrInvty).HasColumnName("SysSeq_LdgrInvty");

                entity.Property(e => e.TotalHoursDifferenceLdgrInvty)
                    .HasColumnName("TotalHoursDifference_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.TransactionStatusLdgrInvty)
                    .HasColumnName("TransactionStatus_LdgrInvty")
                    .HasMaxLength(40);

                entity.Property(e => e.TransactionTypeLdgrInvty)
                    .HasColumnName("TransactionType_LdgrInvty")
                    .HasMaxLength(20);

                entity.Property(e => e.UnitNetCostLdgrInvty)
                    .HasColumnName("UnitNetCost_LdgrInvty")
                    .HasColumnType("money");

                entity.Property(e => e.UserFkInvtyBatchLdgrInvty)
                    .HasColumnName("UserFK_InvtyBatch_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkInvtyLdgrInvty)
                    .HasColumnName("UserFK_Invty_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkInvtyPriceLdgrInvty)
                    .HasColumnName("UserFK_InvtyPrice_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkLaneLdgrInvty)
                    .HasColumnName("UserFK_Lane_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkTankLdgrInvty)
                    .HasColumnName("UserFK_Tank_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkWrseLdgrInvty)
                    .HasColumnName("UserFK_Wrse_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFksourceDocumentLdgrInvty)
                    .HasColumnName("UserFKSourceDocument_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkLdgrInvty)
                    .HasColumnName("UserPK_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkalternativeLdgrInvty)
                    .HasColumnName("UserPKAlternative_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkcustomerLdgrInvty)
                    .HasColumnName("UserPKCustomer_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkpriceLdgrInvty)
                    .HasColumnName("UserPKPrice_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPksupplierLdgrInvty)
                    .HasColumnName("UserPKSupplier_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktransHLdgrInvty)
                    .HasColumnName("UserPKTransH_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkwarehouseLdgrInvty)
                    .HasColumnName("UserPKWarehouse_LdgrInvty")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrInvty).HasColumnName("UserSeq_LdgrInvty");
            });

            modelBuilder.Entity<TransactionLedgerInvtySalesPurchOrd>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrInvtySpo);

                entity.ToTable("Transaction_Ledger_InvtySalesPurchOrd");

                entity.Property(e => e.SysPkLdgrInvtySpo)
                    .HasColumnName("SysPK_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BarcodeLdgrInvtySpo)
                    .HasColumnName("Barcode_LdgrInvtySPO")
                    .HasMaxLength(25);

                entity.Property(e => e.BaseUnitOfMeasureLdgrInvtySpo)
                    .HasColumnName("BaseUnitOfMeasure_LdgrInvtySPO")
                    .HasMaxLength(8);

                entity.Property(e => e.BaseUnitQtyInLdgrInvtySpo)
                    .HasColumnName("BaseUnitQtyIn_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyMultiplierLdgrInvtySpo)
                    .HasColumnName("BaseUnitQtyMultiplier_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.BaseUnitQtyOutLdgrInvtySpo)
                    .HasColumnName("BaseUnitQtyOut_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.CheckedByLdgrInvtySpo)
                    .HasColumnName("CheckedBy_LdgrInvtySPO")
                    .HasMaxLength(100);

                entity.Property(e => e.CommissionAmountLdgrInvtySpo)
                    .HasColumnName("CommissionAmount_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.CommissionRateLdgrInvtySpo)
                    .HasColumnName("CommissionRate_LdgrInvtySPO")
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountedUnitPurchaseLdgrInvtySpo)
                    .HasColumnName("DiscountedUnitPurchase_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DiscountedUnitSellingLdgrInvtySpo)
                    .HasColumnName("DiscountedUnitSelling_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayDescriptionLdgrInvtySpo)
                    .HasColumnName("DisplayDescription_LdgrInvtySPO")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayDiscountingLdgrInvtySpo)
                    .HasColumnName("DisplayDiscounting_LdgrInvtySPO")
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayForeignConversionRateLdgInvtySpo)
                    .HasColumnName("DisplayForeignConversionRate_LdgInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayForeignSignLdgrInvtySpo)
                    .HasColumnName("DisplayForeignSign_LdgrInvtySPO")
                    .HasMaxLength(2);

                entity.Property(e => e.DisplayForeignUnitPurchaseLdgrInvtySpo)
                    .HasColumnName("DisplayForeignUnitPurchase_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayForeignUnitSellingLdgrInvtySpo)
                    .HasColumnName("DisplayForeignUnitSelling_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyInLdgrInvtySpo)
                    .HasColumnName("DisplayQtyIn_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayQtyOutLdgrInvtySpo)
                    .HasColumnName("DisplayQtyOut_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalInLdgrInvtySpo)
                    .HasColumnName("DisplaySubTotalIn_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplaySubTotalOutLdgrInvtySpo)
                    .HasColumnName("DisplaySubTotalOut_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitOfMeasureLdgrInvtySpo)
                    .HasColumnName("DisplayUnitOfMeasure_LdgrInvtySPO")
                    .HasMaxLength(8);

                entity.Property(e => e.DisplayUnitPurchaseLdgrInvtySpo)
                    .HasColumnName("DisplayUnitPurchase_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.DisplayUnitSellingLdgrInvtySpo)
                    .HasColumnName("DisplayUnitSelling_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.FormulaUsedInSubTotalLdgrInvtySpo)
                    .HasColumnName("FormulaUsedInSubTotal_LdgrInvtySPO")
                    .HasMaxLength(10);

                entity.Property(e => e.IsConsignedOnPurchaseLdgrInvtySpo).HasColumnName("IsConsignedOnPurchase_LdgrInvtySPO");

                entity.Property(e => e.LastUpdatedByLdgrInvtySpo)
                    .HasColumnName("LastUpdatedBy_LdgrInvtySPO")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrInvtySpo)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrInvtySPO")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrInvtySpo)
                    .HasColumnName("LastUpdatedDate_LdgrInvtySPO")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ManualComputedSubTotalLdgrInvtySpo)
                    .HasColumnName("ManualComputedSubTotal_LdgrInvtySPO")
                    .HasMaxLength(10);

                entity.Property(e => e.ModuleLdgrInvtySpo)
                    .HasColumnName("Module_LdgrInvtySPO")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsLdgrInvtySpo)
                    .HasColumnName("Particulars_LdgrInvtySPO")
                    .HasMaxLength(255);

                entity.Property(e => e.PurchConsignQtyCreditLdgrInvtySpo)
                    .HasColumnName("PurchConsignQtyCredit_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.PurchConsignQtyDebitLdgrInvtySpo)
                    .HasColumnName("PurchConsignQtyDebit_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.PurchQtyCreditLdgrInvtySpo)
                    .HasColumnName("PurchQtyCredit_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.PurchQtyDebitLdgrInvtySpo)
                    .HasColumnName("PurchQtyDebit_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.SalesConsignQtyCreditLdgrInvtySpo)
                    .HasColumnName("SalesConsignQtyCredit_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.SalesConsignQtyDebitLdgrInvtySpo)
                    .HasColumnName("SalesConsignQtyDebit_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.SerialsLdgrInvtySpo)
                    .HasColumnName("Serials_LdgrInvtySPO")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusLdgrInvtySpo)
                    .HasColumnName("Status_LdgrInvtySPO")
                    .HasMaxLength(40);

                entity.Property(e => e.SysFkCustomerLdgrInvtySpo)
                    .HasColumnName("SysFK_Customer_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyBatchLdgrInvtySpo)
                    .HasColumnName("SysFK_InvtyBatch_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyLdgrInvtySpo)
                    .HasColumnName("SysFK_Invty_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyPriceLdgrInvtySpo)
                    .HasColumnName("SysFK_InvtyPrice_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyUnitMsrLdgrInvtySpo)
                    .HasColumnName("SysFK_InvtyUnitMsr_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkSupplierLdgrInvtySpo)
                    .HasColumnName("SysFK_Supplier_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHLdgrInvtySpo)
                    .HasColumnName("SysFK_TransH_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHslLdgrInvtySpo)
                    .HasColumnName("SysFK_TransHSL_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkWarehouseLdgrInvtySpo)
                    .HasColumnName("SysFK_Warehouse_LdgrInvtySPO")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqLdgrInvtySpo).HasColumnName("SysSeq_LdgrInvtySPO");

                entity.Property(e => e.TypeLdgrInvtySpo)
                    .HasColumnName("Type_LdgrInvtySPO")
                    .HasMaxLength(20);

                entity.Property(e => e.UnitNetCostLdgrInvtySpo)
                    .HasColumnName("UnitNetCost_LdgrInvtySPO")
                    .HasColumnType("money");

                entity.Property(e => e.UserFkInvtyPriceLdgrInvtySpo)
                    .HasColumnName("UserFK_InvtyPrice_LdgrInvtySPO")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkLdgrInvtySpo)
                    .HasColumnName("UserPK_LdgrInvtySPO")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrInvtySpo).HasColumnName("UserSeq_LdgrInvtySPO");
            });

            modelBuilder.Entity<TransactionLedgerInvtySerials>(entity =>
            {
                entity.HasKey(e => e.SysPkLdgrInvtySerial);

                entity.ToTable("Transaction_Ledger_Invty_Serials");

                entity.Property(e => e.SysPkLdgrInvtySerial)
                    .HasColumnName("SysPK_LdgrInvtySerial")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BarCodeLdgrInvtySerial)
                    .HasColumnName("BarCode_LdgrInvtySerial")
                    .HasMaxLength(50);

                entity.Property(e => e.DateTimeReceivedLdgrInvtySerial)
                    .HasColumnName("DateTimeReceived_LdgrInvtySerial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeReleasedLdgrInvtySerial)
                    .HasColumnName("DateTimeReleased_LdgrInvtySerial")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.HoursDifferenceLdgrInvtySerial)
                    .HasColumnName("HoursDifference_LdgrInvtySerial")
                    .HasColumnType("money");

                entity.Property(e => e.InChargeByLdgrInvtySerial)
                    .HasColumnName("InChargeBy_LdgrInvtySerial")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByLdgrInvtySerial)
                    .HasColumnName("LastUpdatedBy_LdgrInvtySerial")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdLdgrInvtySerial)
                    .HasColumnName("LastUpdatedConcurrencyID_LdgrInvtySerial")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateLdgrInvtySerial)
                    .HasColumnName("LastUpdatedDate_LdgrInvtySerial")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.QtyLdgrInvtySerial)
                    .HasColumnName("Qty_LdgrInvtySerial")
                    .HasColumnType("money");

                entity.Property(e => e.SerialLdgrInvtySerial)
                    .HasColumnName("Serial_LdgrInvtySerial")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusLdgrInvtySerial)
                    .HasColumnName("Status_LdgrInvtySerial")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusPercentLdgrInvtySerial)
                    .HasColumnName("StatusPercent_LdgrInvtySerial")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkInvtyLdgrInvtySerial)
                    .HasColumnName("SysFK_Invty_LdgrInvtySerial")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkLdgrInvtyLdgrInvtySerial)
                    .HasColumnName("SysFK_LdgrInvty_LdgrInvtySerial")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHldgrInvtyLdgrInvtySerial)
                    .HasColumnName("SysFK_TransHLdgrInvty_LdgrInvtySerial")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.UserPkLdgrInvtySerial)
                    .HasColumnName("UserPK_LdgrInvtySerial")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqLdgrInvtySerial)
                    .HasColumnName("UserSeq_LdgrInvtySerial")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TransactionLedgerWslipDetail>(entity =>
            {
                entity.HasKey(e => e.SysPkWslipDtl);

                entity.ToTable("Transaction_Ledger_WSlipDetail");

                entity.Property(e => e.SysPkWslipDtl)
                    .HasColumnName("SysPK_WSlipDtl")
                    .HasColumnType("money");

                entity.Property(e => e.DescriptionWslipDtl)
                    .HasColumnName("Description_WSlipDtl")
                    .HasMaxLength(255);

                entity.Property(e => e.DisplayQtyWslipDtl)
                    .HasColumnName("DisplayQty_WSlipDtl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DisplayReturnedQtyWslipDtl)
                    .HasColumnName("DisplayReturnedQty_WSlipDtl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByWslipDtl)
                    .HasColumnName("LastUpdatedBy_WSlipDtl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdWslipDtl).HasColumnName("LastUpdatedConcurrencyID_WSlipDtl");

                entity.Property(e => e.LastUpdatedDateWslipDtl)
                    .HasColumnName("LastUpdatedDate_WSlipDtl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModuleWslipDtl)
                    .HasColumnName("Module_WSlipDtl")
                    .HasMaxLength(50);

                entity.Property(e => e.RefNoWslipDtl)
                    .HasColumnName("RefNo_WSlipDtl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTransHWslipDtl)
                    .HasColumnName("SysFK_TransH_WSlipDtl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkWslipWslipDtl)
                    .HasColumnName("SysFK_WSlip_WSlipDtl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqWslipDtl).HasColumnName("SysSeq_WSlipDtl");

                entity.Property(e => e.UnitWslipDtl)
                    .HasColumnName("Unit_WSlipDtl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkWslipDtl)
                    .HasColumnName("UserPK_WSlipDtl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqWslipDtl).HasColumnName("UserSeq_WSlipDtl");
            });

            modelBuilder.Entity<TransactionPayrollAmount>(entity =>
            {
                entity.HasKey(e => e.SysPkPayrlAmt);

                entity.ToTable("Transaction_Payroll_Amount");

                entity.Property(e => e.SysPkPayrlAmt)
                    .HasColumnName("SysPK_PayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AdditionPayrlAmt)
                    .HasColumnName("Addition_PayrlAmt")
                    .HasColumnType("money");

                entity.Property(e => e.DeductionPayrlAmt)
                    .HasColumnName("Deduction_PayrlAmt")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPayrlAmt)
                    .HasColumnName("LastUpdatedBy_PayrlAmt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPayrlAmt)
                    .HasColumnName("LastUpdatedConcurrencyID_PayrlAmt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePayrlAmt)
                    .HasColumnName("LastUpdatedDate_PayrlAmt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePayrlAmt)
                    .HasColumnName("Module_PayrlAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.QtyPayrlAmt)
                    .HasColumnName("Qty_PayrlAmt")
                    .HasColumnType("money");

                entity.Property(e => e.RatePayrlAmt)
                    .HasColumnName("Rate_PayrlAmt")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkCoaPayrlAmt)
                    .HasColumnName("SysFK_COA_PayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHPayrlAmt)
                    .HasColumnName("SysFK_TransH_PayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHpayrlPayrlAmt)
                    .HasColumnName("SysFK_TransHPayrl_PayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmemplPayrlAmt)
                    .HasColumnName("SysFK_UMEmpl_PayrlAmt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPayrlAmt).HasColumnName("SysSeq_PayrlAmt");

                entity.Property(e => e.UserPkPayrlAmt)
                    .HasColumnName("UserPK_PayrlAmt")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPayrlAmt).HasColumnName("UserSeq_PayrlAmt");
            });

            modelBuilder.Entity<TransactionPayrollDeduction>(entity =>
            {
                entity.HasKey(e => e.SysPkPayrlDeduct);

                entity.ToTable("Transaction_Payroll_Deduction");

                entity.Property(e => e.SysPkPayrlDeduct)
                    .HasColumnName("SysPK_PayrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.AmountPayrlDeduct)
                    .HasColumnName("Amount_PayrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.DescriptionPayrlDeduct)
                    .HasColumnName("Description_PayrlDeduct")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByPayrlDeduct)
                    .HasColumnName("LastUpdatedBy_PayrlDeduct")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPayrlDeduct).HasColumnName("LastUpdatedConcurrencyID_PayrlDeduct");

                entity.Property(e => e.LastUpdatedDatePayrlDeduct)
                    .HasColumnName("LastUpdatedDate_PayrlDeduct")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModulePayrlDeduct)
                    .HasColumnName("Module_PayrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsPayrlDeduct)
                    .HasColumnName("Particulars_PayrlDeduct")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkPmdeductPayrlDeduct)
                    .HasColumnName("SysFK_PMDeduct_PayrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkPmmemoPayrlDeduct)
                    .HasColumnName("SysFK_PMMemo_PayrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkTransHPayrlDeduct)
                    .HasColumnName("SysFK_TransH_PayrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUmemplPayrlDeduct)
                    .HasColumnName("SysFK_UMEmpl_PayrlDeduct")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqPayrlDeduct).HasColumnName("SysSeq_PayrlDeduct");

                entity.Property(e => e.TypePayrlDeduct)
                    .HasColumnName("Type_PayrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPayrlDeduct)
                    .HasColumnName("UserPK_PayrlDeduct")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPayrlDeduct).HasColumnName("UserSeq_PayrlDeduct");
            });

            modelBuilder.Entity<TransactionPayrollDtr>(entity =>
            {
                entity.HasKey(e => e.SysPkPayrlDtr);

                entity.ToTable("Transaction_Payroll_DTR");

                entity.Property(e => e.SysPkPayrlDtr)
                    .HasColumnName("SysPK_PayrlDTR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DtrdatePayrlDtr)
                    .HasColumnName("DTRDate_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByPayrlDtr)
                    .HasColumnName("LastUpdatedBy_PayrlDTR")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPayrlDtr)
                    .HasColumnName("LastUpdatedConcurrencyID_PayrlDTR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePayrlDtr)
                    .HasColumnName("LastUpdatedDate_PayrlDTR")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LegalHolidayPayrlDtr)
                    .HasColumnName("LegalHoliday_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.ModulePayrlDtr)
                    .HasColumnName("Module_PayrlDTR")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsPayrlDtr)
                    .HasColumnName("Particulars_PayrlDTR")
                    .HasMaxLength(255);

                entity.Property(e => e.Shift1MinLatePayrlDtr)
                    .HasColumnName("Shift1MinLate_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift1MinUndertimePayrlDtr)
                    .HasColumnName("Shift1MinUndertime_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift1OthoursPayrlDtr)
                    .HasColumnName("Shift1OTHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift1OtminutesPayrlDtr)
                    .HasColumnName("Shift1OTMinutes_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift1TimeInPayrlDtr)
                    .HasColumnName("Shift1TimeIn_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift1TimeOutPayrlDtr)
                    .HasColumnName("Shift1TimeOut_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift1TotalHoursPayrlDtr)
                    .HasColumnName("Shift1TotalHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift1TotalMinutesPayrlDtr)
                    .HasColumnName("Shift1TotalMinutes_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift2MinLatePayrlDtr)
                    .HasColumnName("Shift2MinLate_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift2MinUndertimePayrlDtr)
                    .HasColumnName("Shift2MinUndertime_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift2OthoursPayrlDtr)
                    .HasColumnName("Shift2OTHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift2OtminutesPayrlDtr)
                    .HasColumnName("Shift2OTMinutes_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift2TimeInPayrlDtr)
                    .HasColumnName("Shift2TimeIn_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift2TimeOutPayrlDtr)
                    .HasColumnName("Shift2TimeOut_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift2TotalHoursPayrlDtr)
                    .HasColumnName("Shift2TotalHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift2TotalMinutesPayrlDtr)
                    .HasColumnName("Shift2TotalMinutes_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift3OthoursPayrlDtr)
                    .HasColumnName("Shift3OTHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift3TimeInPayrlDtr)
                    .HasColumnName("Shift3TimeIn_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift3TimeOutPayrlDtr)
                    .HasColumnName("Shift3TimeOut_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift3TotalHoursPayrlDtr)
                    .HasColumnName("Shift3TotalHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift4OthoursPayrlDtr)
                    .HasColumnName("Shift4OTHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.Shift4TimeInPayrlDtr)
                    .HasColumnName("Shift4TimeIn_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift4TimeOutPayrlDtr)
                    .HasColumnName("Shift4TimeOut_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift4TotalHoursPayrlDtr)
                    .HasColumnName("Shift4TotalHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.ShiftTotalTimeInPayrlDtr)
                    .HasColumnName("ShiftTotalTimeIn_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShiftTotalTimeOutPayrlDtr)
                    .HasColumnName("ShiftTotalTimeOut_PayrlDTR")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ShiftTotalTotalHoursPayrlDtr)
                    .HasColumnName("ShiftTotalTotalHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.ShiftTotalTotalMinLatePayrlDtr)
                    .HasColumnName("ShiftTotalTotalMinLate_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.ShiftTotalTotalMinUndertimePayrlDtr)
                    .HasColumnName("ShiftTotalTotalMinUndertime_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.ShiftTotalTotalMinutesPayrlDtr)
                    .HasColumnName("ShiftTotalTotalMinutes_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.ShiftTotalTotalOthoursPayrlDtr)
                    .HasColumnName("ShiftTotalTotalOTHours_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.ShiftTotalTotalOtminutesPayrlDtr)
                    .HasColumnName("ShiftTotalTotalOTMinutes_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.SickLeavePayrlDtr)
                    .HasColumnName("SickLeave_PayrlDTR")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SpecialHolidayPayrlDtr)
                    .HasColumnName("SpecialHoliday_PayrlDTR")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkTransHPayrlDtr)
                    .HasColumnName("SysFK_TransH_PayrlDTR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHpayrlPayrlDtr)
                    .HasColumnName("SysFK_TransHPayrl_PayrlDTR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmemplPayrlDtr)
                    .HasColumnName("SysFK_UMEmpl_PayrlDTR")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPayrlDtr).HasColumnName("SysSeq_PayrlDTR");

                entity.Property(e => e.TypePayrlDtr)
                    .HasColumnName("Type_PayrlDTR")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPayrlDtr)
                    .HasColumnName("UserPK_PayrlDTR")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPayrlDtr).HasColumnName("UserSeq_PayrlDTR");

                entity.Property(e => e.VacationLeavePayrlDtr)
                    .HasColumnName("VacationLeave_PayrlDTR")
                    .HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TransactionPayrollMemoLog>(entity =>
            {
                entity.HasKey(e => e.SysPkPayrlMemo);

                entity.ToTable("Transaction_Payroll_MemoLog");

                entity.Property(e => e.SysPkPayrlMemo)
                    .HasColumnName("SysPK_PayrlMemo")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPayrlMemo)
                    .HasColumnName("LastUpdatedBy_PayrlMemo")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPayrlMemo).HasColumnName("LastUpdatedConcurrencyID_PayrlMemo");

                entity.Property(e => e.LastUpdatedDatePayrlMemo)
                    .HasColumnName("LastUpdatedDate_PayrlMemo")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModulePayrlMemo)
                    .HasColumnName("Module_PayrlMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmmemoPayrlMemo)
                    .HasColumnName("SysFK_PMMemo_PayrlMemo")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkTransHPayrlMemo)
                    .HasColumnName("SysFK_TransH_PayrlMemo")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUmemplPayrlMemo)
                    .HasColumnName("SysFK_UMEmpl_PayrlMemo")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqPayrlMemo).HasColumnName("SysSeq_PayrlMemo");

                entity.Property(e => e.UserPkPayrlMemo)
                    .HasColumnName("UserPK_PayrlMemo")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPayrlMemo).HasColumnName("UserSeq_PayrlMemo");

                entity.Property(e => e.WarningLevelPayrlMemo)
                    .HasColumnName("WarningLevel_PayrlMemo")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionPayrollPaySlip>(entity =>
            {
                entity.HasKey(e => e.SysPkPayrlPslp);

                entity.ToTable("Transaction_Payroll_PaySlip");

                entity.Property(e => e.SysPkPayrlPslp)
                    .HasColumnName("SysPK_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AbsentRatePayrlPslp)
                    .HasColumnName("AbsentRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.AmountAdditionPayrlPslp)
                    .HasColumnName("AmountAddition_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.AmountDeductionPayrlPslp)
                    .HasColumnName("AmountDeduction_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.AmountGrossPayrlPslp)
                    .HasColumnName("AmountGross_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.AmountNetPayrlPslp)
                    .HasColumnName("AmountNet_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.BalancesPayrlPslp)
                    .HasColumnName("Balances_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BranchcodePayrlPslp)
                    .HasColumnName("Branchcode_PayrlPslp")
                    .HasMaxLength(50);

                entity.Property(e => e.CashAdvancePayrlPslp)
                    .HasColumnName("CashAdvance_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.DatePayrlPslp)
                    .HasColumnName("Date_PayrlPslp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DaysAbsentPayrlPslp)
                    .HasColumnName("DaysAbsent_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Deduction1PayrlPslp)
                    .HasColumnName("Deduction1_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Deduction2PayrlPslp)
                    .HasColumnName("Deduction2_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Deduction3PayrlPslp)
                    .HasColumnName("Deduction3_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Deduction4PayrlPslp)
                    .HasColumnName("Deduction4_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.HoursPerDayPayrlPslp)
                    .HasColumnName("HoursPerDay_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.IncomeTaxAmountPayrlPslp)
                    .HasColumnName("IncomeTaxAmount_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.IsFixedRatedPayrlPslp)
                    .HasColumnName("IsFixedRated_PayrlPslp")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByPayrlPslp)
                    .HasColumnName("LastUpdatedBy_PayrlPslp")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPayrlPslp)
                    .HasColumnName("LastUpdatedConcurrencyID_PayrlPslp")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePayrlPslp)
                    .HasColumnName("LastUpdatedDate_PayrlPslp")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LatesPayrlPslp)
                    .HasColumnName("Lates_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.LatesRatePayrlPslp)
                    .HasColumnName("LatesRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.LegalHolidayRatePayrlPslp)
                    .HasColumnName("LegalHolidayRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.LegalHolidayTotalPayrlPslp)
                    .HasColumnName("LegalHolidayTotal_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.ModulePayrlPslp)
                    .HasColumnName("Module_PayrlPslp")
                    .HasMaxLength(50);

                entity.Property(e => e.OtratePayrlPslp)
                    .HasColumnName("OTRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.OverDraftPayrlPslp)
                    .HasColumnName("OverDraft_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Overtime1DayRatePayrlPslp)
                    .HasColumnName("Overtime1DayRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime1DayWorkPayrlPslp)
                    .HasColumnName("Overtime1DayWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime1HourRatePayrlPslp)
                    .HasColumnName("Overtime1HourRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime1HourWorkPayrlPslp)
                    .HasColumnName("Overtime1HourWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime1WagePayrlPslp)
                    .HasColumnName("Overtime1Wage_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime2DayRatePayrlPslp)
                    .HasColumnName("Overtime2DayRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime2DayWorkPayrlPslp)
                    .HasColumnName("Overtime2DayWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime2HourRatePayrlPslp)
                    .HasColumnName("Overtime2HourRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime2HourWorkPayrlPslp)
                    .HasColumnName("Overtime2HourWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime2WageDayPayrlPslp)
                    .HasColumnName("Overtime2WageDay_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime2WageHourPayrlPslp)
                    .HasColumnName("Overtime2WageHour_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime3DayRatePayrlPslp)
                    .HasColumnName("Overtime3DayRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime3DayWorkPayrlPslp)
                    .HasColumnName("Overtime3DayWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime3HourRatePayrlPslp)
                    .HasColumnName("Overtime3HourRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime3HourWorkPayrlPslp)
                    .HasColumnName("Overtime3HourWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.Overtime3WagePayrlPslp)
                    .HasColumnName("Overtime3Wage_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.PagibigContEePayrlPslp)
                    .HasColumnName("PagibigContEE_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.PagibigContErPayrlPslp)
                    .HasColumnName("PagibigContER_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.PagibigLoanPayrlPslp)
                    .HasColumnName("PagibigLoan_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.PhilHealthAmountPayrlPslp)
                    .HasColumnName("PhilHealthAmount_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RateCodePayrlPslp)
                    .HasColumnName("RateCode_PayrlPslp")
                    .HasMaxLength(50);

                entity.Property(e => e.RateMethodPayrlPslp)
                    .HasColumnName("RateMethod_PayrlPslp")
                    .HasMaxLength(50);

                entity.Property(e => e.RatePayrlPslp).HasColumnName("Rate_PayrlPslp");

                entity.Property(e => e.RegularDayRatePayrlPslp)
                    .HasColumnName("RegularDayRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RegularDayWorkPayrlPslp)
                    .HasColumnName("RegularDayWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RegularHourRatePayrlPslp)
                    .HasColumnName("RegularHourRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RegularHourWorkPayrlPslp)
                    .HasColumnName("RegularHourWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RegularMonthRatePayrlPslp)
                    .HasColumnName("RegularMonthRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RegularPieceRatePayrlPslp)
                    .HasColumnName("RegularPieceRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RegularPieceWorkPayrlPslp)
                    .HasColumnName("RegularPieceWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.RegularWagePayrlPslp)
                    .HasColumnName("RegularWage_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.ShortDeductionPayrlPslp)
                    .HasColumnName("ShortDeduction_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.SpecialHolidayRatePayrlPslp)
                    .HasColumnName("SpecialHolidayRate_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.SpecialHolidayTotalPayrlPslp)
                    .HasColumnName("SpecialHolidayTotal_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.SsscontEePayrlPslp)
                    .HasColumnName("SSSContEE_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.SsscontErPayrlPslp)
                    .HasColumnName("SSSContER_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.SssloanPayrlPslp)
                    .HasColumnName("SSSLoan_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.StatusPayrlPslp)
                    .HasColumnName("Status_PayrlPslp")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoapayPayrlPslp)
                    .HasColumnName("SysFK_COAPay_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPlcyRatePayrlPslp)
                    .HasColumnName("SysFK_PlcyRate_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmdeductPayrlPslp)
                    .HasColumnName("SysFK_PMDeduct_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTransHPayrlPslp)
                    .HasColumnName("SysFK_TransH_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbranchPayrlPslp)
                    .HasColumnName("SysFK_UMBranch_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmemplPayrlPslp)
                    .HasColumnName("SysFK_UMEmpl_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPayrlPslp).HasColumnName("SysSeq_PayrlPslp");

                entity.Property(e => e.TotalAbsentChargePayrlPslp)
                    .HasColumnName("TotalAbsentCharge_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalDaysOfWorkPayrlPslp)
                    .HasColumnName("TotalDaysOfWork_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalDaysWorkedPayrlPslp)
                    .HasColumnName("TotalDaysWorked_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalHoursOfWorkPayrlPslp)
                    .HasColumnName("TotalHoursOfWork_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalLatesChargePayrlPslp)
                    .HasColumnName("TotalLatesCharge_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalLegalHolidaysHoursOtPayrlPslp)
                    .HasColumnName("TotalLegalHolidaysHoursOT_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalLegalHolidaysMinsOtPayrlPslp)
                    .HasColumnName("TotalLegalHolidaysMinsOT_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalLegalHolidaysOtPayrlPslp)
                    .HasColumnName("TotalLegalHolidaysOT_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalMinsOfWorkPayrlPslp)
                    .HasColumnName("TotalMinsOfWork_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalOtdaysOfWorkPayrlPslp)
                    .HasColumnName("TotalOTDaysOfWork_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalOthoursOfWorkPayrlPslp)
                    .HasColumnName("TotalOTHoursOfWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOtminsOfWorkPayrlPslp)
                    .HasColumnName("TotalOTMinsOfWork_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalOtwagePayrlPslp)
                    .HasColumnName("TotalOTWage_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalSpecialHolidaysHoursOtPayrlPslp)
                    .HasColumnName("TotalSpecialHolidaysHoursOT_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalSpecialHolidaysMinsOtPayrlPslp)
                    .HasColumnName("TotalSpecialHolidaysMinsOT_PayrlPslp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.TotalSpecialHolidaysOtPayrlPslp)
                    .HasColumnName("TotalSpecialHolidaysOT_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TotalWagePayrlPslp)
                    .HasColumnName("TotalWage_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.TypePayrlPslp)
                    .HasColumnName("Type_PayrlPslp")
                    .HasMaxLength(50);

                entity.Property(e => e.UndertimePayrlPslp)
                    .HasColumnName("Undertime_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.UndertimeRatePayrslp)
                    .HasColumnName("UndertimeRate_Payrslp")
                    .HasColumnType("money");

                entity.Property(e => e.UndertimeTotalChargePayrlPslp)
                    .HasColumnName("UndertimeTotalCharge_PayrlPslp")
                    .HasColumnType("money");

                entity.Property(e => e.UserPkPayrlPslp)
                    .HasColumnName("UserPK_PayrlPslp")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPayrlPslp).HasColumnName("UserSeq_PayrlPslp");

                entity.Property(e => e.WithHoldingTaxAmountPayrlPslp)
                    .HasColumnName("WithHoldingTaxAmount_PayrlPslp")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TransactionPayrollTimeSheet>(entity =>
            {
                entity.HasKey(e => e.SysPkPayrlTimeSheet);

                entity.ToTable("Transaction_Payroll_TimeSheet");

                entity.Property(e => e.SysPkPayrlTimeSheet)
                    .HasColumnName("SysPK_PayrlTimeSheet")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByPayrlTimeSheet)
                    .HasColumnName("LastUpdatedBy_PayrlTimeSheet")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPayrlTimeSheet).HasColumnName("LastUpdatedConcurrencyID_PayrlTimeSheet");

                entity.Property(e => e.LastUpdatedDatePayrlTimeSheet)
                    .HasColumnName("LastUpdatedDate_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ModulePayrlTimeSheet)
                    .HasColumnName("Module_PayrlTimeSheet")
                    .HasMaxLength(50);

                entity.Property(e => e.Shift1TimeInPayrlTimeSheet)
                    .HasColumnName("Shift1TimeIn_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift1TimeOutPayrlTimeSheet)
                    .HasColumnName("Shift1TimeOut_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift2TimeInPayrlTimeSheet)
                    .HasColumnName("Shift2TimeIn_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift2TimeOutPayrlTimeSheet)
                    .HasColumnName("Shift2TimeOut_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift3TimeInPayrlTimeSheet)
                    .HasColumnName("Shift3TimeIn_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift3TimeOutPayrlTimeSheet)
                    .HasColumnName("Shift3TimeOut_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift4TimeInPayrlTimeSheet)
                    .HasColumnName("Shift4TimeIn_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Shift4TimeOutPayrlTimeSheet)
                    .HasColumnName("Shift4TimeOut_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SysFkTransHPayrlTimeSheet)
                    .HasColumnName("SysFK_TransH_PayrlTimeSheet")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmemplPayrlTimeSheet)
                    .HasColumnName("SysFK_UMEmpl_PayrlTimeSheet")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmpayrlPayrlTimeSheet)
                    .HasColumnName("SysFK_UMPayrl_PayrlTimeSheet")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqPayrlTimeSheet).HasColumnName("SysSeq_PayrlTimeSheet");

                entity.Property(e => e.TimeSheetDatePayrlTimeSheet)
                    .HasColumnName("TimeSheetDate_PayrlTimeSheet")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.UserPkPayrlTimeSheet)
                    .HasColumnName("UserPK_PayrlTimeSheet")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPayrlTimeSheet).HasColumnName("UserSeq_PayrlTimeSheet");
            });

            modelBuilder.Entity<TransactionSalesQuote>(entity =>
            {
                entity.HasKey(e => e.SysPkSalesQ);

                entity.ToTable("Transaction_SalesQuote");

                entity.Property(e => e.SysPkSalesQ)
                    .HasColumnName("SysPK_SalesQ")
                    .HasColumnType("money");

                entity.Property(e => e.CodeSalesQ)
                    .HasColumnName("Code_SalesQ")
                    .HasMaxLength(50);

                entity.Property(e => e.DateIssueSalesQ)
                    .HasColumnName("DateIssue_SalesQ")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModuleSalesQ)
                    .HasColumnName("Module_SalesQ")
                    .HasMaxLength(50);

                entity.Property(e => e.NameSalesQ)
                    .HasColumnName("Name_SalesQ")
                    .HasMaxLength(255);

                entity.Property(e => e.ParticularsSalesQ)
                    .HasColumnName("Particulars_SalesQ")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesQnumOrderSalesQ)
                    .HasColumnName("SalesQNumOrder_SalesQ")
                    .HasColumnType("money");

                entity.Property(e => e.SalesQnumSalesQ)
                    .HasColumnName("SalesQNum_SalesQ")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkSqSalesQ)
                    .HasColumnName("SysFK_SQ_SalesQ")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUmSalesQ)
                    .HasColumnName("SysFK_UM_SalesQ")
                    .HasColumnType("money");

                entity.Property(e => e.TotalAmountSalesQ)
                    .HasColumnName("TotalAmount_SalesQ")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<TransactionSalesQuoteDtl>(entity =>
            {
                entity.HasKey(e => e.SysPkSalesQdtl);

                entity.ToTable("Transaction_SalesQuoteDtl");

                entity.Property(e => e.SysPkSalesQdtl)
                    .HasColumnName("SysPK_SalesQDtl")
                    .HasColumnType("money");

                entity.Property(e => e.ApplicationSalesQdtl)
                    .HasColumnName("Application_SalesQDtl")
                    .HasMaxLength(100);

                entity.Property(e => e.BrandSalesQdtl)
                    .HasColumnName("Brand_SalesQDtl")
                    .HasMaxLength(100);

                entity.Property(e => e.CostCodeSalesQdtl)
                    .HasColumnName("CostCode_SalesQDtl")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionSalesQdtl)
                    .HasColumnName("Description_SalesQDtl")
                    .HasMaxLength(255);

                entity.Property(e => e.DiscSalesQdtl)
                    .HasColumnName("Disc_SalesQDtl")
                    .HasColumnType("money");

                entity.Property(e => e.PartNoSalesQdtl)
                    .HasColumnName("PartNo_SalesQDtl")
                    .HasMaxLength(100);

                entity.Property(e => e.QtySalesQdtl)
                    .HasColumnName("Qty_SalesQDtl")
                    .HasColumnType("money");

                entity.Property(e => e.SubTotalSalesQdtl)
                    .HasColumnName("SubTotal_SalesQDtl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkInvtySalesQdtl)
                    .HasColumnName("SysFK_Invty_SalesQDtl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkSqSalesQdtl)
                    .HasColumnName("SysFK_SQ_SalesQDtl")
                    .HasColumnType("money");

                entity.Property(e => e.UnitPriceSalesQdtl)
                    .HasColumnName("UnitPrice_SalesQDtl")
                    .HasColumnType("money");

                entity.Property(e => e.UnitSalesQdtl)
                    .HasColumnName("Unit_SalesQDtl")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UnitConversionDetails>(entity =>
            {
                entity.HasKey(e => e.SysPkUnitConvDetl);

                entity.ToTable("UnitConversion_Details");

                entity.Property(e => e.SysPkUnitConvDetl)
                    .HasColumnName("SysPK_UnitConvDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EnglishAreaUnitUnitConvDetl)
                    .HasColumnName("EnglishAreaUnit_UnitConvDetl")
                    .HasColumnType("money");

                entity.Property(e => e.EnglishVolumeUnitUnitConvDetl)
                    .HasColumnName("EnglishVolumeUnit_UnitConvDetl")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByUnitConvDetl)
                    .HasColumnName("LastUpdatedBy_UnitConvDetl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUnitConvDetl)
                    .HasColumnName("LastUpdatedConcurrencyID_UnitConvDetl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUnitConvDetl)
                    .HasColumnName("LastUpdatedDate_UnitConvDetl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MetricAreaUnitUnitConvDetl)
                    .HasColumnName("MetricAreaUnit_UnitConvDetl")
                    .HasColumnType("money");

                entity.Property(e => e.MetricVolumeUnitUnitConvDetl)
                    .HasColumnName("MetricVolumeUnit_UnitConvDetl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUnitConvMstrUnitConvDetl)
                    .HasColumnName("SysFK_UnitConvMstr_UnitConvDetl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUnitConvDetl).HasColumnName("SysSeq_UnitConvDetl");

                entity.Property(e => e.UserSeqUnitConvDetl).HasColumnName("UserSeq_UnitConvDetl");
            });

            modelBuilder.Entity<UnitConversionMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkUnitConvMstr);

                entity.ToTable("UnitConversion_Master");

                entity.Property(e => e.SysPkUnitConvMstr)
                    .HasColumnName("SysPK_UnitConvMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateDefinedUnitConvMstr)
                    .HasColumnName("DateDefined_UnitConvMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DefinedByUnitConvMstr)
                    .HasColumnName("DefinedBy_UnitConvMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.DescriptionUnitConvMstr)
                    .HasColumnName("Description_UnitConvMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByUnitConvMstr)
                    .HasColumnName("LastUpdatedBy_UnitConvMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUnitConvMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_UnitConvMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUnitConvMstr)
                    .HasColumnName("LastUpdatedDate_UnitConvMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticularsUnitConvMstr)
                    .HasColumnName("Particulars_UnitConvMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkInvtyBatchUnitConvMstr)
                    .HasColumnName("SysFK_InvtyBatch_UnitConvMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyUnitConvMstr)
                    .HasColumnName("SysFK_Invty_UnitConvMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmUnitConvMstr)
                    .HasColumnName("SysFK_UM_UnitConvMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUnitConvMstr).HasColumnName("SysSeq_UnitConvMstr");

                entity.Property(e => e.UserPkUnitConvMstr)
                    .HasColumnName("UserPK_UnitConvMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUnitConvMstr).HasColumnName("UserSeq_UnitConvMstr");
            });

            modelBuilder.Entity<UniversalMaster2>(entity =>
            {
                entity.HasKey(e => e.SysPkUm);

                entity.ToTable("Universal_Master2");

                entity.HasIndex(e => e.CbdUm)
                    .HasName("IX_Universal_Master2");

                entity.HasIndex(e => e.ModuleRoleUm)
                    .HasName("IX_Universal_Master2_2");

                entity.HasIndex(e => e.ModuleUm)
                    .HasName("IX_Universal_Master2_1");

                entity.HasIndex(e => e.NameUm)
                    .HasName("IX_Universal_Master2_3");

                entity.Property(e => e.SysPkUm)
                    .HasColumnName("SysPK_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccountNumUm)
                    .HasColumnName("AccountNum_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressBillingUm)
                    .HasColumnName("AddressBilling_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressShippingUm)
                    .HasColumnName("AddressShipping_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.AreaUm)
                    .HasColumnName("Area_UM")
                    .HasMaxLength(100);

                entity.Property(e => e.BondAmountUm)
                    .HasColumnName("BondAmount_UM")
                    .HasColumnType("money");

                entity.Property(e => e.BranchTypeUm)
                    .HasColumnName("BranchType_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.CbdUm)
                    .HasColumnName("CBD_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CheckNameUm)
                    .HasColumnName("CheckName_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.CiinfoFileNameUm)
                    .HasColumnName("CIInfoFileName_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.ConfidentialityLevelUm)
                    .HasColumnName("ConfidentialityLevel_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactPersonPositionUm)
                    .HasColumnName("ContactPersonPosition_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactPersonUm)
                    .HasColumnName("ContactPerson_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditInfoFileNameUm)
                    .HasColumnName("CreditInfoFileName_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.CustAssignedCollectorUm)
                    .HasColumnName("CustAssignedCollector_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.CustPreferredSalesAgentUm)
                    .HasColumnName("CustPreferredSalesAgent_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.DeptUm)
                    .HasColumnName("Dept_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.InactiveUm)
                    .HasColumnName("Inactive_UM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.IsConsignmentUm).HasColumnName("IsConsignment_UM");

                entity.Property(e => e.IsVatUm).HasColumnName("IsVAT_UM");

                entity.Property(e => e.LastUpdatedByUm)
                    .HasColumnName("LastUpdatedBy_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUm)
                    .HasColumnName("LastUpdatedConcurrencyID_UM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUm)
                    .HasColumnName("LastUpdatedDate_UM")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleRoleUm)
                    .HasColumnName("ModuleRole_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.ModuleTypeUm)
                    .HasColumnName("ModuleType_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUm)
                    .HasColumnName("Module_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUserPkUm)
                    .HasColumnName("ModuleUserPK_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.NameInitialsUm)
                    .HasColumnName("NameInitials_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.NameSpeakUm)
                    .HasColumnName("NameSpeak_UM")
                    .HasMaxLength(100);

                entity.Property(e => e.NameUm)
                    .HasColumnName("Name_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.ParticularsUm)
                    .HasColumnName("Particulars_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameUm)
                    .HasColumnName("PictureFileName_UM")
                    .HasMaxLength(255);

                entity.Property(e => e.ReportNameUm)
                    .HasColumnName("ReportName_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.SectionUm)
                    .HasColumnName("Section_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusUm)
                    .HasColumnName("Status_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkBranchUm)
                    .HasColumnName("SysFK_Branch_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaapUm)
                    .HasColumnName("SysFK_COAAP_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaarUm)
                    .HasColumnName("SysFK_COAAR_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacibUm)
                    .HasColumnName("SysFK_COACIB_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoainputTaxUm)
                    .HasColumnName("SysFK_COAInputTax_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaoutputTaxUm)
                    .HasColumnName("SysFK_COAOutputTax_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaslUm)
                    .HasColumnName("SysFK_COASL_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoavatUm)
                    .HasColumnName("SysFK_COAVat_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCollectorUm)
                    .HasColumnName("SysFK_Collector_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCustPreferredSalesAgentUm)
                    .HasColumnName("SysFK_CustPreferredSalesAgent_UM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyUm)
                    .HasColumnName("SysFK_Invty_UM")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUmUm)
                    .HasColumnName("SysFK_UM_UM")
                    .HasColumnType("money");

                entity.Property(e => e.SysSeqUm).HasColumnName("SysSeq_UM");

                entity.Property(e => e.TelNumBillingUm)
                    .HasColumnName("TelNumBilling_UM")
                    .HasMaxLength(150);

                entity.Property(e => e.TelNumShippingUm)
                    .HasColumnName("TelNumShipping_UM")
                    .HasMaxLength(150);

                entity.Property(e => e.TinvatnumberUm)
                    .HasColumnName("TINVATNumber_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeAcctConcatenatedUm)
                    .HasColumnName("TypeAcctConcatenated_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeUm)
                    .HasColumnName("Type_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkBranchUm)
                    .HasColumnName("UserFK_Branch_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPasswordUm)
                    .HasColumnName("UserPassword_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkUm)
                    .HasColumnName("UserPK_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkseqMasterfileTypeUm)
                    .HasColumnName("UserPKSeqMasterfileType_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkseqUm)
                    .HasColumnName("UserPKSeq_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPktypeUm)
                    .HasColumnName("UserPKType_UM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUm).HasColumnName("UserSeq_UM");
            });

            modelBuilder.Entity<UniversalMasterBalances>(entity =>
            {
                entity.HasKey(e => e.SysPkUmbal);

                entity.ToTable("Universal_Master_Balances");

                entity.Property(e => e.SysPkUmbal)
                    .HasColumnName("SysPK_UMBal")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ApamountUmbal)
                    .HasColumnName("APAmount_UMBal")
                    .HasColumnType("money");

                entity.Property(e => e.ApasOfUmbal)
                    .HasColumnName("APAsOf_UMBal")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ApdaysPastDueUmbal).HasColumnName("APDaysPastDue_UMBal");

                entity.Property(e => e.AramountUmbal)
                    .HasColumnName("ARAmount_UMBal")
                    .HasColumnType("money");

                entity.Property(e => e.ArasOfUmbal)
                    .HasColumnName("ARAsOf_UMBal")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ArdaysPastDueUmbal).HasColumnName("ARDaysPastDue_UMBal");

                entity.Property(e => e.CheckAsOfUmbal)
                    .HasColumnName("CheckAsOf_UMBal")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CheckBadUmbal)
                    .HasColumnName("CheckBad_UMBal")
                    .HasColumnType("money");

                entity.Property(e => e.CheckUnClearedUmbal)
                    .HasColumnName("CheckUnCleared_UMBal")
                    .HasColumnType("money");

                entity.Property(e => e.LastUpdatedByUmbal)
                    .HasColumnName("LastUpdatedBy_UMBal")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmbal)
                    .HasColumnName("LastUpdatedConcurrencyID_UMBal")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmbal)
                    .HasColumnName("LastUpdatedDate_UMBal")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmbal)
                    .HasColumnName("Module_UMBal")
                    .HasMaxLength(50);

                entity.Property(e => e.SalesConsignmentAmountUmbal)
                    .HasColumnName("SalesConsignmentAmount_UMBal")
                    .HasColumnType("money");

                entity.Property(e => e.SalesConsignmentDaysPastDueUmbal).HasColumnName("SalesConsignmentDaysPastDue_UMBal");

                entity.Property(e => e.SysFkUmUmbal)
                    .HasColumnName("SysFK_UM_UMBal")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmbal).HasColumnName("SysSeq_UMBal");

                entity.Property(e => e.UserSeqUmbal).HasColumnName("UserSeq_UMBal");
            });

            modelBuilder.Entity<UniversalMasterBank>(entity =>
            {
                entity.HasKey(e => e.SysPkUmbank);

                entity.ToTable("Universal_Master_Bank");

                entity.Property(e => e.SysPkUmbank)
                    .HasColumnName("SysPK_UMBank")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AccountNumUmbank)
                    .HasColumnName("AccountNum_UMBank")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByUmbank)
                    .HasColumnName("LastUpdatedBy_UMBank")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmbank)
                    .HasColumnName("LastUpdatedConcurrencyID_UMBank")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmbank)
                    .HasColumnName("LastUpdatedDate_UMBank")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MinimumBalanceUmbank)
                    .HasColumnName("MinimumBalance_UMBank")
                    .HasColumnType("money");

                entity.Property(e => e.ModuleUmbank)
                    .HasColumnName("Module_UMBank")
                    .HasMaxLength(50);

                entity.Property(e => e.NameContactPersonUmbank)
                    .HasColumnName("NameContactPerson_UMBank")
                    .HasMaxLength(50);

                entity.Property(e => e.NameManagerUmbank)
                    .HasColumnName("NameManager_UMBank")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoaapUmbank)
                    .HasColumnName("SysFK_COAAP_UMBank")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaarcreditCardUmbank)
                    .HasColumnName("SysFK_COAARCreditCard_UMBank")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoacashInBankUmbank)
                    .HasColumnName("SysFK_COACashInBank_UMBank")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoapdcUmbank)
                    .HasColumnName("SysFK_COAPDC_UMBank")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmUmbank)
                    .HasColumnName("SysFK_UM_UMBank")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbankParentUmbank)
                    .HasColumnName("SysFK_UMBankParent_UMBank")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmbank).HasColumnName("SysSeq_UMBank");

                entity.Property(e => e.UserPkalternativeUmbank)
                    .HasColumnName("UserPKAlternative_UMBank")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmbank).HasColumnName("UserSeq_UMBank");
            });

            modelBuilder.Entity<UniversalMasterBorrower>(entity =>
            {
                entity.HasKey(e => e.SysPkUmbrwr);

                entity.ToTable("Universal_Master_Borrower");

                entity.Property(e => e.SysPkUmbrwr)
                    .HasColumnName("SysPK_UMBrwr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AddressBusinessUmbrwr)
                    .HasColumnName("AddressBusiness_UMBrwr")
                    .HasMaxLength(255);

                entity.Property(e => e.AreaUmbrwr)
                    .HasColumnName("Area_UMBrwr")
                    .HasMaxLength(50);

                entity.Property(e => e.BirthdateUmbrwr)
                    .HasColumnName("Birthdate_UMBrwr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByUmbrwr)
                    .HasColumnName("LastUpdatedBy_UMBrwr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmbrwr)
                    .HasColumnName("LastUpdatedConcurrencyID_UMBrwr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmbrwr)
                    .HasColumnName("LastUpdatedDate_UMBrwr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaritalRoleUmbrwr)
                    .HasColumnName("MaritalRole_UMBrwr")
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatusUmbrwr)
                    .HasColumnName("MaritalStatus_UMBrwr")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUmbrwr)
                    .HasColumnName("Module_UMBrwr")
                    .HasMaxLength(50);

                entity.Property(e => e.RelationUmbrwr)
                    .HasColumnName("Relation_UMBrwr")
                    .HasMaxLength(50);

                entity.Property(e => e.SalutationUmbrwr)
                    .HasColumnName("Salutation_UMBrwr")
                    .HasMaxLength(50);

                entity.Property(e => e.SpaUmbrwr)
                    .HasColumnName("SPA_UMBrwr")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkUmUmbrwr)
                    .HasColumnName("SysFK_UM_UMBrwr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmbrwrParentUmbrwr)
                    .HasColumnName("SysFK_UMBrwrParent_UMBrwr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmbrwr).HasColumnName("SysSeq_UMBrwr");

                entity.Property(e => e.UserPkalternativeUmbrwr)
                    .HasColumnName("UserPKAlternative_UMBrwr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmbrwr).HasColumnName("UserSeq_UMBrwr");
            });

            modelBuilder.Entity<UniversalMasterBusinessFinancial>(entity =>
            {
                entity.HasKey(e => e.SysPkUmbusnFinc);

                entity.ToTable("Universal_Master_BusinessFinancial");

                entity.Property(e => e.SysPkUmbusnFinc)
                    .HasColumnName("SysPK_UMBusnFinc")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactUmbusnFinc)
                    .HasColumnName("Contact_UMBusnFinc")
                    .HasMaxLength(50);

                entity.Property(e => e.DateUmbusnFinc)
                    .HasColumnName("Date_UMBusnFinc")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.LastUpdatedByUmbusnFinc)
                    .HasColumnName("LastUpdatedBy_UMBusnFinc")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmbusnFinc)
                    .HasColumnName("LastUpdatedConcurrencyID_UMBusnFinc")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmbusnFinc)
                    .HasColumnName("LastUpdatedDate_UMBusnFinc")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmbusnFinc)
                    .HasColumnName("Module_UMBusnFinc")
                    .HasMaxLength(50);

                entity.Property(e => e.NameUmbusnFinc)
                    .HasColumnName("Name_UMBusnFinc")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksUmbusnFinc)
                    .HasColumnName("Remarks_UMBusnFinc")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkUmUmbusnFinc).HasColumnName("SysFK_UM_UMBusnFinc");

                entity.Property(e => e.SysSeqUmbusnFinc).HasColumnName("SysSeq_UMBusnFinc");

                entity.Property(e => e.TypeUmbusnFinc)
                    .HasColumnName("Type_UMBusnFinc")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmbusnFinc).HasColumnName("UserSeq_UMBusnFinc");

                entity.Property(e => e.Value1UmbusnFinc)
                    .HasColumnName("Value1_UMBusnFinc")
                    .HasColumnType("money");

                entity.Property(e => e.Value2UmbusnFinc)
                    .HasColumnName("Value2_UMBusnFinc")
                    .HasColumnType("money");

                entity.Property(e => e.Value3UmbusnFinc)
                    .HasColumnName("Value3_UMBusnFinc")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<UniversalMasterCampaign>(entity =>
            {
                entity.HasKey(e => e.SysPkUmcamp);

                entity.ToTable("Universal_Master_Campaign");

                entity.Property(e => e.SysPkUmcamp)
                    .HasColumnName("SysPK_UMCamp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.EmailUmcamp)
                    .HasColumnName("EMail_UMCamp")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByUmcamp)
                    .HasColumnName("LastUpdatedBy_UMCamp")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmcamp)
                    .HasColumnName("LastUpdatedConcurrencyID_UMCamp")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmcamp)
                    .HasColumnName("LastUpdatedDate_UMCamp")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MailingAddressUmcamp)
                    .HasColumnName("MailingAddress_UMCamp")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUmcamp)
                    .HasColumnName("Module_UMCamp")
                    .HasMaxLength(50);

                entity.Property(e => e.SmsnumUmcamp)
                    .HasColumnName("SMSNum_UMCamp")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkUmUmcamp)
                    .HasColumnName("SysFK_UM_UMCamp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmcampParentUmcamp)
                    .HasColumnName("SysFK_UMCampParent_UMCamp")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmcamp).HasColumnName("SysSeq_UMCamp");

                entity.Property(e => e.UserPkalternativeUmcamp)
                    .HasColumnName("UserPKAlternative_UMCamp")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmcamp).HasColumnName("UserSeq_UMCamp");
            });

            modelBuilder.Entity<UniversalMasterCustomer>(entity =>
            {
                entity.HasKey(e => e.SysPkUmcust);

                entity.ToTable("Universal_Master_Customer");

                entity.Property(e => e.SysPkUmcust)
                    .HasColumnName("SysPK_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AddressContactEmergencyUmcust)
                    .HasColumnName("AddressContactEmergency_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressDeliveryUmcust)
                    .HasColumnName("AddressDelivery_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressOfficeUmcust)
                    .HasColumnName("AddressOffice_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.AddressResidenceUmcust)
                    .HasColumnName("AddressResidence_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.AreaUmcust)
                    .HasColumnName("Area_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.BarangayUmcust)
                    .HasColumnName("Barangay_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.BirthdateUmcust)
                    .HasColumnName("Birthdate_UMCust")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.BirthplaceUmcust)
                    .HasColumnName("Birthplace_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.BondAmountUmcust)
                    .HasColumnName("BondAmount_UMCust")
                    .HasColumnType("money");

                entity.Property(e => e.CityUmcust)
                    .HasColumnName("City_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.CoopPositionUmcust)
                    .HasColumnName("CoopPosition_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.CountryUmcust)
                    .HasColumnName("Country_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.CreditLimitAmountUmcust)
                    .HasColumnName("CreditLimitAmount_UMCust")
                    .HasColumnType("money");

                entity.Property(e => e.CreditLimitDaysPastDueUmcust)
                    .HasColumnName("CreditLimitDaysPastDue_UMCust")
                    .HasColumnType("money");

                entity.Property(e => e.CreditLimitRuleUsedUmcust)
                    .HasColumnName("CreditLimitRuleUsed_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.CtcdateIssueUmcust)
                    .HasColumnName("CTCDateIssue_UMCust")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CtcnumUmcust)
                    .HasColumnName("CTCNum_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.CtcplaceIssueUmcust)
                    .HasColumnName("CTCPlaceIssue_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.DateGrossIncomeUmcust)
                    .HasColumnName("DateGrossIncome_UMCust")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateLastConsultPhysicianUmcust)
                    .HasColumnName("DateLastConsultPhysician_UMCust")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateMarriedUmcust)
                    .HasColumnName("DateMarried_UMCust")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateMembershipUmcust)
                    .HasColumnName("DateMembership_UMCust")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateWithdrawUmcust)
                    .HasColumnName("DateWithdraw_UMCust")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultDiscountUmcust)
                    .HasColumnName("DefaultDiscount_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.EmailUmcust)
                    .HasColumnName("Email_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.GrossIncomeUmcust)
                    .HasColumnName("GrossIncome_UMCust")
                    .HasColumnType("money");

                entity.Property(e => e.HeightCmUmcust)
                    .HasColumnName("HeightCm_UMCust")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HeightInchesUmcust)
                    .HasColumnName("HeightInches_UMCust")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.HouseNumUmcust)
                    .HasColumnName("HouseNum_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.IllnessChildUmcust)
                    .HasColumnName("IllnessChild_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.IllnessLastFiveYearsUmcust)
                    .HasColumnName("IllnessLastFiveYears_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedByUmcust)
                    .HasColumnName("LastUpdatedBy_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmcust)
                    .HasColumnName("LastUpdatedConcurrencyID_UMCust")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmcust)
                    .HasColumnName("LastUpdatedDate_UMCust")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MaritalRoleUmcust)
                    .HasColumnName("MaritalRole_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatusUmcust)
                    .HasColumnName("MaritalStatus_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUmcust)
                    .HasColumnName("Module_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.NameContactEmergencyUmcust)
                    .HasColumnName("NameContactEmergency_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.NameDoctorLastConsultUmcust)
                    .HasColumnName("NameDoctorLastConsult_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.NameSpouseUmcust)
                    .HasColumnName("NameSpouse_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.NationalityUmcust)
                    .HasColumnName("Nationality_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.NetIncomeUmcust)
                    .HasColumnName("NetIncome_UMCust")
                    .HasColumnType("money");

                entity.Property(e => e.NickNameSpouseUmcust)
                    .HasColumnName("NickNameSpouse_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.NickNameUmcust)
                    .HasColumnName("NickName_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.PagIbigUmcust)
                    .HasColumnName("PagIbig_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.PhilhealthUmcust)
                    .HasColumnName("Philhealth_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.PhysicianConsultReasonUmcust)
                    .HasColumnName("PhysicianConsultReason_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.ProvinceUmcust)
                    .HasColumnName("Province_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.RelationUmcust)
                    .HasColumnName("Relation_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.ReligionUmcust)
                    .HasColumnName("Religion_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.SalutationUmcust)
                    .HasColumnName("Salutation_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.SexUmcust)
                    .HasColumnName("Sex_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.SpadescriptionUmcust)
                    .HasColumnName("SPADescription_UMCust")
                    .HasMaxLength(255);

                entity.Property(e => e.SssUmcust)
                    .HasColumnName("SSS_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.StallUmcust)
                    .HasColumnName("Stall_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusUmcust)
                    .HasColumnName("Status_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.StreetUmcust)
                    .HasColumnName("Street_UMCust")
                    .HasMaxLength(100);

                entity.Property(e => e.SysFkCoMaker1Umcust)
                    .HasColumnName("SysFK_CoMaker1_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoMaker2Umcust)
                    .HasColumnName("SysFK_CoMaker2_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoaarUmcust)
                    .HasColumnName("SysFK_COAAR_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoabadDebtsUmcust)
                    .HasColumnName("SysFK_COABadDebts_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesReturnUmcust)
                    .HasColumnName("SysFK_COASalesReturn_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasalesUmcust)
                    .HasColumnName("SysFK_COASales_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoasavingsUmcust)
                    .HasColumnName("SysFK_COASavings_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkCoashareCapUmcust)
                    .HasColumnName("SysFK_COAShareCap_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkDefaultAgentUmcust)
                    .HasColumnName("SysFK_DefaultAgent_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPrincipalAuthorityUmcust)
                    .HasColumnName("SysFK_PrincipalAuthority_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmUmcust)
                    .HasColumnName("SysFK_UM_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmcustParentUmcust)
                    .HasColumnName("SysFK_UMCustParent_UMCust")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmcust).HasColumnName("SysSeq_UMCust");

                entity.Property(e => e.TelNumContactEmergencyUmcust)
                    .HasColumnName("TelNumContactEmergency_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TelNumFaxUmcust)
                    .HasColumnName("TelNumFAX_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TelNumMobileUmcust)
                    .HasColumnName("TelNumMobile_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TelNumOfficeUmcust)
                    .HasColumnName("TelNumOffice_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TelNumResidenceUmcust)
                    .HasColumnName("TelNumResidence_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TermsArUmcust)
                    .HasColumnName("TermsAR_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TermsInUseArUmcust)
                    .HasColumnName("TermsInUseAR_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TinUmcust)
                    .HasColumnName("TIN_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TownUmcust)
                    .HasColumnName("Town_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeUmcust)
                    .HasColumnName("Type_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkalternativeUmcust)
                    .HasColumnName("UserPKAlternative_UMCust")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmcust).HasColumnName("UserSeq_UMCust");

                entity.Property(e => e.WeightKlUmcust)
                    .HasColumnName("WeightKl_UMCust")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WeightLbsUmcust)
                    .HasColumnName("WeightLbs_UMCust")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.YearsInAddressOfficeUmcust)
                    .HasColumnName("YearsInAddressOffice_UMCust")
                    .HasMaxLength(10);

                entity.Property(e => e.YearsInAddressResidenceUmcust)
                    .HasColumnName("YearsInAddressResidence_UMCust")
                    .HasMaxLength(10);

                entity.Property(e => e.ZipCodeUmcust)
                    .HasColumnName("ZipCode_UMCust")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UniversalMasterDefaults>(entity =>
            {
                entity.HasKey(e => e.SysPkUmd);

                entity.ToTable("Universal_Master_Defaults");

                entity.Property(e => e.SysPkUmd)
                    .HasColumnName("SysPK_UMD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByUmd)
                    .HasColumnName("LastUpdatedBy_UMD")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmd)
                    .HasColumnName("LastUpdatedConcurrencyID_UMD")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmd)
                    .HasColumnName("LastUpdatedDate_UMD")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmd)
                    .HasColumnName("Module_UMD")
                    .HasMaxLength(100);

                entity.Property(e => e.PreferenceNumUmd).HasColumnName("PreferenceNum_UMD");

                entity.Property(e => e.SysFkInvtyBatchUmd)
                    .HasColumnName("SysFK_InvtyBatch_UMD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkInvtyUmd)
                    .HasColumnName("SysFK_Invty_UMD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmUmd)
                    .HasColumnName("SysFK_UM_UMD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmd)
                    .HasColumnName("SysFK_UMD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUnitConvMstrUmd)
                    .HasColumnName("SysFK_UnitConvMstr_UMD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmd).HasColumnName("SysSeq_UMD");

                entity.Property(e => e.TypeAcctConcatenatedUmd)
                    .HasColumnName("TypeAcctConcatenated_UMD")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPkUmd)
                    .HasColumnName("UserPK_UMD")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmd).HasColumnName("UserSeq_UMD");
            });

            modelBuilder.Entity<UniversalMasterEmployee>(entity =>
            {
                entity.HasKey(e => e.SysPkUmempl);

                entity.ToTable("Universal_Master_Employee");

                entity.Property(e => e.SysPkUmempl)
                    .HasColumnName("SysPK_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateContractExpireUmempl)
                    .HasColumnName("DateContractExpire_UMEmpl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateHiredUmempl)
                    .HasColumnName("DateHired_UMEmpl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateRetireUmempl)
                    .HasColumnName("DateRetire_UMEmpl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentUmempl)
                    .HasColumnName("Department_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByUmempl)
                    .HasColumnName("LastUpdatedBy_UMEmpl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmempl)
                    .HasColumnName("LastUpdatedConcurrencyID_UMEmpl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmempl)
                    .HasColumnName("LastUpdatedDate_UMEmpl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmempl)
                    .HasColumnName("Module_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.PositionUmempl)
                    .HasColumnName("Position_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.RankLevelCodeUmempl)
                    .HasColumnName("RankLevelCode_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusUmempl)
                    .HasColumnName("Status_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoasalaryExpenseUmempl)
                    .HasColumnName("SysFK_COASalaryExpense_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmUmempl)
                    .HasColumnName("SysFK_PM_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmslryRteUmempl)
                    .HasColumnName("SysFK_PMSlryRte_UMEmpl")
                    .HasColumnType("money");

                entity.Property(e => e.SysFkUmUmempl)
                    .HasColumnName("SysFK_UM_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmemplParentUmempl)
                    .HasColumnName("SysFK_UMEmplParent_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmempl).HasColumnName("SysSeq_UMEmpl");

                entity.Property(e => e.TypeUmempl)
                    .HasColumnName("Type_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkalternativeUmempl)
                    .HasColumnName("UserPKAlternative_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmempl).HasColumnName("UserSeq_UMEmpl");
            });

            modelBuilder.Entity<UniversalMasterHris>(entity =>
            {
                entity.HasKey(e => e.SysPkUmempl)
                    .HasName("PK__Universal_Master__19B5BC39");

                entity.ToTable("Universal_Master_HRIS");

                entity.Property(e => e.SysPkUmempl)
                    .HasColumnName("SysPK_UMEmpl")
                    .HasColumnType("money");

                entity.Property(e => e.DateHiredUmempl)
                    .HasColumnName("DateHired_UMEmpl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateRetireUmempl)
                    .HasColumnName("DateRetire_UMEmpl")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentUmempl)
                    .HasColumnName("Department_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByUmempl)
                    .HasColumnName("LastUpdatedBy_UMEmpl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmempl)
                    .HasColumnName("LastUpdatedConcurrencyID_UMEmpl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmempl)
                    .HasColumnName("LastUpdatedDate_UMEmpl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmempl)
                    .HasColumnName("Module_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.PositionUmempl)
                    .HasColumnName("Position_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusUmempl)
                    .HasColumnName("Status_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoasalaryExpenseUmempl)
                    .HasColumnName("SysFK_COASalaryExpense_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkPmUmempl)
                    .HasColumnName("SysFK_PM_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmUmempl)
                    .HasColumnName("SysFK_UM_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmemplParentUmempl)
                    .HasColumnName("SysFK_UMEmplParent_UMEmpl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmempl).HasColumnName("SysSeq_UMEmpl");

                entity.Property(e => e.TypeUmempl)
                    .HasColumnName("Type_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkalternativeUmempl)
                    .HasColumnName("UserPKAlternative_UMEmpl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmempl).HasColumnName("UserSeq_UMEmpl");
            });

            modelBuilder.Entity<UniversalMasterJunction>(entity =>
            {
                entity.HasKey(e => e.SysPkUmj);

                entity.ToTable("Universal_Master_Junction");

                entity.Property(e => e.SysPkUmj)
                    .HasColumnName("SysPK_UMJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByUmj)
                    .HasColumnName("LastUpdatedBy_UMJ")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmj)
                    .HasColumnName("LastUpdatedConcurrencyID_UMJ")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmj)
                    .HasColumnName("LastUpdatedDate_UMJ")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTypeUmj)
                    .HasColumnName("ModuleType_UMJ")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleUmj)
                    .HasColumnName("Module_UMJ")
                    .HasMaxLength(50);

                entity.Property(e => e.RemarksUmj)
                    .HasColumnName("Remarks_UMJ")
                    .HasMaxLength(255);

                entity.Property(e => e.SysFkUm01Umj)
                    .HasColumnName("SysFK_UM01_UMJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUm02Umj)
                    .HasColumnName("SysFK_UM02_UMJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUm03Umj)
                    .HasColumnName("SysFK_UM03_UMJ")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmj).HasColumnName("SysSeq_UMJ");

                entity.Property(e => e.UserSeqUmj).HasColumnName("UserSeq_UMJ");
            });

            modelBuilder.Entity<UniversalMasterMembersGrossIncome>(entity =>
            {
                entity.HasKey(e => e.SysPkTableCode);

                entity.ToTable("Universal_Master_Members_GrossIncome");

                entity.Property(e => e.SysPkTableCode)
                    .HasColumnName("SysPK_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdTableCode)
                    .HasColumnName("CBD_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByTableCode)
                    .HasColumnName("LastUpdatedBy_TableCode")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTableCode)
                    .HasColumnName("LastUpdatedConcurrencyID_TableCode")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateTableCode)
                    .HasColumnName("LastUpdatedDate_TableCode")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleTableCode)
                    .HasColumnName("Module_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsTableCode)
                    .HasColumnName("Particulars_TableCode")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameTableCode)
                    .HasColumnName("PictureFileName_TableCode")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusTableCode)
                    .HasColumnName("Status_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkTableCodeParentTableCode)
                    .HasColumnName("SysFK_TableCodeParent_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTableCodeTableCode)
                    .HasColumnName("SysFK_TableCode_TableCode")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqTableCode).HasColumnName("SysSeq_TableCode");

                entity.Property(e => e.TypeTableCode)
                    .HasColumnName("Type_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTableCode)
                    .HasColumnName("UserPK_TableCode")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqTableCode).HasColumnName("UserSeq_TableCode");
            });

            modelBuilder.Entity<UniversalMasterPersonalInfo>(entity =>
            {
                entity.HasKey(e => e.SysPkUmpinfo);

                entity.ToTable("Universal_Master_Personal_Info");

                entity.Property(e => e.SysPkUmpinfo)
                    .HasColumnName("SysPK_UMPInfo")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByUmpinfo)
                    .HasColumnName("LastUpdatedBy_UMPInfo")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmpinfo)
                    .HasColumnName("LastUpdatedConcurrencyID_UMPInfo")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmpinfo)
                    .HasColumnName("LastUpdatedDate_UMPInfo")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmpinfo)
                    .HasColumnName("Module_UMPInfo")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsUmpinfo)
                    .HasColumnName("Particulars_UMPInfo")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameUmpinfo)
                    .HasColumnName("PictureFileName_UMPInfo")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusUmpinfo)
                    .HasColumnName("Status_UMPInfo")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkUmUmpinfo)
                    .HasColumnName("SysFK_UM_UMPInfo")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmpinfo).HasColumnName("SysSeq_UMPInfo");

                entity.Property(e => e.TypeUmpinfo)
                    .HasColumnName("Type_UMPInfo")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmpinfo).HasColumnName("UserSeq_UMPInfo");
            });

            modelBuilder.Entity<UniversalMasterSupplier>(entity =>
            {
                entity.HasKey(e => e.SysPkUmsupl);

                entity.ToTable("Universal_Master_Supplier");

                entity.Property(e => e.SysPkUmsupl)
                    .HasColumnName("SysPK_UMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.BondAmountUmsupl)
                    .HasColumnName("BondAmount_UMSupl")
                    .HasColumnType("money");

                entity.Property(e => e.CreditLimitAmountUmsupl)
                    .HasColumnName("CreditLimitAmount_UMSupl")
                    .HasColumnType("money");

                entity.Property(e => e.CreditLimitDaysPastDueUmsupl)
                    .HasColumnName("CreditLimitDaysPastDue_UMSupl")
                    .HasColumnType("money");

                entity.Property(e => e.DefaultDiscountUmsupl)
                    .HasColumnName("DefaultDiscount_UMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByUmsupl)
                    .HasColumnName("LastUpdatedBy_UMSupl")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmsupl)
                    .HasColumnName("LastUpdatedConcurrencyID_UMSupl")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmsupl)
                    .HasColumnName("LastUpdatedDate_UMSupl")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmsupl)
                    .HasColumnName("Module_UMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusUmsupl)
                    .HasColumnName("Status_UMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkCoapcsgnUmsupl)
                    .HasColumnName("SysFK_COAPCsgn_UMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmUmsupl)
                    .HasColumnName("SysFK_UM_UMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmsuplParentUmsupl)
                    .HasColumnName("SysFK_UMSuplParent_UMSupl")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmsupl).HasColumnName("SysSeq_UMSupl");

                entity.Property(e => e.TermsApUmsupl)
                    .HasColumnName("TermsAP_UMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.TermsInUseApUmsupl)
                    .HasColumnName("TermsInUseAP_UMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeUmsupl)
                    .HasColumnName("Type_UMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkalternativeUmsupl)
                    .HasColumnName("UserPKAlternative_UMSupl")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmsupl).HasColumnName("UserSeq_UMSupl");
            });

            modelBuilder.Entity<UniversalMasterVotes>(entity =>
            {
                entity.HasKey(e => e.SysPkUmvote);

                entity.ToTable("Universal_Master_Votes");

                entity.Property(e => e.SysPkUmvote)
                    .HasColumnName("SysPK_UMVote")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByUmvote)
                    .HasColumnName("LastUpdatedBy_UMVote")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdUmvote)
                    .HasColumnName("LastUpdatedConcurrencyID_UMVote")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateUmvote)
                    .HasColumnName("LastUpdatedDate_UMVote")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleUmvote)
                    .HasColumnName("Module_UMVote")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusUmvote)
                    .HasColumnName("Status_UMVote")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkPmUmvote)
                    .HasColumnName("SysFK_PM_UMVote")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkUmUmvote)
                    .HasColumnName("SysFK_UM_UMVote")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqUmvote).HasColumnName("SysSeq_UMVote");

                entity.Property(e => e.TypeUmvote)
                    .HasColumnName("Type_UMVote")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqUmvote).HasColumnName("UserSeq_UMVote");
            });

            modelBuilder.Entity<ZzzFormMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkFrmMstr);

                entity.ToTable("zzzForm_Master");

                entity.Property(e => e.SysPkFrmMstr)
                    .HasColumnName("SysPK_FrmMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DescriptionFrmMstr)
                    .HasColumnName("Description_FrmMstr")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastUpdatedByFrmMstr)
                    .HasColumnName("LastUpdatedBy_FrmMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFrmMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_FrmMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFrmMstr)
                    .HasColumnName("LastUpdatedDate_FrmMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuCaptionFrmMstr)
                    .HasColumnName("MenuCaption_FrmMstr")
                    .HasMaxLength(200);

                entity.Property(e => e.ModuleUserPkFrmMstr)
                    .HasColumnName("ModuleUserPK_FrmMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFrmMstr)
                    .HasColumnName("UserPK_FrmMstr")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ZzzFormMasterSystem>(entity =>
            {
                entity.HasKey(e => e.SysPkFrmMstr);

                entity.ToTable("zzzForm_MasterSystem");

                entity.Property(e => e.SysPkFrmMstr)
                    .HasColumnName("SysPK_FrmMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DescriptionFrmMstr)
                    .HasColumnName("Description_FrmMstr")
                    .HasColumnType("ntext");

                entity.Property(e => e.LastUpdatedByFrmMstr)
                    .HasColumnName("LastUpdatedBy_FrmMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdFrmMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_FrmMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateFrmMstr)
                    .HasColumnName("LastUpdatedDate_FrmMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MenuCaptionFrmMstr)
                    .HasColumnName("MenuCaption_FrmMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkFrmMstr)
                    .HasColumnName("UserPK_FrmMstr")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZzzGlobalOptions>(entity =>
            {
                entity.HasKey(e => e.SysPkGlbalOpt);

                entity.ToTable("zzzGlobalOptions");

                entity.Property(e => e.SysPkGlbalOpt)
                    .HasColumnName("SysPK_GlbalOpt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdGlbalOpt)
                    .HasColumnName("CBD_GlbalOpt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CompanyAddress2GlbalOpt)
                    .HasColumnName("CompanyAddress2_GlbalOpt")
                    .HasColumnType("ntext");

                entity.Property(e => e.CompanyAddressGlbalOpt)
                    .HasColumnName("CompanyAddress_GlbalOpt")
                    .HasColumnType("ntext");

                entity.Property(e => e.CompanyNameGlbalOpt)
                    .HasColumnName("CompanyName_GlbalOpt")
                    .HasMaxLength(255);

                entity.Property(e => e.CompanyTelGlbalOpt)
                    .HasColumnName("CompanyTel_GlbalOpt")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByGlbalOpt)
                    .HasColumnName("LastUpdatedBy_GlbalOpt")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdGlbalOpt)
                    .HasColumnName("LastUpdatedConcurrencyID_GlbalOpt")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateGlbalOpt)
                    .HasColumnName("LastUpdatedDate_GlbalOpt")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleGlbalOpt)
                    .HasColumnName("Module_GlbalOpt")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsGlbalOpt)
                    .HasColumnName("Particulars_GlbalOpt")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameGlbalOpt)
                    .HasColumnName("PictureFileName_GlbalOpt")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusGlbalOpt)
                    .HasColumnName("Status_GlbalOpt")
                    .HasMaxLength(50);

                entity.Property(e => e.SysFkGlbalOptParentGlbalOpt)
                    .HasColumnName("SysFK_GlbalOptParent_GlbalOpt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysFkTableCodeGlbalOpt)
                    .HasColumnName("SysFK_TableCode_GlbalOpt")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.SysSeqGlbalOpt).HasColumnName("SysSeq_GlbalOpt");

                entity.Property(e => e.TypeGlbalOpt)
                    .HasColumnName("Type_GlbalOpt")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkGlbalOpt)
                    .HasColumnName("UserPK_GlbalOpt")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqGlbalOpt).HasColumnName("UserSeq_GlbalOpt");
            });

            modelBuilder.Entity<ZzzHelpMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkHelpM);

                entity.ToTable("zzzHelp_Master");

                entity.Property(e => e.SysPkHelpM)
                    .HasColumnName("SysPK_HelpM")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CausedByHelpM)
                    .HasColumnName("CausedBy_HelpM")
                    .HasMaxLength(50);

                entity.Property(e => e.DateFixedHelpM)
                    .HasColumnName("DateFixed_HelpM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DateReportedHelpM)
                    .HasColumnName("DateReported_HelpM")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DetectedByHelpM)
                    .HasColumnName("DetectedBy_HelpM")
                    .HasMaxLength(50);

                entity.Property(e => e.FixedByHelpM)
                    .HasColumnName("FixedBy_HelpM")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByHelpM)
                    .HasColumnName("LastUpdatedBy_HelpM")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdHelpM)
                    .HasColumnName("LastUpdatedConcurrencyID_HelpM")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateHelpM)
                    .HasColumnName("LastUpdatedDate_HelpM")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModuleHelpM)
                    .HasColumnName("Module_HelpM")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsHelpM)
                    .HasColumnName("Particulars_HelpM")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameHelpM)
                    .HasColumnName("PictureFileName_HelpM")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusHelpM)
                    .HasColumnName("Status_HelpM")
                    .HasMaxLength(50);

                entity.Property(e => e.SysSeqHelpM).HasColumnName("SysSeq_HelpM");

                entity.Property(e => e.TypeHelpM)
                    .HasColumnName("Type_HelpM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkHelpM)
                    .HasColumnName("UserPK_HelpM")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqHelpM).HasColumnName("UserSeq_HelpM");
            });

            modelBuilder.Entity<ZzzModuleMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkModMstr);

                entity.ToTable("zzzModule_Master");

                entity.Property(e => e.SysPkModMstr)
                    .HasColumnName("SysPK_ModMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ParticularsModMstr)
                    .HasColumnName("Particulars_ModMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkModMstr)
                    .HasColumnName("UserPK_ModMstr")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZzzModuleTypeMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkModTypeMstr);

                entity.ToTable("zzzModule_Type_Master");

                entity.Property(e => e.SysPkModTypeMstr)
                    .HasColumnName("SysPK_ModTypeMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.FormCaptionModTypeMstr)
                    .HasColumnName("FormCaption_ModTypeMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.FormNameModTypeMstr)
                    .HasColumnName("FormName_ModTypeMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.FormPictureFileNameModTypeMstr)
                    .HasColumnName("FormPictureFileName_ModTypeMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserFkModMstrModTypeMstr)
                    .HasColumnName("UserFK_ModMstr_ModTypeMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkModTypeMstr)
                    .HasColumnName("UserPK_ModTypeMstr")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZzzPcstationMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkPcstnMstr);

                entity.ToTable("zzzPCStation_Master");

                entity.Property(e => e.SysPkPcstnMstr)
                    .HasColumnName("SysPK_PCStnMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByPcstnMstr)
                    .HasColumnName("LastUpdatedBy_PCStnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdPcstnMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_PCStnMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDatePcstnMstr)
                    .HasColumnName("LastUpdatedDate_PCStnMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModulePcstnMstr)
                    .HasColumnName("Module_PCStnMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.ParticularsPcstnMstr)
                    .HasColumnName("Particulars_PCStnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNamePcstnMstr)
                    .HasColumnName("PictureFileName_PCStnMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.StatusPcstnMstr)
                    .HasColumnName("Status_PCStnMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.TypePcstnMstr)
                    .HasColumnName("Type_PCStnMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkPcstnMstr)
                    .HasColumnName("UserPK_PCStnMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqPcstnMstr).HasColumnName("UserSeq_PCStnMstr");
            });

            modelBuilder.Entity<ZzzProcessingHistory>(entity =>
            {
                entity.HasKey(e => e.SysPkProcHist);

                entity.ToTable("zzzProcessing_History");

                entity.Property(e => e.SysPkProcHist)
                    .HasColumnName("SysPK_ProcHist")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CbdProcHist)
                    .HasColumnName("CBD_ProcHist")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ParticularsProcHist)
                    .HasColumnName("Particulars_ProcHist")
                    .HasMaxLength(255);

                entity.Property(e => e.ProcessByProcHist)
                    .HasColumnName("ProcessBy_ProcHist")
                    .HasMaxLength(255);

                entity.Property(e => e.ProcessDateProcHist)
                    .HasColumnName("ProcessDate_ProcHist")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ProcessTimeEndProcHist)
                    .HasColumnName("ProcessTimeEnd_ProcHist")
                    .HasMaxLength(50);

                entity.Property(e => e.ProcessTimeStartProcHist)
                    .HasColumnName("ProcessTimeStart_ProcHist")
                    .HasMaxLength(50);

                entity.Property(e => e.StatusProcHist)
                    .HasColumnName("Status_ProcHist")
                    .HasMaxLength(50);

                entity.Property(e => e.TypeProcHist)
                    .HasColumnName("Type_ProcHist")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ZzzQueries>(entity =>
            {
                entity.HasKey(e => e.SysPkQry);

                entity.ToTable("zzzQueries");

                entity.Property(e => e.SysPkQry)
                    .HasColumnName("SysPK_Qry")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByQry)
                    .HasColumnName("LastUpdatedBy_Qry")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdQry)
                    .HasColumnName("LastUpdatedConcurrencyID_Qry")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateQry)
                    .HasColumnName("LastUpdatedDate_Qry")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TagQry)
                    .HasColumnName("Tag_Qry")
                    .HasColumnType("ntext");

                entity.Property(e => e.TextQry)
                    .HasColumnName("Text_Qry")
                    .HasColumnType("ntext");

                entity.Property(e => e.UserPkQry)
                    .HasColumnName("UserPK_Qry")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ZzzQuotesMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkQuotMstr);

                entity.ToTable("zzzQuotes_Master");

                entity.Property(e => e.SysPkQuotMstr)
                    .HasColumnName("SysPK_QuotMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedByQuotMstr)
                    .HasColumnName("LastUpdatedBy_QuotMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdQuotMstr)
                    .HasColumnName("LastUpdatedConcurrencyID_QuotMstr")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateQuotMstr)
                    .HasColumnName("LastUpdatedDate_QuotMstr")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ParticularsQuotMstr)
                    .HasColumnName("Particulars_QuotMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.PictureFileNameQuotMstr)
                    .HasColumnName("PictureFileName_QuotMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.TypeQuotMstr)
                    .HasColumnName("Type_QuotMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkQuotMstr)
                    .HasColumnName("UserPK_QuotMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqQuotMstr).HasColumnName("UserSeq_QuotMstr");
            });

            modelBuilder.Entity<ZzzStoredProc>(entity =>
            {
                entity.HasKey(e => e.NameSp);

                entity.ToTable("zzzStoredProc");

                entity.Property(e => e.NameSp)
                    .HasColumnName("Name_sp")
                    .HasMaxLength(100)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBySp)
                    .HasColumnName("CreatedBy_sp")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedDateSp)
                    .HasColumnName("CreatedDate_sp")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ValidationSp)
                    .HasColumnName("Validation_sp")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<ZzzSupportRequest>(entity =>
            {
                entity.HasKey(e => e.SysPkSuprtReq);

                entity.ToTable("zzzSupport_Request");

                entity.Property(e => e.SysPkSuprtReq)
                    .HasColumnName("SysPK_SuprtReq")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AcceptedBySuprtReq)
                    .HasColumnName("AcceptedBy_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.AcceptedDateSuprtReq)
                    .HasColumnName("AcceptedDate_SuprtReq")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.CbdSuprtReq)
                    .HasColumnName("CBD_SuprtReq")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ChargesSuprtReq)
                    .HasColumnName("Charges_SuprtReq")
                    .HasColumnType("money");

                entity.Property(e => e.DeployedBySuprtReq)
                    .HasColumnName("DeployedBy_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.DeployedDateSuprtReq)
                    .HasColumnName("DeployedDate_SuprtReq")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IsEmergencySuprtReq).HasColumnName("IsEmergency_SuprtReq");

                entity.Property(e => e.ItemMenuCaptionSuprtReq)
                    .HasColumnName("ItemMenuCaption_SuprtReq")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedBySuprtReq)
                    .HasColumnName("LastUpdatedBy_SuprtReq")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdSuprtReq)
                    .HasColumnName("LastUpdatedConcurrencyID_SuprtReq")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedDateSuprtReq)
                    .HasColumnName("LastUpdatedDate_SuprtReq")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MainMenuCaptionSuprtReq)
                    .HasColumnName("MainMenuCaption_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.ModuleSuprtReq)
                    .HasColumnName("Module_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.PictureFileNameSuprtReq)
                    .HasColumnName("PictureFileName_SuprtReq")
                    .HasMaxLength(255);

                entity.Property(e => e.PrioritySuprtReq)
                    .HasColumnName("Priority_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.ProgrammedBySuprtReq)
                    .HasColumnName("ProgrammedBy_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.ProgrammedDateSuprtReq)
                    .HasColumnName("ProgrammedDate_SuprtReq")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ProphetSuprtReq)
                    .HasColumnName("Prophet_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.RejectedBySuprtReq)
                    .HasColumnName("RejectedBy_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.RejectedDateSuprtReq)
                    .HasColumnName("RejectedDate_SuprtReq")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.RequestParticularsSuprtReq)
                    .HasColumnName("RequestParticulars_SuprtReq")
                    .HasColumnType("ntext");

                entity.Property(e => e.RequestedBySuprtReq)
                    .HasColumnName("RequestedBy_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.RequestedDateSuprtReq)
                    .HasColumnName("RequestedDate_SuprtReq")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.SolutionParticularsSuprtReq)
                    .HasColumnName("SolutionParticulars_SuprtReq")
                    .HasColumnType("ntext");

                entity.Property(e => e.StatusSuprtReq)
                    .HasColumnName("Status_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.SysSeqSuprtReq).HasColumnName("SysSeq_SuprtReq");

                entity.Property(e => e.TypeSuprtReq)
                    .HasColumnName("Type_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkSuprtReq)
                    .HasColumnName("UserPK_SuprtReq")
                    .HasMaxLength(50);

                entity.Property(e => e.UserSeqSuprtReq).HasColumnName("UserSeq_SuprtReq");
            });

            modelBuilder.Entity<ZzzTrainMaster>(entity =>
            {
                entity.HasKey(e => e.SysPkTrainMstr);

                entity.ToTable("zzzTrain_Master");

                entity.Property(e => e.SysPkTrainMstr)
                    .HasColumnName("SysPK_TrainMstr")
                    .HasColumnType("money")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.DateTrainedTrainMstr)
                    .HasColumnName("DateTrained_TrainMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.DescriptionDetailedTrainMstr)
                    .HasColumnName("DescriptionDetailed_TrainMstr")
                    .HasColumnType("ntext");

                entity.Property(e => e.DescriptionShortTrainMstr)
                    .HasColumnName("DescriptionShort_TrainMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.LastUpdatedByTrainMstr)
                    .HasColumnName("LastUpdatedBy_TrainMstr")
                    .HasMaxLength(255);

                entity.Property(e => e.LastUpdatedConcurrencyIdTrainMstr).HasColumnName("LastUpdatedConcurrencyID_TrainMstr");

                entity.Property(e => e.LastUpdatedDateTrainMstr)
                    .HasColumnName("LastUpdatedDate_TrainMstr")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.ObjectModuleTrainMstr)
                    .HasColumnName("ObjectModule_TrainMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.TrainedByTrainMstr)
                    .HasColumnName("TrainedBy_TrainMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.TraineeTrainMstr)
                    .HasColumnName("Trainee_TrainMstr")
                    .HasMaxLength(50);

                entity.Property(e => e.UserPkTrainMstr)
                    .HasColumnName("UserPK_TrainMstr")
                    .HasMaxLength(50);
            });
        }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class UniversalMaster2
    {
        public UniversalMaster2()
        {
            TransactionHeader = new HashSet<TransactionHeader>();
        }

        public decimal CbdUm { get; set; }
        public decimal SysPkUm { get; set; }
        public decimal SysFkCollectorUm { get; set; }
        public decimal SysFkCoaslUm { get; set; }
        public decimal SysFkCustPreferredSalesAgentUm { get; set; }
        public decimal SysFkBranchUm { get; set; }
        public decimal SysFkCoaarUm { get; set; }
        public decimal SysFkCoaapUm { get; set; }
        public decimal SysFkCoacibUm { get; set; }
        public decimal SysFkCoavatUm { get; set; }
        public decimal SysFkCoaoutputTaxUm { get; set; }
        public decimal SysFkCoainputTaxUm { get; set; }
        public short? SysSeqUm { get; set; }
        public int? UserSeqUm { get; set; }
        public string UserPkUm { get; set; }
        public string UserPkseqUm { get; set; }
        public string UserPkseqMasterfileTypeUm { get; set; }
        public string UserPktypeUm { get; set; }
        public string LastUpdatedByUm { get; set; }
        public short? LastUpdatedConcurrencyIdUm { get; set; }
        public DateTime? LastUpdatedDateUm { get; set; }
        public string AccountNumUm { get; set; }
        public string AddressBillingUm { get; set; }
        public string AddressShippingUm { get; set; }
        public string AreaUm { get; set; }
        public decimal? BondAmountUm { get; set; }
        public string BranchTypeUm { get; set; }
        public string CheckNameUm { get; set; }
        public string ConfidentialityLevelUm { get; set; }
        public string ContactPersonUm { get; set; }
        public string ContactPersonPositionUm { get; set; }
        public string CustPreferredSalesAgentUm { get; set; }
        public string CustAssignedCollectorUm { get; set; }
        public string DeptUm { get; set; }
        public short? InactiveUm { get; set; }
        public short? IsConsignmentUm { get; set; }
        public short? IsVatUm { get; set; }
        public string ModuleUm { get; set; }
        public string ModuleRoleUm { get; set; }
        public string ModuleTypeUm { get; set; }
        public string ModuleUserPkUm { get; set; }
        public string NameUm { get; set; }
        public string NameSpeakUm { get; set; }
        public string NameInitialsUm { get; set; }
        public string ParticularsUm { get; set; }
        public string PictureFileNameUm { get; set; }
        public string CreditInfoFileNameUm { get; set; }
        public string CiinfoFileNameUm { get; set; }
        public string ReportNameUm { get; set; }
        public string SectionUm { get; set; }
        public string StatusUm { get; set; }
        public string TelNumBillingUm { get; set; }
        public string TelNumShippingUm { get; set; }
        public string TinvatnumberUm { get; set; }
        public string TypeUm { get; set; }
        public string UserPasswordUm { get; set; }
        public string TypeAcctConcatenatedUm { get; set; }
        public string UserFkBranchUm { get; set; }
        public decimal? SysFkUmUm { get; set; }
        public decimal? SysFkInvtyUm { get; set; }

        public virtual ICollection<TransactionHeader> TransactionHeader { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerInvty
    {
        public decimal SysPkLdgrInvty { get; set; }
        public decimal SysFkTransHLdgrInvty { get; set; }
        public decimal SysFkTransHslLdgrInvty { get; set; }
        public decimal SysFkCustomerLdgrInvty { get; set; }
        public decimal SysFkInvtyLdgrInvty { get; set; }
        public decimal SysFkLdgrInvtySysPkLdgrInvty { get; set; }
        public decimal SysFkInvtyBatchLdgrInvty { get; set; }
        public decimal SysFkSupplierLdgrInvty { get; set; }
        public short? SysSeqLdgrInvty { get; set; }
        public int? UserSeqLdgrInvty { get; set; }
        public string UserFkInvtyLdgrInvty { get; set; }
        public string UserFkInvtyBatchLdgrInvty { get; set; }
        public string UserFkInvtyPriceLdgrInvty { get; set; }
        public string UserFkAreaLdgrInvty { get; set; }
        public string UserFkBranchLdgrInvty { get; set; }
        public string UserFkWrseLdgrInvty { get; set; }
        public string LastUpdatedByLdgrInvty { get; set; }
        public short? LastUpdatedConcurrencyIdLdgrInvty { get; set; }
        public DateTime? LastUpdatedDateLdgrInvty { get; set; }
        public string ModuleLdgrInvty { get; set; }
        public decimal? BaseUnitQtyInLdgrInvty { get; set; }
        public decimal? BaseUnitQtyMultiplierLdgrInvty { get; set; }
        public decimal? BaseUnitQtyOutLdgrInvty { get; set; }
        public decimal? BaseUnitQtyReceivedBalanceLdgrInvty { get; set; }
        public decimal? CommissionAmountLdgrInvty { get; set; }
        public string CommissionRateLdgrInvty { get; set; }
        public decimal? DisplayQtyInLdgrInvty { get; set; }
        public decimal? DisplayQtyOutLdgrInvty { get; set; }
        public decimal? DisplayQtyServedLdgrInvty { get; set; }
        public string DisplayUnitOfMeasureLdgrInvty { get; set; }
        public decimal? DisplayUnitSellingLdgrInvty { get; set; }
        public decimal? DisplayUnitPurchaseLdgrInvty { get; set; }
        public string DisplayForeignSignLdgrInvty { get; set; }
        public decimal? DisplayForeignUnitSellingLdgrInvty { get; set; }
        public decimal? DisplayForeignUnitPurchaseLdgrInvty { get; set; }
        public decimal? DisplayForeignConversionRateLdgInvty { get; set; }
        public string DisplayCostCodeLdgrInvty { get; set; }
        public string DisplayDiscountingLdgrInvty { get; set; }
        public decimal? DiscountedUnitSellingLdgrInvty { get; set; }
        public decimal? DiscountedUnitPurchaseLdgrInvty { get; set; }
        public decimal? DisplaySubTotalInLdgrInvty { get; set; }
        public decimal? DisplaySubTotalOutLdgrInvty { get; set; }
        public decimal? ForeignDiscountedUnitSellingLdgrInvty { get; set; }
        public decimal? ForeignDiscountedUnitPurchaseLdgrInvty { get; set; }
        public decimal? ForeignSubTotalInLdgrInvty { get; set; }
        public decimal? ForeignSubTotalOutLdgrInvty { get; set; }
        public string DisplayDescriptionLdgrInvty { get; set; }
        public short? IsPostedToConsignRrLdgrInvty { get; set; }
        public short? IsPostedToConsignSalesLdgrInvty { get; set; }
        public string FormulaUsedInSubTotalLdgrInvty { get; set; }
        public string ManualComputedSubTotalLdgrInvty { get; set; }
        public string ParticularsLdgrInvty { get; set; }
        public decimal? PurchQtyCreditLdgrInvty { get; set; }
        public decimal? PurchQtyDebitLdgrInvty { get; set; }
        public decimal? PurchConsignQtyCreditLdgrInvty { get; set; }
        public decimal? PurchConsignQtyDebitLdgrInvty { get; set; }
        public decimal? SalesConsignQtyCreditLdgrInvty { get; set; }
        public decimal? SalesConsignQtyDebitLdgrInvty { get; set; }
        public string TransactionStatusLdgrInvty { get; set; }
        public string TransactionTypeLdgrInvty { get; set; }
        public decimal? UnitNetCostLdgrInvty { get; set; }
        public decimal? ConsignDisplayedBeginningConsignedQtyLdgrInvty { get; set; }
        public decimal? ConsignDisplayedConsignedQtyLdgrInvty { get; set; }
        public decimal? ConsignDisplayedSoldLdgrInvty { get; set; }
        public decimal? ConsignDisplayedDeclaredSoldLdgrInvty { get; set; }
        public decimal? ConsignSalesQtyAdjustLdgrInvty { get; set; }
        public decimal? ConsignDisplayedEndConsignedQtyLdgrInvty { get; set; }
        public string BaseUnitOfMeasureLdgrInvty { get; set; }
        public decimal? DisplaySubTotalAdjustLdgrInvty { get; set; }
        public decimal? StoreQtyAdjustLdgrInvty { get; set; }
        public decimal? BaseUnitQtyAdjustLdgrInvty { get; set; }
        public decimal SysFkInvtyPriceLdgrInvty { get; set; }
        public decimal? StoreQtyInLdgrInvty { get; set; }
        public decimal? StoreQtyOutLdgrInvty { get; set; }
        public short? IsPrintingDisabledLdgrInvty { get; set; }

        public virtual InventoryMaster2 SysFkInvtyLdgrInvtyNavigation { get; set; }
        public virtual TransactionHeader SysFkTransHLdgrInvtyNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class InventoryMaster2
    {
        public InventoryMaster2()
        {
            TransactionLedgerInvty = new HashSet<TransactionLedgerInvty>();
        }

        public decimal CbdInvty { get; set; }
        public decimal SysPkInvty { get; set; }
        public decimal SysFkBatchInvtyInvty { get; set; }
        public decimal SysFkCoapolicyInvty { get; set; }
        public decimal SysFkCoaapInvty { get; set; }
        public decimal SysFkCoaarInvty { get; set; }
        public decimal SysFkCoacostOfGoodsInvty { get; set; }
        public decimal SysFkCoainventoryInvty { get; set; }
        public decimal SysFkCoainventoryPcsgnInvty { get; set; }
        public decimal SysFkCoainventoryScsgnInvty { get; set; }
        public decimal SysFkCoainventoryPscsgnInvty { get; set; }
        public decimal SysFkCoapcsgnInvty { get; set; }
        public decimal SysFkCoapurchaseInvty { get; set; }
        public decimal SysFkCoareturnPurchaseInvty { get; set; }
        public decimal SysFkCoareturnSalesInvty { get; set; }
        public decimal SysFkCoasalesInvty { get; set; }
        public decimal SysFkCoascsgnInvty { get; set; }
        public decimal SysFkCoacompliSalesInvty { get; set; }
        public decimal SysFkCoacompliPurchaseInvty { get; set; }
        public decimal SysFkCoabranchPurchaseInvty { get; set; }
        public decimal SysFkDefaultDeptInvty { get; set; }
        public decimal SysFkDefaultReceiveUnitMeasureInvty { get; set; }
        public decimal SysFkDefaultReleaseUnitMeasureInvty { get; set; }
        public decimal SysFkDefaultWrseInvty { get; set; }
        public decimal SysFkLastPurchaseInvty { get; set; }
        public decimal SysFkLastSalesInvty { get; set; }
        public decimal SysFkPreferredSupplierInvty { get; set; }
        public decimal SysFkUmareaDefaultInvty { get; set; }
        public decimal SysFkUmsupplierDefaultInvty { get; set; }
        public decimal SysFkUmwarehouseDefaultInvty { get; set; }
        public decimal SysFkTransHInvty { get; set; }
        public int? UserSeqInvty { get; set; }
        public string UserPkInvty { get; set; }
        public string UserPkalternativeInvty { get; set; }
        public string UserPkseqInvty { get; set; }
        public string UserPktypeInvty { get; set; }
        public string UserFkBatchInvtyInvty { get; set; }
        public string UserFkDefaultDeptInvty { get; set; }
        public string UserFkDefaultWrseInvty { get; set; }
        public string LastUpdatedByInvty { get; set; }
        public short? LastUpdatedConcurrencyIdInvty { get; set; }
        public DateTime? LastUpdatedDateInvty { get; set; }
        public int? AverageDailyMovementInvty { get; set; }
        public decimal? AvgCostInvty { get; set; }
        public decimal? LatestArrivePriceInvty { get; set; }
        public decimal? LatestArrivePriceForeignInvty { get; set; }
        public DateTime? LatestArrivePriceAsOfInvty { get; set; }
        public decimal? LatestArriveQtyInvty { get; set; }
        public decimal? LatestPopriceInvty { get; set; }
        public decimal? LatestPopriceForeignInvty { get; set; }
        public DateTime? LatestPopriceAsOfInvty { get; set; }
        public decimal? LatestPoqtyInvty { get; set; }
        public string BarCodeInvty { get; set; }
        public string BaseUnitOfMeasureInvty { get; set; }
        public string BrandInvty { get; set; }
        public decimal? CurrentCostInvty { get; set; }
        public string CategoryInvty { get; set; }
        public string ClassificationInvty { get; set; }
        public string ColorInvty { get; set; }
        public string DescriptionInvty { get; set; }
        public string DescriptionSupplierInvty { get; set; }
        public string DescriptionSpeakInvty { get; set; }
        public string DescriptionShortInvty { get; set; }
        public string EnglishDimensionsInvty { get; set; }
        public string FlagInvty { get; set; }
        public string FormatInvty { get; set; }
        public string GroupInvty { get; set; }
        public string GroupPriceInvty { get; set; }
        public short? HasInvtySlInvty { get; set; }
        public string HtmlscriptInvty { get; set; }
        public short? IsPurchasedOnConsignmentInvty { get; set; }
        public short? LeadDaysInvty { get; set; }
        public string MadeInInvty { get; set; }
        public string MetricDimensionsInvty { get; set; }
        public string ModelInvty { get; set; }
        public string ModuleInvty { get; set; }
        public string ModuleUserPkInvty { get; set; }
        public string NextSubGroupInvty { get; set; }
        public decimal? MaximumStockQtyInvty { get; set; }
        public decimal? MaximumSalesConsignmentQtyInvty { get; set; }
        public decimal? OnOrderedQtyInvty { get; set; }
        public decimal? OrderqtyInvty { get; set; }
        public string ParticularsInvty { get; set; }
        public string PhasedOutInvty { get; set; }
        public string PictureFileNameInvty { get; set; }
        public decimal? PurchaseUnitBaseMultiplierInvty { get; set; }
        public string PurchaseUnitOfMeasureInvty { get; set; }
        public string RankInvty { get; set; }
        public int? RankInPurchaseAmountInvty { get; set; }
        public int? RankInQtyInvty { get; set; }
        public int? RankInSalesAmountInvty { get; set; }
        public string RankParticularsInvty { get; set; }
        public decimal? ReorderLevelInvty { get; set; }
        public decimal? RestockingQtyInvty { get; set; }
        public int? ShortageFromRestockingQtyInvty { get; set; }
        public string SpecificationInvty { get; set; }
        public string SpeedInvty { get; set; }
        public string StatusInvty { get; set; }
        public string StyleInvty { get; set; }
        public string SubCategoryInvty { get; set; }
        public string SubGroupInvty { get; set; }
        public string TypeInvty { get; set; }
        public string UpcskuInvty { get; set; }
        public string WhyNegativeQtyRemainingInvty { get; set; }
        public DateTime? YtdasOfInvty { get; set; }
        public decimal? YtdbaseQtyInInvty { get; set; }
        public decimal? YtdbaseQtyOutInvty { get; set; }
        public decimal? YtdbaseQtyBalInvty { get; set; }
        public decimal? YtdpurchasesInvty { get; set; }
        public decimal? YtdsalesInvty { get; set; }
        public decimal? BaseUnitQtyInvty { get; set; }
        public decimal? BaseUnitQtyLogInvty { get; set; }
        public decimal? SalesConsignQtyInvty { get; set; }
        public decimal? PurchConsignQtyInvty { get; set; }
        public decimal? PurchQtyInvty { get; set; }
        public string ShapeInvty { get; set; }
        public string SizeInvty { get; set; }
        public string CcodeInvty { get; set; }
        public string ArefInvty { get; set; }
        public string UserFkBranchInvty { get; set; }
        public decimal? PatronageRefundInvty { get; set; }
        public short? IsNonVatInvty { get; set; }
        public decimal? SysFkCoasalesDiscountInvty { get; set; }
        public decimal? SysFkCoapurchaseDiscountInvty { get; set; }
        public decimal? SysFkCoaappnInvty { get; set; }
        public decimal? UserPktimeStampInvty { get; set; }

        public virtual ICollection<TransactionLedgerInvty> TransactionLedgerInvty { get; set; }
    }
}

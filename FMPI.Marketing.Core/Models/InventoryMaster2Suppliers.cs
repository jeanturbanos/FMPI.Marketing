using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class InventoryMaster2Suppliers
    {
        public decimal SysPkInvtySupl { get; set; }
        public decimal SysFkInvtyInvtySupl { get; set; }
        public decimal SysFkUmInvtySupl { get; set; }
        public short? SysSeqInvtySupl { get; set; }
        public int? UserSeqInvtySupl { get; set; }
        public string LastUpdatedByInvtySupl { get; set; }
        public short? LastUpdatedConcurrencyIdInvtySupl { get; set; }
        public DateTime? LastUpdatedDateInvtySupl { get; set; }
        public string ModuleInvtySupl { get; set; }
        public decimal? MarketPriceLocalInvtySupl { get; set; }
        public decimal? MarketPriceForeignInvtySupl { get; set; }
        public string DiscountInvtySupl { get; set; }
        public DateTime? DateLatestReceivedInvtySupl { get; set; }
        public decimal? PurchasePriceLatestLocalInvtySupl { get; set; }
        public decimal? PurchasePriceLatestForeignInvtySupl { get; set; }
        public decimal? PurchasePriceAverageLocalInvtySupl { get; set; }
        public decimal? PurchasePriceAverageForeignInvtySupl { get; set; }
        public short? IsPreferredInvtySupl { get; set; }
    }
}

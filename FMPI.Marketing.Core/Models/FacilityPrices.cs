using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class FacilityPrices
    {
        public decimal SysPkFaclPrice { get; set; }
        public decimal SysFkFaclFaclPrice { get; set; }
        public short? SysSeqFaclPrice { get; set; }
        public int? UserSeqFaclPrice { get; set; }
        public short? LastUpdatedConcurrencyIdFaclPrice { get; set; }
        public DateTime? LastUpdatedDateFaclPrice { get; set; }
        public string LastUpdatedByFaclPrice { get; set; }
        public string UserPkFaclPrice { get; set; }
        public DateTime? DateEffectiveFaclPrice { get; set; }
        public decimal? HoursFaclPrice { get; set; }
        public string IsFaclPrice { get; set; }
        public string ModuleFaclPrice { get; set; }
        public string PromoRemarksFaclPrice { get; set; }
        public decimal? RegularPriceFaclPrice { get; set; }
        public string DiscountFaclPrice { get; set; }
        public decimal? SellingPriceFaclPrice { get; set; }
        public decimal? SellingPriceMinimumFaclPrice { get; set; }
        public decimal? ServiceChargeFaclPrice { get; set; }
        public decimal? TaxFaclPrice { get; set; }
        public string StatusFaclPrice { get; set; }
        public string TypeFaclPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderSalesPurchOrder
    {
        public decimal SysPkSalePurchOrd { get; set; }
        public decimal SysFkTransHSalePurchOrd { get; set; }
        public short? SysSeqSalePurchOrd { get; set; }
        public string UserFkInvoicesSalePurchOrd { get; set; }
        public int? UserSeqSalePurchOrd { get; set; }
        public string LastUpdatedBySalePurchOrd { get; set; }
        public short? LastUpdatedConcurrencyIdSalePurchOrd { get; set; }
        public DateTime? LastUpdatedDateSalePurchOrd { get; set; }
        public string ModuleSalePurchOrd { get; set; }
        public DateTime? DateDeliverOnSalePurchOrd { get; set; }
        public DateTime? DateDueSalePurchOrd { get; set; }
        public DateTime? DateFirstDueSalePurchOrd { get; set; }
        public short? DaysPastDueSalePurchOrd { get; set; }
        public string DeliveryAddressSalePurchOrd { get; set; }
        public string DeliveryInstructionSalePurchOrd { get; set; }
        public string DeliveryVesselSalePurchOrd { get; set; }
        public string DeliveryViaSalePurchOrd { get; set; }
        public decimal? ForeignSignSalePurchOrd { get; set; }
        public decimal? ForeignConversionRateSalePurchOrd { get; set; }
        public decimal? FreightChargeSalePurchOrd { get; set; }
        public short? HasOtherPaymentsSalePurchOrd { get; set; }
        public short? InvoiceReturnedSalePurchOrd { get; set; }
        public string IsSalePurchOrd { get; set; }
        public decimal? SalesDiscountSalePurchOrd { get; set; }
        public decimal? SalesGrossForeignAmountSalePurchOrd { get; set; }
        public decimal? SalesGrossLocalAmountSalePurchOrd { get; set; }
        public decimal? SalesNetForeignAmountSalePurchOrd { get; set; }
        public decimal? SalesNetLocalAmountSalePurchOrd { get; set; }
        public decimal? TaxLocalAmountSalePurchOrd { get; set; }
        public decimal? TaxLocalRateSalePurchOrd { get; set; }
        public string SalesPurchTypeSalePurchOrd { get; set; }
        public string StatusDueSalePurchOrd { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderSalesPurch
    {
        public decimal SysPkSalePurch { get; set; }
        public decimal SysFkAdvanceOrderSalesPurch { get; set; }
        public decimal SysFkTransHSalePurch { get; set; }
        public decimal SysFkTransH2SalePurch { get; set; }
        public decimal SysFkCoaarSalePurch { get; set; }
        public decimal SysFkCoaapSalePurch { get; set; }
        public decimal SysFkCoacashPaymentSalePurch { get; set; }
        public decimal SysFkCoacheckPaymentSalePurch { get; set; }
        public decimal SysFkCoacrCardPaymentSalePurch { get; set; }
        public decimal SysFkCoamemoPaymentSalePurch { get; set; }
        public decimal SysFkLdgrEntryMemoPaymentSalePurch { get; set; }
        public decimal SysFkSalePurchParentSalePurch { get; set; }
        public decimal SysFkTransHmemoSalePurch { get; set; }
        public decimal SysFkUmbankCashPaymentSalePurch { get; set; }
        public decimal SysFkUmbankCheckPaymentSalePurch { get; set; }
        public decimal SysFkUmbankCrCardPaymentSalePurch { get; set; }
        public decimal SysFkUmmemoPaymentSalePurch { get; set; }
        public short? SysSeqSalePurch { get; set; }
        public int? UserSeqSalePurch { get; set; }
        public string UserFkInvoicesSalePurch { get; set; }
        public string LastUpdatedBySalePurch { get; set; }
        public short? LastUpdatedConcurrencyIdSalePurch { get; set; }
        public DateTime? LastUpdatedDateSalePurch { get; set; }
        public string ModuleSalePurch { get; set; }
        public decimal? AmountCoaSalePurch { get; set; }
        public decimal? AmountCoaforeignSalePurch { get; set; }
        public decimal? AramountSalePurch { get; set; }
        public decimal? BondAmountSalePurch { get; set; }
        public decimal? CashPaymentAmountSalePurch { get; set; }
        public decimal? CashRefundAmountSalePurch { get; set; }
        public decimal? CheckAmountSalePurch { get; set; }
        public decimal? CheckAmountClrSalePurch { get; set; }
        public decimal? CheckAmountPdcSalePurch { get; set; }
        public string CheckBankBranchSalePurch { get; set; }
        public DateTime? CheckDateSalePurch { get; set; }
        public string CheckNumSalePurch { get; set; }
        public string CheckStatusSalePurch { get; set; }
        public string CreditCardBankSalePurch { get; set; }
        public decimal? CreditCardCustomerAmountSalePurch { get; set; }
        public DateTime? CreditCardExpiryDateSalePurch { get; set; }
        public string CreditCardNumSalePurch { get; set; }
        public string CreditCardTypeSalePurch { get; set; }
        public string CreditCardVerificationNumSalePurch { get; set; }
        public decimal? CreditLineSalePurch { get; set; }
        public DateTime? DateDeliverOnSalePurch { get; set; }
        public DateTime? DateDueSalePurch { get; set; }
        public DateTime? DateFirstDueSalePurch { get; set; }
        public short? DaysPastDueSalePurch { get; set; }
        public string DeliveryAddressSalePurch { get; set; }
        public string DeliveryInstructionSalePurch { get; set; }
        public string DeliveryVesselSalePurch { get; set; }
        public string DeliveryViaSalePurch { get; set; }
        public decimal? DuePerInstallmentSalePurch { get; set; }
        public decimal? ForeignSignSalePurch { get; set; }
        public decimal? ForeignConversionRateSalePurch { get; set; }
        public decimal? FreightChargeSalePurch { get; set; }
        public short? HasOtherChargesSalePurch { get; set; }
        public short? HasOtherPaymentsSalePurch { get; set; }
        public short? InvoiceReturnedSalePurch { get; set; }
        public string IsSalePurch { get; set; }
        public decimal? MiscAmountSalePurch { get; set; }
        public decimal? MemoAmountSalePurch { get; set; }
        public decimal? NonSalesTotalSalePurch { get; set; }
        public string NumOfInstallmentSalePurch { get; set; }
        public decimal? OutstandingDueSalePurch { get; set; }
        public string PaymentTypeSalePurch { get; set; }
        public decimal? PurchaseDiscountSalePurch { get; set; }
        public string PurchaseDiscountPercentSalePurch { get; set; }
        public decimal? PurchaseGrossForeignAmountSalePurch { get; set; }
        public decimal? PurchaseGrossLocalAmountSalePurch { get; set; }
        public decimal? PurchaseNetForeignAmountSalePurch { get; set; }
        public decimal? PurchaseNetLocalAmountSalePurch { get; set; }
        public decimal? SalesDiscountSalePurch { get; set; }
        public string SalesDiscountPercentSalePurch { get; set; }
        public decimal? SalesGrossForeignAmountSalePurch { get; set; }
        public decimal? SalesGrossLocalAmountSalePurch { get; set; }
        public decimal? SalesNetForeignAmountSalePurch { get; set; }
        public decimal? SalesNetLocalAmountSalePurch { get; set; }
        public decimal? TaxLocalAmountSalePurch { get; set; }
        public decimal? TaxLocalRateSalePurch { get; set; }
        public short? TermsInDaysSalePurch { get; set; }
        public short? TermsInMonthsSalePurch { get; set; }
        public short? TermsInYearsSalePurch { get; set; }
        public string SalesPurchTypeSalePurch { get; set; }
        public string StatusDueSalePurch { get; set; }
        public string SalesReturnTypeSalePurch { get; set; }
        public string DiscountPercentSalePurch { get; set; }
        public string ReturnTypeSalePurch { get; set; }
        public string ReturnTypeSalesPurch { get; set; }
    }
}

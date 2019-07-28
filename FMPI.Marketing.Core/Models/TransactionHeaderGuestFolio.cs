using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderGuestFolio
    {
        public decimal SysPkGtrans { get; set; }
        public decimal SysFkGtransParentGtrans { get; set; }
        public decimal SysFkTransHGtrans { get; set; }
        public short? SysSeqGtrans { get; set; }
        public int? UserSeqGtrans { get; set; }
        public short? LastUpdatedConcurrencyIdGtrans { get; set; }
        public DateTime? LastUpdatedDateGtrans { get; set; }
        public string LastUpdatedByGtrans { get; set; }
        public decimal SysFkAgentGtrans { get; set; }
        public decimal SysFkInvtyGtrans { get; set; }
        public decimal SysFkFaclGtrans { get; set; }
        public decimal SysFkGregGtrans { get; set; }
        public decimal SysFkGcompGtrans { get; set; }
        public decimal SysFkGfaclGtrans { get; set; }
        public decimal SysFkSourceDocumentGtrans { get; set; }
        public decimal SysFkLedgerTransHGtrans { get; set; }
        public string UserFkPaymentModeGtrans { get; set; }
        public string UserFkFaclPriceGtrans { get; set; }
        public string UserPkGtrans { get; set; }
        public decimal? AmountTotalDebitGtrans { get; set; }
        public decimal? AmountTotalCreditGtrans { get; set; }
        public decimal? AmountChargesGtrans { get; set; }
        public decimal? AmountChargesTransferGtrans { get; set; }
        public decimal? AmountPaymentsGtrans { get; set; }
        public decimal? AmountPaymentsPdcGtrans { get; set; }
        public decimal? AmountRefundsGtrans { get; set; }
        public decimal? AmountBalanceGtrans { get; set; }
        public decimal? AmountCommissionGtrans { get; set; }
        public string AmountCommissionRateGtrans { get; set; }
        public decimal? AmountTaxGtrans { get; set; }
        public string AmountTaxRateGtrans { get; set; }
        public decimal? AmountRushGtrans { get; set; }
        public decimal? AmountServiceChargeGtrans { get; set; }
        public string ByFrontOfficeGtrans { get; set; }
        public string ByWaiterGtrans { get; set; }
        public string ByHousekeepingGtrans { get; set; }
        public string ByCashierGtrans { get; set; }
        public string CreditCardCheckNumGtrans { get; set; }
        public string CreditCardCheckTypeGtrans { get; set; }
        public string CreditCardCheckBankGtrans { get; set; }
        public DateTime? DateIssueGtrans { get; set; }
        public DateTime? TimeIssueGtrans { get; set; }
        public DateTime? DateTimeStartGtrans { get; set; }
        public DateTime? DateTimeEndGtrans { get; set; }
        public DateTime? DateTimeCutOffGtrans { get; set; }
        public decimal? DisplayQtyBeginGtrans { get; set; }
        public decimal? DisplayQtyAdditionalGtrans { get; set; }
        public decimal? DisplayQtyDamagedGtrans { get; set; }
        public decimal? DisplayQtyEndGtrans { get; set; }
        public decimal? DisplayQtyInGtrans { get; set; }
        public decimal? DisplayQtyOutGtrans { get; set; }
        public decimal? DisplayUnitMeasureGtrans { get; set; }
        public decimal? DisplayUnitPriceInGtrans { get; set; }
        public decimal? DisplayUnitPriceOutGtrans { get; set; }
        public string DisplayDiscountGtrans { get; set; }
        public decimal? DiscountedUnitPriceInGtrans { get; set; }
        public decimal? DiscountedUnitPriceOutGtrans { get; set; }
        public decimal? DisplaySubTotalInGtrans { get; set; }
        public decimal? DisplaySubTotalOutGtrans { get; set; }
        public short? IsServiceChargedGtrans { get; set; }
        public short? IsRushedGtrans { get; set; }
        public string IsGtrans { get; set; }
        public string ModuleGtrans { get; set; }
        public string ModuleTypeGtrans { get; set; }
        public string ModuleSubTypeGtrans { get; set; }
        public string PaymentForGtrans { get; set; }
        public string PaymentModeGtrans { get; set; }
        public string ReferenceDocNumGtrans { get; set; }
        public string ReferenceDocByGtrans { get; set; }
        public decimal? ReferenceDocAmountGtrans { get; set; }
        public DateTime? ReferenceDocDateGtrans { get; set; }
    }
}

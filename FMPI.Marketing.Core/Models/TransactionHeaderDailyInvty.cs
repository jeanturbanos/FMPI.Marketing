using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderDailyInvty
    {
        public decimal SysPkDlyInvty { get; set; }
        public decimal SysFkTransHDlyInvty { get; set; }
        public string LastUpdatedByDlyInvty { get; set; }
        public short? LastUpdatedConcurrencyIdDlyInvty { get; set; }
        public DateTime? LastUpdatedDateCxi { get; set; }
        public decimal? CashActualDlyInvty { get; set; }
        public decimal? CashActualBreakdownCoinsDlyInvty { get; set; }
        public decimal? CashActualBreakdownBillsDlyInvty { get; set; }
        public decimal? CashActualBreakdownChecksDlyInvty { get; set; }
        public string CashActualBreakdownChecksDetailsDlyInvty { get; set; }
        public decimal? CashExpectedDlyInvty { get; set; }
        public decimal? CashBeginDlyInvty { get; set; }
        public decimal? CashEndDlyInvty { get; set; }
        public decimal? CashOutDlyInvty { get; set; }
        public decimal? CreditCardDlyInvty { get; set; }
        public decimal? DownPaymentsDlyInvty { get; set; }
        public decimal? ExpensesFuelDlyInvty { get; set; }
        public decimal? ExpensesItemDlyInvty { get; set; }
        public decimal? ExpensesTotalDlyInvty { get; set; }
        public decimal? SalesArtotalDlyInvty { get; set; }
        public decimal? SalesCashTotalDlyInvty { get; set; }
        public decimal? SalesFuelCashDlyInvty { get; set; }
        public decimal? SalesFuelArDlyInvty { get; set; }
        public decimal? SalesFuelTotalDlyInvty { get; set; }
        public decimal? SalesItemCashDlyInvty { get; set; }
        public decimal? SalesItemArDlyInvty { get; set; }
        public decimal? SalesItemTotalDlyInvty { get; set; }
        public decimal? SalesGrandTotalDlyInvty { get; set; }
        public decimal? ShortExcessDlyInvty { get; set; }
        public decimal? ServicesCashDlyInvty { get; set; }
    }
}

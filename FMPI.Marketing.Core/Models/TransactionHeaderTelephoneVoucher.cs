using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderTelephoneVoucher
    {
        public decimal SysPkTelVchr { get; set; }
        public decimal SysFkCoaarTelVchr { get; set; }
        public decimal SysFkTransHTelVchr { get; set; }
        public decimal SysFkTransH2TelVchr { get; set; }
        public short? SysSeqTelVchr { get; set; }
        public int? UserSeqTelVchr { get; set; }
        public string UserPkTelVchr { get; set; }
        public string LastUpdatedByTelVchr { get; set; }
        public short? LastUpdatedConcurrencyIdTelVchr { get; set; }
        public DateTime? LastUpdatedDateTelVchr { get; set; }
        public string ModuleTelVchr { get; set; }
        public string ParticularsTelVchr { get; set; }
        public string PictureFileNameTelVchr { get; set; }
        public string StatusTelVchr { get; set; }
        public string TypeTelVchr { get; set; }
        public decimal? TotalDetailsChargesTelVchr { get; set; }
        public decimal? GovtTaxTelVchr { get; set; }
        public decimal? GovtTaxRateTelVchr { get; set; }
        public decimal? TotalBalanceTelVchr { get; set; }
        public decimal? TotalPaymentsTelVchr { get; set; }
        public decimal? HandlingFeeTelVchr { get; set; }
        public decimal? HandlingFeeRateTelVchr { get; set; }
        public string AccountDocumentNameTelVchr { get; set; }
        public string AccountDocumentAddressTelVchr { get; set; }
        public DateTime? TimeTelVchr { get; set; }
        public decimal? TotalDetailsQtyTelVchr { get; set; }
        public string WaiterByTelVchr { get; set; }
        public string TrunkLineNumTelVchr { get; set; }
        public decimal? TotalChargesTelVchr { get; set; }
    }
}

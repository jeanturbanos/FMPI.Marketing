using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderStockTransfer
    {
        public decimal SysPkStkXfer { get; set; }
        public decimal SysFkTransHStkXfer { get; set; }
        public decimal SysFkAccountStkXfer { get; set; }
        public decimal SysFkInChargeStkXfer { get; set; }
        public short? SysSeqStkXfer { get; set; }
        public int? UserSeqStkXfer { get; set; }
        public short? LastUpdatedConcurrencyIdStkXfer { get; set; }
        public DateTime? LastUpdatedDateStkXfer { get; set; }
        public string LastUpdatedByStkXfer { get; set; }
        public string ModuleStkXfer { get; set; }
        public string AccountNameStkXfer { get; set; }
        public string AccountBillingParticularsStkXfer { get; set; }
        public string AccountContactPersonAndPositionStkXfer { get; set; }
        public string ApprovedByStkXfer { get; set; }
        public string AreaStkXfer { get; set; }
        public string CheckedByStkXfer { get; set; }
        public DateTime? DateDeliverOnStkXfer { get; set; }
        public string DeliveryAddressStkXfer { get; set; }
        public string DeliveryInstructionStkXfer { get; set; }
        public string DeliveryVesselStkXfer { get; set; }
        public string DeliveryViaStkXfer { get; set; }
        public decimal? FreightChargeStkXfer { get; set; }
        public string InChargedByStkXfer { get; set; }
        public string PreparedByStkXfer { get; set; }
        public string PreparedByDutyShiftStkXfer { get; set; }
        public short? StockReceivedStkXfer { get; set; }
    }
}

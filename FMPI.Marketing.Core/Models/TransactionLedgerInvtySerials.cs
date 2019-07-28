using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerInvtySerials
    {
        public decimal SysPkLdgrInvtySerial { get; set; }
        public decimal SysFkTransHldgrInvtyLdgrInvtySerial { get; set; }
        public decimal SysFkLdgrInvtyLdgrInvtySerial { get; set; }
        public decimal SysFkInvtyLdgrInvtySerial { get; set; }
        public string BarCodeLdgrInvtySerial { get; set; }
        public decimal? QtyLdgrInvtySerial { get; set; }
        public string SerialLdgrInvtySerial { get; set; }
        public string StatusLdgrInvtySerial { get; set; }
        public DateTime? DateTimeReleasedLdgrInvtySerial { get; set; }
        public DateTime? DateTimeReceivedLdgrInvtySerial { get; set; }
        public decimal? HoursDifferenceLdgrInvtySerial { get; set; }
        public string InChargeByLdgrInvtySerial { get; set; }
        public decimal? StatusPercentLdgrInvtySerial { get; set; }
        public string UserPkLdgrInvtySerial { get; set; }
        public decimal? UserSeqLdgrInvtySerial { get; set; }
        public short? LastUpdatedConcurrencyIdLdgrInvtySerial { get; set; }
        public DateTime? LastUpdatedDateLdgrInvtySerial { get; set; }
        public string LastUpdatedByLdgrInvtySerial { get; set; }
    }
}

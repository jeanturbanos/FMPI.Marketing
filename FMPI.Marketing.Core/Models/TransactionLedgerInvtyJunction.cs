using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionLedgerInvtyJunction
    {
        public decimal SysPkLdgrInvtyJ { get; set; }
        public decimal SysFkPostedFromLdgrInvtyJ { get; set; }
        public decimal SysFkPostedToLdgrInvtyJ { get; set; }
        public string LastUpdatedByLdgrInvtyJ { get; set; }
        public short? LastUpdatedConcurrencyIdLdgrInvtyJ { get; set; }
        public DateTime? LastUpdatedDateLdgrInvtyJ { get; set; }
    }
}

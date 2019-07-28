using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class GuestRegistrationFaclBlocking
    {
        public decimal SysPkGfaclB { get; set; }
        public decimal SysFkGregGfaclB { get; set; }
        public decimal SysFkGfaclGfaclB { get; set; }
        public decimal SysFkFaclGfaclB { get; set; }
        public short? SysSeqGfaclB { get; set; }
        public DateTime? DateBlockedGfaclB { get; set; }
        public short? DayCountGfaclB { get; set; }
        public DateTime? HourBlockedStartGfaclB { get; set; }
        public DateTime? HourBlockedEndGfaclB { get; set; }
        public decimal? HourBlockedTotalGfaclB { get; set; }
        public short? LastUpdatedConcurrencyIdGfaclB { get; set; }
        public DateTime? LastUpdatedDateGfaclB { get; set; }
        public string LastUpdatedByGfaclB { get; set; }
    }
}

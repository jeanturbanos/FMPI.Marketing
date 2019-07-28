using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterHotel
    {
        public decimal SysPkPmhotel { get; set; }
        public decimal SysFkPmPmhotel { get; set; }
        public short? SysSeqPmhotel { get; set; }
        public int? UserSeqPmhotel { get; set; }
        public string UserPkPmhotel { get; set; }
        public string LastUpdatedByPmhotel { get; set; }
        public short? LastUpdatedConcurrencyIdPmhotel { get; set; }
        public DateTime? LastUpdatedDatePmhotel { get; set; }
        public string ModulePmhotel { get; set; }
        public short? IsDefaultPmhotel { get; set; }
        public string TimeAccountingCutOffPmhotel { get; set; }
        public string TimeEarlyCheckInPmhotel { get; set; }
        public string TimeCheckOutPmhotel { get; set; }
        public string TimeCheckOutExtensionPmhotel { get; set; }
        public string TimeHalfRateStartPmhotel { get; set; }
        public string TimeHalfRateEndPmhotel { get; set; }
        public string StatusPmhotel { get; set; }
        public string TypePmhotel { get; set; }
    }
}

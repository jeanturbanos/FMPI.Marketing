using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterSalaryRate
    {
        public decimal SysPkPmslryRte { get; set; }
        public decimal SysFkPmPmslryRte { get; set; }
        public decimal SysFkPmtblSysSssPmslryRte { get; set; }
        public decimal SysFkPmtblSysPagibigPmslryRte { get; set; }
        public decimal SysFkPmtblSysPhilhealthPmslryRte { get; set; }
        public decimal SysFkPmtblSysWtaxPmslryRte { get; set; }
        public short? SysSeqPmslryRte { get; set; }
        public int? UserSeqPmslryRte { get; set; }
        public string UserPkPmslryRte { get; set; }
        public string LastUpdatedByPmslryRte { get; set; }
        public short? LastUpdatedConcurrencyIdPmslryRte { get; set; }
        public DateTime? LastUpdatedDatePmslryRte { get; set; }
        public string ModulePmslryRte { get; set; }
        public decimal? HoursPerDayPmslryRte { get; set; }
        public decimal? RatePerMonthPmslryRte { get; set; }
        public decimal? RatePerDayPmslryRte { get; set; }
        public decimal? RatePerHourPmslryRte { get; set; }
        public decimal? RateOtpercentagePmslryRte { get; set; }
        public decimal? RateLegalHolidayPercentagePmslryRte { get; set; }
        public decimal? RateSpecialHolidayPercentagePmslryRte { get; set; }
        public decimal? MaximumCaperWeekPmslryRte { get; set; }
        public string StatusPmslryRte { get; set; }
        public string TypePmslryRte { get; set; }
    }
}

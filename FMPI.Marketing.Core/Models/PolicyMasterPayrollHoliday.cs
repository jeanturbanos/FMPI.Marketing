using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterPayrollHoliday
    {
        public decimal SysPkPmholiday { get; set; }
        public decimal SysFkPmPmholiday { get; set; }
        public short? SysSeqPmholiday { get; set; }
        public int? UserSeqPmholiday { get; set; }
        public string UserPkPmholiday { get; set; }
        public string LastUpdatedByPmholiday { get; set; }
        public short? LastUpdatedConcurrencyIdPmholiday { get; set; }
        public DateTime? LastUpdatedDatePmholiday { get; set; }
        public string ModulePmholiday { get; set; }
        public DateTime? DateOfHolidayPmholiday { get; set; }
        public string DescriptionPmholiday { get; set; }
        public string TypePmholiday { get; set; }
    }
}

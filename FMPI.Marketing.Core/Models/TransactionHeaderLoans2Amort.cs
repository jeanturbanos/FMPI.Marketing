using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderLoans2Amort
    {
        public decimal SysPkTransHloanAmrt { get; set; }
        public decimal SysFkTransHTransHloanAmrt { get; set; }
        public decimal SysFkTransHloanTransHloanAmrt { get; set; }
        public decimal SysFkTransHloanAmrtParentTransHloanAmrt { get; set; }
        public short? SysSeqTransHloanAmrt { get; set; }
        public int? UserSeqTransHloanAmrt { get; set; }
        public string LastUpdatedByTransHloanAmrt { get; set; }
        public short? LastUpdatedConcurrencyIdTransHloanAmrt { get; set; }
        public DateTime? LastUpdatedDateTransHloanAmrt { get; set; }
        public string ModuleTransHloanAmrt { get; set; }
        public DateTime? DateDueTransHloanAmrt { get; set; }
        public int? DayNumTransHloanAmrt { get; set; }
        public decimal? InterestDueClrTransHloanAmrt { get; set; }
        public decimal? InterestRunBalTransHloanAmrt { get; set; }
        public short? IsHolidayTransHloanAmrt { get; set; }
        public decimal? MiscDueClrTransHloanAmrt { get; set; }
        public decimal? MiscRunBalTransHloanAmrt { get; set; }
        public decimal? PrincipalDueClrTransHloanAmrt { get; set; }
        public decimal? PrincipalRunBalTransHloanAmrt { get; set; }
        public decimal? SavingsDaysCountTransHloanAmrt { get; set; }
        public decimal? SavingsDuePerDayTransHloanAmrt { get; set; }
        public decimal? SavingsDueClrTransHloanAmrt { get; set; }
        public decimal? TotalDueClrTransHloanAmrt { get; set; }
        public decimal? TotalRunBalTransHloanAmrt { get; set; }
        public string WeekdayTransHloanAmrt { get; set; }
    }
}

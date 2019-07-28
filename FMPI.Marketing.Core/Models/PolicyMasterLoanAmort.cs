using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMasterLoanAmort
    {
        public decimal SysPkPmloanAmrt { get; set; }
        public decimal SysFkPmPmloanAmrt { get; set; }
        public decimal SysFkPmloanPmloanAmrt { get; set; }
        public decimal SysFkPmloanAmrtParentPmloanAmrt { get; set; }
        public short? SysSeqPmloanAmrt { get; set; }
        public int? UserSeqPmloanAmrt { get; set; }
        public string LastUpdatedByPmloanAmrt { get; set; }
        public short? LastUpdatedConcurrencyIdPmloanAmrt { get; set; }
        public DateTime? LastUpdatedDatePmloanAmrt { get; set; }
        public string ModulePmloanAmrt { get; set; }
        public int? DayNumPmloanAmrt { get; set; }
        public decimal? InterestDueClrPmloanAmrt { get; set; }
        public decimal? InterestRunBalPmloanAmrt { get; set; }
        public decimal? MiscDueClrPmloanAmrt { get; set; }
        public decimal? MiscRunBalPmloanAmrt { get; set; }
        public decimal? PrincipalDueClrPmloanAmrt { get; set; }
        public decimal? PrincipalRunBalPmloanAmrt { get; set; }
        public decimal? SavingsDaysCountPmloanAmrt { get; set; }
        public decimal? SavingsDuePerDayPmloanAmrt { get; set; }
        public decimal? SavingsDueClrPmloanAmrt { get; set; }
        public decimal? TotalDueClrPmloanAmrt { get; set; }
        public decimal? TotalRunBalPmloanAmrt { get; set; }
    }
}

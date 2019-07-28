using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class FranchiseSocioEconomic
    {
        public long SysPkFrchSeco { get; set; }
        public long SysFkFrchMstrFrchSeco { get; set; }
        public short? SysSeqFrchSeco { get; set; }
        public int? UserSeqFrchSeco { get; set; }
        public string UserPkFrchSeco { get; set; }
        public string LastUpdatedByFrchSeco { get; set; }
        public short? LastUpdatedConcurrencyIdFrchSeco { get; set; }
        public DateTime? LastUpdatedDateFrchSeco { get; set; }
        public string ModuleFrchSeco { get; set; }
        public string AreaFrchSeco { get; set; }
        public decimal? AvgIncomeFrchSeco { get; set; }
        public int? DistanceKmFrchSeco { get; set; }
        public long? HouseholdFrchSeco { get; set; }
        public string NameFrchSeco { get; set; }
        public string PopulationFrchSeco { get; set; }
        public string ProductFrchSeco { get; set; }
        public string ParticularsFrchSeco { get; set; }
        public string PictureFileNameFrchSeco { get; set; }
        public string StatusFrchSeco { get; set; }
        public string TypeFrchSeco { get; set; }
        public string YearFrchSeco { get; set; }
    }
}

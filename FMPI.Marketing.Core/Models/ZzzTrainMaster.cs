using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ZzzTrainMaster
    {
        public decimal SysPkTrainMstr { get; set; }
        public string UserPkTrainMstr { get; set; }
        public string LastUpdatedByTrainMstr { get; set; }
        public short? LastUpdatedConcurrencyIdTrainMstr { get; set; }
        public DateTime? LastUpdatedDateTrainMstr { get; set; }
        public string ObjectModuleTrainMstr { get; set; }
        public string DescriptionShortTrainMstr { get; set; }
        public string DescriptionDetailedTrainMstr { get; set; }
        public string TrainedByTrainMstr { get; set; }
        public string TraineeTrainMstr { get; set; }
        public DateTime? DateTrainedTrainMstr { get; set; }
    }
}

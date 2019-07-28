using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ZzzFormMasterSystem
    {
        public decimal SysPkFrmMstr { get; set; }
        public string UserPkFrmMstr { get; set; }
        public string LastUpdatedByFrmMstr { get; set; }
        public short? LastUpdatedConcurrencyIdFrmMstr { get; set; }
        public DateTime? LastUpdatedDateFrmMstr { get; set; }
        public string DescriptionFrmMstr { get; set; }
        public string MenuCaptionFrmMstr { get; set; }
    }
}

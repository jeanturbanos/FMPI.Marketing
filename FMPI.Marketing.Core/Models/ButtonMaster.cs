using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class ButtonMaster
    {
        public decimal SysPkBtnMstr { get; set; }
        public string UserPkBtnMstr { get; set; }
        public string LastUpdatedByBtnMstr { get; set; }
        public short? LastUpdatedConcurrencyIdBtnMstr { get; set; }
        public DateTime? LastUpdatedDateBtnMstr { get; set; }
        public string ModuleBtnMstr { get; set; }
        public string CaptionBtnMstr { get; set; }
        public int? ColorBtnMstr { get; set; }
        public int? Color2BtnMstr { get; set; }
        public string DescriptionBtnMstr { get; set; }
        public string FormControlNameBtnMstr { get; set; }
        public string MenuCaptionBtnMstr { get; set; }
        public string PathFileNameBtnMstr { get; set; }
        public string PictureFileNameBtnMstr { get; set; }
        public string ToolTipTextBtnMstr { get; set; }
    }
}

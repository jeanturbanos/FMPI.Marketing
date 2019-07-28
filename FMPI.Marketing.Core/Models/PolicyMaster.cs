using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class PolicyMaster
    {
        public decimal CbdPm { get; set; }
        public decimal SysPkPm { get; set; }
        public decimal SysFkPmparentPm { get; set; }
        public short? SysSeqPm { get; set; }
        public int? UserSeqPm { get; set; }
        public int? SequencePkPm { get; set; }
        public string UserPkPm { get; set; }
        public string LastUpdatedByPm { get; set; }
        public short? LastUpdatedConcurrencyIdPm { get; set; }
        public DateTime? LastUpdatedDatePm { get; set; }
        public short? IsDefaultPm { get; set; }
        public string ModulePm { get; set; }
        public DateTime? DateDefinedPm { get; set; }
        public DateTime? DateEffectivePm { get; set; }
        public string DescriptionPm { get; set; }
        public string ParticularsPm { get; set; }
        public string PictureFileNamePm { get; set; }
        public string StatusPm { get; set; }
        public string TypePm { get; set; }
    }
}

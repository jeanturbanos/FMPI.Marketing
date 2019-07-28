using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderShipping
    {
        public decimal SysPkTransHship { get; set; }
        public decimal SysFkShipperTransHship { get; set; }
        public decimal SysFkVesselTransHship { get; set; }
        public string LastUpdatedByTransHship { get; set; }
        public short? LastUpdatedConcurrencyIdTransHship { get; set; }
        public DateTime? LastUpdatedDateTransHship { get; set; }
        public string UserPkShipperTransHship { get; set; }
        public string UserPkVesselTransHship { get; set; }
        public string ShipmentInChargeByTransHship { get; set; }
        public string BillofLadingNumTransHship { get; set; }
        public decimal? BillofLadingAmountTransHship { get; set; }
        public string ContainerNumTransHship { get; set; }
        public string ContainerSealNumTransHship { get; set; }
        public DateTime? DateShippedTransHship { get; set; }
        public string ExportNumTransHship { get; set; }
        public decimal? HandlingAmountTransHship { get; set; }
        public string InsuranceNumTransHship { get; set; }
        public decimal? InsuranceAmountTransHship { get; set; }
        public string ImportNumTransHship { get; set; }
        public string ShippingChargedTransHship { get; set; }
        public decimal? FrieghtAmountTransHship { get; set; }
        public string ShipNameTransHship { get; set; }
        public string VesselNameTransHship { get; set; }
    }
}

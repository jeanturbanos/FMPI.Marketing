using System;
using System.Collections.Generic;

namespace FMPI.Marketing.Core.Models
{
    public partial class TransactionHeaderCxi
    {
        public decimal SysPkCxi { get; set; }
        public decimal SysFkTransHCxi { get; set; }
        public string LastUpdatedByCxi { get; set; }
        public short? LastUpdatedConcurrencyIdCxi { get; set; }
        public DateTime? LastUpdatedDateCxi { get; set; }
        public string AgainstOrderCxi { get; set; }
        public decimal? ConsignedToSysFkCxi { get; set; }
        public string ConsignedToUserFkCxi { get; set; }
        public string ConsignedToNameCxi { get; set; }
        public string ConsignedToAddressCxi { get; set; }
        public DateTime? DateOfLoadingCxi { get; set; }
        public string PortOfLoadingCxi { get; set; }
        public decimal? ShippedViaSysFkCxi { get; set; }
        public string ShippedViaUserFkCxi { get; set; }
        public string ShippedViaNameCxi { get; set; }
        public string ShippedFromCxi { get; set; }
        public string ShippedToCxi { get; set; }
        public string ShippingMarksCxi { get; set; }
        public DateTime? ShippingDateCxi { get; set; }
        public string DirectShipmentForTranshipmentByCxi { get; set; }
        public string PackingListUserFkCxi { get; set; }
        public DateTime? PackingListDateIssueCxi { get; set; }
        public string AdditionalInfoDocsProducedCertAunthCxi { get; set; }
        public string BankNameCxi { get; set; }
        public string CurrencyCxi { get; set; }
        public string CountryOfDestinationCxi { get; set; }
        public string CustomsProcedureCodeCxi { get; set; }
        public DateTime? DateOfDepartureCxi { get; set; }
        public string ExportDeclarationNumCxi { get; set; }
        public short? ForexCxi { get; set; }
        public decimal? FobvalueOfImportedRawMaterialsCxi { get; set; }
        public decimal? GrossWeightCxi { get; set; }
        public string HarmonizedSystemsCodeCxi { get; set; }
        public decimal? ItemFobpriceCxi { get; set; }
        public string MarksAndNumContainersDescriptionOfGoodsCxi { get; set; }
        public string ModeOfPaymentCxi { get; set; }
        public decimal? NetWeightCxi { get; set; }
        public string NumOfItemsTariffLinesCxi { get; set; }
        public string LocalCarrierCxi { get; set; }
        public string PageCxi { get; set; }
        public string PortOfDepartureCxi { get; set; }
        public string PreviousImportDocumentNumCxi { get; set; }
        public string ProvinceOfOriginCxi { get; set; }
        public string SupplementaryUnitsCxi { get; set; }
        public string TotalPackagesCxi { get; set; }
        public string VesselAircraftCxi { get; set; }
        public string ConsignedToTinCxi { get; set; }
    }
}

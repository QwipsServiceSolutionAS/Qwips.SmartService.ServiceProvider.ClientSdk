// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class InvoiceDetailDto : IParsable {
        /// <summary>The ArticleCount property</summary>
        public double? ArticleCount { get; set; }
        /// <summary>The ArticleDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleDescription { get; set; }
#nullable restore
#else
        public string ArticleDescription { get; set; }
#endif
        /// <summary>The ArticleNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleNumber { get; set; }
#nullable restore
#else
        public string ArticleNumber { get; set; }
#endif
        /// <summary>The ArticlePrice property</summary>
        public double? ArticlePrice { get; set; }
        /// <summary>The ArticlePriceIn property</summary>
        public double? ArticlePriceIn { get; set; }
        /// <summary>The ArticlePriceOut property</summary>
        public double? ArticlePriceOut { get; set; }
        /// <summary>The Created property</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>The CreatedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The Deleted property</summary>
        public bool? Deleted { get; set; }
        /// <summary>The Discount property</summary>
        public double? Discount { get; set; }
        /// <summary>The EmploymentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmploymentId { get; set; }
#nullable restore
#else
        public string EmploymentId { get; set; }
#endif
        /// <summary>The EmploymentTimeReportDate property</summary>
        public DateTimeOffset? EmploymentTimeReportDate { get; set; }
        /// <summary>The ExtCreatedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtCreatedBy { get; set; }
#nullable restore
#else
        public string ExtCreatedBy { get; set; }
#endif
        /// <summary>The ExtRef property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtRef { get; set; }
#nullable restore
#else
        public string ExtRef { get; set; }
#endif
        /// <summary>The ExtTransferDate property</summary>
        public DateTimeOffset? ExtTransferDate { get; set; }
        /// <summary>The ExtTransferred property</summary>
        public bool? ExtTransferred { get; set; }
        /// <summary>The ExtUpdatedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtUpdatedBy { get; set; }
#nullable restore
#else
        public string ExtUpdatedBy { get; set; }
#endif
        /// <summary>The HiddenNoInvoice property</summary>
        public bool? HiddenNoInvoice { get; set; }
        /// <summary>The Id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The IsInternal property</summary>
        public bool? IsInternal { get; set; }
        /// <summary>The JobId property</summary>
        public int? JobId { get; set; }
        /// <summary>The LastModified property</summary>
        public DateTimeOffset? LastModified { get; set; }
        /// <summary>The LastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy { get; set; }
#nullable restore
#else
        public string LastModifiedBy { get; set; }
#endif
        /// <summary>The LinePosition property</summary>
        public int? LinePosition { get; set; }
        /// <summary>The NoDetailInvoice property</summary>
        public bool? NoDetailInvoice { get; set; }
        /// <summary>The OrderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderId { get; set; }
#nullable restore
#else
        public string OrderId { get; set; }
#endif
        /// <summary>The ReadOnly property</summary>
        public bool? ReadOnly { get; set; }
        /// <summary>The StartDateTime property</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The StartLatitude property</summary>
        public double? StartLatitude { get; set; }
        /// <summary>The StartLongitude property</summary>
        public double? StartLongitude { get; set; }
        /// <summary>The StopDateTime property</summary>
        public DateTimeOffset? StopDateTime { get; set; }
        /// <summary>The StopLatitude property</summary>
        public double? StopLatitude { get; set; }
        /// <summary>The StopLongitude property</summary>
        public double? StopLongitude { get; set; }
        /// <summary>The StoreItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InvoiceStoreItemDto>? StoreItems { get; set; }
#nullable restore
#else
        public List<InvoiceStoreItemDto> StoreItems { get; set; }
#endif
        /// <summary>The TotalAmountExclVat property</summary>
        public double? TotalAmountExclVat { get; set; }
        /// <summary>The TotalDiscount property</summary>
        public double? TotalDiscount { get; set; }
        /// <summary>The Type property</summary>
        public int? Type { get; set; }
        /// <summary>The VatRate property</summary>
        public double? VatRate { get; set; }
        /// <summary>The VechicleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VechicleId { get; set; }
#nullable restore
#else
        public string VechicleId { get; set; }
#endif
        /// <summary>The WareHouseId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WareHouseId { get; set; }
#nullable restore
#else
        public string WareHouseId { get; set; }
#endif
        /// <summary>The WareHouseLocation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WareHouseLocation { get; set; }
#nullable restore
#else
        public string WareHouseLocation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InvoiceDetailDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvoiceDetailDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ArticleCount", n => { ArticleCount = n.GetDoubleValue(); } },
                {"ArticleDescription", n => { ArticleDescription = n.GetStringValue(); } },
                {"ArticleNumber", n => { ArticleNumber = n.GetStringValue(); } },
                {"ArticlePrice", n => { ArticlePrice = n.GetDoubleValue(); } },
                {"ArticlePriceIn", n => { ArticlePriceIn = n.GetDoubleValue(); } },
                {"ArticlePriceOut", n => { ArticlePriceOut = n.GetDoubleValue(); } },
                {"Created", n => { Created = n.GetDateTimeOffsetValue(); } },
                {"CreatedBy", n => { CreatedBy = n.GetStringValue(); } },
                {"Deleted", n => { Deleted = n.GetBoolValue(); } },
                {"Discount", n => { Discount = n.GetDoubleValue(); } },
                {"EmploymentId", n => { EmploymentId = n.GetStringValue(); } },
                {"EmploymentTimeReportDate", n => { EmploymentTimeReportDate = n.GetDateTimeOffsetValue(); } },
                {"ExtCreatedBy", n => { ExtCreatedBy = n.GetStringValue(); } },
                {"ExtRef", n => { ExtRef = n.GetStringValue(); } },
                {"ExtTransferDate", n => { ExtTransferDate = n.GetDateTimeOffsetValue(); } },
                {"ExtTransferred", n => { ExtTransferred = n.GetBoolValue(); } },
                {"ExtUpdatedBy", n => { ExtUpdatedBy = n.GetStringValue(); } },
                {"HiddenNoInvoice", n => { HiddenNoInvoice = n.GetBoolValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"IsInternal", n => { IsInternal = n.GetBoolValue(); } },
                {"JobId", n => { JobId = n.GetIntValue(); } },
                {"LastModified", n => { LastModified = n.GetDateTimeOffsetValue(); } },
                {"LastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                {"LinePosition", n => { LinePosition = n.GetIntValue(); } },
                {"NoDetailInvoice", n => { NoDetailInvoice = n.GetBoolValue(); } },
                {"OrderId", n => { OrderId = n.GetStringValue(); } },
                {"ReadOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"StartDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"StartLatitude", n => { StartLatitude = n.GetDoubleValue(); } },
                {"StartLongitude", n => { StartLongitude = n.GetDoubleValue(); } },
                {"StopDateTime", n => { StopDateTime = n.GetDateTimeOffsetValue(); } },
                {"StopLatitude", n => { StopLatitude = n.GetDoubleValue(); } },
                {"StopLongitude", n => { StopLongitude = n.GetDoubleValue(); } },
                {"StoreItems", n => { StoreItems = n.GetCollectionOfObjectValues<InvoiceStoreItemDto>(InvoiceStoreItemDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"TotalAmountExclVat", n => { TotalAmountExclVat = n.GetDoubleValue(); } },
                {"TotalDiscount", n => { TotalDiscount = n.GetDoubleValue(); } },
                {"Type", n => { Type = n.GetIntValue(); } },
                {"VatRate", n => { VatRate = n.GetDoubleValue(); } },
                {"VechicleId", n => { VechicleId = n.GetStringValue(); } },
                {"WareHouseId", n => { WareHouseId = n.GetStringValue(); } },
                {"WareHouseLocation", n => { WareHouseLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("ArticleCount", ArticleCount);
            writer.WriteStringValue("ArticleDescription", ArticleDescription);
            writer.WriteStringValue("ArticleNumber", ArticleNumber);
            writer.WriteDoubleValue("ArticlePrice", ArticlePrice);
            writer.WriteDoubleValue("ArticlePriceIn", ArticlePriceIn);
            writer.WriteDoubleValue("ArticlePriceOut", ArticlePriceOut);
            writer.WriteDateTimeOffsetValue("Created", Created);
            writer.WriteStringValue("CreatedBy", CreatedBy);
            writer.WriteBoolValue("Deleted", Deleted);
            writer.WriteDoubleValue("Discount", Discount);
            writer.WriteStringValue("EmploymentId", EmploymentId);
            writer.WriteDateTimeOffsetValue("EmploymentTimeReportDate", EmploymentTimeReportDate);
            writer.WriteStringValue("ExtCreatedBy", ExtCreatedBy);
            writer.WriteStringValue("ExtRef", ExtRef);
            writer.WriteDateTimeOffsetValue("ExtTransferDate", ExtTransferDate);
            writer.WriteBoolValue("ExtTransferred", ExtTransferred);
            writer.WriteStringValue("ExtUpdatedBy", ExtUpdatedBy);
            writer.WriteBoolValue("HiddenNoInvoice", HiddenNoInvoice);
            writer.WriteStringValue("Id", Id);
            writer.WriteBoolValue("IsInternal", IsInternal);
            writer.WriteIntValue("JobId", JobId);
            writer.WriteDateTimeOffsetValue("LastModified", LastModified);
            writer.WriteStringValue("LastModifiedBy", LastModifiedBy);
            writer.WriteIntValue("LinePosition", LinePosition);
            writer.WriteBoolValue("NoDetailInvoice", NoDetailInvoice);
            writer.WriteStringValue("OrderId", OrderId);
            writer.WriteBoolValue("ReadOnly", ReadOnly);
            writer.WriteDateTimeOffsetValue("StartDateTime", StartDateTime);
            writer.WriteDoubleValue("StartLatitude", StartLatitude);
            writer.WriteDoubleValue("StartLongitude", StartLongitude);
            writer.WriteDateTimeOffsetValue("StopDateTime", StopDateTime);
            writer.WriteDoubleValue("StopLatitude", StopLatitude);
            writer.WriteDoubleValue("StopLongitude", StopLongitude);
            writer.WriteCollectionOfObjectValues<InvoiceStoreItemDto>("StoreItems", StoreItems);
            writer.WriteDoubleValue("TotalAmountExclVat", TotalAmountExclVat);
            writer.WriteDoubleValue("TotalDiscount", TotalDiscount);
            writer.WriteIntValue("Type", Type);
            writer.WriteDoubleValue("VatRate", VatRate);
            writer.WriteStringValue("VechicleId", VechicleId);
            writer.WriteStringValue("WareHouseId", WareHouseId);
            writer.WriteStringValue("WareHouseLocation", WareHouseLocation);
        }
    }
}

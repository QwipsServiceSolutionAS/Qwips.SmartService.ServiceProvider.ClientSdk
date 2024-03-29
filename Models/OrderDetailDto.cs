// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class OrderDetailDto : IParsable {
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
        /// <summary>The ExtRef property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtRef { get; set; }
#nullable restore
#else
        public string ExtRef { get; set; }
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
        /// <summary>The LinePosition property</summary>
        public int? LinePosition { get; set; }
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
        /// <summary>The TotalAmountExclVat property</summary>
        public double? TotalAmountExclVat { get; set; }
        /// <summary>The WareHouseId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WareHouseId { get; set; }
#nullable restore
#else
        public string WareHouseId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrderDetailDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrderDetailDto();
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
                {"Deleted", n => { Deleted = n.GetBoolValue(); } },
                {"Discount", n => { Discount = n.GetDoubleValue(); } },
                {"EmploymentId", n => { EmploymentId = n.GetStringValue(); } },
                {"ExtRef", n => { ExtRef = n.GetStringValue(); } },
                {"HiddenNoInvoice", n => { HiddenNoInvoice = n.GetBoolValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"LinePosition", n => { LinePosition = n.GetIntValue(); } },
                {"OrderId", n => { OrderId = n.GetStringValue(); } },
                {"ReadOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"TotalAmountExclVat", n => { TotalAmountExclVat = n.GetDoubleValue(); } },
                {"WareHouseId", n => { WareHouseId = n.GetStringValue(); } },
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
            writer.WriteBoolValue("Deleted", Deleted);
            writer.WriteDoubleValue("Discount", Discount);
            writer.WriteStringValue("EmploymentId", EmploymentId);
            writer.WriteStringValue("ExtRef", ExtRef);
            writer.WriteBoolValue("HiddenNoInvoice", HiddenNoInvoice);
            writer.WriteStringValue("Id", Id);
            writer.WriteIntValue("LinePosition", LinePosition);
            writer.WriteStringValue("OrderId", OrderId);
            writer.WriteBoolValue("ReadOnly", ReadOnly);
            writer.WriteDoubleValue("TotalAmountExclVat", TotalAmountExclVat);
            writer.WriteStringValue("WareHouseId", WareHouseId);
        }
    }
}

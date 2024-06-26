// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Models {
    public class StockEntryGetResponseDto : IParsable {
        /// <summary>The ArticleId property</summary>
        public int? ArticleId { get; set; }
        /// <summary>The ArticleNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleNumber { get; set; }
#nullable restore
#else
        public string ArticleNumber { get; set; }
#endif
        /// <summary>The Available property</summary>
        public double? Available { get; set; }
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The StoreLocationName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreLocationName { get; set; }
#nullable restore
#else
        public string StoreLocationName { get; set; }
#endif
        /// <summary>The StoreName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreName { get; set; }
#nullable restore
#else
        public string StoreName { get; set; }
#endif
        /// <summary>The WarehouseId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WarehouseId { get; set; }
#nullable restore
#else
        public string WarehouseId { get; set; }
#endif
        /// <summary>The WarehouseLocationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WarehouseLocationId { get; set; }
#nullable restore
#else
        public string WarehouseLocationId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StockEntryGetResponseDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StockEntryGetResponseDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ArticleId", n => { ArticleId = n.GetIntValue(); } },
                {"ArticleNumber", n => { ArticleNumber = n.GetStringValue(); } },
                {"Available", n => { Available = n.GetDoubleValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"StoreLocationName", n => { StoreLocationName = n.GetStringValue(); } },
                {"StoreName", n => { StoreName = n.GetStringValue(); } },
                {"WarehouseId", n => { WarehouseId = n.GetStringValue(); } },
                {"WarehouseLocationId", n => { WarehouseLocationId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("ArticleId", ArticleId);
            writer.WriteStringValue("ArticleNumber", ArticleNumber);
            writer.WriteDoubleValue("Available", Available);
            writer.WriteIntValue("Id", Id);
            writer.WriteStringValue("StoreLocationName", StoreLocationName);
            writer.WriteStringValue("StoreName", StoreName);
            writer.WriteStringValue("WarehouseId", WarehouseId);
            writer.WriteStringValue("WarehouseLocationId", WarehouseLocationId);
        }
    }
}

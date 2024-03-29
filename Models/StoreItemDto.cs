// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class StoreItemDto : IParsable {
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
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The StoreId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreId { get; set; }
#nullable restore
#else
        public string StoreId { get; set; }
#endif
        /// <summary>The StoreLocationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreLocationId { get; set; }
#nullable restore
#else
        public string StoreLocationId { get; set; }
#endif
        /// <summary>The StoreName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StoreName { get; set; }
#nullable restore
#else
        public string StoreName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StoreItemDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StoreItemDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ArticleNumber", n => { ArticleNumber = n.GetStringValue(); } },
                {"Available", n => { Available = n.GetDoubleValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"StoreId", n => { StoreId = n.GetStringValue(); } },
                {"StoreLocationId", n => { StoreLocationId = n.GetStringValue(); } },
                {"StoreName", n => { StoreName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ArticleNumber", ArticleNumber);
            writer.WriteDoubleValue("Available", Available);
            writer.WriteStringValue("Id", Id);
            writer.WriteStringValue("StoreId", StoreId);
            writer.WriteStringValue("StoreLocationId", StoreLocationId);
            writer.WriteStringValue("StoreName", StoreName);
        }
    }
}

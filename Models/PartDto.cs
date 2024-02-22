// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class PartDto : IParsable {
        /// <summary>The ArticleDescription property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleDescription { get; set; }
#nullable restore
#else
        public string ArticleDescription { get; set; }
#endif
        /// <summary>The ArticleDescriptionLong property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleDescriptionLong { get; set; }
#nullable restore
#else
        public string ArticleDescriptionLong { get; set; }
#endif
        /// <summary>The ArticleImage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleImage { get; set; }
#nullable restore
#else
        public string ArticleImage { get; set; }
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
        /// <summary>The CentralSystemId property</summary>
        public int? CentralSystemId { get; set; }
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The Internal property</summary>
        public bool? Internal { get; set; }
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>The IsStoreArticle property</summary>
        public bool? IsStoreArticle { get; set; }
        /// <summary>The StoreItems property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GenericStoreItemDataModel>? StoreItems { get; set; }
#nullable restore
#else
        public List<GenericStoreItemDataModel> StoreItems { get; set; }
#endif
        /// <summary>The SupplierId property</summary>
        public int? SupplierId { get; set; }
        /// <summary>The SupplierName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SupplierName { get; set; }
#nullable restore
#else
        public string SupplierName { get; set; }
#endif
        /// <summary>The TechnicianSparePart property</summary>
        public bool? TechnicianSparePart { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PartDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PartDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ArticleDescription", n => { ArticleDescription = n.GetStringValue(); } },
                {"ArticleDescriptionLong", n => { ArticleDescriptionLong = n.GetStringValue(); } },
                {"ArticleImage", n => { ArticleImage = n.GetStringValue(); } },
                {"ArticleNumber", n => { ArticleNumber = n.GetStringValue(); } },
                {"ArticlePrice", n => { ArticlePrice = n.GetDoubleValue(); } },
                {"ArticlePriceIn", n => { ArticlePriceIn = n.GetDoubleValue(); } },
                {"CentralSystemId", n => { CentralSystemId = n.GetIntValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"Internal", n => { Internal = n.GetBoolValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"IsStoreArticle", n => { IsStoreArticle = n.GetBoolValue(); } },
                {"StoreItems", n => { StoreItems = n.GetCollectionOfObjectValues<GenericStoreItemDataModel>(GenericStoreItemDataModel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"SupplierId", n => { SupplierId = n.GetIntValue(); } },
                {"SupplierName", n => { SupplierName = n.GetStringValue(); } },
                {"TechnicianSparePart", n => { TechnicianSparePart = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ArticleDescription", ArticleDescription);
            writer.WriteStringValue("ArticleDescriptionLong", ArticleDescriptionLong);
            writer.WriteStringValue("ArticleImage", ArticleImage);
            writer.WriteStringValue("ArticleNumber", ArticleNumber);
            writer.WriteDoubleValue("ArticlePrice", ArticlePrice);
            writer.WriteDoubleValue("ArticlePriceIn", ArticlePriceIn);
            writer.WriteIntValue("CentralSystemId", CentralSystemId);
            writer.WriteIntValue("Id", Id);
            writer.WriteBoolValue("Internal", Internal);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteBoolValue("IsStoreArticle", IsStoreArticle);
            writer.WriteCollectionOfObjectValues<GenericStoreItemDataModel>("StoreItems", StoreItems);
            writer.WriteIntValue("SupplierId", SupplierId);
            writer.WriteStringValue("SupplierName", SupplierName);
            writer.WriteBoolValue("TechnicianSparePart", TechnicianSparePart);
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class JobCategoryArticleDto : IParsable {
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
        /// <summary>The ArticleId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleId { get; set; }
#nullable restore
#else
        public string ArticleId { get; set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The JobCategoryId property</summary>
        public int? JobCategoryId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JobCategoryArticleDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JobCategoryArticleDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ArticleCount", n => { ArticleCount = n.GetDoubleValue(); } },
                {"ArticleDescription", n => { ArticleDescription = n.GetStringValue(); } },
                {"ArticleId", n => { ArticleId = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"JobCategoryId", n => { JobCategoryId = n.GetIntValue(); } },
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
            writer.WriteStringValue("ArticleId", ArticleId);
            writer.WriteIntValue("Id", Id);
            writer.WriteIntValue("JobCategoryId", JobCategoryId);
        }
    }
}
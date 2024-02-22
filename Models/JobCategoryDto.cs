// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class JobCategoryDto : IParsable {
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The JobCategoryArticles property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JobCategoryArticleDto>? JobCategoryArticles { get; set; }
#nullable restore
#else
        public List<JobCategoryArticleDto> JobCategoryArticles { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JobCategoryDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JobCategoryDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Id", n => { Id = n.GetIntValue(); } },
                {"JobCategoryArticles", n => { JobCategoryArticles = n.GetCollectionOfObjectValues<JobCategoryArticleDto>(JobCategoryArticleDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("Id", Id);
            writer.WriteCollectionOfObjectValues<JobCategoryArticleDto>("JobCategoryArticles", JobCategoryArticles);
            writer.WriteStringValue("Name", Name);
        }
    }
}
// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class CheckListTemplateDto : IParsable {
        /// <summary>The CheckListFields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CheckListFieldDto>? CheckListFields { get; set; }
#nullable restore
#else
        public List<CheckListFieldDto> CheckListFields { get; set; }
#endif
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
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
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
        public static CheckListTemplateDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CheckListTemplateDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CheckListFields", n => { CheckListFields = n.GetCollectionOfObjectValues<CheckListFieldDto>(CheckListFieldDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Created", n => { Created = n.GetDateTimeOffsetValue(); } },
                {"CreatedBy", n => { CreatedBy = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<CheckListFieldDto>("CheckListFields", CheckListFields);
            writer.WriteDateTimeOffsetValue("Created", Created);
            writer.WriteStringValue("CreatedBy", CreatedBy);
            writer.WriteIntValue("Id", Id);
            writer.WriteStringValue("Name", Name);
        }
    }
}

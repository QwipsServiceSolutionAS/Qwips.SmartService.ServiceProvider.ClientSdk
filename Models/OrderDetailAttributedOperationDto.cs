// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class OrderDetailAttributedOperationDto : IParsable {
        /// <summary>The Content property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary2? Content { get; set; }
#nullable restore
#else
        public Dictionary2 Content { get; set; }
#endif
        /// <summary>The Id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The JobId property</summary>
        public int? JobId { get; set; }
        /// <summary>The ValidationType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TypeObject? ValidationType { get; set; }
#nullable restore
#else
        public TypeObject ValidationType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrderDetailAttributedOperationDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrderDetailAttributedOperationDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Content", n => { Content = n.GetObjectValue<Dictionary2>(Dictionary2.CreateFromDiscriminatorValue); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"JobId", n => { JobId = n.GetIntValue(); } },
                {"ValidationType", n => { ValidationType = n.GetObjectValue<TypeObject>(TypeObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Dictionary2>("Content", Content);
            writer.WriteStringValue("Id", Id);
            writer.WriteIntValue("JobId", JobId);
            writer.WriteObjectValue<TypeObject>("ValidationType", ValidationType);
        }
    }
}
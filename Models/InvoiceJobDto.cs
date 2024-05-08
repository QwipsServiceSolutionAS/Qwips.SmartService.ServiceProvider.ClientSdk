// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Models {
    public class InvoiceJobDto : IParsable {
        /// <summary>The DisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The MachineDisplayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MachineDisplayName { get; set; }
#nullable restore
#else
        public string MachineDisplayName { get; set; }
#endif
        /// <summary>The OrderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderId { get; set; }
#nullable restore
#else
        public string OrderId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InvoiceJobDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvoiceJobDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DisplayName", n => { DisplayName = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"MachineDisplayName", n => { MachineDisplayName = n.GetStringValue(); } },
                {"OrderId", n => { OrderId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("DisplayName", DisplayName);
            writer.WriteIntValue("Id", Id);
            writer.WriteStringValue("MachineDisplayName", MachineDisplayName);
            writer.WriteStringValue("OrderId", OrderId);
        }
    }
}

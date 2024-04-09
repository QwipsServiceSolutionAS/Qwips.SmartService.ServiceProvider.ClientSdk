// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Models {
    public class MachineModelDto : IParsable {
        /// <summary>The AlternativeName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternativeName { get; set; }
#nullable restore
#else
        public string AlternativeName { get; set; }
#endif
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
        /// <summary>The IsActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>The MachineType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleMachineTypeDto? MachineType { get; set; }
#nullable restore
#else
        public SimpleMachineTypeDto MachineType { get; set; }
#endif
        /// <summary>The ModelImage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModelImage { get; set; }
#nullable restore
#else
        public string ModelImage { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The ProductNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductNumber { get; set; }
#nullable restore
#else
        public string ProductNumber { get; set; }
#endif
        /// <summary>The Supplier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleSupplierDto? Supplier { get; set; }
#nullable restore
#else
        public SimpleSupplierDto Supplier { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MachineModelDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MachineModelDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AlternativeName", n => { AlternativeName = n.GetStringValue(); } },
                {"DisplayName", n => { DisplayName = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"IsActive", n => { IsActive = n.GetBoolValue(); } },
                {"MachineType", n => { MachineType = n.GetObjectValue<SimpleMachineTypeDto>(SimpleMachineTypeDto.CreateFromDiscriminatorValue); } },
                {"ModelImage", n => { ModelImage = n.GetStringValue(); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"ProductNumber", n => { ProductNumber = n.GetStringValue(); } },
                {"Supplier", n => { Supplier = n.GetObjectValue<SimpleSupplierDto>(SimpleSupplierDto.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("AlternativeName", AlternativeName);
            writer.WriteStringValue("DisplayName", DisplayName);
            writer.WriteIntValue("Id", Id);
            writer.WriteBoolValue("IsActive", IsActive);
            writer.WriteObjectValue<SimpleMachineTypeDto>("MachineType", MachineType);
            writer.WriteStringValue("ModelImage", ModelImage);
            writer.WriteStringValue("Name", Name);
            writer.WriteStringValue("ProductNumber", ProductNumber);
            writer.WriteObjectValue<SimpleSupplierDto>("Supplier", Supplier);
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class MemberInfo : IParsable {
        /// <summary>The CustomAttributes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomAttributeData>? CustomAttributes { get; private set; }
#nullable restore
#else
        public List<CustomAttributeData> CustomAttributes { get; private set; }
#endif
        /// <summary>The DeclaringType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TypeObject? DeclaringType { get; set; }
#nullable restore
#else
        public TypeObject DeclaringType { get; set; }
#endif
        /// <summary>The MemberType property</summary>
        public int? MemberType { get; set; }
        /// <summary>The MetadataToken property</summary>
        public int? MetadataToken { get; private set; }
        /// <summary>The Module property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module? Module { get; set; }
#nullable restore
#else
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module Module { get; set; }
#endif
        /// <summary>The Name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; private set; }
#nullable restore
#else
        public string Name { get; private set; }
#endif
        /// <summary>The ReflectedType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TypeObject? ReflectedType { get; set; }
#nullable restore
#else
        public TypeObject ReflectedType { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MemberInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MemberInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CustomAttributes", n => { CustomAttributes = n.GetCollectionOfObjectValues<CustomAttributeData>(CustomAttributeData.CreateFromDiscriminatorValue)?.ToList(); } },
                {"DeclaringType", n => { DeclaringType = n.GetObjectValue<TypeObject>(TypeObject.CreateFromDiscriminatorValue); } },
                {"MemberType", n => { MemberType = n.GetIntValue(); } },
                {"MetadataToken", n => { MetadataToken = n.GetIntValue(); } },
                {"Module", n => { Module = n.GetObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module>(Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module.CreateFromDiscriminatorValue); } },
                {"Name", n => { Name = n.GetStringValue(); } },
                {"ReflectedType", n => { ReflectedType = n.GetObjectValue<TypeObject>(TypeObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TypeObject>("DeclaringType", DeclaringType);
            writer.WriteIntValue("MemberType", MemberType);
            writer.WriteObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.Module>("Module", Module);
            writer.WriteObjectValue<TypeObject>("ReflectedType", ReflectedType);
        }
    }
}
// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class CustomAttributeNamedArgument : IParsable {
        /// <summary>The IsField property</summary>
        public bool? IsField { get; private set; }
        /// <summary>The MemberInfo property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.MemberInfo? MemberInfo { get; set; }
#nullable restore
#else
        public Qwips.SmartService.ServiceProvider.ClientSdk.Models.MemberInfo MemberInfo { get; set; }
#endif
        /// <summary>The MemberName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberName { get; private set; }
#nullable restore
#else
        public string MemberName { get; private set; }
#endif
        /// <summary>The TypedValue property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomAttributeTypedArgument? TypedValue { get; set; }
#nullable restore
#else
        public CustomAttributeTypedArgument TypedValue { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomAttributeNamedArgument CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomAttributeNamedArgument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"IsField", n => { IsField = n.GetBoolValue(); } },
                {"MemberInfo", n => { MemberInfo = n.GetObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.MemberInfo>(Qwips.SmartService.ServiceProvider.ClientSdk.Models.MemberInfo.CreateFromDiscriminatorValue); } },
                {"MemberName", n => { MemberName = n.GetStringValue(); } },
                {"TypedValue", n => { TypedValue = n.GetObjectValue<CustomAttributeTypedArgument>(CustomAttributeTypedArgument.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Qwips.SmartService.ServiceProvider.ClientSdk.Models.MemberInfo>("MemberInfo", MemberInfo);
            writer.WriteObjectValue<CustomAttributeTypedArgument>("TypedValue", TypedValue);
        }
    }
}
// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class GenericOrderDto : IParsable {
        /// <summary>The CustomerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId { get; set; }
#nullable restore
#else
        public string CustomerId { get; set; }
#endif
        /// <summary>The CustomerPersonId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerPersonId { get; set; }
#nullable restore
#else
        public string CustomerPersonId { get; set; }
#endif
        /// <summary>The DepartmentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DepartmentId { get; set; }
#nullable restore
#else
        public string DepartmentId { get; set; }
#endif
        /// <summary>The Id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The NoInvoice property</summary>
        public bool? NoInvoice { get; set; }
        /// <summary>The TotalAmountExclVat property</summary>
        public double? TotalAmountExclVat { get; set; }
        /// <summary>The TotalDiscount property</summary>
        public double? TotalDiscount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static GenericOrderDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GenericOrderDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"CustomerId", n => { CustomerId = n.GetStringValue(); } },
                {"CustomerPersonId", n => { CustomerPersonId = n.GetStringValue(); } },
                {"DepartmentId", n => { DepartmentId = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"NoInvoice", n => { NoInvoice = n.GetBoolValue(); } },
                {"TotalAmountExclVat", n => { TotalAmountExclVat = n.GetDoubleValue(); } },
                {"TotalDiscount", n => { TotalDiscount = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("CustomerId", CustomerId);
            writer.WriteStringValue("CustomerPersonId", CustomerPersonId);
            writer.WriteStringValue("DepartmentId", DepartmentId);
            writer.WriteStringValue("Id", Id);
            writer.WriteBoolValue("NoInvoice", NoInvoice);
            writer.WriteDoubleValue("TotalAmountExclVat", TotalAmountExclVat);
            writer.WriteDoubleValue("TotalDiscount", TotalDiscount);
        }
    }
}

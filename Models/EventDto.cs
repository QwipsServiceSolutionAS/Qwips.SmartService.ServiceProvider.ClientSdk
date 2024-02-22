// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class EventDto : IParsable {
        /// <summary>The address property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeliveryAddressDto? Address { get; set; }
#nullable restore
#else
        public DeliveryAddressDto Address { get; set; }
#endif
        /// <summary>The appointmentType property</summary>
        public int? AppointmentType { get; set; }
        /// <summary>The endDate property</summary>
        public DateTimeOffset? EndDate { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The jobId property</summary>
        public int? JobId { get; set; }
        /// <summary>The jobStatusId property</summary>
        public int? JobStatusId { get; set; }
        /// <summary>The jobStatusName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobStatusName { get; set; }
#nullable restore
#else
        public string JobStatusName { get; set; }
#endif
        /// <summary>The jobTypeId property</summary>
        public int? JobTypeId { get; set; }
        /// <summary>The jobTypeName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTypeName { get; set; }
#nullable restore
#else
        public string JobTypeName { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The startDate property</summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EventDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EventDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"address", n => { Address = n.GetObjectValue<DeliveryAddressDto>(DeliveryAddressDto.CreateFromDiscriminatorValue); } },
                {"appointmentType", n => { AppointmentType = n.GetIntValue(); } },
                {"endDate", n => { EndDate = n.GetDateTimeOffsetValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"jobId", n => { JobId = n.GetIntValue(); } },
                {"jobStatusId", n => { JobStatusId = n.GetIntValue(); } },
                {"jobStatusName", n => { JobStatusName = n.GetStringValue(); } },
                {"jobTypeId", n => { JobTypeId = n.GetIntValue(); } },
                {"jobTypeName", n => { JobTypeName = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"startDate", n => { StartDate = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeliveryAddressDto>("address", Address);
            writer.WriteIntValue("appointmentType", AppointmentType);
            writer.WriteDateTimeOffsetValue("endDate", EndDate);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("jobId", JobId);
            writer.WriteIntValue("jobStatusId", JobStatusId);
            writer.WriteStringValue("jobStatusName", JobStatusName);
            writer.WriteIntValue("jobTypeId", JobTypeId);
            writer.WriteStringValue("jobTypeName", JobTypeName);
            writer.WriteStringValue("name", Name);
            writer.WriteDateTimeOffsetValue("startDate", StartDate);
        }
    }
}

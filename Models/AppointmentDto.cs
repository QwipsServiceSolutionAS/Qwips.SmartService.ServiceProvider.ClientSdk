// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class AppointmentDto : IParsable {
        /// <summary>The AppointmentDate property</summary>
        public DateTimeOffset? AppointmentDate { get; set; }
        /// <summary>The AppointmentStatus property</summary>
        public int? AppointmentStatus { get; set; }
        /// <summary>The EndTime property</summary>
        public DateTimeOffset? EndTime { get; set; }
        /// <summary>The ExchangeUniqueId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExchangeUniqueId { get; set; }
#nullable restore
#else
        public string ExchangeUniqueId { get; set; }
#endif
        /// <summary>The Id property</summary>
        public int? Id { get; set; }
        /// <summary>The IsAbsence property</summary>
        public bool? IsAbsence { get; set; }
        /// <summary>The JobId property</summary>
        public int? JobId { get; set; }
        /// <summary>The JobStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JobStatusDto? JobStatus { get; set; }
#nullable restore
#else
        public JobStatusDto JobStatus { get; set; }
#endif
        /// <summary>The Participants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ParticipantDto>? Participants { get; set; }
#nullable restore
#else
        public List<ParticipantDto> Participants { get; set; }
#endif
        /// <summary>The StartTime property</summary>
        public DateTimeOffset? StartTime { get; set; }
        /// <summary>The Subject property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The Type property</summary>
        public int? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AppointmentDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppointmentDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"AppointmentDate", n => { AppointmentDate = n.GetDateTimeOffsetValue(); } },
                {"AppointmentStatus", n => { AppointmentStatus = n.GetIntValue(); } },
                {"EndTime", n => { EndTime = n.GetDateTimeOffsetValue(); } },
                {"ExchangeUniqueId", n => { ExchangeUniqueId = n.GetStringValue(); } },
                {"Id", n => { Id = n.GetIntValue(); } },
                {"IsAbsence", n => { IsAbsence = n.GetBoolValue(); } },
                {"JobId", n => { JobId = n.GetIntValue(); } },
                {"JobStatus", n => { JobStatus = n.GetObjectValue<JobStatusDto>(JobStatusDto.CreateFromDiscriminatorValue); } },
                {"Participants", n => { Participants = n.GetCollectionOfObjectValues<ParticipantDto>(ParticipantDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"StartTime", n => { StartTime = n.GetDateTimeOffsetValue(); } },
                {"Subject", n => { Subject = n.GetStringValue(); } },
                {"Type", n => { Type = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("AppointmentDate", AppointmentDate);
            writer.WriteIntValue("AppointmentStatus", AppointmentStatus);
            writer.WriteDateTimeOffsetValue("EndTime", EndTime);
            writer.WriteStringValue("ExchangeUniqueId", ExchangeUniqueId);
            writer.WriteIntValue("Id", Id);
            writer.WriteBoolValue("IsAbsence", IsAbsence);
            writer.WriteIntValue("JobId", JobId);
            writer.WriteObjectValue<JobStatusDto>("JobStatus", JobStatus);
            writer.WriteCollectionOfObjectValues<ParticipantDto>("Participants", Participants);
            writer.WriteDateTimeOffsetValue("StartTime", StartTime);
            writer.WriteStringValue("Subject", Subject);
            writer.WriteIntValue("Type", Type);
        }
    }
}
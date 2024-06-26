// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Models {
    public class TimeSpanObject : IParsable {
        /// <summary>The Days property</summary>
        public int? Days { get; private set; }
        /// <summary>The Hours property</summary>
        public int? Hours { get; private set; }
        /// <summary>The Milliseconds property</summary>
        public int? Milliseconds { get; private set; }
        /// <summary>The Minutes property</summary>
        public int? Minutes { get; private set; }
        /// <summary>The Seconds property</summary>
        public int? Seconds { get; private set; }
        /// <summary>The Ticks property</summary>
        public long? Ticks { get; private set; }
        /// <summary>The TotalDays property</summary>
        public double? TotalDays { get; private set; }
        /// <summary>The TotalHours property</summary>
        public double? TotalHours { get; private set; }
        /// <summary>The TotalMilliseconds property</summary>
        public double? TotalMilliseconds { get; private set; }
        /// <summary>The TotalMinutes property</summary>
        public double? TotalMinutes { get; private set; }
        /// <summary>The TotalSeconds property</summary>
        public double? TotalSeconds { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeSpanObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeSpanObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"Days", n => { Days = n.GetIntValue(); } },
                {"Hours", n => { Hours = n.GetIntValue(); } },
                {"Milliseconds", n => { Milliseconds = n.GetIntValue(); } },
                {"Minutes", n => { Minutes = n.GetIntValue(); } },
                {"Seconds", n => { Seconds = n.GetIntValue(); } },
                {"Ticks", n => { Ticks = n.GetLongValue(); } },
                {"TotalDays", n => { TotalDays = n.GetDoubleValue(); } },
                {"TotalHours", n => { TotalHours = n.GetDoubleValue(); } },
                {"TotalMilliseconds", n => { TotalMilliseconds = n.GetDoubleValue(); } },
                {"TotalMinutes", n => { TotalMinutes = n.GetDoubleValue(); } },
                {"TotalSeconds", n => { TotalSeconds = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Models {
    public class JobTimeEntryDto : IParsable {
        /// <summary>The ArticleNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArticleNumber { get; set; }
#nullable restore
#else
        public string ArticleNumber { get; set; }
#endif
        /// <summary>The ArticlePrice property</summary>
        public double? ArticlePrice { get; set; }
        /// <summary>The Discount property</summary>
        public double? Discount { get; set; }
        /// <summary>The EmploymentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmploymentId { get; set; }
#nullable restore
#else
        public string EmploymentId { get; set; }
#endif
        /// <summary>The EmploymentTimeReportDate property</summary>
        public DateTimeOffset? EmploymentTimeReportDate { get; set; }
        /// <summary>The End property</summary>
        public DateTimeOffset? End { get; set; }
        /// <summary>The Hours property</summary>
        public double? Hours { get; set; }
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
        /// <summary>The Latitude property</summary>
        public double? Latitude { get; set; }
        /// <summary>The Longitude property</summary>
        public double? Longitude { get; set; }
        /// <summary>The OrderId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderId { get; set; }
#nullable restore
#else
        public string OrderId { get; set; }
#endif
        /// <summary>The Start property</summary>
        public DateTimeOffset? Start { get; set; }
        /// <summary>The StartLatitude property</summary>
        public double? StartLatitude { get; set; }
        /// <summary>The StartLongitude property</summary>
        public double? StartLongitude { get; set; }
        /// <summary>The Text property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Text { get; set; }
#nullable restore
#else
        public string Text { get; set; }
#endif
        /// <summary>The TotalAmountExclVat property</summary>
        public double? TotalAmountExclVat { get; set; }
        /// <summary>The TotalDiscount property</summary>
        public double? TotalDiscount { get; set; }
        /// <summary>The Type property</summary>
        public int? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JobTimeEntryDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JobTimeEntryDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ArticleNumber", n => { ArticleNumber = n.GetStringValue(); } },
                {"ArticlePrice", n => { ArticlePrice = n.GetDoubleValue(); } },
                {"Discount", n => { Discount = n.GetDoubleValue(); } },
                {"EmploymentId", n => { EmploymentId = n.GetStringValue(); } },
                {"EmploymentTimeReportDate", n => { EmploymentTimeReportDate = n.GetDateTimeOffsetValue(); } },
                {"End", n => { End = n.GetDateTimeOffsetValue(); } },
                {"Hours", n => { Hours = n.GetDoubleValue(); } },
                {"Id", n => { Id = n.GetStringValue(); } },
                {"JobId", n => { JobId = n.GetIntValue(); } },
                {"Latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"Longitude", n => { Longitude = n.GetDoubleValue(); } },
                {"OrderId", n => { OrderId = n.GetStringValue(); } },
                {"Start", n => { Start = n.GetDateTimeOffsetValue(); } },
                {"StartLatitude", n => { StartLatitude = n.GetDoubleValue(); } },
                {"StartLongitude", n => { StartLongitude = n.GetDoubleValue(); } },
                {"Text", n => { Text = n.GetStringValue(); } },
                {"TotalAmountExclVat", n => { TotalAmountExclVat = n.GetDoubleValue(); } },
                {"TotalDiscount", n => { TotalDiscount = n.GetDoubleValue(); } },
                {"Type", n => { Type = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("ArticleNumber", ArticleNumber);
            writer.WriteDoubleValue("ArticlePrice", ArticlePrice);
            writer.WriteDoubleValue("Discount", Discount);
            writer.WriteStringValue("EmploymentId", EmploymentId);
            writer.WriteDateTimeOffsetValue("EmploymentTimeReportDate", EmploymentTimeReportDate);
            writer.WriteDateTimeOffsetValue("End", End);
            writer.WriteDoubleValue("Hours", Hours);
            writer.WriteStringValue("Id", Id);
            writer.WriteIntValue("JobId", JobId);
            writer.WriteDoubleValue("Latitude", Latitude);
            writer.WriteDoubleValue("Longitude", Longitude);
            writer.WriteStringValue("OrderId", OrderId);
            writer.WriteDateTimeOffsetValue("Start", Start);
            writer.WriteDoubleValue("StartLatitude", StartLatitude);
            writer.WriteDoubleValue("StartLongitude", StartLongitude);
            writer.WriteStringValue("Text", Text);
            writer.WriteDoubleValue("TotalAmountExclVat", TotalAmountExclVat);
            writer.WriteDoubleValue("TotalDiscount", TotalDiscount);
            writer.WriteIntValue("Type", Type);
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Models {
    public class InvoiceViewDto : IParsable {
        /// <summary>The DefaultEmploymentId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultEmploymentId { get; set; }
#nullable restore
#else
        public string DefaultEmploymentId { get; set; }
#endif
        /// <summary>The DefaultStoreId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultStoreId { get; set; }
#nullable restore
#else
        public string DefaultStoreId { get; set; }
#endif
        /// <summary>The Employees property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InvoiceEmploymentDto>? Employees { get; set; }
#nullable restore
#else
        public List<InvoiceEmploymentDto> Employees { get; set; }
#endif
        /// <summary>The Jobs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InvoiceJobDto>? Jobs { get; set; }
#nullable restore
#else
        public List<InvoiceJobDto> Jobs { get; set; }
#endif
        /// <summary>The JobStatusId property</summary>
        public int? JobStatusId { get; set; }
        /// <summary>The NoInvoice property</summary>
        public bool? NoInvoice { get; set; }
        /// <summary>The OrderDetails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InvoiceDetailDto>? OrderDetails { get; set; }
#nullable restore
#else
        public List<InvoiceDetailDto> OrderDetails { get; set; }
#endif
        /// <summary>The OrderStatus property</summary>
        public InvoiceOrderStatusEnum? OrderStatus { get; set; }
        /// <summary>The Participants property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InvoiceUserDto>? Participants { get; set; }
#nullable restore
#else
        public List<InvoiceUserDto> Participants { get; set; }
#endif
        /// <summary>The Primary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public InvoiceJobDto? Primary { get; set; }
#nullable restore
#else
        public InvoiceJobDto Primary { get; set; }
#endif
        /// <summary>The Samtech property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SamtechDto? Samtech { get; set; }
#nullable restore
#else
        public SamtechDto Samtech { get; set; }
#endif
        /// <summary>The Stores property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<InvoiceStoreDto>? Stores { get; set; }
#nullable restore
#else
        public List<InvoiceStoreDto> Stores { get; set; }
#endif
        /// <summary>The TimeZone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeSpanObject? TimeZone { get; set; }
#nullable restore
#else
        public TimeSpanObject TimeZone { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static InvoiceViewDto CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvoiceViewDto();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"DefaultEmploymentId", n => { DefaultEmploymentId = n.GetStringValue(); } },
                {"DefaultStoreId", n => { DefaultStoreId = n.GetStringValue(); } },
                {"Employees", n => { Employees = n.GetCollectionOfObjectValues<InvoiceEmploymentDto>(InvoiceEmploymentDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Jobs", n => { Jobs = n.GetCollectionOfObjectValues<InvoiceJobDto>(InvoiceJobDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"JobStatusId", n => { JobStatusId = n.GetIntValue(); } },
                {"NoInvoice", n => { NoInvoice = n.GetBoolValue(); } },
                {"OrderDetails", n => { OrderDetails = n.GetCollectionOfObjectValues<InvoiceDetailDto>(InvoiceDetailDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"OrderStatus", n => { OrderStatus = n.GetEnumValue<InvoiceOrderStatusEnum>(); } },
                {"Participants", n => { Participants = n.GetCollectionOfObjectValues<InvoiceUserDto>(InvoiceUserDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"Primary", n => { Primary = n.GetObjectValue<InvoiceJobDto>(InvoiceJobDto.CreateFromDiscriminatorValue); } },
                {"Samtech", n => { Samtech = n.GetObjectValue<SamtechDto>(SamtechDto.CreateFromDiscriminatorValue); } },
                {"Stores", n => { Stores = n.GetCollectionOfObjectValues<InvoiceStoreDto>(InvoiceStoreDto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"TimeZone", n => { TimeZone = n.GetObjectValue<TimeSpanObject>(TimeSpanObject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("DefaultEmploymentId", DefaultEmploymentId);
            writer.WriteStringValue("DefaultStoreId", DefaultStoreId);
            writer.WriteCollectionOfObjectValues<InvoiceEmploymentDto>("Employees", Employees);
            writer.WriteCollectionOfObjectValues<InvoiceJobDto>("Jobs", Jobs);
            writer.WriteIntValue("JobStatusId", JobStatusId);
            writer.WriteBoolValue("NoInvoice", NoInvoice);
            writer.WriteCollectionOfObjectValues<InvoiceDetailDto>("OrderDetails", OrderDetails);
            writer.WriteEnumValue<InvoiceOrderStatusEnum>("OrderStatus", OrderStatus);
            writer.WriteCollectionOfObjectValues<InvoiceUserDto>("Participants", Participants);
            writer.WriteObjectValue<InvoiceJobDto>("Primary", Primary);
            writer.WriteObjectValue<SamtechDto>("Samtech", Samtech);
            writer.WriteCollectionOfObjectValues<InvoiceStoreDto>("Stores", Stores);
            writer.WriteObjectValue<TimeSpanObject>("TimeZone", TimeZone);
        }
    }
}

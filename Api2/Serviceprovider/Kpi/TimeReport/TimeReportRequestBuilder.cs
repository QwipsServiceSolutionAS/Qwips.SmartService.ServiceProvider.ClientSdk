// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Kpi.TimeReport {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\Kpi\TimeReport
    /// </summary>
    public class TimeReportRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new TimeReportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeReportRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Kpi/TimeReport{?employeeId*,dateFrom*,dateTo*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TimeReportRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TimeReportRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Kpi/TimeReport{?employeeId*,dateFrom*,dateTo*}", rawUrl) {
        }
        /// <summary>
        /// Returns a list of completed jobs within the filtered query
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<TimeReportItemDto>?> GetAsync(Action<TimeReportRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<TimeReportItemDto>> GetAsync(Action<TimeReportRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<TimeReportItemDto>(requestInfo, TimeReportItemDto.CreateFromDiscriminatorValue, default, cancellationToken);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns a list of completed jobs within the filtered query
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<TimeReportRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<TimeReportRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json;odata.metadata=minimal;odata.streaming=true");
            if (requestConfiguration != null) {
                var requestConfig = new TimeReportRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public TimeReportRequestBuilder WithUrl(string rawUrl) {
            return new TimeReportRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of completed jobs within the filtered query
        /// </summary>
        public class TimeReportRequestBuilderGetQueryParameters {
            public DateTimeOffset? DateFrom { get; set; }
            public DateTimeOffset? DateTo { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? EmployeeId { get; set; }
#nullable restore
#else
            public string EmployeeId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class TimeReportRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public TimeReportRequestBuilderGetQueryParameters QueryParameters { get; set; } = new TimeReportRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new TimeReportRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public TimeReportRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

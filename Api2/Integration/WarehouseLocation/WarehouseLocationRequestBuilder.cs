// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.WarehouseLocation.Item;
using Qwips.SmartService.Integration.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Api2.Integration.WarehouseLocation {
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\WarehouseLocation
    /// </summary>
    public class WarehouseLocationRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.SmartService.Integration.ClientSdk.api2.Integration.WarehouseLocation.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WarehouseLocationItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("id", position);
            return new WarehouseLocationItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new WarehouseLocationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WarehouseLocationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/WarehouseLocation{?WarehouseId*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WarehouseLocationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WarehouseLocationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/WarehouseLocation{?WarehouseId*}", rawUrl) {
        }
        /// <summary>
        /// Get warehouse location list. Has optional warehouse filter parameter.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<WarehouseLocationDto>?> GetAsync(Action<WarehouseLocationRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<WarehouseLocationDto>> GetAsync(Action<WarehouseLocationRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<WarehouseLocationDto>(requestInfo, WarehouseLocationDto.CreateFromDiscriminatorValue, default, cancellationToken);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Create or update a warehouse location.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WarehouseLocationDto?> PutAsync(WarehouseLocationDto body, Action<WarehouseLocationRequestBuilderPutRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WarehouseLocationDto> PutAsync(WarehouseLocationDto body, Action<WarehouseLocationRequestBuilderPutRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<WarehouseLocationDto>(requestInfo, WarehouseLocationDto.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Get warehouse location list. Has optional warehouse filter parameter.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WarehouseLocationRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WarehouseLocationRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json;odata.metadata=minimal;odata.streaming=true");
            if (requestConfiguration != null) {
                var requestConfig = new WarehouseLocationRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Create or update a warehouse location.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(WarehouseLocationDto body, Action<WarehouseLocationRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(WarehouseLocationDto body, Action<WarehouseLocationRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json;odata.metadata=minimal;odata.streaming=true", body);
            if (requestConfiguration != null) {
                var requestConfig = new WarehouseLocationRequestBuilderPutRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public WarehouseLocationRequestBuilder WithUrl(string rawUrl) {
            return new WarehouseLocationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Get warehouse location list. Has optional warehouse filter parameter.
        /// </summary>
        public class WarehouseLocationRequestBuilderGetQueryParameters {
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? WarehouseId { get; set; }
#nullable restore
#else
            public string WarehouseId { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WarehouseLocationRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WarehouseLocationRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WarehouseLocationRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WarehouseLocationRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WarehouseLocationRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WarehouseLocationRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WarehouseLocationRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public WarehouseLocationRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

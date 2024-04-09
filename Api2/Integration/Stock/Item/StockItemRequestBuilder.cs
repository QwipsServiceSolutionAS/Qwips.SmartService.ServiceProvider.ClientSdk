// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.Integration.ClientSdk.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Stock.Item {
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Stock\{id}
    /// </summary>
    public class StockItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new StockItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StockItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Stock/{id}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new StockItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public StockItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Stock/{id}", rawUrl) {
        }
        /// <summary>
        /// Delete a stock entry.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<StockEntryGetResponseDto>?> DeleteAsync(Action<StockItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<StockEntryGetResponseDto>> DeleteAsync(Action<StockItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"422", ProblemDetails.CreateFromDiscriminatorValue},
            };
            var collectionResult = await RequestAdapter.SendCollectionAsync<StockEntryGetResponseDto>(requestInfo, StockEntryGetResponseDto.CreateFromDiscriminatorValue, errorMapping, cancellationToken);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Get single stock entry.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<StockEntryGetResponseDto?> GetAsync(Action<StockItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<StockEntryGetResponseDto> GetAsync(Action<StockItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<StockEntryGetResponseDto>(requestInfo, StockEntryGetResponseDto.CreateFromDiscriminatorValue, default, cancellationToken);
        }
        /// <summary>
        /// Delete a stock entry.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<StockItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<StockItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new StockItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Get single stock entry.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<StockItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<StockItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json;odata.metadata=minimal;odata.streaming=true");
            if (requestConfiguration != null) {
                var requestConfig = new StockItemRequestBuilderGetRequestConfiguration();
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
        public StockItemRequestBuilder WithUrl(string rawUrl) {
            return new StockItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class StockItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new StockItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public StockItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class StockItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new StockItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public StockItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.CustomerClosedJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.CustomerJobs2;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.CustomerJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.CustomerOpenJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.CustomerUpcomingJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.DeepFiltered;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.MachineClosedJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.MachineJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.MachineOpenJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.MachineUpcomingJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.MyJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.PartsJobs;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.Search;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.Unplanned;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList.Unprocessed;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\JobList
    /// </summary>
    public class JobListRequestBuilder : BaseRequestBuilder {
        /// <summary>The CustomerClosedJobs property</summary>
        public CustomerClosedJobsRequestBuilder CustomerClosedJobs { get =>
            new CustomerClosedJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomerJobs property</summary>
        public CustomerJobsRequestBuilder CustomerJobs { get =>
            new CustomerJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomerJobs2 property</summary>
        public CustomerJobs2RequestBuilder CustomerJobs2 { get =>
            new CustomerJobs2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomerOpenJobs property</summary>
        public CustomerOpenJobsRequestBuilder CustomerOpenJobs { get =>
            new CustomerOpenJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CustomerUpcomingJobs property</summary>
        public CustomerUpcomingJobsRequestBuilder CustomerUpcomingJobs { get =>
            new CustomerUpcomingJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The DeepFiltered property</summary>
        public DeepFilteredRequestBuilder DeepFiltered { get =>
            new DeepFilteredRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineClosedJobs property</summary>
        public MachineClosedJobsRequestBuilder MachineClosedJobs { get =>
            new MachineClosedJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineJobs property</summary>
        public MachineJobsRequestBuilder MachineJobs { get =>
            new MachineJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineOpenJobs property</summary>
        public MachineOpenJobsRequestBuilder MachineOpenJobs { get =>
            new MachineOpenJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineUpcomingJobs property</summary>
        public MachineUpcomingJobsRequestBuilder MachineUpcomingJobs { get =>
            new MachineUpcomingJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MyJobs property</summary>
        public MyJobsRequestBuilder MyJobs { get =>
            new MyJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The PartsJobs property</summary>
        public PartsJobsRequestBuilder PartsJobs { get =>
            new PartsJobsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Unplanned property</summary>
        public UnplannedRequestBuilder Unplanned { get =>
            new UnplannedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Unprocessed property</summary>
        public UnprocessedRequestBuilder Unprocessed { get =>
            new UnprocessedRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new JobListRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobListRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/JobList{?jobStatusId*,jobSubStatusId*,search*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new JobListRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobListRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/JobList{?jobStatusId*,jobSubStatusId*,search*}", rawUrl) {
        }
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> GetAsync(Action<JobListRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> GetAsync(Action<JobListRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, default, cancellationToken);
        }
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<JobListRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<JobListRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new JobListRequestBuilderGetRequestConfiguration();
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
        public JobListRequestBuilder WithUrl(string rawUrl) {
            return new JobListRequestBuilder(rawUrl, RequestAdapter);
        }
        public class JobListRequestBuilderGetQueryParameters {
            public int? JobStatusId { get; set; }
            public int? JobSubStatusId { get; set; }
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            public string? Search { get; set; }
#nullable restore
#else
            public string Search { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class JobListRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public JobListRequestBuilderGetQueryParameters QueryParameters { get; set; } = new JobListRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new JobListRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public JobListRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}

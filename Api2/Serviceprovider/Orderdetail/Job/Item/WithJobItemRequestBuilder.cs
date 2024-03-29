// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Orderdetail.Job.Item.Change;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Orderdetail.Job.Item {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\Orderdetail\job\{jobId}
    /// </summary>
    public class WithJobItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The change property</summary>
        public ChangeRequestBuilder Change { get =>
            new ChangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithJobItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJobItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Orderdetail/job/{jobId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithJobItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithJobItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Orderdetail/job/{jobId}", rawUrl) {
        }
    }
}

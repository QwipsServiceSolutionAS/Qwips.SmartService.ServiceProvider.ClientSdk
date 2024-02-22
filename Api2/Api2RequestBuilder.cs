// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2 {
    /// <summary>
    /// Builds and executes requests for operations under \api2
    /// </summary>
    public class Api2RequestBuilder : BaseRequestBuilder {
        /// <summary>The ServiceProvider property</summary>
        public ServiceproviderRequestBuilder ServiceProvider { get =>
            new ServiceproviderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new Api2RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Api2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Api2RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Api2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2", rawUrl) {
        }
    }
}
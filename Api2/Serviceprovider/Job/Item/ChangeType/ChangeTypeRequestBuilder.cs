// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Job.Item.ChangeType.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Job.Item.ChangeType {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\Job\{jobId}\ChangeType
    /// </summary>
    public class ChangeTypeRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.SmartService.ServiceProvider.ClientSdk.api2.ServiceProvider.Job.item.ChangeType.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithJobTypeItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("jobTypeId", position);
            return new WithJobTypeItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Qwips.SmartService.ServiceProvider.ClientSdk.api2.ServiceProvider.Job.item.ChangeType.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithJobTypeItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("jobTypeId", position);
            return new WithJobTypeItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ChangeTypeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangeTypeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Job/{jobId}/ChangeType", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ChangeTypeRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ChangeTypeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Job/{jobId}/ChangeType", rawUrl) {
        }
    }
}

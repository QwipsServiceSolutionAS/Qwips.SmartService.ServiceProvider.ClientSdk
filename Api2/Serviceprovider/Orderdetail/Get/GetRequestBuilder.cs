// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Orderdetail.Get.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Orderdetail.Get {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\Orderdetail\get
    /// </summary>
    public class GetRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.SmartService.ServiceProvider.ClientSdk.api2.ServiceProvider.Orderdetail.get.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithDetailItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("detailId", position);
            return new WithDetailItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new GetRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Orderdetail/get", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GetRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Orderdetail/get", rawUrl) {
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Parts.CustomerPrice.Item;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Parts.CustomerPrice {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\Parts\customer-price
    /// </summary>
    public class CustomerPriceRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the Qwips.SmartService.ServiceProvider.ClientSdk.api2.ServiceProvider.Parts.customerPrice.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithCustomerItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("customerId", position);
            return new WithCustomerItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CustomerPriceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomerPriceRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Parts/customer-price", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CustomerPriceRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CustomerPriceRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Parts/customer-price", rawUrl) {
        }
    }
}

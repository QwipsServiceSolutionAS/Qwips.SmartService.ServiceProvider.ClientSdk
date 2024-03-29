// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.ChangeModelInfo;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.ChangeOwner;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.Customer;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.Filtered;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.Item;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.Search;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.Searchall;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine.Update;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\Machine
    /// </summary>
    public class MachineRequestBuilder : BaseRequestBuilder {
        /// <summary>The ChangeModelInfo property</summary>
        public ChangeModelInfoRequestBuilder ChangeModelInfo { get =>
            new ChangeModelInfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ChangeOwner property</summary>
        public ChangeOwnerRequestBuilder ChangeOwner { get =>
            new ChangeOwnerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Customer property</summary>
        public CustomerRequestBuilder Customer { get =>
            new CustomerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The filtered property</summary>
        public FilteredRequestBuilder Filtered { get =>
            new FilteredRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Machine property</summary>
        public MachineRequestBuilder Machine { get =>
            new MachineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The searchall property</summary>
        public SearchallRequestBuilder Searchall { get =>
            new SearchallRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Update property</summary>
        public UpdateRequestBuilder Update { get =>
            new UpdateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.SmartService.ServiceProvider.ClientSdk.api2.ServiceProvider.Machine.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithMachineItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("machineId", position);
            return new WithMachineItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new MachineRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Machine", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MachineRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Machine", rawUrl) {
        }
    }
}

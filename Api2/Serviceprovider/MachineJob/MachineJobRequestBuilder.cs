// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineJob.Add;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineJob.Change;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineJob.Get;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineJob.Remove;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineJob.Transfer;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineJob {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\MachineJob
    /// </summary>
    public class MachineJobRequestBuilder : BaseRequestBuilder {
        /// <summary>The add property</summary>
        public AddRequestBuilder Add { get =>
            new AddRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The change property</summary>
        public ChangeRequestBuilder Change { get =>
            new ChangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPath property</summary>
        public GetRequestBuilder GetPath { get =>
            new GetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The remove property</summary>
        public RemoveRequestBuilder Remove { get =>
            new RemoveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The transfer property</summary>
        public TransferRequestBuilder Transfer { get =>
            new TransferRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MachineJobRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineJobRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/MachineJob", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MachineJobRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineJobRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/MachineJob", rawUrl) {
        }
    }
}
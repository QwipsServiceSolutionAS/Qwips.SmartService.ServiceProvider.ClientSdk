// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Job.AddPart;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Job.InvoiceComment;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Job.Item;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Job.ServiceManagerComment;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Job.Status;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Job {
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration\Job
    /// </summary>
    public class JobRequestBuilder : BaseRequestBuilder {
        /// <summary>The addPart property</summary>
        public AddPartRequestBuilder AddPart { get =>
            new AddPartRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The invoiceComment property</summary>
        public InvoiceCommentRequestBuilder InvoiceComment { get =>
            new InvoiceCommentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The serviceManagerComment property</summary>
        public ServiceManagerCommentRequestBuilder ServiceManagerComment { get =>
            new ServiceManagerCommentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The status property</summary>
        public StatusRequestBuilder Status { get =>
            new StatusRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.SmartService.Integration.ClientSdk.api2.Integration.Job.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithOrderNoItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("orderNo", position);
            return new WithOrderNoItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new JobRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new JobRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JobRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration/Job", rawUrl) {
        }
    }
}

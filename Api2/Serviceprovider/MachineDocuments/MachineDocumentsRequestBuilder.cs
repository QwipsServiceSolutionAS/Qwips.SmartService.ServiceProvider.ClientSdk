// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineDocuments.Item;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineDocuments.Machine;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineDocuments {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\MachineDocuments
    /// </summary>
    public class MachineDocumentsRequestBuilder : BaseRequestBuilder {
        /// <summary>The machine property</summary>
        public MachineRequestBuilder Machine { get =>
            new MachineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the Qwips.SmartService.ServiceProvider.ClientSdk.api2.ServiceProvider.MachineDocuments.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithDocumentItemRequestBuilder this[int position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("documentId", position);
            return new WithDocumentItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the Qwips.SmartService.ServiceProvider.ClientSdk.api2.ServiceProvider.MachineDocuments.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithDocumentItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("documentId", position);
            return new WithDocumentItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new MachineDocumentsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineDocumentsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/MachineDocuments", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MachineDocumentsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MachineDocumentsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/MachineDocuments", rawUrl) {
        }
    }
}

// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Article;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.AssetType;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Customer;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Job;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Machine;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.MachineModel;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.MachineType;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Order;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Stock;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Supplier;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.Warehouse;
using Qwips.SmartService.Integration.ClientSdk.Api2.Integration.WarehouseLocation;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.Integration.ClientSdk.Api2.Integration {
    /// <summary>
    /// Builds and executes requests for operations under \api2\Integration
    /// </summary>
    public class IntegrationRequestBuilder : BaseRequestBuilder {
        /// <summary>The Article property</summary>
        public ArticleRequestBuilder Article { get =>
            new ArticleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The AssetType property</summary>
        public AssetTypeRequestBuilder AssetType { get =>
            new AssetTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Customer property</summary>
        public CustomerRequestBuilder Customer { get =>
            new CustomerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Job property</summary>
        public JobRequestBuilder Job { get =>
            new JobRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Machine property</summary>
        public MachineRequestBuilder Machine { get =>
            new MachineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineModel property</summary>
        public MachineModelRequestBuilder MachineModel { get =>
            new MachineModelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineType property</summary>
        public MachineTypeRequestBuilder MachineType { get =>
            new MachineTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Order property</summary>
        public OrderRequestBuilder Order { get =>
            new OrderRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Stock property</summary>
        public StockRequestBuilder Stock { get =>
            new StockRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Supplier property</summary>
        public SupplierRequestBuilder Supplier { get =>
            new SupplierRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Warehouse property</summary>
        public WarehouseRequestBuilder Warehouse { get =>
            new WarehouseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WarehouseLocation property</summary>
        public WarehouseLocationRequestBuilder WarehouseLocation { get =>
            new WarehouseLocationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new IntegrationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IntegrationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new IntegrationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IntegrationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/Integration", rawUrl) {
        }
    }
}

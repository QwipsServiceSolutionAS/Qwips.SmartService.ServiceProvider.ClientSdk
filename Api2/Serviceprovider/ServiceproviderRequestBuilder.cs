// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Article;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.AssetType;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.CheckList;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Customer;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Departments;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Import;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Inventory;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Invoice;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Job;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobCategory;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobDocuments;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobHistory;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobList;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobPriority;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.JobType;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Kpi;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Lead;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.LeadType;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Log;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Logg;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Machine;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineDocuments;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineJob;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineModel;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.MachineType;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Orderdetail;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Parts;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.PreventiveMaintenance;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.RepairPlace;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Scheduler;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.ServiceAgreement;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Settings;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Statistics;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Store;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Supplier;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.SupplierFailureCode;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Time;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Userinfo;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.WarrantyType;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider {
    /// <summary>
    /// Builds and executes requests for operations under \api2\serviceprovider
    /// </summary>
    public class ServiceproviderRequestBuilder : BaseRequestBuilder {
        /// <summary>The Appointment property</summary>
        public AppointmentRequestBuilder Appointment { get =>
            new AppointmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Article property</summary>
        public ArticleRequestBuilder Article { get =>
            new ArticleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The AssetType property</summary>
        public AssetTypeRequestBuilder AssetType { get =>
            new AssetTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The CheckList property</summary>
        public CheckListRequestBuilder CheckList { get =>
            new CheckListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Customer property</summary>
        public CustomerRequestBuilder Customer { get =>
            new CustomerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Departments property</summary>
        public DepartmentsRequestBuilder Departments { get =>
            new DepartmentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Import property</summary>
        public ImportRequestBuilder Import { get =>
            new ImportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Inventory property</summary>
        public InventoryRequestBuilder Inventory { get =>
            new InventoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Invoice property</summary>
        public InvoiceRequestBuilder Invoice { get =>
            new InvoiceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Job property</summary>
        public JobRequestBuilder Job { get =>
            new JobRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The JobCategory property</summary>
        public JobCategoryRequestBuilder JobCategory { get =>
            new JobCategoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The JobDocuments property</summary>
        public JobDocumentsRequestBuilder JobDocuments { get =>
            new JobDocumentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The JobHistory property</summary>
        public JobHistoryRequestBuilder JobHistory { get =>
            new JobHistoryRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The JobList property</summary>
        public JobListRequestBuilder JobList { get =>
            new JobListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The JobPriority property</summary>
        public JobPriorityRequestBuilder JobPriority { get =>
            new JobPriorityRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The JobType property</summary>
        public JobTypeRequestBuilder JobType { get =>
            new JobTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Kpi property</summary>
        public KpiRequestBuilder Kpi { get =>
            new KpiRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Lead property</summary>
        public LeadRequestBuilder Lead { get =>
            new LeadRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The LeadType property</summary>
        public LeadTypeRequestBuilder LeadType { get =>
            new LeadTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Log property</summary>
        public LogRequestBuilder Log { get =>
            new LogRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Logg property</summary>
        public LoggRequestBuilder Logg { get =>
            new LoggRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Machine property</summary>
        public MachineRequestBuilder Machine { get =>
            new MachineRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineDocuments property</summary>
        public MachineDocumentsRequestBuilder MachineDocuments { get =>
            new MachineDocumentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineJob property</summary>
        public MachineJobRequestBuilder MachineJob { get =>
            new MachineJobRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineModel property</summary>
        public MachineModelRequestBuilder MachineModel { get =>
            new MachineModelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The MachineType property</summary>
        public MachineTypeRequestBuilder MachineType { get =>
            new MachineTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Orderdetail property</summary>
        public OrderdetailRequestBuilder Orderdetail { get =>
            new OrderdetailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Parts property</summary>
        public PartsRequestBuilder Parts { get =>
            new PartsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The PreventiveMaintenance property</summary>
        public PreventiveMaintenanceRequestBuilder PreventiveMaintenance { get =>
            new PreventiveMaintenanceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The RepairPlace property</summary>
        public RepairPlaceRequestBuilder RepairPlace { get =>
            new RepairPlaceRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Scheduler property</summary>
        public SchedulerRequestBuilder Scheduler { get =>
            new SchedulerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The ServiceAgreement property</summary>
        public ServiceAgreementRequestBuilder ServiceAgreement { get =>
            new ServiceAgreementRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Settings property</summary>
        public SettingsRequestBuilder Settings { get =>
            new SettingsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Statistics property</summary>
        public StatisticsRequestBuilder Statistics { get =>
            new StatisticsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Store property</summary>
        public StoreRequestBuilder Store { get =>
            new StoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Supplier property</summary>
        public SupplierRequestBuilder Supplier { get =>
            new SupplierRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The SupplierFailureCode property</summary>
        public SupplierFailureCodeRequestBuilder SupplierFailureCode { get =>
            new SupplierFailureCodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The Time property</summary>
        public TimeRequestBuilder Time { get =>
            new TimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The userinfo property</summary>
        public UserinfoRequestBuilder Userinfo { get =>
            new UserinfoRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The WarrantyType property</summary>
        public WarrantyTypeRequestBuilder WarrantyType { get =>
            new WarrantyTypeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ServiceproviderRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServiceproviderRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/serviceprovider", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ServiceproviderRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ServiceproviderRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/serviceprovider", rawUrl) {
        }
    }
}

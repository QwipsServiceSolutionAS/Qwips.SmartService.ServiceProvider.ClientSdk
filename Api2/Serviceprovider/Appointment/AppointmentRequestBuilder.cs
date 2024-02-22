// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Available;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Bookable;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Change;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Create;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.DateRange;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Delete;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Get;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.GetJobsForAppointment;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Job;
using Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment.Recreate;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Qwips.SmartService.ServiceProvider.ClientSdk.Api2.Serviceprovider.Appointment {
    /// <summary>
    /// Builds and executes requests for operations under \api2\ServiceProvider\Appointment
    /// </summary>
    public class AppointmentRequestBuilder : BaseRequestBuilder {
        /// <summary>The available property</summary>
        public AvailableRequestBuilder Available { get =>
            new AvailableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The bookable property</summary>
        public BookableRequestBuilder Bookable { get =>
            new BookableRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The change property</summary>
        public ChangeRequestBuilder Change { get =>
            new ChangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The create property</summary>
        public CreateRequestBuilder Create { get =>
            new CreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The DateRange property</summary>
        public DateRangeRequestBuilder DateRange { get =>
            new DateRangeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deletePath property</summary>
        public DeleteRequestBuilder DeletePath { get =>
            new DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetJobsForAppointment property</summary>
        public GetJobsForAppointmentRequestBuilder GetJobsForAppointment { get =>
            new GetJobsForAppointmentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The getPath property</summary>
        public GetRequestBuilder GetPath { get =>
            new GetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The job property</summary>
        public JobRequestBuilder Job { get =>
            new JobRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The recreate property</summary>
        public RecreateRequestBuilder Recreate { get =>
            new RecreateRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AppointmentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppointmentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Appointment", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AppointmentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AppointmentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/api2/ServiceProvider/Appointment", rawUrl) {
        }
    }
}
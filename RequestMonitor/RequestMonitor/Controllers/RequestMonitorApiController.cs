using RequestMonitor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RequestMonitor.Controllers
{

    public class RequestMonitorApiController : ApiController
    {

        // A static list to store the incoming requests
        public static List<RequestLog> requestLogs = new List<RequestLog>();

        // Change GetRequestInfo() to static
        [HttpGet]
        [Route("api/requests")]
        public IHttpActionResult GetRequestInfo()
        {
            // Create a new RequestLog object to store request details
            var requestLog = new RequestLog
            {
                HttpMethod = "GET",  // HTTP method of the request
                Url = Request.RequestUri.ToString(),  // URL of the incoming request
                Timestamp = DateTime.Now  // Timestamp when the request was received
            };

            // Add the request log to the list
            requestLogs.Add(requestLog);

            // Return a message confirming the request was logged
            return Ok("GET request logged!");
        }

        // This is a helper method to retrieve all the logged requests
        [HttpGet]
        [Route("api/req")]
        public IHttpActionResult GetAllRequests()
        {
            return Ok(requestLogs);  // Returns the entire list of logged requests
        }
    }


}

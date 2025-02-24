using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RequestMonitor.Models
{
    public class RequestLog
    {
        public string HttpMethod { get; set; }
        public string Url { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
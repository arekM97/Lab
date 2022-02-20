using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace labki.Services
{
    public interface IMetricsCollector
    {
        void Collect(string httpMethod, string requestUrl, int responseCode);

        IEnumerable<EndpointStats> GetEndpointStats();
    }
}

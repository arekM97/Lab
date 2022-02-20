using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Services;
using Microsoft.AspNetCore.Http;

namespace labki.Middleware
{
    public class CollectMetricsMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IMetricsCollector _collector;
        public CollectMetricsMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context, IMetricsCollector collector)
        {
            await _next(context);
            collector.Collect(context.Request.Method, context.Request.Path, context.Response.StatusCode);
        }
    }
}

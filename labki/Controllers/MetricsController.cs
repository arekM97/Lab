using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using labki.Services;
using Microsoft.AspNetCore.Mvc;

namespace labki.Controllers
{
    public class MetricsController : Controller
    {
        private readonly IMetricsCollector _collector;

        public MetricsController(IMetricsCollector collector)
        {
            _collector = collector;
        }

        public async Task<IActionResult> Index()
        {
            var stats = _collector.GetEndpointStats();
            return View(stats);
        }
    }
}

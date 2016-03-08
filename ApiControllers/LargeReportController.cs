using Microsoft.AspNet.Mvc;
using Visma.ReportingPoc.Services;
using Visma.ReportingPoc.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Visma.ReportingPoc.ApiControllers
{
    [Route("api/[controller]")]
    public class LargeReportController : Controller
    {
        private readonly ILargeReportService _largeReportService;

        public LargeReportController(ILargeReportService largeReportService)
        {
            _largeReportService = largeReportService;
        }

        // GET: api/values
        [HttpGet]
        public LargeReportViewModel Get()
        {
            return _largeReportService.GetLargeReport();
        }
    }
}

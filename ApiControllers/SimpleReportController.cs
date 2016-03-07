using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Visma.ReportingPoc.Contracts;
using Visma.ReportingPoc.Services;
using Visma.ReportingPoc.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Visma.ReportingPoc.ApiControllers
{
    [Route("api/[controller]")]
    public class SimpleReportController : Controller
    {
        private readonly ISimpleReportService _simpleReportService;

        public SimpleReportController(ISimpleReportService simpleReportService)
        {
            _simpleReportService = simpleReportService;
        }

        // GET: api/values
        [HttpGet]
        public SimpleReportViewModel Get()
        {
            return _simpleReportService.GetSimpleReport(new SimpleReportFilter());
        }
    }
}

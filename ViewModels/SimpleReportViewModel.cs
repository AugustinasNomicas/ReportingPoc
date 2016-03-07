using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Visma.ReportingPoc.ViewModels
{
    public class SimpleReportViewModel
    {
        public string ReportName { get; set; }
        public string CountyName { get; set; }
        public DateTime ReportDate { get; set; }
        public string SubectGroupName { get; set; }
        public string GradeResonsible { get; set; }
        public List<StudentWithAddressViewModel> Students { get; set; }
    }
}

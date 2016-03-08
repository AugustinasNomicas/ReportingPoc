using System;
using System.Collections.Generic;

namespace Visma.ReportingPoc.ViewModels
{
    public class LargeReportViewModel
    {
        public string ReportName { get; set; }
        public string CountyName { get; set; }
        public DateTime ReportDate { get; set; }
        public List<StudentWithDiplomaViewModel> Students { get; set; } 
    }
}

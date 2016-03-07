using System;
using GenFu;
using Visma.ReportingPoc.Contracts;
using Visma.ReportingPoc.ViewModels;

namespace Visma.ReportingPoc.Services
{
    public interface ISimpleReportService
    {
        SimpleReportViewModel GetSimpleReport(SimpleReportFilter filter);
    }

    public class SimpleReportService : ISimpleReportService
    {
        private readonly Random _rnd = new Random(DateTime.Now.Millisecond);

        public SimpleReportService()
        {
            GenFu.GenFu.Configure<StudentWithAddressViewModel>()
                .Fill(p => p.NationalId, () => _rnd.Next(10001566, 90001566).ToString());
        }

        public SimpleReportViewModel GetSimpleReport(SimpleReportFilter filter)
        {
            var students = A.ListOf<StudentWithAddressViewModel>();

            return new SimpleReportViewModel() {
                ReportName = "Subject Group, Students with address",
                CountyName = "Oslo County",
                GradeResonsible = "Jonhs R.",
                ReportDate = DateTime.Now,
                SubectGroupName = "Subject Group 1A",
                Students = students
            };
                
        }
    }
}

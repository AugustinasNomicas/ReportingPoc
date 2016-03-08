using System;
using System.Collections.Generic;
using GenFu;
using Visma.ReportingPoc.ViewModels;

namespace Visma.ReportingPoc.Services
{
    public interface ILargeReportService
    {
        LargeReportViewModel GetLargeReport();
    }

    public class LargeReportService : ILargeReportService
    {
        private readonly Random _rnd = new Random(DateTime.Now.Millisecond);

        private readonly List<string> _schoolNames = new List<string>
        {
            "Porsgrunn videregående skole",
            "Rjukan videregående skole",
            "Rosenvilde videregående skole",
            "Rud videregående skole",
            "Skedsmo videregående skole",
            "Skien videregående skole",
            "Skogmo videregående skole"
        };

        private readonly List<string> _programAreas = new List<string>
        {
            "ProgramArea AA1",
            "ProgramArea AB1",
            "ProgramArea BB1",
            "ProgramArea AA2",
            "ProgramArea AA3",
            "ProgramArea AB2",
            "ProgramArea BB2",
            "ProgramArea AA4",
        };

        public LargeReportService()
        {
            GenFu.GenFu.Configure<StudentWithDiplomaViewModel>()
                .Fill(p => p.SchoolName).WithRandom(_schoolNames)
                .Fill(p => p.ProgramArea).WithRandom(_programAreas)
                .Fill(p => p.CountOfDiplomas, _rnd.Next(1, 8))
                .Fill(p => p.LastDiplomaDate, DateTime.Now.AddDays(_rnd.Next(1, 365) * -1));
        }

        public LargeReportViewModel GetLargeReport()
        {
            var students = A.ListOf<StudentWithDiplomaViewModel>(30000);
            return new LargeReportViewModel
            {
                ReportName = "Students with diploma",
                CountyName = "Oslo County",
                ReportDate = DateTime.Now,
                Students = students
            };
        }
    }
}

using System;

namespace Visma.ReportingPoc.ViewModels
{
    public class StudentWithDiplomaViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SchoolName { get; set; }
        public string ProgramArea { get; set; }
        public DateTime LastDiplomaDate { get; set; }
        public int CountOfDiplomas { get; set; }
    }
}

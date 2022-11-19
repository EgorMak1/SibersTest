namespace SibersTestTask.Models
{
    public class Project
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int IdProject { get; set; }
        public int IdLeadProject { get; set; }
        public int Priority { get; set; }
        public string NameProject { get; set; }
        public string NameContractorCompany { get; set; }
        public string NameClientCompany { get; set; }
        public DateTime StartDate { get; set; }




        public ICollection<EmployeesInProject> EmployeesInProjects { get; set; }
        public Leader Leader { get; set; }

    }
}

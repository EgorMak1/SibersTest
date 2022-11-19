using Microsoft.EntityFrameworkCore;

namespace SibersTestTask.Models
{
    [PrimaryKey(nameof(IdEmployee), nameof(IdProject))]
    public class EmployeesInProject
    {
        
        public int IdEmployee { get; set; }
        public int IdProject { get; set; }



        public Project Project { get; set; }
        public Employee Employee { get; set; }
    }
}
